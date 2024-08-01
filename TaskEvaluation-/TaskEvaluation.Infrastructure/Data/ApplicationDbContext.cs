using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TaskEvaluation.Core.Entities.Business;

namespace TaskEvaluation.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
             : base(options)
        {
        }

        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<EvaluationGrade> EvalutionGrades { get; set; }
       public DbSet<Group> Groups { get; set; }
        public DbSet<Solution> Solutions { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);

            
            foreach (var foreignKey in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetForeignKeys()))
            {
                if (foreignKey.DeleteBehavior == DeleteBehavior.SetNull)
                {
                    foreignKey.DeleteBehavior = DeleteBehavior.Restrict;
                }
            }

                modelBuilder.Entity<Course>().HasData(
                new Course { Id = 1, Title = "Front End", IsCompleted = false },
                new Course { Id = 2, Title = "Back End", IsCompleted = false }
            );

            modelBuilder.Entity<Group>().HasData(
                new Group { Id = 1, Title = "A", CourseId = 1 },
                new Group { Id = 2, Title = "B", CourseId = 2 }
            );

            modelBuilder.Entity<EvaluationGrade>().HasData(
                new EvaluationGrade { Id = 1, Grade = "Good" },
                new EvaluationGrade { Id = 2, Grade = "Very good" },
                new EvaluationGrade { Id = 3, Grade = "Excellent" }
            );
        }
    }
}
