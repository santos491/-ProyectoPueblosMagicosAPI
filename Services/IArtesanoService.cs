using Dto;
using Dto.Request;
using Entitiess;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Services
{
    public interface IArtesanoService
    {
        Task<ICollection<ArtesanoDto>> ListAsync();
        Task<ArtesanoDto> GetAsync(int id);

        Task<int> CreateAsync(ArtesanoDtoRequest request);

        Task<int> UpdateAsync(int id, ArtesanoDtoRequest request);

        Task DeleteAsync(int id);

        Task<int> CreateAsync1(ArtesaniasDtoRequest request);
        Task<Restaurantes> GetAsync1(string Municipio_Restaurante);

        Task<ICollection<ProductosArtesanias>> ListAsync2();

        Task<int> CreateAsync2(RestaurantesDtoRequest request);
    }
}
