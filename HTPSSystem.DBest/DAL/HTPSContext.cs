using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using HTPSSystem.DBest.Entities;

namespace HTPSSystem.DBest.DAL
{
    internal class HTPSContext : DbContext
    {
        public HTPSContext() : base("StarTEDDb")
        {

        }
        public DbSet<Address> Addresses { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<StudentAddress> StudentAddresses { get; set; }
    }
}
