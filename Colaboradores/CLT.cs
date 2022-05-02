using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App52.Colaboradores
{
    public class CLT : Colaborador
    {
        public CLT(string nome, double salario) : base(nome, salario)
        {
        }

        public override double SalarioLiquido()
        {
            //salario final = salario - (salario * 0.06) - (INSS)
            if (Salario <= 1212)
            {
                return (Salario - (Salario * 0.06)) - (Salario * 0.075);
            }
            else if (Salario <= 2427.35 && Salario > 1212)
            {
                return (Salario - (Salario * 0.06)) - (Salario * 0.09);
            }
            else if (Salario > 2427.35 && Salario <= 3641.03)
            {
                return (Salario - (Salario * 0.06)) - (Salario * 0.12);
            }
            else
            {
                return (Salario - (Salario * 0.06)) - (Salario * 0.14);
            }
        }
    }
}
