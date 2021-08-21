using System;

namespace Gritador
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto;
            Console.Clear();
            Console.Beep();

            Console.WriteLine("Olá usuário, irei GRITAR tudo que você digitiar!");

            Console.Write("Digite algo : ");
            texto = Console.ReadLine();

            Console.Beep();
            Console.WriteLine($"\nVocê Digitou : ");
            Console.ForegroundColor = ConsoleColor.Cyan; 
            Console.WriteLine(texto);
            Console.ResetColor();

            Console.WriteLine($"GRITADO fica : ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(texto.ToUpper());
            Console.ResetColor();



        }
    }
}
