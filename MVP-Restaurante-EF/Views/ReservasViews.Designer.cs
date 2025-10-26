namespace MVP_Restaurante_EF.Views
{
    partial class ReservasViews
    {
        private System.ComponentModel.IContainer components = null;

        private Guna.UI2.WinForms.Guna2Elipse elipseForm;
        private Guna.UI2.WinForms.Guna2ShadowForm shadowForm;

        private Guna.UI2.WinForms.Guna2Button btnVolver;
        private System.Windows.Forms.Label lblTitulo;

        // Panel Izquierdo (Nueva Reserva)
        private Guna.UI2.WinForms.Guna2ShadowPanel cardNuevaReserva;
        private Guna.UI2.WinForms.Guna2GradientCircleButton iconNuevaReserva;
        private System.Windows.Forms.Label lblNuevaReserva;

        private System.Windows.Forms.Label lblCliente;
        private Guna.UI2.WinForms.Guna2ComboBox cboCliente;

        private System.Windows.Forms.Label lblMesa;
        private Guna.UI2.WinForms.Guna2ComboBox cboMesa;

        private System.Windows.Forms.Label lblFecha;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFecha;

        private System.Windows.Forms.Label lblHora;
        private Guna.UI2.WinForms.Guna2TextBox txtHora;

        private System.Windows.Forms.Label lblDuracion;
        private Guna.UI2.WinForms.Guna2TextBox txtDuracion;

        private Guna.UI2.WinForms.Guna2GradientButton btnConfirmar;

        // Panel Derecho (Reservas Activas)
        private Guna.UI2.WinForms.Guna2ShadowPanel cardReservasActivas;
        private System.Windows.Forms.Label lblReservasActivas;
        private Guna.UI2.WinForms.Guna2Panel tarjetaActiva;
        private System.Windows.Forms.Label lblActivaNombre;
        private Guna.UI2.WinForms.Guna2Button badgeConfirmada;
        private System.Windows.Forms.Label lblActivaMesa;
        private System.Windows.Forms.Label lblActivaFecha;
        private System.Windows.Forms.Label lblActivaHora;
        private System.Windows.Forms.Label lblActivaPersonas;
        private System.Windows.Forms.Label lblActivaDuracion;
        private Guna.UI2.WinForms.Guna2Button btnCancelarReserva;

        // Panel Inferior (Historial)
        private Guna.UI2.WinForms.Guna2ShadowPanel cardHistorial;
        private System.Windows.Forms.Label lblHistorial;
        private Guna.UI2.WinForms.Guna2DataGridView gridHistorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHMesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHDuracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHEstado;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.elipseForm = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.shadowForm = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.btnVolver = new Guna.UI2.WinForms.Guna2Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cardNuevaReserva = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.iconNuevaReserva = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.lblNuevaReserva = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.cboCliente = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblMesa = new System.Windows.Forms.Label();
            this.cboMesa = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblHora = new System.Windows.Forms.Label();
            this.txtHora = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.txtDuracion = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnConfirmar = new Guna.UI2.WinForms.Guna2GradientButton();
            this.cardReservasActivas = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblReservasActivas = new System.Windows.Forms.Label();
            this.tarjetaActiva = new Guna.UI2.WinForms.Guna2Panel();
            this.lblActivaNombre = new System.Windows.Forms.Label();
            this.badgeConfirmada = new Guna.UI2.WinForms.Guna2Button();
            this.lblActivaMesa = new System.Windows.Forms.Label();
            this.lblActivaFecha = new System.Windows.Forms.Label();
            this.lblActivaHora = new System.Windows.Forms.Label();
            this.lblActivaPersonas = new System.Windows.Forms.Label();
            this.lblActivaDuracion = new System.Windows.Forms.Label();
            this.btnCancelarReserva = new Guna.UI2.WinForms.Guna2Button();
            this.cardHistorial = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblHistorial = new System.Windows.Forms.Label();
            this.gridHistorial = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colHCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHMesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHDuracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardNuevaReserva.SuspendLayout();
            this.cardReservasActivas.SuspendLayout();
            this.tarjetaActiva.SuspendLayout();
            this.cardHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridHistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // elipseForm
            // 
            this.elipseForm.BorderRadius = 18;
            this.elipseForm.TargetControl = this;
            // 
            // shadowForm
            // 
            this.shadowForm.TargetForm = this;
            // 
            // btnVolver
            // 
            this.btnVolver.Animated = true;
            this.btnVolver.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(64)))));
            this.btnVolver.BorderRadius = 12;
            this.btnVolver.BorderThickness = 1;
            this.btnVolver.FillColor = System.Drawing.Color.White;
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnVolver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(74)))), ((int)(((byte)(15)))));
            this.btnVolver.Location = new System.Drawing.Point(40, 28);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(150, 44);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "  ←  Volver";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(57)))), ((int)(((byte)(33)))));
            this.lblTitulo.Location = new System.Drawing.Point(210, 32);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(400, 36);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Asignación de Reservas";
            // 
            // cardNuevaReserva
            // 
            this.cardNuevaReserva.BackColor = System.Drawing.Color.Transparent;
            this.cardNuevaReserva.Controls.Add(this.iconNuevaReserva);
            this.cardNuevaReserva.Controls.Add(this.lblNuevaReserva);
            this.cardNuevaReserva.Controls.Add(this.lblCliente);
            this.cardNuevaReserva.Controls.Add(this.cboCliente);
            this.cardNuevaReserva.Controls.Add(this.lblMesa);
            this.cardNuevaReserva.Controls.Add(this.cboMesa);
            this.cardNuevaReserva.Controls.Add(this.lblFecha);
            this.cardNuevaReserva.Controls.Add(this.dtpFecha);
            this.cardNuevaReserva.Controls.Add(this.lblHora);
            this.cardNuevaReserva.Controls.Add(this.txtHora);
            this.cardNuevaReserva.Controls.Add(this.lblDuracion);
            this.cardNuevaReserva.Controls.Add(this.txtDuracion);
            this.cardNuevaReserva.Controls.Add(this.btnConfirmar);
            this.cardNuevaReserva.FillColor = System.Drawing.Color.White;
            this.cardNuevaReserva.Location = new System.Drawing.Point(24, 96);
            this.cardNuevaReserva.Name = "cardNuevaReserva";
            this.cardNuevaReserva.Radius = 18;
            this.cardNuevaReserva.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardNuevaReserva.ShadowDepth = 40;
            this.cardNuevaReserva.ShadowShift = 6;
            this.cardNuevaReserva.Size = new System.Drawing.Size(720, 540);
            this.cardNuevaReserva.TabIndex = 2;
            // 
            // iconNuevaReserva
            // 
            this.iconNuevaReserva.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.iconNuevaReserva.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(70)))));
            this.iconNuevaReserva.Font = new System.Drawing.Font("Segoe UI Emoji", 20F, System.Drawing.FontStyle.Bold);
            this.iconNuevaReserva.ForeColor = System.Drawing.Color.White;
            this.iconNuevaReserva.Location = new System.Drawing.Point(28, 24);
            this.iconNuevaReserva.Name = "iconNuevaReserva";
            this.iconNuevaReserva.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.iconNuevaReserva.Size = new System.Drawing.Size(56, 56);
            this.iconNuevaReserva.TabIndex = 0;
            this.iconNuevaReserva.Text = "🍽️";
            // 
            // lblNuevaReserva
            // 
            this.lblNuevaReserva.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblNuevaReserva.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(57)))), ((int)(((byte)(30)))));
            this.lblNuevaReserva.Location = new System.Drawing.Point(92, 34);
            this.lblNuevaReserva.Name = "lblNuevaReserva";
            this.lblNuevaReserva.Size = new System.Drawing.Size(220, 32);
            this.lblNuevaReserva.TabIndex = 1;
            this.lblNuevaReserva.Text = "Nueva Reserva";
            // 
            // lblCliente
            // 
            this.lblCliente.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(57)))), ((int)(((byte)(30)))));
            this.lblCliente.Location = new System.Drawing.Point(28, 96);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(200, 24);
            this.lblCliente.TabIndex = 2;
            this.lblCliente.Text = "Cliente";
            // 
            // cboCliente
            // 
            this.cboCliente.BackColor = System.Drawing.Color.Transparent;
            this.cboCliente.BorderRadius = 12;
            this.cboCliente.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCliente.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(246)))), ((int)(((byte)(243)))));
            this.cboCliente.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(64)))));
            this.cboCliente.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(64)))));
            this.cboCliente.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cboCliente.ItemHeight = 36;
            this.cboCliente.Location = new System.Drawing.Point(32, 124);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(656, 42);
            this.cboCliente.TabIndex = 3;
            // 
            // lblMesa
            // 
            this.lblMesa.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblMesa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(57)))), ((int)(((byte)(30)))));
            this.lblMesa.Location = new System.Drawing.Point(28, 176);
            this.lblMesa.Name = "lblMesa";
            this.lblMesa.Size = new System.Drawing.Size(200, 24);
            this.lblMesa.TabIndex = 4;
            this.lblMesa.Text = "Mesa";
            // 
            // cboMesa
            // 
            this.cboMesa.BackColor = System.Drawing.Color.Transparent;
            this.cboMesa.BorderRadius = 12;
            this.cboMesa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboMesa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMesa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(246)))), ((int)(((byte)(243)))));
            this.cboMesa.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(64)))));
            this.cboMesa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(64)))));
            this.cboMesa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboMesa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cboMesa.ItemHeight = 36;
            this.cboMesa.Location = new System.Drawing.Point(32, 204);
            this.cboMesa.Name = "cboMesa";
            this.cboMesa.Size = new System.Drawing.Size(656, 42);
            this.cboMesa.TabIndex = 5;
            // 
            // lblFecha
            // 
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(57)))), ((int)(((byte)(30)))));
            this.lblFecha.Location = new System.Drawing.Point(28, 256);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(200, 24);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "Fecha";
            // 
            // dtpFecha
            // 
            this.dtpFecha.BorderRadius = 12;
            this.dtpFecha.Checked = true;
            this.dtpFecha.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(246)))), ((int)(((byte)(243)))));
            this.dtpFecha.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(64)))));
            this.dtpFecha.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(32, 284);
            this.dtpFecha.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFecha.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(656, 44);
            this.dtpFecha.TabIndex = 7;
            this.dtpFecha.Value = new System.DateTime(2025, 10, 25, 21, 33, 27, 281);
            // 
            // lblHora
            // 
            this.lblHora.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(57)))), ((int)(((byte)(30)))));
            this.lblHora.Location = new System.Drawing.Point(28, 336);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(200, 24);
            this.lblHora.TabIndex = 8;
            this.lblHora.Text = "Hora";
            // 
            // txtHora
            // 
            this.txtHora.BorderRadius = 12;
            this.txtHora.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHora.DefaultText = "";
            this.txtHora.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(246)))), ((int)(((byte)(243)))));
            this.txtHora.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(64)))));
            this.txtHora.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtHora.Location = new System.Drawing.Point(32, 364);
            this.txtHora.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtHora.Name = "txtHora";
            this.txtHora.PlaceholderText = "--:-- --";
            this.txtHora.SelectedText = "";
            this.txtHora.Size = new System.Drawing.Size(656, 44);
            this.txtHora.TabIndex = 9;
            // 
            // lblDuracion
            // 
            this.lblDuracion.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblDuracion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(57)))), ((int)(((byte)(30)))));
            this.lblDuracion.Location = new System.Drawing.Point(28, 416);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(200, 24);
            this.lblDuracion.TabIndex = 10;
            this.lblDuracion.Text = "Duración (horas)";
            // 
            // txtDuracion
            // 
            this.txtDuracion.BorderRadius = 12;
            this.txtDuracion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDuracion.DefaultText = "";
            this.txtDuracion.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(246)))), ((int)(((byte)(243)))));
            this.txtDuracion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(64)))));
            this.txtDuracion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDuracion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtDuracion.Location = new System.Drawing.Point(32, 444);
            this.txtDuracion.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.PlaceholderText = "2";
            this.txtDuracion.SelectedText = "";
            this.txtDuracion.Size = new System.Drawing.Size(656, 44);
            this.txtDuracion.TabIndex = 11;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Animated = true;
            this.btnConfirmar.BorderRadius = 10;
            this.btnConfirmar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(70)))));
            this.btnConfirmar.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(70)))));
            this.btnConfirmar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(32, 500);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(656, 44);
            this.btnConfirmar.TabIndex = 12;
            this.btnConfirmar.Text = "   ✓   Confirmar Reserva";
            // 
            // cardReservasActivas
            // 
            this.cardReservasActivas.BackColor = System.Drawing.Color.Transparent;
            this.cardReservasActivas.Controls.Add(this.lblReservasActivas);
            this.cardReservasActivas.Controls.Add(this.tarjetaActiva);
            this.cardReservasActivas.FillColor = System.Drawing.Color.White;
            this.cardReservasActivas.Location = new System.Drawing.Point(768, 96);
            this.cardReservasActivas.Name = "cardReservasActivas";
            this.cardReservasActivas.Radius = 18;
            this.cardReservasActivas.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardReservasActivas.ShadowDepth = 40;
            this.cardReservasActivas.ShadowShift = 6;
            this.cardReservasActivas.Size = new System.Drawing.Size(708, 540);
            this.cardReservasActivas.TabIndex = 3;
            // 
            // lblReservasActivas
            // 
            this.lblReservasActivas.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Bold);
            this.lblReservasActivas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(57)))), ((int)(((byte)(30)))));
            this.lblReservasActivas.Location = new System.Drawing.Point(28, 24);
            this.lblReservasActivas.Name = "lblReservasActivas";
            this.lblReservasActivas.Size = new System.Drawing.Size(220, 28);
            this.lblReservasActivas.TabIndex = 0;
            this.lblReservasActivas.Text = "Reservas Activas";
            // 
            // tarjetaActiva
            // 
            this.tarjetaActiva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(240)))));
            this.tarjetaActiva.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(185)))));
            this.tarjetaActiva.BorderRadius = 12;
            this.tarjetaActiva.BorderThickness = 1;
            this.tarjetaActiva.Controls.Add(this.lblActivaNombre);
            this.tarjetaActiva.Controls.Add(this.badgeConfirmada);
            this.tarjetaActiva.Controls.Add(this.lblActivaMesa);
            this.tarjetaActiva.Controls.Add(this.lblActivaFecha);
            this.tarjetaActiva.Controls.Add(this.lblActivaHora);
            this.tarjetaActiva.Controls.Add(this.lblActivaPersonas);
            this.tarjetaActiva.Controls.Add(this.lblActivaDuracion);
            this.tarjetaActiva.Controls.Add(this.btnCancelarReserva);
            this.tarjetaActiva.Location = new System.Drawing.Point(24, 64);
            this.tarjetaActiva.Name = "tarjetaActiva";
            this.tarjetaActiva.Size = new System.Drawing.Size(660, 300);
            this.tarjetaActiva.TabIndex = 1;
            // 
            // lblActivaNombre
            // 
            this.lblActivaNombre.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblActivaNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(57)))), ((int)(((byte)(30)))));
            this.lblActivaNombre.Location = new System.Drawing.Point(24, 16);
            this.lblActivaNombre.Name = "lblActivaNombre";
            this.lblActivaNombre.Size = new System.Drawing.Size(300, 30);
            this.lblActivaNombre.TabIndex = 0;
            this.lblActivaNombre.Text = "Ana Martínez";
            // 
            // badgeConfirmada
            // 
            this.badgeConfirmada.BorderRadius = 10;
            this.badgeConfirmada.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(194)))), ((int)(((byte)(129)))));
            this.badgeConfirmada.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.badgeConfirmada.ForeColor = System.Drawing.Color.White;
            this.badgeConfirmada.Location = new System.Drawing.Point(520, 14);
            this.badgeConfirmada.Name = "badgeConfirmada";
            this.badgeConfirmada.Size = new System.Drawing.Size(116, 28);
            this.badgeConfirmada.TabIndex = 1;
            this.badgeConfirmada.Text = "Confirmada";
            // 
            // lblActivaMesa
            // 
            this.lblActivaMesa.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.lblActivaMesa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(90)))), ((int)(((byte)(60)))));
            this.lblActivaMesa.Location = new System.Drawing.Point(24, 56);
            this.lblActivaMesa.Name = "lblActivaMesa";
            this.lblActivaMesa.Size = new System.Drawing.Size(200, 24);
            this.lblActivaMesa.TabIndex = 2;
            this.lblActivaMesa.Text = "Mesa 3";
            // 
            // lblActivaFecha
            // 
            this.lblActivaFecha.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.lblActivaFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(90)))), ((int)(((byte)(60)))));
            this.lblActivaFecha.Location = new System.Drawing.Point(24, 92);
            this.lblActivaFecha.Name = "lblActivaFecha";
            this.lblActivaFecha.Size = new System.Drawing.Size(260, 24);
            this.lblActivaFecha.TabIndex = 3;
            this.lblActivaFecha.Text = "📅  2025-10-26";
            // 
            // lblActivaHora
            // 
            this.lblActivaHora.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.lblActivaHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(90)))), ((int)(((byte)(60)))));
            this.lblActivaHora.Location = new System.Drawing.Point(360, 92);
            this.lblActivaHora.Name = "lblActivaHora";
            this.lblActivaHora.Size = new System.Drawing.Size(220, 24);
            this.lblActivaHora.TabIndex = 4;
            this.lblActivaHora.Text = "🕒  19:00";
            // 
            // lblActivaPersonas
            // 
            this.lblActivaPersonas.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.lblActivaPersonas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(90)))), ((int)(((byte)(60)))));
            this.lblActivaPersonas.Location = new System.Drawing.Point(24, 124);
            this.lblActivaPersonas.Name = "lblActivaPersonas";
            this.lblActivaPersonas.Size = new System.Drawing.Size(220, 24);
            this.lblActivaPersonas.TabIndex = 5;
            this.lblActivaPersonas.Text = "👥  6 personas";
            // 
            // lblActivaDuracion
            // 
            this.lblActivaDuracion.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.lblActivaDuracion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(90)))), ((int)(((byte)(60)))));
            this.lblActivaDuracion.Location = new System.Drawing.Point(360, 124);
            this.lblActivaDuracion.Name = "lblActivaDuracion";
            this.lblActivaDuracion.Size = new System.Drawing.Size(220, 24);
            this.lblActivaDuracion.TabIndex = 6;
            this.lblActivaDuracion.Text = "⏱️  2h";
            // 
            // btnCancelarReserva
            // 
            this.btnCancelarReserva.Animated = true;
            this.btnCancelarReserva.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btnCancelarReserva.BorderRadius = 10;
            this.btnCancelarReserva.BorderThickness = 1;
            this.btnCancelarReserva.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btnCancelarReserva.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancelarReserva.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnCancelarReserva.Location = new System.Drawing.Point(24, 170);
            this.btnCancelarReserva.Name = "btnCancelarReserva";
            this.btnCancelarReserva.Size = new System.Drawing.Size(612, 40);
            this.btnCancelarReserva.TabIndex = 7;
            this.btnCancelarReserva.Text = "Cancelar Reserva";
            // 
            // cardHistorial
            // 
            this.cardHistorial.BackColor = System.Drawing.Color.Transparent;
            this.cardHistorial.Controls.Add(this.lblHistorial);
            this.cardHistorial.Controls.Add(this.gridHistorial);
            this.cardHistorial.FillColor = System.Drawing.Color.White;
            this.cardHistorial.Location = new System.Drawing.Point(24, 660);
            this.cardHistorial.Name = "cardHistorial";
            this.cardHistorial.Radius = 18;
            this.cardHistorial.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardHistorial.ShadowDepth = 40;
            this.cardHistorial.ShadowShift = 6;
            this.cardHistorial.Size = new System.Drawing.Size(1452, 260);
            this.cardHistorial.TabIndex = 4;
            // 
            // lblHistorial
            // 
            this.lblHistorial.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblHistorial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(57)))), ((int)(((byte)(30)))));
            this.lblHistorial.Location = new System.Drawing.Point(28, 20);
            this.lblHistorial.Name = "lblHistorial";
            this.lblHistorial.Size = new System.Drawing.Size(250, 28);
            this.lblHistorial.TabIndex = 0;
            this.lblHistorial.Text = "Historial de Reservas";
            // 
            // gridHistorial
            // 
            this.gridHistorial.AllowUserToAddRows = false;
            this.gridHistorial.AllowUserToDeleteRows = false;
            this.gridHistorial.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(250)))), ((int)(((byte)(245)))));
            this.gridHistorial.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(57)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridHistorial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridHistorial.ColumnHeadersHeight = 44;
            this.gridHistorial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colHCliente,
            this.colHMesa,
            this.colHFecha,
            this.colHHora,
            this.colHDuracion,
            this.colHEstado});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridHistorial.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridHistorial.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(238)))), ((int)(((byte)(220)))));
            this.gridHistorial.Location = new System.Drawing.Point(28, 64);
            this.gridHistorial.MultiSelect = false;
            this.gridHistorial.Name = "gridHistorial";
            this.gridHistorial.ReadOnly = true;
            this.gridHistorial.RowHeadersVisible = false;
            this.gridHistorial.RowHeadersWidth = 51;
            this.gridHistorial.RowTemplate.Height = 44;
            this.gridHistorial.Size = new System.Drawing.Size(1396, 172);
            this.gridHistorial.TabIndex = 1;
            this.gridHistorial.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(250)))), ((int)(((byte)(245)))));
            this.gridHistorial.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridHistorial.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridHistorial.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridHistorial.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridHistorial.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridHistorial.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(238)))), ((int)(((byte)(220)))));
            this.gridHistorial.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(225)))));
            this.gridHistorial.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridHistorial.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.gridHistorial.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(57)))), ((int)(((byte)(30)))));
            this.gridHistorial.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridHistorial.ThemeStyle.HeaderStyle.Height = 44;
            this.gridHistorial.ThemeStyle.ReadOnly = true;
            this.gridHistorial.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridHistorial.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridHistorial.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gridHistorial.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.gridHistorial.ThemeStyle.RowsStyle.Height = 44;
            this.gridHistorial.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(230)))));
            this.gridHistorial.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            // 
            // colHCliente
            // 
            this.colHCliente.HeaderText = "Cliente";
            this.colHCliente.MinimumWidth = 120;
            this.colHCliente.Name = "colHCliente";
            this.colHCliente.ReadOnly = true;
            // 
            // colHMesa
            // 
            this.colHMesa.HeaderText = "Mesa";
            this.colHMesa.MinimumWidth = 80;
            this.colHMesa.Name = "colHMesa";
            this.colHMesa.ReadOnly = true;
            // 
            // colHFecha
            // 
            this.colHFecha.HeaderText = "Fecha";
            this.colHFecha.MinimumWidth = 120;
            this.colHFecha.Name = "colHFecha";
            this.colHFecha.ReadOnly = true;
            // 
            // colHHora
            // 
            this.colHHora.HeaderText = "Hora";
            this.colHHora.MinimumWidth = 80;
            this.colHHora.Name = "colHHora";
            this.colHHora.ReadOnly = true;
            // 
            // colHDuracion
            // 
            this.colHDuracion.HeaderText = "Duración";
            this.colHDuracion.MinimumWidth = 80;
            this.colHDuracion.Name = "colHDuracion";
            this.colHDuracion.ReadOnly = true;
            // 
            // colHEstado
            // 
            this.colHEstado.HeaderText = "Estado";
            this.colHEstado.MinimumWidth = 100;
            this.colHEstado.Name = "colHEstado";
            this.colHEstado.ReadOnly = true;
            // 
            // ReservasViews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(1500, 960);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.cardNuevaReserva);
            this.Controls.Add(this.cardReservasActivas);
            this.Controls.Add(this.cardHistorial);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReservasViews";
            this.Padding = new System.Windows.Forms.Padding(16);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignación de Reservas";
            this.cardNuevaReserva.ResumeLayout(false);
            this.cardReservasActivas.ResumeLayout(false);
            this.tarjetaActiva.ResumeLayout(false);
            this.cardHistorial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridHistorial)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
    }
}