using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using K2E.Entities;

namespace K2E.DataAcess
{
    public class RolDAL
    {
        private static RolDAL _instance;
        private readonly K2EDBContext _context;
        public static RolDAL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new RolDAL();
                return _instance;

            }
        }

        public RolDAL()
        {
            _context = new K2EDBContext();
        }

        public bool Create(Rol entity)
        {
            _context.Rols.Add(entity);
            return Save() > 0;
        }

        public bool Update(Rol entity)
        {
            Rol query = GetById(entity.RolId);  //db
            query.Nombre = entity.Nombre;  //Nuevos valores

            return Save() > 0;
        }

        public List<Rol> GetAll()
        {
            return _context.Rols.ToList();

        }

        public Rol GetById(int id)
        {
            return _context.Rols.FirstOrDefault(x => x.RolId.Equals(id));
        }


        public int Save()
        {
            return _context.SaveChanges();
        }
    }
}
