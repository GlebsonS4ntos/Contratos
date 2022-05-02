using App52.Colaboradores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App52
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Visible = false;
            txtValorProjeto.Visible = false;
            string[] contratos = { "CLT", "PJ", "FREELANCER" };
            foreach (string contrato in contratos)
            {
                comboBox1.Items.Add(contrato);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int valor = comboBox1.SelectedIndex;
            if (valor == 2)
            {
                label4.Visible = true;
                txtValorProjeto.Visible = true;
            }
            else
            {
                label4.Visible = false;
                txtValorProjeto.Visible = false;
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        string nomeClt = txtNome.Text;
                        double salarioClt = double.Parse(txtSalario.Text);
                        Colaborador clt = new CLT(nomeClt, salarioClt);
                        MessageBox.Show("O valor do salário liquido é de: " + clt.SalarioLiquido());
                        break;
                    case 1:
                        string nomePj = txtNome.Text;
                        double salarioPj = double.Parse(txtSalario.Text);
                        Colaborador pj = new PJ(nomePj, salarioPj);
                        MessageBox.Show("O valor do salário liquido é de: " + pj.SalarioLiquido());
                        break;
                    case 2:
                        string nomeFr = txtNome.Text;
                        double salarioFr = double.Parse(txtSalario.Text);
                        double valorProjetoFr = double.Parse(txtValorProjeto.Text);
                        Colaborador freela = new Freelancer(valorProjetoFr, nomeFr, salarioFr);
                        MessageBox.Show("O valor do salário liquido é de: " + freela.SalarioLiquido());
                        break;
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
