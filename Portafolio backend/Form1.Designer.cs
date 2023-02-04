namespace Portafolio_backend
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cPago = new System.Windows.Forms.ComboBox();
            this.Tapellido = new System.Windows.Forms.TextBox();
            this.TNombre = new System.Windows.Forms.TextBox();
            this.cViaje = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtfecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BotonReservacion = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Idreserva = new System.Windows.Forms.TextBox();
            this.Busquedas = new System.Windows.Forms.TextBox();
            this.buscar = new System.Windows.Forms.Button();
            this.BotonSalir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cPago);
            this.groupBox1.Controls.Add(this.Tapellido);
            this.groupBox1.Controls.Add(this.TNombre);
            this.groupBox1.Controls.Add(this.cViaje);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtfecha);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BotonReservacion);
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 277);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Añadir Reservacion";
            // 
            // cPago
            // 
            this.cPago.FormattingEnabled = true;
            this.cPago.Items.AddRange(new object[] {
            "Tarjeta de Credito o Debito",
            "Cheque",
            "Transferencia",
            "Efectivo"});
            this.cPago.Location = new System.Drawing.Point(119, 155);
            this.cPago.Name = "cPago";
            this.cPago.Size = new System.Drawing.Size(145, 21);
            this.cPago.TabIndex = 13;
            // 
            // Tapellido
            // 
            this.Tapellido.Location = new System.Drawing.Point(119, 45);
            this.Tapellido.Name = "Tapellido";
            this.Tapellido.Size = new System.Drawing.Size(200, 20);
            this.Tapellido.TabIndex = 12;
            // 
            // TNombre
            // 
            this.TNombre.Location = new System.Drawing.Point(119, 19);
            this.TNombre.Name = "TNombre";
            this.TNombre.Size = new System.Drawing.Size(200, 20);
            this.TNombre.TabIndex = 11;
            // 
            // cViaje
            // 
            this.cViaje.FormattingEnabled = true;
            this.cViaje.Items.AddRange(new object[] {
            "Redondo",
            "Ida",
            "Vuelta"});
            this.cViaje.Location = new System.Drawing.Point(119, 128);
            this.cViaje.Name = "cViaje";
            this.cViaje.Size = new System.Drawing.Size(145, 21);
            this.cViaje.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tipo de Pago";
            // 
            // dtfecha
            // 
            this.dtfecha.Location = new System.Drawing.Point(123, 89);
            this.dtfecha.MinDate = new System.DateTime(2023, 2, 3, 0, 0, 0, 0);
            this.dtfecha.Name = "dtfecha";
            this.dtfecha.Size = new System.Drawing.Size(200, 20);
            this.dtfecha.TabIndex = 6;
            this.dtfecha.Value = new System.DateTime(2023, 2, 3, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tipo de Viaje";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha de reservacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // BotonReservacion
            // 
            this.BotonReservacion.Location = new System.Drawing.Point(119, 212);
            this.BotonReservacion.Name = "BotonReservacion";
            this.BotonReservacion.Size = new System.Drawing.Size(145, 39);
            this.BotonReservacion.TabIndex = 0;
            this.BotonReservacion.Text = "Agregar Reservacion";
            this.BotonReservacion.UseVisualStyleBackColor = true;
            this.BotonReservacion.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.Idreserva);
            this.groupBox2.Controls.Add(this.Busquedas);
            this.groupBox2.Controls.Add(this.buscar);
            this.groupBox2.Location = new System.Drawing.Point(405, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(387, 385);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "verificar cita ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(149, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Id la reserva";
            // 
            // Idreserva
            // 
            this.Idreserva.Location = new System.Drawing.Point(124, 77);
            this.Idreserva.Name = "Idreserva";
            this.Idreserva.Size = new System.Drawing.Size(140, 20);
            this.Idreserva.TabIndex = 14;
            // 
            // Busquedas
            // 
            this.Busquedas.Location = new System.Drawing.Point(6, 103);
            this.Busquedas.Multiline = true;
            this.Busquedas.Name = "Busquedas";
            this.Busquedas.Size = new System.Drawing.Size(377, 276);
            this.Busquedas.TabIndex = 13;
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(6, 28);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(112, 69);
            this.buscar.TabIndex = 1;
            this.buscar.Text = "Buscar por ID";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // BotonSalir
            // 
            this.BotonSalir.Location = new System.Drawing.Point(131, 316);
            this.BotonSalir.Name = "BotonSalir";
            this.BotonSalir.Size = new System.Drawing.Size(183, 74);
            this.BotonSalir.TabIndex = 2;
            this.BotonSalir.Text = "Salir";
            this.BotonSalir.UseVisualStyleBackColor = true;
            this.BotonSalir.Click += new System.EventHandler(this.BotonSalir_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(269, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 69);
            this.button1.TabIndex = 17;
            this.button1.Text = "Todas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AcceptButton = this.BotonReservacion;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BotonSalir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservacions Jose ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cViaje;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtfecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BotonReservacion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.TextBox Tapellido;
        private System.Windows.Forms.TextBox TNombre;
        private System.Windows.Forms.TextBox Busquedas;
        private System.Windows.Forms.ComboBox cPago;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BotonSalir;
        private System.Windows.Forms.TextBox Idreserva;
        private System.Windows.Forms.Button button1;
    }
}

