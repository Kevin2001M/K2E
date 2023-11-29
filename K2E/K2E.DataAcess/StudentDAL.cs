using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using K2E.Entities;

namespace K2E.DataAcess
{
    public class StudentDAL
    {
        private static StudentDAL _instance;
        private readonly K2EDBContext _context;
        public static StudentDAL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new StudentDAL();
                return _instance;

            }
        }

        public StudentDAL()
        {
            _context = new K2EDBContext();
        }

        public bool Create(Student entity)
        {
            _context.Students.Add(entity);
            return Save() > 0;
        }

        public bool Update(Student entity)
        {
            Student query = GetById(entity.StudentId);  //db
            query.Email = entity.Email;
            query.Nombre = entity.Nombre;  //Nuevos valores
            query.Nacionalidad = entity.Nacionalidad;
            return Save() > 0;
        }

        public List<Student> GetAll()
        {
            return _context.Students.ToList();

        }

        public Student GetById(int id)
        {
            return _context.Students.FirstOrDefault(x => x.StudentId.Equals(id));
        }


        public int Save()
        {
            return _context.SaveChanges();
        }
    }
}
