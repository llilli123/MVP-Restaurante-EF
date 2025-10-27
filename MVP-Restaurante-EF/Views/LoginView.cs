using MVP_Restaurante_EF.Interfaces;
using MVP_Restaurante_EF.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVP_Restaurante_EF
{
    public partial class LoginView : Form, ILoginVista

    {
        public LoginView()
        {
            InitializeComponent();
            btnLogin.Click += (s, e) => LoginClicked?.Invoke(this, EventArgs.Empty);
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public string Username => txtUsuario.Text;
        public string Password => txtContrasena.Text;
        public event EventHandler LoginClicked;

        public void ShowError(string message)
        => MessageBox.Show(this, message, "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        public void CloseSelf() => this.Hide();

    }
}
