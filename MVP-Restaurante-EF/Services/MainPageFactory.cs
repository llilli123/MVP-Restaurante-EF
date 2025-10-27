using MVP_Restaurante_EF.Interfaces;
using MVP_Restaurante_EF.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVP_Restaurante_EF.Services
{
    public class MainPageFactory : IMainPageFactory
    {
        public Form Create() => new MainPageViewcs();
    }
}