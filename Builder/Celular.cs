using System;
namespace Builder
{
    public class Celular
    {
        string Nome_celular;
        
        public Celular(string nome)
        {
            this.Nome_celular = nome;
        }

        public string Nome { get; set; }
        public string Tela { get; set; }
        public string Bateria { get; set; }
        public string SO { get; set; }
        public string Camera { get; set; }

    }
}
