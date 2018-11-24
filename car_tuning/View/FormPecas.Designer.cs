namespace car_tuning
{
    partial class FormPecas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPecas));
            this.iTalk_GroupBox1 = new iTalk.iTalk_GroupBox();
            this.dgvPecas = new System.Windows.Forms.DataGridView();
            this.colPeca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompativel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPotencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTorque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTorque = new iTalk.iTalk_TextBox_Small();
            this.txtPotencia = new iTalk.iTalk_TextBox_Small();
            this.txtMarca = new iTalk.iTalk_ComboBox();
            this.iTalk_Label7 = new iTalk.iTalk_Label();
            this.iTalk_Label8 = new iTalk.iTalk_Label();
            this.iTalk_Label6 = new iTalk.iTalk_Label();
            this.iTalk_Label4 = new iTalk.iTalk_Label();
            this.iTalk_Label3 = new iTalk.iTalk_Label();
            this.txtPeso = new iTalk.iTalk_TextBox_Small();
            this.iTalk_Label9 = new iTalk.iTalk_Label();
            this.iTalk_Label2 = new iTalk.iTalk_Label();
            this.iTalk_Label5 = new iTalk.iTalk_Label();
            this.iTalk_Label11 = new iTalk.iTalk_Label();
            this.iTalk_Label1 = new iTalk.iTalk_Label();
            this.txtTipo = new iTalk.iTalk_TextBox_Small();
            this.txtFabri = new iTalk.iTalk_TextBox_Small();
            this.txtPreco = new iTalk.iTalk_TextBox_Small();
            this.txtDescri = new iTalk.iTalk_TextBox_Small();
            this.iTalk_TextBox_Small4 = new iTalk.iTalk_TextBox_Small();
            this.txtCodigo = new iTalk.iTalk_TextBox_Small();
            this.btPesquisar = new iTalk.iTalk_Button_2();
            this.btNovo = new iTalk.iTalk_Button_2();
            this.btSalvar = new iTalk.iTalk_Button_2();
            this.btLimpar = new iTalk.iTalk_Button_2();
            this.btEditar = new iTalk.iTalk_Button_2();
            this.btExcluir = new iTalk.iTalk_Button_2();
            this.iTalk_GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPecas)).BeginInit();
            this.SuspendLayout();
            // 
            // iTalk_GroupBox1
            // 
            this.iTalk_GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_GroupBox1.Controls.Add(this.dgvPecas);
            this.iTalk_GroupBox1.Controls.Add(this.txtTorque);
            this.iTalk_GroupBox1.Controls.Add(this.txtPotencia);
            this.iTalk_GroupBox1.Controls.Add(this.txtMarca);
            this.iTalk_GroupBox1.Controls.Add(this.iTalk_Label7);
            this.iTalk_GroupBox1.Controls.Add(this.iTalk_Label8);
            this.iTalk_GroupBox1.Controls.Add(this.iTalk_Label6);
            this.iTalk_GroupBox1.Controls.Add(this.iTalk_Label4);
            this.iTalk_GroupBox1.Controls.Add(this.iTalk_Label3);
            this.iTalk_GroupBox1.Controls.Add(this.txtPeso);
            this.iTalk_GroupBox1.Controls.Add(this.iTalk_Label9);
            this.iTalk_GroupBox1.Controls.Add(this.iTalk_Label2);
            this.iTalk_GroupBox1.Controls.Add(this.iTalk_Label5);
            this.iTalk_GroupBox1.Controls.Add(this.iTalk_Label11);
            this.iTalk_GroupBox1.Controls.Add(this.iTalk_Label1);
            this.iTalk_GroupBox1.Controls.Add(this.txtTipo);
            this.iTalk_GroupBox1.Controls.Add(this.txtFabri);
            this.iTalk_GroupBox1.Controls.Add(this.txtPreco);
            this.iTalk_GroupBox1.Controls.Add(this.txtDescri);
            this.iTalk_GroupBox1.Controls.Add(this.iTalk_TextBox_Small4);
            this.iTalk_GroupBox1.Controls.Add(this.txtCodigo);
            this.iTalk_GroupBox1.Location = new System.Drawing.Point(159, 21);
            this.iTalk_GroupBox1.MinimumSize = new System.Drawing.Size(136, 50);
            this.iTalk_GroupBox1.Name = "iTalk_GroupBox1";
            this.iTalk_GroupBox1.Padding = new System.Windows.Forms.Padding(5, 28, 5, 5);
            this.iTalk_GroupBox1.Size = new System.Drawing.Size(1180, 726);
            this.iTalk_GroupBox1.TabIndex = 10;
            this.iTalk_GroupBox1.Text = "Peças";
            // 
            // dgvPecas
            // 
            this.dgvPecas.AllowUserToAddRows = false;
            this.dgvPecas.AllowUserToDeleteRows = false;
            this.dgvPecas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPecas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPeca,
            this.colDescricao,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.colCompativel,
            this.colPeso,
            this.colPotencia,
            this.colTorque});
            this.dgvPecas.Location = new System.Drawing.Point(22, 361);
            this.dgvPecas.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPecas.Name = "dgvPecas";
            this.dgvPecas.ReadOnly = true;
            this.dgvPecas.RowTemplate.Height = 24;
            this.dgvPecas.Size = new System.Drawing.Size(1144, 352);
            this.dgvPecas.TabIndex = 14;
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Fabricante";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Tipo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // colCompativel
            // 
            this.colCompativel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCompativel.HeaderText = "Compativel";
            this.colCompativel.Name = "colCompativel";
            this.colCompativel.ReadOnly = true;
            // 
            // colPeso
            // 
            this.colPeso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPeso.HeaderText = "Peso";
            this.colPeso.Name = "colPeso";
            this.colPeso.ReadOnly = true;
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
            // txtTorque
            // 
            this.txtTorque.BackColor = System.Drawing.Color.Transparent;
            this.txtTorque.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtTorque.ForeColor = System.Drawing.Color.DimGray;
            this.txtTorque.Location = new System.Drawing.Point(754, 221);
            this.txtTorque.MaxLength = 32767;
            this.txtTorque.Multiline = false;
            this.txtTorque.Name = "txtTorque";
            this.txtTorque.ReadOnly = false;
            this.txtTorque.Size = new System.Drawing.Size(185, 28);
            this.txtTorque.TabIndex = 0;
            this.txtTorque.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTorque.UseSystemPasswordChar = false;
            // 
            // txtPotencia
            // 
            this.txtPotencia.BackColor = System.Drawing.Color.Transparent;
            this.txtPotencia.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtPotencia.ForeColor = System.Drawing.Color.DimGray;
            this.txtPotencia.Location = new System.Drawing.Point(754, 174);
            this.txtPotencia.MaxLength = 32767;
            this.txtPotencia.Multiline = false;
            this.txtPotencia.Name = "txtPotencia";
            this.txtPotencia.ReadOnly = false;
            this.txtPotencia.Size = new System.Drawing.Size(185, 28);
            this.txtPotencia.TabIndex = 0;
            this.txtPotencia.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPotencia.UseSystemPasswordChar = false;
            // 
            // txtMarca
            // 
            this.txtMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.txtMarca.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtMarca.DropDownHeight = 100;
            this.txtMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtMarca.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.txtMarca.FormattingEnabled = true;
            this.txtMarca.HoverSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.txtMarca.IntegralHeight = false;
            this.txtMarca.ItemHeight = 20;
            this.txtMarca.Items.AddRange(new object[] {
            "FIAT",
            "MERCEDEZ",
            "BMW",
            "VOLKSWAGEM"});
            this.txtMarca.Location = new System.Drawing.Point(754, 82);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(185, 26);
            this.txtMarca.StartIndex = 0;
            this.txtMarca.TabIndex = 2;
            // 
            // iTalk_Label7
            // 
            this.iTalk_Label7.AutoSize = true;
            this.iTalk_Label7.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label7.Location = new System.Drawing.Point(680, 221);
            this.iTalk_Label7.Name = "iTalk_Label7";
            this.iTalk_Label7.Size = new System.Drawing.Size(68, 21);
            this.iTalk_Label7.TabIndex = 1;
            this.iTalk_Label7.Text = "+Torque";
            // 
            // iTalk_Label8
            // 
            this.iTalk_Label8.AutoSize = true;
            this.iTalk_Label8.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label8.Location = new System.Drawing.Point(612, 84);
            this.iTalk_Label8.Name = "iTalk_Label8";
            this.iTalk_Label8.Size = new System.Drawing.Size(136, 21);
            this.iTalk_Label8.TabIndex = 1;
            this.iTalk_Label8.Text = "Marca Compativel";
            // 
            // iTalk_Label6
            // 
            this.iTalk_Label6.AutoSize = true;
            this.iTalk_Label6.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label6.Location = new System.Drawing.Point(669, 174);
            this.iTalk_Label6.Name = "iTalk_Label6";
            this.iTalk_Label6.Size = new System.Drawing.Size(79, 21);
            this.iTalk_Label6.TabIndex = 1;
            this.iTalk_Label6.Text = "+Potencia";
            // 
            // iTalk_Label4
            // 
            this.iTalk_Label4.AutoSize = true;
            this.iTalk_Label4.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label4.Location = new System.Drawing.Point(706, 130);
            this.iTalk_Label4.Name = "iTalk_Label4";
            this.iTalk_Label4.Size = new System.Drawing.Size(42, 21);
            this.iTalk_Label4.TabIndex = 1;
            this.iTalk_Label4.Text = "Peso";
            // 
            // iTalk_Label3
            // 
            this.iTalk_Label3.AutoSize = true;
            this.iTalk_Label3.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label3.Location = new System.Drawing.Point(130, 155);
            this.iTalk_Label3.Name = "iTalk_Label3";
            this.iTalk_Label3.Size = new System.Drawing.Size(81, 21);
            this.iTalk_Label3.TabIndex = 1;
            this.iTalk_Label3.Text = "Fabricante";
            // 
            // txtPeso
            // 
            this.txtPeso.BackColor = System.Drawing.Color.Transparent;
            this.txtPeso.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtPeso.ForeColor = System.Drawing.Color.DimGray;
            this.txtPeso.Location = new System.Drawing.Point(754, 127);
            this.txtPeso.MaxLength = 32767;
            this.txtPeso.Multiline = false;
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.ReadOnly = false;
            this.txtPeso.Size = new System.Drawing.Size(185, 28);
            this.txtPeso.TabIndex = 0;
            this.txtPeso.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPeso.UseSystemPasswordChar = false;
            // 
            // iTalk_Label9
            // 
            this.iTalk_Label9.AutoSize = true;
            this.iTalk_Label9.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label9.Location = new System.Drawing.Point(130, 256);
            this.iTalk_Label9.Name = "iTalk_Label9";
            this.iTalk_Label9.Size = new System.Drawing.Size(40, 21);
            this.iTalk_Label9.TabIndex = 1;
            this.iTalk_Label9.Text = "Tipo";
            // 
            // iTalk_Label2
            // 
            this.iTalk_Label2.AutoSize = true;
            this.iTalk_Label2.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label2.Location = new System.Drawing.Point(130, 107);
            this.iTalk_Label2.Name = "iTalk_Label2";
            this.iTalk_Label2.Size = new System.Drawing.Size(77, 21);
            this.iTalk_Label2.TabIndex = 1;
            this.iTalk_Label2.Text = "Descrição";
            // 
            // iTalk_Label5
            // 
            this.iTalk_Label5.AutoSize = true;
            this.iTalk_Label5.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label5.Location = new System.Drawing.Point(130, 208);
            this.iTalk_Label5.Name = "iTalk_Label5";
            this.iTalk_Label5.Size = new System.Drawing.Size(49, 21);
            this.iTalk_Label5.TabIndex = 1;
            this.iTalk_Label5.Text = "Preço";
            // 
            // iTalk_Label11
            // 
            this.iTalk_Label11.AutoSize = true;
            this.iTalk_Label11.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label11.Location = new System.Drawing.Point(18, 330);
            this.iTalk_Label11.Name = "iTalk_Label11";
            this.iTalk_Label11.Size = new System.Drawing.Size(56, 21);
            this.iTalk_Label11.TabIndex = 1;
            this.iTalk_Label11.Text = "Buscar";
            // 
            // iTalk_Label1
            // 
            this.iTalk_Label1.AutoSize = true;
            this.iTalk_Label1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label1.Location = new System.Drawing.Point(130, 58);
            this.iTalk_Label1.Name = "iTalk_Label1";
            this.iTalk_Label1.Size = new System.Drawing.Size(38, 21);
            this.iTalk_Label1.TabIndex = 1;
            this.iTalk_Label1.Text = "Cod";
            // 
            // txtTipo
            // 
            this.txtTipo.BackColor = System.Drawing.Color.Transparent;
            this.txtTipo.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtTipo.ForeColor = System.Drawing.Color.DimGray;
            this.txtTipo.Location = new System.Drawing.Point(215, 256);
            this.txtTipo.MaxLength = 32767;
            this.txtTipo.Multiline = false;
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.ReadOnly = false;
            this.txtTipo.Size = new System.Drawing.Size(232, 28);
            this.txtTipo.TabIndex = 0;
            this.txtTipo.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTipo.UseSystemPasswordChar = false;
            // 
            // txtFabri
            // 
            this.txtFabri.BackColor = System.Drawing.Color.Transparent;
            this.txtFabri.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtFabri.ForeColor = System.Drawing.Color.DimGray;
            this.txtFabri.Location = new System.Drawing.Point(215, 155);
            this.txtFabri.MaxLength = 32767;
            this.txtFabri.Multiline = false;
            this.txtFabri.Name = "txtFabri";
            this.txtFabri.ReadOnly = false;
            this.txtFabri.Size = new System.Drawing.Size(232, 28);
            this.txtFabri.TabIndex = 0;
            this.txtFabri.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFabri.UseSystemPasswordChar = false;
            // 
            // txtPreco
            // 
            this.txtPreco.BackColor = System.Drawing.Color.Transparent;
            this.txtPreco.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtPreco.ForeColor = System.Drawing.Color.DimGray;
            this.txtPreco.Location = new System.Drawing.Point(215, 208);
            this.txtPreco.MaxLength = 32767;
            this.txtPreco.Multiline = false;
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.ReadOnly = false;
            this.txtPreco.Size = new System.Drawing.Size(232, 28);
            this.txtPreco.TabIndex = 0;
            this.txtPreco.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPreco.UseSystemPasswordChar = false;
            // 
            // txtDescri
            // 
            this.txtDescri.BackColor = System.Drawing.Color.Transparent;
            this.txtDescri.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtDescri.ForeColor = System.Drawing.Color.DimGray;
            this.txtDescri.Location = new System.Drawing.Point(215, 107);
            this.txtDescri.MaxLength = 32767;
            this.txtDescri.Multiline = false;
            this.txtDescri.Name = "txtDescri";
            this.txtDescri.ReadOnly = false;
            this.txtDescri.Size = new System.Drawing.Size(232, 28);
            this.txtDescri.TabIndex = 0;
            this.txtDescri.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDescri.UseSystemPasswordChar = false;
            // 
            // iTalk_TextBox_Small4
            // 
            this.iTalk_TextBox_Small4.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_TextBox_Small4.Font = new System.Drawing.Font("Tahoma", 11F);
            this.iTalk_TextBox_Small4.ForeColor = System.Drawing.Color.DimGray;
            this.iTalk_TextBox_Small4.Location = new System.Drawing.Point(80, 328);
            this.iTalk_TextBox_Small4.MaxLength = 32767;
            this.iTalk_TextBox_Small4.Multiline = false;
            this.iTalk_TextBox_Small4.Name = "iTalk_TextBox_Small4";
            this.iTalk_TextBox_Small4.ReadOnly = false;
            this.iTalk_TextBox_Small4.Size = new System.Drawing.Size(1086, 28);
            this.iTalk_TextBox_Small4.TabIndex = 0;
            this.iTalk_TextBox_Small4.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.iTalk_TextBox_Small4.UseSystemPasswordChar = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.Transparent;
            this.txtCodigo.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtCodigo.ForeColor = System.Drawing.Color.DimGray;
            this.txtCodigo.Location = new System.Drawing.Point(215, 58);
            this.txtCodigo.MaxLength = 32767;
            this.txtCodigo.Multiline = false;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = false;
            this.txtCodigo.Size = new System.Drawing.Size(232, 28);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCodigo.UseSystemPasswordChar = false;
            // 
            // btPesquisar
            // 
            this.btPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.btPesquisar.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btPesquisar.ForeColor = System.Drawing.Color.White;
            this.btPesquisar.Image = null;
            this.btPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPesquisar.Location = new System.Drawing.Point(16, 390);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(116, 40);
            this.btPesquisar.TabIndex = 3;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // btNovo
            // 
            this.btNovo.BackColor = System.Drawing.Color.Transparent;
            this.btNovo.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btNovo.ForeColor = System.Drawing.Color.White;
            this.btNovo.Image = null;
            this.btNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btNovo.Location = new System.Drawing.Point(16, 67);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(116, 40);
            this.btNovo.TabIndex = 4;
            this.btNovo.Text = "Novo";
            this.btNovo.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btSalvar.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btSalvar.ForeColor = System.Drawing.Color.White;
            this.btSalvar.Image = null;
            this.btSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSalvar.Location = new System.Drawing.Point(16, 113);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(116, 40);
            this.btSalvar.TabIndex = 5;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.BackColor = System.Drawing.Color.Transparent;
            this.btLimpar.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btLimpar.ForeColor = System.Drawing.Color.White;
            this.btLimpar.Image = null;
            this.btLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLimpar.Location = new System.Drawing.Point(16, 159);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(116, 40);
            this.btLimpar.TabIndex = 6;
            this.btLimpar.Text = "Cancelar";
            this.btLimpar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btEditar
            // 
            this.btEditar.BackColor = System.Drawing.Color.Transparent;
            this.btEditar.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btEditar.ForeColor = System.Drawing.Color.White;
            this.btEditar.Image = null;
            this.btEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btEditar.Location = new System.Drawing.Point(16, 205);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(116, 40);
            this.btEditar.TabIndex = 7;
            this.btEditar.Text = "Editar";
            this.btEditar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.BackColor = System.Drawing.Color.Transparent;
            this.btExcluir.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btExcluir.ForeColor = System.Drawing.Color.White;
            this.btExcluir.Image = null;
            this.btExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btExcluir.Location = new System.Drawing.Point(16, 251);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(116, 40);
            this.btExcluir.TabIndex = 8;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // FormPecas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 752);
            this.ControlBox = false;
            this.Controls.Add(this.iTalk_GroupBox1);
            this.Controls.Add(this.btPesquisar);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btExcluir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPecas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.iTalk_GroupBox1.ResumeLayout(false);
            this.iTalk_GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPecas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private iTalk.iTalk_GroupBox iTalk_GroupBox1;
        private iTalk.iTalk_TextBox_Small txtTorque;
        private iTalk.iTalk_TextBox_Small txtPotencia;
        private iTalk.iTalk_ComboBox txtMarca;
        private iTalk.iTalk_Label iTalk_Label7;
        private iTalk.iTalk_Label iTalk_Label8;
        private iTalk.iTalk_Label iTalk_Label6;
        private iTalk.iTalk_Label iTalk_Label4;
        private iTalk.iTalk_Label iTalk_Label3;
        private iTalk.iTalk_TextBox_Small txtPeso;
        private iTalk.iTalk_Label iTalk_Label9;
        private iTalk.iTalk_Label iTalk_Label2;
        private iTalk.iTalk_Label iTalk_Label5;
        private iTalk.iTalk_Label iTalk_Label11;
        private iTalk.iTalk_Label iTalk_Label1;
        private iTalk.iTalk_TextBox_Small txtTipo;
        private iTalk.iTalk_TextBox_Small txtFabri;
        private iTalk.iTalk_TextBox_Small txtPreco;
        private iTalk.iTalk_TextBox_Small txtDescri;
        private iTalk.iTalk_TextBox_Small iTalk_TextBox_Small4;
        private iTalk.iTalk_TextBox_Small txtCodigo;
        private iTalk.iTalk_Button_2 btPesquisar;
        private iTalk.iTalk_Button_2 btNovo;
        private iTalk.iTalk_Button_2 btSalvar;
        private iTalk.iTalk_Button_2 btLimpar;
        private iTalk.iTalk_Button_2 btEditar;
        private iTalk.iTalk_Button_2 btExcluir;
        private System.Windows.Forms.DataGridView dgvPecas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPeca;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompativel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPeso;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPotencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTorque;
    }
}