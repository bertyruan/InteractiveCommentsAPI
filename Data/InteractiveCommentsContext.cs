using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using InteractiveComments.Models;

namespace InteractiveComments.Data
{
    public class InteractiveCommentsContext : DbContext
    {
        public InteractiveCommentsContext (DbContextOptions<InteractiveCommentsContext> options)
            : base(options)
        {
        }

        public DbSet<User> User { get; set; } = default!;
        public DbSet<Comment> Comments { get; set; } = default!;
        public DbSet<InteractiveComments.Models.Thread> Threads { get; set; } = default!;
    }
}
