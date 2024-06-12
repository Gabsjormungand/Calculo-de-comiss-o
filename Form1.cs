using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_de_comissão
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = txtBoxSalario.Text;

            if (decimal.TryParse(input, out decimal ValorVendas))
            {
                decimal comissao;
                if (ValorVendas < 1500)
                {
                    comissao = ValorVendas * 0.20m;
                }
                else
                {
                    comissao = ValorVendas * 0.35m;
                }
                txtBoxVenda.Text = comissao.ToString();
            }
            else
            {
                MessageBox.Show("Entrada Invalida, Digite um Valor numerico!!");
            }
            textBox3.Text = ValorVendas.ToString();
        }
    }
}
