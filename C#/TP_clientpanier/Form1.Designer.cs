namespace TP_clientpanier
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
            cbClients = new ComboBox();
            lvPanier = new ListView();
            Produit = new ColumnHeader();
            Prix = new ColumnHeader();
            Quantite = new ColumnHeader();
            Total = new ColumnHeader();
            chargerpanierclient = new Button();
            prixto = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // cbClients
            // 
            cbClients.FormattingEnabled = true;
            cbClients.Location = new Point(12, 12);
            cbClients.Name = "cbClients";
            cbClients.Size = new Size(500, 23);
            cbClients.TabIndex = 0;
            // 
            // lvPanier
            // 
            lvPanier.Columns.AddRange(new ColumnHeader[] { Produit, Prix, Quantite, Total });
            lvPanier.Location = new Point(15, 71);
            lvPanier.Name = "lvPanier";
            lvPanier.Size = new Size(492, 348);
            lvPanier.TabIndex = 1;
            lvPanier.UseCompatibleStateImageBehavior = false;
            // 
            // chargerpanierclient
            // 
            chargerpanierclient.Location = new Point(531, 72);
            chargerpanierclient.Name = "chargerpanierclient";
            chargerpanierclient.Size = new Size(99, 342);
            chargerpanierclient.TabIndex = 2;
            chargerpanierclient.Text = "Charger";
            chargerpanierclient.UseVisualStyleBackColor = true;
            chargerpanierclient.Click += chargerpanierclient_Click;
            // 
            // prixto
            // 
            prixto.AutoSize = true;
            prixto.Location = new Point(414, 426);
            prixto.Name = "prixto";
            prixto.Size = new Size(0, 15);
            prixto.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(531, 3);
            button1.Name = "button1";
            button1.Size = new Size(93, 46);
            button1.TabIndex = 4;
            button1.Text = "Ajouter Produit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(645, 450);
            Controls.Add(button1);
            Controls.Add(prixto);
            Controls.Add(chargerpanierclient);
            Controls.Add(lvPanier);
            Controls.Add(cbClients);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbClients;
        private ListView lvPanier;
        private ColumnHeader Produit;
        private ColumnHeader Prix;
        private ColumnHeader Quantite;
        private ColumnHeader Total;
        private Button chargerpanierclient;
        private Label prixto;
        private Button button1;
    }
}
