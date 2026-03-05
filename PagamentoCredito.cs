namespace Heranca_e_Interface;

internal class PagamentoCredito : Pessoa, IPagamentos
{
    public PagamentoCredito(string nome, string email)
        :base(nome, email)
    {
        
    }

    public void ProcessarPagamentos()
    {
        Console.WriteLine($"Processando o pagamento com cartao de credito para {Nome} - {Email}");
    }
}
