using Microsoft.EntityFrameworkCore;
using SchoolManagement.Entities;
using SchoolManagement.Entities.Contract;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.DataAccess.Concrete
{
    public class SchoolManagementDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=ARC134NB\MSSQLSERVER02;Database=School;Integrated Security=true;TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Class> CLASS { get; set; }
        public DbSet<Parameter> PARAMETER { get; set; }
        public DbSet<School> SCHOOL { get; set; }
        public DbSet<Student> STUDENT { get; set; }
        public DbSet<Teacher> TEACHER { get; set; }
        public DbSet<TeacherSyllabus> TEACHERSYLLABUS { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configure default schema
            modelBuilder.HasDefaultSchema("Admin");

            //Map entity to table
            modelBuilder.Entity<Class>().ToTable("CLASS", "SCH");
            modelBuilder.Entity<Parameter>().ToTable("PARAMETER", "COR").HasNoKey();
            modelBuilder.Entity<School>().ToTable("SCHOOL", "SCH");
            modelBuilder.Entity<Student>().ToTable("STUDENT", "SCH");
            modelBuilder.Entity<Teacher>().ToTable("Teacher", "SCH");
            modelBuilder.Entity<TeacherSyllabus>().ToTable("TeacherSyllabus", "SCH");

        }
    }
}
