namespace ApplicationServices.Services.Behavioral.Strategy.WithPattern.Pedido;

public class WpPedidoEletronico : WpPedido
{
    private string NomeSetor { get; set; } = "Eletrônicos";
    
    public string GetNomeSetor() => NomeSetor;
    public void SetNomeSetor(string nomeSetor) => NomeSetor = nomeSetor;
}