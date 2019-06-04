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
    public partial class Form_AddVenda : Form
    {
        public string erro;
        public Decimal valor;
        public string estado;
        public DateTime data;
        public bool erro_det = false;

        public Form_AddVenda()
        {
            InitializeComponent();
        }

        private void Add_venda_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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
            data = dateTimePickerData.Value;
        }

        private void mensagem_erro()
        {
            erro_det = true;
            MessageBox.Show("O calmpo " + "(" + erro + ")" + " não pode estar vazio");
        }

        private void textBoxValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
