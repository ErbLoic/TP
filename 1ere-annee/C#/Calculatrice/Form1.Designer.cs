namespace Calculatrice
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
            Total = new TextBox();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            plus = new Button();
            moins = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            div = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            egal = new Button();
            mult = new Button();
            clear = new Button();
            btn = new Button();
            SuspendLayout();
            // 
            // Total
            // 
            Total.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Total.BackColor = SystemColors.ScrollBar;
            Total.Cursor = Cursors.Hand;
            Total.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Total.ForeColor = SystemColors.ActiveCaptionText;
            Total.Location = new Point(50, 23);
            Total.Margin = new Padding(0);
            Total.Multiline = true;
            Total.Name = "Total";
            Total.Size = new Size(371, 58);
            Total.TabIndex = 0;
            // 
            // btn1
            // 
            btn1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn1.Cursor = Cursors.Hand;
            btn1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn1.ForeColor = SystemColors.ActiveCaptionText;
            btn1.Location = new Point(50, 117);
            btn1.Margin = new Padding(0);
            btn1.Name = "btn1";
            btn1.Size = new Size(60, 53);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn2.Cursor = Cursors.Hand;
            btn2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn2.ForeColor = SystemColors.ActiveCaptionText;
            btn2.Location = new Point(154, 117);
            btn2.Margin = new Padding(0);
            btn2.Name = "btn2";
            btn2.Size = new Size(60, 53);
            btn2.TabIndex = 2;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn3.Cursor = Cursors.Hand;
            btn3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn3.ForeColor = SystemColors.ActiveCaptionText;
            btn3.Location = new Point(260, 117);
            btn3.Margin = new Padding(0);
            btn3.Name = "btn3";
            btn3.Size = new Size(60, 53);
            btn3.TabIndex = 3;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // plus
            // 
            plus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            plus.BackColor = Color.FromArgb(255, 128, 0);
            plus.Cursor = Cursors.Hand;
            plus.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            plus.ForeColor = SystemColors.ActiveCaptionText;
            plus.Location = new Point(373, 117);
            plus.Margin = new Padding(0);
            plus.Name = "plus";
            plus.Size = new Size(60, 53);
            plus.TabIndex = 4;
            plus.Text = "+";
            plus.UseVisualStyleBackColor = false;
            plus.Click += plus_Click;
            // 
            // moins
            // 
            moins.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            moins.BackColor = Color.FromArgb(255, 128, 0);
            moins.Cursor = Cursors.Hand;
            moins.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            moins.ForeColor = SystemColors.ActiveCaptionText;
            moins.Location = new Point(373, 235);
            moins.Margin = new Padding(0);
            moins.Name = "moins";
            moins.Size = new Size(60, 53);
            moins.TabIndex = 8;
            moins.Text = "-";
            moins.UseVisualStyleBackColor = false;
            moins.Click += moins_Click;
            // 
            // btn6
            // 
            btn6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn6.Cursor = Cursors.Hand;
            btn6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn6.ForeColor = SystemColors.ActiveCaptionText;
            btn6.Location = new Point(260, 235);
            btn6.Margin = new Padding(0);
            btn6.Name = "btn6";
            btn6.Size = new Size(60, 53);
            btn6.TabIndex = 7;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn5
            // 
            btn5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn5.Cursor = Cursors.Hand;
            btn5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn5.ForeColor = SystemColors.ActiveCaptionText;
            btn5.Location = new Point(154, 235);
            btn5.Margin = new Padding(0);
            btn5.Name = "btn5";
            btn5.Size = new Size(60, 53);
            btn5.TabIndex = 6;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn4
            // 
            btn4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn4.Cursor = Cursors.Hand;
            btn4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn4.ForeColor = SystemColors.ActiveCaptionText;
            btn4.Location = new Point(50, 235);
            btn4.Margin = new Padding(0);
            btn4.Name = "btn4";
            btn4.Size = new Size(60, 53);
            btn4.TabIndex = 5;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // div
            // 
            div.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            div.BackColor = Color.FromArgb(255, 128, 0);
            div.Cursor = Cursors.Hand;
            div.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            div.ForeColor = SystemColors.ActiveCaptionText;
            div.Location = new Point(373, 348);
            div.Margin = new Padding(0);
            div.Name = "div";
            div.Size = new Size(60, 53);
            div.TabIndex = 12;
            div.Text = "/";
            div.UseVisualStyleBackColor = false;
            div.Click += div_Click;
            // 
            // btn9
            // 
            btn9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn9.Cursor = Cursors.Hand;
            btn9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn9.ForeColor = SystemColors.ActiveCaptionText;
            btn9.Location = new Point(260, 348);
            btn9.Margin = new Padding(0);
            btn9.Name = "btn9";
            btn9.Size = new Size(60, 53);
            btn9.TabIndex = 11;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn8
            // 
            btn8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn8.Cursor = Cursors.Hand;
            btn8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn8.ForeColor = SystemColors.ActiveCaptionText;
            btn8.Location = new Point(154, 348);
            btn8.Margin = new Padding(0);
            btn8.Name = "btn8";
            btn8.Size = new Size(60, 53);
            btn8.TabIndex = 10;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn7
            // 
            btn7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn7.Cursor = Cursors.Hand;
            btn7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn7.ForeColor = SystemColors.ActiveCaptionText;
            btn7.Location = new Point(50, 348);
            btn7.Margin = new Padding(0);
            btn7.Name = "btn7";
            btn7.Size = new Size(60, 53);
            btn7.TabIndex = 9;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // egal
            // 
            egal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            egal.BackColor = Color.FromArgb(255, 128, 0);
            egal.Cursor = Cursors.Hand;
            egal.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            egal.ForeColor = SystemColors.ActiveCaptionText;
            egal.Location = new Point(373, 452);
            egal.Margin = new Padding(0);
            egal.Name = "egal";
            egal.Size = new Size(60, 53);
            egal.TabIndex = 16;
            egal.Text = "=";
            egal.UseVisualStyleBackColor = false;
            egal.Click += egal_Click;
            // 
            // mult
            // 
            mult.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mult.BackColor = Color.FromArgb(255, 128, 0);
            mult.Cursor = Cursors.Hand;
            mult.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mult.ForeColor = SystemColors.ActiveCaptionText;
            mult.Location = new Point(260, 452);
            mult.Margin = new Padding(0);
            mult.Name = "mult";
            mult.Size = new Size(60, 53);
            mult.TabIndex = 15;
            mult.Text = "*";
            mult.UseVisualStyleBackColor = false;
            mult.Click += mult_Click;
            // 
            // clear
            // 
            clear.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            clear.BackColor = Color.FromArgb(255, 128, 0);
            clear.Cursor = Cursors.Hand;
            clear.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clear.ForeColor = SystemColors.ActiveCaptionText;
            clear.Location = new Point(154, 452);
            clear.Margin = new Padding(0);
            clear.Name = "clear";
            clear.Size = new Size(60, 53);
            clear.TabIndex = 14;
            clear.Text = "CE";
            clear.UseVisualStyleBackColor = false;
            clear.Click += clear_Click;
            // 
            // btn
            // 
            btn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn.Cursor = Cursors.Hand;
            btn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn.ForeColor = SystemColors.ActiveCaptionText;
            btn.Location = new Point(50, 452);
            btn.Margin = new Padding(0);
            btn.Name = "btn";
            btn.Size = new Size(60, 53);
            btn.TabIndex = 17;
            btn.Text = "0";
            btn.UseVisualStyleBackColor = true;
            btn.Click += btn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(468, 559);
            Controls.Add(btn);
            Controls.Add(egal);
            Controls.Add(mult);
            Controls.Add(clear);
            Controls.Add(div);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(moins);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(plus);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(Total);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Total;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button plus;
        private Button moins;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button div;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button egal;
        private Button mult;
        private Button clear;
        private Button btn;
    }
}
