using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;



namespace PlantsVsZombies
{
    public partial class GameScreen : UserControl
    {
        public GameScreen()
        {
            InitializeComponent();
        }

        Boolean upArrowKeyDown, downArrowKeyDown, leftArrowKeyDown, rightArrowKeyDown, mKeyDown, nKeyDown, bKeyDown, spaceKeyDown;

        SolidBrush drawBrush = new SolidBrush(Color.White);
        SolidBrush greenBrush = new SolidBrush(Color.Green);
        
        Image peaShooter;
        Image zombie;

        Font font = new Font("ariel", 20);
        Font font2 = new Font("ariel", 15);

        List<Plant> plants = new List<Plant>();
        List<Zombies> zombies = new List<Zombies>();

        int newPlantX = 200;
        int counter = 0;
        

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    upArrowKeyDown = true;
                    break;
                case Keys.Down:
                    downArrowKeyDown = true;
                    break;
                case Keys.Left:
                    leftArrowKeyDown = true;
                    break;
                case Keys.Right:
                    rightArrowKeyDown = true;
                    break;
                case Keys.M:
                    mKeyDown = true;
                    break;
                case Keys.N:
                    nKeyDown = true;
                    break;
                case Keys.B:
                    bKeyDown = true;
                    break;
                case Keys.Space:
                    spaceKeyDown = true;
                    break;

            }
        }

        

        private void GameScreen_Load(object sender, EventArgs e)
        {
            peaShooter = Properties.Resources.peaShooter;
            zombie = Properties.Resources.zombie;

            Zombies newZombies = new Zombies(700, 20, 125, 1);
            zombies.Add(newZombies);
        }

        private void GameScreen_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    upArrowKeyDown = true;
                    break;
                case Keys.Down:
                    downArrowKeyDown = true;
                    break;
                case Keys.Left:
                    leftArrowKeyDown = true;
                    break;
                case Keys.Right:
                    rightArrowKeyDown = true;
                    break;
                case Keys.M:
                    mKeyDown = true;
                    break;
                case Keys.N:
                    nKeyDown = true;
                    break;
                case Keys.B:
                    bKeyDown = true;
                    break;
                case Keys.Space:
                    spaceKeyDown = true;
                    break;
                
            }
        }
        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    upArrowKeyDown = false;
                    break;
                case Keys.Down:
                    downArrowKeyDown = false;
                    break;
                case Keys.Left:
                    leftArrowKeyDown = false;
                    break;
                case Keys.Right:
                    rightArrowKeyDown = false;
                    break;
                case Keys.M:
                    mKeyDown = false;
                    break;
                case Keys.N:
                    nKeyDown = false;
                    break;
                case Keys.B:
                    bKeyDown = false;
                    break;
                case Keys.Space:
                    spaceKeyDown = false;
                    break;

            }
        }
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            counter++;
            counterLabel.Text = $"{counter}";

            if (mKeyDown == true && counter >100)
            {
                Plant newPlant = new Plant(newPlantX, 50, 60);
                plants.Add(newPlant);
                newPlantX += 60;
                counter -= 100;
            }
            

            foreach(Zombies z in zombies)
            {
                z.x -= 1;
                
            }
            

            Refresh();
        }
        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            foreach(Plant p in plants)
            {
                e.Graphics.DrawImage(peaShooter, p.x, p.y, p.size, p.size);
            }
            foreach (Zombies z in zombies)
            {
                e.Graphics.DrawImage(zombie, z.x, z.y, z.size, z.size);
            }

            e.Graphics.FillRectangle(drawBrush, 30, 50, 120, 160);
            e.Graphics.DrawImage(peaShooter, 30, 50, 100, 100);
            e.Graphics.DrawString($"100", font, greenBrush, 50, 150);
            e.Graphics.DrawString($"M to Place", font2, greenBrush, 30, 180);
        }
    }
}
