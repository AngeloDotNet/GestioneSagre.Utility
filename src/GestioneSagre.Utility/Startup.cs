namespace GestioneSagre.Utility;

public class Startup
{
    private readonly string serviceName = "GestioneSagre.Utility";
    private readonly string swaggerName = "Gestione Sagre Utility";

    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers();
        services.AddCors(options =>
        {
            options.AddPolicy($"{serviceName}", policy =>
            {
                policy.AllowAnyOrigin()
                    .AllowAnyHeader()
                    .AllowAnyMethod();
            });
        });

        var dbConfig = Configuration.GetSection("ConnectionStrings");
        var startupConfig = dbConfig["TypeStartup"];
        var connectionString = string.Empty;

        if (startupConfig == "Default")
        {
            connectionString = dbConfig["Default"]
                .Replace("NOME-SERVER\\NOME-ISTANZA", string.Join(",", dbConfig["Hostname"], dbConfig["Port"]))
                .Replace("PASSWORD", dbConfig["Password"]);
        }
        else
        {
            connectionString = dbConfig["Docker"]
                .Replace("NOME-DOCKER", dbConfig["DockerHost"])
                .Replace("PASSWORD", dbConfig["Password"]);
        }

        services.AddSwaggerGenConfig($"{swaggerName}", "v1", string.Empty);
        services.AddSerilogSeqServices();

        //Creazione migration: Add-Migration InitialMigration -project GestioneSagre.Utility.DataAccessLayer
        //Esecuzione migration: Update-Database
        services.AddDbContextForSQLServer<UtilityDbContext>(connectionString, 3, string.Empty);
        services.AddDbContextServicesGenerics<UtilityDbContext>();

        services.AddTransient<IUtilityService, UtilityService>();
        services.AddHealthChecksUISQLServer<UtilityDbContext>("SQL Server", connectionString);

        services.AddRedisCacheService(Configuration);
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(GetScontrinoPagatoHandler).Assembly));

        var rabbitConfig = Configuration.GetSection("RabbitMQ");
        services.AddMassTransitService(rabbitConfig);

        services.Configure<KestrelServerOptions>(Configuration.GetSection("Kestrel"));
        services.Configure<RouteOptions>(options => options.LowercaseUrls = true);
    }

    public void Configure(WebApplication app)
    {
        IWebHostEnvironment env = app.Environment;

        app.UseCors($"{serviceName}");
        app.AddUseSwaggerUI($"{swaggerName} v1");

        app.UseRouting();
        app.AddSerilogConfigureServices();

        app.UseHealthChecksUI();
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}