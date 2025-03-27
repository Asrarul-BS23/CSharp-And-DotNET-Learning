class Vehicle
{
    private string modelName;
    private int vehicleId;
    public string ModelName
    {
        get { return modelName; }
        set { modelName = value; }
    }
    public int VehicleId
    {
        get { return vehicleId; }
        set { vehicleId = value; }
    } 
    public void Honk()
    {
        Console.WriteLine("Peep Peeeep Ppepepeeeeeeeep.");
    }
}

class Car: Vehicle
{
    private int speed;
    public Car(int speed)
    { 
        this.speed = speed; 
    }
    public int Speed
    {
        get { return speed; }
        set { speed = value; }
    }
}

class Truck: Vehicle
{
    private int capacity;
    public int Capacity
    {
        get{ return capacity; }
        set { capacity = value; }
    }
    public void Honk()
    {
        Console.WriteLine("Tuuut tuuuuut...");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car car= new Car(65);
        car.ModelName = "Lamborgini";
        car.VehicleId = 10001;
        Console.WriteLine("========CAR========");
        Console.WriteLine($"Vehicle ID: {car.VehicleId} \nModel Name: {car.ModelName} \nSpeed: {car.Speed}");
        car.Honk();

        Truck truck = new Truck();   
        truck.Capacity = 5000;
        truck.VehicleId = 10002;
        truck.ModelName = "Heunday";
        Console.WriteLine("========TRUCK========");
        Console.WriteLine($"Vehicle ID: {truck.VehicleId} \nModel Name: {truck.ModelName} \nCapacity: {truck.Capacity}");
        truck.Honk();
    }
}