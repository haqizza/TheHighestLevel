using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheHighestLevel.Views;

namespace TheHighestLevel.Presenters
{
    interface IPMainMenu
    {
        void ConnectScreens(MainScreen mainScreen, MainMenu mainMenu);
        void GameStart();
        DataTable GetUserTable();
        void CloseApplication();

    }
}
