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
    public partial class GestaoDeAdministradores : Form
    {

        private BaseDeDadosContainer database = new BaseDeDadosContainer();
        private Administrador administradorSelecionado;
        private Administrador AdminLogado;
        private bool isRoot = false;
        private bool isToAdd = false;

        public GestaoDeAdministradores(Administrador adminLogado)
        {
            InitializeComponent();
            AdminLogado = adminLogado;
            if (AdminLogado.username == "root")
                isRoot = true;
            buttonGuardar.Visible = false;
            listBoxAdministradores.DataSource = database.Administradores.ToList();
        }


        private void listBoxAdministradores_SelectedIndexChanged(object sender, EventArgs e)
        {
            Administrador administradorSelecionado = (Administrador)listBoxAdministradores.SelectedItem;
            if (listBoxAdministradores.SelectedIndex == -1)
                return;
            if (!isRoot)
                textBoxPassword.PasswordChar = '*';
            textBoxUsername.Text = administradorSelecionado.username;
            textBoxPassword.Text = administradorSelecionado.password;
            checkBoxSuperUser.Checked = administradorSelecionado.superUser;
            LockControls();
        }

        private void buttonAddAdmin_Click(object sender, EventArgs e)
        {
            textBoxUsername.Clear();
            textBoxPassword.Clear();
            isToAdd = true;
            UnlockControls();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (isToAdd)
            {
                isToAdd = false;
                if (string.IsNullOrEmpty(textBoxUsername.Text))
                    return;
                if (string.IsNullOrEmpty(textBoxPassword.Text))
                    return;
                string usernameAdd = textBoxUsername.Text;
                string passwordAdd = textBoxPassword.Text;
                bool super = checkBoxSuperUser.Checked;
                Administrador novoAdmin = new Administrador(usernameAdd, passwordAdd, super);
                database.Administradores.Add(novoAdmin);
                database.SaveChanges();
                AtualizarListboxAdministradores();
                LockControls();
            }
            else
            {
                if (string.IsNullOrEmpty(textBoxUsername.Text))
                    return;
                if (string.IsNullOrEmpty(textBoxPassword.Text))
                    return;
                string userTemp = textBoxUsername.Text;
                string pwTemp = textBoxPassword.Text;
                administradorSelecionado.username = userTemp;
                administradorSelecionado.password = pwTemp;
                database.SaveChanges();
                LockControls();
            }
        }

        private void buttonEditAdmin_Click(object sender, EventArgs e)
        {

            administradorSelecionado = (Administrador)listBoxAdministradores.SelectedItem;
            if (listBoxAdministradores.SelectedIndex == -1)
                return;
            try
            {
                if (!isRoot && !AdminLogado.superUser)
                    throw new Exception("Não pode editar informações de outros Administradores");
                UnlockControls();
                textBoxUsername.Text = administradorSelecionado.username;
                textBoxPassword.Text = administradorSelecionado.password;
                checkBoxSuperUser.Checked = administradorSelecionado.superUser;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }

        private void buttonDelAdmin_Click(object sender, EventArgs e)
        {
            administradorSelecionado = (Administrador)listBoxAdministradores.SelectedItem;
            if (listBoxAdministradores.SelectedIndex == -1)
                return;
            try
            {
                if (administradorSelecionado.username == "root")
                    throw new Exception("Não pode eliminar o Administrador root");
                if (administradorSelecionado.username == AdminLogado.username)
                    throw new Exception("Não se pode eliminar a si mesmo");
                if (!AdminLogado.superUser)
                    throw new Exception("Não tem permissões para eliminar utilizadores");
                DialogResult dialogResult = MessageBox.Show("Tem a certeza que pretende Eliminar o Administrador " + administradorSelecionado.username + " ?", "Eliminar Administrador", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    database.Administradores.Remove(administradorSelecionado);
                    database.SaveChanges();
                    AtualizarListboxAdministradores();
                    listBoxAdministradores.SelectedIndex = -1;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }

        private void UnlockControls()
        {
            textBoxUsername.Enabled = true;
            textBoxPassword.Enabled = true;
            checkBoxSuperUser.Enabled = true;
            if (isRoot || AdminLogado.superUser)
                checkBoxSuperUser.Visible = true;
            else
                checkBoxSuperUser.Visible = false;
            checkBoxSuperUser.Checked = false;
            buttonGuardar.Visible = true;
        }

        private void LockControls()
        {
            textBoxUsername.Enabled = false;
            textBoxPassword.Enabled = false;
            checkBoxSuperUser.Enabled = false;
            if (isRoot || AdminLogado.superUser)
                checkBoxSuperUser.Visible = true;
            else
                checkBoxSuperUser.Visible = false;
            buttonGuardar.Visible = false;
        }

        private void AtualizarListboxAdministradores()
        {
            listBoxAdministradores.DataSource = null;
            listBoxAdministradores.DataSource = database.Administradores.ToList();
        }

    }
}
