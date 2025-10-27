namespace MVP_Restaurante_EF.Views
{
    partial class Reservaciones
    {
        private System.ComponentModel.IContainer components = null;

        private Guna.UI2.WinForms.Guna2Elipse elipseForm;
        private Guna.UI2.WinForms.Guna2ShadowForm shadowForm;

        private Guna.UI2.WinForms.Guna2Button btnVolver;
        private System.Windows.Forms.Label lbltittle;

        private Guna.UI2.WinForms.Guna2ShadowPanel panelCard;
        private System.Windows.Forms.Label lblSeccion;
        private Guna.UI2.WinForms.Guna2GradientButton btnAgregarReservas;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.elipseForm = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.shadowForm = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.btnVolver = new Guna.UI2.WinForms.Guna2Button();
            this.lbltittle = new System.Windows.Forms.Label();
            this.panelCard = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblSeccion = new System.Windows.Forms.Label();
            this.btnAgregarReservas = new Guna.UI2.WinForms.Guna2GradientButton();
            this.gridReservas = new System.Windows.Forms.DataGridView();
            this.panelCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridReservas)).BeginInit();
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
            this.btnVolver.Location = new System.Drawing.Point(40, 32);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(150, 44);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "  ←   Volver";
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lbltittle
            // 
            this.lbltittle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lbltittle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(57)))), ((int)(((byte)(33)))));
            this.lbltittle.Location = new System.Drawing.Point(210, 36);
            this.lbltittle.Name = "lbltittle";
            this.lbltittle.Size = new System.Drawing.Size(520, 36);
            this.lbltittle.TabIndex = 1;
            this.lbltittle.Text = "Gestión de Reservas";
            // 
            // panelCard
            // 
            this.panelCard.BackColor = System.Drawing.Color.Transparent;
            this.panelCard.Controls.Add(this.lblSeccion);
            this.panelCard.Controls.Add(this.btnAgregarReservas);
            this.panelCard.Controls.Add(this.gridReservas);
            this.panelCard.FillColor = System.Drawing.Color.White;
            this.panelCard.Location = new System.Drawing.Point(40, 97);
            this.panelCard.Name = "panelCard";
            this.panelCard.Radius = 18;
            this.panelCard.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelCard.ShadowDepth = 40;
            this.panelCard.ShadowShift = 6;
            this.panelCard.Size = new System.Drawing.Size(1143, 454);
            this.panelCard.TabIndex = 2;
            // 
            // lblSeccion
            // 
            this.lblSeccion.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblSeccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(57)))), ((int)(((byte)(30)))));
            this.lblSeccion.Location = new System.Drawing.Point(28, 20);
            this.lblSeccion.Name = "lblSeccion";
            this.lblSeccion.Size = new System.Drawing.Size(200, 32);
            this.lblSeccion.TabIndex = 0;
            this.lblSeccion.Text = "Reservas";
            // 
            // btnAgregarReservas
            // 
            this.btnAgregarReservas.Animated = true;
            this.btnAgregarReservas.BorderRadius = 10;
            this.btnAgregarReservas.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(0)))));
            this.btnAgregarReservas.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(94)))), ((int)(((byte)(0)))));
            this.btnAgregarReservas.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnAgregarReservas.ForeColor = System.Drawing.Color.White;
            this.btnAgregarReservas.Location = new System.Drawing.Point(865, 20);
            this.btnAgregarReservas.Name = "btnAgregarReservas";
            this.btnAgregarReservas.Size = new System.Drawing.Size(236, 44);
            this.btnAgregarReservas.TabIndex = 1;
            this.btnAgregarReservas.Text = "  +  Agregar Reserva";
            this.btnAgregarReservas.Click += new System.EventHandler(this.btnAgregarReservas_Click);
            // 
            // gridReservas
            // 
            this.gridReservas.AllowUserToAddRows = false;
            this.gridReservas.AllowUserToDeleteRows = false;
            this.gridReservas.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(250)))), ((int)(((byte)(245)))));
            this.gridReservas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridReservas.BackgroundColor = System.Drawing.Color.White;
            this.gridReservas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridReservas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridReservas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(57)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(57)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridReservas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gridReservas.ColumnHeadersHeight = 44;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridReservas.DefaultCellStyle = dataGridViewCellStyle6;
            this.gridReservas.EnableHeadersVisualStyles = false;
            this.gridReservas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(238)))), ((int)(((byte)(220)))));
            this.gridReservas.Location = new System.Drawing.Point(52, 87);
            this.gridReservas.MultiSelect = false;
            this.gridReservas.Name = "gridReservas";
            this.gridReservas.ReadOnly = true;
            this.gridReservas.RowHeadersVisible = false;
            this.gridReservas.RowHeadersWidth = 62;
            this.gridReservas.RowTemplate.Height = 44;
            this.gridReservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridReservas.Size = new System.Drawing.Size(1049, 331);
            this.gridReservas.TabIndex = 2;
            // 
            // Reservaciones
            // 
            this.ClientSize = new System.Drawing.Size(1234, 599);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lbltittle);
            this.Controls.Add(this.panelCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Reservaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Disponibilidad_Load);
            this.panelCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridReservas)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.DataGridView gridReservas;
    }
}
