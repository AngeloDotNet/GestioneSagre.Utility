using GestioneSagre.Utility.DataAccessLayer;

namespace GestioneSagre.Utility.Api.Internal;

public class Startup
{
    private readonly string serviceName = "GestioneSagre.Utility.Api.Internal";
    private readonly string swaggerName = "Gestione Sagre Utility Api Internal";

    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers();
        services.AddRegisterApiInternalConfigureServices(Configuration, serviceName, swaggerName);

        services.Configure<KestrelServerOptions>(Configuration.GetSection("Kestrel"));
        services.Configure<RouteOptions>(options => options.LowercaseUrls = true);
    }

    public void Configure(WebApplication app)
    {
        IWebHostEnvironment env = app.Environment;
        UpdateDatabase(app);

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

    private static void UpdateDatabase(IApplicationBuilder app)
    {
        using var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope();
        using var context = serviceScope.ServiceProvider.GetRequiredService<UtilityDbContext>();

        DBSeeder.Seed(context);
    }
}