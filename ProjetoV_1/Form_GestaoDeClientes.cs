using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoV_1
{
    public partial class Form_GestaoDeClientes : Form
    {

        private BaseDeDadosContainer database = new BaseDeDadosContainer();
        private int currentRow = 0;


        public Form_GestaoDeClientes()
        {
            InitializeComponent();

            (from cliente in database.Clientes
             orderby cliente.Nome
             select cliente).Load();
            clienteBindingSource.DataSource = database.Clientes.Local.ToBindingList();

            //clienteDataGridView.Rows[currentRow].Selected = true;
            
            toolStripTextBoxPagina.Text = (currentRow + 1).ToString();
            toolStripLabelMaxClientes.Text = "/ " + database.Clientes.Count<Cliente>().ToString();
        }

        private void toolStripButtonAddCliente_Click(object sender, EventArgs e)
        {
            lockTextBoxes();
            Form_AddCliente addCliente = new Form_AddCliente();
            if (addCliente.ShowDialog() == DialogResult.OK)
            {
                Cliente novoCliente = new Cliente(addCliente.nome, addCliente.nif, addCliente.morada, addCliente.contacto);
                database.Clientes.Add(novoCliente);
                database.SaveChanges();
                clienteBindingSource.DataSource = database.Clientes.Local.ToBindingList();
                toolStripLabelMaxClientes.Text = "/ " + database.Clientes.Count<Cliente>().ToString();
                IrParaUltimo();
                //listBoxListaClientes.SelectedItem = novoCliente;
                updateTextBoxesInfoCliente(novoCliente);
            }
        }

        private void toolStripButtonDelCliente_Click(object sender, EventArgs e)
        {
            lockTextBoxes();
            Cliente clienteSelecionado = (Cliente) clienteDataGridView.CurrentRow.DataBoundItem;
            if (clienteSelecionado == null)
                return;
            try
            {
                DialogResult dialogResult = MessageBox.Show("Tem a certeza que pretende Eliminar o Cliente " + clienteSelecionado.Nome + " ?", "Eliminar cliente", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    foreach (Aluguer item in database.Aluguers.ToList<Aluguer>())
                        if (item.Cliente == clienteSelecionado)
                            throw new Exception("O Cliente " + clienteSelecionado.Nome + " tem pelo menos um Aluguer associado, então não pode ser eliminado");

                    foreach (Venda item in database.Vendas.ToList<Venda>())
                        if (item.Cliente == clienteSelecionado)
                            throw new Exception("O Cliente " + clienteSelecionado.Nome + " tem pelo menos uma Venda associada, então não pode ser eliminado");

                    foreach (CarroOficina item in database.Carros.OfType<CarroOficina>().ToList<CarroOficina>())
                        if (item.Cliente == clienteSelecionado)
                            throw new Exception("O Cliente " + clienteSelecionado.Nome + " tem pelo menos um Carro na Oficina associado, então não pode ser eliminado");

                    database.Clientes.Remove(clienteSelecionado);
                    database.SaveChanges();
                    //clienteBindingSource.DataSource = database.Clientes.Local.ToBindingList();
                    updateListboxClientes();

                    Cliente clienteSelecionado2 = (Cliente)clienteDataGridView.CurrentRow.DataBoundItem;

                    toolStripLabelMaxClientes.Text = "/ " + database.Clientes.Count<Cliente>().ToString();
                    updateTextBoxesInfoCliente(clienteSelecionado2);
                    if (database.Clientes.Count<Cliente>() == 0)
                    {
                        toolStripTextBoxPagina.Text = "0";
                        textboxNome.Text = "";
                        textboxNif.Text = "";
                        textboxMorada.Text = "";
                        textboxContacto.Text = "";
                        
                    }

                }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void toolStripButtonIrParaUltimo_Click(object sender, EventArgs e)
        {
            lockTextBoxes();
            if (clienteDataGridView.Rows.Count > 0)
            {
                IrParaUltimo();
            }
        }

        private void toolStripButtonAndarParaFrente_Click(object sender, EventArgs e)
        {
            lockTextBoxes();
            if (clienteDataGridView.CurrentCell.RowIndex != (clienteDataGridView.Rows.Count -1))
            {
                if (clienteDataGridView.Rows.Count > 0)
                {
                    int index = clienteDataGridView.CurrentCell.RowIndex+1;
                    currentRow = index;
                    clienteDataGridView.CurrentCell = clienteDataGridView.Rows[currentRow].Cells[0];
                    toolStripTextBoxPagina.Text = (currentRow + 1).ToString();
                    Cliente clienteSelecionado = (Cliente)clienteDataGridView.CurrentRow.DataBoundItem;
                    updateTextBoxesInfoCliente(clienteSelecionado);

                }
            }
        }

        private void toolStripButtonAndarParaTras_Click(object sender, EventArgs e)
        {
            lockTextBoxes();
            if (currentRow > 0)
            {
                if (clienteDataGridView.Rows.Count > 0)
                {
                    int index = clienteDataGridView.CurrentCell.RowIndex - 1;
                    currentRow = index;
                    clienteDataGridView.CurrentCell = clienteDataGridView.Rows[currentRow].Cells[0];
                    toolStripTextBoxPagina.Text = (currentRow+1).ToString();
                    Cliente clienteSelecionado = (Cliente)clienteDataGridView.CurrentRow.DataBoundItem;
                    updateTextBoxesInfoCliente(clienteSelecionado);
                }
            }
        }
        

        private void updateTextBoxesInfoCliente(Cliente clienteSelected)
        {
            textboxNome.Text = clienteSelected.Nome;
            textboxNif.Text = clienteSelected.NIF;
            textboxMorada.Text = clienteSelected.Morada;
            textboxContacto.Text = clienteSelected.Contacto;
        }

        private void unlockTextBoxes()
        {
            labelMostrarParaGuardar.Visible = true;
            textboxNome.ReadOnly = false;
            textboxNif.ReadOnly = false;
            textboxMorada.ReadOnly = false;
            textboxContacto.ReadOnly = false;
        }

        private void lockTextBoxes()
        {
            labelMostrarParaGuardar.Visible = false;
            textboxNome.ReadOnly = true;
            textboxNif.ReadOnly = true;
            textboxMorada.ReadOnly = true;
            textboxContacto.ReadOnly = true;
        }

        private void toolStripButtonIrParaPrimeiro_Click(object sender, EventArgs e)
        {
            lockTextBoxes();
            if (clienteDataGridView.Rows.Count > 0)
            {
                IrParaPrimeiro();
            }
        }

        private void IrParaPrimeiro()
        {
            int index = 0;
            currentRow = index;
            clienteDataGridView.CurrentCell = clienteDataGridView.Rows[currentRow].Cells[0];
            toolStripTextBoxPagina.Text = (currentRow + 1).ToString();
            Cliente clienteSelecionado = (Cliente)clienteDataGridView.CurrentRow.DataBoundItem;
            updateTextBoxesInfoCliente(clienteSelecionado);
        }

        private void IrParaUltimo()
        {
            toolStripTextBoxPagina.Text = clienteDataGridView.Rows.Count.ToString();
            int index = clienteDataGridView.Rows.Count;
            currentRow = index - 1;
            clienteDataGridView.CurrentCell = clienteDataGridView.Rows[currentRow].Cells[0];
            toolStripTextBoxPagina.Text = index.ToString();
            Cliente clienteSelecionado = (Cliente)clienteDataGridView.CurrentRow.DataBoundItem;
            updateTextBoxesInfoCliente(clienteSelecionado);
        }

        private void toolStripButton_editar_Click(object sender, EventArgs e)
        {

            Cliente clienteSelecionado = (Cliente)clienteDataGridView.CurrentRow.DataBoundItem;
            if (clienteSelecionado == null)
                return;
            unlockTextBoxes();
        }

        private void toolStripButtonGuardarAlteracoes_Click(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = (Cliente)clienteDataGridView.CurrentRow.DataBoundItem;
            if (clienteSelecionado == null)
                return;
            string nomeDef = textboxNome.Text;
            string nifDef = textboxNif.Text;
            string moradaDef = textboxMorada.Text;
            string contactoDef = textboxContacto.Text;
            clienteSelecionado.Nome = nomeDef;
            clienteSelecionado.NIF = nifDef;
            clienteSelecionado.Morada = moradaDef;
            clienteSelecionado.Contacto = contactoDef;
            database.SaveChanges();

            updateListboxClientes();
            lockTextBoxes();
        }

        private void updateListboxClientes()
        {

            (from cliente in database.Clientes
             orderby cliente.Nome
             select cliente).Load();
            clienteBindingSource.DataSource = database.Clientes.Local.ToBindingList();
        }

        private void buttonFiltrar_Click(object sender, EventArgs e)
        {
            string textoParaFiltrar = textBoxClientesFiltrar.Text;
            if (string.IsNullOrEmpty(textBoxClientesFiltrar.Text))
                return;
            try
            {
                int nif = int.Parse(textoParaFiltrar);

                database.Dispose();
                database = new BaseDeDadosContainer();

                (from c in database.Clientes where c.NIF.Contains(nif.ToString()) select c).Load();
                clienteBindingSource.DataSource = database.Clientes.Local.ToBindingList();

                int max = database.Clientes.Local.Count;

                toolStripLabelMaxClientes.Text = max.ToString();
            }
            catch
            {
                try
                {
                    string nome = textoParaFiltrar;

                    database.Dispose();
                    database = new BaseDeDadosContainer();

                    (from c in database.Clientes where c.Nome.Contains(nome) select c).Load();
                    clienteBindingSource.DataSource = database.Clientes.Local.ToBindingList();

                    int max = database.Clientes.Local.Count;

                    toolStripLabelMaxClientes.Text = max.ToString();
                }
                catch (Exception err1)
                {
                    MessageBox.Show(err1.Message);
                }
            }
        }
        

        private void buttonReporPesquisa_Click(object sender, EventArgs e)
        {
            database.Dispose();
            database = new BaseDeDadosContainer();
            (from cliente in database.Clientes
             orderby cliente.Nome
             select cliente).Load();
            clienteBindingSource.DataSource = database.Clientes.Local.ToBindingList();
            textBoxClientesFiltrar.Text = "";
            toolStripLabelMaxClientes.Text = database.Clientes.Count<Cliente>().ToString();
        }

        private void toolStripButton_exportar_Click(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = (Cliente)clienteDataGridView.CurrentRow.DataBoundItem;
            if (clienteSelecionado == null)
                return;
            string pathDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string pathDesktopPastaClientes = pathDesktop + @"\Clientes";
            string pathPastaClienteComFicheiroCliente = pathDesktopPastaClientes + @"\Cliente_" + clienteSelecionado.NIF;
            string pathParaFicheiroDoCliente = pathPastaClienteComFicheiroCliente + @"\Cliente_" + clienteSelecionado.Nome + ".txt";
            try
            {
                if (Directory.Exists(pathPastaClienteComFicheiroCliente))
                {
                    WriteStuff(clienteSelecionado, pathParaFicheiroDoCliente);
                }
                else
                {
                    DirectoryInfo directoryInfo = Directory.CreateDirectory(pathPastaClienteComFicheiroCliente);
                    WriteStuff(clienteSelecionado, pathParaFicheiroDoCliente);
                }

                MessageBox.Show("Ficha de Cliente Exportada para o Ambiente de Trabalho");
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }

        }
        private void WriteStuff(Cliente clienteSelecionado, String pathParaFicheiroDoCliente)
        {
            TextWriter tw;
            tw = new StreamWriter(pathParaFicheiroDoCliente);
            tw.WriteLine("CLIENTE:\t" + clienteSelecionado.Nome);
            tw.WriteLine("NIF:\t\t" + clienteSelecionado.NIF);
            tw.WriteLine("MORADA:\t\t" + clienteSelecionado.Morada);
            tw.WriteLine("CONTACTO:\t" + clienteSelecionado.Contacto);
            tw.WriteLine(Environment.NewLine + Environment.NewLine + "----------------------------------------------------------------------");
            tw.WriteLine(Environment.NewLine + "\t\t\t\tOFICINA");
            tw.WriteLine(Environment.NewLine + "----------------------------------------------------------------------");
            foreach (CarroOficina itemCarro in clienteSelecionado.CarrosOficina.ToList())
            {
                tw.WriteLine("\tMarca:\t\t\t\t\t" + itemCarro.Marca + " " + itemCarro.Modelo);
                tw.WriteLine("\tMatricula:\t\t\t\t" + itemCarro.Matricula);
                tw.WriteLine("\tNúmero de Chassis:\t\t\t" + itemCarro.NumeroChassis);
                tw.WriteLine("\tTipo de Carro:\t\t\t\t" + itemCarro.Combustível);
                tw.WriteLine("\tKilometragem:\t\t\t\t" + itemCarro.Kms);
                tw.WriteLine("\tTotal Gasto:\t\t\t\t" + itemCarro.totalCarro.ToString() + " €");
                foreach (Servico itemServico in itemCarro.Servicos.ToList())
                {
                    tw.WriteLine("\tServiço no Carro");
                    tw.WriteLine("\t\tTipo de Serviço:\t\t" + itemServico.Tipo);
                    tw.WriteLine("\t\tData de Entrada do Carro:\t" + itemServico.DataEntrada.ToShortDateString());
                    tw.WriteLine("\t\tData de Saída do Carro:\t\t" + itemServico.DataSaida.ToShortDateString());
                    tw.WriteLine("\t\tTotal no Serviço:\t\t" + itemServico.TotalServico.ToString() + " €");
                    tw.WriteLine(Environment.NewLine + "\t\t-Parcelas do Serviço");
                    foreach (Parcela itemParcela in itemServico.Parcelas.ToList())
                    {
                        tw.WriteLine("\t\t\tDescrição:\t\t" + itemParcela.Descricao);
                        tw.WriteLine("\t\t\tValor:\t\t\t" + itemParcela.Valor + " €");
                    }
                }
                tw.WriteLine("\t---------------------------------------------------");
            }
            tw.WriteLine(Environment.NewLine + Environment.NewLine + "----------------------------------------------------------------------");
            tw.WriteLine(Environment.NewLine + "\t\t\t\tALUGUERES");
            tw.WriteLine(Environment.NewLine + "----------------------------------------------------------------------");
            foreach (Aluguer item in clienteSelecionado.Alugueres.ToList())
            {
                tw.WriteLine("\tData Inicial:\t\t\t\t" + item.DataInicio);
                tw.WriteLine("\tData Final:\t\t\t\t" + item.DataFim);
                tw.WriteLine("\tCarro Alugado");
                tw.WriteLine("\t\tMarca:\t\t\t\t" + item.CarroAluguer.Marca + " " + item.CarroAluguer.Modelo);
                tw.WriteLine("\t\tMatricula:\t\t\t" + item.CarroAluguer.Matricula);
                tw.WriteLine("\t\tNúmero de Chassis:\t\t" + item.CarroAluguer.NumeroChassis);
                tw.WriteLine("\t\tTipo de Carro:\t\t\t" + item.CarroAluguer.Combustível);
                tw.WriteLine("\t\tEstado do Carro:\t\t" + item.CarroAluguer.Estado);
                tw.WriteLine("\tValor de Aluguer:\t\t\t" + item.Valor + " €");
                tw.WriteLine("\t-----------------------------------------------------------");
            }
            tw.WriteLine(Environment.NewLine + Environment.NewLine + "----------------------------------------------------------------------");
            tw.WriteLine(Environment.NewLine + "\t\t\t\tVENDAS");
            tw.WriteLine(Environment.NewLine + "----------------------------------------------------------------------");
            foreach (Venda item in clienteSelecionado.Vendas.ToList())
            {
                tw.WriteLine("\tData da Venda:\t\t\t\t" + item.Data);
                tw.WriteLine("\tCarro Vendido\t\t\t");
                tw.WriteLine("\t\tMarca:\t\t\t\t" + item.CarroVenda.Marca + " " + item.CarroVenda.Modelo);
                tw.WriteLine("\t\tNúmero de Chassis:\t\t" + item.CarroVenda.NumeroChassis);
                tw.WriteLine("\t\tTipo de Carro:\t\t\t" + item.CarroVenda.Combustível);
                tw.WriteLine("\t\tExtras do Carro:\t\t" + item.CarroVenda.Extras);
                tw.WriteLine("\tEstado:\t\t\t\t\t" + item.Estado);
                tw.WriteLine("\tValor da Venda:\t\t\t\t" + item.Valor + " €");
                tw.WriteLine("\t-----------------------------------------------------------");
            }
            tw.WriteLine(Environment.NewLine + Environment.NewLine + "----------------------------------------------------------------------");
            tw.Close();
        }

        private void clienteDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            lockTextBoxes();
            Cliente clienteSelecionado = (Cliente)clienteDataGridView.CurrentRow.DataBoundItem;
            updateTextBoxesInfoCliente(clienteSelecionado);
            int index = clienteDataGridView.CurrentCell.RowIndex;
            toolStripTextBoxPagina.Text = (index + 1).ToString();
        }

        private void clienteDataGridView_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            //lockTextBoxes();
            //Cliente clienteSelecionado = (Cliente)clienteDataGridView.CurrentRow.DataBoundItem;
            //updateTextBoxesInfoCliente(clienteSelecionado);

            //int index = currentRow;
            //toolStripTextBoxPagina.Text = (currentRow + 1).ToString();
        }

        private void textboxNif_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
