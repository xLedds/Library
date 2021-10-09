using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryEntities
{
    public interface IBookDAO
    {
        void AddBook(string title, string authorName, string authorSurname, string publishingHouse, int quantity);
        Book FindBook(string title, string authorName, string authorSurname, string publishingHouse);
        DataTable GetAllBook();
        void UpdateBookQuantity(int BookID, int quantity);
        void DeleteBook();
    }
}
