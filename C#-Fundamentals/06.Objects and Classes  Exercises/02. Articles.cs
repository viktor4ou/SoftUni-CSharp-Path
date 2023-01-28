namespace Program
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            string[] articleArr = Console.ReadLine().Split(", ").ToArray();
            Article article = new Article(articleArr[0], articleArr[1], articleArr[2]);

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(": ").ToArray();

                string cmdArgs = input[0];
                if (cmdArgs == "Edit")
                {
                    article.Edit(input[1]);
                }
                else if (cmdArgs == "ChangeAuthor")
                {
                    article.ChangeAutor(input[1]);
                }
                else if (cmdArgs == "Rename")
                {
                    article.Raname(input[1]);
                }

            }
            Console.WriteLine(article.ToString());
        }
    }
    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string  Author { get; set; }

        public Article(string title, string content, string author)
        {
           this.Title = title;
           this.Content = content;
           this.Author = author;
        }
        public void Edit(string content)    
        {
            Content = content;
        }
        public void ChangeAutor(string autor)
        {
            Author = autor;
        }
        public void Raname(string title)
        {
            Title = title;
        }

        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }
    }
}