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
    public partial class AddCarroAluguer : Form
    {

        public string numChassis;
        public string marca;
        public string modelo;
        public string combustivel;
        public string estado;
        public string matricula;

        public bool erro = false;


        public AddCarroAluguer()
        {
            InitializeComponent();
        }
        

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrEmpty(textBoxNumeroChassis.Text))
                    throw new Exception("O Número de Chassis não pode estar vazio");
                else
                    numChassis = textBoxNumeroChassis.Text;


                if (string.IsNullOrEmpty(textBoxMarca.Text))
                    throw new Exception("A Marca não pode estar vazia");
                else
                    marca = textBoxMarca.Text;


                if (string.IsNullOrEmpty(textBoxModelo.Text))
                    throw new Exception("O Modelo não pode estar vazio");
                else
                    modelo = textBoxModelo.Text;


                if (comboBoxCombustvel.SelectedIndex == -1)
                    throw new Exception("O Combustível não pode estar vazio");
                else
                    combustivel = comboBoxCombustvel.Text;


                if (comboBoxEstado.SelectedIndex == -1)
                    throw new Exception("O Estado não pode estar vazio");
                else
                    estado = comboBoxEstado.Text;


                if (string.IsNullOrEmpty(textBoxMatricula.Text))
                    throw new Exception("A Matricula não pode estar vazia");
                else
                    matricula = textBoxMatricula.Text;


            }
            catch (Exception error)
            {
                erro = true;
                MessageBox.Show(error.Message);
            }   
           
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxCombustvel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
