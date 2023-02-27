
string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
string title = input[0];
string content = input[1];
string author = input[2];
Article article = new Article(title,content,author);

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{

    string[] arr = Console.ReadLine().Split(": ", StringSplitOptions.RemoveEmptyEntries).ToArray();

    string element = arr[0];
    string element2 = arr[1];

    if (element == "Edit")
    {
        article.Edit(element2);
    }
    else if (element == "Rename")
    {
        article.Rename(element2);
    }
    else if (element == "ChangeAuthor")
    {
        article.ChangeAuthor(element2);
    }

}

Console.WriteLine(article);

class Article
{

    public Article(string title, string content, string author)
    {
        this.Title = title;
        this.Content = content;
        this.Author = author;
    }
    public string Title { get; set; }
    public string Content { get; set; }
    public string Author { get; set; }

   
    
    public void Edit(string Content)
    {
        this.Content = Content;
    }

    public void ChangeAuthor(string author)
    {
        this.Author = author;
    }

    public void Rename(string title)
    {
        this.Title = title;
    }

    public override string ToString()
    {
        return $"{Title} - {Content}: {Author}";
    }
}