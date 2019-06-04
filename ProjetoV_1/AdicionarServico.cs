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
    public partial class AdicionarServico : Form
    {
        public string erro;
        public DateTime DataEntrada;
        public DateTime DataSaida;
        public string tipo;
        public bool erro_det = false;

        public AdicionarServico()
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


            if (dateTimePickerDataDeEntrada.Value >= dateTimePickerDataSaida.Value)
            {
                MessageBox.Show("A data de Entrada não pode ser superior ou igual a data de Saida");
                erro_det = true;
                return;
            }
            if (string.IsNullOrEmpty(textBoxTipo.Text))
            {
                erro = labelTipo.Text;
                mensagem_erro();
                return;
            }
            else
            {
                tipo = textBoxTipo.Text;
                DataEntrada = dateTimePickerDataDeEntrada.Value;
                DataSaida = dateTimePickerDataSaida.Value;
            }
        }
    }
}

