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
    public partial class Form_AddCliente : Form
    {
        public string nome;
        public string nif;
        public string morada;
        public string contacto;

        public Form_AddCliente()
        {
            InitializeComponent();
            buttonAdicionar.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxNome.Text))
            {
                nome = textBoxNome.Text;
            }
            else
            {
                MessageBox.Show("O campo Nome não pode estar vazio");
            }
            if (!string.IsNullOrEmpty(textBoxNIF.Text))
            {
                nif = textBoxNIF.Text;
            }
            else
            {
                MessageBox.Show("O campo NIF não pode estar vazio");
            }
            if (!string.IsNullOrEmpty(textBoxMorada.Text))
            {
                morada = textBoxMorada.Text;
            }
            else
            {
                MessageBox.Show("O campo Morada não pode estar vazio");
            }
            if (!string.IsNullOrEmpty(textBoxContacto.Text))
            {
                contacto = textBoxContacto.Text;
            }
            else
            {
                MessageBox.Show("O campo Contacto não pode estar vazio");
            }
        }

        private void textBoxNIF_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
