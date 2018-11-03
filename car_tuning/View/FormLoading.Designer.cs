namespace car_tuning.View
{
    partial class FormLoading
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pgbProgressao = new Ambiance.Ambiance_ProgressBar();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pgbProgressao
            // 
            this.pgbProgressao.BackColor = System.Drawing.Color.Transparent;
            this.pgbProgressao.DrawHatch = true;
            this.pgbProgressao.Location = new System.Drawing.Point(12, 37);
            this.pgbProgressao.Maximum = 100;
            this.pgbProgressao.Minimum = 0;
            this.pgbProgressao.MinimumSize = new System.Drawing.Size(58, 20);
            this.pgbProgressao.Name = "pgbProgressao";
            this.pgbProgressao.ShowPercentage = true;
            this.pgbProgressao.Size = new System.Drawing.Size(386, 20);
            this.pgbProgressao.TabIndex = 0;
            this.pgbProgressao.Text = "ambiance_ProgressBar1";
            this.pgbProgressao.Value = 0;
            this.pgbProgressao.ValueAlignment = Ambiance.Ambiance_ProgressBar.Alignment.Right;
            // 
            // FormLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 94);
            this.ControlBox = false;
            this.Controls.Add(this.pgbProgressao);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLoading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private Ambiance.Ambiance_ProgressBar pgbProgressao;
        private System.Windows.Forms.Timer timer1;
    }
}