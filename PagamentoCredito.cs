namespace Heranca_e_Interface;

internal class PagamentoCredito : Pessoa, IPagamentos
{
    public PagamentoCredito(string nome, string email)
        :base(nome, email)
    {
        
    }
}
