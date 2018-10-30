namespace car_tuning
{
    partial class FormHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsCliente = new System.Windows.Forms.ToolStripButton();
            this.tsCarro = new System.Windows.Forms.ToolStripButton();
            this.tsPeca = new System.Windows.Forms.ToolStripButton();
            this.tsSrevico = new System.Windows.Forms.ToolStripButton();
            this.tsPesquisa = new System.Windows.Forms.ToolStripButton();
            this.tsRelatorio = new System.Windows.Forms.ToolStripButton();
            this.btSair = new System.Windows.Forms.ToolStripButton();
            this.tsfuncionario = new System.Windows.Forms.ToolStripButton();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(46, 46);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsCliente,
            this.tsCarro,
            this.tsPeca,
            this.tsSrevico,
            this.tsPesquisa,
            this.tsRelatorio,
            this.btSair,
            this.tsfuncionario});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1344, 53);
            this.toolStrip2.TabIndex = 0;
            // 
            // tsCliente
            // 
            this.tsCliente.BackColor = System.Drawing.SystemColors.Control;
            this.tsCliente.Image = global::car_tuning.Properties.Resources.Cliente;
            this.tsCliente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsCliente.Name = "tsCliente";
            this.tsCliente.Size = new System.Drawing.Size(94, 50);
            this.tsCliente.Text = "Cliente";
            this.tsCliente.Click += new System.EventHandler(this.tsCliente_Click);
            // 
            // tsCarro
            // 
            this.tsCarro.Image = ((System.Drawing.Image)(resources.GetObject("tsCarro.Image")));
            this.tsCarro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsCarro.Name = "tsCarro";
            this.tsCarro.Size = new System.Drawing.Size(86, 50);
            this.tsCarro.Text = "Carro";
            this.tsCarro.Click += new System.EventHandler(this.tsCarro_Click);
            // 
            // tsPeca
            // 
            this.tsPeca.Image = ((System.Drawing.Image)(resources.GetObject("tsPeca.Image")));
            this.tsPeca.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsPeca.Name = "tsPeca";
            this.tsPeca.Size = new System.Drawing.Size(87, 50);
            this.tsPeca.Text = "Peças";
            this.tsPeca.Click += new System.EventHandler(this.tsPeca_Click);
            // 
            // tsSrevico
            // 
            this.tsSrevico.Image = ((System.Drawing.Image)(resources.GetObject("tsSrevico.Image")));
            this.tsSrevico.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSrevico.Name = "tsSrevico";
            this.tsSrevico.Size = new System.Drawing.Size(100, 50);
            this.tsSrevico.Text = "Serviços";
            this.tsSrevico.Click += new System.EventHandler(this.tsServico_Click);
            // 
            // tsPesquisa
            // 
            this.tsPesquisa.Image = ((System.Drawing.Image)(resources.GetObject("tsPesquisa.Image")));
            this.tsPesquisa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsPesquisa.Name = "tsPesquisa";
            this.tsPesquisa.Size = new System.Drawing.Size(103, 50);
            this.tsPesquisa.Text = "Pesquisa";
            this.tsPesquisa.Click += new System.EventHandler(this.tsPesquisa_Click);
            // 
            // tsRelatorio
            // 
            this.tsRelatorio.Image = ((System.Drawing.Image)(resources.GetObject("tsRelatorio.Image")));
            this.tsRelatorio.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsRelatorio.Name = "tsRelatorio";
            this.tsRelatorio.Size = new System.Drawing.Size(109, 50);
            this.tsRelatorio.Text = "Relatórios";
            this.tsRelatorio.Click += new System.EventHandler(this.tsRelatorio_Click);
            // 
            // btSair
            // 
            this.btSair.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btSair.Image = ((System.Drawing.Image)(resources.GetObject("btSair.Image")));
            this.btSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(50, 50);
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // tsfuncionario
            // 
            this.tsfuncionario.Image = ((System.Drawing.Image)(resources.GetObject("tsfuncionario.Image")));
            this.tsfuncionario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsfuncionario.Name = "tsfuncionario";
            this.tsfuncionario.Size = new System.Drawing.Size(120, 50);
            this.tsfuncionario.Text = "Funcionário";
            this.tsfuncionario.Click += new System.EventHandler(this.tsfuncionario_Click);
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(796, 446);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 749);
            this.ControlBox = false;
            this.Controls.Add(this.toolStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormHome";
            this.Text = "Car_Tuning";
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton tsCliente;
        private System.Windows.Forms.ToolStripButton tsPeca;
        private System.Windows.Forms.ToolStripButton tsSrevico;
        private System.Windows.Forms.ToolStripButton tsPesquisa;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.ToolStripButton tsRelatorio;
        private System.Windows.Forms.ToolStripButton btSair;
        private System.Windows.Forms.ToolStripButton tsCarro;
        private System.Windows.Forms.ToolStripButton tsfuncionario;
    }
}