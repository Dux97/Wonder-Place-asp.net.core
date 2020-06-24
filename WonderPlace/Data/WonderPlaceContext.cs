using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WonderPlace.Models
{
    public class WonderPlaceContext : DbContext
    {
        public WonderPlaceContext (DbContextOptions<WonderPlaceContext> options)
            : base(options)
        {
        }

        public DbSet<WonderPlace.Models.Place> Place { get; set; }
    }
}
