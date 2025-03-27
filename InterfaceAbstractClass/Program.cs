interface IAnimal
{
    public void Sounds();
}
class Pig: IAnimal
{
    public void Sounds()
    {
        Console.WriteLine("Pig sounds: Wee Weee....");
    }
}
abstract class Pet 
{
    public abstract void Eat();
}
class Dog: Pet
{
    public override void Eat()
    {
        Console.WriteLine("Dog eat meat.");
    }
}
class Cat: IAnimal
{
    public void Sounds()
    {
        Console.WriteLine("Cat sounds: meu meu...");
    }
}

interface IEngine
{
    public void StartEngine();
}

interface IRun
{
    public void Run();
}
interface IBrake
{
    public void ApplyBrakes();
}

class Car : IEngine, IBrake, IRun
{
    public void StartEngine()
    {
        Console.WriteLine("Engine started.");
    }

    public void ApplyBrakes()
    {
        Console.WriteLine("Brakes applied.");
    }

    public void Run()
    {
        Console.WriteLine("Car Running.");
    }
}


class Program
{
    static void Main(string[] args)
    {
        var pig = new Pig();
        Console.WriteLine("========PIG========");
        pig.Sounds();

        Console.WriteLine("========CAR========");
        Car car = new Car();
        car.StartEngine();
        car.Run();
        car.ApplyBrakes();

        Console.WriteLine("========DOG========");
        Dog dog = new Dog();
        dog.Eat();

        Console.WriteLine("========CAT========");
        Cat cat= new Cat();
        cat.Sounds();
    }
}