using GestionAeroport;
namespace GestionAeroportTest
{
    [TestClass]
    public sealed class Test1
    {
        int immat = 205058;
        string modele = "n360";
        int capacite = 22;
        int capaciteM = 550;
        double vitesse = 750.5;


        [TestMethod]
        public void TestAvionToString_BV()
        {
           

            Avion avion = new Avion(immat, modele, capacite, capaciteM, vitesse);

            string expected = "205058 n360 22 550 750,5";
            Assert.AreEqual(expected, avion.ToString());
        }

        [TestMethod]
        public void TestReservation()
        {
            Avion avion = new Avion(immat, modele, capacite, capaciteM, vitesse);
            DateTime dateN1 = new DateTime(2000,9,12,14,30,0);
            DateTime dateN2 = new DateTime(1995, 1, 14, 12, 00, 00);
            Client C1 = new Client("Jean", "Bernard", 10005156, 20,dateN2);
            Client C2 = new Client("Béa", "Trouve", 157486, 15,dateN1);

            Aeroport A1 = new Aeroport("Charle", "France", "Paris");
            Aeroport A2 = new Aeroport("Lequin", "France", "Lille");



            DateTime dateD = new DateTime(2025, 9, 10, 14, 30, 0);
            DateTime dateA = new DateTime(2025, 9, 15, 18, 0, 0);
            Reservation R1=new Reservation(dateD, dateA,A1,A2,avion);

            Assert.IsTrue(R1.AddClient(C1));
            R1.AddClient(C2);

            int totalAttendu = 35;
            Assert.AreEqual(totalAttendu, R1.PoidsTotalbagage());

            string DuréAttendu = "5.03:30:00";
            Assert.AreEqual(DuréAttendu, R1.DureeTrajet());

            Client clientattendu = C2;
            Assert.AreNotEqual(clientattendu, R1.DoyenClient());


        }
    }
}
