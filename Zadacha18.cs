using System;

namespace Zadacha18
{
    abstract class Transport
    {
        public abstract int Speed { get; set; }
        public abstract double Weight { get; set; }
        public abstract double Distance { get; set; }

        public abstract void Print_Speed();
        public abstract void Print_Weight();
        public abstract void Print_Distance();

    }

    class Car : Transport
    {
        public override int Speed { get; set; }
        public override double Weight { get; set; }
        public override double Distance { get; set; }
        public Car(int speed, double weight, double length)
        {
            Speed = speed;
            Weight = weight;
            Distance = length;
        }

        public override void Print_Speed()
        {
            Console.WriteLine($"Скорость авто: {Speed}.");
        }
        public override void Print_Weight()
        {
            Console.WriteLine($"Грузоподъемность авто: {Weight}.");
        }
        public override void Print_Distance()
        {
            Console.WriteLine($"Дальность проезжаемая авто расстояния: {Distance}");
        }
    }

    class Airplane : Transport
    {
        public override int Speed { get; set; }
        public override double Weight { get; set; }
        public override double Distance { get; set; }

        public Airplane(int speed, double weight, double length)
        {
            Speed = speed;
            Weight = weight;
            Distance = length;
        }

        public override void Print_Speed()
        {
            Console.WriteLine($"Скорость самолёта: {Speed}.");
        }
        public override void Print_Weight()
        {
            Console.WriteLine($"Грузоподъемность самолёта: {Weight}.");
        }
        public override void Print_Distance()
        {
            Console.WriteLine($"Дальность пролетаемая самолётом расстояния: {Distance}");
        }
    }

    class Ship : Transport
    {
        public override int Speed { get; set; }
        public override double Weight { get; set; }
        public override double Distance { get; set; }

        public Ship(int speed, double weight, double length)
        {
            Speed = speed;
            Weight = weight;
            Distance = length;
        }

        public override void Print_Speed()
        {
            Console.WriteLine($"Скорость корабля: {Speed}.");
        }
        public override void Print_Weight()
        {
            Console.WriteLine($"Грузоподъемность корабля: {Weight}.");
        }
        public override void Print_Distance()
        {
            Console.WriteLine($"Дальность проплываемая кораблём расстояния: {Distance}");
        }
    }

    public class Program
    {
        public static void Main()
        {
            Car car = new Car(50, 200, 5000);
            Airplane airplane = new Airplane(100, 2000, 100000);
            Ship ship = new Ship(350, 10000, 10000);
        }
    }
}
