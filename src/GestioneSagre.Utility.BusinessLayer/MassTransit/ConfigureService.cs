namespace GestioneSagre.Utility.BusinessLayer.MassTransit;

public static class ConfigureService
{
    public static void AddMassTransitService(this IServiceCollection services, IConfigurationSection rabbitConfig)
    {
        services.AddMassTransit(x =>
        {
            x.AddConsumer<ScontrinoPagatoListConsumer>();
            x.AddConsumer<ScontrinoStatoListConsumer>();

            x.SetKebabCaseEndpointNameFormatter();
            x.UsingRabbitMq((context, cfg) =>
            {
                cfg.Host(rabbitConfig["Hostname"], rabbitConfig["VirtualHost"], h =>
                {
                    h.Username(rabbitConfig["Username"]);
                    h.Password(rabbitConfig["Password"]);
                });

                cfg.ReceiveEndpoint(rabbitConfig["NameResponse-1"], e =>
                {
                    e.Durable = Convert.ToBoolean(rabbitConfig["Durable"]);
                    e.AutoDelete = Convert.ToBoolean(rabbitConfig["AutoDelete"]);
                    e.ExchangeType = rabbitConfig["ExchangeType"];
                    e.PrefetchCount = Convert.ToInt32(rabbitConfig["PrefetchCount"]);

                    e.ConfigureConsumer<ScontrinoPagatoListConsumer>(context);
                    e.ConfigureConsumer<ScontrinoStatoListConsumer>(context);
                });
            });
        });

        services.AddMassTransit<ISecondBus>(x =>
        {
            x.AddConsumer<TipoClienteListConsumer>();
            x.AddConsumer<TipoPagamentoListConsumer>();
            x.AddConsumer<TipoScontrinoListConsumer>();

            x.SetKebabCaseEndpointNameFormatter();
            x.UsingRabbitMq((context, cfg) =>
            {
                cfg.Host(rabbitConfig["Hostname"], rabbitConfig["VirtualHost"], h =>
                {
                    h.Username(rabbitConfig["Username"]);
                    h.Password(rabbitConfig["Password"]);
                });

                cfg.ReceiveEndpoint(rabbitConfig["NameResponse-2"], e =>
                {
                    e.Durable = Convert.ToBoolean(rabbitConfig["Durable"]);
                    e.AutoDelete = Convert.ToBoolean(rabbitConfig["AutoDelete"]);
                    e.ExchangeType = rabbitConfig["ExchangeType"];
                    e.PrefetchCount = Convert.ToInt32(rabbitConfig["PrefetchCount"]);

                    e.ConfigureConsumer<TipoClienteListConsumer>(context);
                    e.ConfigureConsumer<TipoPagamentoListConsumer>(context);
                    e.ConfigureConsumer<TipoScontrinoListConsumer>(context);
                });
            });
        });
    }
}