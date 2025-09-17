namespace GestionBDD
{
    public partial class Form1 : Form
    {
        basededonné bdd;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bdd = new basededonné("localhost", "leclerc", "3306", "root", "");
            bdd.ChargerListeClient(comboBox1);

        }

        public void btncharg_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem is not null)
            {
                string client = comboBox1.SelectedIndex.ToString();
                string[] clientsplit = client.Split("-");
                int id = Convert.ToInt32(clientsplit[0]);
                bdd.ChargerCommande(listBox1, id, label1);
            }
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem is not null)
            {
                string client = comboBox1.SelectedIndex.ToString();
                string[] clientsplit = client.Split("-");
                int idclient = Convert.ToInt32(clientsplit[0]);

                string produit = listBox1.SelectedItem.ToString();
                string[] produitsplit = produit.Split("-");
                int idProduit = Convert.ToInt32(produitsplit[0]);

                bdd.Delcommand(idclient, idProduit);

                bdd.ChargerCommande(listBox1, idclient, label1);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string client = comboBox1.SelectedIndex.ToString();
            string[] clientsplit = client.Split("-");
            int idclient = Convert.ToInt32(clientsplit[0]);

            this.Hide();

            Form2 form2 = new Form2(bdd, idclient, 0, this);
            form2.ShowDialog();


        }

        private void btnmodif_Click(object sender, EventArgs e)
        {
            string client = comboBox1.SelectedIndex.ToString();
            string[] clientsplit = client.Split("-");
            int idclient = Convert.ToInt32(clientsplit[0]);


            this.Hide();

            Form2 form2 = new Form2(bdd, idclient, 1, this);
            form2.ShowDialog();

        }
    }
}
