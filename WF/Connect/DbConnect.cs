using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WF.Models;

namespace WF.Connect
{
    // Подключение всех моделей к БД
    // К классу который мы используем для подключения (DbConnect)
    // Необходимо добавить наследования от класса DbContext (Класс скачивается вместе с библиотеками)
    public class DbConnect : DbContext
    {
        // Подключение моделей к нашему коннекту
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<SubOrganization> SubOrganizations { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Absence> Absences { get; set; }

        // Настройка конфига для подключения к БД
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Строка подключения проекта к БД
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=testkz;Trusted_Connection=True;");
        }
    }
}
