namespace Unidad3Practica1Problema17
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
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(145, 9);
            label1.Name = "label1";
            label1.Size = new Size(506, 37);
            label1.TabIndex = 0;
            label1.Text = "Ordenar 3 números de mayor a menor";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(88, 97);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 39);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(352, 97);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 39);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.Location = new Point(610, 97);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 39);
            textBox3.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(111, 148);
            label2.Name = "label2";
            label2.Size = new Size(48, 50);
            label2.TabIndex = 4;
            label2.Text = "A";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(377, 148);
            label3.Name = "label3";
            label3.Size = new Size(46, 50);
            label3.TabIndex = 5;
            label3.Text = "B";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(634, 148);
            label4.Name = "label4";
            label4.Size = new Size(45, 50);
            label4.TabIndex = 6;
            label4.Text = "C";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(316, 240);
            button1.Name = "button1";
            button1.Size = new Size(164, 71);
            button1.TabIndex = 7;
            button1.Text = "Ordenar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            textBox4.Location = new Point(88, 365);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 39);
            textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            textBox5.Location = new Point(352, 365);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 39);
            textBox5.TabIndex = 9;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            textBox6.Location = new Point(610, 365);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 39);
            textBox6.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.grid_paper_pattern_background_vector;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
    }
}