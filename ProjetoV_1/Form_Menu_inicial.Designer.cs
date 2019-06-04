namespace ProjetoV_1
{
    partial class Form_Menu_inicial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Menu_inicial));
            this.Logo = new System.Windows.Forms.PictureBox();
            this.buttonGestaoClientes = new System.Windows.Forms.Button();
            this.Panel_logo_buto = new System.Windows.Forms.Panel();
            this.buttonGerirAdministradores = new System.Windows.Forms.Button();
            this.buttonGestaoVendas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGestaoAluguer = new System.Windows.Forms.Button();
            this.buttonGestaoOficina = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.Painel_dos_menus = new System.Windows.Forms.Panel();
            this.pictureBoxGif = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelData = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelClientes = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelNumClientes = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelVendas = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelNumVendas = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelAlugueres = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelNumAlugueres = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerSegundos = new System.Windows.Forms.Timer(this.components);
            this.panelLogin = new System.Windows.Forms.Panel();
            this.buttonLogOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.Panel_logo_buto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGif)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.SystemColors.Control;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(9, 21);
            this.Logo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(229, 81);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            this.Logo.Click += new System.EventHandler(this.Logo_Click);
            // 
            // buttonGestaoClientes
            // 
            this.buttonGestaoClientes.BackColor = System.Drawing.Color.LightBlue;
            this.buttonGestaoClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGestaoClientes.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGestaoClientes.Image = ((System.Drawing.Image)(resources.GetObject("buttonGestaoClientes.Image")));
            this.buttonGestaoClientes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonGestaoClientes.Location = new System.Drawing.Point(16, 11);
            this.buttonGestaoClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGestaoClientes.Name = "buttonGestaoClientes";
            this.buttonGestaoClientes.Size = new System.Drawing.Size(205, 101);
            this.buttonGestaoClientes.TabIndex = 1;
            this.buttonGestaoClientes.Text = "Gestão de Clientes";
            this.buttonGestaoClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonGestaoClientes.UseVisualStyleBackColor = false;
            this.buttonGestaoClientes.Click += new System.EventHandler(this.gestao_clientes_Click);
            // 
            // Panel_logo_buto
            // 
            this.Panel_logo_buto.BackColor = System.Drawing.Color.Lavender;
            this.Panel_logo_buto.Controls.Add(this.buttonGerirAdministradores);
            this.Panel_logo_buto.Controls.Add(this.buttonGestaoVendas);
            this.Panel_logo_buto.Controls.Add(this.label1);
            this.Panel_logo_buto.Controls.Add(this.buttonGestaoAluguer);
            this.Panel_logo_buto.Controls.Add(this.buttonGestaoOficina);
            this.Panel_logo_buto.Controls.Add(this.buttonGestaoClientes);
            this.Panel_logo_buto.Location = new System.Drawing.Point(-1, 114);
            this.Panel_logo_buto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel_logo_buto.Name = "Panel_logo_buto";
            this.Panel_logo_buto.Size = new System.Drawing.Size(235, 558);
            this.Panel_logo_buto.TabIndex = 2;
            this.Panel_logo_buto.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonGerirAdministradores
            // 
            this.buttonGerirAdministradores.BackColor = System.Drawing.Color.LightBlue;
            this.buttonGerirAdministradores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGerirAdministradores.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGerirAdministradores.Image = ((System.Drawing.Image)(resources.GetObject("buttonGerirAdministradores.Image")));
            this.buttonGerirAdministradores.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonGerirAdministradores.Location = new System.Drawing.Point(16, 453);
            this.buttonGerirAdministradores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGerirAdministradores.Name = "buttonGerirAdministradores";
            this.buttonGerirAdministradores.Size = new System.Drawing.Size(205, 101);
            this.buttonGerirAdministradores.TabIndex = 7;
            this.buttonGerirAdministradores.Text = "Gestão de Administradores";
            this.buttonGerirAdministradores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonGerirAdministradores.UseVisualStyleBackColor = false;
            this.buttonGerirAdministradores.Click += new System.EventHandler(this.buttonGerirAdministradores_Click);
            // 
            // buttonGestaoVendas
            // 
            this.buttonGestaoVendas.BackColor = System.Drawing.Color.LightBlue;
            this.buttonGestaoVendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGestaoVendas.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGestaoVendas.Image = ((System.Drawing.Image)(resources.GetObject("buttonGestaoVendas.Image")));
            this.buttonGestaoVendas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonGestaoVendas.Location = new System.Drawing.Point(16, 344);
            this.buttonGestaoVendas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGestaoVendas.Name = "buttonGestaoVendas";
            this.buttonGestaoVendas.Size = new System.Drawing.Size(205, 101);
            this.buttonGestaoVendas.TabIndex = 4;
            this.buttonGestaoVendas.Text = "Gestão de Vendas";
            this.buttonGestaoVendas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonGestaoVendas.UseVisualStyleBackColor = false;
            this.buttonGestaoVendas.Click += new System.EventHandler(this.gestao_vendas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 426);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 6;
            // 
            // buttonGestaoAluguer
            // 
            this.buttonGestaoAluguer.BackColor = System.Drawing.Color.LightBlue;
            this.buttonGestaoAluguer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGestaoAluguer.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGestaoAluguer.Image = ((System.Drawing.Image)(resources.GetObject("buttonGestaoAluguer.Image")));
            this.buttonGestaoAluguer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonGestaoAluguer.Location = new System.Drawing.Point(16, 231);
            this.buttonGestaoAluguer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGestaoAluguer.Name = "buttonGestaoAluguer";
            this.buttonGestaoAluguer.Size = new System.Drawing.Size(205, 101);
            this.buttonGestaoAluguer.TabIndex = 3;
            this.buttonGestaoAluguer.Text = "Gestão de Aluguer";
            this.buttonGestaoAluguer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonGestaoAluguer.UseVisualStyleBackColor = false;
            this.buttonGestaoAluguer.Click += new System.EventHandler(this.gestap_aluger_Click);
            // 
            // buttonGestaoOficina
            // 
            this.buttonGestaoOficina.BackColor = System.Drawing.Color.LightBlue;
            this.buttonGestaoOficina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGestaoOficina.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGestaoOficina.Image = ((System.Drawing.Image)(resources.GetObject("buttonGestaoOficina.Image")));
            this.buttonGestaoOficina.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonGestaoOficina.Location = new System.Drawing.Point(17, 121);
            this.buttonGestaoOficina.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGestaoOficina.Name = "buttonGestaoOficina";
            this.buttonGestaoOficina.Size = new System.Drawing.Size(205, 101);
            this.buttonGestaoOficina.TabIndex = 2;
            this.buttonGestaoOficina.Text = "Gestão de Oficina";
            this.buttonGestaoOficina.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonGestaoOficina.UseVisualStyleBackColor = false;
            this.buttonGestaoOficina.Click += new System.EventHandler(this.gestao_oficina_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Black;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(227, 114);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(13, 558);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // Painel_dos_menus
            // 
            this.Painel_dos_menus.Location = new System.Drawing.Point(240, 121);
            this.Painel_dos_menus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Painel_dos_menus.Name = "Painel_dos_menus";
            this.Painel_dos_menus.Size = new System.Drawing.Size(867, 548);
            this.Painel_dos_menus.TabIndex = 5;
            this.Painel_dos_menus.Paint += new System.Windows.Forms.PaintEventHandler(this.Painel_dos_menus_Paint);
            // 
            // pictureBoxGif
            // 
            this.pictureBoxGif.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxGif.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGif.Image")));
            this.pictureBoxGif.Location = new System.Drawing.Point(235, 11);
            this.pictureBoxGif.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxGif.Name = "pictureBoxGif";
            this.pictureBoxGif.Size = new System.Drawing.Size(861, 110);
            this.pictureBoxGif.TabIndex = 7;
            this.pictureBoxGif.TabStop = false;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.Black;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(-1, -5);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(1113, 21);
            this.flowLayoutPanel3.TabIndex = 4;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.BackColor = System.Drawing.Color.Black;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(-1, 672);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(1109, 12);
            this.flowLayoutPanel4.TabIndex = 4;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.BackColor = System.Drawing.Color.Black;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(-1, 106);
            this.flowLayoutPanel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(1113, 15);
            this.flowLayoutPanel5.TabIndex = 4;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelData,
            this.toolStripStatusLabelHora,
            this.toolStripStatusLabelClientes,
            this.toolStripStatusLabelNumClientes,
            this.toolStripStatusLabelVendas,
            this.toolStripStatusLabelNumVendas,
            this.toolStripStatusLabelAlugueres,
            this.toolStripStatusLabelNumAlugueres});
            this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.statusStrip1.Location = new System.Drawing.Point(-1, 687);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(414, 25);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelData
            // 
            this.toolStripStatusLabelData.Name = "toolStripStatusLabelData";
            this.toolStripStatusLabelData.Size = new System.Drawing.Size(85, 20);
            this.toolStripStatusLabelData.Text = "01/01/2019";
            // 
            // toolStripStatusLabelHora
            // 
            this.toolStripStatusLabelHora.Name = "toolStripStatusLabelHora";
            this.toolStripStatusLabelHora.Size = new System.Drawing.Size(63, 20);
            this.toolStripStatusLabelHora.Text = "00:00:00";
            // 
            // toolStripStatusLabelClientes
            // 
            this.toolStripStatusLabelClientes.Name = "toolStripStatusLabelClientes";
            this.toolStripStatusLabelClientes.Size = new System.Drawing.Size(64, 20);
            this.toolStripStatusLabelClientes.Text = "Clientes:";
            // 
            // toolStripStatusLabelNumClientes
            // 
            this.toolStripStatusLabelNumClientes.Name = "toolStripStatusLabelNumClientes";
            this.toolStripStatusLabelNumClientes.Size = new System.Drawing.Size(17, 20);
            this.toolStripStatusLabelNumClientes.Text = "0";
            // 
            // toolStripStatusLabelVendas
            // 
            this.toolStripStatusLabelVendas.Name = "toolStripStatusLabelVendas";
            this.toolStripStatusLabelVendas.Size = new System.Drawing.Size(56, 20);
            this.toolStripStatusLabelVendas.Text = "Vendas";
            // 
            // toolStripStatusLabelNumVendas
            // 
            this.toolStripStatusLabelNumVendas.Name = "toolStripStatusLabelNumVendas";
            this.toolStripStatusLabelNumVendas.Size = new System.Drawing.Size(17, 20);
            this.toolStripStatusLabelNumVendas.Text = "0";
            // 
            // toolStripStatusLabelAlugueres
            // 
            this.toolStripStatusLabelAlugueres.Name = "toolStripStatusLabelAlugueres";
            this.toolStripStatusLabelAlugueres.Size = new System.Drawing.Size(75, 20);
            this.toolStripStatusLabelAlugueres.Text = "Alugueres";
            // 
            // toolStripStatusLabelNumAlugueres
            // 
            this.toolStripStatusLabelNumAlugueres.Name = "toolStripStatusLabelNumAlugueres";
            this.toolStripStatusLabelNumAlugueres.Size = new System.Drawing.Size(17, 20);
            this.toolStripStatusLabelNumAlugueres.Text = "0";
            // 
            // timerSegundos
            // 
            this.timerSegundos.Interval = 50;
            this.timerSegundos.Tick += new System.EventHandler(this.timerSegundos_Tick);
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.SystemColors.Control;
            this.panelLogin.Location = new System.Drawing.Point(-1, 121);
            this.panelLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(1109, 591);
            this.panelLogin.TabIndex = 0;
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(991, 687);
            this.buttonLogOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(100, 25);
            this.buttonLogOut.TabIndex = 8;
            this.buttonLogOut.Text = "Sair";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Visible = false;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // Menu_inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1107, 713);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.flowLayoutPanel5);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.pictureBoxGif);
            this.Controls.Add(this.Panel_logo_buto);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.Painel_dos_menus);
            this.Controls.Add(this.flowLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Menu_inicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Menu_inicial_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.Panel_logo_buto.ResumeLayout(false);
            this.Panel_logo_buto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGif)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button buttonGestaoClientes;
        private System.Windows.Forms.Panel Panel_logo_buto;
        private System.Windows.Forms.Button buttonGestaoVendas;
        private System.Windows.Forms.Button buttonGestaoAluguer;
        private System.Windows.Forms.Button buttonGestaoOficina;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel Painel_dos_menus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxGif;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelClientes;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelNumClientes;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelVendas;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelHora;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelNumVendas;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelAlugueres;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelNumAlugueres;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelData;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Button buttonGerirAdministradores;
        private System.Windows.Forms.Button buttonLogOut;
        public System.Windows.Forms.Timer timerSegundos;
    }
}

