using System;
namespace Builder
{
    public class AndroidBuilder : ICelular
    {
        Celular celular;

        public AndroidBuilder()
        {
            celular = new Celular("Android");
        }


        public Celular Celular
        {
            get { return celular; }
        }


        public void Nome()
        {
            this.celular.Nome = "LG";
        }

        public void BuildBateria()
        {
            this.celular.Bateria = "Lithium";
        }

        public void BuildCamera()
        {
            this.celular.Camera = "5mp";
        }

        public void BuildSO()
        {
            this.celular.SO = "Android";
        }

        public void BuildTela()
        {
            this.celular.Tela = "FullHd";
        }
    }
}
