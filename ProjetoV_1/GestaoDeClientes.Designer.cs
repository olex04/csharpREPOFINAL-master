namespace ProjetoV_1
{
    partial class GestaoDeClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestaoDeClientes));
            this.Lista_de_clie_gbox = new System.Windows.Forms.GroupBox();
            this.clienteDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonReporPesquisa = new System.Windows.Forms.Button();
            this.buttonFiltrar = new System.Windows.Forms.Button();
            this.textBoxClientesFiltrar = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelMostrarParaGuardar = new System.Windows.Forms.Label();
            this.textboxNif = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textboxMorada = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textboxContacto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textboxNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonIrParaPrimeiro = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAndarParaTras = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBoxPagina = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabelMaxClientes = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButtonAndarParaFrente = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonIrParaUltimo = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAddCliente = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDelCliente = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_editar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonGuardarAlteracoes = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_exportar = new System.Windows.Forms.ToolStripButton();
            this.Lista_de_clie_gbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lista_de_clie_gbox
            // 
            this.Lista_de_clie_gbox.Controls.Add(this.clienteDataGridView);
            this.Lista_de_clie_gbox.Controls.Add(this.buttonReporPesquisa);
            this.Lista_de_clie_gbox.Controls.Add(this.buttonFiltrar);
            this.Lista_de_clie_gbox.Controls.Add(this.textBoxClientesFiltrar);
            this.Lista_de_clie_gbox.Location = new System.Drawing.Point(11, 3);
            this.Lista_de_clie_gbox.Margin = new System.Windows.Forms.Padding(2);
            this.Lista_de_clie_gbox.Name = "Lista_de_clie_gbox";
            this.Lista_de_clie_gbox.Padding = new System.Windows.Forms.Padding(2);
            this.Lista_de_clie_gbox.Size = new System.Drawing.Size(263, 430);
            this.Lista_de_clie_gbox.TabIndex = 0;
            this.Lista_de_clie_gbox.TabStop = false;
            this.Lista_de_clie_gbox.Text = "Lista de Clientes";
            // 
            // clienteDataGridView
            // 
            this.clienteDataGridView.AllowUserToAddRows = false;
            this.clienteDataGridView.AllowUserToDeleteRows = false;
            this.clienteDataGridView.AutoGenerateColumns = false;
            this.clienteDataGridView.CausesValidation = false;
            this.clienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clienteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn1});
            this.clienteDataGridView.DataSource = this.clienteBindingSource;
            this.clienteDataGridView.Location = new System.Drawing.Point(5, 67);
            this.clienteDataGridView.MultiSelect = false;
            this.clienteDataGridView.Name = "clienteDataGridView";
            this.clienteDataGridView.ReadOnly = true;
            this.clienteDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.clienteDataGridView.Size = new System.Drawing.Size(253, 358);
            this.clienteDataGridView.TabIndex = 3;
            this.clienteDataGridView.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.clienteDataGridView_RowStateChanged);
            this.clienteDataGridView.SelectionChanged += new System.EventHandler(this.clienteDataGridView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NIF";
            this.dataGridViewTextBoxColumn4.HeaderText = "NIF";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "totalGastoNoStand";
            this.dataGridViewTextBoxColumn1.HeaderText = "Total Gasto no Stand";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(ProjetoV_1.Cliente);
            // 
            // buttonReporPesquisa
            // 
            this.buttonReporPesquisa.BackColor = System.Drawing.Color.LightBlue;
            this.buttonReporPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReporPesquisa.Font = new System.Drawing.Font("Berlin Sans FB", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReporPesquisa.Location = new System.Drawing.Point(197, 38);
            this.buttonReporPesquisa.Margin = new System.Windows.Forms.Padding(2);
            this.buttonReporPesquisa.Name = "buttonReporPesquisa";
            this.buttonReporPesquisa.Size = new System.Drawing.Size(61, 24);
            this.buttonReporPesquisa.TabIndex = 2;
            this.buttonReporPesquisa.Text = "Repôr";
            this.buttonReporPesquisa.UseVisualStyleBackColor = false;
            this.buttonReporPesquisa.Click += new System.EventHandler(this.buttonReporPesquisa_Click);
            // 
            // buttonFiltrar
            // 
            this.buttonFiltrar.BackColor = System.Drawing.Color.LightBlue;
            this.buttonFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFiltrar.Font = new System.Drawing.Font("Berlin Sans FB", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFiltrar.Location = new System.Drawing.Point(197, 12);
            this.buttonFiltrar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFiltrar.Name = "buttonFiltrar";
            this.buttonFiltrar.Size = new System.Drawing.Size(61, 24);
            this.buttonFiltrar.TabIndex = 1;
            this.buttonFiltrar.Text = "Filtrar";
            this.buttonFiltrar.UseVisualStyleBackColor = false;
            this.buttonFiltrar.Click += new System.EventHandler(this.buttonFiltrar_Click);
            // 
            // textBoxClientesFiltrar
            // 
            this.textBoxClientesFiltrar.Location = new System.Drawing.Point(4, 27);
            this.textBoxClientesFiltrar.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxClientesFiltrar.Name = "textBoxClientesFiltrar";
            this.textBoxClientesFiltrar.Size = new System.Drawing.Size(189, 20);
            this.textBoxClientesFiltrar.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelMostrarParaGuardar);
            this.groupBox1.Controls.Add(this.textboxNif);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textboxMorada);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textboxContacto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textboxNome);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.toolStrip1);
            this.groupBox1.Location = new System.Drawing.Point(278, 3);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(370, 430);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ficha de Cliente";
            // 
            // labelMostrarParaGuardar
            // 
            this.labelMostrarParaGuardar.AutoSize = true;
            this.labelMostrarParaGuardar.Location = new System.Drawing.Point(39, 298);
            this.labelMostrarParaGuardar.Name = "labelMostrarParaGuardar";
            this.labelMostrarParaGuardar.Size = new System.Drawing.Size(297, 13);
            this.labelMostrarParaGuardar.TabIndex = 10;
            this.labelMostrarParaGuardar.Text = "Depois de editar o que pretende precisa de clicar em Guardar";
            this.labelMostrarParaGuardar.Visible = false;
            // 
            // textboxNif
            // 
            this.textboxNif.Location = new System.Drawing.Point(101, 252);
            this.textboxNif.Margin = new System.Windows.Forms.Padding(2);
            this.textboxNif.Name = "textboxNif";
            this.textboxNif.ReadOnly = true;
            this.textboxNif.Size = new System.Drawing.Size(191, 20);
            this.textboxNif.TabIndex = 9;
            this.textboxNif.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxNif_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 252);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "NIF:";
            // 
            // textboxMorada
            // 
            this.textboxMorada.Location = new System.Drawing.Point(101, 222);
            this.textboxMorada.Margin = new System.Windows.Forms.Padding(2);
            this.textboxMorada.Name = "textboxMorada";
            this.textboxMorada.ReadOnly = true;
            this.textboxMorada.Size = new System.Drawing.Size(191, 20);
            this.textboxMorada.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 222);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Morada:";
            // 
            // textboxContacto
            // 
            this.textboxContacto.Location = new System.Drawing.Point(101, 191);
            this.textboxContacto.Margin = new System.Windows.Forms.Padding(2);
            this.textboxContacto.Name = "textboxContacto";
            this.textboxContacto.ReadOnly = true;
            this.textboxContacto.Size = new System.Drawing.Size(191, 20);
            this.textboxContacto.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 191);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contacto:";
            // 
            // textboxNome
            // 
            this.textboxNome.Location = new System.Drawing.Point(101, 161);
            this.textboxNome.Margin = new System.Windows.Forms.Padding(2);
            this.textboxNome.Name = "textboxNome";
            this.textboxNome.ReadOnly = true;
            this.textboxNome.Size = new System.Drawing.Size(191, 20);
            this.textboxNome.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 161);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonIrParaPrimeiro,
            this.toolStripButtonAndarParaTras,
            this.toolStripTextBoxPagina,
            this.toolStripLabelMaxClientes,
            this.toolStripButtonAndarParaFrente,
            this.toolStripButtonIrParaUltimo,
            this.toolStripButtonAddCliente,
            this.toolStripButtonDelCliente,
            this.toolStripButton_editar,
            this.toolStripButtonGuardarAlteracoes,
            this.toolStripButton_exportar});
            this.toolStrip1.Location = new System.Drawing.Point(2, 15);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(366, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonIrParaPrimeiro
            // 
            this.toolStripButtonIrParaPrimeiro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonIrParaPrimeiro.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonIrParaPrimeiro.Image")));
            this.toolStripButtonIrParaPrimeiro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonIrParaPrimeiro.Name = "toolStripButtonIrParaPrimeiro";
            this.toolStripButtonIrParaPrimeiro.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonIrParaPrimeiro.Text = "Ir para o Primeiro Cliente";
            this.toolStripButtonIrParaPrimeiro.Click += new System.EventHandler(this.toolStripButtonIrParaPrimeiro_Click);
            // 
            // toolStripButtonAndarParaTras
            // 
            this.toolStripButtonAndarParaTras.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAndarParaTras.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAndarParaTras.Image")));
            this.toolStripButtonAndarParaTras.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAndarParaTras.Name = "toolStripButtonAndarParaTras";
            this.toolStripButtonAndarParaTras.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonAndarParaTras.Text = "Ir para o Cliente Anterior";
            this.toolStripButtonAndarParaTras.Click += new System.EventHandler(this.toolStripButtonAndarParaTras_Click);
            // 
            // toolStripTextBoxPagina
            // 
            this.toolStripTextBoxPagina.Name = "toolStripTextBoxPagina";
            this.toolStripTextBoxPagina.Size = new System.Drawing.Size(76, 27);
            // 
            // toolStripLabelMaxClientes
            // 
            this.toolStripLabelMaxClientes.Name = "toolStripLabelMaxClientes";
            this.toolStripLabelMaxClientes.Size = new System.Drawing.Size(13, 24);
            this.toolStripLabelMaxClientes.Text = "9";
            // 
            // toolStripButtonAndarParaFrente
            // 
            this.toolStripButtonAndarParaFrente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAndarParaFrente.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAndarParaFrente.Image")));
            this.toolStripButtonAndarParaFrente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAndarParaFrente.Name = "toolStripButtonAndarParaFrente";
            this.toolStripButtonAndarParaFrente.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonAndarParaFrente.Text = "ir para o Próximo Cliente";
            this.toolStripButtonAndarParaFrente.Click += new System.EventHandler(this.toolStripButtonAndarParaFrente_Click);
            // 
            // toolStripButtonIrParaUltimo
            // 
            this.toolStripButtonIrParaUltimo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonIrParaUltimo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonIrParaUltimo.Image")));
            this.toolStripButtonIrParaUltimo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonIrParaUltimo.Name = "toolStripButtonIrParaUltimo";
            this.toolStripButtonIrParaUltimo.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonIrParaUltimo.Text = "Ir para o Último Cliente";
            this.toolStripButtonIrParaUltimo.Click += new System.EventHandler(this.toolStripButtonIrParaUltimo_Click);
            // 
            // toolStripButtonAddCliente
            // 
            this.toolStripButtonAddCliente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAddCliente.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAddCliente.Image")));
            this.toolStripButtonAddCliente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddCliente.Name = "toolStripButtonAddCliente";
            this.toolStripButtonAddCliente.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonAddCliente.Text = "Adicionar Cliente";
            this.toolStripButtonAddCliente.Click += new System.EventHandler(this.toolStripButtonAddCliente_Click);
            // 
            // toolStripButtonDelCliente
            // 
            this.toolStripButtonDelCliente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDelCliente.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDelCliente.Image")));
            this.toolStripButtonDelCliente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDelCliente.Name = "toolStripButtonDelCliente";
            this.toolStripButtonDelCliente.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonDelCliente.Text = "Eliminar Cliente";
            this.toolStripButtonDelCliente.Click += new System.EventHandler(this.toolStripButtonDelCliente_Click);
            // 
            // toolStripButton_editar
            // 
            this.toolStripButton_editar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_editar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_editar.Image")));
            this.toolStripButton_editar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_editar.Name = "toolStripButton_editar";
            this.toolStripButton_editar.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton_editar.Text = "Editar Cliente";
            this.toolStripButton_editar.ToolTipText = "Editar Cliente";
            this.toolStripButton_editar.Click += new System.EventHandler(this.toolStripButton_editar_Click);
            // 
            // toolStripButtonGuardarAlteracoes
            // 
            this.toolStripButtonGuardarAlteracoes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonGuardarAlteracoes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripButtonGuardarAlteracoes.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonGuardarAlteracoes.Image")));
            this.toolStripButtonGuardarAlteracoes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonGuardarAlteracoes.Name = "toolStripButtonGuardarAlteracoes";
            this.toolStripButtonGuardarAlteracoes.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonGuardarAlteracoes.Text = "Guardar Edição de Cliente";
            this.toolStripButtonGuardarAlteracoes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripButtonGuardarAlteracoes.ToolTipText = "Guardar Alterações";
            this.toolStripButtonGuardarAlteracoes.Click += new System.EventHandler(this.toolStripButtonGuardarAlteracoes_Click);
            // 
            // toolStripButton_exportar
            // 
            this.toolStripButton_exportar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_exportar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_exportar.Image")));
            this.toolStripButton_exportar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_exportar.Name = "toolStripButton_exportar";
            this.toolStripButton_exportar.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton_exportar.Text = "Exportar Cliente";
            this.toolStripButton_exportar.Click += new System.EventHandler(this.toolStripButton_exportar_Click);
            // 
            // GestaoDeClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 445);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Lista_de_clie_gbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GestaoDeClientes";
            this.Text = "Gestão de Clientes";
            this.Lista_de_clie_gbox.ResumeLayout(false);
            this.Lista_de_clie_gbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Lista_de_clie_gbox;
        private System.Windows.Forms.Button buttonFiltrar;
        private System.Windows.Forms.TextBox textBoxClientesFiltrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textboxNif;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textboxMorada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textboxContacto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textboxNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonIrParaPrimeiro;
        private System.Windows.Forms.ToolStripButton toolStripButtonAndarParaTras;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxPagina;
        private System.Windows.Forms.ToolStripLabel toolStripLabelMaxClientes;
        private System.Windows.Forms.ToolStripButton toolStripButtonAndarParaFrente;
        private System.Windows.Forms.ToolStripButton toolStripButtonIrParaUltimo;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddCliente;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelCliente;
        private System.Windows.Forms.ToolStripButton toolStripButton_editar;
        private System.Windows.Forms.ToolStripButton toolStripButton_exportar;
        private System.Windows.Forms.ToolStripButton toolStripButtonGuardarAlteracoes;
        private System.Windows.Forms.Label labelMostrarParaGuardar;
        private System.Windows.Forms.Button buttonReporPesquisa;
        private System.Windows.Forms.DataGridView clienteDataGridView;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}