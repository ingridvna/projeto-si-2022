using System;
using ProjetoBanco.Classes;

namespace ProjetoBanco
{
    class Program
    {
        static void Main()
        {

            try
            {
                var cliente = Cliente.CreateCliente("Ingrid", "Av Plinio de Carvalho, 1680", 16997575141, "393.245.138-42", new DateTime(1997, 02, 04));
                Console.WriteLine(cliente.ToString());

                //var conta = Conta.CriarContaParaCliente(cliente, 20052020, 1000);

                Conta contaPoupanca = new PP(cliente, 20052020, 1000);
                Console.WriteLine(contaPoupanca.Saldo);

                contaPoupanca.Depositar(1000);
                Console.WriteLine(contaPoupanca.Saldo);

                contaPoupanca.Sacar(500);
                Console.WriteLine(contaPoupanca.Saldo);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



        }
    }
}
