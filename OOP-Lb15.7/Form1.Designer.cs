namespace OOP_Lb15._7
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
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(327, 309);
            button1.Name = "button1";
            button1.Size = new Size(122, 34);
            button1.TabIndex = 0;
            button1.Text = "Підрахувати";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 372);
            label1.Name = "label1";
            label1.Size = new Size(776, 35);
            label1.TabIndex = 1;
            label1.Text = "Кількість букв К(k) в останньому слові: ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(197, 264);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(398, 23);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(303, 226);
            label2.Name = "label2";
            label2.Size = new Size(192, 35);
            label2.TabIndex = 3;
            label2.Text = "Введіть Речення";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Завдання 7";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
    }
}
