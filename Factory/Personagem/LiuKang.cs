using System;
using Factory.Interfaces;

namespace Factory.Personagem
{
    public class LiuKang : IPersonagem
    {
        public void Escolhido()
        {
            Console.WriteLine("Escolhido  Here");
        }
    }
}
