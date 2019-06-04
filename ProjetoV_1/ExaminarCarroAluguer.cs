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
    public partial class ExaminarCarroAluguer : Form
    {

        public ExaminarCarroAluguer(CarroAluguer carroEnviado)
        {
            InitializeComponent();
            labelMarcaModeloCarro.Text = carroEnviado.Marca + "( " + carroEnviado.Modelo + " )";
            textBoxNumeroChassis.Text = carroEnviado.NumeroChassis;
            textBoxMarca.Text = carroEnviado.Marca;
            textBoxModelo.Text = carroEnviado.Modelo;
            comboBoxCombustvel.Text = carroEnviado.Combustível;
            comboBoxEstado.Text = carroEnviado.Estado;
            textBoxMatricula.Text = carroEnviado.Matricula;
            if (carroEnviado.EmUso == true)
                textBoxAlugadoDeMomento.Text = "Alugado de momento";
            else
                textBoxAlugadoDeMomento.Text = "Disponível";
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
