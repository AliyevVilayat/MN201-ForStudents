namespace Core.Entities;

public class Post
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public string Title { get; set; }
    public string Body { get; set; }

    public override string ToString()
    {
        return $"Title:{Title} UserId:{UserId} Id:{Id}";
    }
}
