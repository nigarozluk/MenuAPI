using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class MenuContext:DbContext
    {
        public MenuContext(DbContextOptions<MenuContext> options)
            : base(options)
        {

        }

        public DbSet<Menu> Menus { get; set; }
    }
}
