using System;

List<Person> people = new List<Person>();

while (true)
{
    string array = Console.ReadLine();
    if (array == "End")
    {
        break;
    }
    string[] info = array.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
    string name = info[0];
    string id = info[1];
    int age = int.Parse(info[2]);


    Person person = new Person(name, id, age);

    people.Add(person);
}
var result = people.OrderBy(x => x.age);
foreach (var person in result)
{
    Console.WriteLine(person);
}


class Person
{
    public Person(string name, string id, int age)
    {
        this.Name = name;
        this.id = id;
        this.age = age;
    }

    public string Name { get; set; }
    public string id { get; set; }
    public int age { get; set; }

    public override string ToString()
    {
        return $"{Name} with ID: {id} is {age} years old.";
    }
}