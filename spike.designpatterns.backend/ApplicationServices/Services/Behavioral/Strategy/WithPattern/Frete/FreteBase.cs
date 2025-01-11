namespace ApplicationServices.Services.Behavioral.Strategy.WithPattern.Frete;

public abstract class FreteBase
{
    protected string Descricao { get; set; }
    public string GetDescricao() => Descricao;
}