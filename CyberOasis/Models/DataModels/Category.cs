namespace CyberOasis.Models.DataModels;

public class Category
{
    public int Id { get; set; }
    public string Title { get; set; }

    public ICollection<Entry> Entries { get; set; }
}
