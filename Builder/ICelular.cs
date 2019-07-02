using System;
namespace Builder
{
    public interface ICelular
    {
        void BuildBateria();
        void BuildTela();
        void BuildSO();
        void BuildCamera();
        void Nome();

        Celular Celular { get;}
    }
}
