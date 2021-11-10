using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal myDecimal = 3.14m;
            Console.WriteLine($"decimal: {myDecimal}");

            int myInt = (int)myDecimal; //haverá perca de informações
            Console.WriteLine($"int: {myInt}");
            Console.WriteLine("------------------------");

            int first = 5;
            int second = 7;
            string message = first.ToString() + second.ToString(); //o ToString: converte explicitamente valores int em strings.
            Console.WriteLine("Concatenação de dois valores 5 e 7: "+message);
            Console.WriteLine("----------------------------");

            string terceiro = "5";
            string quarto = "7";
            int sum = int.Parse(terceiro) + int.Parse(quarto); //o método parse converte as strings e soma os valores
            Console.WriteLine("converte as string e soma os valores 5 e 7: "+sum);
            Console.WriteLine("-----------------------------");

            /*
            * A classe Convert é melhor para converter números fracionários 
            * em números inteiros (int) porque ela arredonda da maneira esperada.
            */
            string value1 = "5";
            string value2 = "7";
            int result = Convert.ToInt32(value1) * Convert.ToInt32(value2); // converter uma cadeia de caracteres em um número usando a classe Convert
            Console.WriteLine(result);
            Console.WriteLine("--------------------------");

            /*
             * Durante a conversão cast, o valor de float é truncado, 
             * o que significa que o valor depois do decimal é ignorado completamente.
             */
            int value = (int)1.5m; // casting truncates
            Console.WriteLine(value);

            /*
             * Ao converter usando Convert.ToInt32(), o valor de float literal é 
             * corretamente arredondado para 2. Se alterássemos o valor literal 
             * para 1.499m, ele seria arredondado para baixo para 1.
             */
            int value3 = Convert.ToInt32(1.5m); // converting rounds up
            Console.WriteLine(value3);



            Console.ReadLine();
        }
    }
}
