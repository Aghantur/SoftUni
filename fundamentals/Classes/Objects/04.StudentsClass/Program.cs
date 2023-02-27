

using _04.StudentsClass;

int n = int.Parse(Console.ReadLine());
List<Student> students = new List<Student>();
for (int i = 0; i < n; i++)
{
    string[] currStudentToken = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

    string firstName = currStudentToken[0];
    string lastName = currStudentToken[1];
    double grade = double.Parse(currStudentToken[2]);

    Student student = new Student(firstName, lastName, grade);

    students.Add(student);


}

foreach (var student in students.OrderByDescending(x => x.grade))
{

    Console.WriteLine(student);
}



