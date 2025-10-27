using MVP_Restaurante_EF.Services;
using MVP_Restaurante_EF.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVP_Restaurante_EF
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // 1) ÚNICA instancia de la vista
            var view = new LoginView();

            // 2) DbContext del EDMX
            var db = new RestauranteReservasEntities();

            // 3) Suscripción del evento (AuthService se engancha a view.LoginClicked)
            var auth = new AuthService(view, db);
            Application.Run(new RegistroClientesView());
        }
    }
}
