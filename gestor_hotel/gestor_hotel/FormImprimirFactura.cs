using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using iTextSharp.text;
using gestor_hotel.dto;
using gestor_hotel.dao;

namespace gestor_hotel
{
    public partial class FormImprimirFactura : Form
    {
        private Factura _factura;   // Variable privada
        private Cliente _cliente;
        private Reserva _reserva;
        private Habitacion _habitacion;
        private ServicioDisponible _servicioDisponible;
        DaoFacturas daoFacturas = new DaoFacturas();
        DaoClientes daoClientes = new DaoClientes();
        DaoReservas daoReservas = new DaoReservas();
        DaoHabitaciones daoHabitaciones = new DaoHabitaciones();
        DaoServiciosDisponibles daoServiciosDisponibles = new DaoServiciosDisponibles();
        string estadoViejo, metodoPagoViejo;
        string estadoSeleccionado, metodoPagoSeleccionado;
        string idFactura;
        decimal precioTotal, cantidadPagada, faltaPagar;


        public FormImprimirFactura()
        {
            InitializeComponent();
        }

        public FormImprimirFactura(Factura factura)
        {
            InitializeComponent();
            this._factura = factura;
            CargarDatos();
        }

        private void txtCantidadPagada_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada no es un dígito y no es una tecla de control (como backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Cancela el evento KeyPress
            }
        }

        public void CargarDatos()
        {
            estadoViejo = _factura.estado;
            metodoPagoViejo = _factura.metodoPago;

            txtNumeroFactura.Text = _factura.numeroFactura.ToString();
            txtPrecioTotal.Text = _factura.precioTotal.ToString();

            idFactura = _factura.idFactura.ToString();
            
            ConseguirCampos();
        }
        
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRetroceder_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnImprimirFactura_Click(object sender, EventArgs e)
        {
            if (estadoSeleccionado == null)
                estadoSeleccionado = estadoViejo;
            if (metodoPagoSeleccionado == null)
                metodoPagoSeleccionado = metodoPagoViejo;

            if (txtCantidadPagada.Text == "")
                txtCantidadPagada.Text = "0";

                cantidadPagada = Convert.ToDecimal(txtCantidadPagada.Text);

            precioTotal = _factura.precioTotal;

            faltaPagar = precioTotal - cantidadPagada;

            // Mostrar un mensaje de confirmación
            DialogResult resultado = MessageBox.Show("¿Está seguro de los cambios realizados y imprimir la factura?", "Confirmar cambios e imprimir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Si confirmamos la habitación será modificada
            if (resultado == DialogResult.Yes)
            {
                daoFacturas.ModificarEstadoYMetodoPago(_factura.idFactura, cantidadPagada, estadoSeleccionado, metodoPagoSeleccionado);
                ImprimirFactura();
                this.Close();
            }
        }

        private void cboActualizarEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el valor seleccionado
            estadoSeleccionado = cboActualizarEstado.SelectedItem.ToString();
        }

        private void cboMetodoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el valor seleccionado
            metodoPagoSeleccionado = cboMetodoPago.SelectedItem.ToString();
        }

        public void ConseguirCampos()
        {
            _cliente = daoClientes.ObtenerClientePorId(_factura.idCliente);
            _reserva = daoReservas.ObtenerReservaPorId(_factura.idReserva);
            _servicioDisponible = daoServiciosDisponibles.ObtenerServicioDisponiblePorId(_factura.idServicioDisponible);
            _habitacion = daoHabitaciones.ObtenerHabitacionPorId(_reserva.idHabitacion);
        }

        public void ImprimirFactura()
        {
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.FileName = "Factura_" + DateTime.Now.ToString("ddMMyyyyHHmmss") + ".pdf";


            string paginahtml_texto = Properties.Resources.Plantilla.ToString();
            paginahtml_texto = paginahtml_texto.Replace("@FECHAHOY", DateTime.Now.ToString("dd/MM/yyyy"));
            paginahtml_texto = paginahtml_texto.Replace("@NOMBRECLIENTE", _cliente.nombre);
            paginahtml_texto = paginahtml_texto.Replace("@APELLIDOSCLIENTE", _cliente.apellidos);
            paginahtml_texto = paginahtml_texto.Replace("@DIRECCIONFACTURACION", _cliente.direccionFacturacion);
            paginahtml_texto = paginahtml_texto.Replace("@FECHAENTRADA", _reserva.fechaEntrada.ToString());
            paginahtml_texto = paginahtml_texto.Replace("@FECHASALIDA", _reserva.fechaSalida.ToString());
            paginahtml_texto = paginahtml_texto.Replace("@NUMEROHABITACION", _habitacion.numeroHabitacion);
            paginahtml_texto = paginahtml_texto.Replace("@COSTEHABITACION", _reserva.coste.ToString());
            paginahtml_texto = paginahtml_texto.Replace("@NOMBRESERVICIO", _servicioDisponible.nombre);
            paginahtml_texto = paginahtml_texto.Replace("@DESCRIPCIONSERVICIO", _servicioDisponible.descripcion);
            paginahtml_texto = paginahtml_texto.Replace("@PRECIOSERVICIO", _servicioDisponible.precioServicioDisponible.ToString());
            paginahtml_texto = paginahtml_texto.Replace("@METODOPAGO", metodoPagoSeleccionado);
            paginahtml_texto = paginahtml_texto.Replace("@ESTADO", estadoSeleccionado);
            paginahtml_texto = paginahtml_texto.Replace("@CANTIDADPAGADA", cantidadPagada.ToString());
            paginahtml_texto = paginahtml_texto.Replace("@PRECIOTOTAL", precioTotal.ToString());
            paginahtml_texto = paginahtml_texto.Replace("@FALTAPAGAR", faltaPagar.ToString());


            if (guardar.ShowDialog() == DialogResult.OK)
            {
                // Archivo de memoria
                using (FileStream stream = new FileStream(guardar.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.LogoFacturas, System.Drawing.Imaging.ImageFormat.Png);
                    img.ScaleToFit(80, 60);
                    img.Alignment = iTextSharp.text.Image.UNDERLYING;
                    img.SetAbsolutePosition(pdfDoc.LeftMargin + 30, pdfDoc.Top - 50);
                    pdfDoc.Add(img);

                    using (StringReader sr = new StringReader(paginahtml_texto))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }
                    pdfDoc.Close();
                    stream.Close();
                }

            }
        }
    }
}
