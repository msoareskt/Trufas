using System;

namespace Trufas
{
    class Program
    {
        static void Main(string[] args)
        {
            vendasTrufa t = new vendasTrufa();

            double userValorUnitario = 0;
            int userQtd = 0;
            double usercalcularValorTotal = 0;
            int usercalcularQtdAjustada = 0;

            Console.WriteLine("Informe o valor da trufa: ");
            userValorUnitario = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de trufas: ");
            userQtd = int.Parse(Console.ReadLine());

            t.qtd = userQtd;
            t.valorUnitario = userValorUnitario;

            usercalcularValorTotal = t.calcular_Valor_Total();
            usercalcularQtdAjustada = t.calcularQuantidadeAjustada();


            Console.Write("O valor de cada trufa é de R$ " + userValorUnitario + ", o valor total foi de R$" + usercalcularValorTotal + " e foram levadas " + usercalcularQtdAjustada);

            Console.ReadKey();

        }



        public class vendasTrufa
        {
            public double valorUnitario = 0;
            public int qtd = 0;


            public double calcular_Valor_Total()
            {
                double valorTotal = 0;

                valorTotal = valorUnitario * qtd;
                return valorTotal;

            }

            public int calcularQuantidadeAjustada()
            {
                int qtdeAjustada = 0;

                if (qtd > 10)
                {
                    qtdeAjustada = qtd + 1;
                }
                else
                {
                    qtdeAjustada = qtd;
                }

                return qtdeAjustada;
            }
        }
    }
}
