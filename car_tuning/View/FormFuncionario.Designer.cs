namespace car_tuning
{
    partial class FormFuncionario
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
            this.btNovo = new iTalk.iTalk_Button_2();
            this.iTalk_GroupBox1 = new iTalk.iTalk_GroupBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.iTalk_Label4 = new iTalk.iTalk_Label();
            this.dgvFunc = new System.Windows.Forms.DataGridView();
            this.cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscaFunc = new iTalk.iTalk_TextBox_Small();
            this.iTalk_Label3 = new iTalk.iTalk_Label();
            this.iTalk_Label2 = new iTalk.iTalk_Label();
            this.iTalk_Label1 = new iTalk.iTalk_Label();
            this.txtNome = new iTalk.iTalk_TextBox_Small();
            this.btPesquisar = new iTalk.iTalk_Button_2();
            this.btSalvar = new iTalk.iTalk_Button_2();
            this.btLimpar = new iTalk.iTalk_Button_2();
            this.btEditar = new iTalk.iTalk_Button_2();
            this.btExcluir = new iTalk.iTalk_Button_2();
            this.btVoltar = new iTalk.iTalk_Button_2();
            this.iTalk_GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunc)).BeginInit();
            this.SuspendLayout();
            // 
            // btNovo
            // 
            this.btNovo.BackColor = System.Drawing.Color.Transparent;
            this.btNovo.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btNovo.ForeColor = System.Drawing.Color.White;
            this.btNovo.Image = null;
            this.btNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btNovo.Location = new System.Drawing.Point(12, 40);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(116, 40);
            this.btNovo.TabIndex = 11;
            this.btNovo.Text = "Novo";
            this.btNovo.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // iTalk_GroupBox1
            // 
            this.iTalk_GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_GroupBox1.Controls.Add(this.txtTelefone);
            this.iTalk_GroupBox1.Controls.Add(this.txtCpf);
            this.iTalk_GroupBox1.Controls.Add(this.iTalk_Label4);
            this.iTalk_GroupBox1.Controls.Add(this.dgvFunc);
            this.iTalk_GroupBox1.Controls.Add(this.txtBuscaFunc);
            this.iTalk_GroupBox1.Controls.Add(this.iTalk_Label3);
            this.iTalk_GroupBox1.Controls.Add(this.iTalk_Label2);
            this.iTalk_GroupBox1.Controls.Add(this.iTalk_Label1);
            this.iTalk_GroupBox1.Controls.Add(this.txtNome);
            this.iTalk_GroupBox1.Location = new System.Drawing.Point(149, 3);
            this.iTalk_GroupBox1.MinimumSize = new System.Drawing.Size(136, 50);
            this.iTalk_GroupBox1.Name = "iTalk_GroupBox1";
            this.iTalk_GroupBox1.Padding = new System.Windows.Forms.Padding(5, 28, 5, 5);
            this.iTalk_GroupBox1.Size = new System.Drawing.Size(993, 572);
            this.iTalk_GroupBox1.TabIndex = 10;
            this.iTalk_GroupBox1.Text = "Funcionario";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.ForeColor = System.Drawing.Color.DimGray;
            this.txtTelefone.Location = new System.Drawing.Point(97, 150);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefone.Mask = "(00) 00000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(148, 27);
            this.txtTelefone.TabIndex = 2;
            this.txtTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtCpf
            // 
            this.txtCpf.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpf.ForeColor = System.Drawing.Color.DimGray;
            this.txtCpf.Location = new System.Drawing.Point(97, 57);
            this.txtCpf.Margin = new System.Windows.Forms.Padding(2);
            this.txtCpf.Mask = "000,000,000-00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.PromptChar = ' ';
            this.txtCpf.Size = new System.Drawing.Size(138, 27);
            this.txtCpf.TabIndex = 0;
            this.txtCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // iTalk_Label4
            // 
            this.iTalk_Label4.AutoSize = true;
            this.iTalk_Label4.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label4.Location = new System.Drawing.Point(397, 42);
            this.iTalk_Label4.Name = "iTalk_Label4";
            this.iTalk_Label4.Size = new System.Drawing.Size(76, 21);
            this.iTalk_Label4.TabIndex = 9;
            this.iTalk_Label4.Text = "Pesquisar";
            // 
            // dgvFunc
            // 
            this.dgvFunc.AllowUserToAddRows = false;
            this.dgvFunc.AllowUserToDeleteRows = false;
            this.dgvFunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFunc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cpf,
            this.nome,
            this.telefone});
            this.dgvFunc.Location = new System.Drawing.Point(401, 83);
            this.dgvFunc.Name = "dgvFunc";
            this.dgvFunc.ReadOnly = true;
            this.dgvFunc.Size = new System.Drawing.Size(571, 465);
            this.dgvFunc.TabIndex = 7;
            this.dgvFunc.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFunc_CellContentDoubleClick);
            // 
            // cpf
            // 
            this.cpf.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cpf.HeaderText = "Cpf";
            this.cpf.Name = "cpf";
            this.cpf.ReadOnly = true;
            // 
            // nome
            // 
            this.nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // telefone
            // 
            this.telefone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.telefone.HeaderText = "Telefone";
            this.telefone.Name = "telefone";
            this.telefone.ReadOnly = true;
            // 
            // txtBuscaFunc
            // 
            this.txtBuscaFunc.BackColor = System.Drawing.Color.Transparent;
            this.txtBuscaFunc.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtBuscaFunc.ForeColor = System.Drawing.Color.DimGray;
            this.txtBuscaFunc.Location = new System.Drawing.Point(479, 42);
            this.txtBuscaFunc.MaxLength = 32767;
            this.txtBuscaFunc.Multiline = false;
            this.txtBuscaFunc.Name = "txtBuscaFunc";
            this.txtBuscaFunc.ReadOnly = false;
            this.txtBuscaFunc.Size = new System.Drawing.Size(493, 28);
            this.txtBuscaFunc.TabIndex = 3;
            this.txtBuscaFunc.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBuscaFunc.UseSystemPasswordChar = false;
            this.txtBuscaFunc.TextChanged += new System.EventHandler(this.txtBuscaFunc_TextChanged);
            // 
            // iTalk_Label3
            // 
            this.iTalk_Label3.AutoSize = true;
            this.iTalk_Label3.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label3.Location = new System.Drawing.Point(24, 150);
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
            this.iTalk_Label2.Location = new System.Drawing.Point(24, 103);
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
            this.iTalk_Label1.Location = new System.Drawing.Point(24, 58);
            this.iTalk_Label1.Name = "iTalk_Label1";
            this.iTalk_Label1.Size = new System.Drawing.Size(37, 21);
            this.iTalk_Label1.TabIndex = 1;
            this.iTalk_Label1.Text = "CPF";
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.Transparent;
            this.txtNome.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtNome.ForeColor = System.Drawing.Color.DimGray;
            this.txtNome.Location = new System.Drawing.Point(97, 103);
            this.txtNome.MaxLength = 32767;
            this.txtNome.Multiline = false;
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = false;
            this.txtNome.Size = new System.Drawing.Size(232, 28);
            this.txtNome.TabIndex = 1;
            this.txtNome.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNome.UseSystemPasswordChar = false;
            // 
            // btPesquisar
            // 
            this.btPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.btPesquisar.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btPesquisar.ForeColor = System.Drawing.Color.White;
            this.btPesquisar.Image = null;
            this.btPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPesquisar.Location = new System.Drawing.Point(12, 362);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(116, 40);
            this.btPesquisar.TabIndex = 3;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btSalvar.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btSalvar.ForeColor = System.Drawing.Color.White;
            this.btSalvar.Image = null;
            this.btSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSalvar.Location = new System.Drawing.Point(12, 86);
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
            this.btLimpar.Location = new System.Drawing.Point(12, 132);
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
            this.btEditar.Location = new System.Drawing.Point(12, 178);
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
            this.btExcluir.Location = new System.Drawing.Point(12, 224);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(116, 40);
            this.btExcluir.TabIndex = 8;
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
            this.btVoltar.Location = new System.Drawing.Point(12, 523);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(116, 40);
            this.btVoltar.TabIndex = 9;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // FormFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 640);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.iTalk_GroupBox1);
            this.Controls.Add(this.btPesquisar);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btVoltar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(126, 39);
            this.Name = "FormFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "monoFlat_ThemeContainer1";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.iTalk_GroupBox1.ResumeLayout(false);
            this.iTalk_GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private iTalk.iTalk_GroupBox iTalk_GroupBox1;
        private iTalk.iTalk_Label iTalk_Label3;
        private iTalk.iTalk_Label iTalk_Label2;
        private iTalk.iTalk_Label iTalk_Label1;
        private iTalk.iTalk_TextBox_Small txtNome;
        private iTalk.iTalk_Button_2 btPesquisar;
        private iTalk.iTalk_Button_2 btSalvar;
        private iTalk.iTalk_Button_2 btLimpar;
        private iTalk.iTalk_Button_2 btEditar;
        private iTalk.iTalk_Button_2 btExcluir;
        private iTalk.iTalk_Button_2 btVoltar;
        private System.Windows.Forms.DataGridView dgvFunc;
        private iTalk.iTalk_TextBox_Small txtBuscaFunc;
        private iTalk.iTalk_Label iTalk_Label4;
        private iTalk.iTalk_Button_2 btNovo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
    }
}