
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
    public partial class GestaoDeOficina : Form
    {
        private BaseDeDadosContainer database = new BaseDeDadosContainer();


        public GestaoDeOficina()
        {
            InitializeComponent();
            listboxClientesOficina.DataSource = database.Clientes.ToList();

        }

        private void atualizarListaCarros(Cliente clienteSelecionado)
        {
            listBoxCarrosOficina.DataSource = null;
            listBoxServicos.DataSource = null;
            listBoxParcelas.DataSource = null;
            listBoxCarrosOficina.DataSource = clienteSelecionado.CarrosOficina.ToList();


        }
        private void atualizarListaServicos(CarroOficina carroOficina)
        {
            try
            {
                listBoxServicos.DataSource = null;
                listBoxParcelas.DataSource = null;
                listBoxServicos.DataSource = carroOficina.Servicos.ToList();
            }
            catch (Exception)
            {
                return;
            }
        }

        private void buttonAdicionarCarro_Click_1(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = (Cliente)listboxClientesOficina.SelectedItem;
            if (listboxClientesOficina.SelectedIndex == -1)
                return;

            AddCarroOficina addCarroOfic = new AddCarroOficina();
            if (addCarroOfic.ShowDialog() == DialogResult.OK)
            {
                if (addCarroOfic.erro_det == true)
                    return;
                CarroOficina novoCarroOficina = new CarroOficina(addCarroOfic.numChasis, addCarroOfic.marca, addCarroOfic.modelo, addCarroOfic.combustivel, addCarroOfic.matricula, addCarroOfic.Kms);
                clienteSelecionado.CarrosOficina.Add(novoCarroOficina);
                database.SaveChanges();
                atualizarListaCarros(clienteSelecionado);
            }
        }

        private void buttonAdicionarServico_Click_1(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = (Cliente)listboxClientesOficina.SelectedItem;
            if (listboxClientesOficina.SelectedIndex == -1)
                return;
            CarroOficina carroSelecionado = (CarroOficina)listBoxCarrosOficina.SelectedItem;
            if (listBoxCarrosOficina.SelectedIndex == -1)
                return;
            AdicionarServico adicionarServico = new AdicionarServico();
            if (adicionarServico.ShowDialog() == DialogResult.OK)
            {
                if (adicionarServico.erro_det == true)
                    return;
                Servico addUmServico = new Servico(adicionarServico.DataEntrada, adicionarServico.DataSaida, adicionarServico.tipo, carroSelecionado);
                carroSelecionado.Servicos.Add(addUmServico);
                database.SaveChanges();
                atualizarListaServicos(carroSelecionado);

            }
        }

        private void buttonCriarParcela_Click(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = (Cliente)listboxClientesOficina.SelectedItem;
            if (listboxClientesOficina.SelectedIndex == -1)
                return;
            CarroOficina carroSelecionado = (CarroOficina)listBoxCarrosOficina.SelectedItem;
            if (listBoxCarrosOficina.SelectedIndex == -1)
                return;
            Servico servicoSelecionado = (Servico)listBoxServicos.SelectedItem;
            if (listBoxServicos.SelectedIndex == -1)
                return;
            if (servicoSelecionado.EnviouFatura == true)
            {
                MessageBox.Show("Não pode adicionar Parcelas a um Serviço que já enviou fatura");
                return;
            }
            if (string.IsNullOrEmpty(textBoxDescricaoParcela.Text) && string.IsNullOrEmpty(textBoxValorParcela.Text))
            {
                MessageBox.Show("É obrigatorio preencher o campo: Descrição e Valor");
                return;
            }
            if (string.IsNullOrEmpty(textBoxDescricaoParcela.Text))
            {
                MessageBox.Show("É obrigatorio preencher o campo: Desrição");
                return;
            }
            if (string.IsNullOrEmpty(textBoxValorParcela.Text))
            {
                MessageBox.Show("É obrigatorio preencher o campo: Valor");
                return;
            }
            Parcela adicionarParcela = new Parcela(Convert.ToInt32(textBoxValorParcela.Text), textBoxDescricaoParcela.Text);
            servicoSelecionado.Parcelas.Add(adicionarParcela);
            database.SaveChanges();
            atualizarListaParcela(servicoSelecionado);
            textBoxDescricaoParcela.Clear();
            textBoxValorParcela.Clear();
            atualizarLabels(clienteSelecionado);

        }
        private void buttonEliminarServico_Click(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = (Cliente)listboxClientesOficina.SelectedItem;
            if (listboxClientesOficina.SelectedIndex == -1)
                return;
            CarroOficina carroSelecionado = (CarroOficina)listBoxCarrosOficina.SelectedItem;
            if (listBoxCarrosOficina.SelectedIndex == -1)
                return;
            Servico servico_selecionado = (Servico)listBoxServicos.SelectedItem;
            if (listBoxServicos.SelectedIndex == -1)
                return;
            if (servico_selecionado.EnviouFatura == true)
            {
                MessageBox.Show("Não pode eliminar um Serviço que já enviou fatura");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Tem a certeza que pretende Eliminar o Serviço do Carro " + servico_selecionado.CarroOficina.Marca + " ?", "Eliminar serviço", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (servico_selecionado.Parcelas.Count > 0)
                {
                    DialogResult dialogResult2 = MessageBox.Show("Não pode eliminar o Serviço em questão porque existem Parcelas associadas. Eliminar Todas as Parcelas?", "Impossível eliminar Serviço", MessageBoxButtons.YesNo);
                    if (dialogResult2 == DialogResult.Yes)
                    {
                        foreach (Parcela item in servico_selecionado.Parcelas.ToList())
                        {
                            database.Parcelas.Remove(item);
                        }
                    }
                    database.Servicos.Remove(servico_selecionado);
                    database.SaveChanges();
                    atualizarListaServicos(carroSelecionado);
                    atualizarLabels(clienteSelecionado);
                }
                else
                {
                    database.Servicos.Remove(servico_selecionado);
                    database.SaveChanges();
                    atualizarListaServicos(carroSelecionado);
                }
            }
        }



        private void buttonEliminarCarro_Click_1(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = (Cliente)listboxClientesOficina.SelectedItem;
            if (listboxClientesOficina.SelectedIndex == -1)
                return;
            CarroOficina carroSelecionado = (CarroOficina)listBoxCarrosOficina.SelectedItem;
            if (listBoxCarrosOficina.SelectedIndex == -1)
                return;
            DialogResult dialogResult = MessageBox.Show("Tem a certeza que pretende Eliminar o Carro da Oficina " + carroSelecionado.Marca + "(" + carroSelecionado.Modelo + ")" + " ?", "Eliminar serviço", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (carroSelecionado.Servicos.Count > 0)
                {
                    DialogResult dialogResult2 = MessageBox.Show("Não pode eliminar o carro em questão porque existem Serviços associados. Eliminar Todos os Serviços e respetivas parcelas?", "Impossível eliminar Carro", MessageBoxButtons.YesNo);
                    if (dialogResult2 == DialogResult.Yes)
                    {
                        foreach (Servico itemServico in carroSelecionado.Servicos.ToList())
                        {
                            foreach (Parcela itemParcela in itemServico.Parcelas.ToList())
                            {
                                database.Parcelas.Remove(itemParcela);
                            }
                            database.Servicos.Remove(itemServico);
                        }
                        database.Carros.Remove(carroSelecionado);
                        database.SaveChanges();
                        atualizarListaCarros(clienteSelecionado);
                    }
                }
                else
                {
                    database.Carros.Remove(carroSelecionado);
                    database.SaveChanges();
                    atualizarListaCarros(clienteSelecionado);
                }
            }

        }


        private void atualizarListaParcela(Servico servicoSelec)
        {
            listBoxParcelas.DataSource = null;
            listBoxParcelas.DataSource = servicoSelec.Parcelas.ToList<Parcela>();
        }

        private void atualizarLabels(Cliente clienteSelecionado)
        {
            label_selec_clien.Text = clienteSelecionado.Nome;
            labelContacto.Text = "- "+clienteSelecionado.Contacto;
            labelMorada.Text = "- " + clienteSelecionado.Morada;
            labelTotalOficina.Text = clienteSelecionado.totalGastoOficina.ToString() + " €";
        }

        private void listboxClientesOficina_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = (Cliente)listboxClientesOficina.SelectedItem;
            if (listboxClientesOficina.SelectedIndex == -1)
                return;
            atualizarLabels(clienteSelecionado);
            atualizarListaCarros(clienteSelecionado);
        }

        private void buttonEliminarParcela_Click(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = (Cliente)listboxClientesOficina.SelectedItem;
            if (listboxClientesOficina.SelectedIndex == -1)
                return;
            CarroOficina carroSelecionado = (CarroOficina)listBoxCarrosOficina.SelectedItem;
            if (listBoxCarrosOficina.SelectedIndex == -1)
                return;
            Servico servico_selecionado = (Servico)listBoxServicos.SelectedItem;
            if (listBoxServicos.SelectedIndex == -1)
                return;
            if (servico_selecionado.EnviouFatura == true)
            {
                MessageBox.Show("Não pode eliminar Parcelas de um Serviço que já enviou fatura");
                return;
            }
            Parcela parcelaSelecionada = (Parcela)listBoxParcelas.SelectedItem;
            if (listBoxParcelas.SelectedIndex == -1)
                return;
            DialogResult dialogResult = MessageBox.Show("Tem a certeza que pretende Eliminar o a Parcela " + parcelaSelecionada + " ?", "Eliminar Parcela", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                database.Parcelas.Remove(parcelaSelecionada);
                database.SaveChanges();
                atualizarListaParcela(servico_selecionado);
                atualizarLabels(clienteSelecionado);
            }
        }



        private void buttonEditarCarro_Click(object sender, EventArgs e)
        {
            Cliente clienteSelicionado = (Cliente)listboxClientesOficina.SelectedItem;
            if (listboxClientesOficina.SelectedIndex == -1)
                return;
            CarroOficina carroOficinaSelecionado = (CarroOficina)listBoxCarrosOficina.SelectedItem;
            if (listBoxCarrosOficina.SelectedIndex == -1)
                return;
            EditarCarroOficina editarCarroOficina = new EditarCarroOficina(carroOficinaSelecionado);
            if (editarCarroOficina.ShowDialog() == DialogResult.OK)
            {
                if (editarCarroOficina.erro_det == true)
                    return;
                carroOficinaSelecionado.NumeroChassis = editarCarroOficina.numChasis;
                carroOficinaSelecionado.Marca = editarCarroOficina.marca;
                carroOficinaSelecionado.Matricula = editarCarroOficina.matricula;
                carroOficinaSelecionado.Modelo = editarCarroOficina.modelo;
                carroOficinaSelecionado.Combustível = editarCarroOficina.combustivel;
                carroOficinaSelecionado.Kms = editarCarroOficina.Kms;
                database.SaveChanges();
                atualizarListaCarros(clienteSelicionado);
            }

        }

        private void buttonEditarServiço_Click(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = (Cliente)listboxClientesOficina.SelectedItem;
            if (listboxClientesOficina.SelectedIndex == -1)
                return;
            CarroOficina carroOficinaSelecionado = (CarroOficina)listBoxCarrosOficina.SelectedItem;
            if (listBoxCarrosOficina.SelectedIndex == -1)
                return;
            Servico ServicoSelecionado = (Servico)listBoxServicos.SelectedItem;
            if (listBoxServicos.SelectedIndex == -1)
                return;
            if(ServicoSelecionado.EnviouFatura == true)
            {
                MessageBox.Show("Não pode editar um Serviço que já enviou fatura");
                return;
            }
            EditarServico editarServicoSelecionado = new EditarServico(ServicoSelecionado);
            if (editarServicoSelecionado.ShowDialog() == DialogResult.OK)
            {
                if (editarServicoSelecionado.erro_det == true)
                    return;
                ServicoSelecionado.DataEntrada = editarServicoSelecionado.DataEntrada;
                ServicoSelecionado.DataSaida = editarServicoSelecionado.DataSaida;
                ServicoSelecionado.Tipo = editarServicoSelecionado.tipo;
                database.SaveChanges();
                atualizarListaServicos(carroOficinaSelecionado);
            }
        }

        private void buttonEditarParcela_Click(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = (Cliente)listboxClientesOficina.SelectedItem;
            if (listboxClientesOficina.SelectedIndex == -1)
                return;
            Servico ServicoSelecionado = (Servico)listBoxServicos.SelectedItem;
            if (listBoxServicos.SelectedIndex == -1)
                return;
            if (ServicoSelecionado.EnviouFatura == true)
            {
                MessageBox.Show("Não pode editar Parcelas de um Serviço que já enviou fatura");
                return;
            }
            Parcela parcelaSelecionada = (Parcela)listBoxParcelas.SelectedItem;
            if (listBoxParcelas.SelectedIndex == -1)
                return;
            EditarParcela editarParcela = new EditarParcela(parcelaSelecionada.Descricao, parcelaSelecionada.Valor);
            if (editarParcela.ShowDialog() == DialogResult.OK)
            {
                if (editarParcela.erro_det == true)
                    return;
                parcelaSelecionada.Descricao = editarParcela.descricao;
                parcelaSelecionada.Valor = editarParcela.valor;
                database.SaveChanges();
                atualizarListaParcela(ServicoSelecionado);
                atualizarLabels(clienteSelecionado);
            }


        }

        private void buttonExportar_Click(object sender, EventArgs e)
        {
            Servico servicoSelecionado = (Servico)listBoxServicos.SelectedItem;
            if (listBoxServicos.SelectedIndex == -1)
                return;
            Parcela ParcelaSelecionada = (Parcela)listBoxParcelas.SelectedItem;
            if (listBoxParcelas.SelectedIndex == -1)
                return;
            if (servicoSelecionado.EnviouFatura == true)
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
                MailOficina enviarFaturaOficina = new MailOficina(escolherEmail.email, ParcelaSelecionada, servicoSelecionado);
                if (enviarFaturaOficina.enviou == true)
                {
                    MessageBox.Show("Fatura Enviada");
                    servicoSelecionado.EnviouFatura = true;
                    database.SaveChanges();
                }
                else
                    MessageBox.Show("Erro a Enviar Fatura");
            }
        }

        private void listBoxCarrosOficina_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = (Cliente)listboxClientesOficina.SelectedItem;
            if (listboxClientesOficina.SelectedIndex == -1)
                return;
            CarroOficina carroSelecionado = (CarroOficina)listBoxCarrosOficina.SelectedItem;
            if (listBoxCarrosOficina.SelectedIndex == -1)
                return;

            atualizarListaServicos(carroSelecionado);
        }

        private void listBoxServicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = (Cliente)listboxClientesOficina.SelectedItem;
            if (listboxClientesOficina.SelectedIndex == -1)
                return;
            CarroOficina carroSelecionado = (CarroOficina)listBoxCarrosOficina.SelectedItem;
            if (listBoxCarrosOficina.SelectedIndex == -1)
                return;
            Servico servicoSelecionado = (Servico)listBoxServicos.SelectedItem;
            if (listBoxServicos.SelectedIndex == -1)
                return;

            atualizarListaParcela(servicoSelecionado);
        }

        private void textBoxValorParcela_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void buttonExaminarServico_Click(object sender, EventArgs e)
        {
            Servico servicoSelecionado = (Servico)listBoxServicos.SelectedItem;
            if (listBoxServicos.SelectedIndex == -1)
                return;
            ExaminarServico examinarServico = new ExaminarServico(servicoSelecionado);
            examinarServico.ShowDialog();

        }

        private void buttonExaminarCarro_Click(object sender, EventArgs e)
        {
            CarroOficina carroSelecionado = (CarroOficina)listBoxCarrosOficina.SelectedItem;
            if (listBoxCarrosOficina.SelectedIndex == -1)
                return;
            ExaminarCarroOficina examinarCarroOficina = new ExaminarCarroOficina(carroSelecionado);
            examinarCarroOficina.ShowDialog();
        }
    }
}
