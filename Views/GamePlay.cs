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

namespace TheHighestLevel.Views
{
    public partial class GamePlay : UserControl
    {
        PGamePlay presenter;

        public GamePlay()
        {
            InitializeComponent();
        }
        public void ConnectPresenter(PGamePlay presenter)
        {
            this.presenter = presenter;
        }

        private void GamePlay_Load(object sender, EventArgs e)
        {
            floor0.Image = Resources._1;
        }


        private void lbl_title_Click(object sender, EventArgs e)
        {

        }
    }
}
