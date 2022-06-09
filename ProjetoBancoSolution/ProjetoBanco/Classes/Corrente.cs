using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoBanco.Classes
{
    public class Corrente : Conta
    {
        public Corrente(Cliente cliente, int numero, decimal saldo)
            : base(cliente, numero, saldo)
        { }

        public override bool Depositar(decimal deposito)
        {
            if (deposito <= 0)
            {
                Msg = $"O valor do depósito é inválido!";
                return false;
            }

            Saldo += deposito + 0.5m;
            Msg = "Deposito realizado com sucesso!";

            return true;
        }

        public override bool Sacar(decimal saque)
        {
            if (Saldo <= 0m)
            {
                Msg = $"O saldo é insuficiente para saque. Sua conta está com o valor atual de {Saldo}";
                return false;
            }

            if (Saldo < saque)
            {
                Msg = $"Valor solicitado para o saque é {saque} e o Saldo é {Saldo}";
                return false;
            }

            Saldo -= saque + 0.1m;
            return true;
        }
    }
}