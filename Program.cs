using System;

namespace Exercicio_VelocMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            double distancia, tempo, resultado;
            
            Console.Write("-------Velocidade Média-------");
            Console.WriteLine(); 

            Console.Write("Digite Distancia Percorrida: ");
            distancia = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Digite Tempo Gasto: ");
            tempo = Convert.ToDouble(Console.ReadLine());


            resultado = distancia / tempo;

             Console.WriteLine($"Resultado da Velocidade Média: {resultado:N3}");





        }
    }
}
