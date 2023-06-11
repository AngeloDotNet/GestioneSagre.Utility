namespace GestioneSagre.Utility.UnitTest;

[Author("Angelo")]
public class UnitTest
{
    private Mock<IUtilityService> mockUtilityService;

    [SetUp]
    public void Setup()
    {
        mockUtilityService = new Mock<IUtilityService>(MockBehavior.Strict);
    }

    [TearDown]
    public void TearDown()
    {
        mockUtilityService.VerifyAll();
    }

    [Test, Description("Get list scontrino pagato should response not empty (2 items)")]
    public async Task GetListScontrinoPagatoShouldResponseNotEmptyAsync()
    {
        var list = new List<ScontrinoPagato>()
        {
            new ScontrinoPagato { Id = new Guid("5168436b-4618-4fcc-957d-ab1974e16cbe"), Value = "Pagato" },
            new ScontrinoPagato { Id = new Guid("95e5b0c1-a51a-4d29-91a7-db01c49f5f3f"), Value = "Non pagato" }
        };

        mockUtilityService.Setup(x => x.GetListScontrinoPagatoAsync()).ReturnsAsync(list);

        var result = await mockUtilityService.Object.GetListScontrinoPagatoAsync();

        Assert.That(result, Is.Not.Empty);
        Assert.That(result.Count, Is.EqualTo(2));
    }

    [Test, Description("Get list scontrino stato should reponse not empty (5 items)")]
    public async Task GetListScontrinoStatoShouldResponseNotEmptyAsync()
    {
        var list = new List<ScontrinoStato>()
        {
            new ScontrinoStato { Id = new Guid("da58ff5f-0f08-4d0b-8942-1e080fea763c"), Value = "Aperto" },
            new ScontrinoStato { Id = new Guid("19f815c8-2018-47a3-a6e9-be0bac57205a"), Value = "In elaborazione" },
            new ScontrinoStato { Id = new Guid("d5199f4a-df16-40af-8100-2c4c4f78466f"), Value = "Da incassare" },
            new ScontrinoStato { Id = new Guid("0e838069-6094-4fca-ad09-4fca2cee173e"), Value = "Chiuso" },
            new ScontrinoStato { Id = new Guid("318b6631-1c19-4e06-bd1f-bf14e86a8d24"), Value = "Annullato" }
        };

        mockUtilityService.Setup(x => x.GetListScontrinoStatoAsync()).ReturnsAsync(list);

        var result = await mockUtilityService.Object.GetListScontrinoStatoAsync();

        Assert.That(result, Is.Not.Empty);
        Assert.That(result.Count, Is.EqualTo(5));
    }

    [Test, Description("Get list tipo cliente should reponse not empty (2 items)")]
    public async Task GetListTipoClienteShouldResponseNotEmptyAsync()
    {
        var list = new List<TipoCliente>()
        {
            new TipoCliente { Id = new Guid("1c48295b-6dec-4e82-9377-787961208a48"), Value = "Cliente" },
            new TipoCliente { Id = new Guid("4e1a05a4-2655-4466-b3cc-8ba3e2dbe271"), Value = "Staff" }
        };

        mockUtilityService.Setup(x => x.GetListTipoClienteAsync()).ReturnsAsync(list);

        var result = await mockUtilityService.Object.GetListTipoClienteAsync();

        Assert.That(result, Is.Not.Empty);
        Assert.That(result.Count, Is.EqualTo(2));
    }

    [Test, Description("Get list tipo scontrino should reponse not empty (2 items)")]
    public async Task GetListTipoScontrinoShouldResponseNotEmptyAsync()
    {
        var list = new List<TipoScontrino>()
        {
            new TipoScontrino { Id = new Guid("4237bc9e-8751-4340-a31d-7babab87cc72"), Value = "Pagamento" },
            new TipoScontrino { Id = new Guid("eb036a5f-95bc-4818-ac5a-e14655604b06"), Value = "Omaggio" }
        };

        mockUtilityService.Setup(x => x.GetListTipoScontrinoAsync()).ReturnsAsync(list);

        var result = await mockUtilityService.Object.GetListTipoScontrinoAsync();

        Assert.That(result, Is.Not.Empty);
        Assert.That(result.Count, Is.EqualTo(2));
    }

    [Test, Description("Get list tipo pagamento should reponse not empty (3 items)")]
    public async Task GetListTipoPagamentoShouldResponseNotEmptyAsync()
    {
        var list = new List<TipoPagamento>()
        {
            new TipoPagamento { Id = new Guid("bbd45d77-33de-42df-ba62-573e7953153b"), Value = "Contanti" },
            new TipoPagamento { Id = new Guid("a7e910b0-67c9-4913-a279-e43674375bcf"), Value = "Carta di credito" },
            new TipoPagamento { Id = new Guid("9a3b35b1-0640-4d6d-8952-e56c5962c15c"), Value = "Carta di debito" }
        };

        mockUtilityService.Setup(x => x.GetListTipoPagamentoAsync()).ReturnsAsync(list);

        var result = await mockUtilityService.Object.GetListTipoPagamentoAsync();

        Assert.That(result, Is.Not.Empty);
        Assert.That(result.Count, Is.EqualTo(3));
    }
}