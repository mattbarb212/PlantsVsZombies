using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace PlantsVsZombies
{
    public partial class MenuScreen : UserControl
    {
        public MenuScreen()
        {
            InitializeComponent();
        }

        private void MenuScreen_Load(object sender, EventArgs e)
        {

        }

        private void playButton_Click(object sender, EventArgs e)
        {
            playButton.Enabled = false;
            playButton.Visible = false;

            GameScreen gS = new GameScreen();

            this.Controls.Add(gS);

            gS.Location = new Point((this.Width - gS.Width) / 2, (this.Height - gS.Height) / 2);
            gS.Focus();
        }
    }
}
