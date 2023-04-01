using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CyberOasis.Models.DataModels;

public class Entry
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime Date { get; set; }
    public string EntryBody { get; set; }



    /* Navigation Properties */

    public User User { get; set; }
    public Category Category { get; set; }
    public ICollection<Favorite> FavoriteUsers { get; set; }
    public ICollection<Vote> VoteUsers { get; set; }
}
