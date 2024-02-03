using ElectronicLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicLibrary.Repositories
{
    public interface IBookRepository
    {
        Book FindById(int id);
        List<Book> FindAll();
        void Create(Book book);
        void DeleteById(int id);
        void UpdateByYear(int id, int NewYear);
    }
}
