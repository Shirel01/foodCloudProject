using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using foodCloudProject.Models;

namespace foodCloudProject.Data
{
    public class foodCloudProjectContext : DbContext
    {
        public foodCloudProjectContext (DbContextOptions<foodCloudProjectContext> options)
            : base(options)
        {
        }

        public DbSet<foodCloudProject.Models.Recipe> Recipe { get; set; } = default!;
    }
}
