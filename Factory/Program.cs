using System;
using Factory.Interfaces;

namespace Factory
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            FactoryMethod fm = new FactoryMethod();

            Console.WriteLine("Liu Kang| Subzero | Scorpion");
            Console.WriteLine();

            Console.WriteLine("Escolha seu personagem");
            string escolha = Console.ReadLine();

            IPersonagem personagem = fm.EscolherPersonagem(escolha);
            personagem.Escolhido();
            Console.ReadKey();
        }
    }
}
