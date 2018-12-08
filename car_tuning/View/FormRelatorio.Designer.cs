namespace car_tuning
{
    partial class FormRelatorio
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
            this.components = new System.ComponentModel.Container();
            this.crPeca1 = new car_tuning.Relatorio.CrPeca();
            this.ambiance_TabControl1 = new Ambiance.Ambiance_TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.crvCliente = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.iTalk_Button_21 = new iTalk.iTalk_Button_2();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.crvCarro = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.crvPeca = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.crvPecas = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.crvFuncionario = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.crvVendapeca = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlacaEvolu = new System.Windows.Forms.MaskedTextBox();
            this.btCarregarEvolu = new iTalk.iTalk_Button_2();
            this.crvEvolucao = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.pecasDAOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ambiance_TabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pecasDAOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ambiance_TabControl1
            // 
            this.ambiance_TabControl1.Controls.Add(this.tabPage1);
            this.ambiance_TabControl1.Controls.Add(this.tabPage2);
            this.ambiance_TabControl1.Controls.Add(this.tabPage3);
            this.ambiance_TabControl1.Controls.Add(this.tabPage4);
            this.ambiance_TabControl1.Controls.Add(this.tabPage5);
            this.ambiance_TabControl1.Controls.Add(this.tabPage6);
            this.ambiance_TabControl1.Controls.Add(this.tabPage7);
            this.ambiance_TabControl1.ItemSize = new System.Drawing.Size(80, 24);
            this.ambiance_TabControl1.Location = new System.Drawing.Point(0, 0);
            this.ambiance_TabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.ambiance_TabControl1.Name = "ambiance_TabControl1";
            this.ambiance_TabControl1.SelectedIndex = 0;
            this.ambiance_TabControl1.Size = new System.Drawing.Size(1201, 707);
            this.ambiance_TabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.tabPage1.Controls.Add(this.crvCliente);
            this.tabPage1.Controls.Add(this.iTalk_Button_21);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(1193, 675);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Clientes";
            // 
            // crvCliente
            // 
            this.crvCliente.ActiveViewIndex = -1;
            this.crvCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvCliente.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvCliente.Location = new System.Drawing.Point(2, 2);
            this.crvCliente.Name = "crvCliente";
            this.crvCliente.Size = new System.Drawing.Size(1189, 671);
            this.crvCliente.TabIndex = 2;
            this.crvCliente.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // iTalk_Button_21
            // 
            this.iTalk_Button_21.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Button_21.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.iTalk_Button_21.ForeColor = System.Drawing.Color.White;
            this.iTalk_Button_21.Image = null;
            this.iTalk_Button_21.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iTalk_Button_21.Location = new System.Drawing.Point(1178, 669);
            this.iTalk_Button_21.Margin = new System.Windows.Forms.Padding(2);
            this.iTalk_Button_21.Name = "iTalk_Button_21";
            this.iTalk_Button_21.Size = new System.Drawing.Size(99, 44);
            this.iTalk_Button_21.TabIndex = 1;
            this.iTalk_Button_21.Text = "Carregar";
            this.iTalk_Button_21.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.tabPage2.Controls.Add(this.crvCarro);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(1193, 675);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Carros";
            // 
            // crvCarro
            // 
            this.crvCarro.ActiveViewIndex = -1;
            this.crvCarro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvCarro.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvCarro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvCarro.Location = new System.Drawing.Point(2, 2);
            this.crvCarro.Name = "crvCarro";
            this.crvCarro.Size = new System.Drawing.Size(1189, 671);
            this.crvCarro.TabIndex = 4;
            this.crvCarro.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.tabPage3.Controls.Add(this.crvPeca);
            this.tabPage3.Controls.Add(this.crvPecas);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(1193, 675);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Peças";
            // 
            // crvPeca
            // 
            this.crvPeca.ActiveViewIndex = -1;
            this.crvPeca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvPeca.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvPeca.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvPeca.Location = new System.Drawing.Point(2, 2);
            this.crvPeca.Name = "crvPeca";
            this.crvPeca.Size = new System.Drawing.Size(1189, 671);
            this.crvPeca.TabIndex = 1;
            this.crvPeca.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // crvPecas
            // 
            this.crvPecas.ActiveViewIndex = -1;
            this.crvPecas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvPecas.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvPecas.DisplayToolbar = false;
            this.crvPecas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvPecas.Location = new System.Drawing.Point(2, 2);
            this.crvPecas.Name = "crvPecas";
            this.crvPecas.Size = new System.Drawing.Size(1189, 671);
            this.crvPecas.TabIndex = 0;
            this.crvPecas.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.tabPage4.Location = new System.Drawing.Point(4, 28);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage4.Size = new System.Drawing.Size(1193, 675);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Serviços";
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.tabPage5.Controls.Add(this.crvFuncionario);
            this.tabPage5.Location = new System.Drawing.Point(4, 28);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage5.Size = new System.Drawing.Size(1193, 675);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Funcionário";
            // 
            // crvFuncionario
            // 
            this.crvFuncionario.ActiveViewIndex = -1;
            this.crvFuncionario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvFuncionario.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvFuncionario.DisplayToolbar = false;
            this.crvFuncionario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvFuncionario.Location = new System.Drawing.Point(2, 2);
            this.crvFuncionario.Name = "crvFuncionario";
            this.crvFuncionario.Size = new System.Drawing.Size(1189, 671);
            this.crvFuncionario.TabIndex = 0;
            this.crvFuncionario.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.tabPage6.Controls.Add(this.crvVendapeca);
            this.tabPage6.Controls.Add(this.dataGridView6);
            this.tabPage6.Location = new System.Drawing.Point(4, 28);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage6.Size = new System.Drawing.Size(1193, 675);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Rank Pecas";
            // 
            // crvVendapeca
            // 
            this.crvVendapeca.ActiveViewIndex = -1;
            this.crvVendapeca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvVendapeca.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvVendapeca.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvVendapeca.Location = new System.Drawing.Point(2, 2);
            this.crvVendapeca.Name = "crvVendapeca";
            this.crvVendapeca.Size = new System.Drawing.Size(1189, 671);
            this.crvVendapeca.TabIndex = 1;
            this.crvVendapeca.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // dataGridView6
            // 
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Location = new System.Drawing.Point(2, 2);
            this.dataGridView6.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.RowTemplate.Height = 24;
            this.dataGridView6.Size = new System.Drawing.Size(1286, 612);
            this.dataGridView6.TabIndex = 0;
            // 
            // tabPage7
            // 
            this.tabPage7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.tabPage7.Controls.Add(this.label1);
            this.tabPage7.Controls.Add(this.txtPlacaEvolu);
            this.tabPage7.Controls.Add(this.btCarregarEvolu);
            this.tabPage7.Controls.Add(this.crvEvolucao);
            this.tabPage7.Location = new System.Drawing.Point(4, 28);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(1193, 675);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Histórico ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Digite a placa ";
            // 
            // txtPlacaEvolu
            // 
            this.txtPlacaEvolu.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtPlacaEvolu.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlacaEvolu.ForeColor = System.Drawing.Color.Black;
            this.txtPlacaEvolu.Location = new System.Drawing.Point(189, 13);
            this.txtPlacaEvolu.Margin = new System.Windows.Forms.Padding(2);
            this.txtPlacaEvolu.Mask = "aaa-0000";
            this.txtPlacaEvolu.Name = "txtPlacaEvolu";
            this.txtPlacaEvolu.Size = new System.Drawing.Size(122, 33);
            this.txtPlacaEvolu.TabIndex = 2;
            this.txtPlacaEvolu.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // btCarregarEvolu
            // 
            this.btCarregarEvolu.BackColor = System.Drawing.Color.Transparent;
            this.btCarregarEvolu.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btCarregarEvolu.ForeColor = System.Drawing.Color.White;
            this.btCarregarEvolu.Image = null;
            this.btCarregarEvolu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCarregarEvolu.Location = new System.Drawing.Point(349, 6);
            this.btCarregarEvolu.Name = "btCarregarEvolu";
            this.btCarregarEvolu.Size = new System.Drawing.Size(166, 40);
            this.btCarregarEvolu.TabIndex = 1;
            this.btCarregarEvolu.Text = "Carregar";
            this.btCarregarEvolu.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btCarregarEvolu.Click += new System.EventHandler(this.btCarregar_Click);
            // 
            // crvEvolucao
            // 
            this.crvEvolucao.ActiveViewIndex = -1;
            this.crvEvolucao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvEvolucao.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvEvolucao.Location = new System.Drawing.Point(6, 67);
            this.crvEvolucao.Name = "crvEvolucao";
            this.crvEvolucao.Size = new System.Drawing.Size(1184, 602);
            this.crvEvolucao.TabIndex = 0;
            this.crvEvolucao.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // pecasDAOBindingSource
            // 
            this.pecasDAOBindingSource.DataSource = typeof(car_tuning.Modelo.PecasDAO);
            // 
            // FormRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 709);
            this.ControlBox = false;
            this.Controls.Add(this.ambiance_TabControl1);
            this.Name = "FormRelatorio";
            this.Load += new System.EventHandler(this.FormRelatorio_Load);
            this.ambiance_TabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pecasDAOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private Ambiance.Ambiance_TabControl ambiance_TabControl1;
        private System.Windows.Forms.DataGridView dataGridView6;
        private iTalk.iTalk_Button_2 iTalk_Button_21;
        private iTalk.iTalk_Button_2 btCarregarEvolu;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvCarro;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvCliente;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvPecas;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvFuncionario;
        private System.Windows.Forms.BindingSource pecasDAOBindingSource;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvVendapeca;
        private Relatorio.CrPeca crPeca1;
        private System.Windows.Forms.TabPage tabPage7;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvEvolucao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtPlacaEvolu;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvPeca;
    }
}
          

        

