namespace ApplicationServices.Services.Behavioral.Strategy.WithPattern.Pedido;

public class WpPedidoMoveis : WpPedido
{
    private string NomeSetor { get; set; } = "Móveis";

    public string GetNomeSetor() => NomeSetor;

    public void SetNomeSetor(string nomeSetor) => NomeSetor = nomeSetor;
}