using MVP_Restaurante_EF.Models;
using MVP_Restaurante_EF.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVP_Restaurante_EF.Views
{
    public partial class ReservasViews : Form
    {
        private readonly ReservasPresenter _presenter;
        public int ReservaId { get; private set; }
        public ReservasViews()
        {
            InitializeComponent();
            _presenter = new ReservasPresenter(this);
            
            // Una vez que el Presenter está listo, inicializa la carga de datos
            _presenter.InicializarVista();
        }
        // --- CÓDIGO DENTRO DE LA VISTA (Ej: ReservasView.cs) ---
     

        public void CargarDatosIniciales()
        {
            // 1. Obtener la lista de DTOs del Presenter/ViewModel
            var clientes = _presenter;
            var mesas = _presenter; // Podrías pasar la fecha por si filtra

            // 2. Poblar el control (Asumiendo WinForms o similar)
            cboCliente.DataSource = clientes;
            cboCliente.DisplayMember = "NombreCompleto"; // Propiedad del ClienteDTO
            cboCliente.ValueMember = "IdCliente";

            cboMesa.DataSource = mesas;
            cboMesa.DisplayMember = "NumeroMesa"; // Propiedad del MesaDTO
            cboMesa.ValueMember = "IdMesa";
        }
        // --- CÓDIGO DENTRO DE LA VISTA (Ej: ReservasView.cs) ---

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            // 1. Recoger todos los datos del formulario
            var nuevaReservaData = new NuevaReservaDTO
            {
                ClienteId = (int)cboCliente.SelectedValue,
                MesaId = (int)cboMesa.SelectedValue,
                Fecha = dtpFecha.Value,
                Hora = txtHora.Text,
                DuracionHoras = byte.Parse(txtDuracion.Text) // ¡Cuidado con el parsing! Usar TryParse.
            };

            // 2. Enviar el evento y los datos al Presenter
        // --- CÓDIGO DENTRO DE LA TARJETA (Ej: TarjetaReservaActiva.cs) ---
            _presenter.ConfirmarNuevaReserva(nuevaReservaData);
        }

        private void btnCancelarReserva_Click(object sender, EventArgs e)
        {
            // El control/tarjeta debe tener el ID de la reserva asociada como propiedad (ej: this.ReservaId)
            _presenter.CancelarReservaActiva(this.ReservaId);
        }
        // --- CÓDIGO DENTRO DE LA VISTA (Ej: ReservasView.cs) ---

        public void MostrarReservasActivas(List<ReservaActivaDTO> reservas)
        {
            cardReservasActivas.Controls.Clear();

            foreach (var reserva in reservas)
            {
                // 1. Instanciar la nueva clase 'TarjetaActiva'
                var tarjeta = new TarjetaActiva(_presenter); // ¡Correcto!

                // 2. Pasar los datos a la tarjeta
                tarjeta.SetData(reserva);

                // 3. Suscribirse al evento de cancelación
                // La suscripción es al evento de la *instancia* creada en el bucle.
                tarjeta.CancelarClicked += (s, id) => _presenter.CancelarReservaActiva(id);

                cardReservasActivas.Controls.Add(tarjetaActiva);
            }
        }


        // --- CÓDIGO DENTRO DE LA VISTA (Ej: ReservasView.cs) ---

        public void LimpiarCamposNuevaReserva()
        {
            // Resetear los combos
            cboCliente.SelectedIndex = -1; // o cmbCliente.Text = "Seleccione Cliente";
            cboMesa.SelectedIndex = -1;   // o cmbMesa.Text = "Seleccione Mesa";

            // Resetear los campos de texto/fecha
            dtpFecha.Value = DateTime.Now.Date;
            txtHora.Text = string.Empty;
            txtDuracion.Text = string.Empty;

            // Opcional: Mostrar un mensaje de éxito
            MessageBox.Show("Reserva confirmada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

}
