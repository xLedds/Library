using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryEntities
{
    public class User
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Role RoleType { get; set; }

        public void Load(SqlDataReader reader)
        {
            UserID = int.Parse(reader["UserID"].ToString());
            Username = reader["Username"].ToString();
            Password = reader["Password"].ToString();
            if (reader["Role"].ToString()== "Admin")
            {
                RoleType = Role.Admin;
                return;
            }
            if (reader["Role"].ToString() == "User")
                RoleType = Role.User;
        }
    }
    public enum Role { Admin, User }
    
}
