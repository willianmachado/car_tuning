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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.iTalk_TextBox_Small1 = new iTalk.iTalk_TextBox_Small();
            this.iTalk_Label1 = new iTalk.iTalk_Label();
            this.dgCliente = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.iTalk_TextBox_Small2 = new iTalk.iTalk_TextBox_Small();
            this.iTalk_Label2 = new iTalk.iTalk_Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFabricante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPotencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTorque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabCliente.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCliente)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btVoltar
            // 
            this.btVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btVoltar.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btVoltar.ForeColor = System.Drawing.Color.White;
            this.btVoltar.Image = null;
            this.btVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btVoltar.Location = new System.Drawing.Point(1152, 640);
            this.btVoltar.Margin = new System.Windows.Forms.Padding(4);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(155, 49);
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
            this.btSelecionar.Location = new System.Drawing.Point(989, 640);
            this.btSelecionar.Margin = new System.Windows.Forms.Padding(4);
            this.btSelecionar.Name = "btSelecionar";
            this.btSelecionar.Size = new System.Drawing.Size(155, 49);
            this.btSelecionar.TabIndex = 2;
            this.btSelecionar.Text = "Selecionar";
            this.btSelecionar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btSelecionar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // tabCliente
            // 
            this.tabCliente.Controls.Add(this.tabPage1);
            this.tabCliente.Controls.Add(this.tabPage2);
            this.tabCliente.ItemSize = new System.Drawing.Size(80, 24);
            this.tabCliente.Location = new System.Drawing.Point(-1, 0);
            this.tabCliente.Margin = new System.Windows.Forms.Padding(4);
            this.tabCliente.Name = "tabCliente";
            this.tabCliente.SelectedIndex = 0;
            this.tabCliente.Size = new System.Drawing.Size(1329, 633);
            this.tabCliente.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.tabPage1.Controls.Add(this.iTalk_TextBox_Small1);
            this.tabPage1.Controls.Add(this.iTalk_Label1);
            this.tabPage1.Controls.Add(this.dgCliente);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1321, 601);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // iTalk_TextBox_Small1
            // 
            this.iTalk_TextBox_Small1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_TextBox_Small1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.iTalk_TextBox_Small1.ForeColor = System.Drawing.Color.DimGray;
            this.iTalk_TextBox_Small1.Location = new System.Drawing.Point(127, 21);
            this.iTalk_TextBox_Small1.Margin = new System.Windows.Forms.Padding(4);
            this.iTalk_TextBox_Small1.MaxLength = 32767;
            this.iTalk_TextBox_Small1.Multiline = false;
            this.iTalk_TextBox_Small1.Name = "iTalk_TextBox_Small1";
            this.iTalk_TextBox_Small1.ReadOnly = false;
            this.iTalk_TextBox_Small1.Size = new System.Drawing.Size(1179, 33);
            this.iTalk_TextBox_Small1.TabIndex = 8;
            this.iTalk_TextBox_Small1.Tag = "";
            this.iTalk_TextBox_Small1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.iTalk_TextBox_Small1.UseSystemPasswordChar = false;
            // 
            // iTalk_Label1
            // 
            this.iTalk_Label1.AutoSize = true;
            this.iTalk_Label1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label1.Location = new System.Drawing.Point(25, 21);
            this.iTalk_Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.iTalk_Label1.Name = "iTalk_Label1";
            this.iTalk_Label1.Size = new System.Drawing.Size(91, 32);
            this.iTalk_Label1.TabIndex = 7;
            this.iTalk_Label1.Text = "Buscar";
            // 
            // dgCliente
            // 
            this.dgCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCpf,
            this.colNome,
            this.Column1,
            this.Column2});
            this.dgCliente.Location = new System.Drawing.Point(8, 76);
            this.dgCliente.Margin = new System.Windows.Forms.Padding(4);
            this.dgCliente.Name = "dgCliente";
            this.dgCliente.Size = new System.Drawing.Size(1303, 510);
            this.dgCliente.TabIndex = 6;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.tabPage2.Controls.Add(this.iTalk_TextBox_Small2);
            this.tabPage2.Controls.Add(this.iTalk_Label2);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1321, 601);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // iTalk_TextBox_Small2
            // 
            this.iTalk_TextBox_Small2.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_TextBox_Small2.Font = new System.Drawing.Font("Tahoma", 11F);
            this.iTalk_TextBox_Small2.ForeColor = System.Drawing.Color.DimGray;
            this.iTalk_TextBox_Small2.Location = new System.Drawing.Point(124, 20);
            this.iTalk_TextBox_Small2.Margin = new System.Windows.Forms.Padding(4);
            this.iTalk_TextBox_Small2.MaxLength = 32767;
            this.iTalk_TextBox_Small2.Multiline = false;
            this.iTalk_TextBox_Small2.Name = "iTalk_TextBox_Small2";
            this.iTalk_TextBox_Small2.ReadOnly = false;
            this.iTalk_TextBox_Small2.Size = new System.Drawing.Size(1179, 33);
            this.iTalk_TextBox_Small2.TabIndex = 10;
            this.iTalk_TextBox_Small2.Text = "Digite o nome ou tipo da Peça";
            this.iTalk_TextBox_Small2.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.iTalk_TextBox_Small2.UseSystemPasswordChar = false;
            // 
            // iTalk_Label2
            // 
            this.iTalk_Label2.AutoSize = true;
            this.iTalk_Label2.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label2.Location = new System.Drawing.Point(23, 20);
            this.iTalk_Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.iTalk_Label2.Name = "iTalk_Label2";
            this.iTalk_Label2.Size = new System.Drawing.Size(91, 32);
            this.iTalk_Label2.TabIndex = 9;
            this.iTalk_Label2.Text = "Buscar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCod,
            this.dataGridViewTextBoxColumn1,
            this.colFabricante,
            this.colPreco,
            this.colTipo,
            this.dataGridViewTextBoxColumn2,
            this.colPeso,
            this.colPotencia,
            this.colTorque});
            this.dataGridView1.Location = new System.Drawing.Point(8, 76);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1311, 513);
            this.dataGridView1.TabIndex = 4;
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
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "telefone";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Email";
            this.Column2.Name = "Column2";
            // 
            // colCod
            // 
            this.colCod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCod.HeaderText = "Codigo";
            this.colCod.Name = "colCod";
            this.colCod.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // colFabricante
            // 
            this.colFabricante.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFabricante.HeaderText = "Fabricante";
            this.colFabricante.Name = "colFabricante";
            this.colFabricante.ReadOnly = true;
            // 
            // colPreco
            // 
            this.colPreco.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPreco.HeaderText = "Valor";
            this.colPreco.Name = "colPreco";
            this.colPreco.ReadOnly = true;
            // 
            // colTipo
            // 
            this.colTipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTipo.HeaderText = "Tipo";
            this.colTipo.Name = "colTipo";
            this.colTipo.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Marca";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
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
            // FormPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 705);
            this.ControlBox = false;
            this.Controls.Add(this.tabCliente);
            this.Controls.Add(this.btSelecionar);
            this.Controls.Add(this.btVoltar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPesquisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.tabCliente.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCliente)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private iTalk.iTalk_Button_2 btVoltar;
        private iTalk.iTalk_Button_2 btSelecionar;
        private Ambiance.Ambiance_TabControl tabCliente;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgCliente;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private iTalk.iTalk_TextBox_Small iTalk_TextBox_Small1;
        private iTalk.iTalk_Label iTalk_Label1;
        private iTalk.iTalk_TextBox_Small iTalk_TextBox_Small2;
        private iTalk.iTalk_Label iTalk_Label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFabricante;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPreco;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPeso;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPotencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTorque;
    }
}