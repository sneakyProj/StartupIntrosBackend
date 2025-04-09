using System.Runtime.InteropServices.JavaScript;
using System.Text;

namespace StartupIntrosBackend;

public class Post
{
    public int Id { get; set; } // primary key
    public string Title { get; set; }
    public string Content { get; set; }
    public DateTime Date { get; set; }
    public int AuthorId { get; set; }
    public NewsSource Author { get; set; }

    // Parameterless constructor for EF Core
    public Post()
    {
    }

    // Parameterized constructor for convenience
    public Post(string title, string content, DateTime date, NewsSource author)
    {
        Title = title;
        Content = content;
        Date = date;
        Author = author;
        AuthorId = author.Id;
    }

    public string Serialize()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append($"title: {Title}\n");
        sb.Append($"content: {Content}\n");
        sb.Append($"date: {Date}\n");
        sb.Append($"author: {Author}\n");
        return sb.ToString();
    }
}