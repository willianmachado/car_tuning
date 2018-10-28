namespace car_tuning
{
    partial class FormCliente
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
            this.scPanel = new iTalk.iTalk_Panel();
            this.iTalk_GroupBox1 = new iTalk.iTalk_GroupBox();
            this.iTalk_Label4 = new iTalk.iTalk_Label();
            this.txtEmail = new iTalk.iTalk_TextBox_Small();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.iTalk_Label3 = new iTalk.iTalk_Label();
            this.iTalk_Label2 = new iTalk.iTalk_Label();
            this.iTalk_Label1 = new iTalk.iTalk_Label();
            this.txtNome = new iTalk.iTalk_TextBox_Small();
            this.btPesquisar = new iTalk.iTalk_Button_2();
            this.btNovo = new iTalk.iTalk_Button_2();
            this.btSalvar = new iTalk.iTalk_Button_2();
            this.btLimpar = new iTalk.iTalk_Button_2();
            this.btEditar = new iTalk.iTalk_Button_2();
            this.btExcluir = new iTalk.iTalk_Button_2();
            this.btVoltar = new iTalk.iTalk_Button_2();
            this.iTalk_Label6 = new iTalk.iTalk_Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTalk_GroupBox2 = new iTalk.iTalk_GroupBox();
            this.maskedTextBoxPlacaVei = new System.Windows.Forms.MaskedTextBox();
            this.btBuscarCarro = new Ambiance.Ambiance_Button_2();
            this.scPanel.SuspendLayout();
            this.iTalk_GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.iTalk_GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // scPanel
            // 
            this.scPanel.BackColor = System.Drawing.Color.Transparent;
            this.scPanel.Controls.Add(this.iTalk_GroupBox1);
            this.scPanel.Controls.Add(this.btPesquisar);
            this.scPanel.Controls.Add(this.btNovo);
            this.scPanel.Controls.Add(this.btSalvar);
            this.scPanel.Controls.Add(this.btLimpar);
            this.scPanel.Controls.Add(this.btEditar);
            this.scPanel.Controls.Add(this.btExcluir);
            this.scPanel.Controls.Add(this.btVoltar);
            this.scPanel.Location = new System.Drawing.Point(0, 0);
            this.scPanel.Margin = new System.Windows.Forms.Padding(4);
            this.scPanel.Name = "scPanel";
            this.scPanel.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.scPanel.Size = new System.Drawing.Size(1393, 750);
            this.scPanel.TabIndex = 0;
            this.scPanel.Text = "iTalk_Panel1";
            this.scPanel.Click += new System.EventHandler(this.scPanel_Click);
            // 
            // iTalk_GroupBox1
            // 
            this.iTalk_GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_GroupBox1.Controls.Add(this.btBuscarCarro);
            this.iTalk_GroupBox1.Controls.Add(this.maskedTextBoxPlacaVei);
            this.iTalk_GroupBox1.Controls.Add(this.iTalk_Label6);
            this.iTalk_GroupBox1.Controls.Add(this.iTalk_GroupBox2);
            this.iTalk_GroupBox1.Controls.Add(this.iTalk_Label4);
            this.iTalk_GroupBox1.Controls.Add(this.txtEmail);
            this.iTalk_GroupBox1.Controls.Add(this.txtCpf);
            this.iTalk_GroupBox1.Controls.Add(this.txtTelefone);
            this.iTalk_GroupBox1.Controls.Add(this.iTalk_Label3);
            this.iTalk_GroupBox1.Controls.Add(this.iTalk_Label2);
            this.iTalk_GroupBox1.Controls.Add(this.iTalk_Label1);
            this.iTalk_GroupBox1.Controls.Add(this.txtNome);
            this.iTalk_GroupBox1.Location = new System.Drawing.Point(199, 0);
            this.iTalk_GroupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.iTalk_GroupBox1.MinimumSize = new System.Drawing.Size(181, 62);
            this.iTalk_GroupBox1.Name = "iTalk_GroupBox1";
            this.iTalk_GroupBox1.Padding = new System.Windows.Forms.Padding(7, 34, 7, 6);
            this.iTalk_GroupBox1.Size = new System.Drawing.Size(987, 740);
            this.iTalk_GroupBox1.TabIndex = 2;
            this.iTalk_GroupBox1.Text = "Cliente";
            this.iTalk_GroupBox1.Click += new System.EventHandler(this.iTalk_GroupBox1_Click);
            // 
            // iTalk_Label4
            // 
            this.iTalk_Label4.AutoSize = true;
            this.iTalk_Label4.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label4.Location = new System.Drawing.Point(463, 183);
            this.iTalk_Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.iTalk_Label4.Name = "iTalk_Label4";
            this.iTalk_Label4.Size = new System.Drawing.Size(59, 28);
            this.iTalk_Label4.TabIndex = 18;
            this.iTalk_Label4.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtEmail.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtEmail.Location = new System.Drawing.Point(561, 183);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = false;
            this.txtEmail.Size = new System.Drawing.Size(309, 33);
            this.txtEmail.TabIndex = 17;
            this.txtEmail.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmail.UseSystemPasswordChar = false;
            // 
            // txtCpf
            // 
            this.txtCpf.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpf.ForeColor = System.Drawing.Color.DimGray;
            this.txtCpf.Location = new System.Drawing.Point(121, 78);
            this.txtCpf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCpf.Mask = "000,000,000,00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(183, 32);
            this.txtCpf.TabIndex = 16;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.ForeColor = System.Drawing.Color.DimGray;
            this.txtTelefone.Location = new System.Drawing.Point(561, 77);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelefone.Mask = "(99) 0000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(185, 32);
            this.txtTelefone.TabIndex = 10;
            // 
            // iTalk_Label3
            // 
            this.iTalk_Label3.AutoSize = true;
            this.iTalk_Label3.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label3.Location = new System.Drawing.Point(463, 79);
            this.iTalk_Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.iTalk_Label3.Name = "iTalk_Label3";
            this.iTalk_Label3.Size = new System.Drawing.Size(84, 28);
            this.iTalk_Label3.TabIndex = 1;
            this.iTalk_Label3.Text = "Telefone";
            this.iTalk_Label3.Click += new System.EventHandler(this.iTalk_Label3_Click);
            // 
            // iTalk_Label2
            // 
            this.iTalk_Label2.AutoSize = true;
            this.iTalk_Label2.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label2.Location = new System.Drawing.Point(21, 183);
            this.iTalk_Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.iTalk_Label2.Name = "iTalk_Label2";
            this.iTalk_Label2.Size = new System.Drawing.Size(66, 28);
            this.iTalk_Label2.TabIndex = 1;
            this.iTalk_Label2.Text = "Nome";
            this.iTalk_Label2.Click += new System.EventHandler(this.iTalk_Label2_Click);
            // 
            // iTalk_Label1
            // 
            this.iTalk_Label1.AutoSize = true;
            this.iTalk_Label1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label1.Location = new System.Drawing.Point(21, 79);
            this.iTalk_Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.iTalk_Label1.Name = "iTalk_Label1";
            this.iTalk_Label1.Size = new System.Drawing.Size(45, 28);
            this.iTalk_Label1.TabIndex = 1;
            this.iTalk_Label1.Text = "CPF";
            this.iTalk_Label1.Click += new System.EventHandler(this.iTalk_Label1_Click);
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.Transparent;
            this.txtNome.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtNome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtNome.Location = new System.Drawing.Point(119, 183);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.MaxLength = 32767;
            this.txtNome.Multiline = false;
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = false;
            this.txtNome.Size = new System.Drawing.Size(309, 33);
            this.txtNome.TabIndex = 0;
            this.txtNome.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNome.UseSystemPasswordChar = false;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // btPesquisar
            // 
            this.btPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.btPesquisar.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btPesquisar.ForeColor = System.Drawing.Color.White;
            this.btPesquisar.Image = null;
            this.btPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPesquisar.Location = new System.Drawing.Point(13, 446);
            this.btPesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(155, 49);
            this.btPesquisar.TabIndex = 1;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // btNovo
            // 
            this.btNovo.BackColor = System.Drawing.Color.Transparent;
            this.btNovo.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btNovo.ForeColor = System.Drawing.Color.White;
            this.btNovo.Image = null;
            this.btNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btNovo.Location = new System.Drawing.Point(13, 49);
            this.btNovo.Margin = new System.Windows.Forms.Padding(4);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(155, 49);
            this.btNovo.TabIndex = 1;
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
            this.btSalvar.Location = new System.Drawing.Point(13, 106);
            this.btSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(155, 49);
            this.btSalvar.TabIndex = 1;
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
            this.btLimpar.Location = new System.Drawing.Point(13, 162);
            this.btLimpar.Margin = new System.Windows.Forms.Padding(4);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(155, 49);
            this.btLimpar.TabIndex = 1;
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
            this.btEditar.Location = new System.Drawing.Point(13, 219);
            this.btEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(155, 49);
            this.btEditar.TabIndex = 1;
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
            this.btExcluir.Location = new System.Drawing.Point(13, 276);
            this.btExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(155, 49);
            this.btExcluir.TabIndex = 1;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btVoltar
            // 
            this.btVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btVoltar.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btVoltar.ForeColor = System.Drawing.Color.White;
            this.btVoltar.Image = null;
            this.btVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btVoltar.Location = new System.Drawing.Point(13, 644);
            this.btVoltar.Margin = new System.Windows.Forms.Padding(4);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(155, 49);
            this.btVoltar.TabIndex = 1;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // iTalk_Label6
            // 
            this.iTalk_Label6.AutoSize = true;
            this.iTalk_Label6.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label6.Location = new System.Drawing.Point(22, 315);
            this.iTalk_Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.iTalk_Label6.Name = "iTalk_Label6";
            this.iTalk_Label6.Size = new System.Drawing.Size(57, 28);
            this.iTalk_Label6.TabIndex = 24;
            this.iTalk_Label6.Text = "Placa";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column2,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(0, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(977, 328);
            this.dataGridView1.TabIndex = 28;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Marca";
            this.Column4.Name = "Column4";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Modelo";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "ano";
            this.Column3.Name = "Column3";
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Placa";
            this.Column1.Name = "Column1";
            // 
            // iTalk_GroupBox2
            // 
            this.iTalk_GroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_GroupBox2.Controls.Add(this.dataGridView1);
            this.iTalk_GroupBox2.Location = new System.Drawing.Point(0, 356);
            this.iTalk_GroupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.iTalk_GroupBox2.MinimumSize = new System.Drawing.Size(181, 62);
            this.iTalk_GroupBox2.Name = "iTalk_GroupBox2";
            this.iTalk_GroupBox2.Padding = new System.Windows.Forms.Padding(7, 34, 7, 6);
            this.iTalk_GroupBox2.Size = new System.Drawing.Size(987, 374);
            this.iTalk_GroupBox2.TabIndex = 19;
            this.iTalk_GroupBox2.Text = "Carro";
            // 
            // maskedTextBoxPlacaVei
            // 
            this.maskedTextBoxPlacaVei.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxPlacaVei.ForeColor = System.Drawing.Color.Black;
            this.maskedTextBoxPlacaVei.Location = new System.Drawing.Point(86, 315);
            this.maskedTextBoxPlacaVei.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maskedTextBoxPlacaVei.Mask = "aaa-0000";
            this.maskedTextBoxPlacaVei.Name = "maskedTextBoxPlacaVei";
            this.maskedTextBoxPlacaVei.Size = new System.Drawing.Size(183, 32);
            this.maskedTextBoxPlacaVei.TabIndex = 34;
            // 
            // btBuscarCarro
            // 
            this.btBuscarCarro.BackColor = System.Drawing.Color.Transparent;
            this.btBuscarCarro.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btBuscarCarro.Image = null;
            this.btBuscarCarro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btBuscarCarro.Location = new System.Drawing.Point(296, 313);
            this.btBuscarCarro.Name = "btBuscarCarro";
            this.btBuscarCarro.Size = new System.Drawing.Size(113, 30);
            this.btBuscarCarro.TabIndex = 35;
            this.btBuscarCarro.Text = "Pesquisar";
            this.btBuscarCarro.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1392, 747);
            this.ControlBox = false;
            this.Controls.Add(this.scPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.scPanel.ResumeLayout(false);
            this.iTalk_GroupBox1.ResumeLayout(false);
            this.iTalk_GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.iTalk_GroupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private iTalk.iTalk_Panel scPanel;
        private iTalk.iTalk_Button_2 btNovo;
        private iTalk.iTalk_Button_2 btSalvar;
        private iTalk.iTalk_Button_2 btLimpar;
        private iTalk.iTalk_Button_2 btEditar;
        private iTalk.iTalk_Button_2 btExcluir;
        private iTalk.iTalk_Button_2 btVoltar;
        private iTalk.iTalk_GroupBox iTalk_GroupBox1;
        private iTalk.iTalk_Label iTalk_Label3;
        private iTalk.iTalk_Label iTalk_Label2;
        private iTalk.iTalk_Label iTalk_Label1;
        private iTalk.iTalk_TextBox_Small txtNome;
        private iTalk.iTalk_Button_2 btPesquisar;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private iTalk.iTalk_Label iTalk_Label4;
        private iTalk.iTalk_TextBox_Small txtEmail;
        private iTalk.iTalk_Label iTalk_Label6;
        private iTalk.iTalk_GroupBox iTalk_GroupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPlacaVei;
        private Ambiance.Ambiance_Button_2 btBuscarCarro;
    }
}