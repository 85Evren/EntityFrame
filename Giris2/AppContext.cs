using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giris2
{
    public class AppContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder

        optionBuilder)
        {
            //DESKTOP - S0CBLLS\SQLEXPRESS
            optionBuilder.UseSqlServer(@"server=.\SQLEXPRESS;Database=YeniYil2;uid=sa;pwd=123");

        }


        public DbSet<User> User { get; set;}
        public DbSet<Gender> Gender { get; set; }

        public DbSet<Adress> Adres { get; set; }

    }
}
