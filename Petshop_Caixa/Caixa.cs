using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop_Caixa
{
     public class Caixa
     { 
        public DateTime DataCaixa { get; private set; }
        public decimal Saldo { get; private set; }

        public void AbrirCaixa(decimal saldoInicial = 0)
        {
            DataCaixa = DateTime.Now;
            Saldo = saldoInicial;
        }

        public void Deposito(decimal valor)
        {
            Saldo += valor;
        }
        public void Saque(decimal valor)
        {
            if (Saldo >= valor)
            {
                Saldo -= valor;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente");
                Console.WriteLine($"o saldo atual é de R${Saldo}");
            }

        }
        public decimal CalcularTroco(decimal valorVenda, decimal dinheiroEntregue)
        {
            var troco = 0M;
            if (valorVenda <= dinheiroEntregue)
            {
                troco = dinheiroEntregue - valorVenda;
            }
            else
            {
                troco = -1M;
            }

            return troco;
        }

        public void DevolverTroco(decimal troco, decimal valorVenda)
        {
            Deposito(valorVenda);
            Console.WriteLine($"Troco: R${troco}");
            Console.WriteLine($"Saldo atual do caixa após a venda R${Saldo}");

        }
    }
}
