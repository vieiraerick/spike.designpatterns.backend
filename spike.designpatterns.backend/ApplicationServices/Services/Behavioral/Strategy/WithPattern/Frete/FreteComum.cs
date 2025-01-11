namespace ApplicationServices.Services.Behavioral.Strategy.WithPattern.Frete;

public class FreteComum : FreteBase, IFrete
{
    public FreteComum() => Descricao = "Frete comum";
    
    public double CalculaFrete(double valorPedido) => Math.Round(valorPedido * 0.05);
}