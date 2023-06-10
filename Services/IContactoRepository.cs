using MauiPetShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiPetShop.Services
{
    public interface IContactoRepository
    {
		public Task<List<Contacto>> GetContactosAsync();
		public Task<Contacto> GetContactoAsync(int ContactoId);
		public Task<bool> AddContactoAsync(Contacto contacto);
		public Task<bool> UpdateContactoAsync(Contacto contacto);
		public Task<bool> DeleteContactoAsync(int ContactoId);

        Task<List<Producto>> GetProductosAsync();
        Task<Producto> GetProductoAsync(int id);
        Task<bool> AddProductoAsync(Producto producto);
        Task<bool> UpdateProductoAsync(Producto producto);
        Task<bool> DeleteProductoAsync(int id);

        Task<List<Cliente>> GetClientesAsync();
        Task<Cliente> GetClienteAsync(int id);
        Task<bool> AddClienteAsync(Cliente cliente);
        Task<bool> UpdateClienteAsync(Cliente cliente);
        Task<bool> DeleteClienteAsync(int id);
    }
}
