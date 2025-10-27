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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.panelCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMesas)).BeginInit();
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
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(57)))), ((int)(((byte)(33)))));
            this.lblTitulo.Location = new System.Drawing.Point(210, 36);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(520, 36);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Gestión de Mesas y Horarios";
            // 
            // panelCard
            // 
            this.panelCard.BackColor = System.Drawing.Color.Transparent;
            this.panelCard.Controls.Add(this.btnEliminar);
            this.panelCard.Controls.Add(this.btnEditar);
            this.panelCard.Controls.Add(this.lblSeccion);
            this.panelCard.Controls.Add(this.btnAgregarMesa);
            this.panelCard.Controls.Add(this.gridMesas);
            this.panelCard.FillColor = System.Drawing.Color.White;
            this.panelCard.Location = new System.Drawing.Point(32, 96);
            this.panelCard.Name = "panelCard";
            this.panelCard.Radius = 18;
            this.panelCard.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelCard.ShadowDepth = 40;
            this.panelCard.ShadowShift = 6;
            this.panelCard.Size = new System.Drawing.Size(1440, 580);
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
            this.lblSeccion.Text = "Mesas";
            // 
            // btnAgregarMesa
            // 
            this.btnAgregarMesa.Animated = true;
            this.btnAgregarMesa.BorderRadius = 10;
            this.btnAgregarMesa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(0)))));
            this.btnAgregarMesa.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(94)))), ((int)(((byte)(0)))));
            this.btnAgregarMesa.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnAgregarMesa.ForeColor = System.Drawing.Color.White;
            this.btnAgregarMesa.Location = new System.Drawing.Point(1200, 16);
            this.btnAgregarMesa.Name = "btnAgregarMesa";
            this.btnAgregarMesa.Size = new System.Drawing.Size(220, 44);
            this.btnAgregarMesa.TabIndex = 1;
            this.btnAgregarMesa.Text = "  +  Agregar Mesa";
            this.btnAgregarMesa.Click += new System.EventHandler(this.btnAgregarMesa_Click_1);
            // 
            // gridMesas
            // 
            this.gridMesas.AllowUserToAddRows = false;
            this.gridMesas.AllowUserToDeleteRows = false;
            this.gridMesas.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(250)))), ((int)(((byte)(245)))));
            this.gridMesas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(57)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(57)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridMesas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gridMesas.ColumnHeadersHeight = 44;
            this.gridMesas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdMesa,
            this.colCapacidad,
            this.colEstado,
            this.colEditar,
            this.colEliminar});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridMesas.DefaultCellStyle = dataGridViewCellStyle6;
            this.gridMesas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(238)))), ((int)(((byte)(220)))));
            this.gridMesas.Location = new System.Drawing.Point(32, 88);
            this.gridMesas.MultiSelect = false;
            this.gridMesas.Name = "gridMesas";
            this.gridMesas.ReadOnly = true;
            this.gridMesas.RowHeadersVisible = false;
            this.gridMesas.RowHeadersWidth = 51;
            this.gridMesas.RowTemplate.Height = 44;
            this.gridMesas.Size = new System.Drawing.Size(1388, 468);
            this.gridMesas.TabIndex = 2;
            this.gridMesas.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(250)))), ((int)(((byte)(245)))));
            this.gridMesas.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridMesas.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridMesas.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridMesas.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridMesas.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridMesas.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(238)))), ((int)(((byte)(220)))));
            this.gridMesas.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(225)))));
            this.gridMesas.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridMesas.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.gridMesas.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(57)))), ((int)(((byte)(30)))));
            this.gridMesas.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridMesas.ThemeStyle.HeaderStyle.Height = 44;
            this.gridMesas.ThemeStyle.ReadOnly = true;
            this.gridMesas.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridMesas.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridMesas.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gridMesas.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.gridMesas.ThemeStyle.RowsStyle.Height = 44;
            this.gridMesas.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(230)))));
            this.gridMesas.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            // 
            // colIdMesa
            // 
            this.colIdMesa.HeaderText = "ID Mesa";
            this.colIdMesa.MinimumWidth = 120;
            this.colIdMesa.Name = "colIdMesa";
            this.colIdMesa.ReadOnly = true;
            // 
            // colCapacidad
            // 
            this.colCapacidad.HeaderText = "Capacidad";
            this.colCapacidad.MinimumWidth = 120;
            this.colCapacidad.Name = "colCapacidad";
            this.colCapacidad.ReadOnly = true;
            // 
            // colEstado
            // 
            this.colEstado.HeaderText = "Estado";
            this.colEstado.MinimumWidth = 120;
            this.colEstado.Name = "colEstado";
            this.colEstado.ReadOnly = true;
            // 
            // colEditar
            // 
            this.colEditar.HeaderText = "Acciones";
            this.colEditar.MinimumWidth = 6;
            this.colEditar.Name = "colEditar";
            this.colEditar.ReadOnly = true;
            this.colEditar.Text = "✏️";
            this.colEditar.UseColumnTextForButtonValue = true;
            // 
            // colEliminar
            // 
            this.colEliminar.HeaderText = "";
            this.colEliminar.MinimumWidth = 6;
            this.colEliminar.Name = "colEliminar";
            this.colEliminar.ReadOnly = true;
            this.colEliminar.Text = "🗑️";
            this.colEliminar.UseColumnTextForButtonValue = true;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.SeaShell;
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditar.Location = new System.Drawing.Point(466, 157);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 29);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.SeaShell;
            this.btnEliminar.Location = new System.Drawing.Point(466, 210);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 33);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // MesasView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(1500, 720);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.panelCard);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MesasView";
            this.Padding = new System.Windows.Forms.Padding(16);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Mesas y Horarios";
            this.panelCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridMesas)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
    }
}