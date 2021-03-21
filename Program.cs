using System;

namespace AreaTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("---Área do triangulo---");
            Console.WriteLine();
            Console.ResetColor();
            Console.WriteLine("Base:");
            double b = Convert.ToDouble (Console.ReadLine());
            Console.WriteLine("Altura:");
            double h = Convert.ToDouble(Console.ReadLine());
            double a = b * h/2;
            Console.WriteLine();
            Console.WriteLine($"Área:{a}");
            
        }
    }
}
