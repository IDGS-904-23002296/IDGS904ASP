using System;

namespace IDGS904ASP.Models
{
    public class Boletos
    {
        public string Nombre { get; set; }
        public int CantidadCompradores { get; set; }
        public int CantidadBoletas { get; set; }
        public bool TarjetaCineco { get; set; }
        public double TotalAPagar { get; set; }
        public string MensajeError { get; set; }

        public void CalcularProceso()
        {
            double precioBoleta = 12;
            int maximoPermitido = CantidadCompradores * 7;

            if (CantidadBoletas > maximoPermitido)
            {
                MensajeError = $"No se pueden comprar más de 7 boletas por persona (Máximo: {maximoPermitido}).";
                TotalAPagar = 0;
                return;
            }

            double subtotal = CantidadBoletas * precioBoleta;
            double descuento = 0;

            if (CantidadBoletas > 5)
                descuento = subtotal * 0.15; // 15% 
            else if (CantidadBoletas >= 3)
                descuento = subtotal * 0.10; // 10% 

            double totalConDesc1 = subtotal - descuento;

            if (TarjetaCineco)
            {
                totalConDesc1 -= (totalConDesc1 * 0.10); // 10% adicional 
            }

            TotalAPagar = totalConDesc1;
        }
    }
}