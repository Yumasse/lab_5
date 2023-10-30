using Task_1;

namespace lab_5
{
{
    static void Main(string[] args)
    {
        Human human = new Human(5);
        Car car = new Car(60);
        Bus bus = new Bus(40);
        Train train = new Train(100);

        Route route = new Route(0, 100);
        TransportNetwork network = new TransportNetwork();
        network.AddVehicle(car);
        network.AddVehicle(bus);
        network.AddVehicle(train);

        (Vehicle optimalVehicle, double travelTime) = network.CalculateOptimalRoute(route);

        if (optimalVehicle != null)
        {
            Console.WriteLine($"The optimal vehicle to travel from {route.Start} to {route.End} is a {optimalVehicle.GetType().Name} with a travel time of {travelTime} hours.");
            optimalVehicle.Move();
        }
        else
        {
            Console.WriteLine("No available vehicle for this route.");
        }
    }
}






