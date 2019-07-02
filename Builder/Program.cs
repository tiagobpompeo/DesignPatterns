using System;

namespace Builder
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ICelular celular = null;


            Fabricante fab = new Fabricante();


            celular = new AndroidBuilder();


            fab.Construtor(celular);


            Console.WriteLine("Novo Celular foi construido : " + celular.Celular.Nome.ToString());

        }
    }
}
