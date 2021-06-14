using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheHighestLevel.Presenters;
using TheHighestLevel.Models;

namespace TheHighestLevel.Views
{
    public partial class MainMenu : UserControl, IMainMenu
    {
        private string playerName = "";
        private PMainMenu presenter = new();

        public MainMenu()
        {
            InitializeComponent();
        }

        public void ConnectPresenter(PMainMenu presenter)
        {
            this.presenter = presenter;
        }

        private void btn_mulai_Click(object sender, EventArgs e)
        {
            // simpan username
            playerName = tb_username.Text.Length != 0 ?
                tb_username.Text
                :
                scoreTable.CurrentRow.Cells[0].Value.ToString();
            // set username di presenter
            presenter.playerName = playerName;
            // start game
            presenter.GameStart();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            LoadScoreData();
        }

        public void LoadScoreData()
        {
            DataTable table = presenter.GetUserTable();

            BindingSource bindSource = new();
            table.Columns.RemoveAt(0);
            bindSource.DataSource = table;

            scoreTable.DataSource = bindSource;
            scoreTable.ReadOnly = true;
        }

        private void MainMenu_VisibleChanged(object sender, EventArgs e)
        {
            // jika dirubah menjadi visible
            if (this.Visible)
            {
                // load ulang data tabel score
                LoadScoreData();
            }
        }

        private void btn_keluar_Click(object sender, EventArgs e)
        {
            presenter.CloseApplication();
        }
    }
}
