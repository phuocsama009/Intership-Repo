using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ExerciseS2.Models;

namespace ExerciseS2.Data
{
    public class ExerciseS2Context : DbContext
    {
        public ExerciseS2Context (DbContextOptions<ExerciseS2Context> options)
            : base(options)
        {
        }

        public DbSet<ExerciseS2.Models.Movie> Movie { get; set; }
    }
}
