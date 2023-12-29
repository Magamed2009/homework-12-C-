var dog = new Dog();

System.Console.WriteLine(dog.GetName());
System.Console.WriteLine(dog.Eat());

public abstract class Animal
{
    public string name = Console.ReadLine();
    public void SetName(string name)
    {

    }
    public string GetName()
    {
        return $"{name}";
    }
    public virtual string Eat()
    {
        return $"The animel is eating";
    }
}

class Dog : Animal
{
    public override string Eat()
    {
        return "The dog is eating";
    }
}