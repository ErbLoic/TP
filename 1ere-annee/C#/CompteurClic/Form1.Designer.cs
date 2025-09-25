namespace CompteurClic
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
            btn = new Button();
            btn1 = new Button();
            button1 = new Button();
            textBox2 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Top;
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(0, 0);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(221, 40);
            textBox1.TabIndex = 0;
            textBox1.Text = "0";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.ReadOnly = true;
            // 
            // btn
            // 
            btn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn.Location = new Point(35, 72);
            btn.Name = "btn";
            btn.Size = new Size(141, 51);
            btn.TabIndex = 1;
            btn.Text = "+1";
            btn.UseVisualStyleBackColor = true;
            btn.Click += btn_Click;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn1.Location = new Point(35, 159);
            btn1.Name = "btn1";
            btn1.Size = new Size(141, 51);
            btn1.TabIndex = 2;
            btn1.Text = "+5";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(35, 551);
            button1.Name = "button1";
            button1.Size = new Size(141, 51);
            button1.TabIndex = 3;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(0, 660);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(221, 40);
            textBox2.TabIndex = 4;
            textBox2.Text = "0";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 627);
            label1.Name = "label1";
            label1.Size = new Size(191, 30);
            label1.TabIndex = 5;
            label1.Text = "Compteur de click";
            textBox1.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(221, 702);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(btn1);
            Controls.Add(btn);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button btn;
        private Button btn1;
        private Button button1;
        private TextBox textBox2;
        private Label label1;
    }
}
