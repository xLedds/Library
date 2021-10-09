using LibraryData;
using LibraryEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBusinessLogic
{
    public static class BusinessLogic
    {
        public static int Login(string username, string password)
        {
            var userRepo = new Repository(new UserDAOForDB());
            var user = userRepo.FindUser(username, password);
            if (user != null)
            {
                if (user.RoleType == Role.Admin)
                    return 1;
                else if (user.RoleType == Role.User)
                    return 2;
            }
            return 3;
        }
        public static bool AddBook(string title, string authorName, string authorSurname, string publishingHouse, int quantity)
        {
            var repoBook = new Repository(new BookDAOForDB());
            var foundBook = repoBook.FindBook(title, authorName, authorSurname, publishingHouse);
            if (foundBook == null)
            {
                repoBook.AddBook(title, authorName, authorSurname, publishingHouse, quantity);
                return true;
            }
            repoBook.UpdateBookQuantity(foundBook.BookId, quantity);
            return false;
        }
    }
}
