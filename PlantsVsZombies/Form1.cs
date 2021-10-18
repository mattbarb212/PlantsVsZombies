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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MenuScreen mS = new MenuScreen();

            this.Controls.Add(mS);

            mS.Location = new Point((this.Width - mS.Width) / 2, (this.Height - mS.Height) / 2);
        }
    }
}
