using System;
using Factory.Interfaces;

namespace Factory.Personagem
{
    public class Subzero : IPersonagem
    {
        public void Escolhido()
        {
            Console.WriteLine("Escolhido  Here");
        }
    }
}
