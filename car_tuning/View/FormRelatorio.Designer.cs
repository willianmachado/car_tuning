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
            this.btCarregar = new iTalk.iTalk_Button_2();
            this.ambiance_TabControl1 = new Ambiance.Ambiance_TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.crvCliente = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.iTalk_Button_21 = new iTalk.iTalk_Button_2();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.crvCarro = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.ambiance_TabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            this.SuspendLayout();
            // 
            // btCarregar
            // 
            this.btCarregar.BackColor = System.Drawing.Color.Transparent;
            this.btCarregar.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btCarregar.ForeColor = System.Drawing.Color.White;
            this.btCarregar.Image = null;
            this.btCarregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCarregar.Location = new System.Drawing.Point(1126, 679);
            this.btCarregar.Name = "btCarregar";
            this.btCarregar.Size = new System.Drawing.Size(166, 40);
            this.btCarregar.TabIndex = 1;
            this.btCarregar.Text = "Carregar";
            this.btCarregar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btCarregar.Click += new System.EventHandler(this.btCarregar_Click);
            // 
            // ambiance_TabControl1
            // 
            this.ambiance_TabControl1.Controls.Add(this.tabPage1);
            this.ambiance_TabControl1.Controls.Add(this.tabPage2);
            this.ambiance_TabControl1.Controls.Add(this.tabPage3);
            this.ambiance_TabControl1.Controls.Add(this.tabPage4);
            this.ambiance_TabControl1.Controls.Add(this.tabPage5);
            this.ambiance_TabControl1.Controls.Add(this.tabPage6);
            this.ambiance_TabControl1.ItemSize = new System.Drawing.Size(80, 24);
            this.ambiance_TabControl1.Location = new System.Drawing.Point(0, 0);
            this.ambiance_TabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.ambiance_TabControl1.Name = "ambiance_TabControl1";
            this.ambiance_TabControl1.SelectedIndex = 0;
            this.ambiance_TabControl1.Size = new System.Drawing.Size(1296, 648);
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
            this.tabPage1.Size = new System.Drawing.Size(1288, 616);
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
            this.crvCliente.Size = new System.Drawing.Size(1284, 612);
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
            this.tabPage2.Size = new System.Drawing.Size(1288, 616);
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
            this.crvCarro.Size = new System.Drawing.Size(1284, 612);
            this.crvCarro.TabIndex = 4;
            this.crvCarro.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(1288, 616);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Peças";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.tabPage4.Location = new System.Drawing.Point(4, 28);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage4.Size = new System.Drawing.Size(1288, 616);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Serviços";
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.tabPage5.Location = new System.Drawing.Point(4, 28);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage5.Size = new System.Drawing.Size(1288, 616);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Funcionário";
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.tabPage6.Controls.Add(this.dataGridView6);
            this.tabPage6.Location = new System.Drawing.Point(4, 28);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage6.Size = new System.Drawing.Size(1288, 616);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Rank ";
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
            // FormRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 752);
            this.ControlBox = false;
            this.Controls.Add(this.btCarregar);
            this.Controls.Add(this.ambiance_TabControl1);
            this.Name = "FormRelatorio";
            this.Load += new System.EventHandler(this.FormRelatorio_Load);
            this.ambiance_TabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
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
        private iTalk.iTalk_Button_2 btCarregar;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvCarro;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvCliente;
    }
}
          

        

