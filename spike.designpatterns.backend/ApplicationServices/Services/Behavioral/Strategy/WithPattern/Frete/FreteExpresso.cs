namespace ApplicationServices.Services.Behavioral.Strategy.WithPattern.Frete;

public class FreteExpresso : FreteBase, IFrete
{
    public FreteExpresso() => Descricao = "Frete Expresso";
    public double CalculaFrete(double valorFrete) => Math.Round(valorFrete * 0.1, 2);
}