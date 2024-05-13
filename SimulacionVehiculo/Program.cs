namespace SimulacionVehiculo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******************************");
            Console.WriteLine("Descripcion de Automoviles: ");
            Console.WriteLine("******************************");

            //Instancias de automovil
            Automovil automovil1 = new Automovil("Lamborghini", "GDW - 571", "Huracan", "Dorado", 25, 30);
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
            Automovil automovil2 = new Automovil("Ferrari", "VGF - 786", "SF90 Deportivo", "Plateado", 20, 25);

            //Acciones de conducir y llenar el tanque
            automovil1.Conducir(180);//Se necesita llenar el tanque para viajar
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
            automovil2.Conducir(150);//Se necesita llenar el tanque para viajar
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
            automovil1.ReabastecerCombustible(4);
            automovil1.Conducir(180);
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
            automovil2.ReabastecerCombustible(6);
            automovil2.Conducir(120); //Ahora si puede viajar

            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
            //Probar si el auto puede viajar una distancia especifica 
            if (automovil1.PuedeConducir(200))
            {
                Console.WriteLine($"El automovil {automovil1.Marca} {automovil1.Modelo} puede viajar 200 KM ");
            }
            else
            {
                Console.WriteLine($"El vehículo {automovil1.Marca} {automovil1.Modelo} no tiene suficiente combustible para recorrer 200 km.");

            }
        }
    }
}