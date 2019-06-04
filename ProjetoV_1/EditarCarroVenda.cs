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
    public partial class EditarCarroVenda : Form
    {
        public string erro;
        public string numChasis;
        public string marca;
        public string modelo;
        public string combustivel;
        public string extras;
        public bool erro_det = false;
        public EditarCarroVenda(CarroVenda receberCarroVenda)
        {
            InitializeComponent();
            textBoxNumeroChassis.Text = receberCarroVenda.NumeroChassis;
            textBoxModelo.Text = receberCarroVenda.Modelo;
            textBoxMarca.Text = receberCarroVenda.Marca;
            comboBoxCombustivel.Text = receberCarroVenda.Combustível;
            if (receberCarroVenda.Extras.Contains(checkBox1.Text))
                checkBox1.Checked = true;
            if (receberCarroVenda.Extras.Contains(checkBox2.Text))
                checkBox2.Checked = true;
            if (receberCarroVenda.Extras.Contains(checkBox3.Text))
                checkBox3.Checked = true;
            if (receberCarroVenda.Extras.Contains(checkBox4.Text))
                checkBox4.Checked = true;
            if (receberCarroVenda.Extras.Contains(checkBox5.Text))
                checkBox5.Checked = true;
            if (receberCarroVenda.Extras.Contains(checkBox6.Text))
                checkBox6.Checked = true;
            if (receberCarroVenda.Extras.Contains(checkBox7.Text))
                checkBox7.Checked = true;
            if (receberCarroVenda.Extras.Contains(checkBox8.Text))
                checkBox8.Checked = true;
            if (receberCarroVenda.Extras.Contains(checkBox9.Text))
                checkBox9.Checked = true;

        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
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
                erro = labelNumChas.Text;
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
                MessageBox.Show("O campo (Extras) não pode estar Vazio");
                erro_det = true;
                return;
            }



        }
        private void mensagem_erro()
        {
            MessageBox.Show("O calmpo " + "(" + erro + ")" + " não pode estar vazio");
            erro_det = true;
        }
    }
}
