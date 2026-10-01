using System;
using System.Collections.Generic;
using System.Text;
using Tienda.Dominio.ObjetosDeValor;

namespace Tienda.Dominio.Entidades
{
    public class Producto
    {
        public Guid Id { get; private set; } = Guid.CreateVersion7();
        public string Nombre { get; private set; } = default!;

        public Dinero Precio { get; private set; } = Dinero.Crear(0,"USD");

        public CantidadInventario CantidadInventario { get; private set; } = CantidadInventario.Crear(0);

        public bool Activo { get; private set; } = true;

        public string Descripçion { get; private set; } = default!;

        public static Producto Crear(string nombre, Dinero precio, CantidadInventario cantidadInventario, string descripcion)
        {
            // Reglas de negocio o invariante del negocio, en este caso es para el producto
            if (string.IsNullOrWhiteSpace(nombre))
            {
                throw new ArgumentException("El nombre del producto no puede estar vacío.");
            }

            if (nombre.Trim().Length > 50) 
            {
                throw new ArgumentException("El nombre del producto no puede tener más de 50 caracteres."); 
            }

            if (precio == null)
            {
                throw new ArgumentException("El precio del producto no puede ser nulo.");
            }
            if (cantidadInventario == null)
            {
                throw new ArgumentException("La cantidad de inventario del producto no puede ser nula.");
            }
            if (string.IsNullOrWhiteSpace(descripcion))
            {
                throw new ArgumentException("La descripción del producto no puede estar vacía.");
            }
            return new Producto
            {
                Nombre = nombre,
                Precio = precio,
                CantidadInventario = cantidadInventario,
                Descripçion = descripcion
            };
        }

    }
}
