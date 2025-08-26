using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosPlataforma
{
    internal class Entrega1
    {
        public static void Exercises()
        {
            AuxiliarMethods.ShowMenu([
                Exercise1, 
                Exercise2, 
                Exercise3, 
                Exercise4
            ]);
        }

        private static void Exercise1()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Digite o numero {i + 1} (numero inteiro): ");
                double num = double.Parse(Console.ReadLine() ?? "0");

                if ((num % 2) == 0)
                    Console.WriteLine($"O numero {num} é par");
                else
                    Console.WriteLine($"O numero {num} é impar");
            }
        }

        private static void Exercise2()
        {
            Console.WriteLine("Digite uma temperatura em Fahrenheit para conversao em celsius: ");
            double F = double.Parse(Console.ReadLine() ?? "0");
            double C = 5 * ((F - 32) / 9);

            Console.WriteLine($"A temperatura fahrenheit de {F} graus, é o mesmo que {C} graus celsius");
        }

        private static void Exercise3()
        {
            Console.WriteLine("Digite os valores de uma equação de segundo grau");

            Console.WriteLine("A (x elevado a 2):");
            double a = double.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine("B (x)");
            double b = double.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine("C (numero não incognita)");
            double c = double.Parse(Console.ReadLine() ?? "0");

            double delta = b * b - 4 * a * c;
            double a1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double a2 = (-b - Math.Sqrt(delta)) / (2 * a);

            Console.WriteLine($"Os dois valores possíveis são:\n a1: {a1}\n a2: {a2}");
        }

        private static void Exercise4()
        {
            int count = 3;
            List<double> numbers = new List<double>();
            Console.WriteLine($"Digite {count} numeros para ordenar");

            for (int i = 0; i < count; i++)
            {
                numbers.Add(double.Parse(Console.ReadLine() ?? "0"));
            }

            Console.WriteLine($"Agora iremos ordenar os {count} numeros...");

            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count - 1; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        double temp = numbers[j];
                        numbers[j] = numbers[i];
                        numbers[i] = temp;
                    }
                }
            }

            Console.WriteLine($"Ordem final: {string.Join(",", numbers)}");
        }
    }
}