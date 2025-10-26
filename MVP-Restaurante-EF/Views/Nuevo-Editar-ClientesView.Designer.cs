namespace MVP_Restaurante_EF.Views
{
    partial class Nuevo_Editar_ClientesView
    {
        private System.ComponentModel.IContainer components = null;

        private Guna.UI2.WinForms.Guna2Elipse elipseForm;
        private Guna.UI2.WinForms.Guna2ShadowForm shadowForm;
        private Guna.UI2.WinForms.Guna2ControlBox controlClose;

        private System.Windows.Forms.Label lblTitulo;

        private System.Windows.Forms.Label lblNombre;
        private Guna.UI2.WinForms.Guna2TextBox txtNombre;

        private System.Windows.Forms.Label lblTelefono;
        private Guna.UI2.WinForms.Guna2TextBox txtTelefono;

        private System.Windows.Forms.Label lblCorreo;
        private Guna.UI2.WinForms.Guna2TextBox txtCorreo;

        private System.Windows.Forms.Label lblPersonas;
        private Guna.UI2.WinForms.Guna2TextBox txtPersonas;

        private Guna.UI2.WinForms.Guna2Button btnCancelar;
        private Guna.UI2.WinForms.Guna2GradientButton btnGuardar;

        private System.Windows.Forms.Label req1;
        private System.Windows.Forms.Label req2;
        private System.Windows.Forms.Label req4;

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

            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new Guna.UI2.WinForms.Guna2TextBox();

            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new Guna.UI2.WinForms.Guna2TextBox();

            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtCorreo = new Guna.UI2.WinForms.Guna2TextBox();

            this.lblPersonas = new System.Windows.Forms.Label();
            this.txtPersonas = new Guna.UI2.WinForms.Guna2TextBox();

            this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.btnGuardar = new Guna.UI2.WinForms.Guna2GradientButton();

            this.req1 = new System.Windows.Forms.Label();
            this.req2 = new System.Windows.Forms.Label();
            this.req4 = new System.Windows.Forms.Label();

            // ===== Form =====
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(660, 520);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Padding = new System.Windows.Forms.Padding(16);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nuevo Cliente";

            this.elipseForm.BorderRadius = 16;
            this.elipseForm.TargetControl = this;
            this.shadowForm.SetShadowForm(this);

            // ===== ControlBox (X) =====
            this.controlClose.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.controlClose.BorderRadius = 8;
            this.controlClose.FillColor = System.Drawing.Color.Transparent;
            this.controlClose.HoverState.FillColor = System.Drawing.Color.FromArgb(255, 238, 230);
            this.controlClose.IconColor = System.Drawing.Color.FromArgb(90, 57, 30);
            this.controlClose.Location = new System.Drawing.Point(612, 8);
            this.controlClose.Name = "controlClose";
            this.controlClose.Size = new System.Drawing.Size(36, 28);

            // ===== Título =====
            this.lblTitulo.AutoSize = false;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(94, 57, 33);
            this.lblTitulo.Location = new System.Drawing.Point(28, 26);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(300, 36);
            this.lblTitulo.Text = "Nuevo Cliente";

            // ===== Nombre =====
            this.lblNombre.AutoSize = false;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(90, 57, 30);
            this.lblNombre.Location = new System.Drawing.Point(28, 88);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(190, 24);
            this.lblNombre.Text = "Nombre Completo";

            this.req1.AutoSize = true;
            this.req1.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.req1.ForeColor = System.Drawing.Color.FromArgb(218, 44, 56);
            this.req1.Location = new System.Drawing.Point(182, 88);
            this.req1.Text = "*";

            this.txtNombre.BorderRadius = 12;
            this.txtNombre.FillColor = System.Drawing.Color.FromArgb(247, 246, 244);
            this.txtNombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(255, 170, 64);
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.txtNombre.Location = new System.Drawing.Point(32, 116);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PlaceholderText = "Ej: Juan Pérez";
            this.txtNombre.Size = new System.Drawing.Size(596, 44);

            // ===== Teléfono =====
            this.lblTelefono.AutoSize = false;
            this.lblTelefono.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblTelefono.ForeColor = System.Drawing.Color.FromArgb(90, 57, 30);
            this.lblTelefono.Location = new System.Drawing.Point(28, 176);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(110, 24);
            this.lblTelefono.Text = "Teléfono";

            this.req2.AutoSize = true;
            this.req2.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.req2.ForeColor = System.Drawing.Color.FromArgb(218, 44, 56);
            this.req2.Location = new System.Drawing.Point(118, 176);
            this.req2.Text = "*";

            this.txtTelefono.BorderRadius = 12;
            this.txtTelefono.FillColor = System.Drawing.Color.FromArgb(247, 246, 244);
            this.txtTelefono.FocusedState.BorderColor = System.Drawing.Color.FromArgb(255, 170, 64);
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTelefono.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.txtTelefono.Location = new System.Drawing.Point(32, 204);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.PlaceholderText = "555-0123";
            this.txtTelefono.Size = new System.Drawing.Size(596, 44);

            // ===== Correo =====
            this.lblCorreo.AutoSize = false;
            this.lblCorreo.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblCorreo.ForeColor = System.Drawing.Color.FromArgb(90, 57, 30);
            this.lblCorreo.Location = new System.Drawing.Point(28, 264);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(180, 24);
            this.lblCorreo.Text = "Correo Electrónico";

            this.txtCorreo.BorderRadius = 12;
            this.txtCorreo.FillColor = System.Drawing.Color.FromArgb(247, 246, 244);
            this.txtCorreo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(255, 170, 64);
            this.txtCorreo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCorreo.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.txtCorreo.Location = new System.Drawing.Point(32, 292);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.PlaceholderText = "cliente@email.com";
            this.txtCorreo.Size = new System.Drawing.Size(596, 44);

            // ===== Nº Personas =====
            this.lblPersonas.AutoSize = false;
            this.lblPersonas.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblPersonas.ForeColor = System.Drawing.Color.FromArgb(90, 57, 30);
            this.lblPersonas.Location = new System.Drawing.Point(28, 352);
            this.lblPersonas.Name = "lblPersonas";
            this.lblPersonas.Size = new System.Drawing.Size(200, 24);
            this.lblPersonas.Text = "Número de Personas";

            this.req4.AutoSize = true;
            this.req4.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.req4.ForeColor = System.Drawing.Color.FromArgb(218, 44, 56);
            this.req4.Location = new System.Drawing.Point(220, 352);
            this.req4.Text = "*";

            this.txtPersonas.BorderRadius = 12;
            this.txtPersonas.FillColor = System.Drawing.Color.FromArgb(247, 246, 244);
            this.txtPersonas.FocusedState.BorderColor = System.Drawing.Color.FromArgb(255, 170, 64);
            this.txtPersonas.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPersonas.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.txtPersonas.Location = new System.Drawing.Point(32, 380);
            this.txtPersonas.Name = "txtPersonas";
            this.txtPersonas.PlaceholderText = "4";
            this.txtPersonas.Size = new System.Drawing.Size(596, 44);

            // ===== Botones =====
            this.btnCancelar.Animated = true;
            this.btnCancelar.BorderColor = System.Drawing.Color.FromArgb(255, 170, 64);
            this.btnCancelar.BorderRadius = 12;
            this.btnCancelar.BorderThickness = 1;
            this.btnCancelar.FillColor = System.Drawing.Color.White;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(139, 74, 15);
            this.btnCancelar.Location = new System.Drawing.Point(404, 448);
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
            this.btnGuardar.Location = new System.Drawing.Point(532, 448);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 44);
            this.btnGuardar.Text = "Guardar";

            // ===== Add controls =====
            this.Controls.Add(this.controlClose);
            this.Controls.Add(this.lblTitulo);

            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.req1);
            this.Controls.Add(this.txtNombre);

            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.req2);
            this.Controls.Add(this.txtTelefono);

            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.txtCorreo);

            this.Controls.Add(this.lblPersonas);
            this.Controls.Add(this.req4);
            this.Controls.Add(this.txtPersonas);

            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
        }
        #endregion
    }
}