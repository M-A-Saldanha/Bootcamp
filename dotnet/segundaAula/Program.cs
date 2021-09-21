using System;

namespace segundaAula
{
    class Program
    {
        static void Main()
        {
            var p = new Pilha();
            p.Empilha(1);
            p.Empilha(2);
            p.Empilha(3);
            p.Empilha(4);
            p.Empilha(5);
            Console.WriteLine(p.Desempilha());
            Console.WriteLine(p.Desempilha());
            Console.WriteLine(p.Desempilha());
            Console.WriteLine(p.Desempilha());
            Console.WriteLine(p.Desempilha());
            Console.WriteLine(p.Desempilha());
        }
    }
}
