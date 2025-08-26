using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosPlataforma
{
    internal class AuxiliarMethods
    {
        public static void ShowMenu(List<Action> Exercises, string texto = "Selecione o exercicio")
        {
            while (true)
            {
                Console.WriteLine($"\n\n# {texto} de 1 a {Exercises.Count} ou _ para sair: ");
                string input = Console.ReadLine() ?? "1";

                if (int.TryParse(input, out int choice) && choice >= 1 && choice <= Exercises.Count)
                {
                    Exercises[choice - 1]();
                }
                else if (input == "_")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Opção inválida, tente novamente.");
                }
            }
        }
    }
}
