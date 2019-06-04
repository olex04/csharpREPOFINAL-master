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
    public partial class Form_Menu_inicial : Form
    {

        private BaseDeDadosContainer database;

        public Administrador AdminLogadoMenu;
        
        private Form_Login formLogin;


        public Form_Menu_inicial()
        {
            InitializeComponent();
            database = new BaseDeDadosContainer();
            buttonLogOut.Visible = false;
            AtualizarStatusLabels();
            formLogin = new Form_Login(this);
        }

        public void AtualizarStatusLabels()
        {
            toolStripStatusLabelNumClientes.Text = database.Clientes.Count<Cliente>().ToString();
            toolStripStatusLabelNumVendas.Text = database.Vendas.Count<Venda>().ToString();
            toolStripStatusLabelNumAlugueres.Text = database.Aluguers.Count<Aluguer>().ToString();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gestao_clientes_Click(object sender, EventArgs e)
        {
            Painel_dos_menus.Controls.Clear();
            Form_GestaoDeClientes gestaoClientes = new Form_GestaoDeClientes();
            gestaoClientes.TopLevel = false;
            Painel_dos_menus.Controls.Add(gestaoClientes);
            gestaoClientes.Show();

        }

        private void gestao_oficina_Click(object sender, EventArgs e)
        {
            Painel_dos_menus.Controls.Clear();
            Form_GestaoDeOficina gestaoOficina = new Form_GestaoDeOficina();
            gestaoOficina.TopLevel = false;
            Painel_dos_menus.Controls.Add(gestaoOficina);
            gestaoOficina.Show();
        
        }

        private void Logo_Click(object sender, EventArgs e)
        {

        }

        

        private void gestap_aluger_Click(object sender, EventArgs e)
        {
            Painel_dos_menus.Controls.Clear();
            Form_GestaoDeAluguer gestao_alug_form = new Form_GestaoDeAluguer();
            gestao_alug_form.TopLevel = false;
            Painel_dos_menus.Controls.Add(gestao_alug_form);
            gestao_alug_form.Show();

        }

        private void gestao_vendas_Click(object sender, EventArgs e)
        {
            Painel_dos_menus.Controls.Clear();
            Form_GestaoDeVendas gestao_vend_form = new Form_GestaoDeVendas();
            gestao_vend_form.TopLevel = false;
            Painel_dos_menus.Controls.Add(gestao_vend_form);
            gestao_vend_form.Show();
        }

        private void Painel_dos_menus_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timerSegundos_Tick(object sender, EventArgs e)
        {
            if (formLogin.isLoggedIn == true)
            {
                AdminLogadoMenu = formLogin.adminLogado;
                buttonLogOut.Visible = true;
                formLogin.Visible = false;
                panelLogin.Controls.Remove(formLogin);
                panelLogin.Visible = false;
                flowLayoutPanel2.Visible = true;
                Painel_dos_menus.Enabled = true;
                Painel_dos_menus.Visible = true;
            }
            else
            {
                AdminLogadoMenu = null;
                buttonLogOut.Visible = false;
                timerSegundos.Stop();
                formLogin = new Form_Login(this);
                formLogin.Visible = true;
                panelLogin.Visible = true;
                flowLayoutPanel2.Visible = false;
                Painel_dos_menus.Controls.Clear();
                Painel_dos_menus.Enabled = false;
                Painel_dos_menus.Visible = false;
                formLogin.TopLevel = false;
                panelLogin.Controls.Add(formLogin);
                formLogin.Show();
            }
            

            AtualizarStatusLabels();
            toolStripStatusLabelData.Text = DateTime.Now.ToShortDateString();
            toolStripStatusLabelHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void Menu_inicial_Shown(object sender, EventArgs e)
        {
            flowLayoutPanel2.Visible = false;
            Painel_dos_menus.Visible = false;
            formLogin.TopLevel = false;
            panelLogin.Controls.Add(formLogin);
            formLogin.Show();
        }

        private void buttonGerirAdministradores_Click(object sender, EventArgs e)
        {
            Form_GestaoDeAdministradores gestaoDeAdministradores = new Form_GestaoDeAdministradores(AdminLogadoMenu);
            Painel_dos_menus.Controls.Clear();
            gestaoDeAdministradores.TopLevel = false;
            Painel_dos_menus.Controls.Add(gestaoDeAdministradores);
            gestaoDeAdministradores.Show();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            formLogin.isLoggedIn = false;
        }
    }
}
