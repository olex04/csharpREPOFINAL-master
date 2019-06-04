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
    public partial class Form_Login : Form
    {

        Form_Menu_inicial opener;

        BaseDeDadosContainer database = new BaseDeDadosContainer();

        public bool isLoggedIn = false;
        public Administrador adminLogado = null;
        public string username;

        public Form_Login(Form_Menu_inicial inicio)
        {
            InitializeComponent();
            isLoggedIn = false;
            this.ActiveControl = textBoxUsername;
            buttonEntrar.DialogResult = DialogResult.OK;
            opener = inicio;
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            string password;

            if (string.IsNullOrEmpty(textBoxUsername.Text))
                return;
            else
                username = textBoxUsername.Text;

            if (string.IsNullOrEmpty(textBoxPassword.Text))
                return;
            else
                password = textBoxPassword.Text;

            foreach (Administrador item in database.Administradores.ToList())
            {

                if (item.username == username && item.password == password)
                {
                    isLoggedIn = true;
                    adminLogado = item;
                    opener.timerSegundos.Start();
                    break;
                }
                else
                    isLoggedIn = false;
            }
            if (isLoggedIn == false)
                MessageBox.Show("Erro na autenticação");
        }

    }
}
