using System.Threading.Channels;
using Lab_4;

namespace Lab_4;
abstract class Transport
{
    public abstract int Wheels { get; }
    public abstract int Speed { get; }
    public abstract bool DoorsAvailable { get; }
    // public abstract void GetWheelsAmount();
    // public abstract void CheckDoors();
}

class Motorcycle : Transport
{
    private Random rand = new Random();
    public override int Wheels => 2;
    public override bool DoorsAvailable => false;
    public override int Speed { get; }
    public Motorcycle()
    {
        Speed = rand.Next(100, 300);
    }

    public override string ToString()
    {
        return $"Speed: {Speed}\nWheels: {Wheels}\nDoors available: {DoorsAvailable}";
    }
}

class Scooter : Transport
{
    private Random rand = new Random();
    public override int Wheels => 2;
    public override bool DoorsAvailable => false;
    public override int Speed { get; }
    public Scooter()
    {
        Speed = rand.Next(80, 120);
    }

    public override string ToString()
    {
        return $"Speed: {Speed}\nWheels: {Wheels}\nDoors available: {DoorsAvailable}";
    }
}

class Car : Transport
{
    private Random rand = new Random();
    public override int Wheels => 4;
    public override bool DoorsAvailable => true;
    public override int Speed { get; }
    public Car()
    {
        Speed = rand.Next(60, 240);
    }

    public override string ToString()
    {
        return $"Speed: {Speed}\nWheels: {Wheels}\nDoors available: {DoorsAvailable}";
    }
}

class Train : Transport
{
    private Random rand = new Random();
    public override int Wheels => 64;
    public override bool DoorsAvailable => true;
    public override int Speed { get; }
    public Train()
    {
        Speed = rand.Next(100, 400);
    }

    public override string ToString()
    {
        return $"Speed: {Speed}\nWheels: {Wheels}\nDoors available: {DoorsAvailable}";
    }
}