using Microsoft.Extensions.Configuration;

namespace GestioneSagre.Utility.IntegrationTest;

public class IntegrationTest
{
    [Fact]
    public async Task GetScontrinoPagatoShouldResponseListNotNullAsync()
    {
        var httpClient = GenerateAppFactory()
            .CreateClient();

        var response = await httpClient.GetFromJsonAsync<List<ScontrinoPagato>>("/api/utility/scontrinopagato");

        Assert.NotNull(response);
        Assert.Equal(2, response.Count);
    }

    [Fact]
    public async Task GetScontrinoStatoShouldResponseListNotNullAsync()
    {
        var httpClient = GenerateAppFactory()
            .CreateClient();

        var response = await httpClient.GetFromJsonAsync<List<ScontrinoStato>>("/api/utility/scontrinostato");

        Assert.NotNull(response);
        Assert.Equal(5, response.Count);
    }

    [Fact]
    public async Task GetTipoClienteShouldResponseListNotNullAsync()
    {
        var httpClient = GenerateAppFactory()
            .CreateClient();

        var response = await httpClient.GetFromJsonAsync<List<TipoCliente>>("/api/utility/tipocliente");

        Assert.NotNull(response);
        Assert.NotEmpty(response);
        Assert.Equal(2, response.Count);
    }

    [Fact]
    public async Task GetTipoScontrinoShouldResponseListNotNullAsync()
    {
        var httpClient = GenerateAppFactory()
            .CreateClient();

        var response = await httpClient.GetFromJsonAsync<List<TipoScontrino>>("/api/utility/tiposcontrino");

        Assert.NotNull(response);
        Assert.Equal(2, response.Count);
    }

    [Fact]
    public async Task GetTipoPagamentoShouldResponseListNotNullAsync()
    {
        var httpClient = GenerateAppFactory()
            .CreateClient();

        var response = await httpClient.GetFromJsonAsync<List<TipoPagamento>>("/api/utility/tipopagamento");

        Assert.NotNull(response);
        Assert.Equal(3, response.Count);
    }

    private static WebApplicationFactory<Startup> GenerateAppFactory()
    {
        var config = new ConfigurationBuilder()
            .AddUserSecrets<Startup>()
            .Build();

        var database = config["ConnectionStrings:Default"];
        var application = new WebApplicationFactory<Startup>()
            .WithWebHostBuilder(builder =>
            {
                builder.ConfigureTestServices(services =>
                {
                    var options = new DbContextOptionsBuilder<UtilityDbContext>()
                    .UseSqlServer(database)
                    .Options;

                    services.AddSingleton(options);
                    services.AddSingleton<UtilityDbContext>();
                });
            });

        return application;
    }
}