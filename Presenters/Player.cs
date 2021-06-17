using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheHighestLevel.Presenters
{

    interface Player
    {
        bool goRight { get; set; }

        bool goLeft { get; set; }

        bool jump { get; set; }

        void SetPlayer(PictureBox player);

        void PlayerMove();

        void FallCheck();

        void GameOver();

        void SaveScore();

        void Restart();
    }
}
