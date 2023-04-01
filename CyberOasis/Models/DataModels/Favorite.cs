namespace CyberOasis.Models.DataModels;

public class Favorite
{
    public int Id { get; set; }

    public int UserId { get; set; }
    public User User { get; set; }


    public int EntryId { get; set; }
    public Entry Entry { get; set; }
}
