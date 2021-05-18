using System;

namespace Área
{
    class Program
    {
        static void Main(string[] args)
        {
            // declarar variaveis
            int comprimento, altura, area;

            // obter dados
            Console.Write("Comprimento:");
            comprimento = int.Parse(Console.ReadLine());
            Console.Write("Altura:");
            altura = int.Parse(Console.ReadLine());

            //calcular
            area = comprimento * altura;

            //apresentar resultado
            Console.WriteLine("Área:" + area);
            Console.Read();
        }
    }
}
