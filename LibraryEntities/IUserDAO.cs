using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryEntities
{
    public interface IUserDAO
    {
        void AddUser(string username, string password, string role);
        User FindUser(string username, string password);
        void Update();
        void Delete();

    }
}
