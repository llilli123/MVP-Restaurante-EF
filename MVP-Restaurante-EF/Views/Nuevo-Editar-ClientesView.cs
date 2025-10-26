using System;
using System.Windows.Forms;
using MVP_Restaurante_EF.Interfaces; // Para IClienteView
using MVP_Restaurante_EF.Presenters; // Para ClientePresenter
using MVP_Restaurante_EF.Repositories; // Para ClienteRepository

namespace MVP_Restaurante_EF.Views
{
    // NO implementa IClienteView. Es un formulario "tonto"
    public partial class Nuevo_Editar_ClientesView : Form
    {
        // Propiedades públicas para que el "padre" pueda leer los datos
        public int? ClienteId { get; private set; } // Para saber si es edición
        public string NombreCompleto => txtNombre.Text;
        public string Telefono => txtTelefono.Text;
        public string Correo => txtCorreo.Text;
        public string Personas => txtPersonas.Text; // Devolvemos string para validarlo en el Presenter

        public Nuevo_Editar_ClientesView()
        {
            InitializeComponent();

            // Conectamos los botones
            btnGuardar.Click += BtnGuardar_Click;
            btnCancelar.Click += BtnCancelar_Click;
        }

        // --- MÉTODOS PÚBLICOS ---

        // El "padre" (RegistroClientesView) llamará a este método
        public void CargarDatosParaEdicion(cliente cliente)
        {
            ClienteId = cliente.ClienteId;
            lblTitulo.Text = "Editar Cliente";
            txtNombre.Text = cliente.NombreCompleto;
            txtTelefono.Text = cliente.Telefono;
            txtCorreo.Text = cliente.Correo;
            txtPersonas.Text = cliente.GrupoPorDefecto.ToString();
        }

        // --- EVENTOS DE BOTONES ---

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            // Validaciones MUY BÁSICAS solo para el form
            // La validación "real" la hará el Presenter
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtPersonas.Text))
            {
                MessageBox.Show("Por favor, complete los campos requeridos (*).",
                                "Campos Incompletos",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // Si todo está bien, cerramos el diálogo con "OK"
            // El formulario "padre" sabrá que debe guardar
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
