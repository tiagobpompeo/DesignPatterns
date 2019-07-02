using System;

namespace Singleton
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            //singleton
            SingleInstance player1 = SingleInstance.GetInstance;
            player1.Mensagem("Player1 - the ball is with me in the middle of field");

            SingleInstance player2 = SingleInstance.GetInstance;
            player2.Mensagem("Player2 - I received the ball");

            //sample real project
            SingleInstance registerVM = SingleInstance.GetInstance;
            registerVM.RegisterVM = new RegisterViewModel();

            //no singleton sample varias instancias
            //NoSingleton player3 = new NoSingleton();
            //player3.Mensagem("Player1 - the ball is with me in the middle of field");

            //NoSingleton player4 = new NoSingleton();
            //player4.Mensagem("Player2 - I received the ball");
           
        }
    }
}
