using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_TPB_API.Models;

namespace Web_TPB_API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<NationalPark> NationalParks { get; set; }
        //public object Trails { get; internal set; }
        public DbSet<Trail> Trails { get; set; }
        public DbSet<V_ClosingM> V_ClosingM { get; set; }
        //public DbSet<User> Users { get; set; }
    }
}
