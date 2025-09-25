namespace heritage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BorneElectrique Amiens=new BorneElectrique("Amiens",75,125);
            BorneElectrique Lille = new BorneElectrique("Lille",25,105);
            BorneElectrique Marly = new BorneElectrique("Marly", 15, 175);
            List<BorneElectrique> listeB=new List<BorneElectrique>();
            listeB.Add(Amiens);
            listeB.Add(Lille);
            listeB.Add(Marly);
            Trottinette voiture = new Trottinette(listeB,4,100,100,"Essence","Astral","Toyota",0,100,35);
            Console.WriteLine(voiture.ToString());
            voiture.demarrer();
            voiture.parcourir(100);
            double temps =voiture.RechargerTrot(35);
            Console.WriteLine("Vous en aurez pour" + temps);
        }
    }
}
