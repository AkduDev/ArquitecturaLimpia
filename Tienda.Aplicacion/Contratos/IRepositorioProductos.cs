using System;
using System.Collections.Generic;
using System.Text;
using Tienda.Dominio.Entidades;

namespace Tienda.Aplicacion.Contratos
{
    public interface IRepositorioProductos
    {
        Task Agregar(Producto producto);

        Task<Producto?> ObtenerPorId(Guid id);

        Task<bool> Existe(string nombre);
    }
}
