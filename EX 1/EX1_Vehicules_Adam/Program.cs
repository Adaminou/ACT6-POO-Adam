namespace EX1_Vehicules_Adam
{
     class Program
    {
        static void Main(string[] args)
        {
            Vehicule monVehicule = new Vehicule("Dodge","Charger","Noir", 30000);
            Console.WriteLine(monVehicule.Affiche());
            Velo monVelo = new Velo("VTT",false,"Jsp","Decathlon","Noir",450);
            Console.WriteLine(monVelo.Affiche());
            Voiture MaVoiture = new Voiture("disel",true,"Dodge","Charger","Noir",30000);
            Console.WriteLine(MaVoiture.Affiche());
        }
    }
}