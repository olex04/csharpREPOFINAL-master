using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoV_1
{
    public partial class Form_EscolherEmailParaEnviar : Form
    {

        public string email;
        public bool erro;

        public Form_EscolherEmailParaEnviar()
        {
            InitializeComponent();
            erro = false;
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxEmail.Text))
            {
                erro = true;
                return;
            }
            email = textBoxEmail.Text;
        }
    }
}
