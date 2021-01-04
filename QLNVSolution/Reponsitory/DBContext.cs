using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QLNVSolution.Models;

namespace QLNVSolution.Reponsitory
{
    public class DBContext:DbContext
    {

        public DBContext(DbContextOptions<DBContext>options):base(options)
        {

        }

        public DbSet<Information> Information { get; set; }

    }
}
