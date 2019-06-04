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
    public partial class GestaoDeVendas : Form
    {
        BaseDeDadosContainer database = new BaseDeDadosContainer();

        public GestaoDeVendas()
        {
            InitializeComponent();
            listboxCliente.DataSource = database.Clientes.ToList<Cliente>();
            listBoxCarrosVenda.DataSource = database.Carros.OfType<CarroVenda>().ToList();
        }

        private void AtualizarValorVendasCliente(Cliente clienteSelecionado)
        {
            decimal totalVendaCliente = 0;
            foreach (Venda item in clienteSelecionado.Vendas.ToList())
            {
                totalVendaCliente += item.Valor;
            }
            label_selec_clien.Text = clienteSelecionado.Nome;
            labelTotalVendas.Text = totalVendaCliente.ToString()+" €";
        }

        private void buttonAddCarroVenda_Click(object sender, EventArgs e)
        {
            AddCarroVenda addCarroVenda = new AddCarroVenda();
            if (addCarroVenda.ShowDialog() == DialogResult.OK)
            {
                if (addCarroVenda.erro_det == true)
                    return;
                CarroVenda novoCarro = new CarroVenda(addCarroVenda.numChasis, addCarroVenda.marca, addCarroVenda.modelo, addCarroVenda.combustivel, addCarroVenda.extras);
                database.Carros.Add(novoCarro);
                database.SaveChanges();
                atualizarListaCarros();

            }
        }
        

        private void atualizarLabels(Cliente clienteSelecionado)
        {
            label_selec_clien.Text = clienteSelecionado.Nome;
            labelContacto.Text = "- " + clienteSelecionado.Contacto;
            labelMorada.Text = "- " + clienteSelecionado.Morada;
            labelTotalVendas.Text = clienteSelecionado.totalGastoVendas.ToString() + " €";
        }


        private void buttonAddicionarCarro_a_Venda_Click(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = (Cliente)listboxCliente.SelectedItem;
            if (listboxCliente.SelectedIndex == -1)
                return;
            CarroVenda carroVendaSelecionado = (CarroVenda)listBoxCarrosVenda.SelectedItem;
            if (listBoxCarrosVenda.SelectedIndex == -1)
                return;


            if (carroVendaSelecionado.JaFoiVendido == true)
            {
                MessageBox.Show("Não pode comprar um carro que já foi comprado");
                return;
            }

            AddVenda criarVenda = new AddVenda();
            if (criarVenda.ShowDialog() == DialogResult.OK)
            {
                if (criarVenda.erro_det == true)
                    return;
                Venda novaVenda = new Venda(criarVenda.estado, criarVenda.valor, criarVenda.data, carroVendaSelecionado);
                clienteSelecionado.Vendas.Add(novaVenda);
                carroVendaSelecionado.JaFoiVendido = true;
                database.SaveChanges();
                atualizarListaVenda(clienteSelecionado);
                atualizarLabels(clienteSelecionado);

            }
        }


        private void buttonEliminarCarroVenda_Click(object sender, EventArgs e)
        {
            CarroVenda carroVendaSelecionado = (CarroVenda)listBoxCarrosVenda.SelectedItem;
            if (listBoxCarrosVenda.SelectedIndex == -1)
                return;
            DialogResult dialogResult = MessageBox.Show("Tem a certeza que pretende Eliminar o Carro da Venda " + carroVendaSelecionado.Marca + "(" + carroVendaSelecionado.Modelo + ")" + " ?", "Eliminar Carro de Venda", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (carroVendaSelecionado.JaFoiVendido == true)
                {
                    MessageBox.Show("Não pode eliminar um carro que já foi vendido");
                    return;
                }
                database.Carros.Remove(carroVendaSelecionado);
                database.SaveChanges();
                atualizarListaCarros();
            }
        }

        private void buttonEliminarVenda_Click(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = (Cliente)listboxCliente.SelectedItem;
            if (listboxCliente.SelectedIndex == -1)
                return;
            Venda vendaSelecionada = (Venda)listBoxVendas.SelectedItem;
            if (listBoxCarrosVenda.SelectedIndex == -1)
                return;
            DialogResult dialogResult = MessageBox.Show("Tem a certeza que pretende Eliminar a Venda ", "Eliminar Venda ?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (vendaSelecionada.EnviouFatura == true)
                {
                    MessageBox.Show("Não é possível eliminar a venda em questão porque já enviou fatura.");
                    return;
                }
                vendaSelecionada.CarroVenda.JaFoiVendido = false;
                database.Vendas.Remove(vendaSelecionada);
                database.SaveChanges();
                atualizarListaCarros();
                atualizarListaVenda(clienteSelecionado);
                atualizarLabels(clienteSelecionado);

            }
        }

        private void buttonEditarVenda_Click(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = (Cliente)listboxCliente.SelectedItem;
            if (listboxCliente.SelectedIndex == -1)
                return;
            Venda vendaSelecionada = (Venda)listBoxVendas.SelectedItem;
            if (listBoxCarrosVenda.SelectedIndex == -1)
                return;


            if (vendaSelecionada.EnviouFatura)
            {
                MessageBox.Show("Não é possível editar a venda em questão porque já enviou fatura.");
                return;
            }

            EditarVendas editarVendas = new EditarVendas(vendaSelecionada);
            if (editarVendas.ShowDialog() == DialogResult.OK)
            {
                if (editarVendas.erro_det == true)
                    return;
                vendaSelecionada.Data = editarVendas.data;
                vendaSelecionada.Estado = editarVendas.estado;
                vendaSelecionada.Valor = editarVendas.valor;
                database.SaveChanges();
                atualizarListaVenda(clienteSelecionado);
                atualizarLabels(clienteSelecionado);
            }
        }

        private void buttonExportarFaturaVenda_Click(object sender, EventArgs e)
        {
            Venda vendaSelecionada = (Venda)listBoxVendas.SelectedItem;
            if (listBoxVendas.SelectedIndex == -1)
                return;
            if (vendaSelecionada.EnviouFatura == true)
            {
                MessageBox.Show("Não pode enviar uma fatura que já enviou previamente");
                return;
            }
            EscolherEmailParaEnviar escolherEmail = new EscolherEmailParaEnviar();
            if (escolherEmail.ShowDialog() == DialogResult.OK)
            {
                if (escolherEmail.erro == true)
                {
                    MessageBox.Show("O campo Email não pode estar vazio");
                    return;
                }
                MailVendas novaFatura = new MailVendas(escolherEmail.email, vendaSelecionada);
                if (novaFatura.enviou == true)
                {
                    MessageBox.Show("Fatura Enviada");
                    vendaSelecionada.EnviouFatura = true;
                    database.SaveChanges();
                }
                else
                    MessageBox.Show("Erro a Enviar Fatura");
            }
        }

        private void buttonEditarCarroVenda_Click(object sender, EventArgs e)
        {
            Venda vendaSelecionada = (Venda)listBoxVendas.SelectedItem;
            if (listBoxCarrosVenda.SelectedIndex == -1)
                return;
            CarroVenda carroVendaSelecionado = (CarroVenda)listBoxCarrosVenda.SelectedItem;
            if (listBoxCarrosVenda.SelectedIndex == -1)
                return;

            if (carroVendaSelecionado.JaFoiVendido == true)
            {
                MessageBox.Show("Não pode editar um carro que já foi vendido");
                return;
            }

            EditarCarroVenda editarCarroVenda = new EditarCarroVenda(carroVendaSelecionado);

            if (editarCarroVenda.ShowDialog() == DialogResult.OK)
            {
                if (editarCarroVenda.erro_det)
                    return;
                carroVendaSelecionado.NumeroChassis = editarCarroVenda.numChasis;
                carroVendaSelecionado.Marca = editarCarroVenda.marca;
                carroVendaSelecionado.Modelo = editarCarroVenda.modelo;
                carroVendaSelecionado.Combustível = editarCarroVenda.combustivel;
                carroVendaSelecionado.Extras = editarCarroVenda.extras;
                database.SaveChanges();
                atualizarListaCarros();
            }

        }

        private void atualizarListaVenda(Cliente clienteSelecionado)
        {
            listBoxVendas.DataSource = null;
            listBoxVendas.DataSource = clienteSelecionado.Vendas.ToList();
        }
        private void atualizarListaCarros()
        {
            listBoxCarrosVenda.DataSource = null;
            listBoxCarrosVenda.DataSource = database.Carros.OfType<CarroVenda>().ToList();
        }


        private void listboxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = (Cliente)listboxCliente.SelectedItem;
            if (listboxCliente.SelectedIndex == -1)
                return;
            atualizarListaVenda(clienteSelecionado);
            atualizarLabels(clienteSelecionado);

        }

        private void GestaoDeVendas_Load(object sender, EventArgs e)
        {

        }

        private void buttonExaminarVenda_Click(object sender, EventArgs e)
        {
            Venda vendaSelecionada = (Venda)listBoxVendas.SelectedItem;
            if (listboxCliente.SelectedIndex == -1)
                return;
            ExaminarVenda examinarVenda = new ExaminarVenda(vendaSelecionada);
            examinarVenda.ShowDialog();
        }

        private void listBoxCarrosVenda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
