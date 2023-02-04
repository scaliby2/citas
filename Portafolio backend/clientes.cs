using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portafolio_backend
{
    internal class clientes
    {
        string nombre, apellido, fechaReservacion,Viaje,tipoPago;
        int reserva;
        public clientes(string nombre, string apellido, string fechaReservacion, string viaje, string tipoPago, int reserva)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaReservacion = fechaReservacion;
            this.Viaje = viaje;
            this.tipoPago = tipoPago;
            this.Reserva = reserva;
            
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string FechaReservacion { get => fechaReservacion; set => fechaReservacion = value; }
        public string Viaje1 { get => Viaje; set => Viaje = value; }
        public string TipoPago { get => tipoPago; set => tipoPago = value; }
        public int Reserva { get => reserva; set => reserva = value; }

        public string MostrarInformacion()
        {
            return $"Nombre: {Nombre} \r\n" +
                $"Apellido: {Apellido} \r\n " +
                $"Fecha de Reservacion: {FechaReservacion} \r\n " +
                $"Tipo de viaje: {Viaje} \r\n" +
                $"Tipo de Pago: {TipoPago}\r\n"+
                $"Id reserva Pago {Reserva}";
        }
    }
}
