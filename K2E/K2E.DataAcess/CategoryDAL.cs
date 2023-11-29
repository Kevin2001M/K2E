using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using K2E.Entities;

namespace K2E.DataAcess
{
    public class CategoryDAL
    {
        private static CategoryDAL _instance;
        private readonly K2EDBContext _context;
        public static CategoryDAL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new CategoryDAL();
                return _instance;

            }
        }

        public CategoryDAL()
        {
            _context = new K2EDBContext();
        }


        // CRUD - Create, Retrive, Update, Delete

        public bool Create(Category entity)
        {
            _context.Categories.Add(entity);
            return Save() > 0;
        }

        public bool Update(Category entity)
        {
            Category query = GetById(entity.CategoryId);  //db
            query.Nombre = entity.Nombre;  //Nuevos valores
            query.Descripcion = entity.Descripcion;
            return Save() > 0;
        }

        public List<Category> GetAll()
        {
            return _context.Categories.ToList();

        }

        public Category GetById(int id)
        {
            return _context.Categories.FirstOrDefault(x => x.CategoryId.Equals(id));
        }

        public void Delete(int id)
        {
            //var query = GetById(id);
            Category entity = GetById(id);
            _context.Categories.Remove(entity);
            Save();
        }

        public int Save()
        {
            return _context.SaveChanges();
        }

    }
}

