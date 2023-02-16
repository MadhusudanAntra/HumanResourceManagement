using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRM.ApplicationCore.Entity;

namespace HRM.Infrastructure.Data
{
    public class HRMDbContext:DbContext
    {
        public HRMDbContext(DbContextOptions<HRMDbContext> options):base(options)
        {

        }

        public DbSet<JobRequirement> JobRequirement { get; set; }
        public DbSet<JobCategory> JobCategory { get; set; }
        public DbSet<Candidate> Candidate { get; set; }
        public DbSet<Submission> Submission { get; set; }
    }
}
