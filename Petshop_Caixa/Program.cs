using System;

namespace Petshop_Caixa
{
    class Program
    {
        static void Main(string[] args)
        {
            Caixa caixaDoDia = new Caixa();
            caixaDoDia.AbrirCaixa(500);

            Console.WriteLine($"Caixa Aberto em { caixaDoDia.DataCaixa }");
            Console.WriteLine($"O saldo atual é de R${caixaDoDia.Saldo}");
            Console.WriteLine("Nova Venda");

            Console.WriteLine("Qual o valor da compra?");
            var compra = Console.ReadLine();
            decimal.TryParse(compra, out decimal valorCompra);
            Console.WriteLine("Qual o valor entregue pelo clinete?");
            var pago = Console.ReadLine();
            decimal.TryParse(pago, out decimal valorPago);
            var troco = caixaDoDia.CalcularTroco(valorCompra, valorPago);
            if (troco != -1M)
            {
                caixaDoDia.DevolverTroco(troco, valorCompra);
            }
            else
            {
                Console.WriteLine("Valor entregue insuficiente");
            }
        }
    }
}
