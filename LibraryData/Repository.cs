using LibraryEntities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryData
{
    public class Repository : IRepository
    {
        IUserDAO _userDAO;
        IBookDAO _bookDAO;
        IReservationDAO _reservationDAO;
        public Repository(IUserDAO userDAO)
        {
            _userDAO = userDAO;
        }
        public Repository(IBookDAO bookDAO)
        {
            _bookDAO = bookDAO;
        }
        public Repository(IReservationDAO reservationDAO)
        {
            _reservationDAO = reservationDAO;
        }



        //USER
        public void AddUser(string username, string password, string role)
        {
            throw new NotImplementedException();
        }
        public User FindUser(string username, string password)
        {

            return _userDAO.FindUser(username, password);
            
        }
        public void UpdateUser()
        {
            throw new NotImplementedException();
        }
        public void DeleteUser()
        {
            throw new NotImplementedException();
        }





        //BOOK
        public void AddBook(string title, string authorName, string authorSurname, string publishingHouse, int quantity)
        {
            _bookDAO.AddBook(title, authorName, authorSurname, publishingHouse, quantity);
        }
        public Book FindBook(string title, string authorName, string authorSurname, string publishingHouse)
        {
            return _bookDAO.FindBook(title, authorName, authorSurname,publishingHouse);
        }
        public DataTable GetAllBook()
        {
            throw new NotImplementedException();
        }
        public void UpdateBookQuantity(int bookID, int quantity)
        {
            _bookDAO.UpdateBookQuantity(bookID, quantity);
        }
        public void DeleteBook()
        {
            throw new NotImplementedException();
        }





        //RESERVATION
        public void AddReservation(int userId, int bookId)
        {
            throw new NotImplementedException();
        }
        public DataTable GetAllReservation()
        {
            return _reservationDAO.GetAllReservation();
        }
        public void UpdateReservation()
        {
            throw new NotImplementedException();
        }
        public void DeleteReservation()
        {
            throw new NotImplementedException();
        }
    }
}
