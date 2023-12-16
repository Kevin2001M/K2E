using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using K2E.Entities;

namespace K2E.DataAcess
{
    public class UserDAL
    {
        private static UserDAL _instance;
        private readonly K2EDBContext _context;
        public static UserDAL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserDAL();
                return _instance;

            }
        }

        public UserDAL()
        {
            _context = new K2EDBContext();
        }

        public bool Create(User entity)
        {
            _context.Users.Add(entity);
            return Save() > 0;
        }

        public bool Update(User entity)
        {
            User query = GetById(entity.Email);  //db
            query.Clave = entity.Clave;
            query.RolId = entity.RolId;  //Nuevos valores
            return Save() > 0;
        }

        public List<User> GetAll()
        {
            return _context.Users.Include("Rol").ToList();

        }

        public User GetById(string email)
        {
            return _context.Users.FirstOrDefault(x => x.Email.Equals(email));
        }


        public int Save()
        {
            return _context.SaveChanges();
        }
    }
}
