using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giris1
{
    public class AppContext : DbContext
    {
       
        protected override void OnConfiguring(DbContextOptionsBuilder

            optionBuilder)
        {
            //DESKTOP - S0CBLLS\SQLEXPRESS
            optionBuilder.UseSqlServer(@"server=.\SQLEXPRESS;Database=YeniYil;uid=sa;pwd=123");

        }
        public DbSet<Categories> Category { get; set; }


    }
}
