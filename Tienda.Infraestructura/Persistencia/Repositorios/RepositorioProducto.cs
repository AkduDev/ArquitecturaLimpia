using System;
using System.Collections.Generic;
using System.Text;
using Tienda.Aplicacion.Contratos;
using Tienda.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Tienda.Infraestructura.Persistencia.Repositorios
{
    public class RepositorioProducto(ApplicationDbContext context) : IRepositorioProductos
    {
        public async Task Agregar(Producto producto)
        {
            context.Add(producto);
            await context.SaveChangesAsync();
        }

        public async Task<bool> Existe(string nombre)
        {
            return await context.Productos.AnyAsync(p => p.Nombre == nombre);
        }

        public async Task<Producto?> ObtenerPorId(Guid id)
        {
            return await context.Productos.FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}
