string info = Console.ReadLine();
List<Student> students = new List<Student>();

while (info != "end")
{
    string[] infoArr = info.Split();

    string firstName = infoArr[0];
    string lastName = infoArr[1];
    int age = int.Parse(infoArr[2]);
    string town = infoArr[3];

    bool studentExist = false;



    foreach (var item in students)
    {
        if (item.FirstName == firstName
            && item.LastName == lastName)
        {
            item.Age = age;
            item.HomeTown = town;
            studentExist = true;
            break;
        }
    }

   // Student currStudent = students.FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName);

    if (!studentExist)
    {

        Student student = new Student
        {
            FirstName = firstName,
            LastName = lastName,
            Age = age,
            HomeTown = town
        };
        students.Add(student);
    }
    info = Console.ReadLine();
}
string homeTown = Console.ReadLine();
foreach (Student item in students)
{
    if (item.HomeTown == homeTown)
    {
        Console.WriteLine($"{item.FirstName} {item.LastName} is {item.Age} years old.");
    }
}


class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string HomeTown { get; set; }

}