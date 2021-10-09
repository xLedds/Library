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
    public class BookDAOForDB : IBookDAO
    {
        public void AddBook(string title, string authorName, string authorSurname, string publishingHouse, int quantity)
        {
            using (SqlCommand cmd = DB.GetSqlConnection().CreateCommand())
            {
                cmd.CommandText = @"SP_AddBook";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("title", SqlDbType.NVarChar, 100).Value = title;
                cmd.Parameters.Add("authorName", SqlDbType.NVarChar, 100).Value = authorName;
                cmd.Parameters.Add("authorSurname", SqlDbType.NVarChar, 100).Value = authorSurname;
                cmd.Parameters.Add("publishingHouse", SqlDbType.NVarChar, 100).Value = publishingHouse;
                cmd.Parameters.Add("quantity", SqlDbType.NVarChar, 100).Value = quantity;
                cmd.ExecuteNonQuery();
            }
            
        }

        public void DeleteBook()
        {
            throw new NotImplementedException();
        }

        public Book FindBook(string title, string authorName, string authorSurname, string publishingHouse)
        {
            Book book = null;
            using (SqlCommand cmd = DB.GetSqlConnection().CreateCommand())
            {
                cmd.CommandText = @"SP_FindBook";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("title", SqlDbType.NVarChar, 100).Value = title;
                cmd.Parameters.Add("authorName", SqlDbType.NVarChar, 100).Value = authorName;
                cmd.Parameters.Add("authorSurname", SqlDbType.NVarChar, 100).Value = authorSurname;
                cmd.Parameters.Add("publishingHouse", SqlDbType.NVarChar, 100).Value = publishingHouse;
                SqlDataReader readerBook = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                if (readerBook.Read())
                {
                    book = new Book();
                    book.Load(readerBook);
                }
                return book;
            }
        }

        public DataTable GetAllBook()
        {
            throw new NotImplementedException();
        }
        public void UpdateBookQuantity(int bookID, int quantity)
        {
            using (SqlCommand cmd = DB.GetSqlConnection().CreateCommand())
            {
                cmd.CommandText = @"SP_UpdateBookQuantity";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("bookID", SqlDbType.Int).Value = bookID;
                cmd.Parameters.Add("quantity", SqlDbType.Int).Value = quantity;
                cmd.ExecuteNonQuery();
            }
        }
    }
}
