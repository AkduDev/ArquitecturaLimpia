using System;
using System.Collections.Generic;
using System.Text;
using Tienda.Aplicacion.Contratos;
using Tienda.Dominio.Entidades;
using Tienda.Dominio.ObjetosDeValor;

namespace Tienda.Aplicacion.CasosDeUso.Productos.Comandos.CreaeProducto
{
    public class CasoDeUsoCrearProducto(IRepositorioProductos repositorioProductos)
    {
        public async Task<Guid> Handle(ComandoCrearProducto comando)
        {

            var existeProducto = await repositorioProductos.Existe(comando.Nombre);

            if (existeProducto)
            {
                throw new InvalidOperationException($"El producto con nombre '{comando.Nombre}' ya existe.");
            }


            var dinero = Dinero.Crear(comando.Precio, comando.Moneda);
            var cantidadInventario = CantidadInventario.Crear(comando.CantidadInventario);

            var producto = Producto.Crear(
                nombre: comando.Nombre,
                descripcion: comando.Descripcion,
                precio: dinero,
                cantidadInventario: cantidadInventario
                );
            
            await repositorioProductos.Agregar(producto);
            return producto.Id; 
        }
    }
}
