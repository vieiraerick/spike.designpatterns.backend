using ApplicationServices.Services.Behavioral.Strategy.NonPattern;
using ApplicationServices.Services.Behavioral.Strategy.WithPattern.Frete;
using ApplicationServices.Services.Behavioral.Strategy.WithPattern.Pedido;
using Microsoft.AspNetCore.Mvc;

namespace Interface.Controllers.Behavioral;

[ApiController]
[Route("[controller]")]
public class StrategyController : ControllerBase
{
    public StrategyController()
    {
    }

    [HttpGet("PedidoSemPadrao/{valor:double}")]
    public IActionResult GetStrategyNoPattern(double valor)
    {
        var pedidoEletronico = new NpPedidoEletronico();
        pedidoEletronico.SetValor(valor);
        
        var pedidoMoveis = new NpPedidoMoveis();
        pedidoMoveis.SetValor(valor);

        return Ok(new
        {
            PedidoMoveis = new
            {
                //FreteEconomico = pedidoMoveis.CalculaFreteEconomico(),
                FreteComum = pedidoMoveis.CalculaFreteComum(),
                //FreteExpresso = pedidoMoveis.CalculaFreteExpresso(),
            },
            PedidoEletronico = new
            {
                FreteEconomico = pedidoEletronico.CalculaFreteEconomico(),
                FreteComum = pedidoEletronico.CalculaFreteComum(),
                FreteExpresso = pedidoEletronico.CalculaFreteExpresso(),
            }
        });
    }

    [HttpGet("PedidoComPadrao/{valor:double}/{tipoFrete:int}")]
    public IActionResult GetStrategyPattern(double valor, int tipoFrete)
    {
        var pedido = new WpPedidoMoveis();
        pedido.SetValorPedido(valor);
        var frete = ChooseFrete(tipoFrete);
        pedido.SetTipoFrete(frete);

        return Ok(new
        {
            FreteEscolhido = frete.GetDescricao(),
            Valor = pedido.CalcularFrete(),
        });
    }

    private IFrete ChooseFrete(int tipoFrete)
    {
        switch (tipoFrete)
        {
            case 1:
                return new FreteComum();
            case 2:
                return new FreteExpresso();
            case 3:
                return new FreteEconomico();
            default:
                throw new Exception("Tipo Frete inválido");
        }
    }
}