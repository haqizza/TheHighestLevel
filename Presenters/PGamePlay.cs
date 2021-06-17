using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheHighestLevel.Views;
using TheHighestLevel.Models;
using System.Data;
using System.IO;
using TheHighestLevel.Properties;
using System.Media;

namespace TheHighestLevel.Presenters
{
    public class PGamePlay: Player
    {
        public string username { get; set; }
        int fail = 0;
        int success = 0;

        private MainScreen mainScreen;
        private GamePlay gamePlay;
        private KeyInput keyInput;

        private PictureBox player;

        // player control
        public bool goRight { get; set; }
        public bool goLeft { get; set; }
        public bool jump { get; set; }
        // player setting
        int playerSpeed = 10;
        int jumpSpeed = 25;
        int g = 8;

        public int currentFloor { get; set; }

        enum STATE
        {
            PLAY,
            GAMEOVER,
            STANDBY
        }
        //game state
        STATE gameState = STATE.PLAY;

        //Thread gb sound
        Task sound;

        public PGamePlay()
        {
        }

        public void ConnectScreens(MainScreen mainScreen, GamePlay gamePlay)
        {
            this.mainScreen = mainScreen;
            this.gamePlay = gamePlay;

            username = mainScreen.playerName;
        }

        public void SetPlayer(PictureBox player)
        {
            this.player = player;
        }

        public void GameStart()
        {
            //setting KeyInput
            keyInput = new KeyInput(this);

            //tampilkan view GamePlay
            mainScreen.Controls.Add(gamePlay);

            currentFloor = -1;

            //play ssound
            sound = new(PlayBGSound);
            sound.Start();
        }

        public void PlayBGSound()
        {
            SoundPlayer audio = new SoundPlayer(Resources.bgs);
            audio.Play();
        }

        public bool CheckGameStatus()
        {
            return gameState == STATE.GAMEOVER ? false : true;
        }

        public void KeyHandler(Keys keyCode)
        {
            keyInput.KeyPressed(keyCode);
        }

        public void KeyUp(Keys keyCode)
        {
            keyInput.KeyUp(keyCode);
        }

        public void PlayerMove()
        {
            if (gameState != STATE.GAMEOVER)
            {
                //jika gnya 0, berhenti
                if (jump && g <= 0)
                {
                    jump = false;
                }

                //pergerakan player
                if (goRight)
                {
                    player.Left += playerSpeed;
                }
                if (goLeft)
                {
                    player.Left -= playerSpeed;
                }
                if (jump)
                {
                    //jika dalam keadaan jump, speed ditambah dan gnya dikurangi
                    g -= 1;
                    jumpSpeed = -20;
                }
                else
                {
                    jumpSpeed = 20;
                }

                //efek gravitasi
                player.Top += jumpSpeed;

                //batas player ke tepi
                if (player.Left <= 0)
                {
                    player.Left = 0;
                }
                if (player.Left >= 750)
                {
                    player.Left = 750;
                }

                FallCheck();

                Landing();
            }
        }

        public void Landing()
        {
            foreach (Control x in gamePlay.Controls)
            {
                if (x is PictureBox && ((string)x.Tag).Contains("brick"))
                {
                    if( player.Bounds.IntersectsWith(x.Bounds))
                    {
                        //ketika jump
                        if (jump)
                        {
                            //jika player terkena Bottom dari brick, hentikan
                            g -= g;
                            player.Top = x.Bottom;
                            fail += 1;
                            gamePlay.fail += 1;
                        }
                        else
                        {
                            //jika player terkena Top dari brick, daratkan
                            if (((string) x.Tag).Contains((currentFloor + 1).ToString()))
                            {
                                success += 1;
                                gamePlay.success += 1;
                                currentFloor += 1;
                                gamePlay.MoveLevel();
                            }
                            g = 8;
                            player.Top = x.Top - player.Height;
                        }
                    }
                }
            }
        }

        public void FallCheck()
        {
            if(player.Bottom >= 550)
            {
                GameOver();
            }
        }

        public void GameOver()
        {
            gameState = STATE.GAMEOVER;
        }

        public void SaveScore()
        {
            UserTable userTable = new();
            DataTable table = userTable.GetUserTable();
            
            if (userTable.Find(username))
            {
                userTable.Update(username, fail, success);
            }
            else
            {
                userTable.Add(username, fail, success);
            }
        }

        public void Restart()
        {
            SaveScore();
            mainScreen.Restart();
        }
    }
}
