using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aghanina.Models;
using Microsoft.EntityFrameworkCore;

namespace Aghanina.Data
{
    public class MyDb:DbContext 
    {
        public DbSet<Song> Songs { get; set; }
        public DbSet<Artist> Artists { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        public MyDb( DbContextOptions<MyDb>    options):base(options)
        {

        }
    }
}
