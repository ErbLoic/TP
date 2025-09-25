namespace GestionBDD
{
    partial class Form2
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
            label1 = new Label();
            btnmodif = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            checkedListBox1 = new CheckedListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(602, 616);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 14;
            // 
            // btnmodif
            // 
            btnmodif.Location = new Point(869, 376);
            btnmodif.Name = "btnmodif";
            btnmodif.Size = new Size(75, 23);
            btnmodif.TabIndex = 10;
            btnmodif.Text = "Valider";
            btnmodif.UseVisualStyleBackColor = true;
            btnmodif.Click += btnmodif_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(853, 159);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(148, 23);
            textBox1.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(853, 127);
            label2.Name = "label2";
            label2.Size = new Size(122, 15);
            label2.TabIndex = 16;
            label2.Text = "Nombre d'exemplaire";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(120, 42);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 17;
            label3.Text = "Bonjour";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(211, 42);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 18;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(645, 616);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 19;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(120, 127);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(566, 436);
            checkedListBox1.TabIndex = 20;
            checkedListBox1.ItemCheck += listBox2_SelectedIndexChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 678);
            Controls.Add(checkedListBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(btnmodif);
            Name = "Form2";
            Text = "Form2";
            FormClosing += Form2_FormClosing;
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnmodif;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private CheckedListBox checkedListBox1;
    }
}