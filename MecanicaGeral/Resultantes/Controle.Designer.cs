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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.NovoVetor = new System.Windows.Forms.ToolStripMenuItem();
            this.GerarSaida = new System.Windows.Forms.ToolStripMenuItem();
            this.propriedadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convençãoDeUnidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Dgv_Vetores = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Tb_Magnitude = new System.Windows.Forms.TextBox();
            this.Tb_ACosZ = new System.Windows.Forms.TextBox();
            this.Tb_CosZ = new System.Windows.Forms.TextBox();
            this.Tb_Rz = new System.Windows.Forms.TextBox();
            this.Tb_ACosY = new System.Windows.Forms.TextBox();
            this.Tb_ACosX = new System.Windows.Forms.TextBox();
            this.Tb_CosY = new System.Windows.Forms.TextBox();
            this.Tb_CosX = new System.Windows.Forms.TextBox();
            this.Tb_Ry = new System.Windows.Forms.TextBox();
            this.Tb_Rx = new System.Windows.Forms.TextBox();
            this.Tb_Resultante = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Apagar = new System.Windows.Forms.Button();
            this.Btn_Calcular = new System.Windows.Forms.Button();
            this.Btn_Prop = new System.Windows.Forms.Button();
            this.Painel_MI = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.Cb_MomentoInercia = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Vetores)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NovoVetor,
            this.GerarSaida,
            this.propriedadesToolStripMenuItem});
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
            // propriedadesToolStripMenuItem
            // 
            this.propriedadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.convençãoDeUnidadesToolStripMenuItem});
            this.propriedadesToolStripMenuItem.Name = "propriedadesToolStripMenuItem";
            this.propriedadesToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.propriedadesToolStripMenuItem.Text = "Propriedades";
            // 
            // convençãoDeUnidadesToolStripMenuItem
            // 
            this.convençãoDeUnidadesToolStripMenuItem.Name = "convençãoDeUnidadesToolStripMenuItem";
            this.convençãoDeUnidadesToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.convençãoDeUnidadesToolStripMenuItem.Text = "Convenção de unidades";
            this.convençãoDeUnidadesToolStripMenuItem.Click += new System.EventHandler(this.ConvençãoDeUnidadesToolStripMenuItem_Click);
            // 
            // Dgv_Vetores
            // 
            this.Dgv_Vetores.AllowUserToAddRows = false;
            this.Dgv_Vetores.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Vetores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
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
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Tb_Magnitude);
            this.panel1.Controls.Add(this.Tb_ACosZ);
            this.panel1.Controls.Add(this.Tb_CosZ);
            this.panel1.Controls.Add(this.Tb_Rz);
            this.panel1.Controls.Add(this.Tb_ACosY);
            this.panel1.Controls.Add(this.Tb_ACosX);
            this.panel1.Controls.Add(this.Tb_CosY);
            this.panel1.Controls.Add(this.Tb_CosX);
            this.panel1.Controls.Add(this.Tb_Ry);
            this.panel1.Controls.Add(this.Tb_Rx);
            this.panel1.Controls.Add(this.Tb_Resultante);
            this.panel1.Location = new System.Drawing.Point(12, 230);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(647, 191);
            this.panel1.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(521, 144);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Arccoss Z";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(521, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Cos Z";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(399, 144);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Arccoss Y";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(399, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Cos Y";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(274, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Arccoss X";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(274, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Cos X";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Magnitude";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(518, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Rz";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(399, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ry";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rx";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Resultante";
            // 
            // Tb_Magnitude
            // 
            this.Tb_Magnitude.Location = new System.Drawing.Point(20, 79);
            this.Tb_Magnitude.Name = "Tb_Magnitude";
            this.Tb_Magnitude.ReadOnly = true;
            this.Tb_Magnitude.Size = new System.Drawing.Size(116, 20);
            this.Tb_Magnitude.TabIndex = 1;
            // 
            // Tb_ACosZ
            // 
            this.Tb_ACosZ.Location = new System.Drawing.Point(521, 160);
            this.Tb_ACosZ.Name = "Tb_ACosZ";
            this.Tb_ACosZ.ReadOnly = true;
            this.Tb_ACosZ.Size = new System.Drawing.Size(116, 20);
            this.Tb_ACosZ.TabIndex = 1;
            // 
            // Tb_CosZ
            // 
            this.Tb_CosZ.Location = new System.Drawing.Point(521, 120);
            this.Tb_CosZ.Name = "Tb_CosZ";
            this.Tb_CosZ.ReadOnly = true;
            this.Tb_CosZ.Size = new System.Drawing.Size(116, 20);
            this.Tb_CosZ.TabIndex = 1;
            // 
            // Tb_Rz
            // 
            this.Tb_Rz.Location = new System.Drawing.Point(521, 79);
            this.Tb_Rz.Name = "Tb_Rz";
            this.Tb_Rz.ReadOnly = true;
            this.Tb_Rz.Size = new System.Drawing.Size(116, 20);
            this.Tb_Rz.TabIndex = 1;
            // 
            // Tb_ACosY
            // 
            this.Tb_ACosY.Location = new System.Drawing.Point(399, 160);
            this.Tb_ACosY.Name = "Tb_ACosY";
            this.Tb_ACosY.ReadOnly = true;
            this.Tb_ACosY.Size = new System.Drawing.Size(116, 20);
            this.Tb_ACosY.TabIndex = 1;
            // 
            // Tb_ACosX
            // 
            this.Tb_ACosX.Location = new System.Drawing.Point(277, 160);
            this.Tb_ACosX.Name = "Tb_ACosX";
            this.Tb_ACosX.ReadOnly = true;
            this.Tb_ACosX.Size = new System.Drawing.Size(116, 20);
            this.Tb_ACosX.TabIndex = 1;
            // 
            // Tb_CosY
            // 
            this.Tb_CosY.Location = new System.Drawing.Point(399, 120);
            this.Tb_CosY.Name = "Tb_CosY";
            this.Tb_CosY.ReadOnly = true;
            this.Tb_CosY.Size = new System.Drawing.Size(116, 20);
            this.Tb_CosY.TabIndex = 1;
            // 
            // Tb_CosX
            // 
            this.Tb_CosX.Location = new System.Drawing.Point(277, 120);
            this.Tb_CosX.Name = "Tb_CosX";
            this.Tb_CosX.ReadOnly = true;
            this.Tb_CosX.Size = new System.Drawing.Size(116, 20);
            this.Tb_CosX.TabIndex = 1;
            // 
            // Tb_Ry
            // 
            this.Tb_Ry.Location = new System.Drawing.Point(399, 79);
            this.Tb_Ry.Name = "Tb_Ry";
            this.Tb_Ry.ReadOnly = true;
            this.Tb_Ry.Size = new System.Drawing.Size(116, 20);
            this.Tb_Ry.TabIndex = 1;
            // 
            // Tb_Rx
            // 
            this.Tb_Rx.Location = new System.Drawing.Point(277, 79);
            this.Tb_Rx.Name = "Tb_Rx";
            this.Tb_Rx.ReadOnly = true;
            this.Tb_Rx.Size = new System.Drawing.Size(116, 20);
            this.Tb_Rx.TabIndex = 1;
            // 
            // Tb_Resultante
            // 
            this.Tb_Resultante.Location = new System.Drawing.Point(20, 30);
            this.Tb_Resultante.Name = "Tb_Resultante";
            this.Tb_Resultante.ReadOnly = true;
            this.Tb_Resultante.Size = new System.Drawing.Size(617, 20);
            this.Tb_Resultante.TabIndex = 0;
            this.Tb_Resultante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Resultante";
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
            this.Btn_Calcular.Click += new System.EventHandler(this.Btn_Calcular_Click);
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
            // Painel_MI
            // 
            this.Painel_MI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Painel_MI.Enabled = false;
            this.Painel_MI.Location = new System.Drawing.Point(12, 450);
            this.Painel_MI.Name = "Painel_MI";
            this.Painel_MI.Size = new System.Drawing.Size(647, 100);
            this.Painel_MI.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(24, 439);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 22);
            this.label13.TabIndex = 5;
            this.label13.Text = "Momento ";
            // 
            // Cb_MomentoInercia
            // 
            this.Cb_MomentoInercia.AutoSize = true;
            this.Cb_MomentoInercia.Enabled = false;
            this.Cb_MomentoInercia.Location = new System.Drawing.Point(537, 427);
            this.Cb_MomentoInercia.Name = "Cb_MomentoInercia";
            this.Cb_MomentoInercia.Size = new System.Drawing.Size(119, 17);
            this.Cb_MomentoInercia.TabIndex = 8;
            this.Cb_MomentoInercia.Text = "Momento de inércia";
            this.Cb_MomentoInercia.UseVisualStyleBackColor = true;
            // 
            // Controle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(671, 564);
            this.Controls.Add(this.Cb_MomentoInercia);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Painel_MI);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tb_Magnitude;
        private System.Windows.Forms.TextBox Tb_ACosZ;
        private System.Windows.Forms.TextBox Tb_CosZ;
        private System.Windows.Forms.TextBox Tb_Rz;
        private System.Windows.Forms.TextBox Tb_ACosY;
        private System.Windows.Forms.TextBox Tb_ACosX;
        private System.Windows.Forms.TextBox Tb_CosY;
        private System.Windows.Forms.TextBox Tb_CosX;
        private System.Windows.Forms.TextBox Tb_Ry;
        private System.Windows.Forms.TextBox Tb_Rx;
        private System.Windows.Forms.TextBox Tb_Resultante;
        private System.Windows.Forms.ToolStripMenuItem propriedadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convençãoDeUnidadesToolStripMenuItem;
        private System.Windows.Forms.Panel Painel_MI;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox Cb_MomentoInercia;
    }
}