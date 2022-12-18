namespace MecanicaGeral.Resultantes
{
    partial class PontoEstudo
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
            this.Tb_XV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Tb_YV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Tb_ZV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Tb_XV
            // 
            this.Tb_XV.Location = new System.Drawing.Point(21, 29);
            this.Tb_XV.Name = "Tb_XV";
            this.Tb_XV.Size = new System.Drawing.Size(100, 20);
            this.Tb_XV.TabIndex = 0;
            this.Tb_XV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "X Value";
            // 
            // Tb_YV
            // 
            this.Tb_YV.Location = new System.Drawing.Point(21, 71);
            this.Tb_YV.Name = "Tb_YV";
            this.Tb_YV.Size = new System.Drawing.Size(100, 20);
            this.Tb_YV.TabIndex = 1;
            this.Tb_YV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y Value";
            // 
            // Tb_ZV
            // 
            this.Tb_ZV.Location = new System.Drawing.Point(21, 116);
            this.Tb_ZV.Name = "Tb_ZV";
            this.Tb_ZV.Size = new System.Drawing.Size(100, 20);
            this.Tb_ZV.TabIndex = 2;
            this.Tb_ZV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Z Value";
            // 
            // PontoEstudo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(143, 149);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tb_ZV);
            this.Controls.Add(this.Tb_YV);
            this.Controls.Add(this.Tb_XV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PontoEstudo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ponto de estudo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PontoEstudo_FormClosing);
            this.Load += new System.EventHandler(this.PontoEstudo_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PontoEstudo_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Tb_XV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tb_YV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tb_ZV;
        private System.Windows.Forms.Label label3;
    }
}