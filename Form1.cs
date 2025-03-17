using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maioroumenorquedez
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string valor = txtNumero.Text;
            int numero;
            if (int.TryParse(valor, out numero))
                if (numero > 10)
            {
                MessageBox.Show("O valor é maior que 10", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("O valor é menor que 10", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
