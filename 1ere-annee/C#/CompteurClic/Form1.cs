namespace CompteurClic
{
    public partial class Form1 : Form
    {
        int nbr = 0;
        Button btn2;
        Button btn3;
        Button btn4;
        int compteur = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            nbr++;
            compteur++;
            textBox1.Text = nbr.ToString();
            textBox2.Text = compteur.ToString();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            nbr += 5;
            textBox1.Text = nbr.ToString();
            compteur++;
            textBox2.Text = compteur.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nbr = 0;
            textBox1.Text = nbr.ToString();
            this.Controls.Remove(btn2);
            this.Controls.Remove(btn3);
            this.Controls.Remove(btn4);
            btn2 = null;
            btn3 = null;
            btn4 = null;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            nbr += 10;
            textBox1.Text = nbr.ToString();
            compteur++;
            textBox2.Text = compteur.ToString();
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            nbr += 100;
            textBox1.Text = nbr.ToString();
            compteur++;
            textBox2.Text = compteur.ToString();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            nbr += 1000;
            textBox1.Text = nbr.ToString();
            compteur++;
            textBox2.Text = compteur.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (nbr > 100 && btn2 == null)
            {
                btn2 = new Button
                {
                    Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0),
                    Location = new Point(35, 251),
                    Name = "btn2",
                    Size = new Size(141, 51),
                    TabIndex = 3,
                    Text = "+10",
                };

                btn2.Click += btn2_Click;
                this.Controls.Add(btn2);
            }
            else if (nbr > 1000 && btn3 == null)
            {
                btn3 = new Button
                {
                    Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0),
                    Location = new Point(35, 351),
                    Name = "btn3",
                    Size = new Size(141, 51),
                    TabIndex = 3,
                    Text = "+100",
                };

                btn3.Click += btn3_Click;
                this.Controls.Add(btn3);
            }
            else if (nbr > 10000 && btn4 == null)
            {
                btn4 = new Button
                {
                    Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0),
                    Location = new Point(35, 451),
                    Name = "btn4",
                    Size = new Size(141, 51),
                    TabIndex = 3,
                    Text = "+1000",
                };

                btn4.Click += btn4_Click;
                this.Controls.Add(btn4);
            }
        }

    }
}
