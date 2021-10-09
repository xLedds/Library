using LibraryEntities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryData
{
    public class UserDAOForDB : IUserDAO
    {
        public void AddUser(string username, string password, string role)
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public User FindUser(string username, string password)
        {
            User utente = null;
            using (SqlCommand cmd = DB.GetSqlConnection().CreateCommand())
            {
                cmd.CommandText = @"SP_GetUserByUsernameAndPassword";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("username", SqlDbType.NVarChar, 100).Value = username;
                cmd.Parameters.Add("password", SqlDbType.NVarChar, 100).Value = password;
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                if (reader.Read())
                {
                    utente = new User();
                    utente.Load(reader);
                }
            }
            return utente;
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
