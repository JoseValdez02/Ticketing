using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Ticketing.Models
{
    internal interface IUserRepository
    {
        bool AuthenticateEmail (NetworkCredential credential);
        void Add(User user);
        void Edit(User user);
        void Remove(int id);
        User GetById(int id);
        User GetByEmail (string email);
        IEnumerable<User> GetAll();


    }
}
