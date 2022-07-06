using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3_avaliacao_logica_de_programacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Nilton Kazuo Hasegawa Haji RA:6322507
            // Criar um programa para calcular e mostrar a área de 3 figuras geométricas diferentes, não vale quadrado e nem retângulo.
            // Observação: as figuras são de escolha livre, dá um Google se não lembrar como faz o cálculo de alguma delas.
            //Requisitos: Deve ser apresentada uma lista para o usuário com o nome das 3 figuras que ele pode escolher para calcular.
            //Deve - se utilizar Switch Case.

            int figura = 3, a, b, B, d, D;

            Console.WriteLine("\n1 - Triângulo \n2 - Trapézio \n3 - Losango\n");
            Console.Write("Escolha a figura que deseja saber a área pelo número: ");
            figura = int.Parse(Console.ReadLine());

            switch (figura)
            {
                case 1:
                    figura = 1;
                    Console.Write("Digite a base da figura: ");
                    b = int.Parse(Console.ReadLine());
                    Console.Write("Digite a altura da figura: ");
                    a = int.Parse(Console.ReadLine());
                    Console.WriteLine("A área do triângulo é: " + b * a / 2);

                    break;

                case 2:
                    figura = 2;
                    Console.Write("Digite a base maior: ");
                    B = int.Parse(Console.ReadLine());
                    Console.Write("Digite a base menor: ");
                    b = int.Parse(Console.ReadLine());
                    Console.Write("Digite a altura da figura: ");
                    a = int.Parse(Console.ReadLine());
                    Console.WriteLine("A área do Trapézio é: " + (B + b) * a / 2);

                    break;

                case 3:
                    figura = 1;
                    Console.Write("Digite a diagonal maior: ");
                    D = int.Parse(Console.ReadLine());
                    Console.Write("Digite diagonal menor: ");
                    d = int.Parse(Console.ReadLine());
                    Console.WriteLine("A área do Losango é: " + D * d / 2);

                    break;
            }

            Console.ReadKey();
        }
    }
}
