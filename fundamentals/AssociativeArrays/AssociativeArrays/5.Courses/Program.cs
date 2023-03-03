Dictionary<string, List<string>> courses =
    new Dictionary<string, List<string>>();

while (true)
{
    string input = Console.ReadLine();

    if (input == "end")
    {
        break;
    }

    string[] cmdArg = input.Split(" : ", StringSplitOptions.RemoveEmptyEntries);

    string courseName = cmdArg[0];
    string studentName = cmdArg[1];

    if (!courses.ContainsKey(courseName))
    {
        courses[courseName] = new List<string>();
    }
    if (!courses[courseName].Contains(studentName))
    {
        courses[courseName].Add(studentName);
    }

}


foreach (var course in courses)
{
    Console.WriteLine($"{course.Key}: {course.Value.Count}");
    foreach (var student in course.Value)
    {
        Console.WriteLine($"-- {student}");
    }
}