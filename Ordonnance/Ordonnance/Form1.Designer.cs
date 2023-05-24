namespace Ordonnance
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
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            button1 = new Button();
            textBox4 = new TextBox();
            label4 = new Label();
            progressBar1 = new ProgressBar();
            richTextBox1 = new RichTextBox();
            label5 = new Label();
            numericUpDown1 = new NumericUpDown();
            label6 = new Label();
            textBox5 = new TextBox();
            label7 = new Label();
            label8 = new Label();
            numericUpDown2 = new NumericUpDown();
            label9 = new Label();
            textBox6 = new TextBox();
            cabinetName = new TextBox();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(216, 23);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 1;
            label1.Text = "Nom médecin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 70);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 2;
            label2.Text = "Nom du patient";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 88);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(216, 23);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 114);
            label3.Name = "label3";
            label3.Size = new Size(190, 15);
            label3.TabIndex = 4;
            label3.Text = "Naissance du patient (jj/mm/aaaa)";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 132);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(216, 23);
            textBox3.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(12, 219);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Download";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(12, 176);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(216, 23);
            textBox4.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 158);
            label4.Name = "label4";
            label4.Size = new Size(150, 15);
            label4.TabIndex = 8;
            label4.Text = "Adresse de téléchargement";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(102, 219);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(280, 23);
            progressBar1.TabIndex = 9;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(399, 44);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(395, 155);
            richTextBox1.TabIndex = 10;
            richTextBox1.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(399, 26);
            label5.Name = "label5";
            label5.Size = new Size(75, 15);
            label5.TabIndex = 11;
            label5.Text = "Prescriptions";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(566, 219);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(35, 23);
            numericUpDown1.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(399, 223);
            label6.Name = "label6";
            label6.Size = new Size(161, 15);
            label6.TabIndex = 13;
            label6.Text = "Nombre de produits prescrits";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(243, 44);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(139, 23);
            textBox5.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(243, 26);
            label7.Name = "label7";
            label7.Size = new Size(95, 15);
            label7.TabIndex = 15;
            label7.Text = "Genre du patient";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(243, 70);
            label8.Name = "label8";
            label8.Size = new Size(85, 15);
            label8.TabIndex = 16;
            label8.Text = "Age du patient";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(243, 89);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(139, 23);
            numericUpDown2.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(243, 115);
            label9.Name = "label9";
            label9.Size = new Size(114, 15);
            label9.TabIndex = 18;
            label9.Text = "Lieu de consultation";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(243, 133);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(139, 23);
            textBox6.TabIndex = 19;
            // 
            // cabinetName
            // 
            cabinetName.Location = new Point(243, 177);
            cabinetName.Name = "cabinetName";
            cabinetName.Size = new Size(139, 23);
            cabinetName.TabIndex = 20;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(243, 159);
            label10.Name = "label10";
            label10.Size = new Size(93, 15);
            label10.TabIndex = 21;
            label10.Text = "Nom du cabinet";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(811, 276);
            Controls.Add(label10);
            Controls.Add(cabinetName);
            Controls.Add(textBox6);
            Controls.Add(label9);
            Controls.Add(numericUpDown2);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(numericUpDown1);
            Controls.Add(label5);
            Controls.Add(richTextBox1);
            Controls.Add(progressBar1);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ordonnance Maker";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Button button1;
        private TextBox textBox4;
        private Label label4;
        private ProgressBar progressBar1;
        private RichTextBox richTextBox1;
        private Label label5;
        private NumericUpDown numericUpDown1;
        private Label label6;
        private TextBox textBox5;
        private Label label7;
        private Label label8;
        private NumericUpDown numericUpDown2;
        private Label label9;
        private TextBox textBox6;
        private TextBox cabinetName;
        private Label label10;
    }
}