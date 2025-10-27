using MVP_Restaurante_EF.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace MVP_Restaurante_EF.Services
{
    public class AuthPresenter
    {
        private readonly ILoginVista _view;
        private readonly RestauranteReservasEntities _db;
        private readonly INavegador _nav;

        public AuthPresenter(ILoginVista view, RestauranteReservasEntities db, INavegador nav)
        {
            _view = view;
            _db = db;
            _nav = nav;
            _view.LoginClicked += OnLoginClicked;
        }

        private void OnLoginClicked(object sender, EventArgs e)
        {
            var username = _view.Username?.Trim();
            var password = _view.Password ?? string.Empty;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrEmpty(password))
            {
                _view.ShowError("Usuario y contraseña son requeridos.");
                return;
            }

            // Comparación directa (texto plano)
            var ok = _db.usuarios.Any(u => u.Usuario1 == username && u.Password == password);
            

            if (!ok)
            {
                _view.ShowError("Usuario o contraseña inválidos.");
                return;
            }

            _nav.ShowMainPage();
            _view.CloseSelf();


        }
    }
}
