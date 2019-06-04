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
    public partial class ExaminarCarroOficina : Form
    {
       
        public ExaminarCarroOficina(CarroOficina CarroSelecionadoOficina)
        {
            InitializeComponent();
            textBoxKms.Text = Convert.ToString(CarroSelecionadoOficina.Kms);
            textBoxMarca.Text = CarroSelecionadoOficina.Marca;
            textBoxMatricula.Text = CarroSelecionadoOficina.Matricula;
            textBoxModelo.Text = CarroSelecionadoOficina.Modelo;
            textBoxNumeroChassis.Text = CarroSelecionadoOficina.NumeroChassis;
            comboBoxCombustvel.Text = CarroSelecionadoOficina.Combustível;
            
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
