namespace MVP_Restaurante_EF.Views
{
    partial class RegistroClientesView
    {
        private System.ComponentModel.IContainer components = null;

        private Guna.UI2.WinForms.Guna2Elipse elipseForm;
        private Guna.UI2.WinForms.Guna2ShadowForm shadowForm;

        private Guna.UI2.WinForms.Guna2Button btnVolver;
        private System.Windows.Forms.Label lblTitulo;

        private Guna.UI2.WinForms.Guna2ShadowPanel panelCard;
        private Guna.UI2.WinForms.Guna2GradientButton btnNuevoCliente;
        private Guna.UI2.WinForms.Guna2DataGridView gridClientes;

        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPersonas;
        private System.Windows.Forms.DataGridViewButtonColumn colEditar;
        private System.Windows.Forms.DataGridViewButtonColumn colEliminar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.elipseForm = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.shadowForm = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);

            this.btnVolver = new Guna.UI2.WinForms.Guna2Button();
            this.lblTitulo = new System.Windows.Forms.Label();

            this.panelCard = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.btnNuevoCliente = new Guna.UI2.WinForms.Guna2GradientButton();
            this.gridClientes = new Guna.UI2.WinForms.Guna2DataGridView();

            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPersonas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colEliminar = new System.Windows.Forms.DataGridViewButtonColumn();

            // ===== Form =====
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(255, 248, 237);
            this.ClientSize = new System.Drawing.Size(1500, 760);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Padding = new System.Windows.Forms.Padding(16);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Clientes";

            this.elipseForm.BorderRadius = 18;
            this.elipseForm.TargetControl = this;
            this.shadowForm.SetShadowForm(this);

            // ===== Volver =====
            this.btnVolver.Animated = true;
            this.btnVolver.BorderColor = System.Drawing.Color.FromArgb(255, 170, 64);
            this.btnVolver.BorderRadius = 12;
            this.btnVolver.BorderThickness = 1;
            this.btnVolver.FillColor = System.Drawing.Color.White;
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnVolver.ForeColor = System.Drawing.Color.FromArgb(139, 74, 15);
            this.btnVolver.Location = new System.Drawing.Point(40, 32);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(150, 44);
            this.btnVolver.Text = "  ←   Volver";

            // ===== Título =====
            this.lblTitulo.AutoSize = false;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(94, 57, 33);
            this.lblTitulo.Location = new System.Drawing.Point(210, 36);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(360, 36);
            this.lblTitulo.Text = "Registro de Clientes";

            // ===== Card =====
            this.panelCard.BackColor = System.Drawing.Color.Transparent;
            this.panelCard.FillColor = System.Drawing.Color.White;
            this.panelCard.Location = new System.Drawing.Point(32, 96);
            this.panelCard.Name = "panelCard";
            this.panelCard.Radius = 18;
            this.panelCard.ShadowColor = System.Drawing.Color.FromArgb(60, 0, 0, 0);
            this.panelCard.ShadowDepth = 40;
            this.panelCard.ShadowShift = 6;
            this.panelCard.Size = new System.Drawing.Size(1440, 360);

            // ===== Botón Nuevo Cliente =====
            this.btnNuevoCliente.Animated = true;
            this.btnNuevoCliente.BorderRadius = 10;
            this.btnNuevoCliente.FillColor = System.Drawing.Color.FromArgb(255, 160, 0);
            this.btnNuevoCliente.FillColor2 = System.Drawing.Color.FromArgb(255, 94, 0);
            this.btnNuevoCliente.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnNuevoCliente.ForeColor = System.Drawing.Color.White;
            this.btnNuevoCliente.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.btnNuevoCliente.Location = new System.Drawing.Point(1200, 16);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(220, 44);
            this.btnNuevoCliente.Text = "  +  Nuevo Cliente";

            // ===== Grid =====
            this.gridClientes.AllowUserToAddRows = false;
            this.gridClientes.AllowUserToDeleteRows = false;
            this.gridClientes.AllowUserToResizeRows = false;
            this.gridClientes.BackgroundColor = System.Drawing.Color.White;
            this.gridClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridClientes.EnableHeadersVisualStyles = false;
            this.gridClientes.GridColor = System.Drawing.Color.FromArgb(245, 238, 220);
            this.gridClientes.Location = new System.Drawing.Point(32, 80);
            this.gridClientes.MultiSelect = false;
            this.gridClientes.Name = "gridClientes";
            this.gridClientes.ReadOnly = true;
            this.gridClientes.RowHeadersVisible = false;
            this.gridClientes.RowTemplate.Height = 48;
            this.gridClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridClientes.Size = new System.Drawing.Size(1388, 256);

            // Encabezado
            this.gridClientes.ColumnHeadersHeight = 46;
            this.gridClientes.ColumnHeadersDefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.gridClientes.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 247, 225);
            this.gridClientes.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(90, 57, 30);
            this.gridClientes.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.gridClientes.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(255, 247, 225);
            this.gridClientes.ColumnHeadersDefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(90, 57, 30);

            // Celdas
            this.gridClientes.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.gridClientes.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.gridClientes.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.gridClientes.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gridClientes.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(255, 244, 230);
            this.gridClientes.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(60, 60, 60);

            // Alternas
            this.gridClientes.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(253, 250, 245);

            // ===== Columnas =====
            this.colNombre.HeaderText = "Nombre Completo";
            this.colNombre.Name = "colNombre";
            this.colNombre.MinimumWidth = 160;
            this.colNombre.ReadOnly = true;
            this.colNombre.Width = 380;

            this.colTelefono.HeaderText = "Teléfono";
            this.colTelefono.Name = "colTelefono";
            this.colTelefono.MinimumWidth = 120;
            this.colTelefono.ReadOnly = true;
            this.colTelefono.Width = 280;

            this.colCorreo.HeaderText = "Correo";
            this.colCorreo.Name = "colCorreo";
            this.colCorreo.MinimumWidth = 160;
            this.colCorreo.ReadOnly = true;
            this.colCorreo.Width = 420;

            this.colPersonas.HeaderText = "Nº Personas";
            this.colPersonas.Name = "colPersonas";
            this.colPersonas.MinimumWidth = 100;
            this.colPersonas.ReadOnly = true;
            this.colPersonas.Width = 160;

            this.colEditar.HeaderText = "Acciones";
            this.colEditar.Name = "colEditar";
            this.colEditar.ReadOnly = true;
            this.colEditar.Text = "✏️";
            this.colEditar.UseColumnTextForButtonValue = true;
            this.colEditar.Width = 100;

            this.colEliminar.HeaderText = "";
            this.colEliminar.Name = "colEliminar";
            this.colEliminar.ReadOnly = true;
            this.colEliminar.Text = "🗑️";
            this.colEliminar.UseColumnTextForButtonValue = true;
            this.colEliminar.Width = 90;

            this.gridClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colNombre, this.colTelefono, this.colCorreo, this.colPersonas, this.colEditar, this.colEliminar
            });

            // ===== Ensamblar Card =====
            this.panelCard.Controls.Add(this.btnNuevoCliente);
            this.panelCard.Controls.Add(this.gridClientes);

            // ===== Ensamblar Form =====
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.panelCard);
        }
        #endregion
    }
}