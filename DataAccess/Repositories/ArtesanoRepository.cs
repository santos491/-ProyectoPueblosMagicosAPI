using Entitiess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{

    public class ArtesanoRepository : IArtesanoRepository
    {
        private ApplicationDbContext _context;

        public ArtesanoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> CreateAsync(ArtesanoData artesano)
        {
            await _context.Set<ArtesanoData>().AddAsync(artesano);
            await _context.SaveChangesAsync();

            return artesano.Id;
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _context.Set<ArtesanoData>()
                .SingleOrDefaultAsync(p => p.Id == id);

            if (entity != null)
            {
                _context.Set<ArtesanoData>().Attach(entity);
                _context.Entry(entity).State = EntityState.Deleted;
                await _context.SaveChangesAsync();

            }

        }

        public async Task<ArtesanoData> GetAsync(int id)
        {
            
            return await _context.Set<ArtesanoData>()
                .Where(x => x.Id == id)
                .SingleOrDefaultAsync();
        }

        public async Task<ICollection<ArtesanoData>> ListCollectionAsync()
        {
            return await _context.Set<ArtesanoData>()
                .ToListAsync();
        }

        public async Task<ICollection<ProductosArtesanias>> ListCollectionAsync2()
        {
            return await _context.Set<ProductosArtesanias>()
                .ToListAsync();
        }



        public async Task<int> UpdateAsync(ArtesanoData artesano)
        {
            _context.Set<ArtesanoData>().Attach(artesano);
            _context.Entry(artesano).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return artesano.Id;
        }

        public async Task<int> CreateAsync1(ProductosArtesanias productosArtesanias)
        {
            await _context.Set<ProductosArtesanias>().AddAsync(productosArtesanias);
            await _context.SaveChangesAsync();

            return productosArtesanias.Id;
        }

        public async Task<Restaurantes> GetAsync1(string Municipio_Restaurante)
        {
          
            return await _context.Set<Restaurantes>()
                .Where(x => x.Municipio_Restaurante == Municipio_Restaurante)
                .SingleOrDefaultAsync();
        }

        public async Task<int> CreateAsync2(Restaurantes restaurantes)
        {
            await _context.Set<Restaurantes>().AddAsync(restaurantes);
            await _context.SaveChangesAsync();

            return restaurantes.Id;
        }



    }
}
