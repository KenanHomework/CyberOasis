using CyberOasis.Interfaces;
using CyberOasis.Models.DataModels;

namespace CyberOasis.Services
{
    public class UserService 
    {
        public void AddEntry(Entry entry)
        {
            throw new NotImplementedException();
        }

        public bool ApplyVote(int entryId, bool isUpVote)
        {
            throw new NotImplementedException();
        }

        public bool ChangeFollowStatusById(int targetUserId)
        {
            throw new NotImplementedException();
        }

        public void DeleteEntry(int id)
        {
            throw new NotImplementedException();
        }

        public bool DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Entry> GetEntries()
        {
            throw new NotImplementedException();
        }

        public Entry GetEntryById(int id)
        {
            throw new NotImplementedException();
        }

        public User? GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        public User? GetUserByUsername(string username)
        {
            throw new NotImplementedException();
        }

        public bool SetFavorite(int entryId)
        {
            throw new NotImplementedException();
        }

        public void UpdateEntry(int id, Entry entry)
        {
            throw new NotImplementedException();
        }

        public User UpdateUser(int id, User newUser)
        {
            throw new NotImplementedException();
        }
    }
}
