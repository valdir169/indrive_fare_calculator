public class FareCalculator
{
    public static void Main(string[] args)
    {
        Console.WriteLine("===================================");
        Console.WriteLine("InDrive - Simulador de Tarifa");
        Console.WriteLine("===================================");

        string vehicle_name, name;
        double base_fare, distance, cost_km, sub_total, final_fare, discount = 0.00;
        int hour, vehicle_type; ;
        bool is_peak_hour = false;

        Console.Write("Ingrese el nombre del pasajero: ");
        name = Console.ReadLine();
        Console.Write("Ingrese la distancia del viaje en (km): ");
        distance = double.Parse(Console.ReadLine());
        Console.Write("Hora de salida (0 - 23 horas: ) ");
        hour = int.Parse(Console.ReadLine());

        Console.Write("\nTipo de vehículo): ");
        Console.Write("1. Económico");
        Console.Write("2. Confort");
        Console.Write("3. Premium");
        Console.Write("1. Moto");
        Console.WriteLine("===================================\n");
        Console.Write("Ingrese la opción del tipo de vehículo (1-4): ");
        vehicle_type = int.Parse(Console.ReadLine());
        
        switch(vehicle_type)
        {
            case 1: //Economico
                vehicle_name = "Económico";
                base_fare = 2.0;
                cost_km = 1.5;
                break;

            case 2: //Confort
                vehicle_name = "Confort";
                base_fare = 3.0;
                cost_km = 2.0;
                break;

            case 3: //Premium
                vehicle_name = "Premium";
                base_fare = 5.0;
                cost_km = 3.0;
                break;

            case 4: //Moto
                vehicle_name = "Moto";
                base_fare = 1.5;
                cost_km = 1.0;
                break;

            default:
                Console.WriteLine("Opción no válida. Por favor, ingrese un número entre 1 y 4.");
                return;
        }

        //Calculate sub total base
        sub_total = base_fare + (cost_km * distance);

        //Calculate peak hour
        if ((hour >= 7 && hour <= 9) || (hour >= 17 && hour <= 20))
        {
            is_peak_hour = true;
            sub_total *= 1.30; 
        }

        // Discount for long distance
        if (distance > 15)
        {
            discount =  sub_total * 0.05;
            sub_total -= discount; 
        }

        // fare minimum and rounded
        final_fare = Math.Max(sub_total, 5.0); 
        final_fare = Math.Round(final_fare, 2);

        Console.WriteLine("\n===================================");
        Console.WriteLine("            RESUMEN DEL VIAJE          ");
        Console.WriteLine("===================================");
        Console.WriteLine($"Pasajero: {name}");
        Console.WriteLine($"Tipo de vehículo: {vehicle_name}");
        Console.WriteLine($"Distancia: {distance} km");
        Console.WriteLine($"Hora pico: {(is_peak_hour ? "Sí (+30%)" : "No")}");

        if (discount > 0)
        {
            Console.WriteLine($"Descuento por distancia: ${discount}");
        } else
        {
            Console.WriteLine("Descuento por distancia: No aplica");
        }

        Console.WriteLine("\n===================================");
        Console.WriteLine($"Tarifa final: ${final_fare}");
    }
}
