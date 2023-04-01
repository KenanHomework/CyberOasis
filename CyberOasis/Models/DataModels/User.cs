namespace CyberOasis.Models.DataModels;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Password { get; set; }
    public int PageCount { get; set; }



    /* Navigation Properties */
    public ICollection<Entry> Entries { get; set; }
    public ICollection<Favorite> FavoriteEntries { get; set; }
    public ICollection<Vote> VoteEntries { get; set; }
    public ICollection<Follow> Followers { get; set; }
    public ICollection<Follow> FollowedUsers { get; set; }
}
