namespace FormPokeAPI
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
            LstPoke = new ComboBox();
            pctBPoke = new PictureBox();
            name = new Label();
            type1 = new Label();
            type2 = new Label();
            weight = new Label();
            height = new Label();
            bsexp = new Label();
            AddE = new Button();
            consultE = new Button();
            ((System.ComponentModel.ISupportInitialize)pctBPoke).BeginInit();
            SuspendLayout();
            // 
            // LstPoke
            // 
            LstPoke.FormattingEnabled = true;
            LstPoke.Location = new Point(92, 28);
            LstPoke.Name = "LstPoke";
            LstPoke.Size = new Size(583, 23);
            LstPoke.TabIndex = 0;
            LstPoke.SelectedIndexChanged += LstPoke_SelectedIndexChanged;
            // 
            // pctBPoke
            // 
            pctBPoke.Location = new Point(324, 81);
            pctBPoke.Name = "pctBPoke";
            pctBPoke.Size = new Size(157, 102);
            pctBPoke.TabIndex = 1;
            pctBPoke.TabStop = false;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(81, 225);
            name.Name = "name";
            name.Size = new Size(38, 15);
            name.TabIndex = 2;
            name.Text = "label1";
            // 
            // type1
            // 
            type1.AutoSize = true;
            type1.Location = new Point(81, 283);
            type1.Name = "type1";
            type1.Size = new Size(38, 15);
            type1.TabIndex = 3;
            type1.Text = "label1";
            // 
            // type2
            // 
            type2.AutoSize = true;
            type2.Location = new Point(81, 344);
            type2.Name = "type2";
            type2.Size = new Size(38, 15);
            type2.TabIndex = 4;
            type2.Text = "label1";
            // 
            // weight
            // 
            weight.AutoSize = true;
            weight.Location = new Point(637, 344);
            weight.Name = "weight";
            weight.Size = new Size(38, 15);
            weight.TabIndex = 7;
            weight.Text = "label1";
            // 
            // height
            // 
            height.AutoSize = true;
            height.Location = new Point(637, 283);
            height.Name = "height";
            height.Size = new Size(38, 15);
            height.TabIndex = 6;
            height.Text = "label1";
            // 
            // bsexp
            // 
            bsexp.AutoSize = true;
            bsexp.Location = new Point(637, 225);
            bsexp.Name = "bsexp";
            bsexp.Size = new Size(38, 15);
            bsexp.TabIndex = 5;
            bsexp.Text = "label1";
            // 
            // AddE
            // 
            AddE.Location = new Point(130, 404);
            AddE.Name = "AddE";
            AddE.Size = new Size(159, 31);
            AddE.TabIndex = 8;
            AddE.Text = "Ajouter Équipe";
            AddE.UseVisualStyleBackColor = true;
            AddE.Click += AddE_Click;
            // 
            // consultE
            // 
            consultE.Location = new Point(418, 404);
            consultE.Name = "consultE";
            consultE.Size = new Size(196, 27);
            consultE.TabIndex = 9;
            consultE.Text = "Consulter Équipe";
            consultE.UseVisualStyleBackColor = true;
            consultE.Click += consultE_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(consultE);
            Controls.Add(AddE);
            Controls.Add(weight);
            Controls.Add(height);
            Controls.Add(bsexp);
            Controls.Add(type2);
            Controls.Add(type1);
            Controls.Add(name);
            Controls.Add(pctBPoke);
            Controls.Add(LstPoke);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pctBPoke).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox LstPoke;
        private PictureBox pctBPoke;
        private Label name;
        private Label type1;
        private Label type2;
        private Label weight;
        private Label height;
        private Label bsexp;
        private Button AddE;
        private Button consultE;
    }
}
