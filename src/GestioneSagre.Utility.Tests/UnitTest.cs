namespace GestioneSagre.Utility.Tests;

public class Tests
{
    [Test]
    public async Task TestGetTipoCliente()
    {
        // Arrange
        using var application = new WebApplicationFactory<Program>();
        var client = application.CreateClient();

        // Act
        var response = await client.GetFromJsonAsync<List<string>>("/api/Utility/GetTipoCliente");

        // Assert
        Assert.IsNotNull(response);
    }

    [Test]
    public async Task TestGetTipoScontrino()
    {
        // Arrange
        using var application = new WebApplicationFactory<Program>();
        var client = application.CreateClient();

        // Act
        var response = await client.GetFromJsonAsync<List<string>>("/api/Utility/GetTipoScontrino");

        // Assert
        Assert.IsNotNull(response);
    }

    [Test]
    public async Task TestGetTipoPagamento()
    {
        // Arrange
        using var application = new WebApplicationFactory<Program>();
        var client = application.CreateClient();

        // Act
        var response = await client.GetFromJsonAsync<List<string>>("/api/Utility/GetTipoPagamento");

        // Assert
        Assert.IsNotNull(response);
    }

    [Test]
    public async Task TestGetScontrinoPagato()
    {
        // Arrange
        using var application = new WebApplicationFactory<Program>();
        var client = application.CreateClient();

        // Act
        var response = await client.GetFromJsonAsync<List<string>>("/api/Utility/GetScontrinoPagato");

        // Assert
        Assert.IsNotNull(response);
    }

    [Test]
    public async Task TestGetScontrinoStato()
    {
        // Arrange
        using var application = new WebApplicationFactory<Program>();
        var client = application.CreateClient();

        // Act
        var response = await client.GetFromJsonAsync<List<string>>("/api/Utility/GetScontrinoStato");

        // Assert
        Assert.IsNotNull(response);
    }
}