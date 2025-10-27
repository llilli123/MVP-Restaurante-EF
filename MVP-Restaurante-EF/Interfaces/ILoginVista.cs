using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_Restaurante_EF.Interfaces
{
    public interface ILoginVista
    {
        string Username { get; }
        string Password { get; }
        event EventHandler LoginClicked;

        void ShowError(string message);
        void CloseSelf();
    }
}
