namespace ApplicationServices.Services.Behavioral.Strategy.WithPattern.Frete;

public class FreteEconomico : FreteBase, IFrete
{
    public FreteEconomico() => Descricao = "Frete Econômico";
    public double CalculaFrete(double valorFrete) => Math.Round(valorFrete * 0.025, 2);
}