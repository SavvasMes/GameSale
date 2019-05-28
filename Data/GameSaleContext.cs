using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GameSale.Models
{
    public class GameSaleContext : DbContext
    {
        public GameSaleContext (DbContextOptions<GameSaleContext> options)
            : base(options)
        {
        }

        public DbSet<GameSale.Models.Game> Game { get; set; }
    }
}
