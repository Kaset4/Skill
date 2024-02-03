using ElectronicLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicLibrary.Repositories
{
    public interface IUserRepository
    {
        User FindById(int id);
        List<User> FindAll();
        void Create(User user);
        void DeleteById(int id);
        void UpdateByName(int id, string NewName);
    }
}
