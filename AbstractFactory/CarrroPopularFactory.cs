using System;
namespace AbstractFactory
{
    public class CarrroPopularFactory : CarroFactory
    {
        public override Roda MontarRoda()
        {
            return new Roda();
        }

        public override Som MontarSom()
        {
            return new Som();
        }
    }
}
