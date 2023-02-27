using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Article2._0
{
    internal class Article2
    {

        public Article2(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }



        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
