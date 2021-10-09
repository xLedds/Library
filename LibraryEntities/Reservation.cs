using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryEntities
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public void Load(SqlDataReader reader)
        {
            ReservationId = int.Parse(reader["ReservationID"].ToString());
            UserId = int.Parse(reader["UserID"].ToString());
            BookId = int.Parse(reader["BookID"].ToString());
            StartDate = DateTime.Parse(reader["StartDate"].ToString());
            EndDate= DateTime.Parse(reader["EndDate"].ToString());
        }
    }
}
