using ApplicationServices.Services.Behavioral.Strategy.WithPattern.Frete;

namespace ApplicationServices.Services.Behavioral.Strategy.WithPattern.Pedido;

public abstract class WpPedido
{
    private double ValorPedido { get; set; }
    private IFrete TipoFrete { get; set;  }
    
    public double GetValorPedido() => Math.Round(ValorPedido, 2);
    public void SetValorPedido(double valor) => ValorPedido = valor;
    public void SetTipoFrete(IFrete frete) => TipoFrete = frete;
    public double CalcularFrete() => TipoFrete.CalculaFrete(ValorPedido);
}