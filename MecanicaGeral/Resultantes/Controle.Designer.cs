namespace MecanicaGeral.Resultantes
{
    partial class Controle
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.NovoVetor = new System.Windows.Forms.ToolStripMenuItem();
            this.GerarSaida = new System.Windows.Forms.ToolStripMenuItem();
            this.Dgv_Vetores = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Apagar = new System.Windows.Forms.Button();
            this.Btn_Calcular = new System.Windows.Forms.Button();
            this.Btn_Prop = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Vetores)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NovoVetor,
            this.GerarSaida});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(671, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // NovoVetor
            // 
            this.NovoVetor.Name = "NovoVetor";
            this.NovoVetor.Size = new System.Drawing.Size(78, 20);
            this.NovoVetor.Text = "Novo vetor";
            this.NovoVetor.Click += new System.EventHandler(this.NovoVetor_Click);
            // 
            // GerarSaida
            // 
            this.GerarSaida.Name = "GerarSaida";
            this.GerarSaida.Size = new System.Drawing.Size(91, 20);
            this.GerarSaida.Text = "Gerar boletim";
            // 
            // Dgv_Vetores
            // 
            this.Dgv_Vetores.AllowUserToAddRows = false;
            this.Dgv_Vetores.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Vetores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_Vetores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Vetores.EnableHeadersVisualStyles = false;
            this.Dgv_Vetores.Location = new System.Drawing.Point(12, 39);
            this.Dgv_Vetores.MultiSelect = false;
            this.Dgv_Vetores.Name = "Dgv_Vetores";
            this.Dgv_Vetores.ReadOnly = true;
            this.Dgv_Vetores.RowHeadersVisible = false;
            this.Dgv_Vetores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Vetores.Size = new System.Drawing.Size(647, 157);
            this.Dgv_Vetores.TabIndex = 3;
            this.Dgv_Vetores.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(12, 230);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(647, 134);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Dados";
            // 
            // Btn_Apagar
            // 
            this.Btn_Apagar.Location = new System.Drawing.Point(584, 202);
            this.Btn_Apagar.Name = "Btn_Apagar";
            this.Btn_Apagar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Apagar.TabIndex = 6;
            this.Btn_Apagar.Text = "Apagar";
            this.Btn_Apagar.UseVisualStyleBackColor = true;
            this.Btn_Apagar.Click += new System.EventHandler(this.Btn_Apagar_Click);
            // 
            // Btn_Calcular
            // 
            this.Btn_Calcular.Location = new System.Drawing.Point(422, 202);
            this.Btn_Calcular.Name = "Btn_Calcular";
            this.Btn_Calcular.Size = new System.Drawing.Size(75, 23);
            this.Btn_Calcular.TabIndex = 6;
            this.Btn_Calcular.Text = "Calcular";
            this.Btn_Calcular.UseVisualStyleBackColor = true;
            // 
            // Btn_Prop
            // 
            this.Btn_Prop.Location = new System.Drawing.Point(503, 202);
            this.Btn_Prop.Name = "Btn_Prop";
            this.Btn_Prop.Size = new System.Drawing.Size(75, 23);
            this.Btn_Prop.TabIndex = 6;
            this.Btn_Prop.Text = "Prop";
            this.Btn_Prop.UseVisualStyleBackColor = true;
            this.Btn_Prop.Click += new System.EventHandler(this.Btn_Prop_Click);
            // 
            // Controle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 373);
            this.Controls.Add(this.Btn_Prop);
            this.Controls.Add(this.Btn_Calcular);
            this.Controls.Add(this.Btn_Apagar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Dgv_Vetores);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Controle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle - Resultantes";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Vetores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem NovoVetor;
        private System.Windows.Forms.ToolStripMenuItem GerarSaida;
        private System.Windows.Forms.DataGridView Dgv_Vetores;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Apagar;
        private System.Windows.Forms.Button Btn_Calcular;
        private System.Windows.Forms.Button Btn_Prop;
    }
}