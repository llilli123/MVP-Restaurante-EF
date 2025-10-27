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
    public partial class Reservaciones : Form
    {
        private RestauranteReservasEntities _context = new RestauranteReservasEntities();

        public Reservaciones()
        {
            InitializeComponent();
            this.Load += Disponibilidad_Load;
        }

        private void CargarReservas()
        {
            try
            {
                // Consultar las reservas y mostrar información relevante
                var reservas = _context.reservas
                    .Select(r => new
                    {
                        r.ReservaId,
                        Cliente = r.ClienteId,
                        Mesa = r.MesaId,
                        r.Fecha,
                        r.HoraInicio,
                        r.DuracionHoras,
                        r.NumeroPersonas,
                        r.Estado
                    })
                    .ToList();

                gridReservas.DataSource = reservas;

                // Opcional: ajustar estilo visual del DataGridView
                gridReservas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                gridReservas.ReadOnly = true;
                gridReservas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                gridReservas.MultiSelect = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las reservas: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Disponibilidad_Load(object sender, EventArgs e)
        {
            CargarReservas();
        }

        private void btnAgregarReservas_Click(object sender, EventArgs e)
        {
            ReservasViews reservasForm = new ReservasViews();

            // Mostrar el nuevo formulario
            reservasForm.Show();

            // Cerrar el formulario actual (Disponibilidad)
            this.Close();

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MainPageViewcs mainpage = new MainPageViewcs();

            mainpage.Show();

            this.Close();

        }

        private void Reservaciones_Load(object sender, EventArgs e)
        {

        }
    }
}

