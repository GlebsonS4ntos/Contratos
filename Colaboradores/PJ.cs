using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App52.Colaboradores
{
    public class PJ : Colaborador
    {
        public PJ(string nome, double salario) : base(nome, salario)
        {
        }
        public override double SalarioLiquido()
        {
            return Salario - (Salario * 0.06);
        }
    }
}
