using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPN
{
    public class Program
    {

        static void Main(string[] args)
        {
            Methods methods = new Methods();
            while (true) //Бесконечный цикл
            {
                Console.Write("Enter expression: "); //Предлагаем ввести выражение
                Console.WriteLine(methods.Calculate(Console.ReadLine())); //Считываем, и выводим результат
            }
        }
    }
}
