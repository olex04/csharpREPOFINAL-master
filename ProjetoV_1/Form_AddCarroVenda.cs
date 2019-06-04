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
    public partial class Form_AddCarroVenda : Form
    {
        public string erro;
        public string numChasis;
        public string marca;
        public string modelo;
        public string combustivel;
        public string extras;
        public bool erro_det = false;

        public Form_AddCarroVenda()
        {
            InitializeComponent();
        }

        private void mensagem_erro()
        {
            MessageBox.Show("O calmpo " + "(" + erro + ")" + " não pode estar vazio");
            erro_det = true;
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBoxNumeroChassis.Text))
            {
                erro = labelNumChas.Text;
                mensagem_erro();
                return;
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
            if (comboBoxCombustivel.SelectedIndex == -1)
            {
                erro = labelCombustivel.Text;
                mensagem_erro();
                return;
            }
            else
            {
                combustivel = comboBoxCombustivel.Text;
            }
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked || checkBox4.Checked || checkBox5.Checked || checkBox6.Checked || checkBox7.Checked || checkBox8.Checked || checkBox9.Checked)
            {

                if (checkBox1.Checked)
                {
                    extras = extras + " " + checkBox1.Text;
                }
                if (checkBox2.Checked)
                {
                    extras = extras + " " + checkBox2.Text;
                }
                if (checkBox3.Checked)
                {
                    extras = extras + " " + checkBox3.Text;
                }
                if (checkBox4.Checked)
                {
                    extras = extras + " " + checkBox4.Text;
                }
                if (checkBox5.Checked)
                {
                    extras = extras + " " + checkBox5.Text;
                }
                if (checkBox6.Checked)
                {
                    extras = extras + " " + checkBox6.Text;
                }
                if (checkBox7.Checked)
                {
                    extras = extras + " " + checkBox7.Text;
                }
                if (checkBox8.Checked)
                {
                    extras = extras + " " + checkBox8.Text;
                }
                if (checkBox9.Checked)
                {
                    extras = extras + " " + checkBox9.Text;
                }
            }
            else
            {
                MessageBox.Show("O campo (Extras) não pode estar vazio");
                return;
            }
        }


        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddCarroVenda_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
