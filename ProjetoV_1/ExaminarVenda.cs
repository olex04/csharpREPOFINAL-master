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
    public partial class ExaminarVenda : Form
    {
        public ExaminarVenda(Venda venda)
        {
            InitializeComponent();
            textBoxMarca.Text = venda.CarroVenda.Marca;
            textBoxModelo.Text = venda.CarroVenda.Modelo;
            textBoxNumeroChassis.Text = venda.CarroVenda.NumeroChassis;
            comboBoxCombustivel.Text = venda.CarroVenda.Combustível;
            textBoxValor.Text = venda.Valor.ToString();
            dateTimePicker1.Value = venda.Data;
            if (venda.CarroVenda.Extras.Contains(checkBox1.Text))
                checkBox1.Checked = true;
            if (venda.CarroVenda.Extras.Contains(checkBox2.Text))
                checkBox2.Checked = true;
            if (venda.CarroVenda.Extras.Contains(checkBox3.Text))
                checkBox3.Checked = true;
            if (venda.CarroVenda.Extras.Contains(checkBox4.Text))
                checkBox4.Checked = true;
            if (venda.CarroVenda.Extras.Contains(checkBox5.Text))
                checkBox5.Checked = true;
            if (venda.CarroVenda.Extras.Contains(checkBox6.Text))
                checkBox6.Checked = true;
            if (venda.CarroVenda.Extras.Contains(checkBox7.Text))
                checkBox7.Checked = true;
            if (venda.CarroVenda.Extras.Contains(checkBox8.Text))
                checkBox8.Checked = true;
            if (venda.CarroVenda.Extras.Contains(checkBox9.Text))
                checkBox9.Checked = true;
            comboBoxEstado.Text = venda.Estado;
        }

        private void ExaminarVenda_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
