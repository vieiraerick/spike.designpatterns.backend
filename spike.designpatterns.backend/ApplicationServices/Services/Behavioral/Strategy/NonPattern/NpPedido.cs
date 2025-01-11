namespace ApplicationServices.Services.Behavioral.Strategy.NonPattern;

public abstract class NpPedido
{
    protected double Valor { get; set; }

    public double GetValor() => Valor;
    public void SetValor(double valor) => Valor = valor;
    
    abstract public double CalculaFreteEconomico();
    abstract public double CalculaFreteComum();
    abstract public double CalculaFreteExpresso();
}
