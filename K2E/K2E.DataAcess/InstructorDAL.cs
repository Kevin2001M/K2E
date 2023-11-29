using System.Collections.Generic;
using System.Linq;
using K2E.Entities;

namespace K2E.DataAcess
{
    public class InstructorDAL
    {
        private static InstructorDAL _instance;
        private readonly K2EDBContext _context;
        public static InstructorDAL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new InstructorDAL();
                return _instance;

            }
        }

        public InstructorDAL()
        {
            _context = new K2EDBContext();
        }

        public bool Create(Instructor entity)
        {
            _context.Instructors.Add(entity);
            return Save() > 0;
        }

        public bool Update(Instructor entity)
        {
            Instructor query = GetById(entity.InstructorId);  //db
            query.Nombre = entity.Nombre;  //Nuevos valores
            query.TituloEspecialidad = entity.TituloEspecialidad;
            query.SobreMi = entity.SobreMi;
            query.UrlSite = entity.UrlSite;
            query.UrlX = entity.UrlX;
            query.UrlLink = entity.UrlLink;
            query.UrlYt = entity.UrlYt;
            query.UrlFb = entity.UrlFb;
            return Save() > 0;
        }

        public List<Instructor> GetAll()
        {
            return _context.Instructors.ToList();

        }

        public Instructor GetById(int id)
        {
            return _context.Instructors.FirstOrDefault(x => x.InstructorId.Equals(id));
        }




        public int Save()
        {
            return _context.SaveChanges();
        }
    }
}

