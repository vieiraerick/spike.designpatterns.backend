namespace ApplicationServices.Services.Behavioral.Strategy.WithPattern.Frete;

public interface IFrete
{
    public double CalculaFrete(double valorFrete);
    public string GetDescricao();
}