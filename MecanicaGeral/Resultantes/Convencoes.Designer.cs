namespace MecanicaGeral.Resultantes
{
    partial class Convencoes
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Rb_ResultanteKn = new System.Windows.Forms.RadioButton();
            this.Rb_ResultanteN = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Rb_MomentoNCm = new System.Windows.Forms.RadioButton();
            this.Rb_MomentoKnM = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Expressar resultante em:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Rb_ResultanteN);
            this.panel1.Controls.Add(this.Rb_ResultanteKn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(134, 49);
            this.panel1.TabIndex = 1;
            // 
            // Rb_ResultanteKn
            // 
            this.Rb_ResultanteKn.AutoSize = true;
            this.Rb_ResultanteKn.Location = new System.Drawing.Point(7, 19);
            this.Rb_ResultanteKn.Name = "Rb_ResultanteKn";
            this.Rb_ResultanteKn.Size = new System.Drawing.Size(38, 17);
            this.Rb_ResultanteKn.TabIndex = 1;
            this.Rb_ResultanteKn.TabStop = true;
            this.Rb_ResultanteKn.Text = "Kn";
            this.Rb_ResultanteKn.UseVisualStyleBackColor = true;
            // 
            // Rb_ResultanteN
            // 
            this.Rb_ResultanteN.AutoSize = true;
            this.Rb_ResultanteN.Location = new System.Drawing.Point(51, 19);
            this.Rb_ResultanteN.Name = "Rb_ResultanteN";
            this.Rb_ResultanteN.Size = new System.Drawing.Size(33, 17);
            this.Rb_ResultanteN.TabIndex = 1;
            this.Rb_ResultanteN.TabStop = true;
            this.Rb_ResultanteN.Text = "N";
            this.Rb_ResultanteN.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Rb_MomentoNCm);
            this.panel2.Controls.Add(this.Rb_MomentoKnM);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(145, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(134, 49);
            this.panel2.TabIndex = 1;
            // 
            // Rb_MomentoNCm
            // 
            this.Rb_MomentoNCm.AutoSize = true;
            this.Rb_MomentoNCm.Location = new System.Drawing.Point(60, 19);
            this.Rb_MomentoNCm.Name = "Rb_MomentoNCm";
            this.Rb_MomentoNCm.Size = new System.Drawing.Size(48, 17);
            this.Rb_MomentoNCm.TabIndex = 1;
            this.Rb_MomentoNCm.TabStop = true;
            this.Rb_MomentoNCm.Text = "NCm";
            this.Rb_MomentoNCm.UseVisualStyleBackColor = true;
            // 
            // Rb_MomentoKnM
            // 
            this.Rb_MomentoKnM.AutoSize = true;
            this.Rb_MomentoKnM.Location = new System.Drawing.Point(7, 19);
            this.Rb_MomentoKnM.Name = "Rb_MomentoKnM";
            this.Rb_MomentoKnM.Size = new System.Drawing.Size(47, 17);
            this.Rb_MomentoKnM.TabIndex = 1;
            this.Rb_MomentoKnM.TabStop = true;
            this.Rb_MomentoKnM.Text = "KnM";
            this.Rb_MomentoKnM.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Expressar momento em:";
            // 
            // Convencoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 60);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Convencoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Convenções de medida";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Convencoes_FormClosing);
            this.Load += new System.EventHandler(this.Convencoes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton Rb_ResultanteN;
        private System.Windows.Forms.RadioButton Rb_ResultanteKn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton Rb_MomentoNCm;
        private System.Windows.Forms.RadioButton Rb_MomentoKnM;
        private System.Windows.Forms.Label label2;
    }
}