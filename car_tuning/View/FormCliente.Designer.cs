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
            this.iTalk_GroupBox1 = new iTalk.iTalk_GroupBox();
            this.ambiance_Label1 = new Ambiance.Ambiance_Label();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTalk_Label4 = new iTalk.iTalk_Label();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.iTalk_Label3 = new iTalk.iTalk_Label();
            this.iTalk_Label2 = new iTalk.iTalk_Label();
            this.iTalk_Label1 = new iTalk.iTalk_Label();
            this.btPesquisar = new iTalk.iTalk_Button_2();
            this.btNovo = new iTalk.iTalk_Button_2();
            this.btExcluir = new iTalk.iTalk_Button_2();
            this.btSalvar = new iTalk.iTalk_Button_2();
            this.btEditar = new iTalk.iTalk_Button_2();
            this.btLimpar = new iTalk.iTalk_Button_2();
            this.iTalk_GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // iTalk_GroupBox1
            // 
            this.iTalk_GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_GroupBox1.Controls.Add(this.ambiance_Label1);
            this.iTalk_GroupBox1.Controls.Add(this.txtBusca);
            this.iTalk_GroupBox1.Controls.Add(this.txtEmail);
            this.iTalk_GroupBox1.Controls.Add(this.txtNome);
            this.iTalk_GroupBox1.Controls.Add(this.dgvCliente);
            this.iTalk_GroupBox1.Controls.Add(this.iTalk_Label4);
            this.iTalk_GroupBox1.Controls.Add(this.txtCpf);
            this.iTalk_GroupBox1.Controls.Add(this.txtTelefone);
            this.iTalk_GroupBox1.Controls.Add(this.iTalk_Label3);
            this.iTalk_GroupBox1.Controls.Add(this.iTalk_Label2);
            this.iTalk_GroupBox1.Controls.Add(this.iTalk_Label1);
            this.iTalk_GroupBox1.Location = new System.Drawing.Point(166, 28);
            this.iTalk_GroupBox1.MinimumSize = new System.Drawing.Size(136, 50);
            this.iTalk_GroupBox1.Name = "iTalk_GroupBox1";
            this.iTalk_GroupBox1.Padding = new System.Windows.Forms.Padding(5, 28, 5, 5);
            this.iTalk_GroupBox1.Size = new System.Drawing.Size(1161, 644);
            this.iTalk_GroupBox1.TabIndex = 3;
            this.iTalk_GroupBox1.Text = "Clientes";
            // 
            // ambiance_Label1
            // 
            this.ambiance_Label1.AutoSize = true;
            this.ambiance_Label1.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Label1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ambiance_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ambiance_Label1.Location = new System.Drawing.Point(431, 43);
            this.ambiance_Label1.Name = "ambiance_Label1";
            this.ambiance_Label1.Size = new System.Drawing.Size(70, 20);
            this.ambiance_Label1.TabIndex = 51;
            this.ambiance_Label1.Text = "Pesquisar";
            // 
            // txtBusca
            // 
            this.txtBusca.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusca.Location = new System.Drawing.Point(507, 43);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(504, 23);
            this.txtBusca.TabIndex = 4;
            this.txtBusca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBusca_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(135, 197);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(231, 27);
            this.txtEmail.TabIndex = 2;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(135, 151);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(231, 27);
            this.txtNome.TabIndex = 1;
            // 
            // dgvCliente
            // 
            this.dgvCliente.AllowUserToAddRows = false;
            this.dgvCliente.AllowUserToDeleteRows = false;
            this.dgvCliente.AllowUserToOrderColumns = true;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvCliente.Location = new System.Drawing.Point(435, 106);
            this.dgvCliente.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            this.dgvCliente.RowTemplate.Height = 24;
            this.dgvCliente.Size = new System.Drawing.Size(682, 520);
            this.dgvCliente.TabIndex = 28;
            this.dgvCliente.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellContentDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Cpf";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Nome";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Email";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Telefone";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // iTalk_Label4
            // 
            this.iTalk_Label4.AutoSize = true;
            this.iTalk_Label4.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label4.Location = new System.Drawing.Point(60, 197);
            this.iTalk_Label4.Name = "iTalk_Label4";
            this.iTalk_Label4.Size = new System.Drawing.Size(48, 21);
            this.iTalk_Label4.TabIndex = 18;
            this.iTalk_Label4.Text = "Email";
            // 
            // txtCpf
            // 
            this.txtCpf.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpf.ForeColor = System.Drawing.Color.DimGray;
            this.txtCpf.Location = new System.Drawing.Point(135, 105);
            this.txtCpf.Margin = new System.Windows.Forms.Padding(2);
            this.txtCpf.Mask = "000,000,000-00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.PromptChar = ' ';
            this.txtCpf.Size = new System.Drawing.Size(138, 27);
            this.txtCpf.TabIndex = 0;
            this.txtCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.ForeColor = System.Drawing.Color.DimGray;
            this.txtTelefone.Location = new System.Drawing.Point(135, 243);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefone.Mask = "(00) 00000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(148, 27);
            this.txtTelefone.TabIndex = 3;
            this.txtTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // iTalk_Label3
            // 
            this.iTalk_Label3.AutoSize = true;
            this.iTalk_Label3.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label3.Location = new System.Drawing.Point(59, 244);
            this.iTalk_Label3.Name = "iTalk_Label3";
            this.iTalk_Label3.Size = new System.Drawing.Size(67, 21);
            this.iTalk_Label3.TabIndex = 1;
            this.iTalk_Label3.Text = "Telefone";
            // 
            // iTalk_Label2
            // 
            this.iTalk_Label2.AutoSize = true;
            this.iTalk_Label2.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label2.Location = new System.Drawing.Point(61, 150);
            this.iTalk_Label2.Name = "iTalk_Label2";
            this.iTalk_Label2.Size = new System.Drawing.Size(53, 21);
            this.iTalk_Label2.TabIndex = 1;
            this.iTalk_Label2.Text = "Nome";
            // 
            // iTalk_Label1
            // 
            this.iTalk_Label1.AutoSize = true;
            this.iTalk_Label1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label1.Location = new System.Drawing.Point(60, 106);
            this.iTalk_Label1.Name = "iTalk_Label1";
            this.iTalk_Label1.Size = new System.Drawing.Size(37, 21);
            this.iTalk_Label1.TabIndex = 1;
            this.iTalk_Label1.Text = "CPF";
            // 
            // btPesquisar
            // 
            this.btPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.btPesquisar.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btPesquisar.ForeColor = System.Drawing.Color.White;
            this.btPesquisar.Image = null;
            this.btPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPesquisar.Location = new System.Drawing.Point(23, 396);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(116, 40);
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
            this.btNovo.Location = new System.Drawing.Point(23, 74);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(116, 40);
            this.btNovo.TabIndex = 1;
            this.btNovo.Text = "Novo";
            this.btNovo.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.BackColor = System.Drawing.Color.Transparent;
            this.btExcluir.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btExcluir.ForeColor = System.Drawing.Color.White;
            this.btExcluir.Image = null;
            this.btExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btExcluir.Location = new System.Drawing.Point(23, 258);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(116, 40);
            this.btExcluir.TabIndex = 1;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btSalvar.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btSalvar.ForeColor = System.Drawing.Color.White;
            this.btSalvar.Image = null;
            this.btSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSalvar.Location = new System.Drawing.Point(23, 120);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(116, 40);
            this.btSalvar.TabIndex = 1;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btEditar
            // 
            this.btEditar.BackColor = System.Drawing.Color.Transparent;
            this.btEditar.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btEditar.ForeColor = System.Drawing.Color.White;
            this.btEditar.Image = null;
            this.btEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btEditar.Location = new System.Drawing.Point(23, 212);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(116, 40);
            this.btEditar.TabIndex = 1;
            this.btEditar.Text = "Editar";
            this.btEditar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.BackColor = System.Drawing.Color.Transparent;
            this.btLimpar.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btLimpar.ForeColor = System.Drawing.Color.White;
            this.btLimpar.Image = null;
            this.btLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLimpar.Location = new System.Drawing.Point(23, 166);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(116, 40);
            this.btLimpar.TabIndex = 1;
            this.btLimpar.Text = "Cancelar";
            this.btLimpar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1352, 700);
            this.ControlBox = false;
            this.Controls.Add(this.iTalk_GroupBox1);
            this.Controls.Add(this.btPesquisar);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btLimpar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.iTalk_GroupBox1.ResumeLayout(false);
            this.iTalk_GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private iTalk.iTalk_Button_2 btNovo;
        private iTalk.iTalk_Button_2 btSalvar;
        private iTalk.iTalk_Button_2 btLimpar;
        private iTalk.iTalk_Button_2 btEditar;
        private iTalk.iTalk_Button_2 btExcluir;
        private iTalk.iTalk_Button_2 btPesquisar;
        private iTalk.iTalk_GroupBox iTalk_GroupBox1;
        private System.Windows.Forms.DataGridView dgvCliente;
        private iTalk.iTalk_Label iTalk_Label4;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private iTalk.iTalk_Label iTalk_Label3;
        private iTalk.iTalk_Label iTalk_Label2;
        private iTalk.iTalk_Label iTalk_Label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TextBox txtBusca;
        private Ambiance.Ambiance_Label ambiance_Label1;
    }
}