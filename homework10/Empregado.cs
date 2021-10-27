using System;
using System.Collections.Generic;
using System.Text;

namespace homework10
{
    class Empregado
    {
        public string Nome { get; set; }

        public int Id { get; set; }

        public double Salario { get; set; }


        public void AumentarSalario(double porcentagem)
        {
            Salario = Salario * porcentagem;
        }
    }
}
