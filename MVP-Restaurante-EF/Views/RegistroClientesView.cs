using MVP_Restaurante_EF.Interfaces;
using MVP_Restaurante_EF.Presenters;
using MVP_Restaurante_EF.Repositories;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MVP_Restaurante_EF.Views
{
    // Esta es la VISTA REAL que implementa la interfaz
    public partial class RegistroClientesView : Form, IClienteView
    {
        // --- Variables del MVP ---
        private readonly ClientePresenter _presenter;

        // Propiedades "privadas" para guardar los datos del diálogo
        private int? _idActual;
        private string _nombreActual;
        private string _telefonoActual;
        private string _correoActual;
        private byte _grupoActual;
        private bool _activoActual;

        public RegistroClientesView()
        {
            InitializeComponent();

            // ¡AQUÍ SE CONECTA TODO!
            // 1. Crear el Contexto (usando el nombre de tu .edmx)
            var context = new RestauranteReservasEntities();
            // 2. Crear el Repositorio
            var repository = new ClienteRepository(context);
            // 3. Crear el Presenter, pasándole 'this' (este formulario) como la Vista
            _presenter = new ClientePresenter(this, repository);

            // Conectar los eventos del formulario a los métodos
            this.Load += RegistroClientesView_Load;
            this.btnNuevoCliente.Click += BtnNuevoCliente_Click;
            this.gridClientes.CellClick += GridClientes_CellClick;
        }

        // --- IMPLEMENTACIÓN DE IClienteView ---

        // Propiedades de datos (se llenan desde el diálogo)
        public int? ClienteId { get => _idActual; set => _idActual = value; }
        public string NombreCompleto { get => _nombreActual; set => _nombreActual = value; }
        public string Telefono { get => _telefonoActual; set => _telefonoActual = value; }
        public string Correo { get => _correoActual; set => _correoActual = value; }
        public byte GrupoPorDefecto { get => _grupoActual; set => _grupoActual = value; }
        public bool Activo { get => _activoActual; set => _activoActual = value; }

        // Propiedad para el DataGridView
        public object DataSource
        {
            get { return gridClientes.DataSource; }
            set
            {
                gridClientes.DataSource = value;
                ConfigurarGrid(); // Método para ajustar las columnas
            }
        }

        // Eventos (el Presenter los escucha)
        public event EventHandler CargarClientesEvent;
        public event EventHandler GuardarClienteEvent;
        public event EventHandler EliminarClienteEvent;
        public event EventHandler ListaDeClientesCambioEvent;

        // Métodos de la interfaz
        public void MostrarMensaje(string mensaje, string titulo)
        {
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void LimpiarFormulario()
        {
            // No necesitamos hacer nada aquí porque el diálogo se cierra
            _idActual = null;
            _nombreActual = "";
            _telefonoActual = "";
            _correoActual = "";
            _grupoActual = 1; // Valor por defecto
            _activoActual = true;
        }

        public void SetModoEdicion(bool enEdicion)
        {
            // No aplica aquí, se maneja en el diálogo
        }

        // --- MANEJO DE EVENTOS DEL FORMULARIO ---

        private void RegistroClientesView_Load(object sender, EventArgs e)
        {
            // Le dice al Presenter: "¡Carga los datos iniciales!"
            CargarClientesEvent?.Invoke(this, EventArgs.Empty);
        }

        private void BtnNuevoCliente_Click(object sender, EventArgs e)
        {
            // 1. Abrir el diálogo en modo "Nuevo"
            using (var formDialogo = new Nuevo_Editar_ClientesView())
            {
                // 2. Si el usuario presiona "Guardar" (DialogResult.OK)...
                if (formDialogo.ShowDialog() == DialogResult.OK)
                {
                    // 3. Copiar los datos del diálogo a nuestras propiedades
                    this.ClienteId = null; // Es nuevo
                    this.NombreCompleto = formDialogo.NombreCompleto;
                    this.Telefono = formDialogo.Telefono;
                    this.Correo = formDialogo.Correo;
                    this.Activo = true; // Los nuevos siempre están activos

                    // 4. Validar y convertir el N° de Personas
                    if (byte.TryParse(formDialogo.Personas, out byte personas))
                    {
                        this.GrupoPorDefecto = personas;
                    }
                    else
                    {
                        this.GrupoPorDefecto = 0; // Forzamos un error de validación en el Presenter
                    }

                    // 5. Decirle al Presenter: "¡Guarda este cliente!"
                    GuardarClienteEvent?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        private void GridClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Asegurarse de que no sea el encabezado
            if (e.RowIndex < 0) return;

            // Obtener el cliente seleccionado
            // IMPORTANTE: Asume que tu 'DataSource' es una 'List<Cliente>'
            var listaClientes = (List<cliente>)gridClientes.DataSource;
            var clienteSeleccionado = listaClientes[e.RowIndex];

            // 1. Si se hizo clic en la columna "Eliminar"
            if (gridClientes.Columns[e.ColumnIndex].Name == "colEliminar")
            {
                if (MessageBox.Show($"¿Está seguro de que desea desactivar a {clienteSeleccionado.NombreCompleto}?",
                                     "Confirmar Eliminación",
                                     MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    // Poner el ID en la propiedad de la vista
                    this.ClienteId = clienteSeleccionado.ClienteId;
                    // Decirle al Presenter: "¡Elimina este ID!"
                    EliminarClienteEvent?.Invoke(this, EventArgs.Empty);
                }
            }

            // 2. Si se hizo clic en la columna "Editar"
            if (gridClientes.Columns[e.ColumnIndex].Name == "colEditar")
            {
                using (var formDialogo = new Nuevo_Editar_ClientesView())
                {
                    // Cargar el diálogo con los datos del cliente
                    formDialogo.CargarDatosParaEdicion(clienteSeleccionado);

                    // Si el usuario presiona "Guardar" (DialogResult.OK)...
                    if (formDialogo.ShowDialog() == DialogResult.OK)
                    {
                        // Copiar los datos del diálogo a nuestras propiedades
                        this.ClienteId = clienteSeleccionado.ClienteId; // Es edición
                        this.NombreCompleto = formDialogo.NombreCompleto;
                        this.Telefono = formDialogo.Telefono;
                        this.Correo = formDialogo.Correo;
                        this.Activo = true; // Al editar se mantiene activo

                        if (byte.TryParse(formDialogo.Personas, out byte personas))
                        {
                            this.GrupoPorDefecto = personas;
                        }
                        else
                        {
                            this.GrupoPorDefecto = 0; // Forzar error
                        }

                        // Decirle al Presenter: "¡Guarda esta actualización!"
                        GuardarClienteEvent?.Invoke(this, EventArgs.Empty);
                    }
                }
            }
        }

        // --- MÉTODOS PRIVADOS DE AYUDA ---

        private void ConfigurarGrid()
        {
            // Ocultar columnas que no queremos ver
            gridClientes.Columns["ClienteId"].Visible = false;
            gridClientes.Columns["Activo"].Visible = false;
            gridClientes.Columns["Reservas"].Visible = false; // Ocultar la lista de reservas

            // Ajustar los nombres de las columnas del .edmx a tu grid
            gridClientes.Columns["NombreCompleto"].DataPropertyName = "NombreCompleto";
            gridClientes.Columns["Telefono"].DataPropertyName = "Telefono";
            gridClientes.Columns["Correo"].DataPropertyName = "Correo";
            gridClientes.Columns["GrupoPorDefecto"].DataPropertyName = "GrupoPorDefecto";

            // Asignar las columnas de tu .designer a las de datos
            gridClientes.Columns["colNombre"].DataPropertyName = "NombreCompleto";
            gridClientes.Columns["colTelefono"].DataPropertyName = "Telefono";
            gridClientes.Columns["colCorreo"].DataPropertyName = "Correo";
            gridClientes.Columns["colPersonas"].DataPropertyName = "GrupoPorDefecto";
        }
    }
}
