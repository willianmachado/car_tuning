namespace car_tuning
{
    partial class NotaFiscal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotaFiscal));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.crvNotaF = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.btnBuscaNota = new iTalk.iTalk_Button_2();
            this.btSair = new Ambiance.Ambiance_Button_1();
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
            // crvNotaF
            // 
            this.crvNotaF.ActiveViewIndex = -1;
            this.crvNotaF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvNotaF.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvNotaF.Location = new System.Drawing.Point(-1, 58);
            this.crvNotaF.Name = "crvNotaF";
            this.crvNotaF.Size = new System.Drawing.Size(1099, 677);
            this.crvNotaF.TabIndex = 5;
            this.crvNotaF.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(27, 21);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(183, 20);
            this.txtBusca.TabIndex = 10;
            // 
            // btnBuscaNota
            // 
            this.btnBuscaNota.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscaNota.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnBuscaNota.ForeColor = System.Drawing.Color.White;
            this.btnBuscaNota.Image = null;
            this.btnBuscaNota.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscaNota.Location = new System.Drawing.Point(234, 12);
            this.btnBuscaNota.Name = "btnBuscaNota";
            this.btnBuscaNota.Size = new System.Drawing.Size(120, 40);
            this.btnBuscaNota.TabIndex = 11;
            this.btnBuscaNota.Text = "Buscar";
            this.btnBuscaNota.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnBuscaNota.Click += new System.EventHandler(this.btnBuscaNota_Click);
            // 
            // btSair
            // 
            this.btSair.BackColor = System.Drawing.Color.Transparent;
            this.btSair.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btSair.Image = null;
            this.btSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSair.Location = new System.Drawing.Point(1035, 11);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(52, 41);
            this.btSair.TabIndex = 9;
            this.btSair.Text = "Sair";
            this.btSair.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btSair.Click += new System.EventHandler(this.btSair_Click_1);
            // 
            // NotaFiscal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 734);
            this.Controls.Add(this.btnBuscaNota);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.crvNotaF);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(94, 32);
            this.Name = "NotaFiscal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "monoFlat_ThemeContainer1";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage3;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvNotaF;
        private iTalk.iTalk_Button_2 btnBuscaNota;
        private System.Windows.Forms.TextBox txtBusca;
        private Ambiance.Ambiance_Button_1 btSair;
    }
}

