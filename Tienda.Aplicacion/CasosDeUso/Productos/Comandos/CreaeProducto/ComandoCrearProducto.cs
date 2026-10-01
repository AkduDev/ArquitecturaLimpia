using System;
using System.Collections.Generic;
using System.Text;

namespace Tienda.Aplicacion.CasosDeUso.Productos.Comandos.CreaeProducto
{
    public record ComandoCrearProducto(

        string Nombre,
        string? Descripcion,
        decimal Precio,
        string Moneda,
        int CantidadInventario
    );
}
