using System;
using System.Collections.Generic;

List<string> course = Console.ReadLine().Split(", ").ToList();

while (true)
{

    string input = Console.ReadLine();
    if (input == "course start")
    {
        break;
    }
    string[] command = input.Split(":");


    string title1 = command[1];
    if (command[0] == "Add")
    {
        if (!course.Contains(title1))
        {
            course.Add(title1);
        }

    }

    else if (command[0] == "Insert")
    {
        int index = int.Parse(command[2]);

        if (index < 0 || index >= course.Count)
        {
            break;
        }
        else if (!course.Contains(title1))
        {
            course.Insert(index, title1);
        }

    }
    else if (command[0] == "Remove")
    {
        if (course.Contains(title1))
        {
            course.Remove(title1);
        }
        else if (course.Contains(title1 + "-Exercise"))
        {
            course.Remove(title1 + "-Exercise");
        }
    }
    else if (command[0] == "Exercise")
    {

        if (course.Contains(title1) && !course.Contains(title1 + "-Exercise"))
        {
            int index1 = course.IndexOf(title1);
            course.Insert(index1 + 1, title1 + "-Exercise");
        }
        else if (!course.Contains(title1))
        {
            course.Add(title1);
            course.Add(title1 + "-Exercise");
        }
    }
    else if (command[0] == "Swap")
    {
        string title2 = command[2];
        int index1 = course.IndexOf(title1);
        int index2 = course.IndexOf(title2);

        if (course.Contains(title1) && course.Contains(title2))
        {
            string tempLesson = course.ElementAt(index1);
            course[index1] = course[index2];
            course[index2] = tempLesson;
        }
        if (course.Contains(title1 + "-Exercise") && course.Contains(course[index1]))
        {
            index1 = course.IndexOf(title1);
            course.Remove(title1 + "-Exercise");
            course.Insert(index1, title1 + "-Exercise");
        }
        else if (course.Contains(title2 + "-Exercise") && course.Contains(course[index2]))
        {
            index2 = course.IndexOf(title2);
            course.Remove(title2 + "-Exercise");
            course.Insert(index2 + 1, title2 + "-Exercise");
        }
    }
}

for (int i = 0; i < course.Count; i++)
{
    Console.WriteLine($"{i + 1}.{course[i]}");
}