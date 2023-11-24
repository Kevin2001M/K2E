using K2E.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K2E.DataAcess
{
    public class K2EDBContext : DbContext
    {
        public K2EDBContext() : base("conn")
        {


        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Chapter> Chapters { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Rol> Rols { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Title> Titles { get; set; }
        public DbSet<User> Users { get; set; }

        

    }
}
