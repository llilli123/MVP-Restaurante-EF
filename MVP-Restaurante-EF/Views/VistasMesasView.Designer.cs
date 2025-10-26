namespace MVP_Restaurante_EF.Views
{
    partial class VistasMesasView
    {
        private System.ComponentModel.IContainer components = null;

        private Guna.UI2.WinForms.Guna2Elipse elipseForm;
        private Guna.UI2.WinForms.Guna2ShadowForm shadowForm;

        private Guna.UI2.WinForms.Guna2Button btnVolver;
        private System.Windows.Forms.Label lblTitulo;

        // Leyenda superior
        private Guna.UI2.WinForms.Guna2ShadowPanel legendPanel;
        private Guna.UI2.WinForms.Guna2CircleButton dotDisponible;
        private System.Windows.Forms.Label lblDisponible;
        private Guna.UI2.WinForms.Guna2CircleButton dotOcupada;
        private System.Windows.Forms.Label lblOcupada;
        private Guna.UI2.WinForms.Guna2CircleButton dotCapacidad;
        private System.Windows.Forms.Label lblCapacidad;

        // Lienzo principal
        private Guna.UI2.WinForms.Guna2ShadowPanel canvasPanel;
        private Guna.UI2.WinForms.Guna2HtmlLabel chipLayout;

        // Mesas (ejemplo)
        private Guna.UI2.WinForms.Guna2ShadowPanel mesa2;
        private Guna.UI2.WinForms.Guna2CircleButton mesa2Num;
        private System.Windows.Forms.Label mesa2Cap;
        private Guna.UI2.WinForms.Guna2Button mesa2Estado;

        private Guna.UI2.WinForms.Guna2ShadowPanel mesa3;
        private Guna.UI2.WinForms.Guna2CircleButton mesa3Num;
        private System.Windows.Forms.Label mesa3Cap;
        private Guna.UI2.WinForms.Guna2Button mesa3Estado;

        private Guna.UI2.WinForms.Guna2ShadowPanel mesa4;
        private Guna.UI2.WinForms.Guna2CircleButton mesa4Num;
        private System.Windows.Forms.Label mesa4Cap;
        private Guna.UI2.WinForms.Guna2Button mesa4Estado;

        private Guna.UI2.WinForms.Guna2ShadowPanel mesa5;
        private Guna.UI2.WinForms.Guna2CircleButton mesa5Num;
        private System.Windows.Forms.Label mesa5Cap;
        private Guna.UI2.WinForms.Guna2Button mesa5Estado;

        private Guna.UI2.WinForms.Guna2ShadowPanel mesa6;
        private Guna.UI2.WinForms.Guna2CircleButton mesa6Num;
        private System.Windows.Forms.Label mesa6Cap;
        private Guna.UI2.WinForms.Guna2Button mesa6Estado;

        // Métricas inferiores
        private Guna.UI2.WinForms.Guna2ShadowPanel cardDisponibles;
        private System.Windows.Forms.Label lblCardDispTitle;
        private System.Windows.Forms.Label lblCardDispValue;
        private Guna.UI2.WinForms.Guna2GradientCircleButton iconDisp;

        private Guna.UI2.WinForms.Guna2ShadowPanel cardOcupadas;
        private System.Windows.Forms.Label lblCardOcuTitle;
        private System.Windows.Forms.Label lblCardOcuValue;
        private Guna.UI2.WinForms.Guna2GradientCircleButton iconOcu;

        private Guna.UI2.WinForms.Guna2ShadowPanel cardCapacidad;
        private System.Windows.Forms.Label lblCardCapTitle;
        private System.Windows.Forms.Label lblCardCapValue;
        private Guna.UI2.WinForms.Guna2GradientCircleButton iconCap;

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
            this.legendPanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.dotDisponible = new Guna.UI2.WinForms.Guna2CircleButton();
            this.lblDisponible = new System.Windows.Forms.Label();
            this.dotOcupada = new Guna.UI2.WinForms.Guna2CircleButton();
            this.lblOcupada = new System.Windows.Forms.Label();
            this.dotCapacidad = new Guna.UI2.WinForms.Guna2CircleButton();
            this.lblCapacidad = new System.Windows.Forms.Label();
            this.canvasPanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.chipLayout = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.mesa2 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.mesa2Num = new Guna.UI2.WinForms.Guna2CircleButton();
            this.mesa2Cap = new System.Windows.Forms.Label();
            this.mesa2Estado = new Guna.UI2.WinForms.Guna2Button();
            this.mesa3 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.mesa3Num = new Guna.UI2.WinForms.Guna2CircleButton();
            this.mesa3Cap = new System.Windows.Forms.Label();
            this.mesa3Estado = new Guna.UI2.WinForms.Guna2Button();
            this.mesa4 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.mesa4Num = new Guna.UI2.WinForms.Guna2CircleButton();
            this.mesa4Cap = new System.Windows.Forms.Label();
            this.mesa4Estado = new Guna.UI2.WinForms.Guna2Button();
            this.mesa5 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.mesa5Num = new Guna.UI2.WinForms.Guna2CircleButton();
            this.mesa5Cap = new System.Windows.Forms.Label();
            this.mesa5Estado = new Guna.UI2.WinForms.Guna2Button();
            this.mesa6 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.mesa6Num = new Guna.UI2.WinForms.Guna2CircleButton();
            this.mesa6Cap = new System.Windows.Forms.Label();
            this.mesa6Estado = new Guna.UI2.WinForms.Guna2Button();
            this.cardDisponibles = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblCardDispTitle = new System.Windows.Forms.Label();
            this.lblCardDispValue = new System.Windows.Forms.Label();
            this.iconDisp = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.cardOcupadas = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblCardOcuTitle = new System.Windows.Forms.Label();
            this.lblCardOcuValue = new System.Windows.Forms.Label();
            this.iconOcu = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.cardCapacidad = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblCardCapTitle = new System.Windows.Forms.Label();
            this.lblCardCapValue = new System.Windows.Forms.Label();
            this.iconCap = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.legendPanel.SuspendLayout();
            this.canvasPanel.SuspendLayout();
            this.mesa2.SuspendLayout();
            this.mesa3.SuspendLayout();
            this.mesa4.SuspendLayout();
            this.mesa5.SuspendLayout();
            this.mesa6.SuspendLayout();
            this.cardDisponibles.SuspendLayout();
            this.cardOcupadas.SuspendLayout();
            this.cardCapacidad.SuspendLayout();
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
            this.lblTitulo.Size = new System.Drawing.Size(420, 36);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Vista Física del Restaurante";
            // 
            // legendPanel
            // 
            this.legendPanel.BackColor = System.Drawing.Color.Transparent;
            this.legendPanel.Controls.Add(this.dotDisponible);
            this.legendPanel.Controls.Add(this.lblDisponible);
            this.legendPanel.Controls.Add(this.dotOcupada);
            this.legendPanel.Controls.Add(this.lblOcupada);
            this.legendPanel.Controls.Add(this.dotCapacidad);
            this.legendPanel.Controls.Add(this.lblCapacidad);
            this.legendPanel.FillColor = System.Drawing.Color.White;
            this.legendPanel.Location = new System.Drawing.Point(24, 92);
            this.legendPanel.Name = "legendPanel";
            this.legendPanel.Radius = 16;
            this.legendPanel.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.legendPanel.ShadowDepth = 30;
            this.legendPanel.Size = new System.Drawing.Size(1452, 64);
            this.legendPanel.TabIndex = 2;
            // 
            // dotDisponible
            // 
            this.dotDisponible.DisabledState.FillColor = System.Drawing.Color.Transparent;
            this.dotDisponible.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(70)))));
            this.dotDisponible.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dotDisponible.ForeColor = System.Drawing.Color.White;
            this.dotDisponible.Location = new System.Drawing.Point(420, 16);
            this.dotDisponible.Name = "dotDisponible";
            this.dotDisponible.Size = new System.Drawing.Size(28, 28);
            this.dotDisponible.TabIndex = 0;
            // 
            // lblDisponible
            // 
            this.lblDisponible.AutoSize = true;
            this.lblDisponible.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblDisponible.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(70)))));
            this.lblDisponible.Location = new System.Drawing.Point(454, 20);
            this.lblDisponible.Name = "lblDisponible";
            this.lblDisponible.Size = new System.Drawing.Size(107, 25);
            this.lblDisponible.TabIndex = 1;
            this.lblDisponible.Text = "Disponible";
            // 
            // dotOcupada
            // 
            this.dotOcupada.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(58)))), ((int)(((byte)(48)))));
            this.dotOcupada.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dotOcupada.ForeColor = System.Drawing.Color.White;
            this.dotOcupada.Location = new System.Drawing.Point(600, 16);
            this.dotOcupada.Name = "dotOcupada";
            this.dotOcupada.Size = new System.Drawing.Size(28, 28);
            this.dotOcupada.TabIndex = 2;
            // 
            // lblOcupada
            // 
            this.lblOcupada.AutoSize = true;
            this.lblOcupada.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblOcupada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(58)))), ((int)(((byte)(48)))));
            this.lblOcupada.Location = new System.Drawing.Point(634, 20);
            this.lblOcupada.Name = "lblOcupada";
            this.lblOcupada.Size = new System.Drawing.Size(91, 25);
            this.lblOcupada.TabIndex = 3;
            this.lblOcupada.Text = "Ocupada";
            // 
            // dotCapacidad
            // 
            this.dotCapacidad.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(64)))));
            this.dotCapacidad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dotCapacidad.ForeColor = System.Drawing.Color.White;
            this.dotCapacidad.Location = new System.Drawing.Point(760, 16);
            this.dotCapacidad.Name = "dotCapacidad";
            this.dotCapacidad.Size = new System.Drawing.Size(28, 28);
            this.dotCapacidad.TabIndex = 4;
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblCapacidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(119)))), ((int)(((byte)(38)))));
            this.lblCapacidad.Location = new System.Drawing.Point(794, 20);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(216, 25);
            this.lblCapacidad.TabIndex = 5;
            this.lblCapacidad.Text = "Capacidad de personas";
            // 
            // canvasPanel
            // 
            this.canvasPanel.BackColor = System.Drawing.Color.Transparent;
            this.canvasPanel.Controls.Add(this.chipLayout);
            this.canvasPanel.Controls.Add(this.mesa2);
            this.canvasPanel.Controls.Add(this.mesa3);
            this.canvasPanel.Controls.Add(this.mesa4);
            this.canvasPanel.Controls.Add(this.mesa5);
            this.canvasPanel.Controls.Add(this.mesa6);
            this.canvasPanel.FillColor = System.Drawing.Color.White;
            this.canvasPanel.Location = new System.Drawing.Point(24, 168);
            this.canvasPanel.Name = "canvasPanel";
            this.canvasPanel.Radius = 18;
            this.canvasPanel.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.canvasPanel.ShadowDepth = 40;
            this.canvasPanel.ShadowShift = 6;
            this.canvasPanel.Size = new System.Drawing.Size(1452, 640);
            this.canvasPanel.TabIndex = 3;
            // 
            // chipLayout
            // 
            this.chipLayout.AutoSize = false;
            this.chipLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(214)))));
            this.chipLayout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.chipLayout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(119)))), ((int)(((byte)(38)))));
            this.chipLayout.Location = new System.Drawing.Point(32, 24);
            this.chipLayout.Name = "chipLayout";
            this.chipLayout.Size = new System.Drawing.Size(230, 40);
            this.chipLayout.TabIndex = 0;
            this.chipLayout.Text = "  Layout del Restaurante  ";
            // 
            // mesa2
            // 
            this.mesa2.BackColor = System.Drawing.Color.Transparent;
            this.mesa2.Controls.Add(this.mesa2Num);
            this.mesa2.Controls.Add(this.mesa2Cap);
            this.mesa2.Controls.Add(this.mesa2Estado);
            this.mesa2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.mesa2.Location = new System.Drawing.Point(312, 188);
            this.mesa2.Name = "mesa2";
            this.mesa2.Radius = 18;
            this.mesa2.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(158)))), ((int)(((byte)(153)))));
            this.mesa2.ShadowDepth = 40;
            this.mesa2.ShadowShift = 6;
            this.mesa2.Size = new System.Drawing.Size(220, 220);
            this.mesa2.TabIndex = 1;
            // 
            // mesa2Num
            // 
            this.mesa2Num.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.mesa2Num.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.mesa2Num.ForeColor = System.Drawing.Color.White;
            this.mesa2Num.Location = new System.Drawing.Point(80, 20);
            this.mesa2Num.Name = "mesa2Num";
            this.mesa2Num.Size = new System.Drawing.Size(60, 60);
            this.mesa2Num.TabIndex = 0;
            this.mesa2Num.Text = "2";
            // 
            // mesa2Cap
            // 
            this.mesa2Cap.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.mesa2Cap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.mesa2Cap.Location = new System.Drawing.Point(92, 96);
            this.mesa2Cap.Name = "mesa2Cap";
            this.mesa2Cap.Size = new System.Drawing.Size(40, 20);
            this.mesa2Cap.TabIndex = 1;
            this.mesa2Cap.Text = "4";
            // 
            // mesa2Estado
            // 
            this.mesa2Estado.Animated = true;
            this.mesa2Estado.BorderRadius = 10;
            this.mesa2Estado.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(58)))), ((int)(((byte)(48)))));
            this.mesa2Estado.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.mesa2Estado.ForeColor = System.Drawing.Color.White;
            this.mesa2Estado.Location = new System.Drawing.Point(60, 140);
            this.mesa2Estado.Name = "mesa2Estado";
            this.mesa2Estado.Size = new System.Drawing.Size(100, 32);
            this.mesa2Estado.TabIndex = 2;
            this.mesa2Estado.Text = "Ocupada";
            // 
            // mesa3
            // 
            this.mesa3.BackColor = System.Drawing.Color.Transparent;
            this.mesa3.Controls.Add(this.mesa3Num);
            this.mesa3.Controls.Add(this.mesa3Cap);
            this.mesa3.Controls.Add(this.mesa3Estado);
            this.mesa3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(255)))), ((int)(((byte)(242)))));
            this.mesa3.Location = new System.Drawing.Point(540, 168);
            this.mesa3.Name = "mesa3";
            this.mesa3.Radius = 18;
            this.mesa3.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(120)))));
            this.mesa3.ShadowDepth = 40;
            this.mesa3.ShadowShift = 6;
            this.mesa3.Size = new System.Drawing.Size(220, 220);
            this.mesa3.TabIndex = 2;
            // 
            // mesa3Num
            // 
            this.mesa3Num.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(70)))));
            this.mesa3Num.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.mesa3Num.ForeColor = System.Drawing.Color.White;
            this.mesa3Num.Location = new System.Drawing.Point(80, 20);
            this.mesa3Num.Name = "mesa3Num";
            this.mesa3Num.Size = new System.Drawing.Size(60, 60);
            this.mesa3Num.TabIndex = 0;
            this.mesa3Num.Text = "3";
            // 
            // mesa3Cap
            // 
            this.mesa3Cap.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.mesa3Cap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(110)))), ((int)(((byte)(80)))));
            this.mesa3Cap.Location = new System.Drawing.Point(92, 96);
            this.mesa3Cap.Name = "mesa3Cap";
            this.mesa3Cap.Size = new System.Drawing.Size(40, 20);
            this.mesa3Cap.TabIndex = 1;
            this.mesa3Cap.Text = "6";
            // 
            // mesa3Estado
            // 
            this.mesa3Estado.Animated = true;
            this.mesa3Estado.BorderRadius = 10;
            this.mesa3Estado.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(70)))));
            this.mesa3Estado.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.mesa3Estado.ForeColor = System.Drawing.Color.White;
            this.mesa3Estado.Location = new System.Drawing.Point(60, 140);
            this.mesa3Estado.Name = "mesa3Estado";
            this.mesa3Estado.Size = new System.Drawing.Size(100, 32);
            this.mesa3Estado.TabIndex = 2;
            this.mesa3Estado.Text = "Libre";
            // 
            // mesa4
            // 
            this.mesa4.BackColor = System.Drawing.Color.Transparent;
            this.mesa4.Controls.Add(this.mesa4Num);
            this.mesa4.Controls.Add(this.mesa4Cap);
            this.mesa4.Controls.Add(this.mesa4Estado);
            this.mesa4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(255)))), ((int)(((byte)(242)))));
            this.mesa4.Location = new System.Drawing.Point(190, 420);
            this.mesa4.Name = "mesa4";
            this.mesa4.Radius = 18;
            this.mesa4.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(120)))));
            this.mesa4.ShadowDepth = 40;
            this.mesa4.ShadowShift = 6;
            this.mesa4.Size = new System.Drawing.Size(220, 220);
            this.mesa4.TabIndex = 3;
            // 
            // mesa4Num
            // 
            this.mesa4Num.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(70)))));
            this.mesa4Num.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.mesa4Num.ForeColor = System.Drawing.Color.White;
            this.mesa4Num.Location = new System.Drawing.Point(80, 20);
            this.mesa4Num.Name = "mesa4Num";
            this.mesa4Num.Size = new System.Drawing.Size(60, 60);
            this.mesa4Num.TabIndex = 0;
            this.mesa4Num.Text = "4";
            // 
            // mesa4Cap
            // 
            this.mesa4Cap.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.mesa4Cap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(110)))), ((int)(((byte)(80)))));
            this.mesa4Cap.Location = new System.Drawing.Point(92, 96);
            this.mesa4Cap.Name = "mesa4Cap";
            this.mesa4Cap.Size = new System.Drawing.Size(40, 20);
            this.mesa4Cap.TabIndex = 1;
            this.mesa4Cap.Text = "4";
            // 
            // mesa4Estado
            // 
            this.mesa4Estado.Animated = true;
            this.mesa4Estado.BorderRadius = 10;
            this.mesa4Estado.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(70)))));
            this.mesa4Estado.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.mesa4Estado.ForeColor = System.Drawing.Color.White;
            this.mesa4Estado.Location = new System.Drawing.Point(60, 140);
            this.mesa4Estado.Name = "mesa4Estado";
            this.mesa4Estado.Size = new System.Drawing.Size(100, 32);
            this.mesa4Estado.TabIndex = 2;
            this.mesa4Estado.Text = "Libre";
            // 
            // mesa5
            // 
            this.mesa5.BackColor = System.Drawing.Color.Transparent;
            this.mesa5.Controls.Add(this.mesa5Num);
            this.mesa5.Controls.Add(this.mesa5Cap);
            this.mesa5.Controls.Add(this.mesa5Estado);
            this.mesa5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(255)))), ((int)(((byte)(242)))));
            this.mesa5.Location = new System.Drawing.Point(418, 420);
            this.mesa5.Name = "mesa5";
            this.mesa5.Radius = 18;
            this.mesa5.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(120)))));
            this.mesa5.ShadowDepth = 40;
            this.mesa5.ShadowShift = 6;
            this.mesa5.Size = new System.Drawing.Size(220, 220);
            this.mesa5.TabIndex = 4;
            // 
            // mesa5Num
            // 
            this.mesa5Num.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(70)))));
            this.mesa5Num.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.mesa5Num.ForeColor = System.Drawing.Color.White;
            this.mesa5Num.Location = new System.Drawing.Point(80, 20);
            this.mesa5Num.Name = "mesa5Num";
            this.mesa5Num.Size = new System.Drawing.Size(60, 60);
            this.mesa5Num.TabIndex = 0;
            this.mesa5Num.Text = "5";
            // 
            // mesa5Cap
            // 
            this.mesa5Cap.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.mesa5Cap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(110)))), ((int)(((byte)(80)))));
            this.mesa5Cap.Location = new System.Drawing.Point(92, 96);
            this.mesa5Cap.Name = "mesa5Cap";
            this.mesa5Cap.Size = new System.Drawing.Size(40, 20);
            this.mesa5Cap.TabIndex = 1;
            this.mesa5Cap.Text = "2";
            // 
            // mesa5Estado
            // 
            this.mesa5Estado.Animated = true;
            this.mesa5Estado.BorderRadius = 10;
            this.mesa5Estado.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(70)))));
            this.mesa5Estado.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.mesa5Estado.ForeColor = System.Drawing.Color.White;
            this.mesa5Estado.Location = new System.Drawing.Point(60, 140);
            this.mesa5Estado.Name = "mesa5Estado";
            this.mesa5Estado.Size = new System.Drawing.Size(100, 32);
            this.mesa5Estado.TabIndex = 2;
            this.mesa5Estado.Text = "Libre";
            // 
            // mesa6
            // 
            this.mesa6.BackColor = System.Drawing.Color.Transparent;
            this.mesa6.Controls.Add(this.mesa6Num);
            this.mesa6.Controls.Add(this.mesa6Cap);
            this.mesa6.Controls.Add(this.mesa6Estado);
            this.mesa6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(255)))), ((int)(((byte)(242)))));
            this.mesa6.Location = new System.Drawing.Point(646, 420);
            this.mesa6.Name = "mesa6";
            this.mesa6.Radius = 18;
            this.mesa6.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(120)))));
            this.mesa6.ShadowDepth = 40;
            this.mesa6.ShadowShift = 6;
            this.mesa6.Size = new System.Drawing.Size(220, 220);
            this.mesa6.TabIndex = 5;
            // 
            // mesa6Num
            // 
            this.mesa6Num.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(70)))));
            this.mesa6Num.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.mesa6Num.ForeColor = System.Drawing.Color.White;
            this.mesa6Num.Location = new System.Drawing.Point(80, 20);
            this.mesa6Num.Name = "mesa6Num";
            this.mesa6Num.Size = new System.Drawing.Size(60, 60);
            this.mesa6Num.TabIndex = 0;
            this.mesa6Num.Text = "6";
            // 
            // mesa6Cap
            // 
            this.mesa6Cap.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.mesa6Cap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(110)))), ((int)(((byte)(80)))));
            this.mesa6Cap.Location = new System.Drawing.Point(92, 96);
            this.mesa6Cap.Name = "mesa6Cap";
            this.mesa6Cap.Size = new System.Drawing.Size(40, 20);
            this.mesa6Cap.TabIndex = 1;
            this.mesa6Cap.Text = "8";
            // 
            // mesa6Estado
            // 
            this.mesa6Estado.Animated = true;
            this.mesa6Estado.BorderRadius = 10;
            this.mesa6Estado.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(70)))));
            this.mesa6Estado.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.mesa6Estado.ForeColor = System.Drawing.Color.White;
            this.mesa6Estado.Location = new System.Drawing.Point(60, 140);
            this.mesa6Estado.Name = "mesa6Estado";
            this.mesa6Estado.Size = new System.Drawing.Size(100, 32);
            this.mesa6Estado.TabIndex = 2;
            this.mesa6Estado.Text = "Libre";
            // 
            // cardDisponibles
            // 
            this.cardDisponibles.BackColor = System.Drawing.Color.Transparent;
            this.cardDisponibles.Controls.Add(this.lblCardDispTitle);
            this.cardDisponibles.Controls.Add(this.lblCardDispValue);
            this.cardDisponibles.Controls.Add(this.iconDisp);
            this.cardDisponibles.FillColor = System.Drawing.Color.White;
            this.cardDisponibles.Location = new System.Drawing.Point(24, 832);
            this.cardDisponibles.Name = "cardDisponibles";
            this.cardDisponibles.Radius = 18;
            this.cardDisponibles.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardDisponibles.ShadowDepth = 30;
            this.cardDisponibles.ShadowShift = 6;
            this.cardDisponibles.Size = new System.Drawing.Size(500, 112);
            this.cardDisponibles.TabIndex = 4;
            // 
            // lblCardDispTitle
            // 
            this.lblCardDispTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCardDispTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(70)))));
            this.lblCardDispTitle.Location = new System.Drawing.Point(24, 20);
            this.lblCardDispTitle.Name = "lblCardDispTitle";
            this.lblCardDispTitle.Size = new System.Drawing.Size(220, 26);
            this.lblCardDispTitle.TabIndex = 0;
            this.lblCardDispTitle.Text = "Mesas Disponibles";
            // 
            // lblCardDispValue
            // 
            this.lblCardDispValue.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblCardDispValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(110)))), ((int)(((byte)(80)))));
            this.lblCardDispValue.Location = new System.Drawing.Point(24, 56);
            this.lblCardDispValue.Name = "lblCardDispValue";
            this.lblCardDispValue.Size = new System.Drawing.Size(180, 24);
            this.lblCardDispValue.TabIndex = 1;
            this.lblCardDispValue.Text = "4 de 5";
            // 
            // iconDisp
            // 
            this.iconDisp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(70)))));
            this.iconDisp.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(70)))));
            this.iconDisp.Font = new System.Drawing.Font("Segoe UI Emoji", 22F, System.Drawing.FontStyle.Bold);
            this.iconDisp.ForeColor = System.Drawing.Color.White;
            this.iconDisp.Location = new System.Drawing.Point(430, 30);
            this.iconDisp.Name = "iconDisp";
            this.iconDisp.Size = new System.Drawing.Size(56, 56);
            this.iconDisp.TabIndex = 2;
            this.iconDisp.Text = "✔️";
            // 
            // cardOcupadas
            // 
            this.cardOcupadas.BackColor = System.Drawing.Color.Transparent;
            this.cardOcupadas.Controls.Add(this.lblCardOcuTitle);
            this.cardOcupadas.Controls.Add(this.lblCardOcuValue);
            this.cardOcupadas.Controls.Add(this.iconOcu);
            this.cardOcupadas.FillColor = System.Drawing.Color.White;
            this.cardOcupadas.Location = new System.Drawing.Point(536, 832);
            this.cardOcupadas.Name = "cardOcupadas";
            this.cardOcupadas.Radius = 18;
            this.cardOcupadas.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardOcupadas.ShadowDepth = 30;
            this.cardOcupadas.ShadowShift = 6;
            this.cardOcupadas.Size = new System.Drawing.Size(500, 112);
            this.cardOcupadas.TabIndex = 5;
            // 
            // lblCardOcuTitle
            // 
            this.lblCardOcuTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCardOcuTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblCardOcuTitle.Location = new System.Drawing.Point(24, 20);
            this.lblCardOcuTitle.Name = "lblCardOcuTitle";
            this.lblCardOcuTitle.Size = new System.Drawing.Size(200, 26);
            this.lblCardOcuTitle.TabIndex = 0;
            this.lblCardOcuTitle.Text = "Mesas Ocupadas";
            // 
            // lblCardOcuValue
            // 
            this.lblCardOcuValue.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblCardOcuValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblCardOcuValue.Location = new System.Drawing.Point(24, 56);
            this.lblCardOcuValue.Name = "lblCardOcuValue";
            this.lblCardOcuValue.Size = new System.Drawing.Size(180, 24);
            this.lblCardOcuValue.TabIndex = 1;
            this.lblCardOcuValue.Text = "1 de 5";
            // 
            // iconOcu
            // 
            this.iconOcu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(58)))), ((int)(((byte)(48)))));
            this.iconOcu.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(58)))), ((int)(((byte)(48)))));
            this.iconOcu.Font = new System.Drawing.Font("Segoe UI Emoji", 22F, System.Drawing.FontStyle.Bold);
            this.iconOcu.ForeColor = System.Drawing.Color.White;
            this.iconOcu.Location = new System.Drawing.Point(430, 30);
            this.iconOcu.Name = "iconOcu";
            this.iconOcu.Size = new System.Drawing.Size(56, 56);
            this.iconOcu.TabIndex = 2;
            this.iconOcu.Text = "❌";
            // 
            // cardCapacidad
            // 
            this.cardCapacidad.BackColor = System.Drawing.Color.Transparent;
            this.cardCapacidad.Controls.Add(this.lblCardCapTitle);
            this.cardCapacidad.Controls.Add(this.lblCardCapValue);
            this.cardCapacidad.Controls.Add(this.iconCap);
            this.cardCapacidad.FillColor = System.Drawing.Color.White;
            this.cardCapacidad.Location = new System.Drawing.Point(1048, 832);
            this.cardCapacidad.Name = "cardCapacidad";
            this.cardCapacidad.Radius = 18;
            this.cardCapacidad.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardCapacidad.ShadowDepth = 30;
            this.cardCapacidad.ShadowShift = 6;
            this.cardCapacidad.Size = new System.Drawing.Size(428, 112);
            this.cardCapacidad.TabIndex = 6;
            // 
            // lblCardCapTitle
            // 
            this.lblCardCapTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCardCapTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.lblCardCapTitle.Location = new System.Drawing.Point(24, 20);
            this.lblCardCapTitle.Name = "lblCardCapTitle";
            this.lblCardCapTitle.Size = new System.Drawing.Size(200, 26);
            this.lblCardCapTitle.TabIndex = 0;
            this.lblCardCapTitle.Text = "Capacidad Total";
            // 
            // lblCardCapValue
            // 
            this.lblCardCapValue.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblCardCapValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(140)))));
            this.lblCardCapValue.Location = new System.Drawing.Point(24, 56);
            this.lblCardCapValue.Name = "lblCardCapValue";
            this.lblCardCapValue.Size = new System.Drawing.Size(200, 24);
            this.lblCardCapValue.TabIndex = 1;
            this.lblCardCapValue.Text = "24 personas";
            // 
            // iconCap
            // 
            this.iconCap.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.iconCap.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.iconCap.Font = new System.Drawing.Font("Segoe UI Emoji", 22F, System.Drawing.FontStyle.Bold);
            this.iconCap.ForeColor = System.Drawing.Color.White;
            this.iconCap.Location = new System.Drawing.Point(356, 30);
            this.iconCap.Name = "iconCap";
            this.iconCap.Size = new System.Drawing.Size(56, 56);
            this.iconCap.TabIndex = 2;
            this.iconCap.Text = "👥";
            // 
            // VistasMesasView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(1500, 980);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.legendPanel);
            this.Controls.Add(this.canvasPanel);
            this.Controls.Add(this.cardDisponibles);
            this.Controls.Add(this.cardOcupadas);
            this.Controls.Add(this.cardCapacidad);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VistasMesasView";
            this.Padding = new System.Windows.Forms.Padding(16);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vista Física del Restaurante";
            this.legendPanel.ResumeLayout(false);
            this.legendPanel.PerformLayout();
            this.canvasPanel.ResumeLayout(false);
            this.mesa2.ResumeLayout(false);
            this.mesa3.ResumeLayout(false);
            this.mesa4.ResumeLayout(false);
            this.mesa5.ResumeLayout(false);
            this.mesa6.ResumeLayout(false);
            this.cardDisponibles.ResumeLayout(false);
            this.cardOcupadas.ResumeLayout(false);
            this.cardCapacidad.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion
    }
}