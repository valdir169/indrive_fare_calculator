public class FareCalculator
{
    public static void Main(string[] args)
    {
        Console.WriteLine("===================================");
        Console.WriteLine("InDrive - Simulador de Tarifa");
        Console.WriteLine("===================================");

        Console.Write("Ingrese el nombre del pasajero: ");
        string name=Console.ReadLine();
        Console.Write("Ingrese la distancia del viaje en (km): ");
        double distance = double.Parse(Console.ReadLine());
        Console.Write("Hora de salida (0 - 23 horas: ) ");
        int hour = int.Parse(Console.ReadLine());

        Console.Write("\nTipo de vehículo): ");
        Console.Write("1. Económico");
        Console.Write("2. Confort");
        Console.Write("3. Premium");
        Console.Write("1. Moto");
        Console.WriteLine("===================================\n");
        Console.Write("Ingrese la opción del tipo de vehículo (1-4): ");
        int vehicle_type = int.Parse(Console.ReadLine());
        
        
    }
}
