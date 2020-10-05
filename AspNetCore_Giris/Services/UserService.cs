using AspNetCore_Giris.Types;
using System.Collections.Generic;
using System.Linq;

namespace AspNetCore_Giris.Services
{
    public class UserService
    {
        List<RegisteredUser> _users;
        public UserService()
        {
            _users = new List<RegisteredUser>();
        }

        public void AddUser(RegisteredUser user)
        {
            _users.Add(user);
        }

        public void Delete(RegisteredUser user)
        {
            _users.Remove(user);
        }

        public List<RegisteredUser> GetUsers()
        {
            return _users.OrderBy(x => x.FirstName).ToList();
        }
    }
}
