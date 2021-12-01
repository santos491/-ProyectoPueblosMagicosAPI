using Entitiess;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public interface IArtesanoRepository
    {
         Task<ICollection<ArtesanoData>> ListCollectionAsync();
        Task<ArtesanoData> GetAsync(int id);

        Task<int> CreateAsync(ArtesanoData artesano);

        Task<int> UpdateAsync(ArtesanoData artesano);

        Task DeleteAsync(int id);
        Task<int> CreateAsync1(ProductosArtesanias productosArtesanias);
        Task<Restaurantes> GetAsync1(string Municipio_Restaurante);

        Task<ICollection<ProductosArtesanias>> ListCollectionAsync2();

        Task<int> CreateAsync2(Restaurantes restaurantes);

    }
}
