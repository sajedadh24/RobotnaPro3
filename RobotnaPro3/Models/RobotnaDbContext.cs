using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RobotnaPro3.Models
{
    public class RobotnaDbContext : DbContext
    
    {
        public RobotnaDbContext(DbContextOptions<RobotnaDbContext> options) : base(options)
        {

        }
        public  DbSet <Product> Products { get; set; }
        public  DbSet <Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role>Roles { get; set; }


    }
}
