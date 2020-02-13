using System;

namespace Trufas
{
    class Program
    {
        static void Main(string[] args)
        {
            VendasTrufa t = new VendasTrufa();

            double userValorUnitario = 0;
            int userQtd = 0;
            double usercalcularValorTotal = 0;
            int usercalcularQtdAjustada = 0;

            Console.WriteLine("Informe o valor da trufa: ");
            userValorUnitario = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de trufas: ");
            userQtd = int.Parse(Console.ReadLine());

            t.qtdd = userQtd;
            t.valorUnitario = userValorUnitario;

            usercalcularValorTotal = t.calcularValorTotal();
            usercalcularQtdAjustada = t.calcularQtdAjustada();


            Console.Write("O valor de cada trufa é de R$ " + userValorUnitario + ", o valor total foi de R$" + usercalcularValorTotal + " e foram levadas " + usercalcularQtdAjustada);

            Console.ReadKey();

        }



        public class VendasTrufa
        {
            public double valorUnitario = 0;
            public int qtdd = 0;


            public double calcularValorTotal()
            {
                double valorTotal = 0;

                valorTotal = valorUnitario * qtdd;
                return valorTotal;

            }

            public int calcularQtdAjustada()
            {
                int qtdAjustada = 0;

                if (qtdd > 10)
                {
                    qtdAjustada = qtdd + 1;
                }
                else
                {
                    qtdAjustada = qtdd;
                }

                return qtdAjustada;
            }
        }
    }
}
