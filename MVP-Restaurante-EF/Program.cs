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

            var View = new LoginView();
            var db = new RestauranteReservasEntities();

            // Navegación (inyecta la factory al WinFormsNavegador)
            var nav = new WinformsNavegador(new MainPageFactory());

            // Tu “presenter” es AuthService (recibe vista, db y navegador)
            var presenter = new AuthPresenter(View, db, nav);

            Application.Run(View);
        }
    }
}
