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
    public partial class EditarCarroAluguer : Form
    {

        public string numeroChassis, marca, modelo, combustivel, estado, matricula;


        public EditarCarroAluguer(CarroAluguer carroEnviado)
        {
            InitializeComponent();
            textBoxNumeroChassis.Text = carroEnviado.NumeroChassis;
            textBoxMarca.Text = carroEnviado.Marca;
            textBoxModelo.Text = carroEnviado.Modelo;
            comboBoxCombustvel.Text = carroEnviado.Combustível;
            comboBoxEstado.Text = carroEnviado.Estado;
            textBoxMatricula.Text = carroEnviado.Matricula;
        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBoxNumeroChassis.Text))
                    throw new Exception("O Número de Chassis não pode estar vazio");
                else
                    numeroChassis = textBoxNumeroChassis.Text;


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
                MessageBox.Show(error.Message);
                this.DialogResult = DialogResult.Cancel;
            }
        }
    }
}
