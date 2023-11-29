using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using K2E.Entities;

namespace K2E.DataAcess
{
    public class CommentDAL
    {
        private static CommentDAL _instance;
        private readonly K2EDBContext _context;
        public static CommentDAL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new CommentDAL();
                return _instance;

            }
        }

        public CommentDAL()
        {
            _context = new K2EDBContext();
        }

        public bool Create(Comment entity)
        {
            _context.Comments.Add(entity);
            return Save() > 0;
        }

        public bool Update(Comment entity)
        {
            Comment query = GetById(entity.ComentarioId);  //db
            query.CursoId = entity.CursoId;  //Nuevos valores
            query.Email = entity.Email;
            query.Mensaje = entity.Mensaje;
            query.Fecha = entity.Fecha;
            return Save() > 0;
        }

        public List<Comment> GetAll()
        {
            return _context.Comments.ToList();

        }

        public Comment GetById(int id)
        {
            return _context.Comments.FirstOrDefault(x => x.ComentarioId.Equals(id));
        }


        public int Save()
        {
            return _context.SaveChanges();
        }

    }
}
