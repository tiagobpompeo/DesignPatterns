using System;
using Factory.Interfaces;
using Factory.Personagem;

namespace Factory
{
    public class FactoryMethod
    {
        //metodo do tipo IPersonagem
        public IPersonagem EscolherPersonagem(string personagem)
        {
            switch (personagem)
            {
                case "LiuKang": return new LiuKang();
                case "Scorpion": return new Scorpion();
                case "Subzero": return new Subzero();
                default: return null;
            }
        }
    }
}
