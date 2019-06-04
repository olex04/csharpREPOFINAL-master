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
    public partial class Form_GestaoDeAluguer : Form
    {

        private BaseDeDadosContainer database = new BaseDeDadosContainer();

        public Form_GestaoDeAluguer()
        {
            InitializeComponent();
            AtualizarCarrosEmUso();
            listboxClienteAluguer.DataSource = database.Clientes.ToList<Cliente>();
            listBoxCarrosAluguer.DataSource = database.Carros.OfType<CarroAluguer>().ToList();
            List<CarroAluguer> listaTemp = new List<CarroAluguer>();
        }


        private void atualizarLabels(Cliente clienteSelecionado)
        {
            labelClienteSelecionado.Text = clienteSelecionado.Nome;
            labelContacto.Text = "- " + clienteSelecionado.Contacto;
            labelMorada.Text = "- " + clienteSelecionado.Morada;
            labelTotalAluguer.Text = clienteSelecionado.totalGastoAlugueres.ToString() + " €";
        }

        private void AtualizarCarrosEmUso()
        {
            IQueryable<Aluguer> aluguer = from a in database.Aluguers select a;

            foreach (Aluguer item in aluguer)
            {
                if ((DateTime.Now - item.DataFim).TotalDays > 0)
                    item.CarroAluguer.EmUso = false;
                else
                    item.CarroAluguer.EmUso = true;
            }
        }
        


        private void listBoxCarrosAluguer_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarroAluguer carroAluguerSelecionado = (CarroAluguer)listBoxCarrosAluguer.SelectedItem;
            if (listBoxCarrosAluguer.SelectedIndex == -1)
                return;
        }


        private void buttonAdicionarAluguer_Click(object sender, EventArgs e)
        {
            AtualizarCarrosEmUso();
            Cliente clienteSelecionado = (Cliente)listboxClienteAluguer.SelectedItem;
            if (listboxClienteAluguer.SelectedIndex == -1)
                return;
            CarroAluguer carroAluguerSelecionado = (CarroAluguer)listBoxCarrosAluguer.SelectedItem;
            if (listBoxCarrosAluguer.SelectedIndex == -1)
                return;
            try
            {
                if (String.IsNullOrEmpty(textBoxKm.Text))
                    throw new Exception("A Kilometragem não pode estar vazia");
                if (String.IsNullOrEmpty(textBoxValor.Text))
                    throw new Exception("O Valor não pode estar vazio");
                if (dateTimePickerInicio.Value > dateTimePickerFim.Value)
                    throw new Exception("A Data Final tem de ser maior que a Data Inicial");
                if (carroAluguerSelecionado.EmUso == true)
                    throw new Exception("O Carro escolhido para Aluguer está a Alugado de momento");
                Aluguer novoAluguer = new Aluguer(dateTimePickerInicio.Value, decimal.Parse(textBoxValor.Text), decimal.Parse(textBoxKm.Text), dateTimePickerFim.Value, clienteSelecionado, carroAluguerSelecionado);
                database.Aluguers.Add(novoAluguer);
                database.SaveChanges();
                atualizarListaAlugueres(clienteSelecionado);
                atualizarLabels(clienteSelecionado);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }


        private void buttonAdicionarCarroAluguer_Click(object sender, EventArgs e)
        {
            AtualizarCarrosEmUso();
            Form_AddCarroAluguer addCarro = new Form_AddCarroAluguer();
            if (addCarro.ShowDialog() == DialogResult.OK)
            {
                if (addCarro.erro == true)
                    return;
                CarroAluguer novoCarroAluguer = new CarroAluguer(addCarro.numChassis, addCarro.marca, addCarro.modelo, addCarro.combustivel, addCarro.estado, addCarro.matricula);
                database.Carros.Add(novoCarroAluguer);
                database.SaveChanges();
                atualizarListaCarros();
            }
        }


        private void buttonEditarCarroAluguer_Click(object sender, EventArgs e)
        {
            AtualizarCarrosEmUso();
            CarroAluguer carroAluguerSelecionado = (CarroAluguer)listBoxCarrosAluguer.SelectedItem;
            if (listBoxCarrosAluguer.SelectedIndex == -1)
                return;
            Form_EditarCarroAluguer editarCarroAluguer = new Form_EditarCarroAluguer(carroAluguerSelecionado);
            if (editarCarroAluguer.ShowDialog() == DialogResult.OK)
            {
                carroAluguerSelecionado.NumeroChassis = editarCarroAluguer.numeroChassis;
                carroAluguerSelecionado.Marca = editarCarroAluguer.marca;
                carroAluguerSelecionado.Modelo = editarCarroAluguer.modelo;
                carroAluguerSelecionado.Combustível = editarCarroAluguer.combustivel;
                carroAluguerSelecionado.Estado = editarCarroAluguer.estado;
                carroAluguerSelecionado.Matricula = editarCarroAluguer.matricula;
                database.SaveChanges();
                atualizarListaCarros();
            }
        }
        

        private void atualizarListaCarros()
        {
            listBoxCarrosAluguer.DataSource = null;
            listBoxCarrosAluguer.DataSource = database.Carros.OfType<CarroAluguer>().ToList<CarroAluguer>();
        }

        private void atualizarListaAlugueres(Cliente selectedCliente)
        {
            listBoxAlugueresDoCliente.DataSource = null;
            listBoxAlugueresDoCliente.DataSource = selectedCliente.Alugueres.ToList<Aluguer>();
        }


        private void listboxClienteAluguer_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = (Cliente)listboxClienteAluguer.SelectedItem;
            if (listboxClienteAluguer.SelectedIndex == -1)
                return;

            atualizarListaAlugueres(clienteSelecionado);
            atualizarLabels(clienteSelecionado);
        }


        private void buttonVerAluguerAoPormenor_Click(object sender, EventArgs e)
        {
            AtualizarCarrosEmUso();
            Aluguer aluguerSelecionado = (Aluguer)listBoxAlugueresDoCliente.SelectedItem;
            if (listBoxAlugueresDoCliente.SelectedIndex == -1)
                return;
            Form_ExaminarAluguer examinarAluguer = new Form_ExaminarAluguer(aluguerSelecionado);
            examinarAluguer.ShowDialog();
        }


        private void textBoxKm_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void textBoxValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }


        private void buttonExaminarCarro_Click(object sender, EventArgs e)
        {
            AtualizarCarrosEmUso();
            CarroAluguer carroAluguerSelecionado = (CarroAluguer)listBoxCarrosAluguer.SelectedItem;
            if (listBoxCarrosAluguer.SelectedIndex == -1)
                return;
            Form_ExaminarCarroAluguer examinarCarroAluguer = new Form_ExaminarCarroAluguer(carroAluguerSelecionado);
            examinarCarroAluguer.ShowDialog();
        }

        private void buttonEnviarFatura_Click(object sender, EventArgs e)
        {
            Aluguer aluguerSelecionado = (Aluguer)listBoxAlugueresDoCliente.SelectedItem;
            if (listBoxAlugueresDoCliente.SelectedIndex == -1)
                return;

            if (aluguerSelecionado.EnviouFatura == true)
            {
                MessageBox.Show("Não pode enviar uma fatura que já enviou previamente");
                return;
            }
            Form_EscolherEmailParaEnviar escolherEmail = new Form_EscolherEmailParaEnviar();
            if (escolherEmail.ShowDialog() == DialogResult.OK)
            {
                if (escolherEmail.erro == true)
                {
                    MessageBox.Show("O campo Email não pode estar vazio");
                    return;
                }
                MailerAluguer novaFatura = new MailerAluguer(escolherEmail.email, aluguerSelecionado);
                if (novaFatura.enviou == true)
                {
                    MessageBox.Show("Fatura Enviada");
                    aluguerSelecionado.EnviouFatura = true;
                }
                else
                    MessageBox.Show("Erro a Enviar Fatura");
            }

        }

        private void buttonApagarAluguer_Click(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = (Cliente)listboxClienteAluguer.SelectedItem;
            if (listboxClienteAluguer.SelectedIndex == -1)
                return;
            Aluguer aluguerSelecionado = (Aluguer)listBoxAlugueresDoCliente.SelectedItem;
            if (listBoxAlugueresDoCliente.SelectedIndex == -1)
                return;
            DialogResult dialogResult = MessageBox.Show("Tem a certeza que pretende Eliminar o Aluguer do Cliente " + aluguerSelecionado.Cliente.Nome + " ?", "Eliminar Aluguer", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    if (aluguerSelecionado.EnviouFatura == true)
                        throw new Exception("Não é possível apagar aluguer porque já enviou fatura");
                    aluguerSelecionado.CarroAluguer.EmUso = false;
                    database.Aluguers.Remove(aluguerSelecionado);
                    database.SaveChanges();
                    atualizarListaAlugueres(clienteSelecionado);
                    atualizarLabels(clienteSelecionado);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void buttonEliminarCarro_Click(object sender, EventArgs e)
        {
            CarroAluguer carroSelecionado = (CarroAluguer)listBoxCarrosAluguer.SelectedItem;
            if (listBoxCarrosAluguer.SelectedIndex == -1)
                return;
            AtualizarCarrosEmUso();
            try
            {
                if (carroSelecionado.EmUso == true)
                    throw new Exception("Não pode eliminar um carro que está em uso atualmente");
                database.Carros.Remove(carroSelecionado);
                database.SaveChanges();
                atualizarListaCarros();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
