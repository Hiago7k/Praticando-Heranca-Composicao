namespace Praticando_Heranca_Composicao;

internal class ClienteVip : Pessoa
{
    public string NivelFidelidade { get; }
    public string CodigoVip { get; set; }

    public ClienteVip(string nome, int idade, string nivelfidelidade, string codigovip)
        : base(nome, idade)
    {
        NivelFidelidade = nivelfidelidade;
        CodigoVip = codigovip;
    }
}
