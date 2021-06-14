using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheHighestLevel.Models;
using TheHighestLevel.Views;

namespace TheHighestLevel.Presenters
{
    public class PMainMenu : IPMainMenu
    {
        MainScreen mainScreen;
        MainMenu mainMenu;
        public string playerName { get; set; }

        public PMainMenu()
        {

        }

        public void ConnectScreens(MainScreen mainScreen, MainMenu mainMenu)
        {
            this.mainScreen = mainScreen;
            this.mainMenu = mainMenu;
        }

        public void GameStart()
        {
            mainMenu.Visible = false;
            mainScreen.pGamePlay.GameStart();
        }

        public DataTable GetUserTable()
        {
            UserTable userTable = new();

            return userTable.GetUserTable();
        }

        public void CloseApplication()
        {
            mainScreen.Close();
        }
    }
}
