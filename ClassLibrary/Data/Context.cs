using ClassLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Data
{
    public class Context : DbContext
    {
        public DbSet <Emberek> Emberek { get; set; }

        public Context()
        {
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Emberes;Trusted_Connection=True;");
        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string myConnectionString = "Server=127.0.0.1;User ID=root;  Password=;Database=Emberes";
            optionsBuilder.UseMySql(myConnectionString, ServerVersion.AutoDetect(myConnectionString));
        }


    }
}
