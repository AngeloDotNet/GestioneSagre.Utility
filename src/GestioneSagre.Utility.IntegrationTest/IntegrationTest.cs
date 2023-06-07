namespace GestioneSagre.Utility.IntegrationTest;

public class IntegrationTest
{
    [Fact]
    public async Task GetEndpointCheckApiShouldResponseStatusOKAsync()
    {
        using var app = new WebApplicationFactory<Startup>()
            .WithWebHostBuilder(builder =>
            {
                builder.ConfigureServices(services =>
                {
                    var descriptor = services.SingleOrDefault(d => d.ServiceType == typeof(DbContextOptions<UtilityDbContext>));

                    if (descriptor != null)
                    {
                        services.Remove(descriptor);
                    }

                    services.AddDbContext<UtilityDbContext>(options => options.UseInMemoryDatabase("Utility-InMemory-Test"));
                });
            });

        var httpClient = app.CreateClient();
        var response = await httpClient.GetAsync("/api/utility/checkapi");

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
    }

    [Fact]
    public async Task GetScontrinoPagatoShouldResponseListNotNullAsync()
    {
        using var app = new WebApplicationFactory<Startup>()
            .WithWebHostBuilder(builder =>
            {
                builder.ConfigureServices(services =>
                {
                    var descriptor = services.SingleOrDefault(d => d.ServiceType == typeof(DbContextOptions<UtilityDbContext>));

                    if (descriptor != null)
                    {
                        services.Remove(descriptor);
                    }

                    services.AddDbContext<UtilityDbContext>(options => options.UseInMemoryDatabase("Utility-InMemory-Test"));
                });
            });

        var httpClient = app.CreateClient();

        var response = await httpClient.GetAsync("/api/utility/scontrinopagato");
        var items = await response.Content.ReadFromJsonAsync<List<ScontrinoPagato>>();

        using var scope = app.Services.CreateScope();
        using var context = scope.ServiceProvider.GetRequiredService<UtilityDbContext>();

        Assert.NotNull(response);
        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        Assert.NotNull(items);
        Assert.NotEmpty(items);
        Assert.Equal(2, items.Count);
    }

    [Fact]
    public async Task GetScontrinoStatoShouldResponseListNotNullAsync()
    {
        using var app = new WebApplicationFactory<Startup>()
            .WithWebHostBuilder(builder =>
            {
                builder.ConfigureServices(services =>
                {
                    var descriptor = services.SingleOrDefault(d => d.ServiceType == typeof(DbContextOptions<UtilityDbContext>));

                    if (descriptor != null)
                    {
                        services.Remove(descriptor);
                    }

                    services.AddDbContext<UtilityDbContext>(options => options.UseInMemoryDatabase("Utility-InMemory-Test"));
                });
            });

        var httpClient = app.CreateClient();

        var response = await httpClient.GetAsync("/api/utility/scontrinostato");
        var items = await response.Content.ReadFromJsonAsync<List<ScontrinoStato>>();

        using var scope = app.Services.CreateScope();
        using var context = scope.ServiceProvider.GetRequiredService<UtilityDbContext>();

        Assert.NotNull(response);
        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        Assert.NotNull(items);
        Assert.NotEmpty(items);
        Assert.Equal(5, items.Count);
    }

    [Fact]
    public async Task GetTipoClienteShouldResponseListNotNullAsync()
    {
        using var app = new WebApplicationFactory<Startup>()
            .WithWebHostBuilder(builder =>
            {
                builder.ConfigureServices(services =>
                {
                    var descriptor = services.SingleOrDefault(d => d.ServiceType == typeof(DbContextOptions<UtilityDbContext>));

                    if (descriptor != null)
                    {
                        services.Remove(descriptor);
                    }

                    services.AddDbContext<UtilityDbContext>(options => options.UseInMemoryDatabase("Utility-InMemory-Test"));
                });
            });

        var httpClient = app.CreateClient();

        var response = await httpClient.GetAsync("/api/utility/tipocliente");
        var items = await response.Content.ReadFromJsonAsync<List<TipoCliente>>();

        using var scope = app.Services.CreateScope();
        using var context = scope.ServiceProvider.GetRequiredService<UtilityDbContext>();

        Assert.NotNull(response);
        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        Assert.NotNull(items);
        Assert.NotEmpty(items);
        Assert.Equal(2, items.Count);
    }

    [Fact]
    public async Task GetTipoScontrinoShouldResponseListNotNullAsync()
    {
        using var app = new WebApplicationFactory<Startup>()
            .WithWebHostBuilder(builder =>
            {
                builder.ConfigureServices(services =>
                {
                    var descriptor = services.SingleOrDefault(d => d.ServiceType == typeof(DbContextOptions<UtilityDbContext>));

                    if (descriptor != null)
                    {
                        services.Remove(descriptor);
                    }

                    services.AddDbContext<UtilityDbContext>(options => options.UseInMemoryDatabase("Utility-InMemory-Test"));
                });
            });

        var httpClient = app.CreateClient();

        var response = await httpClient.GetAsync("/api/utility/tiposcontrino");
        var items = await response.Content.ReadFromJsonAsync<List<TipoScontrino>>();

        using var scope = app.Services.CreateScope();
        using var context = scope.ServiceProvider.GetRequiredService<UtilityDbContext>();

        Assert.NotNull(response);
        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        Assert.NotNull(items);
        Assert.NotEmpty(items);
        Assert.Equal(2, items.Count);
    }

    [Fact]
    public async Task GetTipoPagamentoShouldResponseListNotNullAsync()
    {
        using var app = new WebApplicationFactory<Startup>()
            .WithWebHostBuilder(builder =>
            {
                builder.ConfigureServices(services =>
                {
                    var descriptor = services.SingleOrDefault(d => d.ServiceType == typeof(DbContextOptions<UtilityDbContext>));

                    if (descriptor != null)
                    {
                        services.Remove(descriptor);
                    }

                    services.AddDbContext<UtilityDbContext>(options => options.UseInMemoryDatabase("Utility-InMemory-Test"));
                });
            });

        var httpClient = app.CreateClient();

        var response = await httpClient.GetAsync("/api/utility/tipopagamento");
        var items = await response.Content.ReadFromJsonAsync<List<TipoPagamento>>();

        using var scope = app.Services.CreateScope();
        using var context = scope.ServiceProvider.GetRequiredService<UtilityDbContext>();

        Assert.NotNull(response);
        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        Assert.NotNull(items);
        Assert.NotEmpty(items);
        Assert.Equal(3, items.Count);
    }
}