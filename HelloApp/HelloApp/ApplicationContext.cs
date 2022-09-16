using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloApp
{
    public class ApplicationContext : DbContext // DbContext: определяет контекст данных, используемый для взаимодействия с базой данных
    {
        public DbSet<User> Users => Set<User>(); // DbSet/DbSet<TEntity>: представляет набор объектов, которые хранятся в базе данных
        public ApplicationContext() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) // DbContextOptionsBuilder: устанавливает параметры подключения
        {
            optionsBuilder.UseSqlite("Data Source=helloapp.db");
        }
    }
}
