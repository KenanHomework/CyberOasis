using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CyberOasis.Models.DataModels;

public class Vote
{
    public int Id { get; set; }


    public int EntryId { get; set; }
    public Entry Entry { get; set; }


    public User User { get; set; }
    public int UserId { get; set; }


    public bool IsUpVote { get; set; }

}
