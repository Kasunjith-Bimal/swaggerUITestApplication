using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwagerAPIConfiguration.Modles
{
    public class StudentDbContext:DbContext
    {
        public StudentDbContext(DbContextOptions options) :base(options)
        {

        }
       public DbSet<Student> students { get; set; }
    }

   
}
