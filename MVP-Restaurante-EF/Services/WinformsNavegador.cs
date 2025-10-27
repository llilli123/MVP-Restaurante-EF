using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVP_Restaurante_EF.Interfaces;

namespace MVP_Restaurante_EF.Services
{
    public class WinformsNavegador : INavegador
    {
        private readonly IMainPageFactory _factory;
        public WinformsNavegador(IMainPageFactory factory) => _factory = factory;

        public void ShowMainPage()
        {
            var main = _factory.Create();
            main.Show();
        }
    }
}
