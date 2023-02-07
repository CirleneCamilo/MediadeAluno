namespace MédiadeAluno
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.alunoTextBox = new System.Windows.Forms.TextBox();
            this.calcularButton = new System.Windows.Forms.Button();
            this.materiaComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.exercicio2TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.portifolioTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.provaTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.menadeTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mediaTextBox = new System.Windows.Forms.TextBox();
            this.limparButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sairBtText = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.exercicio1TextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(21, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aluno";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // alunoTextBox
            // 
            this.alunoTextBox.BackColor = System.Drawing.Color.SkyBlue;
            this.alunoTextBox.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.alunoTextBox.Location = new System.Drawing.Point(401, 135);
            this.alunoTextBox.Name = "alunoTextBox";
            this.alunoTextBox.Size = new System.Drawing.Size(352, 35);
            this.alunoTextBox.TabIndex = 1;
            this.alunoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // calcularButton
            // 
            this.calcularButton.BackColor = System.Drawing.Color.SkyBlue;
            this.calcularButton.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.calcularButton.Location = new System.Drawing.Point(401, 517);
            this.calcularButton.Name = "calcularButton";
            this.calcularButton.Size = new System.Drawing.Size(352, 46);
            this.calcularButton.TabIndex = 2;
            this.calcularButton.Text = "Calcular";
            this.calcularButton.UseVisualStyleBackColor = false;
            this.calcularButton.Click += new System.EventHandler(this.calcularButton_Click);
            // 
            // materiaComboBox
            // 
            this.materiaComboBox.BackColor = System.Drawing.Color.SkyBlue;
            this.materiaComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materiaComboBox.FormattingEnabled = true;
            this.materiaComboBox.Items.AddRange(new object[] {
            "Linguagem C#",
            "Ferramentas Dev. Gráfico",
            "Game Engine Unity",
            "Game Engine 2D",
            "Construção de Requisitos",
            "Projeto Integrador GMK",
            "Tóp. Esp.Game M. Software"});
            this.materiaComboBox.Location = new System.Drawing.Point(401, 188);
            this.materiaComboBox.Name = "materiaComboBox";
            this.materiaComboBox.Size = new System.Drawing.Size(352, 36);
            this.materiaComboBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(21, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Matéria";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(21, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(387, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Exercício Fix.2 (20% nota final)";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // exercicio2TextBox
            // 
            this.exercicio2TextBox.BackColor = System.Drawing.Color.SkyBlue;
            this.exercicio2TextBox.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exercicio2TextBox.Location = new System.Drawing.Point(401, 272);
            this.exercicio2TextBox.Name = "exercicio2TextBox";
            this.exercicio2TextBox.Size = new System.Drawing.Size(352, 35);
            this.exercicio2TextBox.TabIndex = 1;
            this.exercicio2TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(21, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(353, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Portifólio (35% da nota final)";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // portifolioTextBox
            // 
            this.portifolioTextBox.BackColor = System.Drawing.Color.SkyBlue;
            this.portifolioTextBox.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.portifolioTextBox.Location = new System.Drawing.Point(401, 316);
            this.portifolioTextBox.Name = "portifolioTextBox";
            this.portifolioTextBox.Size = new System.Drawing.Size(352, 35);
            this.portifolioTextBox.TabIndex = 1;
            this.portifolioTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(21, 403);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(326, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Prova  (35% da nota final)";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // provaTextBox
            // 
            this.provaTextBox.BackColor = System.Drawing.Color.SkyBlue;
            this.provaTextBox.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.provaTextBox.Location = new System.Drawing.Point(401, 400);
            this.provaTextBox.Name = "provaTextBox";
            this.provaTextBox.Size = new System.Drawing.Size(352, 35);
            this.provaTextBox.TabIndex = 1;
            this.provaTextBox.TabStop = false;
            this.provaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(21, 363);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(360, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "M. Enade (10% da nota final)";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // menadeTextBox
            // 
            this.menadeTextBox.BackColor = System.Drawing.Color.SkyBlue;
            this.menadeTextBox.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menadeTextBox.Location = new System.Drawing.Point(401, 359);
            this.menadeTextBox.Name = "menadeTextBox";
            this.menadeTextBox.Size = new System.Drawing.Size(352, 35);
            this.menadeTextBox.TabIndex = 1;
            this.menadeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(21, 449);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 38);
            this.label7.TabIndex = 0;
            this.label7.Text = "Média";
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // mediaTextBox
            // 
            this.mediaTextBox.BackColor = System.Drawing.Color.SkyBlue;
            this.mediaTextBox.Enabled = false;
            this.mediaTextBox.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mediaTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.mediaTextBox.Location = new System.Drawing.Point(401, 443);
            this.mediaTextBox.Name = "mediaTextBox";
            this.mediaTextBox.Size = new System.Drawing.Size(352, 44);
            this.mediaTextBox.TabIndex = 1;
            this.mediaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // limparButton
            // 
            this.limparButton.BackColor = System.Drawing.Color.SkyBlue;
            this.limparButton.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.limparButton.Location = new System.Drawing.Point(401, 588);
            this.limparButton.Name = "limparButton";
            this.limparButton.Size = new System.Drawing.Size(352, 37);
            this.limparButton.TabIndex = 2;
            this.limparButton.Text = "Limpar";
            this.limparButton.UseVisualStyleBackColor = false;
            this.limparButton.Click += new System.EventHandler(this.limparButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(342, 672);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 38);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // sairBtText
            // 
            this.sairBtText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sairBtText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sairBtText.ForeColor = System.Drawing.Color.Firebrick;
            this.sairBtText.Location = new System.Drawing.Point(401, 683);
            this.sairBtText.Name = "sairBtText";
            this.sairBtText.Size = new System.Drawing.Size(57, 27);
            this.sairBtText.TabIndex = 5;
            this.sairBtText.Text = "Sair";
            this.sairBtText.Click += new System.EventHandler(this.sairBtText_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(177, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(436, 87);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.BackColor = System.Drawing.Color.SkyBlue;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label8.Font = new System.Drawing.Font("Verdana", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(28, 576);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(353, 49);
            this.label8.TabIndex = 7;
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(113, 537);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(200, 39);
            this.label9.TabIndex = 8;
            this.label9.Text = "Resultado Final";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label9.UseMnemonic = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(21, 232);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(379, 28);
            this.label10.TabIndex = 9;
            this.label10.Text = "Exercício Fix.1 (20% nota final)";
            // 
            // exercicio1TextBox
            // 
            this.exercicio1TextBox.BackColor = System.Drawing.Color.SkyBlue;
            this.exercicio1TextBox.Font = new System.Drawing.Font("Verdana", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exercicio1TextBox.Location = new System.Drawing.Point(401, 230);
            this.exercicio1TextBox.Name = "exercicio1TextBox";
            this.exercicio1TextBox.Size = new System.Drawing.Size(352, 34);
            this.exercicio1TextBox.TabIndex = 10;
            this.exercicio1TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(777, 735);
            this.Controls.Add(this.exercicio1TextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.sairBtText);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.materiaComboBox);
            this.Controls.Add(this.limparButton);
            this.Controls.Add(this.calcularButton);
            this.Controls.Add(this.menadeTextBox);
            this.Controls.Add(this.mediaTextBox);
            this.Controls.Add(this.provaTextBox);
            this.Controls.Add(this.portifolioTextBox);
            this.Controls.Add(this.exercicio2TextBox);
            this.Controls.Add(this.alunoTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "MÉDIA DO ALUNO";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox alunoTextBox;
        private Button calcularButton;
        private ComboBox materiaComboBox;
        private Label label2;
        private Label label3;
        private TextBox exercicio2TextBox;
        private Label label4;
        private TextBox portifolioTextBox;
        private Label label5;
        private TextBox provaTextBox;
        private Label label6;
        private TextBox menadeTextBox;
        private Label label7;
        private TextBox mediaTextBox;
        private Button limparButton;
        private PictureBox pictureBox1;
        private Label sairBtText;
        private PictureBox pictureBox2;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox exercicio1TextBox;
    }
}