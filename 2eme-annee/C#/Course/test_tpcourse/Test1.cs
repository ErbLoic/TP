using TP_clientpanier;

namespace test_tpcourse
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]

        public void testAddpanier()
        {
            
            Basededonne bdd = new Basededonne("localhost", "pcshop", "root", "");
            bdd.Ouvrir();

            int idP = 1;
            int idC = 1;
            int q = 1;

            Assert.AreEqual("Déjà l'article", bdd.Add_Panier(idP, idC, q));

            
        }
        [TestMethod]
        public void TestChargerClient()
        {
            Basededonne bdd = new Basededonne("localhost", "pcshop", "root", "");
            bdd.Ouvrir();

            Assert.AreEqual(10, bdd.ChargerClient().Count());
        }

        [TestMethod]
        public void TestChargerPanier()
        {
            Basededonne bdd = new Basededonne("localhost", "pcshop", "root", "");
            bdd.Ouvrir();

            Assert.AreEqual(7, bdd.ChargerPanierClient(1).Count());
        }

        [TestMethod]
        public void TestChargerProduit()
        {
            Basededonne bdd = new Basededonne("localhost", "pcshop", "root", "");
            bdd.Ouvrir();

            Assert.AreEqual(20, bdd.ChargerProduit().Count());
        }

    }
}
