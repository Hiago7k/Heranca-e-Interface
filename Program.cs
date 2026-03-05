using Heranca_e_Interface;
using Heranca_e_Interfacel;

PagamentoCredito cliente1 = new PagamentoCredito("Andre", "andre@gmail.com");
PagamentoBoleto cliente2 = new PagamentoBoleto("Juliana", "juliana@hotmal.com");

cliente1.ProcessarPagamentos();
cliente2.ProcessarPagamentos();