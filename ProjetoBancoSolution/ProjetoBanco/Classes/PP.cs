using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoBanco.Classes
{
    public class PP : Conta
    {
        public PP (Cliente cliente, int numero, decimal saldo)
            : base(cliente, numero, saldo)
        { }
        public override bool Depositar (decimal Deposito)
        {
            if (Deposito<=0)
            {
                Msg = $"Você deve informar um valor.";
                return false;
            }
            Saldo += Deposito + 0.5m;
            Msg = "Operação realizada com sucesso.";
            return true; 
        }
        public override bool Sacar (decimal saque)
        {
            if (Saldo < saque)
            {
                Msg = $"Seu saldo não é suficiente para realizar esta transação. Seu saldo atual é {Saldo}";
                return false;

            }
            if (Saldo < saque)
            {
                Msg = $"Valor à sacar é {saque} e o saldo é de {Saldo}";
                return false;
            }

            Saldo -= saque + 0.1m;
            return true;
        }

    }
}
