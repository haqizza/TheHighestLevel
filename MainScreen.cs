using System;
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
        public string playerName { get; set; }


        public MainScreen()
        {
            InitializeComponent();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            InitiateObjects();
        }

        private void InitiateObjects()
        {
            mainMenu.ConnectPresenter(pMainMenu);
            pMainMenu.ConnectScreens(this, mainMenu);
            gamePlay.ConnectPresenter(pGamePlay);
            pGamePlay.ConnectScreens(this, gamePlay);

            Controls.Add(mainMenu);

            playerName = pMainMenu.playerName;
        }

        public void Restart()
        {
            Controls.Clear();

            pGamePlay = null;
            pMainMenu = null;
            gamePlay = null;
            mainMenu = null;


            pGamePlay = new();
            pMainMenu = new();
            gamePlay = new();
            mainMenu = new();
            InitiateObjects();
        }
    }
}
