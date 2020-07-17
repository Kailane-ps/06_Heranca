using System;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor=ConsoleColor.DarkMagenta;
            CPF cpf = new CPF();
    
            cpf.Nome = "JULIÃO !!!";
            Console.WriteLine(cpf.Oi());
            Console.ResetColor();
            
            cpf.cpf = "1234.4321.5656.0420";
            Console.WriteLine(cpf.ValidarCPF());
        }
    }
}
