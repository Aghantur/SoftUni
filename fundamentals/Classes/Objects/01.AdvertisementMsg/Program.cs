var phrases = new[] { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can't live without this product." };

var events = new[] { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };

var authors = new[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

var cities = new[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };


int num = int.Parse(Console.ReadLine());
Random rand = new Random();
for (int i = 0; i < num; i++)
{
    var phrase = phrases[rand.Next(phrases.Length)];
    var @event = events[rand.Next(events.Length)];
    var author = authors[rand.Next(authors.Length)];
    var city = cities[rand.Next(cities.Length)];


    Console.WriteLine($"{phrase} {@event} {author} - {city}.");
}
