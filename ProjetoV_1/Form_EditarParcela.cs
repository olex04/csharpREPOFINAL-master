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
    public partial class Form_EditarParcela : Form
    {
        public string erro;
        public string descricao;
        public decimal valor;
        public bool erro_det = false;

        public Form_EditarParcela( string descricaoParcela, decimal valorParcela )
        {
            InitializeComponent();
            textBoxDescricaoParcela.Text = descricaoParcela;
            textBoxValorParcela.Text = valorParcela.ToString();
        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxDescricaoParcela.Text))
            {
                erro = labelDesc.Text;
                mensagem_erro();
                return;
            }
            else
            {
                descricao = textBoxDescricaoParcela.Text;
            }
            if (string.IsNullOrEmpty(textBoxValorParcela.Text))
            {
                erro = labelDesc.Text;
                mensagem_erro();
                return;
            }
            else
            {
                valor = Convert.ToDecimal(textBoxValorParcela.Text);
            }

        }
        private void mensagem_erro()
        {
            MessageBox.Show("O calmpo " + "(" + erro + ")" + " não pode estar vazio");
            erro_det = true;

        }

        private void textBoxValorParcela_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
