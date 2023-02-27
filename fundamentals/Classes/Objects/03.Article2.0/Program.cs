
using _03.Article2._0;

List<Article2> articles = new List<Article2>();
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{

    string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();


    string title = input[0];
    string content = input[1];
    string author = input[2];

    Article2 article = new Article2(title, content, author);
    articles.Add(article);

}
foreach (var article in articles)
{
    Console.WriteLine(article);
}

