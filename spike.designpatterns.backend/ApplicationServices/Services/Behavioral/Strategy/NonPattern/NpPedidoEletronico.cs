namespace ApplicationServices.Services.Behavioral.Strategy.NonPattern;

public class NpPedidoEletronico : NpPedido
{
    public override double CalculaFreteEconomico() => Math.Round(Valor * 0.025, 2);

    public override double CalculaFreteComum() => Math.Round(Valor * 0.05, 2);

    public override double CalculaFreteExpresso() => Math.Round(Valor * 0.1, 2);
}
