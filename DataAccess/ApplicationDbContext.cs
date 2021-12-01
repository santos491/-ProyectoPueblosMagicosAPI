using Entitiess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext()
        {

        }
        public ApplicationDbContext
            (DbContextOptions<ApplicationDbContext> options )
            : base(options)
        {

        }

        public DbSet<ArtesanoData> artesanoDatas { get; set; }
        public DbSet<ProductosArtesanias> productosArtesanias { get; set; }
        public DbSet<Restaurantes> restaurantes { get; set; }


    }
}
