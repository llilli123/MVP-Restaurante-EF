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
        private Guna.UI2.WinForms.Guna2NumericUpDown nudCapacidad;

        private System.Windows.Forms.Label lblEstado;
        private Guna.UI2.WinForms.Guna2ComboBox cboEstado;

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
            this.nudCapacidad = new Guna.UI2.WinForms.Guna2NumericUpDown();

            this.lblEstado = new System.Windows.Forms.Label();
            this.cboEstado = new Guna.UI2.WinForms.Guna2ComboBox();

            this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.btnGuardar = new Guna.UI2.WinForms.Guna2GradientButton();

            // ===== Form =====
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(255, 248, 237);
            this.ClientSize = new System.Drawing.Size(640, 360);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Padding = new System.Windows.Forms.Padding(16);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar Mesa";

            this.elipseForm.BorderRadius = 16;
            this.elipseForm.TargetControl = this;
            this.shadowForm.SetShadowForm(this);

            // ===== Botón Cerrar (X) =====
            this.controlClose.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.controlClose.BorderRadius = 8;
            this.controlClose.FillColor = System.Drawing.Color.Transparent;
            this.controlClose.HoverState.FillColor = System.Drawing.Color.FromArgb(255, 238, 230);
            this.controlClose.IconColor = System.Drawing.Color.FromArgb(90, 57, 30);
            this.controlClose.Location = new System.Drawing.Point(592, 8);
            this.controlClose.Name = "controlClose";
            this.controlClose.Size = new System.Drawing.Size(36, 28);

            // ===== Título =====
            this.lblTitulo.AutoSize = false;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(94, 57, 33);
            this.lblTitulo.Location = new System.Drawing.Point(28, 24);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(320, 36);
            this.lblTitulo.Text = "Agregar Mesa";

            // ===== Capacidad =====
            this.lblCapacidad.AutoSize = false;
            this.lblCapacidad.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblCapacidad.ForeColor = System.Drawing.Color.FromArgb(90, 57, 30);
            this.lblCapacidad.Location = new System.Drawing.Point(28, 84);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(240, 24);
            this.lblCapacidad.Text = "Capacidad (personas)";

            this.nudCapacidad.BackColor = System.Drawing.Color.Transparent;
            this.nudCapacidad.BorderRadius = 12;
            this.nudCapacidad.FillColor = System.Drawing.Color.FromArgb(248, 246, 243);
            this.nudCapacidad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(255, 170, 64);
            this.nudCapacidad.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nudCapacidad.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.nudCapacidad.Location = new System.Drawing.Point(32, 112);
            this.nudCapacidad.Name = "nudCapacidad";
            this.nudCapacidad.Size = new System.Drawing.Size(576, 44);
            this.nudCapacidad.UpDownButtonFillColor = System.Drawing.Color.FromArgb(235, 230, 225);
            this.nudCapacidad.UpDownButtonForeColor = System.Drawing.Color.FromArgb(90, 57, 30);
            this.nudCapacidad.Minimum = 1;
            this.nudCapacidad.Maximum = 20;
            this.nudCapacidad.Value = 4;

            // ===== Estado =====
            this.lblEstado.AutoSize = false;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(90, 57, 30);
            this.lblEstado.Location = new System.Drawing.Point(28, 172);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(200, 24);
            this.lblEstado.Text = "Estado";

            this.cboEstado.BackColor = System.Drawing.Color.Transparent;
            this.cboEstado.BorderRadius = 12;
            this.cboEstado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.FillColor = System.Drawing.Color.FromArgb(248, 246, 243);
            this.cboEstado.FocusedColor = System.Drawing.Color.FromArgb(255, 170, 64);
            this.cboEstado.FocusedState.BorderColor = System.Drawing.Color.FromArgb(255, 170, 64);
            this.cboEstado.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboEstado.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.cboEstado.ItemHeight = 36;
            this.cboEstado.Items.AddRange(new object[] { "Disponible", "Ocupada" });
            this.cboEstado.Location = new System.Drawing.Point(32, 200);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(576, 42);
            this.cboEstado.StartIndex = 0;

            // ===== Botones =====
            this.btnCancelar.Animated = true;
            this.btnCancelar.BorderColor = System.Drawing.Color.FromArgb(255, 170, 64);
            this.btnCancelar.BorderRadius = 12;
            this.btnCancelar.BorderThickness = 1;
            this.btnCancelar.FillColor = System.Drawing.Color.White;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(139, 74, 15);
            this.btnCancelar.Location = new System.Drawing.Point(360, 272);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 44);
            this.btnCancelar.Text = "Cancelar";

            this.btnGuardar.Animated = true;
            this.btnGuardar.BorderRadius = 12;
            this.btnGuardar.FillColor = System.Drawing.Color.FromArgb(255, 160, 0);
            this.btnGuardar.FillColor2 = System.Drawing.Color.FromArgb(255, 94, 0);
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.btnGuardar.Location = new System.Drawing.Point(488, 272);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 44);
            this.btnGuardar.Text = "Guardar";

            // ===== Add controls =====
            this.Controls.Add(this.controlClose);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblCapacidad);
            this.Controls.Add(this.nudCapacidad);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
        }
        #endregion
    }
}