using System.Collections.Generic;
using System.Linq;
using K2E.Entities;

namespace K2E.DataAcess
{
    public class TitleDAL
    {
        private static TitleDAL _instance;
        private readonly K2EDBContext _context;
        public static TitleDAL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TitleDAL();
                return _instance;

            }
        }

        public TitleDAL()
        {
            _context = new K2EDBContext();
        }

        public bool Create(Title entity)
        {
            _context.Titles.Add(entity);
            return Save() > 0;
        }

        public bool Update(Title entity)
        {
            Title query = GetById(entity.TituloId);  //db
            query.Nombre = entity.Nombre;
            query.Tiempo = entity.Tiempo;  //Nuevos valores
            query.CapituloId = entity.CapituloId;
            return Save() > 0;
        }

        public List<Title> GetAll()
        {
            return _context.Titles.ToList();

        }

        public Title GetById(int id)
        {
            return _context.Titles.FirstOrDefault(x => x.TituloId.Equals(id));
        }


        public int Save()
        {
            return _context.SaveChanges();
        }
    }
}
