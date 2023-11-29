using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using K2E.Entities;

namespace K2E.DataAcess
{
    public class ChapterDAL
    {
        private static ChapterDAL _instance;
        private readonly K2EDBContext _context;
        public static ChapterDAL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ChapterDAL();
                return _instance;

            }
        }

        public ChapterDAL()
        {
            _context = new K2EDBContext();
        }

        public bool Create(Chapter entity)
        {
            _context.Chapters.Add(entity);
            return Save() > 0;
        }

        public bool Update(Chapter entity)
        {
            Chapter query = GetById(entity.CapituloId);  //db
            query.Nombre = entity.Nombre;  //Nuevos valores
            query.CantidadTitulo = entity.CantidadTitulo;
            query.Tiempo = entity.Tiempo;
            query.CursoId = entity.CursoId;
            return Save() > 0;
        }

        public List<Chapter> GetAll()
        {
            return _context.Chapters.ToList();

        }

        public Chapter GetById(int id)
        {
            return _context.Chapters.FirstOrDefault(x => x.CapituloId.Equals(id));
        }




        public int Save()
        {
            return _context.SaveChanges();
        }
    }
}
