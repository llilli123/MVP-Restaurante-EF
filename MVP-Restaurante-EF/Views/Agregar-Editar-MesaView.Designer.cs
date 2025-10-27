namespace MVP_Restaurante_EF.Views
{
    partial class Agregar_Editar_MesaView
    {
        private System.ComponentModel.IContainer components = null;

        private Guna.UI2.WinForms.Guna2Elipse elipseForm;
        private Guna.UI2.WinForms.Guna2ShadowForm shadowForm;
        private Guna.UI2.WinForms.Guna2ControlBox controlClose;

        private System.Windows.Forms.Label lblTitulo;

        private System.Windows.Forms.Label lblCapacidad;
        private Guna.UI2.WinForms.Guna2NumericUpDown numCapacidad;

        private System.Windows.Forms.Label lblEstado;
        private Guna.UI2.WinForms.Guna2ComboBox cmbEstado;

        private Guna.UI2.WinForms.Guna2Button btnCancelar;
        private Guna.UI2.WinForms.Guna2GradientButton btnGuardar;

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
            this.controlClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCapacidad = new System.Windows.Forms.Label();
            this.numCapacidad = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cmbEstado = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.btnGuardar = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.numCapacidad)).BeginInit();
            this.SuspendLayout();
            // 
            // elipseForm
            // 
            this.elipseForm.BorderRadius = 16;
            this.elipseForm.TargetControl = this;
            // 
            // shadowForm
            // 
            this.shadowForm.TargetForm = this;
            // 
            // controlClose
            // 
            this.controlClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controlClose.BorderRadius = 8;
            this.controlClose.FillColor = System.Drawing.Color.Transparent;
            this.controlClose.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(230)))));
            this.controlClose.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(57)))), ((int)(((byte)(30)))));
            this.controlClose.Location = new System.Drawing.Point(592, 8);
            this.controlClose.Name = "controlClose";
            this.controlClose.Size = new System.Drawing.Size(36, 28);
            this.controlClose.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(57)))), ((int)(((byte)(33)))));
            this.lblTitulo.Location = new System.Drawing.Point(28, 24);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(320, 36);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Agregar Mesa";
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblCapacidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(57)))), ((int)(((byte)(30)))));
            this.lblCapacidad.Location = new System.Drawing.Point(28, 84);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(240, 24);
            this.lblCapacidad.TabIndex = 2;
            this.lblCapacidad.Text = "Capacidad (personas)";
            // 
            // numCapacidad
            // 
            this.numCapacidad.BackColor = System.Drawing.Color.Transparent;
            this.numCapacidad.BorderRadius = 12;
            this.numCapacidad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numCapacidad.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(246)))), ((int)(((byte)(243)))));
            this.numCapacidad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(64)))));
            this.numCapacidad.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numCapacidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.numCapacidad.Location = new System.Drawing.Point(32, 112);
            this.numCapacidad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numCapacidad.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numCapacidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCapacidad.Name = "numCapacidad";
            this.numCapacidad.Size = new System.Drawing.Size(576, 44);
            this.numCapacidad.TabIndex = 3;
            this.numCapacidad.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(225)))));
            this.numCapacidad.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(57)))), ((int)(((byte)(30)))));
            this.numCapacidad.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // lblEstado
            // 
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(57)))), ((int)(((byte)(30)))));
            this.lblEstado.Location = new System.Drawing.Point(28, 172);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(200, 24);
            this.lblEstado.TabIndex = 4;
            this.lblEstado.Text = "Estado";
            // 
            // cmbEstado
            // 
            this.cmbEstado.BackColor = System.Drawing.Color.Transparent;
            this.cmbEstado.BorderRadius = 12;
            this.cmbEstado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(246)))), ((int)(((byte)(243)))));
            this.cmbEstado.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(64)))));
            this.cmbEstado.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(64)))));
            this.cmbEstado.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cmbEstado.ItemHeight = 36;
            this.cmbEstado.Items.AddRange(new object[] {
            "Disponible",
            "Ocupada"});
            this.cmbEstado.Location = new System.Drawing.Point(32, 200);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(576, 42);
            this.cmbEstado.StartIndex = 0;
            this.cmbEstado.TabIndex = 5;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Animated = true;
            this.btnCancelar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(64)))));
            this.btnCancelar.BorderRadius = 12;
            this.btnCancelar.BorderThickness = 1;
            this.btnCancelar.FillColor = System.Drawing.Color.White;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(74)))), ((int)(((byte)(15)))));
            this.btnCancelar.Location = new System.Drawing.Point(360, 272);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 44);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Animated = true;
            this.btnGuardar.BorderRadius = 12;
            this.btnGuardar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(0)))));
            this.btnGuardar.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(94)))), ((int)(((byte)(0)))));
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(488, 272);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 44);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            // 
            // Agregar_Editar_MesaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(640, 360);
            this.Controls.Add(this.controlClose);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblCapacidad);
            this.Controls.Add(this.numCapacidad);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Agregar_Editar_MesaView";
            this.Padding = new System.Windows.Forms.Padding(16);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar Mesa";
            ((System.ComponentModel.ISupportInitialize)(this.numCapacidad)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
    }
}