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
    public partial class Form_EditarVendas : Form
    {
        public string erro;
        public Decimal valor;
        public string estado;
        public DateTime data;
        public bool erro_det = false;

        public Form_EditarVendas(Venda receberVenda)
        {
            InitializeComponent();
            textBoxValor.Text = Convert.ToString(receberVenda.Valor);
            comboBoxEstado.Text = receberVenda.Estado;
            dateTimePickerData.Value = receberVenda.Data;

        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxValor.Text))
            {
                erro = labelValor.Text;
                mensagem_erro();
                return;

            }
            else
            {
                valor = Convert.ToDecimal(textBoxValor.Text);
            }
            if (comboBoxEstado.SelectedItem == null)
            {
                erro = labelEstado.Text;
                mensagem_erro();
                return;
            }
            else
            {
                estado = comboBoxEstado.Text;
            }
            if (dateTimePickerData.Value == null)
            {
                erro = labelData.Text;
                mensagem_erro();
                return;
            }
            data = dateTimePickerData.Value;
        }
        private void mensagem_erro()
        {
            MessageBox.Show("O calmpo " + "(" + erro + ")" + " não pode estar vazio");
            erro_det = true;
        }

        private void textBoxValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }

}
