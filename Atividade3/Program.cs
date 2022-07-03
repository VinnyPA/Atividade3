using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade3
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int forma;
            double b, altura, area, dmaior, dmenor, p, r;
            p = 3.14;

            Console.WriteLine("Esolhe uma forma que deseja descobrir a área:\n===========\n 1- Triângulo \n 2- Losango \n 3- Círculo\n===========");
            forma = Convert.ToInt32(Console.ReadLine());

            switch (forma)
            {
                case 1: 
                    Console.Clear();
                    Console.WriteLine("Digite a base do seu triângulo: ");
                    b = double.Parse(Console.ReadLine());

                    Console.WriteLine("Digite a altura do seu triângulo: ");
                    altura = double.Parse(Console.ReadLine());

                    area = (b * altura) / 2;
                        Console.WriteLine("A área do seu triângulo é: " + area);
                     
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("Digite a diagonal maior do seu losango: ");
                    dmaior = double.Parse(Console.ReadLine());

                    Console.WriteLine("Digite a diagonal menor do seu losango: ");
                    dmenor = double.Parse(Console.ReadLine());

                    area = (dmaior * dmenor) / 2;
                        Console.WriteLine("A área do seu Losango é: " + area);

                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("Digite o raio do seu Círculo: ");
                    r = double.Parse(Console.ReadLine());

                    area = p * (r*r);
                        Console.WriteLine("A área do seu triângulo é: " + area);

                    break;
            }


            Console.ReadKey();

        }
    }
}
