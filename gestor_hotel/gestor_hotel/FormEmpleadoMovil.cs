using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gestor_hotel.dao;
using gestor_hotel.dto;

namespace gestor_hotel
{
    public partial class FormEmpleadoMovil : Form
    {
        DaoRegistroEmpleados daoRegistroEmpleados = new DaoRegistroEmpleados();
        DaoServiciosRealizados daoServiciosRealizados = new DaoServiciosRealizados();
        int id_empleado;
        string nombre_empleado, puesto_empleado;
        private ServicioRealizado servicioRealizadoSeleccionado;    // Variable privada

        string numeroHabitacion;
        public FormEmpleadoMovil()
        {
            InitializeComponent();
        }

        public FormEmpleadoMovil(int id_empleado, string nombre_empleado, string puesto_empleado)
        {
            InitializeComponent();
            this.id_empleado = id_empleado;
            this.nombre_empleado = nombre_empleado;
            this.puesto_empleado = puesto_empleado;
            lblPuesto.Text = this.puesto_empleado;
            lblEmpleado.Text = this.nombre_empleado;
            daoServiciosRealizados.MostrarServiciosRealizados(dgvTareas, this.id_empleado);
        }
        //Para poder mover la ventana cuando se pincha en la barra de título.
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void imgMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void imgCerrar_Click(object sender, EventArgs e)
        {
            daoRegistroEmpleados.CerrarSesionEmpleado(id_empleado);
            Application.Exit();
        }
        private void imgCerrarSesion_Click(object sender, EventArgs e)
        {
            daoRegistroEmpleados.CerrarSesionEmpleado(id_empleado);
            this.Close();
        }
        private void dgvTareas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Nos aseguramos de que no sea la columna de encabezado
            {
                DataGridViewRow row = dgvTareas.Rows[e.RowIndex];

                int idServicioRealizado = Convert.ToInt32(row.Cells["id_servicio_realizado"].Value);
                int idServicioDisponible = Convert.ToInt32(row.Cells["id_servicio_disponible"].Value);
                int idHabitacion = Convert.ToInt32(row.Cells["id_habitacion"].Value);
                int cantidad = Convert.ToInt32(row.Cells["cantidad"].Value);
                decimal precioTotalServicios = Convert.ToDecimal(row.Cells["precio_total_servicios"].Value);
                DateTime? hecho = row.Cells["hecho"].Value != DBNull.Value ? Convert.ToDateTime(row.Cells["hecho"].Value) : (DateTime?)null;
                DateTime? fechaCancelacion = row.Cells["fecha_cancelacion"].Value != DBNull.Value ? Convert.ToDateTime(row.Cells["fecha_cancelacion"].Value) : (DateTime?)null;

                numeroHabitacion = row.Cells["numero_habitacion"].Value.ToString();
                //int numeroPersonas = Convert.ToInt32(row.Cells["numero_personas"].Value);
                //decimal precio = Convert.ToDecimal(row.Cells["precio"].Value);
                //string estado = row.Cells["estado"].Value.ToString();

                // Creamos el objeto ServicioRealizado y se lo pasamos a la variable servicioRealizadoSeleccionado (nuevo formulario)
                servicioRealizadoSeleccionado = new ServicioRealizado(idServicioRealizado, idServicioDisponible, idHabitacion, cantidad, precioTotalServicios, hecho, fechaCancelacion);
            }
        }

        private void btnMarcarComoHecho_Click(object sender, EventArgs e)
        {
            if (servicioRealizadoSeleccionado != null)
            {
                if (servicioRealizadoSeleccionado.hecho == null)
                {
                    servicioRealizadoSeleccionado.hecho = DateTime.Now;

                    // Llamamos a la función para actualizar el servicio en la base de datos
                    daoServiciosRealizados.ActualizarServicioRealizado(servicioRealizadoSeleccionado);
                    // Actualizamos la tabla
                    daoServiciosRealizados.MostrarServiciosRealizados(dgvTareas, this.id_empleado);
                    MessageBox.Show("Servicio marcado como hecho correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Este servicio ya ha sido realizado.", "Servicio ya realizado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("No se ha seleccionado ningún servicio realizado.", "Servicio no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void dgvTareas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Obtenemos el indice de la columna del DataGridView
            if (this.dgvTareas.Columns[e.ColumnIndex].Name == "hecho")
            {
                if (e.Value.GetType() != typeof(System.DBNull))
                {
                    e.CellStyle.BackColor = Color.LimeGreen;
                }
            }
            else if (this.dgvTareas.Columns[e.ColumnIndex].Name == "fecha_cancelacion")
            {
                if (e.Value.GetType() != typeof(System.DBNull))
                {
                    e.CellStyle.BackColor = Color.Red;
                }
            }
        }

        private FormVerTareaEmpleadoMovil formVerTareaEmpleadoMovil;    // Declarar el formulario como variable de clase
        private void btnVerTarea_Click(object sender, EventArgs e)
        {
            if (servicioRealizadoSeleccionado != null)
            {
                // Pasar el objeto servicio al nuevo formulario
                formVerTareaEmpleadoMovil = new FormVerTareaEmpleadoMovil(servicioRealizadoSeleccionado, id_empleado, numeroHabitacion);    // Crear una nueva instancia
                                                                                               //this.Hide();  // Útil
                formVerTareaEmpleadoMovil.Show();
                //servicioRealizadoSeleccionado
            }
            else
                MessageBox.Show("No se ha seleccionado ningún servicio realizado.", "Servicio no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

    }
}
