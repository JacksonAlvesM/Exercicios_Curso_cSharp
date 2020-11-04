using System;


namespace Exercicios2
{
    class Dados
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;
        public double SalarioLiquido;


        


        public void AumentarSalario(double porcentagem)
        {
          
            SalarioLiquido = SalarioBruto / porcentagem + SalarioLiquido;
        }


    }
}
