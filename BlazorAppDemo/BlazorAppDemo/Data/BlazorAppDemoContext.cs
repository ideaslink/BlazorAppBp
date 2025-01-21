using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlazorAppDemo.Models;

namespace BlazorAppDemo.Data
{
    public class BlazorAppDemoContext : DbContext
    {
        public BlazorAppDemoContext (DbContextOptions<BlazorAppDemoContext> options)
            : base(options)
        {
        }

        public DbSet<BlazorAppDemo.Models.Topic> Topic { get; set; } = default!;
    }
}
