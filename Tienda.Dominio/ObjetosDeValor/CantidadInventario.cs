using System;
using System.Collections.Generic;
using System.Text;

namespace Tienda.Dominio.ObjetosDeValor
{
    public class CantidadInventario
    {
       public int Valor { get; private set; }

        public CantidadInventario(int valor)
        {
            Valor = valor;
        }

        public static CantidadInventario Crear(int valor)
        {
            // Reglas de negocio o invariante del negocio, en este caso es para la cantidad de inventario
            if (valor < 0)
            {
                throw new ArgumentException("La cantidad de inventario no puede ser negativa.");
            }
            return new CantidadInventario(valor);
        }

    }
}
