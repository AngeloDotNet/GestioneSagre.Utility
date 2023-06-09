namespace GestioneSagre.Utility.Extensions;

public static class RegisterServices
{
    public static IServiceCollection AddRegisterConfigureServices(this IServiceCollection services,
        IConfiguration configuration, string serviceName, string swaggerName)
    {
        services.AddPolicyCors(serviceName);

        var dbConfig = configuration.GetSection("ConnectionStrings");
        var startupConfig = dbConfig["TypeStartup"];
        var connectionString = string.Empty;

        if (startupConfig == "Default")
        {
            connectionString = GetConnectionString(dbConfig, "Default");
        }
        else
        {
            connectionString = GetConnectionString(dbConfig, "Docker");
        }

        services.AddSwaggerGenConfig($"{swaggerName}", "v1", string.Empty);
        services.AddSerilogSeqServices();

        services.AddDbContextNoPoolSQLServer<UtilityDbContext>(connectionString, string.Empty);
        services.AddDbContextServicesGenerics<UtilityDbContext>();

        services.AddTransient<IUtilityService, UtilityService>();
        services.AddHealthChecksUISQLServer<UtilityDbContext>("SQL Server", connectionString);

        services.AddRedisCacheService(configuration);
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(GetScontrinoPagatoHandler).Assembly));

        var rabbitConfig = configuration.GetSection("RabbitMQ");
        var rabbitServer = $"{rabbitConfig["Username"]}:{rabbitConfig["Password"]}@{rabbitConfig["Hostname"]}";

        services.AddMassTransitService(rabbitConfig, rabbitServer);

        return services;
    }

    private static string GetConnectionString(IConfigurationSection settings, string typology)
    {
        var connectionString = string.Empty;

        if (typology == "Default")
        {
            connectionString = settings["Default"]
               .Replace("NOME-SERVER\\NOME-ISTANZA", string.Join(",", settings["Hostname"], settings["Port"]))
               .Replace("PASSWORD", settings["Password"]);
        }

        if (typology == "Docker")
        {
            connectionString = settings["Docker"]
               .Replace("NOME-DOCKER", settings["DockerHost"])
               .Replace("PASSWORD", settings["Password"]);
        }

        return connectionString;
    }
}