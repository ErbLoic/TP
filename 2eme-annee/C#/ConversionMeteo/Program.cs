namespace ConversionMeteo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Releve R1 = new Releve(15, 25, 12, 3);
            Releve R2 = new Releve(20, 12, 12, 3, Etat.Pluie);
            Releve R3 = new Releve(-2.5, 12, 12, 12, Etat.Nuage);

            Zonegeographique Z1 = new Zonegeographique(15, 15, "Valenciennes", R3);
            Zonegeographique Z2 = new Zonegeographique(15, 15, "Paris", R2);
            Zonegeographique Z3 = new Zonegeographique(15, 15, "Lille", R1);

            Bulletin B1 = new Bulletin(Convert.ToDateTime("08/09/25"));

            B1.AddZone(Z1);
            B1.AddZone(Z2);
            B1.AddZone(Z3);

            Console.WriteLine(B1.Afficherrelever(Z3));
            Console.WriteLine(B1.MoyenneTemp("F") + "°F");
            Console.WriteLine(B1.MoyenneTemp("C") + "°C");

            Console.WriteLine(B1.TemperatureMax("C"));
            Console.WriteLine(B1.TemperatureMin("C"));













            //static void PrintPoint(IExempleInterface p)
            //{
            //    Console.WriteLine("x={0}, y={1}",p.X,p.Y);
            //}

            //IExempleInterface obj = new ExempleClass(2,4);

            //Console.WriteLine("Mon point:");
            //PrintPoint(obj);
            //Console.WriteLine(obj.somme);

        }
    }
}
