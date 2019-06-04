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
    public partial class EditarServico : Form
    {
        public string erro;
        public DateTime DataEntrada;
        public DateTime DataSaida;
        public string tipo;
        public bool erro_det = false;

        public EditarServico(Servico receberServiço)
        {
            InitializeComponent();
            dateTimePickerDataDeEntrada.Value = receberServiço.DataEntrada;
            dateTimePickerDataSaida.Value = receberServiço.DataSaida;
            textBoxTipo.Text = receberServiço.Tipo;
        }

        private void EditarServiço_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {

            DataEntrada = dateTimePickerDataDeEntrada.Value;
            DataSaida = dateTimePickerDataDeEntrada.Value;
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

            }

        }
        private void mensagem_erro()
        {
            MessageBox.Show("O calmpo " + "(" + erro + ")" + " não pode estar vazio");
            erro_det = true;

        }


    }
}
