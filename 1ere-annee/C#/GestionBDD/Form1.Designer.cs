namespace GestionBDD
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
            btnAdd = new Button();
            btndel = new Button();
            btnmodif = new Button();
            listBox1 = new ListBox();
            comboBox1 = new ComboBox();
            btncharg = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(847, 257);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Ajouter";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btndel
            // 
            btndel.Location = new Point(847, 328);
            btndel.Name = "btndel";
            btndel.Size = new Size(75, 23);
            btndel.TabIndex = 1;
            btndel.Text = "Supprimer";
            btndel.UseVisualStyleBackColor = true;
            btndel.Click += btndel_Click;
            // 
            // btnmodif
            // 
            btnmodif.Location = new Point(847, 389);
            btnmodif.Name = "btnmodif";
            btnmodif.Size = new Size(75, 23);
            btnmodif.TabIndex = 2;
            btnmodif.Text = "Modifier";
            btnmodif.UseVisualStyleBackColor = true;
            btnmodif.Click += btnmodif_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(57, 172);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(604, 454);
            listBox1.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(57, 60);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(604, 23);
            comboBox1.TabIndex = 5;
            // 
            // btncharg
            // 
            btncharg.Location = new Point(847, 185);
            btncharg.Name = "btncharg";
            btncharg.Size = new Size(75, 23);
            btncharg.TabIndex = 6;
            btncharg.Text = "Charger";
            btncharg.UseVisualStyleBackColor = true;
            btncharg.Click += btncharg_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(580, 629);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1070, 746);
            Controls.Add(label1);
            Controls.Add(btncharg);
            Controls.Add(comboBox1);
            Controls.Add(listBox1);
            Controls.Add(btnmodif);
            Controls.Add(btndel);
            Controls.Add(btnAdd);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btndel;
        private Button btnmodif;
        private ListBox listBox1;
        private ComboBox comboBox1;
        private Button btncharg;
        private Label label1;
    }
}
