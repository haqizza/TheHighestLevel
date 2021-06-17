using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheHighestLevel.Presenters
{
    public class KeyInput
    {
        PGamePlay player;

        public KeyInput()
        {

        }

        public KeyInput(PGamePlay player)
        {
            this.player = player;
        }

        public void KeyPressed(Keys keyCode)
        {
            if(keyCode == Keys.D)
            {
                player.goRight = true;
            }
            if(keyCode == Keys.A)
            {
                player.goLeft = true;
            }
            if(keyCode == Keys.W && !player.jump)
            {
                player.jump = true;
            }
            if (keyCode == Keys.Space)
            {
                player.Restart();
            }
        }

        public void KeyUp(Keys keyCode)
        {
            if (keyCode == Keys.D)
            {
                player.goRight = false;
            }
            if (keyCode == Keys.A)
            {
                player.goLeft = false;
            }
            if (player.jump)
            {
                player.jump = false;
            }
        }
    }
}
