using System;

namespace Singleton
{

    //bola
    sealed public class SingleInstance //sealed nao pode ser herdada
    {
        private static SingleInstance instance = null;


        public static SingleInstance GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new SingleInstance();//bola
                return instance;
            }
        }

        public void Mensagem(string message)
        {
            Console.WriteLine(message);
        }


        //sample Zuluaga no Xamarin Forms Projects
        #region ViewModels
        public RegisterViewModel RegisterVM
        {
            get;
            set;
        }
        #endregion
         
    }
}
