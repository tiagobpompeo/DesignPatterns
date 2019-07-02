using System;
using Factory.Interfaces;

namespace Factory.Personagem
{
    public class Scorpion : IPersonagem
    {
        public void Escolhido()
        {
            Console.WriteLine("Escolhido Scorpion ");
        }
    }
}
