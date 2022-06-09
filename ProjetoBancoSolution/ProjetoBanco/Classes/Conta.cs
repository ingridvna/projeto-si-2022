using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoBanco.Classes
{
    public abstract class Conta
    {
        public Conta(Cliente cliente, int numero, decimal saldo)
        {
            string numeroconvertido = numero.ToString();

            if (!cliente.MaiorDeIdade())
                throw new Exception("Cliente não é maior de idade.");

            if (numeroconvertido.Length < 5)
                throw new Exception("Número da conta inválido");
        }

        private decimal _saldo;

        public int Numero { get; private set; }

        public Cliente Cliente { get; private set; }

        public string Msg { get; set; }

        public decimal Saldo
        {
            get { return _saldo; }
            protected set
            {
                if (value >= 0)
                    _saldo = value;
                else
                    _saldo = 0;
            }

        }
       
      

        public abstract bool Sacar(decimal saque);

        public abstract bool Depositar(decimal deposito);
    }
}
