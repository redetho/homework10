using System;
using System.Collections.Generic;
using System.Text;

namespace homework10
{
    class Empregado
    {
        //get e set
        public string Nome { get; set; }

        public int Id { get; set; }

        public double Salario { get; set; }

        //função aumentar salário, aumenta de acordo com a porcentagem citada no programa.
        public void AumentarSalario(double porcentagem)
        {
            Salario = Salario * porcentagem;
        }
    }
}
