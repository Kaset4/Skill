using ElectronicLibrary.Models;
using AppContext = ElectronicLibrary.Core.AppContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicLibrary.Repositories
{
    public class UserRepository : IUserRepository
    {
        public void Create(User user)
        {
            using (AppContext db = new AppContext())
            {
                db.Users.Add(user);
                db.SaveChanges();
            }
        }

        public void DeleteById(int id)
        {
            using (AppContext db = new AppContext())
            {
                User user = db.Users.Find(id);
                db.Users.Remove(user);
                db.SaveChanges() ;
            }
        }

        public List<User> FindAll()
        {
            using (AppContext db = new AppContext())
            {
               return db.Users.ToList();
            }
        }

        public User FindById(int id)
        {
            using (AppContext db = new AppContext())
            {
                return db.Users.Find(id);
            }
        }

        public void UpdateByName(int id, string NewName)
        {
            using(AppContext db = new AppContext())
            {
                var user = db.Users.Find(id);
                user.Name = NewName;
                db.SaveChanges();
            }
        }

        public void CheckOutBook(User user, Book book)
        {
            using (AppContext db = new AppContext())
            {
                if (!user.Books.Contains(book) && !book.Users.Contains(user))
                {
                    user.Books.Add(book);
                    book.Users.Add(user);

                    db.Users.Update(user);
                    db.Books.Update(book);

                    db.SaveChanges();
                }
                else
                {
                    throw new Exception();
                }
            }
        }
    }
}
