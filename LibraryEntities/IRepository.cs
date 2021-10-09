using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryEntities
{
    public interface IRepository
    {
        //USER
        void AddUser(string username, string password, string role);
        User FindUser(string username, string password);
        void UpdateUser();
        void DeleteUser();



        //BOOK
        void AddBook(string title, string authorName, string authorSurname, string publishingHouse, int quantity);
        Book FindBook(string title, string authorName, string authorSurname, string publishingHouse);
        DataTable GetAllBook();
        void UpdateBookQuantity(int BookID, int quantity);
        void DeleteBook();



        //RESERVATION
        void AddReservation(int userId, int bookId);
        DataTable GetAllReservation();
        void UpdateReservation();
        void DeleteReservation();

    }
}
