using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GameShopApp.Model;

namespace GameShopApp.Data
{
    public class GameShopAppContext : DbContext
    {
        public GameShopAppContext (DbContextOptions<GameShopAppContext> options)
            : base(options)
        {
        }

        public DbSet<GameShopApp.Model.Game> Game { get; set; } = default!;
    }
}
