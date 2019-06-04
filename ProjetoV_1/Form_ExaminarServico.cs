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
    public partial class Form_ExaminarServico : Form
    {
        public string erro;
        public DateTime DataEntrada;
        public DateTime DataSaida;
        public string tipo;
        public bool erro_det = false;

        public Form_ExaminarServico(Servico ServicoSelecionado)
        {
            InitializeComponent();
            dateTimePickerDataDeEntrada.Value = ServicoSelecionado.DataEntrada;
            dateTimePickerDataSaida.Value = ServicoSelecionado.DataSaida;
            textBoxTipo.Text = ServicoSelecionado.Tipo;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

