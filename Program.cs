using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlunosNota {
    internal class Program {
        static void Main(string[] args) 
        {
            const int numAlunos = 2;
            const int numNotas = 4;

            string[] nomes = new string[numAlunos];
            double[,] notas = new double[numAlunos, numNotas];
            double[] medias = new double[numNotas];
            
            for (int i = 0; i < numAlunos; i++) 
            {
                Console.WriteLine($"Digite o nome do aluno {i + 1}:");
                nomes[i] = Console.ReadLine();

                for (int j = 0; j < numNotas; j++) 
                {
                    Console.WriteLine($"Digite a nota {j + 1} para {nomes[i]}:");
                    notas[i , j] = double.Parse( Console.ReadLine());
                }
            }
            for (int i = 0;i < numAlunos; i++) {
                double soma = 0;
                for (int j = 0;j < numNotas; j++) {
                    soma += notas[i , j];
                }

                medias[i] = soma / numNotas;
            }
            Console.WriteLine("Médias dos alunos");

            for (int i = 0; i <= numAlunos; i++) {
                Console.WriteLine($"{nomes[i]}: {medias[i]:F2}");
                Console.ReadKey();
            }
            
            
        }
    }
}
