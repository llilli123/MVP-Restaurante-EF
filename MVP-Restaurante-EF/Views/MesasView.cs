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
    public partial class MesasView : Form
    {
        private List<Mesa> listaMesas = new List<Mesa>();
        private int contadorMesas = 1;

        public MesasView()
        {
            InitializeComponent();
        }

        private void MesasView_Load(object sender, EventArgs e)
        {
            ConfigurarGrid();
            ActualizarTabla();
        }

        private void btnAgregarMesa_Click(object sender, EventArgs e)
        {
            Agregar_Editar_MesaView frm = new Agregar_Editar_MesaView();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Mesa nuevaMesa = frm.MesaCreada;
                nuevaMesa.Id = contadorMesas++;
                listaMesas.Add(nuevaMesa);
                ActualizarTabla();
            }
        }

        private void ConfigurarGrid()
        {
            gridMesas.Columns.Clear();
            gridMesas.AutoGenerateColumns = false;
            gridMesas.AllowUserToAddRows = false;

            gridMesas.Columns.Add("IdMesa", "ID Mesa");
            gridMesas.Columns.Add("Capacidad", "Capacidad");
            gridMesas.Columns.Add("Estado", "Estado");

            DataGridViewButtonColumn colEditar = new DataGridViewButtonColumn();
            colEditar.HeaderText = "Editar";
            colEditar.Text = "Editar";
            colEditar.UseColumnTextForButtonValue = true;
            gridMesas.Columns.Add(colEditar);

            DataGridViewButtonColumn colEliminar = new DataGridViewButtonColumn();
            colEliminar.HeaderText = "Eliminar";
            colEliminar.Text = "Eliminar";
            colEliminar.UseColumnTextForButtonValue = true;
            gridMesas.Columns.Add(colEliminar);
        }

        private void ActualizarTabla()
        {
            gridMesas.Rows.Clear();
            foreach (var m in listaMesas)
            {
                gridMesas.Rows.Add($"Mesa {m.Id}", m.Capacidad, m.Estado, "Editar", "Eliminar");
            }
        }

        private void gridMesas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string accion = gridMesas.Columns[e.ColumnIndex].HeaderText;

                if (accion == "Editar")
                {
                    Mesa mesaSeleccionada = listaMesas[e.RowIndex];
                    Agregar_Editar_MesaView frm = new Agregar_Editar_MesaView(mesaSeleccionada);
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        listaMesas[e.RowIndex] = frm.MesaCreada;
                        ActualizarTabla();
                    }
                }
                else if (accion == "Eliminar")
                {
                    listaMesas.RemoveAt(e.RowIndex);
                    MessageBox.Show("Mesa eliminada correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarTabla();
                }
            }
        }

        private void btnAgregarMesa_Click_1(object sender, EventArgs e)
        {

        }
    }
}
