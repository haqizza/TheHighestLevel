using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheHighestLevel.Presenters;

namespace TheHighestLevel.Views
{
    interface IMainMenu
    {
        void LoadScoreData();

        void ConnectPresenter(PMainMenu presenter);
    }
}
