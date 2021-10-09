using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryEntities
{
    public interface IReservationDAO
    {
        void AddReservation(int userId, int bookId);
        DataTable GetAllReservation();
        void UpdateReservation();
        void DeleteReservation();

    }
}
