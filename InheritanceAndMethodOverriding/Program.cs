
public class Program
{
    // Base class
    public class Animal 
    {
        public virtual string MakeSound()
        {
            return "Some generic sound";
        }
    }

    public class Dog : Animal   // Inheritance
    {
        public override string MakeSound()  //  Overrides MakeSound property of the base class
        {
            return "Bark";
        }
    }

    public class Cat : Animal   // Inheritance
    {
        public override string MakeSound()  //Overrides MakeSound property of the base class
        {
            return "Meow";
        }
    }

    public static void Main(string[] args)
    {
        // Instances of the Dog and Cat class
        Dog dog = new Dog();
        Cat cat = new Cat();

        Console.WriteLine($"Dogs {dog.MakeSound()} while Cats {cat.MakeSound()}!");
    }
}
