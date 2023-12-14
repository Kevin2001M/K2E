using System.Collections.Generic;
using System.Linq;
using K2E.Entities;

namespace K2E.DataAcess
{
    public class CourseDAL
    {
        private static CourseDAL _instance;
        private readonly K2EDBContext _context;
        public static CourseDAL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new CourseDAL();
                return _instance;

            }
        }

        public CourseDAL()
        {
            _context = new K2EDBContext();
        }

        public bool Create(Course entity)
        {
            _context.Courses.Add(entity);
            return Save() > 0;
        }

        public bool Update(Course entity)
        {
            Course query = GetById(entity.CursoId);  //db
            query.Titulo = entity.Titulo;  //Nuevos valores
            query.CategoryId = entity.CategoryId;
            query.Subtitulo = entity.Subtitulo;
            query.FechaPublicacion = entity.FechaPublicacion;
            query.Descripcion = entity.Descripcion;
            query.InstructorId = entity.InstructorId;
            query.Portada = entity.Portada;
            return Save() > 0;
        }

        public List<Course> GetAll()
        {
            return _context.Courses.Include("Category").Include("Instructor").ToList();

        }

        public Course GetById(int id)
        {
            return _context.Courses.FirstOrDefault(x => x.CursoId.Equals(id));
        }


        public int Save()
        {
            return _context.SaveChanges();
        }
    }
}
