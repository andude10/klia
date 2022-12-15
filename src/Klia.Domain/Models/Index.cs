namespace Klia.Domain.Models;

public class Index
{
    public string Word { get; set; }
    public List<Page> Pages { get; set; } = new List<Page>();
}