
class Program
{
    interface IMovable
    {
        void Move();

    }

    public class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving.");
        }
    }

    public class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }

    public static void Main(string[] args)
    {
        Car car = new Car();
        Bicycle bike = new Bicycle();

        car.Move();
        bike.Move();
    }
}
