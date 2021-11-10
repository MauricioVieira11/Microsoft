using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * O método TryParse() faz várias coisas simultaneamente:
                Ele tenta analisar uma cadeia de caracteres sobre o tipo de dados numérico fornecido.
                Se for bem-sucedido, ele armazenará o valor convertido em um parâmetro out.
                Ele retorna um bool para indicar se ele teve êxito ou não.
             */
            string value = "102";
            int result = 0;
            if (int.TryParse(value, out result))
            {
                Console.WriteLine($"Measurement: {result}");
            }
            else
            {
                Console.WriteLine("Unable to report the measurement.");
            }
            Console.WriteLine($"Measurement (w/ offset): {50 + result}");
            Console.WriteLine("-------------------------------");

            string[] values = { "12.3", "45", "ABC", "11", "DEF" };


            Console.ReadLine();
        }
    }
}
