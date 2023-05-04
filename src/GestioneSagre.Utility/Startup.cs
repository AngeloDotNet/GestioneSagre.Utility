namespace GestioneSagre.Utility;

public class Startup
{
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
            options.AddPolicy("GestioneSagre.Utility", policy =>
            {
                policy.AllowAnyOrigin()
                    .AllowAnyHeader()
                    .AllowAnyMethod();
            });
        });

        var connectionString = Configuration.GetSection("ConnectionStrings").GetValue<string>("Default");
        var connStringRedis = Configuration.GetSection("ConnectionStrings").GetValue<string>("Redis");

        services.AddSwaggerGenConfig("Gestione Sagre Utility", "v1", string.Empty);

        //Creazione migration: Add-Migration InitialMigration
        //Esecuzione migration: Update-Database
        services.AddDbContextUseSQLServer<UtilityDbContext>(connectionString, 3);
        services.AddDbContextGenericsMethods<UtilityDbContext>();

        services
            .AddTransient<IUtilityService, UtilityService>()
            .AddTransient<ICacheService, CacheService>();

        services.AddStackExchangeRedisCache(options =>
        {
            options.Configuration = connStringRedis;
            options.InstanceName = "redisUtility_";
        });
    }

    public void Configure(WebApplication app)
    {
        IWebHostEnvironment env = app.Environment;

        app.UseCors("GestioneSagre.Utility");
        app.AddUseSwaggerUI("Gestione Sagre Utility v1");

        app.UseRouting();
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}