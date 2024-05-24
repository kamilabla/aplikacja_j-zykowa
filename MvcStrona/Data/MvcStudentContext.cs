using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcStrona.Models;

namespace MvcStrona.Data
{
    public class MvcStudentContext : DbContext
    {
        public MvcStudentContext (DbContextOptions<MvcStudentContext> options)
            : base(options)
        {
        }

        public DbSet<MvcStrona.Models.Student> Student { get; set; } = default!;
    }
}
