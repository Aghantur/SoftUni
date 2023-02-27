
Dog dog1 = new Dog();
dog1.Name = "Sharo";
dog1.age = 2;
dog1.Breed = "Street";


Console.WriteLine(dog1.Name);
dog1.Bark();
class Dog
{
    public string Name { get; set; }
    public int age { get; set; }
    public string Breed { get; set; }

    public void Bark()
    {
        Console.WriteLine("Bark!");
    }  

}
