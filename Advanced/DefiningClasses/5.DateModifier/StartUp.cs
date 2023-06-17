using _5.DateModifier;

string start = Console.ReadLine();
string end = Console.ReadLine();


int difference = DateModifier.GetDiff(start, end);
    Console.WriteLine(difference);