namespace car_tuning
{
    partial class FormPesquisa
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
            this.btVoltar = new iTalk.iTalk_Button_2();
            this.btSelecionar = new iTalk.iTalk_Button_2();
            this.tabCliente = new Ambiance.Ambiance_TabControl();
            this.Cliente = new System.Windows.Forms.TabPage();
            this.txtPesquisa = new iTalk.iTalk_TextBox_Small();
            this.iTalk_Label1 = new iTalk.iTalk_Label();
            this.dgCliente = new System.Windows.Forms.DataGridView();
            this.colCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.iTalk_TextBox_Small2 = new iTalk.iTalk_TextBox_Small();
            this.iTalk_Label2 = new iTalk.iTalk_Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPotencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTorque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.colPeca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFabricante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompativel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTalk_TextBox_Small3 = new iTalk.iTalk_TextBox_Small();
            this.iTalk_Label3 = new iTalk.iTalk_Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.iTalk_TextBox_Small4 = new iTalk.iTalk_TextBox_Small();
            this.iTalk_Label4 = new iTalk.iTalk_Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.colCodServico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCpfServico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlacaServico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValorServico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTalk_TextBox_Small5 = new iTalk.iTalk_TextBox_Small();
            this.iTalk_Label5 = new iTalk.iTalk_Label();
            this.tabCliente.SuspendLayout();
            this.Cliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCliente)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // btVoltar
            // 
            this.btVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btVoltar.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btVoltar.ForeColor = System.Drawing.Color.White;
            this.btVoltar.Image = null;
            this.btVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btVoltar.Location = new System.Drawing.Point(1216, 700);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(116, 40);
            this.btVoltar.TabIndex = 2;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // btSelecionar
            // 
            this.btSelecionar.BackColor = System.Drawing.Color.Transparent;
            this.btSelecionar.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btSelecionar.ForeColor = System.Drawing.Color.White;
            this.btSelecionar.Image = null;
            this.btSelecionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSelecionar.Location = new System.Drawing.Point(1094, 700);
            this.btSelecionar.Name = "btSelecionar";
            this.btSelecionar.Size = new System.Drawing.Size(116, 40);
            this.btSelecionar.TabIndex = 2;
            this.btSelecionar.Text = "Selecionar";
            this.btSelecionar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btSelecionar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // tabCliente
            // 
            this.tabCliente.Controls.Add(this.Cliente);
            this.tabCliente.Controls.Add(this.tabPage2);
            this.tabCliente.Controls.Add(this.tabPage1);
            this.tabCliente.Controls.Add(this.tabPage3);
            this.tabCliente.Controls.Add(this.tabPage4);
            this.tabCliente.ItemSize = new System.Drawing.Size(80, 24);
            this.tabCliente.Location = new System.Drawing.Point(1, 25);
            this.tabCliente.Name = "tabCliente";
            this.tabCliente.SelectedIndex = 0;
            this.tabCliente.Size = new System.Drawing.Size(1331, 668);
            this.tabCliente.TabIndex = 6;
            // 
            // Cliente
            // 
            this.Cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.Cliente.Controls.Add(this.txtPesquisa);
            this.Cliente.Controls.Add(this.iTalk_Label1);
            this.Cliente.Controls.Add(this.dgCliente);
            this.Cliente.Location = new System.Drawing.Point(4, 28);
            this.Cliente.Name = "Cliente";
            this.Cliente.Padding = new System.Windows.Forms.Padding(3);
            this.Cliente.Size = new System.Drawing.Size(1323, 636);
            this.Cliente.TabIndex = 0;
            this.Cliente.Text = "Cliente";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.BackColor = System.Drawing.Color.Transparent;
            this.txtPesquisa.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtPesquisa.ForeColor = System.Drawing.Color.DimGray;
            this.txtPesquisa.Location = new System.Drawing.Point(93, 15);
            this.txtPesquisa.MaxLength = 32767;
            this.txtPesquisa.Multiline = false;
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.ReadOnly = false;
            this.txtPesquisa.Size = new System.Drawing.Size(1149, 28);
            this.txtPesquisa.TabIndex = 8;
            this.txtPesquisa.Tag = "";
            this.txtPesquisa.Text = "Digite o CPF, Nome ou Email";
            this.txtPesquisa.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPesquisa.UseSystemPasswordChar = false;
            // 
            // iTalk_Label1
            // 
            this.iTalk_Label1.AutoSize = true;
            this.iTalk_Label1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label1.Location = new System.Drawing.Point(16, 15);
            this.iTalk_Label1.Name = "iTalk_Label1";
            this.iTalk_Label1.Size = new System.Drawing.Size(71, 25);
            this.iTalk_Label1.TabIndex = 7;
            this.iTalk_Label1.Text = "Buscar";
            // 
            // dgCliente
            // 
            this.dgCliente.AllowUserToAddRows = false;
            this.dgCliente.AllowUserToDeleteRows = false;
            this.dgCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCpf,
            this.colNome,
            this.colTelefone,
            this.colEmail});
            this.dgCliente.Location = new System.Drawing.Point(6, 62);
            this.dgCliente.Name = "dgCliente";
            this.dgCliente.ReadOnly = true;
            this.dgCliente.Size = new System.Drawing.Size(1311, 571);
            this.dgCliente.TabIndex = 6;
            // 
            // colCpf
            // 
            this.colCpf.HeaderText = "CPF";
            this.colCpf.Name = "colCpf";
            this.colCpf.ReadOnly = true;
            // 
            // colNome
            // 
            this.colNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNome.HeaderText = "Nome";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            // 
            // colTelefone
            // 
            this.colTelefone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTelefone.HeaderText = "Telefone";
            this.colTelefone.Name = "colTelefone";
            this.colTelefone.ReadOnly = true;
            // 
            // colEmail
            // 
            this.colEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colEmail.HeaderText = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.tabPage2.Controls.Add(this.iTalk_TextBox_Small2);
            this.tabPage2.Controls.Add(this.iTalk_Label2);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1323, 636);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Carro";
            // 
            // iTalk_TextBox_Small2
            // 
            this.iTalk_TextBox_Small2.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_TextBox_Small2.Font = new System.Drawing.Font("Tahoma", 11F);
            this.iTalk_TextBox_Small2.ForeColor = System.Drawing.Color.DimGray;
            this.iTalk_TextBox_Small2.Location = new System.Drawing.Point(93, 15);
            this.iTalk_TextBox_Small2.MaxLength = 32767;
            this.iTalk_TextBox_Small2.Multiline = false;
            this.iTalk_TextBox_Small2.Name = "iTalk_TextBox_Small2";
            this.iTalk_TextBox_Small2.ReadOnly = false;
            this.iTalk_TextBox_Small2.Size = new System.Drawing.Size(1153, 28);
            this.iTalk_TextBox_Small2.TabIndex = 10;
            this.iTalk_TextBox_Small2.Text = "Digite a Placa ou CPF do Cliente";
            this.iTalk_TextBox_Small2.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.iTalk_TextBox_Small2.UseSystemPasswordChar = false;
            // 
            // iTalk_Label2
            // 
            this.iTalk_Label2.AutoSize = true;
            this.iTalk_Label2.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label2.Location = new System.Drawing.Point(16, 15);
            this.iTalk_Label2.Name = "iTalk_Label2";
            this.iTalk_Label2.Size = new System.Drawing.Size(71, 25);
            this.iTalk_Label2.TabIndex = 9;
            this.iTalk_Label2.Text = "Buscar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCod,
            this.colCliente,
            this.colPlaca,
            this.colModelo,
            this.colMarca,
            this.colPotencia,
            this.colTorque});
            this.dataGridView1.Location = new System.Drawing.Point(6, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1311, 571);
            this.dataGridView1.TabIndex = 4;
            // 
            // colCod
            // 
            this.colCod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCod.HeaderText = "Codigo";
            this.colCod.Name = "colCod";
            this.colCod.ReadOnly = true;
            this.colCod.Visible = false;
            // 
            // colCliente
            // 
            this.colCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCliente.HeaderText = "Nome";
            this.colCliente.Name = "colCliente";
            this.colCliente.ReadOnly = true;
            // 
            // colPlaca
            // 
            this.colPlaca.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPlaca.HeaderText = "Placa";
            this.colPlaca.Name = "colPlaca";
            this.colPlaca.ReadOnly = true;
            // 
            // colModelo
            // 
            this.colModelo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colModelo.HeaderText = "Modelo";
            this.colModelo.Name = "colModelo";
            this.colModelo.ReadOnly = true;
            // 
            // colMarca
            // 
            this.colMarca.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMarca.HeaderText = "Marca";
            this.colMarca.Name = "colMarca";
            this.colMarca.ReadOnly = true;
            // 
            // colPotencia
            // 
            this.colPotencia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPotencia.HeaderText = "+Potencia";
            this.colPotencia.Name = "colPotencia";
            this.colPotencia.ReadOnly = true;
            // 
            // colTorque
            // 
            this.colTorque.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTorque.HeaderText = "+Torque";
            this.colTorque.Name = "colTorque";
            this.colTorque.ReadOnly = true;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Controls.Add(this.iTalk_TextBox_Small3);
            this.tabPage1.Controls.Add(this.iTalk_Label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(1323, 636);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Peças";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPeca,
            this.colDescricao,
            this.colFabricante,
            this.colTipo,
            this.colStatus,
            this.colCompativel});
            this.dataGridView2.Location = new System.Drawing.Point(6, 62);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1311, 571);
            this.dataGridView2.TabIndex = 13;
            // 
            // colPeca
            // 
            this.colPeca.HeaderText = "Codigo";
            this.colPeca.Name = "colPeca";
            this.colPeca.ReadOnly = true;
            this.colPeca.Width = 80;
            // 
            // colDescricao
            // 
            this.colDescricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDescricao.HeaderText = "Descricao";
            this.colDescricao.Name = "colDescricao";
            this.colDescricao.ReadOnly = true;
            // 
            // colFabricante
            // 
            this.colFabricante.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFabricante.HeaderText = "Fabricante";
            this.colFabricante.Name = "colFabricante";
            this.colFabricante.ReadOnly = true;
            // 
            // colTipo
            // 
            this.colTipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTipo.HeaderText = "Tipo";
            this.colTipo.Name = "colTipo";
            this.colTipo.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // colCompativel
            // 
            this.colCompativel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCompativel.HeaderText = "Compativel";
            this.colCompativel.Name = "colCompativel";
            this.colCompativel.ReadOnly = true;
            // 
            // iTalk_TextBox_Small3
            // 
            this.iTalk_TextBox_Small3.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_TextBox_Small3.Font = new System.Drawing.Font("Tahoma", 11F);
            this.iTalk_TextBox_Small3.ForeColor = System.Drawing.Color.DimGray;
            this.iTalk_TextBox_Small3.Location = new System.Drawing.Point(93, 15);
            this.iTalk_TextBox_Small3.MaxLength = 32767;
            this.iTalk_TextBox_Small3.Multiline = false;
            this.iTalk_TextBox_Small3.Name = "iTalk_TextBox_Small3";
            this.iTalk_TextBox_Small3.ReadOnly = false;
            this.iTalk_TextBox_Small3.Size = new System.Drawing.Size(1152, 28);
            this.iTalk_TextBox_Small3.TabIndex = 12;
            this.iTalk_TextBox_Small3.Text = "Digite o Código, Fabricante ou Tipo";
            this.iTalk_TextBox_Small3.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.iTalk_TextBox_Small3.UseSystemPasswordChar = false;
            // 
            // iTalk_Label3
            // 
            this.iTalk_Label3.AutoSize = true;
            this.iTalk_Label3.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label3.Location = new System.Drawing.Point(16, 15);
            this.iTalk_Label3.Name = "iTalk_Label3";
            this.iTalk_Label3.Size = new System.Drawing.Size(71, 25);
            this.iTalk_Label3.TabIndex = 11;
            this.iTalk_Label3.Text = "Buscar";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.tabPage3.Controls.Add(this.iTalk_TextBox_Small4);
            this.tabPage3.Controls.Add(this.iTalk_Label4);
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(1323, 636);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Funcionario";
            // 
            // iTalk_TextBox_Small4
            // 
            this.iTalk_TextBox_Small4.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_TextBox_Small4.Font = new System.Drawing.Font("Tahoma", 11F);
            this.iTalk_TextBox_Small4.ForeColor = System.Drawing.Color.DimGray;
            this.iTalk_TextBox_Small4.Location = new System.Drawing.Point(93, 15);
            this.iTalk_TextBox_Small4.MaxLength = 32767;
            this.iTalk_TextBox_Small4.Multiline = false;
            this.iTalk_TextBox_Small4.Name = "iTalk_TextBox_Small4";
            this.iTalk_TextBox_Small4.ReadOnly = false;
            this.iTalk_TextBox_Small4.Size = new System.Drawing.Size(1135, 28);
            this.iTalk_TextBox_Small4.TabIndex = 14;
            this.iTalk_TextBox_Small4.Text = "Digite o CPF ou Nome ";
            this.iTalk_TextBox_Small4.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.iTalk_TextBox_Small4.UseSystemPasswordChar = false;
            // 
            // iTalk_Label4
            // 
            this.iTalk_Label4.AutoSize = true;
            this.iTalk_Label4.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label4.Location = new System.Drawing.Point(16, 15);
            this.iTalk_Label4.Name = "iTalk_Label4";
            this.iTalk_Label4.Size = new System.Drawing.Size(71, 25);
            this.iTalk_Label4.TabIndex = 13;
            this.iTalk_Label4.Text = "Buscar";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column10,
            this.Column11});
            this.dataGridView3.Location = new System.Drawing.Point(6, 62);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(1311, 571);
            this.dataGridView3.TabIndex = 0;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column9.HeaderText = "CPF";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column10.HeaderText = "Nome";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column11.HeaderText = "Telefone";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.tabPage4.Controls.Add(this.dataGridView4);
            this.tabPage4.Controls.Add(this.iTalk_TextBox_Small5);
            this.tabPage4.Controls.Add(this.iTalk_Label5);
            this.tabPage4.Location = new System.Drawing.Point(4, 28);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage4.Size = new System.Drawing.Size(1323, 636);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "tabPage4";
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodServico,
            this.colCpfServico,
            this.colPlacaServico,
            this.colNomeFuncionario,
            this.colValorServico});
            this.dataGridView4.Location = new System.Drawing.Point(6, 62);
            this.dataGridView4.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(1311, 571);
            this.dataGridView4.TabIndex = 17;
            // 
            // colCodServico
            // 
            this.colCodServico.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCodServico.HeaderText = "Codigo";
            this.colCodServico.Name = "colCodServico";
            this.colCodServico.ReadOnly = true;
            // 
            // colCpfServico
            // 
            this.colCpfServico.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCpfServico.HeaderText = "Cliente";
            this.colCpfServico.Name = "colCpfServico";
            this.colCpfServico.ReadOnly = true;
            // 
            // colPlacaServico
            // 
            this.colPlacaServico.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPlacaServico.HeaderText = "Placa";
            this.colPlacaServico.Name = "colPlacaServico";
            this.colPlacaServico.ReadOnly = true;
            // 
            // colNomeFuncionario
            // 
            this.colNomeFuncionario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNomeFuncionario.HeaderText = "Funcionario";
            this.colNomeFuncionario.Name = "colNomeFuncionario";
            this.colNomeFuncionario.ReadOnly = true;
            // 
            // colValorServico
            // 
            this.colValorServico.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colValorServico.HeaderText = "ValorTotal";
            this.colValorServico.Name = "colValorServico";
            this.colValorServico.ReadOnly = true;
            // 
            // iTalk_TextBox_Small5
            // 
            this.iTalk_TextBox_Small5.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_TextBox_Small5.Font = new System.Drawing.Font("Tahoma", 11F);
            this.iTalk_TextBox_Small5.ForeColor = System.Drawing.Color.DimGray;
            this.iTalk_TextBox_Small5.Location = new System.Drawing.Point(93, 15);
            this.iTalk_TextBox_Small5.MaxLength = 32767;
            this.iTalk_TextBox_Small5.Multiline = false;
            this.iTalk_TextBox_Small5.Name = "iTalk_TextBox_Small5";
            this.iTalk_TextBox_Small5.ReadOnly = false;
            this.iTalk_TextBox_Small5.Size = new System.Drawing.Size(1134, 28);
            this.iTalk_TextBox_Small5.TabIndex = 16;
            this.iTalk_TextBox_Small5.Text = "Digite o Codigo do Serviço, Placa do Carro ou CPF do Cliente";
            this.iTalk_TextBox_Small5.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.iTalk_TextBox_Small5.UseSystemPasswordChar = false;
            // 
            // iTalk_Label5
            // 
            this.iTalk_Label5.AutoSize = true;
            this.iTalk_Label5.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label5.Location = new System.Drawing.Point(16, 15);
            this.iTalk_Label5.Name = "iTalk_Label5";
            this.iTalk_Label5.Size = new System.Drawing.Size(71, 25);
            this.iTalk_Label5.TabIndex = 15;
            this.iTalk_Label5.Text = "Buscar";
            // 
            // FormPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 752);
            this.ControlBox = false;
            this.Controls.Add(this.tabCliente);
            this.Controls.Add(this.btSelecionar);
            this.Controls.Add(this.btVoltar);
            this.Name = "FormPesquisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar";
            this.tabCliente.ResumeLayout(false);
            this.Cliente.ResumeLayout(false);
            this.Cliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCliente)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private iTalk.iTalk_Button_2 btVoltar;
        private iTalk.iTalk_Button_2 btSelecionar;
        private Ambiance.Ambiance_TabControl tabCliente;
        private System.Windows.Forms.TabPage Cliente;
        private System.Windows.Forms.DataGridView dgCliente;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private iTalk.iTalk_TextBox_Small txtPesquisa;
        private iTalk.iTalk_Label iTalk_Label1;
        private iTalk.iTalk_TextBox_Small iTalk_TextBox_Small2;
        private iTalk.iTalk_Label iTalk_Label2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private iTalk.iTalk_TextBox_Small iTalk_TextBox_Small3;
        private iTalk.iTalk_Label iTalk_Label3;
        private System.Windows.Forms.TabPage tabPage3;
        private iTalk.iTalk_TextBox_Small iTalk_TextBox_Small4;
        private iTalk.iTalk_Label iTalk_Label4;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridView4;
        private iTalk.iTalk_TextBox_Small iTalk_TextBox_Small5;
        private iTalk.iTalk_Label iTalk_Label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPotencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTorque;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPeca;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFabricante;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompativel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodServico;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCpfServico;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlacaServico;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValorServico;
    }
}