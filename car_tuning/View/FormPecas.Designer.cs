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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.colPeca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompativel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPotencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTorque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTalk_TextBox_Small7 = new iTalk.iTalk_TextBox_Small();
            this.iTalk_TextBox_Small6 = new iTalk.iTalk_TextBox_Small();
            this.txtModelo = new iTalk.iTalk_ComboBox();
            this.iTalk_Label7 = new iTalk.iTalk_Label();
            this.iTalk_Label8 = new iTalk.iTalk_Label();
            this.iTalk_Label6 = new iTalk.iTalk_Label();
            this.iTalk_Label4 = new iTalk.iTalk_Label();
            this.iTalk_Label3 = new iTalk.iTalk_Label();
            this.iTalk_TextBox_Small5 = new iTalk.iTalk_TextBox_Small();
            this.iTalk_Label9 = new iTalk.iTalk_Label();
            this.iTalk_Label2 = new iTalk.iTalk_Label();
            this.iTalk_Label5 = new iTalk.iTalk_Label();
            this.iTalk_Label11 = new iTalk.iTalk_Label();
            this.iTalk_Label1 = new iTalk.iTalk_Label();
            this.iTalk_TextBox_Small2 = new iTalk.iTalk_TextBox_Small();
            this.txtTelefone = new iTalk.iTalk_TextBox_Small();
            this.iTalk_TextBox_Small1 = new iTalk.iTalk_TextBox_Small();
            this.txtNome = new iTalk.iTalk_TextBox_Small();
            this.iTalk_TextBox_Small4 = new iTalk.iTalk_TextBox_Small();
            this.txtCpf = new iTalk.iTalk_TextBox_Small();
            this.btPesquisar = new iTalk.iTalk_Button_2();
            this.btNovo = new iTalk.iTalk_Button_2();
            this.btSalvar = new iTalk.iTalk_Button_2();
            this.btLimpar = new iTalk.iTalk_Button_2();
            this.btEditar = new iTalk.iTalk_Button_2();
            this.btExcluir = new iTalk.iTalk_Button_2();
            this.iTalk_GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // iTalk_GroupBox1
            // 
            this.iTalk_GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_GroupBox1.Controls.Add(this.dataGridView2);
            this.iTalk_GroupBox1.Controls.Add(this.iTalk_TextBox_Small7);
            this.iTalk_GroupBox1.Controls.Add(this.iTalk_TextBox_Small6);
            this.iTalk_GroupBox1.Controls.Add(this.txtModelo);
            this.iTalk_GroupBox1.Controls.Add(this.iTalk_Label7);
            this.iTalk_GroupBox1.Controls.Add(this.iTalk_Label8);
            this.iTalk_GroupBox1.Controls.Add(this.iTalk_Label6);
            this.iTalk_GroupBox1.Controls.Add(this.iTalk_Label4);
            this.iTalk_GroupBox1.Controls.Add(this.iTalk_Label3);
            this.iTalk_GroupBox1.Controls.Add(this.iTalk_TextBox_Small5);
            this.iTalk_GroupBox1.Controls.Add(this.iTalk_Label9);
            this.iTalk_GroupBox1.Controls.Add(this.iTalk_Label2);
            this.iTalk_GroupBox1.Controls.Add(this.iTalk_Label5);
            this.iTalk_GroupBox1.Controls.Add(this.iTalk_Label11);
            this.iTalk_GroupBox1.Controls.Add(this.iTalk_Label1);
            this.iTalk_GroupBox1.Controls.Add(this.iTalk_TextBox_Small2);
            this.iTalk_GroupBox1.Controls.Add(this.txtTelefone);
            this.iTalk_GroupBox1.Controls.Add(this.iTalk_TextBox_Small1);
            this.iTalk_GroupBox1.Controls.Add(this.txtNome);
            this.iTalk_GroupBox1.Controls.Add(this.iTalk_TextBox_Small4);
            this.iTalk_GroupBox1.Controls.Add(this.txtCpf);
            this.iTalk_GroupBox1.Location = new System.Drawing.Point(159, 21);
            this.iTalk_GroupBox1.MinimumSize = new System.Drawing.Size(136, 50);
            this.iTalk_GroupBox1.Name = "iTalk_GroupBox1";
            this.iTalk_GroupBox1.Padding = new System.Windows.Forms.Padding(5, 28, 5, 5);
            this.iTalk_GroupBox1.Size = new System.Drawing.Size(1180, 726);
            this.iTalk_GroupBox1.TabIndex = 10;
            this.iTalk_GroupBox1.Text = "Peças";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPeca,
            this.colDescricao,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.colCompativel,
            this.colPeso,
            this.colPotencia,
            this.colTorque});
            this.dataGridView2.Location = new System.Drawing.Point(22, 361);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1144, 352);
            this.dataGridView2.TabIndex = 14;
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
            // iTalk_TextBox_Small7
            // 
            this.iTalk_TextBox_Small7.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_TextBox_Small7.Font = new System.Drawing.Font("Tahoma", 11F);
            this.iTalk_TextBox_Small7.ForeColor = System.Drawing.Color.DimGray;
            this.iTalk_TextBox_Small7.Location = new System.Drawing.Point(754, 221);
            this.iTalk_TextBox_Small7.MaxLength = 32767;
            this.iTalk_TextBox_Small7.Multiline = false;
            this.iTalk_TextBox_Small7.Name = "iTalk_TextBox_Small7";
            this.iTalk_TextBox_Small7.ReadOnly = false;
            this.iTalk_TextBox_Small7.Size = new System.Drawing.Size(185, 28);
            this.iTalk_TextBox_Small7.TabIndex = 0;
            this.iTalk_TextBox_Small7.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.iTalk_TextBox_Small7.UseSystemPasswordChar = false;
            // 
            // iTalk_TextBox_Small6
            // 
            this.iTalk_TextBox_Small6.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_TextBox_Small6.Font = new System.Drawing.Font("Tahoma", 11F);
            this.iTalk_TextBox_Small6.ForeColor = System.Drawing.Color.DimGray;
            this.iTalk_TextBox_Small6.Location = new System.Drawing.Point(754, 174);
            this.iTalk_TextBox_Small6.MaxLength = 32767;
            this.iTalk_TextBox_Small6.Multiline = false;
            this.iTalk_TextBox_Small6.Name = "iTalk_TextBox_Small6";
            this.iTalk_TextBox_Small6.ReadOnly = false;
            this.iTalk_TextBox_Small6.Size = new System.Drawing.Size(185, 28);
            this.iTalk_TextBox_Small6.TabIndex = 0;
            this.iTalk_TextBox_Small6.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.iTalk_TextBox_Small6.UseSystemPasswordChar = false;
            // 
            // txtModelo
            // 
            this.txtModelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.txtModelo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtModelo.DropDownHeight = 100;
            this.txtModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtModelo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtModelo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.txtModelo.FormattingEnabled = true;
            this.txtModelo.HoverSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.txtModelo.IntegralHeight = false;
            this.txtModelo.ItemHeight = 20;
            this.txtModelo.Items.AddRange(new object[] {
            "FIAT",
            "MERCEDEZ",
            "BMW",
            "VOLKSWAGEM"});
            this.txtModelo.Location = new System.Drawing.Point(754, 82);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(185, 26);
            this.txtModelo.StartIndex = 0;
            this.txtModelo.TabIndex = 2;
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
            // iTalk_TextBox_Small5
            // 
            this.iTalk_TextBox_Small5.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_TextBox_Small5.Font = new System.Drawing.Font("Tahoma", 11F);
            this.iTalk_TextBox_Small5.ForeColor = System.Drawing.Color.DimGray;
            this.iTalk_TextBox_Small5.Location = new System.Drawing.Point(754, 127);
            this.iTalk_TextBox_Small5.MaxLength = 32767;
            this.iTalk_TextBox_Small5.Multiline = false;
            this.iTalk_TextBox_Small5.Name = "iTalk_TextBox_Small5";
            this.iTalk_TextBox_Small5.ReadOnly = false;
            this.iTalk_TextBox_Small5.Size = new System.Drawing.Size(185, 28);
            this.iTalk_TextBox_Small5.TabIndex = 0;
            this.iTalk_TextBox_Small5.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.iTalk_TextBox_Small5.UseSystemPasswordChar = false;
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
            // iTalk_TextBox_Small2
            // 
            this.iTalk_TextBox_Small2.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_TextBox_Small2.Font = new System.Drawing.Font("Tahoma", 11F);
            this.iTalk_TextBox_Small2.ForeColor = System.Drawing.Color.DimGray;
            this.iTalk_TextBox_Small2.Location = new System.Drawing.Point(215, 256);
            this.iTalk_TextBox_Small2.MaxLength = 32767;
            this.iTalk_TextBox_Small2.Multiline = false;
            this.iTalk_TextBox_Small2.Name = "iTalk_TextBox_Small2";
            this.iTalk_TextBox_Small2.ReadOnly = false;
            this.iTalk_TextBox_Small2.Size = new System.Drawing.Size(232, 28);
            this.iTalk_TextBox_Small2.TabIndex = 0;
            this.iTalk_TextBox_Small2.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.iTalk_TextBox_Small2.UseSystemPasswordChar = false;
            // 
            // txtTelefone
            // 
            this.txtTelefone.BackColor = System.Drawing.Color.Transparent;
            this.txtTelefone.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtTelefone.ForeColor = System.Drawing.Color.DimGray;
            this.txtTelefone.Location = new System.Drawing.Point(215, 155);
            this.txtTelefone.MaxLength = 32767;
            this.txtTelefone.Multiline = false;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.ReadOnly = false;
            this.txtTelefone.Size = new System.Drawing.Size(232, 28);
            this.txtTelefone.TabIndex = 0;
            this.txtTelefone.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTelefone.UseSystemPasswordChar = false;
            // 
            // iTalk_TextBox_Small1
            // 
            this.iTalk_TextBox_Small1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_TextBox_Small1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.iTalk_TextBox_Small1.ForeColor = System.Drawing.Color.DimGray;
            this.iTalk_TextBox_Small1.Location = new System.Drawing.Point(215, 208);
            this.iTalk_TextBox_Small1.MaxLength = 32767;
            this.iTalk_TextBox_Small1.Multiline = false;
            this.iTalk_TextBox_Small1.Name = "iTalk_TextBox_Small1";
            this.iTalk_TextBox_Small1.ReadOnly = false;
            this.iTalk_TextBox_Small1.Size = new System.Drawing.Size(232, 28);
            this.iTalk_TextBox_Small1.TabIndex = 0;
            this.iTalk_TextBox_Small1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.iTalk_TextBox_Small1.UseSystemPasswordChar = false;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.Transparent;
            this.txtNome.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtNome.ForeColor = System.Drawing.Color.DimGray;
            this.txtNome.Location = new System.Drawing.Point(215, 107);
            this.txtNome.MaxLength = 32767;
            this.txtNome.Multiline = false;
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = false;
            this.txtNome.Size = new System.Drawing.Size(232, 28);
            this.txtNome.TabIndex = 0;
            this.txtNome.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNome.UseSystemPasswordChar = false;
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
            // txtCpf
            // 
            this.txtCpf.BackColor = System.Drawing.Color.Transparent;
            this.txtCpf.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtCpf.ForeColor = System.Drawing.Color.DimGray;
            this.txtCpf.Location = new System.Drawing.Point(215, 58);
            this.txtCpf.MaxLength = 32767;
            this.txtCpf.Multiline = false;
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.ReadOnly = false;
            this.txtCpf.Size = new System.Drawing.Size(232, 28);
            this.txtCpf.TabIndex = 0;
            this.txtCpf.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCpf.UseSystemPasswordChar = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private iTalk.iTalk_GroupBox iTalk_GroupBox1;
        private iTalk.iTalk_TextBox_Small iTalk_TextBox_Small7;
        private iTalk.iTalk_TextBox_Small iTalk_TextBox_Small6;
        private iTalk.iTalk_ComboBox txtModelo;
        private iTalk.iTalk_Label iTalk_Label7;
        private iTalk.iTalk_Label iTalk_Label8;
        private iTalk.iTalk_Label iTalk_Label6;
        private iTalk.iTalk_Label iTalk_Label4;
        private iTalk.iTalk_Label iTalk_Label3;
        private iTalk.iTalk_TextBox_Small iTalk_TextBox_Small5;
        private iTalk.iTalk_Label iTalk_Label9;
        private iTalk.iTalk_Label iTalk_Label2;
        private iTalk.iTalk_Label iTalk_Label5;
        private iTalk.iTalk_Label iTalk_Label11;
        private iTalk.iTalk_Label iTalk_Label1;
        private iTalk.iTalk_TextBox_Small iTalk_TextBox_Small2;
        private iTalk.iTalk_TextBox_Small txtTelefone;
        private iTalk.iTalk_TextBox_Small iTalk_TextBox_Small1;
        private iTalk.iTalk_TextBox_Small txtNome;
        private iTalk.iTalk_TextBox_Small iTalk_TextBox_Small4;
        private iTalk.iTalk_TextBox_Small txtCpf;
        private iTalk.iTalk_Button_2 btPesquisar;
        private iTalk.iTalk_Button_2 btNovo;
        private iTalk.iTalk_Button_2 btSalvar;
        private iTalk.iTalk_Button_2 btLimpar;
        private iTalk.iTalk_Button_2 btEditar;
        private iTalk.iTalk_Button_2 btExcluir;
        private System.Windows.Forms.DataGridView dataGridView2;
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