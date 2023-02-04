using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portafolio_backend
{
    public partial class Form1 : Form
    {
        List<clientes> Reservas;
        public Form1()
        {
            Reservas = new List<clientes>();
            InitializeComponent();
        }
        
            

           
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            string Nombre = TNombre.Text;
            string Apellido = Tapellido.Text;            
            string Fecha = dtfecha.Text;
            string Viaje = cViaje.Text;
            string Pago = cPago.Text;
            Random rd = new Random();
            int reserva = rd.Next(1,10);

            
            if (TNombre.Text == "" || Tapellido.Text == "" || dtfecha.Text == "" || cPago.Text == "")
            {
                MessageBox.Show("Algun campo esta vacion");
                
            }
            else
            {
                clientes reservas = new clientes(Nombre, Apellido, Fecha, Viaje, Pago, reserva);
                Reservas.Add(reservas);
                MessageBox.Show("Reservacion realizada \n" + reservas.MostrarInformacion());

                TNombre.Clear();
                Tapellido.Clear();

            }






        }

        private void BotonSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hasta luego");
            Close();
        }

        

        private void buscar_Click(object sender, EventArgs e)
        {
            int buscar = Convert.ToInt32(Idreserva.Text);

            foreach (var item in Reservas)
            {
                if (Idreserva.Text.Length==0 )
                {
                    MessageBox.Show("No encontrado");

                }
                else {
                    Busquedas.Text = item.MostrarInformacion();
                }
                

               
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           for (var i=0; i<Reservas.Count; i++)
            {
                Busquedas.Text = Reservas[i].MostrarInformacion();
            }
              


            

        }
    }
}
