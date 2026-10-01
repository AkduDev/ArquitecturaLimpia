using System;
using System.Collections.Generic;
using System.Text;

namespace Tienda.Dominio.ObjetosDeValor
{
    public class Dinero
    {
        public decimal Precio { get; private set; }
        public string Moneda { get; private set; } = default!;
        public Dinero(decimal monto, string moneda)
        {
            Precio = monto;
            Moneda = moneda;
        }
        public static Dinero Crear (decimal monto, string moneda)
        {
            // Reglas de negocio o invariante del negocio, en este caso es para el dinero
            if (monto < 0)
            {
                throw new ArgumentException("El monto no puede ser negativo.");
            }
            if (string.IsNullOrWhiteSpace(moneda))
            {
                throw new ArgumentException("La moneda no puede estar vacía.");
            }
            return new Dinero(monto, moneda);
        }

        

    }
}
