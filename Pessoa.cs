namespace Praticando_Heranca_Composicao;

 abstract class Pessoa
{
    protected Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
    public string Nome { get; }
    public int Idade { get; }
}
