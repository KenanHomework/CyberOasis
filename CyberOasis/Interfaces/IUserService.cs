using CyberOasis.Models.DataModels;

namespace CyberOasis.Interfaces;

public interface IUserService
{
    /* Get User */
    User? GetUserById(int id);


    /* Update User */
    User UpdateUser(int id, User newUser);


    /* Delete User */
    bool DeleteUser(int id);


    /* Follow Control */
    bool ChangeFollowStatusById(int targetUserId, bool follow);


    /* Vote Control */
    bool ApplyVote(int entryId, bool isUpVote);


    /* Favorite Control */
    bool SetToFavorite(int entryId);
    bool RemoveFromFavorite(int entryId);


    /* Entry Control */
    Entry GetEntryById(int id);
    IEnumerable<Entry> GetEntries();
    void AddEntry(Entry entry);
    void UpdateEntry(int id, Entry entry);
    void DeleteEntry(int id);

}
