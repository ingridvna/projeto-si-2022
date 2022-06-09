using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoBanco.Classes
{
       public class Cliente
    {
        private Cliente()
        { }

        public string Nome { get; private set; }

        public string Endereco { get; private set; }

        public long Telefone { get; private set; }

        public string Cpf { get; private set; }

        public DateTime Nascimento  { get; private set; }

        public static Cliente CreateCliente(string nome, string endereco, long telefone, string cpf, DateTime nascimento) =>
        
         new Cliente {Nome = nome,Endereco = endereco,Telefone = telefone, Cpf = cpf,Nascimento = nascimento,};

        public override string ToString() => $"Nome:{Nome} | Documento: {Cpf} | Data de Nascimento: {Nascimento} ---- sobrescrita de: {base.ToString()}" ;

        //static = não muda; comportamento compartilhado por todos os objetos; não depende de um objeto criado em memória

        public bool MaiorDeIdade()
        {
            var atual = DateTime.Today;

            if (atual.Year - Nascimento.Year >= 18)
                return true;
            else
                return false;


        }
    }
}
