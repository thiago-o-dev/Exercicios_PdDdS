using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosPlataforma
{
    internal class Entrega2
    {
        public static void Exercises()
        {
            AuxiliarMethods.ShowMenu([
                Exercise1,
                Exercise2,
                Exercise3
            ]);
        }

        private static void Exercise1()
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

        private static void Exercise2()
        {
            Console.WriteLine("Digite um valor em reais (pode ser quebrado): ");
            double valorTotal = double.Parse(Console.ReadLine() ?? "0");

            var notas = new Dictionary<int, int>()
            {
                { 10000, 0 }, // 100 reais
                {  5000, 0 }, // 50 reais
                {  2000, 0 }, // 20 reais
                {  1000, 0 }, // 10 reais
                {   500, 0 }, // 5 reais
                {   100, 0 }, // 1 real
                {    50, 0 }, // 0.50
                {    25, 0 }, // 0.25
                {     5, 0 }, // 0.05
                {     1, 0 }  // 0.01
            };

            int valorRestante = (int)Math.Ceiling(valorTotal * 100); // uso o ceiling pq acho errado dar menos troco!

            Console.WriteLine($"{valorRestante} centavos");

            foreach (var nota in notas.Keys.ToList())
            {
                int qtd = valorRestante / nota;
                notas[nota] = qtd;
                valorRestante -= qtd * nota;
            }

            Console.WriteLine("Segue o seu troco");

            foreach (var notaPar in notas)
            {
                if (notaPar.Value > 0)
                {
                    if (notaPar.Key >= 100)
                        Console.WriteLine($"{notaPar.Value} nota(s) de R$ {notaPar.Key / 100}\n");
                    else if(notaPar.Key == 1)
                        Console.WriteLine($"{notaPar.Value} moeda(s) de {notaPar.Key} centavo\n");
                    else
                        Console.WriteLine($"{notaPar.Value} moeda(s) de {notaPar.Key} centavos\n");
                }
            }
        }

        private static void Exercise3()
        {
            // Conheço tantos sistemas de primos, mas vou fazer o básico com a raiz

            Console.WriteLine("Digite um numero inteiro (o maior numero primo representavel aqui é 4294967291): ");

            uint num;
            try
            {
                num = uint.Parse(Console.ReadLine() ?? "0");
            }
            catch (OverflowException _)
            {
                num = uint.MaxValue;
                Console.WriteLine($"O numero digitado é grande demais, usarei o numero maximo de um uint, {num}");
            }

            int limit = (int)Math.Ceiling(Math.Sqrt(num));
            bool flag = false;

            for (uint i = 2; i <= limit; i++)
            {
                if(num % i == 0)
                {
                    flag = true;
                    Console.WriteLine($"O numero é divisivel por {i}, logo ele não é primo.");
                    break;
                }
            }

            if (!flag)
                Console.WriteLine($"O numero {num} é primo.");
        }

    }
}