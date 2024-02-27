using System;

// Base Class 
class Animal
{
    private string name; // only accessible within this class
    protected string type; //accessible from derived classes
    public string color;  // accessible from any class

    public void setName(string name)
    {
        this.name = name;
    }

    public virtual string getName()
    {
        return this.name;
    }

    public void setType(string type)
    {
        this.type = type;
    }

    public virtual string getType()
    {
        return this.type;
    }
}

// Derived Class
class Dog : Animal
{
    // Fields
    private int age;
    public string breed;
    protected bool isTrained;

    // Methods to access fields
    public void setAge(int age)
    {
        this.age = age;
    }

    public int getAge()
    {
        return this.age;
    }

    public void setIsTrained(bool isTrained)
    {
        this.isTrained = isTrained;
    }

    public bool getIsTrained()
    {
        return this.isTrained;
    }

    // Overriding base class methods
    public override string getName()
    {
        return "Dog: " + base.getName();
    }

    public override string getType()
    {
        return "Mammal: " + base.getType();
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Object from the base class (Animal)
        Animal myAnimal = new Animal();
        myAnimal.setName("Rex");
        myAnimal.setType("Canine");
        myAnimal.color = "Brown";

        Console.WriteLine("Animal Information:");
        Console.WriteLine($"Name: {myAnimal.getName()}");
        Console.WriteLine($"Type: {myAnimal.getType()}");
        Console.WriteLine($"Color: {myAnimal.color}");
        Console.WriteLine();

        // Object from the derived class (Dog)
        Dog myDog = new Dog();
        myDog.setName("Buddy");
        myDog.setType("Labrador");
        myDog.color = "Golden";
        myDog.breed = "Labrador Retriever";
        myDog.setAge(3);
        myDog.setIsTrained(true);

        Console.WriteLine("Dog Information:");
        Console.WriteLine($"Name: {myDog.getName()}");
        Console.WriteLine($"Type: {myDog.getType()}");
        Console.WriteLine($"Color: {myDog.color}");
        Console.WriteLine($"Breed: {myDog.breed}");
        Console.WriteLine($"Age: {myDog.getAge()} years");
        Console.WriteLine($"Is Trained: {(myDog.getIsTrained() ? "Yes" : "No")}");
    }
}
