using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FinalChallengeStep451.Models;

namespace FinalChallengeStep451.Data
{
    public class FinalChallengeStep451Context : DbContext
    {
        public FinalChallengeStep451Context (DbContextOptions<FinalChallengeStep451Context> options)
            : base(options)
        {
        }

        public DbSet<FinalChallengeStep451.Models.Student> Student { get; set; }
    }
}
