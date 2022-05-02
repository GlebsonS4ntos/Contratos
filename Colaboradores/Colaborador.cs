using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App52
{
    public abstract class Colaborador
    {
        private string Nome { get; set; }
        public double Salario { get; set; }
        public Colaborador(string nome, double salario)
        {
            Nome = nome;
            Salario = salario;
        }

        public abstract double SalarioLiquido();
    }
}
