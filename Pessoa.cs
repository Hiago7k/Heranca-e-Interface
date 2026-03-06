namespace Heranca_e_Interface;

abstract class Pessoa
{
    public Pessoa(string nome, string email)
    {
        Nome = nome;
        Email = email;
    }

    public string Nome { get;}
    public string Email { get;}
}
