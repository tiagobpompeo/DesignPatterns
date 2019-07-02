using System;
namespace Singleton
{
    //bola
    public class NoSingleton
    {
        public NoSingleton()
        {
            Console.WriteLine("Bola em Jogo");            
        }

        public void Mensagem(string message)
        {
            Console.WriteLine(message);
        }
    }
}
