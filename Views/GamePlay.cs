using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheHighestLevel.Properties;
using TheHighestLevel.Presenters;
using System.Diagnostics;

namespace TheHighestLevel.Views
{
    public partial class GamePlay : UserControl
    {
        PGamePlay presenter;
        Random rnd = new();

        PictureBox[][] bricks;

        int floorNumber = 0;

        PictureBox[] addBricks;

        public int fail 
        { 
            get => Convert.ToInt32(lbl_FailScore.Text);
            set => lbl_FailScore.Text = value.ToString();
        }
        public int success
        {
            get => Convert.ToInt32(lbl_SuccessScore.Text);
            set => lbl_SuccessScore.Text = value.ToString();
        }


        public GamePlay()
        {
            InitializeComponent();
        }

        public void ConnectPresenter(PGamePlay presenter)
        {
            this.presenter = presenter;
            presenter.SetPlayer(player);
        }

        private void GamePlay_Load(object sender, EventArgs e)
        {
            GenerateBricks();
        }

        private void GenerateBricks()
        {
            floor0.BackgroundImage = (Image)Resources.ResourceManager.GetObject("_1");

            int laneNumber = 10;
            int laneLength = 30;
            int i, j;

            bricks = new PictureBox[laneNumber][];

            
            for (i = 0; i< laneNumber; i++)
            {
                bricks[i] = new PictureBox[laneLength];
            }


            int y = 470;
            int color = 1;

            for (i = 0; i < laneNumber; i++)
            {
                int left = 0;
                int left1 = -1 * 75 * 20;
                for (j = 0; j < laneLength; j++)
                {
                    bricks[i][j] = new PictureBox();
                    bricks[i][j].Height = 30;
                    bricks[i][j].Width = 75;

                    if (!(rnd.Next(30) % 3 == 0))
                    {
                        bricks[i][j].Tag = "brick, "+ floorNumber.ToString();
                        bricks[i][j].Image = (Image)Resources.ResourceManager.GetObject("_" + (color+1).ToString());
                    }
                    else
                    {
                        bricks[i][j].Tag = "space";
                    }

                    if (i % 2 == 0)
                    {
                        bricks[i][j].Location = new Point(left, y - 120);
                    }
                    else
                    {
                        bricks[i][j].Location = new Point(left1, y - 120);
                    }

                    Controls.Add(bricks[i][j]);
                    left += 75;
                    left1 += 75;
                }

                y -= 120;

                color += 1;
                color = color >= 9 ? 0 : color;

                floorNumber += 1;
            }
        }

        private void GenerateAdditionalFloor()
        {
            addBricks = new PictureBox[30];

            int y = Controls[Controls.Count - 1].Top;
            int color = rnd.Next(8);

            int left = 0;
            int left1 = -1 * 75 * 20;

            int i;

            for (i = 0; i < 30; i++)
            {
                addBricks[i] = new PictureBox();
                addBricks[i].Height = 30;
                addBricks[i].Width = 75;

                if (!(rnd.Next(30) % 3 == 0))
                {
                    addBricks[i].Tag = "brick, " + floorNumber.ToString();
                    addBricks[i].Image = (Image)Resources.ResourceManager.GetObject("_" + (color + 1).ToString());
                }
                else
                {
                    addBricks[i].Image = (Image)Resources.ResourceManager.GetObject("_player");
                    addBricks[i].Tag = "space";
                }

                if (floorNumber % 2 == 0)
                {
                    addBricks[i].Location = new Point(left1, y - 120);
                }
                else
                {
                    addBricks[i].Location = new Point(left1, y - 120);
                }

                //tambahkan object ke layar
                Controls.Add(addBricks[i]);

                left += 75;
                left1 += 75;
            }
            //tambah jumlah lantai
            floorNumber += 1;
        }

        private void lbl_title_Click(object sender, EventArgs e)
        {

        }

        private void GamePlay_KeyDown(object sender, KeyEventArgs e)
        {
            presenter.KeyHandler(e.KeyCode);
        }

        private void GamePlay_KeyUp(object sender, KeyEventArgs e)
        {
            presenter.KeyUp(e.KeyCode);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            presenter.PlayerMove();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            foreach (Control x in Controls)
            {
                if (x is PictureBox && x != player)
                {
                    x.Left += 1;
                }
            }
            if (!presenter.CheckGameStatus())
            {
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                presenter.Restart();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            GenerateAdditionalFloor();
            if (presenter.currentFloor > 0 && presenter.currentFloor % 4 == 0)
            {
            }
        }

        public void MoveLevel()
        {
            foreach (Control x in Controls)
            {
                if (x is PictureBox && x != player)
                {
                    x.Top += 120;
                }

            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            int i = 0;
            foreach (Control x in Controls)
            {
                if (x is PictureBox && x != player)
                {
                    Controls.Remove(x);
                    i++;
                }
                if (i >= 30)
                {
                    break;
                }
            }
        }
    }
}
