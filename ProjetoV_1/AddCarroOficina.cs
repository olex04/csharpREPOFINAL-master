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
    public partial class AddCarroOficina : Form
    {
        public string erro;
        public string numChasis;
        public string marca;
        public string modelo;
        public string combustivel;
        public string matricula;
        public Decimal Kms;
        public bool erro_det = false;
        public AddCarroOficina()
        {
            InitializeComponent();
        }

        private void mensagem_erro()
        {
            MessageBox.Show("O calmpo " + "(" + erro + ")" + " não pode estar vazio");
            erro_det = true;

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBoxNumeroChassis.Text))
            {
                erro = labelChasis.Text;
                mensagem_erro();


            }
            else
            {
                numChasis = textBoxNumeroChassis.Text;
            }
            if (string.IsNullOrEmpty(textBoxMarca.Text))
            {
                erro = labelMarca.Text;
                mensagem_erro();
                return;
            }
            else
            {
                marca = textBoxMarca.Text;
            }
            if (string.IsNullOrEmpty(textBoxModelo.Text))
            {
                erro = labelModelo.Text;
                mensagem_erro();
                return;
            }
            else
            {
                modelo = textBoxModelo.Text;
            }
            if (comboBoxCombustvel.SelectedIndex == -1)
            {
                erro = labelCombustivel.Text;
                mensagem_erro();
                return;
            }
            else
            {
                combustivel = comboBoxCombustvel.Text;
            }
            if (string.IsNullOrEmpty(textBoxMatricula.Text))
            {
                erro = labelMatricula.Text;
                mensagem_erro();
                return;
            }
            else
            {
                matricula = textBoxMatricula.Text;
            }
            if (string.IsNullOrEmpty(textBoxKms.Text))
            {
                erro = labelKms.Text;
                mensagem_erro();
                return;
            }
            else
            {
                int km = Convert.ToInt32(textBoxKms.Text);
                Kms = km;
            }
        }

        private void textBoxKms_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
