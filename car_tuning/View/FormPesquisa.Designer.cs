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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPesquisa));
            this.dgCliente = new System.Windows.Forms.DataGridView();
            this.tabCliente = new Ambiance.Ambiance_TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtPesquisaCarro = new iTalk.iTalk_TextBox_Small();
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
            this.txtPesquisaPecas = new iTalk.iTalk_TextBox_Small();
            this.iTalk_Label3 = new iTalk.iTalk_Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtPesquisaFunc = new iTalk.iTalk_TextBox_Small();
            this.iTalk_Label4 = new iTalk.iTalk_Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbServiço = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.colCodServico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCpfServico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlacaServico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValorServico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPesquisaServ = new iTalk.iTalk_TextBox_Small();
            this.iTalk_Label5 = new iTalk.iTalk_Label();
            this.btSelecionar = new iTalk.iTalk_Button_2();
            this.btVoltar = new iTalk.iTalk_Button_2();
            this.txtPesquisaCli = new iTalk.iTalk_TextBox_Small();
            this.iTalk_Label1 = new iTalk.iTalk_Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgCliente)).BeginInit();
            this.tabCliente.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tbServiço.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // dgCliente
            // 
            this.dgCliente.AllowUserToAddRows = false;
            this.dgCliente.AllowUserToDeleteRows = false;
            this.dgCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCliente.Location = new System.Drawing.Point(6, 62);
            this.dgCliente.Name = "dgCliente";
            this.dgCliente.ReadOnly = true;
            this.dgCliente.Size = new System.Drawing.Size(1311, 568);
            this.dgCliente.TabIndex = 6;
            this.dgCliente.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCliente_CellContentDoubleClick);
            // 
            // tabCliente
            // 
            this.tabCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabCliente.Controls.Add(this.tabPage2);
            this.tabCliente.Controls.Add(this.tabPage1);
            this.tabCliente.Controls.Add(this.tabPage3);
            this.tabCliente.Controls.Add(this.tbServiço);
            this.tabCliente.ItemSize = new System.Drawing.Size(80, 24);
            this.tabCliente.Location = new System.Drawing.Point(1, 25);
            this.tabCliente.Name = "tabCliente";
            this.tabCliente.SelectedIndex = 0;
            this.tabCliente.Size = new System.Drawing.Size(1331, 665);
            this.tabCliente.TabIndex = 6;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.tabPage2.Controls.Add(this.txtPesquisaCarro);
            this.tabPage2.Controls.Add(this.iTalk_Label2);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1323, 633);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Carro";
            // 
            // txtPesquisaCarro
            // 
            this.txtPesquisaCarro.BackColor = System.Drawing.Color.Transparent;
            this.txtPesquisaCarro.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtPesquisaCarro.ForeColor = System.Drawing.Color.DimGray;
            this.txtPesquisaCarro.Location = new System.Drawing.Point(93, 15);
            this.txtPesquisaCarro.MaxLength = 32767;
            this.txtPesquisaCarro.Multiline = false;
            this.txtPesquisaCarro.Name = "txtPesquisaCarro";
            this.txtPesquisaCarro.ReadOnly = false;
            this.txtPesquisaCarro.Size = new System.Drawing.Size(1153, 28);
            this.txtPesquisaCarro.TabIndex = 10;
            this.txtPesquisaCarro.Text = "Digite a Placa ou CPF do Cliente";
            this.txtPesquisaCarro.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPesquisaCarro.UseSystemPasswordChar = false;
            this.txtPesquisaCarro.Enter += new System.EventHandler(this.txtPesquisaCarro_Enter);
            this.txtPesquisaCarro.Leave += new System.EventHandler(this.txtPesquisaCarro_Leave);
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
            this.tabPage1.AutoScroll = true;
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Controls.Add(this.txtPesquisaPecas);
            this.tabPage1.Controls.Add(this.iTalk_Label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(1323, 633);
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
            // txtPesquisaPecas
            // 
            this.txtPesquisaPecas.BackColor = System.Drawing.Color.Transparent;
            this.txtPesquisaPecas.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtPesquisaPecas.ForeColor = System.Drawing.Color.DimGray;
            this.txtPesquisaPecas.Location = new System.Drawing.Point(93, 15);
            this.txtPesquisaPecas.MaxLength = 32767;
            this.txtPesquisaPecas.Multiline = false;
            this.txtPesquisaPecas.Name = "txtPesquisaPecas";
            this.txtPesquisaPecas.ReadOnly = false;
            this.txtPesquisaPecas.Size = new System.Drawing.Size(1152, 28);
            this.txtPesquisaPecas.TabIndex = 12;
            this.txtPesquisaPecas.Text = "Digite o Código, Fabricante ou Tipo";
            this.txtPesquisaPecas.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPesquisaPecas.UseSystemPasswordChar = false;
            this.txtPesquisaPecas.Enter += new System.EventHandler(this.txtPesquisaPecas_Enter);
            this.txtPesquisaPecas.Leave += new System.EventHandler(this.txtPesquisaPecas_Leave);
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
            this.tabPage3.Controls.Add(this.txtPesquisaFunc);
            this.tabPage3.Controls.Add(this.iTalk_Label4);
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(1323, 633);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Funcionario";
            // 
            // txtPesquisaFunc
            // 
            this.txtPesquisaFunc.BackColor = System.Drawing.Color.Transparent;
            this.txtPesquisaFunc.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtPesquisaFunc.ForeColor = System.Drawing.Color.DimGray;
            this.txtPesquisaFunc.Location = new System.Drawing.Point(93, 15);
            this.txtPesquisaFunc.MaxLength = 32767;
            this.txtPesquisaFunc.Multiline = false;
            this.txtPesquisaFunc.Name = "txtPesquisaFunc";
            this.txtPesquisaFunc.ReadOnly = false;
            this.txtPesquisaFunc.Size = new System.Drawing.Size(1135, 28);
            this.txtPesquisaFunc.TabIndex = 14;
            this.txtPesquisaFunc.Text = "Digite o CPF ou Nome ";
            this.txtPesquisaFunc.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPesquisaFunc.UseSystemPasswordChar = false;
            this.txtPesquisaFunc.Enter += new System.EventHandler(this.txtPesquisaFunc_Enter);
            this.txtPesquisaFunc.Leave += new System.EventHandler(this.txtPesquisaFunc_Leave);
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
            // tbServiço
            // 
            this.tbServiço.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.tbServiço.Controls.Add(this.dataGridView4);
            this.tbServiço.Controls.Add(this.txtPesquisaServ);
            this.tbServiço.Controls.Add(this.iTalk_Label5);
            this.tbServiço.Location = new System.Drawing.Point(4, 28);
            this.tbServiço.Margin = new System.Windows.Forms.Padding(2);
            this.tbServiço.Name = "tbServiço";
            this.tbServiço.Padding = new System.Windows.Forms.Padding(2);
            this.tbServiço.Size = new System.Drawing.Size(1323, 633);
            this.tbServiço.TabIndex = 4;
            this.tbServiço.Text = "Serviço";
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
            // txtPesquisaServ
            // 
            this.txtPesquisaServ.BackColor = System.Drawing.Color.Transparent;
            this.txtPesquisaServ.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtPesquisaServ.ForeColor = System.Drawing.Color.DimGray;
            this.txtPesquisaServ.Location = new System.Drawing.Point(93, 15);
            this.txtPesquisaServ.MaxLength = 32767;
            this.txtPesquisaServ.Multiline = false;
            this.txtPesquisaServ.Name = "txtPesquisaServ";
            this.txtPesquisaServ.ReadOnly = false;
            this.txtPesquisaServ.Size = new System.Drawing.Size(1134, 28);
            this.txtPesquisaServ.TabIndex = 16;
            this.txtPesquisaServ.Text = "Digite o Codigo do Serviço, Placa do Carro ou CPF do Cliente";
            this.txtPesquisaServ.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPesquisaServ.UseSystemPasswordChar = false;
            this.txtPesquisaServ.Enter += new System.EventHandler(this.txtPesquisaServ_Enter);
            this.txtPesquisaServ.Leave += new System.EventHandler(this.txtPesquisaServ_Leave);
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
            // btSelecionar
            // 
            this.btSelecionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btSelecionar.BackColor = System.Drawing.Color.Transparent;
            this.btSelecionar.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btSelecionar.ForeColor = System.Drawing.Color.White;
            this.btSelecionar.Image = null;
            this.btSelecionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSelecionar.Location = new System.Drawing.Point(1094, 697);
            this.btSelecionar.Name = "btSelecionar";
            this.btSelecionar.Size = new System.Drawing.Size(116, 40);
            this.btSelecionar.TabIndex = 2;
            this.btSelecionar.Text = "Selecionar";
            this.btSelecionar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btSelecionar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // btVoltar
            // 
            this.btVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btVoltar.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btVoltar.ForeColor = System.Drawing.Color.White;
            this.btVoltar.Image = null;
            this.btVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btVoltar.Location = new System.Drawing.Point(1216, 697);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(116, 40);
            this.btVoltar.TabIndex = 2;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // txtPesquisaCli
            // 
            this.txtPesquisaCli.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisaCli.BackColor = System.Drawing.Color.Transparent;
            this.txtPesquisaCli.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtPesquisaCli.ForeColor = System.Drawing.Color.DimGray;
            this.txtPesquisaCli.Location = new System.Drawing.Point(93, 15);
            this.txtPesquisaCli.MaxLength = 32767;
            this.txtPesquisaCli.Multiline = false;
            this.txtPesquisaCli.Name = "txtPesquisaCli";
            this.txtPesquisaCli.ReadOnly = false;
            this.txtPesquisaCli.Size = new System.Drawing.Size(1149, 28);
            this.txtPesquisaCli.TabIndex = 8;
            this.txtPesquisaCli.Tag = "";
            this.txtPesquisaCli.Text = "Digite o CPF, Nome ou Email";
            this.txtPesquisaCli.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPesquisaCli.UseSystemPasswordChar = false;
            this.txtPesquisaCli.Enter += new System.EventHandler(this.txtPesquisa_Enter);
            this.txtPesquisaCli.Leave += new System.EventHandler(this.txtPesquisa_Leave);
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
            // FormPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1344, 749);
            this.Controls.Add(this.tabCliente);
            this.Controls.Add(this.btSelecionar);
            this.Controls.Add(this.btVoltar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPesquisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar";
            ((System.ComponentModel.ISupportInitialize)(this.dgCliente)).EndInit();
            this.tabCliente.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tbServiço.ResumeLayout(false);
            this.tbServiço.PerformLayout();
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
        private iTalk.iTalk_TextBox_Small txtPesquisaCli;
        private iTalk.iTalk_Label iTalk_Label1;
        private iTalk.iTalk_TextBox_Small txtPesquisaCarro;
        private iTalk.iTalk_Label iTalk_Label2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private iTalk.iTalk_TextBox_Small txtPesquisaPecas;
        private iTalk.iTalk_Label iTalk_Label3;
        private System.Windows.Forms.TabPage tabPage3;
        private iTalk.iTalk_TextBox_Small txtPesquisaFunc;
        private iTalk.iTalk_Label iTalk_Label4;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.TabPage tbServiço;
        private System.Windows.Forms.DataGridView dataGridView4;
        private iTalk.iTalk_TextBox_Small txtPesquisaServ;
        private iTalk.iTalk_Label iTalk_Label5;
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