using System;

namespace JurosSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Olá usuário, vamos calcular o montante final de um investimento a juros simples.");
            Console.WriteLine( " Pressione enter para continuar.");
            Console.ReadKey();
            
            Console.WriteLine("Indique a capital:");
            decimal c = decimal.Parse (Console.ReadLine());
            Console.WriteLine("Indique a taxa de juros (%):");
            decimal i = decimal.Parse (Console.ReadLine());
            Console.WriteLine("Indique o tempo em meses:");
            decimal t = decimal.Parse (Console.ReadLine());
            
            decimal resultj = c * (i/100) * t;
            decimal resultm = c + resultj ;

            Console.WriteLine ("Juros (R$): " + resultj);
            Console.WriteLine ("Montante (R$): " + resultm);

            Console.ReadKey();

        }
    }
}
