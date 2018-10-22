namespace car_tuning
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btPesquisa = new Ambiance.Ambiance_Button_1();
            this.btCliente = new Ambiance.Ambiance_Button_1();
            this.ambiance_ControlBox1 = new Ambiance.Ambiance_ControlBox();
            this.btFuncionario = new Ambiance.Ambiance_Button_1();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 357);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 357);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(192, 71);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "tabPage4";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(675, 357);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "tabPage3";
            // 
            // btPesquisa
            // 
            this.btPesquisa.BackColor = System.Drawing.Color.Transparent;
            this.btPesquisa.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btPesquisa.Image = null;
            this.btPesquisa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPesquisa.Location = new System.Drawing.Point(12, 181);
            this.btPesquisa.Name = "btPesquisa";
            this.btPesquisa.Size = new System.Drawing.Size(177, 30);
            this.btPesquisa.TabIndex = 1;
            this.btPesquisa.Text = "Pesquisa";
            this.btPesquisa.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btPesquisa.Click += new System.EventHandler(this.btPesquisa_Click);
            // 
            // btCliente
            // 
            this.btCliente.BackColor = System.Drawing.Color.Transparent;
            this.btCliente.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btCliente.Image = null;
            this.btCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCliente.Location = new System.Drawing.Point(12, 84);
            this.btCliente.Name = "btCliente";
            this.btCliente.Size = new System.Drawing.Size(177, 30);
            this.btCliente.TabIndex = 0;
            this.btCliente.Text = "CLIENTES";
            this.btCliente.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btCliente.Click += new System.EventHandler(this.btCliente_Click);
            // 
            // ambiance_ControlBox1
            // 
            this.ambiance_ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_ControlBox1.EnableMaximize = true;
            this.ambiance_ControlBox1.Font = new System.Drawing.Font("Marlett", 7F);
            this.ambiance_ControlBox1.Location = new System.Drawing.Point(5, 13);
            this.ambiance_ControlBox1.Name = "ambiance_ControlBox1";
            this.ambiance_ControlBox1.Size = new System.Drawing.Size(64, 22);
            this.ambiance_ControlBox1.TabIndex = 2;
            this.ambiance_ControlBox1.Text = "ambiance_ControlBox1";
            // 
            // btFuncionario
            // 
            this.btFuncionario.BackColor = System.Drawing.Color.Transparent;
            this.btFuncionario.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btFuncionario.Image = null;
            this.btFuncionario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btFuncionario.Location = new System.Drawing.Point(12, 288);
            this.btFuncionario.Name = "btFuncionario";
            this.btFuncionario.Size = new System.Drawing.Size(177, 30);
            this.btFuncionario.TabIndex = 3;
            this.btFuncionario.Text = "Funcionario";
            this.btFuncionario.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btFuncionario.Click += new System.EventHandler(this.btFuncionario_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btFuncionario);
            this.Controls.Add(this.ambiance_ControlBox1);
            this.Controls.Add(this.btPesquisa);
            this.Controls.Add(this.btCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(94, 32);
            this.Name = "Form1";
            this.Text = "monoFlat_ThemeContainer1";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage3;
        private Ambiance.Ambiance_Button_1 btCliente;
        private Ambiance.Ambiance_Button_1 btPesquisa;
        private Ambiance.Ambiance_ControlBox ambiance_ControlBox1;
        private Ambiance.Ambiance_Button_1 btFuncionario;
    }
}

