using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheHighestLevel.Presenters;
using TheHighestLevel.Views;

namespace TheHighestLevel
{
        //**************************************
        // Saya Muhammad Izzatul Haq mengerjakan evaluasi Tugas Masa Depan dalam mata kuliah
        // Desain dan Pemrograman Berorientasi Objek untuk keberkahanNya maka saya
        // tidak melakukan kecurangan seperti yang telah dispesifikasikan.Aamiin.
        //**************************************
    public partial class MainScreen : Form
    {
        public PGamePlay pGamePlay = new();
        public PMainMenu pMainMenu = new();
        public GamePlay gamePlay = new();
        public MainMenu mainMenu = new();
        private string playerName { get; set; }

        public enum SCREEN
        {
            MENU,
            PLAY
        }

        public SCREEN screenState = SCREEN.MENU;


        public MainScreen()
        {
            InitializeComponent();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            mainMenu.ConnectPresenter(pMainMenu);
            pMainMenu.ConnectScreens(this, mainMenu);
            gamePlay.ConnectPresenter(pGamePlay);
            pGamePlay.ConnectScreens(this, gamePlay);

            Controls.Add(mainMenu);


            playerName = pMainMenu.playerName;
            

            // Controls.Remove(mainMenu);
        }
    }
}
