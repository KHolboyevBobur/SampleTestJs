using System.Collections.Generic;

namespace SampleTestJs.Repository
{
    public class UserRepository
    {
        private readonly List<UserModel> _users = new List<UserModel>();

        public IEnumerable<UserModel> GetAll()
        {
            return _users;
        }

        public UserModel GetById(int id)
        {
            return _users[id];
        }

        public void Add(UserModel user)
        {
            _users.Add(user);
        }

        public void Update(int id, UserModel user)
        {
            _users[id] = user;
        }

        public void Delete(int id)
        {
            _users.RemoveAt(id);
        }
    }
}
