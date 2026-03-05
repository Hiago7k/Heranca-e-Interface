using Heranca_e_Interface;

namespace Heranca_e_Interfacel
{
    internal class PagamentoBoleto: Pessoa, IPagamentos
    {
        public PagamentoBoleto(string nome, string email) :base(nome, email)
        {
            
        }
    }
}
