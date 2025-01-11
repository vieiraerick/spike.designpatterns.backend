namespace ApplicationServices.Services.Behavioral.Strategy.NonPattern;

public class NpPedidoMoveis : NpPedido
{
    public override double CalculaFreteEconomico() => throw new Exception("Frete econômico não disponível");

    public override double CalculaFreteComum() => Math.Round(Valor * 0.05, 2);

    public override double CalculaFreteExpresso() => throw new Exception("Frete expresso não disponível");
}