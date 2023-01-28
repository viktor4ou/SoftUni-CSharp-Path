namespace Program
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            List<Article> articles = new List<Article>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split(", ").ToArray();
                string title = cmdArgs[0];
                string content = cmdArgs[1];
                string author = cmdArgs[2];
                Article article = new Article(title, content, author);
                articles.Add(article);
            }
            string cmd = Console.ReadLine();

            foreach (Article article1 in articles)
            {
                Console.WriteLine(article1);
            }
        }
    }
    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }


        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }
    }
}