using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheHighestLevel.Views;

namespace TheHighestLevel.Presenters
{
    public class PGamePlay
    {
        private MainScreen mainScreen;
        private GamePlay gamePlay;

        public PGamePlay()
        {

        }

        public void ConnectScreens(MainScreen mainScreen, GamePlay gamePlay)
        {
            this.mainScreen = mainScreen;
            this.gamePlay = gamePlay;
        }

        public void GameStart()
        {
            mainScreen.Controls.Add(gamePlay);
        }
    }
}
