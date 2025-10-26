namespace MVP_Restaurante_EF.Views
{
    partial class MesasView
    {
        private System.ComponentModel.IContainer components = null;

        private Guna.UI2.WinForms.Guna2Elipse elipseForm;
        private Guna.UI2.WinForms.Guna2ShadowForm shadowForm;

        private Guna.UI2.WinForms.Guna2Button btnVolver;
        private System.Windows.Forms.Label lblTitulo;

        private Guna.UI2.WinForms.Guna2ShadowPanel panelCard;
        private System.Windows.Forms.Label lblSeccion;
        private Guna.UI2.WinForms.Guna2GradientButton btnAgregarMesa;
        private Guna.UI2.WinForms.Guna2DataGridView gridMesas;

        private System.Windows.Forms.DataGridViewTextBoxColumn colIdMesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCapacidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
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
            this.lblSeccion = new System.Windows.Forms.Label();
            this.btnAgregarMesa = new Guna.UI2.WinForms.Guna2GradientButton();
            this.gridMesas = new Guna.UI2.WinForms.Guna2DataGridView();

            this.colIdMesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCapacidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colEliminar = new System.Windows.Forms.DataGridViewButtonColumn();

            // ===== Form =====
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(255, 248, 237);
            this.ClientSize = new System.Drawing.Size(1500, 720);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Padding = new System.Windows.Forms.Padding(16);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Mesas y Horarios";

            this.elipseForm.BorderRadius = 18;
            this.elipseForm.TargetControl = this;
            this.shadowForm.SetShadowForm(this);

            // ===== Botón Volver =====
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
            this.lblTitulo.Size = new System.Drawing.Size(520, 36);
            this.lblTitulo.Text = "Gestión de Mesas y Horarios";

            // ===== Tarjeta contenedora =====
            this.panelCard.BackColor = System.Drawing.Color.Transparent;
            this.panelCard.FillColor = System.Drawing.Color.White;
            this.panelCard.Location = new System.Drawing.Point(32, 96);
            this.panelCard.Name = "panelCard";
            this.panelCard.Radius = 18;
            this.panelCard.ShadowColor = System.Drawing.Color.FromArgb(60, 0, 0, 0);
            this.panelCard.ShadowDepth = 40;
            this.panelCard.ShadowShift = 6;
            this.panelCard.Size = new System.Drawing.Size(1440, 580);

            // ===== Etiqueta "Mesas" =====
            this.lblSeccion.AutoSize = false;
            this.lblSeccion.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblSeccion.ForeColor = System.Drawing.Color.FromArgb(90, 57, 30);
            this.lblSeccion.Location = new System.Drawing.Point(28, 20);
            this.lblSeccion.Name = "lblSeccion";
            this.lblSeccion.Size = new System.Drawing.Size(200, 32);
            this.lblSeccion.Text = "Mesas";

            // ===== Botón Agregar Mesa =====
            this.btnAgregarMesa.Animated = true;
            this.btnAgregarMesa.BorderRadius = 10;
            this.btnAgregarMesa.FillColor = System.Drawing.Color.FromArgb(255, 160, 0);
            this.btnAgregarMesa.FillColor2 = System.Drawing.Color.FromArgb(255, 94, 0);
            this.btnAgregarMesa.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnAgregarMesa.ForeColor = System.Drawing.Color.White;
            this.btnAgregarMesa.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.btnAgregarMesa.Location = new System.Drawing.Point(1200, 16);
            this.btnAgregarMesa.Name = "btnAgregarMesa";
            this.btnAgregarMesa.Size = new System.Drawing.Size(220, 44);
            this.btnAgregarMesa.Text = "  +  Agregar Mesa";

            // ===== Grid =====
            this.gridMesas.AllowUserToAddRows = false;
            this.gridMesas.AllowUserToDeleteRows = false;
            this.gridMesas.AllowUserToResizeRows = false;
            this.gridMesas.BackgroundColor = System.Drawing.Color.White;
            this.gridMesas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridMesas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridMesas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridMesas.EnableHeadersVisualStyles = false;
            this.gridMesas.GridColor = System.Drawing.Color.FromArgb(245, 238, 220);
            this.gridMesas.Location = new System.Drawing.Point(32, 88);
            this.gridMesas.MultiSelect = false;
            this.gridMesas.Name = "gridMesas";
            this.gridMesas.ReadOnly = true;
            this.gridMesas.RowHeadersVisible = false;
            this.gridMesas.RowTemplate.Height = 44;
            this.gridMesas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridMesas.Size = new System.Drawing.Size(1388, 468);

            // Encabezado
            this.gridMesas.ColumnHeadersHeight = 44;
            this.gridMesas.ColumnHeadersDefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.gridMesas.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 247, 225);
            this.gridMesas.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(90, 57, 30);
            this.gridMesas.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.gridMesas.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(255, 247, 225);
            this.gridMesas.ColumnHeadersDefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(90, 57, 30);

            // Celdas
            this.gridMesas.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.gridMesas.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.gridMesas.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.gridMesas.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gridMesas.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(255, 244, 230);
            this.gridMesas.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(60, 60, 60);

            // Líneas
            this.gridMesas.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(253, 250, 245);

            // ===== Columnas =====
            this.colIdMesa.HeaderText = "ID Mesa";
            this.colIdMesa.Name = "colIdMesa";
            this.colIdMesa.MinimumWidth = 120;
            this.colIdMesa.ReadOnly = true;
            this.colIdMesa.Width = 240;

            this.colCapacidad.HeaderText = "Capacidad";
            this.colCapacidad.Name = "colCapacidad";
            this.colCapacidad.MinimumWidth = 120;
            this.colCapacidad.ReadOnly = true;
            this.colCapacidad.Width = 320;

            this.colEstado.HeaderText = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.MinimumWidth = 120;
            this.colEstado.ReadOnly = true;
            this.colEstado.Width = 420;

            this.colEditar.HeaderText = "Acciones";
            this.colEditar.Name = "colEditar";
            this.colEditar.ReadOnly = true;
            this.colEditar.Text = "✏️";
            this.colEditar.UseColumnTextForButtonValue = true;
            this.colEditar.Width = 120;

            this.colEliminar.HeaderText = "";
            this.colEliminar.Name = "colEliminar";
            this.colEliminar.ReadOnly = true;
            this.colEliminar.Text = "🗑️";
            this.colEliminar.UseColumnTextForButtonValue = true;
            this.colEliminar.Width = 100;

            this.gridMesas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colIdMesa, this.colCapacidad, this.colEstado, this.colEditar, this.colEliminar
            });

            // ===== Ensamblado de la tarjeta =====
            this.panelCard.Controls.Add(this.lblSeccion);
            this.panelCard.Controls.Add(this.btnAgregarMesa);
            this.panelCard.Controls.Add(this.gridMesas);

            // ===== Ensamblado del Form =====
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.panelCard);
        }
        #endregion
    }
}