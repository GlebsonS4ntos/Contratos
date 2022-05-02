using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App52.Colaboradores
{
    public class Freelancer : Colaborador
    {
        public double ValorProjeto { get; set; }

        public Freelancer(double valorProjeto, string nome, double salario) : base(nome, salario)
        {
            ValorProjeto = valorProjeto;
        }

        public override double SalarioLiquido()
        {
            return Salario + (ValorProjeto * 0.085);
        }
    }
}
