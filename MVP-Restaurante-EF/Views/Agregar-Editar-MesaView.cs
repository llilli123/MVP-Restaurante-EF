using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVP_Restaurante_EF.Models;

namespace MVP_Restaurante_EF.Views
{
    public partial class Agregar_Editar_MesaView : Form
    {
        public Mesa MesaCreada { get; private set; }
        private bool esEdicion = false;

        public Agregar_Editar_MesaView()
        {
            InitializeComponent();
        }

        public Agregar_Editar_MesaView(Mesa mesaEditar) : this()
        {
            esEdicion = true;
            MesaCreada = mesaEditar;
            numCapacidad.Value = mesaEditar.Capacidad;
            cmbEstado.Text = mesaEditar.Estado;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int capacidad = (int)numCapacidad.Value;
            string estado = cmbEstado.Text;

            if (capacidad <= 0)
            {
                MessageBox.Show("Ingrese una capacidad válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MesaCreada = new Mesa
            {
                Capacidad = capacidad,
                Estado = estado
            };

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
