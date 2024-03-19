using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consoleswtich
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite o primeiro número:");
            double um = double.Parse(Console.ReadLine());
            Console.WriteLine("digite o segundo número:");
            double dois = double.Parse(Console.ReadLine());

            Console.WriteLine("selecione a operação desejada:+, -, *, /");
            string operacao=Console.ReadLine().ToUpper();
            switch (operacao)
            {
                case "+":
                    double resultado = um + dois;
                    Console.WriteLine("o resultado é" + resultado);
                    break;
                case "-":
                    double resultado2 = um - dois;
                    Console.WriteLine("o resultado é" + resultado2);
                    break;
                case "*":
                    double resultado3 = um * dois;
                    Console.WriteLine("o resultado é" + resultado3);
                    break;
                case "/":
                    double resultado4 = um / dois;
                    Console.WriteLine("o resultado é" + resultado4);
                    break;
                    default:
                    Console.WriteLine("erro, opção inválida");
                    break;
            }


        }
    }
}
