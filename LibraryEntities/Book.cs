using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryEntities
{
   public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string AuthorName { get; set; }
        public string AuthorSurname { get; set; }
        public string PublishingHouse { get; set; }
        public int Quantity { get; set; }
        public void Load (SqlDataReader reader)
        {
            BookId = int.Parse(reader["BookID"].ToString());
            Title = reader["Title"].ToString();
            AuthorName = reader["AuthorName"].ToString();
            AuthorSurname = reader["AuthorSurname"].ToString();
            PublishingHouse = reader["PublishingHouse"].ToString();
            Quantity = int.Parse(reader["Quantity"].ToString());
        }
    }
}
