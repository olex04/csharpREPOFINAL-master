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
    public partial class Form_ExaminarAluguer : Form
    {
        public Form_ExaminarAluguer(Aluguer aluguerSelecionado)
        {
            InitializeComponent();
            textBoxDataInicio.Text = aluguerSelecionado.DataInicio.ToLongDateString();
            textBoxDataFim.Text = aluguerSelecionado.DataFim.ToLongDateString();
            textBoxEstado.Text = aluguerSelecionado.CarroAluguer.Estado;
            textBoxKMS.Text = aluguerSelecionado.Kms.ToString();
            textBoxMarca.Text = aluguerSelecionado.CarroAluguer.Marca;
            textBoxMatricula.Text = aluguerSelecionado.CarroAluguer.Matricula;
            textBoxModelo.Text = aluguerSelecionado.CarroAluguer.Modelo;
            textBoxValor.Text = aluguerSelecionado.Valor.ToString();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
