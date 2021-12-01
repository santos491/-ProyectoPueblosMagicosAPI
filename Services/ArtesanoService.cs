using Dto;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataAccess.Repositories;
using System.Linq;
using Dto.Request;
using Entitiess;


namespace Services
{
    public class ArtesanoService : IArtesanoService
    {
        private readonly IArtesanoRepository _repository;
        public ArtesanoService(IArtesanoRepository repository)
        {
            _repository = repository;
        }

        public async Task<int> CreateAsync(ArtesanoDtoRequest request)
        {
            return await _repository.CreateAsync(new ArtesanoData
            {
                Nombre = request.Nombre,
                Apellido_Paterno = request.Apellido_Paterno,
                Apellido_Materno = request.Apellido_Materno,
                Fecha_Registro = request.Fecha_Registro,
                Municipio = request.Municipio,
                Email = request.Email,
                Direccion = request.Direccion,
                Telefono = request.Telefono,
                Nombre_Negocio = request.Nombre_Negocio,

            });

        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }

        public async Task<ArtesanoDto> GetAsync(int id)
        {
            var artesanos = await _repository.GetAsync(id);

            if (artesanos == null)

                return null;

            return new ArtesanoDto
            {
                Id = artesanos.Id,
                Nombre = artesanos.Nombre,
                Apellido_Paterno = artesanos.Apellido_Paterno,
                Apellido_Materno = artesanos.Apellido_Materno,
                Fecha_Registro = artesanos.Fecha_Registro,
                Municipio = artesanos.Municipio,
                Email = artesanos.Email,
                Direccion = artesanos.Direccion,
                Telefono = artesanos.Telefono,
                Nombre_Negocio = artesanos.Nombre_Negocio,

        };
        }

        public async Task<ICollection<ArtesanoDto>> ListAsync()
        {
            var collection = await _repository.ListCollectionAsync();

            return collection.Select(x => new ArtesanoDto
            {
                Id = x.Id,
                Nombre = x.Nombre,
                Apellido_Paterno = x.Apellido_Paterno,
                Apellido_Materno = x.Apellido_Materno,
                Fecha_Registro = x.Fecha_Registro,
                Municipio = x.Municipio,
                Email = x.Email,
                Direccion = x.Direccion,
                Telefono = x.Telefono,
                Nombre_Negocio = x.Nombre_Negocio,


            })
            .ToList();
        }

        public async Task<int> UpdateAsync(int id, ArtesanoDtoRequest request)
        {
            return await _repository.UpdateAsync(new ArtesanoData
            {
                Id = id,
                Nombre = request.Nombre,
                Apellido_Paterno = request.Apellido_Paterno,
                Apellido_Materno = request.Apellido_Materno,
                Fecha_Registro = request.Fecha_Registro,
                Municipio = request.Municipio,
                Email = request.Email,
                Direccion = request.Direccion,
                Telefono = request.Telefono,
                Nombre_Negocio = request.Nombre_Negocio

            });
        }

        public async Task<int> CreateAsync1(ArtesaniasDtoRequest request)
        {
            return await _repository.CreateAsync1(new ProductosArtesanias
            {
                
                Nombre_Artesania = request.Nombre_Artesania,
                Descripcion = request.Descripcion,
                Materia_de_Elaboracion = request.Materia_de_Elaboracion,
                Default = request.Default,
                
            });
        }


        public async Task<Restaurantes> GetAsync1(string Municipio_Restaurante)
        {
            var restaurante = await _repository.GetAsync1(Municipio_Restaurante);

            if (restaurante == null)
            {
                return null;
            }

            return new Restaurantes
            {
                Id = restaurante.Id,
                Nombre_Restaurante = restaurante.Nombre_Restaurante,
                Telefono_Restaurante = restaurante.Telefono_Restaurante,
                Descripcion_Menu = restaurante.Descripcion_Menu,
                Direccion_Restaurante = restaurante.Direccion_Restaurante,
                Municipio_Restaurante = restaurante.Municipio_Restaurante,

            };
        }

        public async Task<ICollection<ProductosArtesanias>> ListAsync2()
        {
            var collection = await _repository.ListCollectionAsync2();

            return collection.Select(x => new ProductosArtesanias
            {
                Id = x.Id,
                Nombre_Artesania = x.Nombre_Artesania,
                Descripcion = x.Descripcion,
                Materia_de_Elaboracion = x.Materia_de_Elaboracion,
                Default = x.Default,
                
            })
            .ToList();
        }

        public async Task<int> CreateAsync2(RestaurantesDtoRequest request)
        {
            return await _repository.CreateAsync2(new Restaurantes
            {
                Nombre_Restaurante = request.Nombre_Restaurante,
                Telefono_Restaurante = request.Telefono_Restaurante,
                Descripcion_Menu = request.Descripcion_Menu,
                Direccion_Restaurante = request.Direccion_Restaurante,
                Municipio_Restaurante = request.Municipio_Restaurante,
                
            });

        }
    }
}
