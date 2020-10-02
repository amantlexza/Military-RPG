using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Military_RPG
{
    public partial class Form1 : Form
    {
        int x, y, bCenter, bMiddle, pCenter, pMiddle, sCenter, cCenter, speed;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            speed = 1;
            //plane.Height will be distance
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            militaryBase.Top += 1;
            enemyCamp.Top += 1;
            enemySquad.Top += 1;

            bCenter = militaryBase.Left + militaryBase.Width / 2;
            bMiddle = militaryBase.Bottom + militaryBase.Height / 2;
            pCenter = plane.Left + plane.Width / 2;
            pMiddle = plane.Bottom + plane.Height / 2;
            sCenter = enemySquad.Left + enemySquad.Width / 2;
            cCenter = enemyCamp.Left + enemyCamp.Width / 2;

            if ((plane.Left <= militaryBase.Right && plane.Left >= militaryBase.Left)  || ((plane.Right <= militaryBase.Right && plane.Right >= militaryBase.Left)))
            {
                //qualifies as straight ahead
                StraightAhead(sCenter, bCenter, cCenter);
            }
            else if (plane.Left < militaryBase.Left)
            {
                //qualifies as diagonal ahead but base is right
                DiagonalToRight(pCenter,bCenter,pMiddle,bMiddle);
                
            }
            else if (plane.Right >= militaryBase.Right)
            {
                //qualifies as diagonal ahead but base is left
                DiagonalToLeft(pCenter,bCenter,pMiddle,bMiddle);
            }

            if (pMiddle == bMiddle)
            {
                if ((plane.Left <= militaryBase.Right && plane.Left >= militaryBase.Left) || ((plane.Right <= militaryBase.Right && plane.Right >= militaryBase.Left)))
                {
                    timer1.Stop();
                    MessageBox.Show("Arrived successfully");
                }
            }

        }
        private void StraightAhead(int sCenter, int bCenter, int cCenter) {
            
            if ((plane.Top - plane.Height) <= (enemySquad.Bottom + plane.Height) && (plane.Top - plane.Height) >= enemySquad.Top)
            {
                //plane.Top += MinSpeed(speed);

                //check for squad close proximity
                if (plane.Left >= (enemySquad.Left - plane.Width) && plane.Right <= (enemySquad.Right + plane.Width))
                {
                    //bullet
                    //LeftOrRight(sCenter,bCenter,enemySquad.Right,enemySquad.Left,speed);
                }
            }
            else if ((plane.Top - plane.Height) <= (enemyCamp.Bottom + plane.Height) && (plane.Top - plane.Height) >= enemyCamp.Top)
            {
                //check for camp close proximity
                if (plane.Left >= (enemyCamp.Left - plane.Width) && plane.Right <= (enemyCamp.Right + plane.Width))
                {
                    //bullet
                    //LeftOrRight(cCenter, bCenter, enemyCamp.Right, enemyCamp.Left,speed);
                }
            }
        }
        public void DiagonalToRight(int pCenter, int bCenter,int pMiddle,int bMiddle) {
            x = Math.Abs(bCenter - pCenter);
            y = Math.Abs(pMiddle - bMiddle);
            speed = x / y;
            plane.Left += MinSpeed(speed);

            if ((plane.Top - plane.Height) <= (enemySquad.Bottom + plane.Height) && (plane.Top - plane.Height) >= enemySquad.Top)
            {
                //check for squad close proximity
                if (plane.Left >= (enemySquad.Left - plane.Width) && plane.Right <= (enemySquad.Right + plane.Width))
                {
                    //MessageBox.Show("squad");
                    //bullet
                    // LeftOrRight(sCenter, bCenter, enemySquad.Right, enemySquad.Left,speed);
                }
                else
                {
                    //no bullet
                }
            }
            else if ((plane.Top - plane.Height) <= (enemyCamp.Bottom + plane.Height) && (plane.Top - plane.Height) >= enemyCamp.Top)
            {
                //check for camp close proximity
                if (plane.Left >= (enemyCamp.Left - plane.Width) && plane.Right <= (enemyCamp.Right + plane.Width))
                {
                    MessageBox.Show("camp");
                    //bullet
                    //LeftOrRight(cCenter, bCenter, enemyCamp.Right, enemyCamp.Left,speed);
                }
                else
                {
                    //no bullet
                }
            }
        }
        public void DiagonalToLeft(int pCenter, int bCenter, int pMiddle, int bMiddle)
        {
            x = Math.Abs(pCenter - bCenter);
            y = Math.Abs(pMiddle - bMiddle);
            speed = x / y;
            plane.Left -= MinSpeed(speed);

            if ((plane.Top - plane.Height) <= (enemySquad.Bottom + plane.Height) && (plane.Top - plane.Height) >= enemySquad.Top)
            {
                //check for squad close proximity
                if (plane.Left >= (enemySquad.Left - plane.Width) && plane.Right <= (enemySquad.Right + plane.Width))
                {
                    //MessageBox.Show("squad close");
                    //bullet
                    // LeftOrRight(sCenter, bCenter, enemySquad.Right, enemySquad.Left,speed);
                }
                else
                {
                    //no bullet
                }
            }
            else if ((plane.Top - plane.Height) <= (enemyCamp.Bottom + plane.Height) && (plane.Top - plane.Height) >= enemyCamp.Top)
            {
                //check for camp close proximity
                if (plane.Left >= (enemyCamp.Left - plane.Width) && plane.Right <= (enemyCamp.Right + plane.Width))
                {
                    //MessageBox.Show("camp close");
                    //bullet
                    //LeftOrRight(cCenter, bCenter, enemyCamp.Right, enemyCamp.Left,speed);
                }
                else
                {
                    //no bullet
                }
            }
        }
        public void LeftOrRight(int eCenter,int bCenter,int enemyRight,int enemyLeft,int speed) {
            //check if best plane movement is left or right
            if (eCenter <= bCenter)
            {
                //plane.Left += speed;
                plane.Left = enemyRight + plane.Width + 1;
            }
            else
            {
                //plane.Left -= MinSpeed(speed);
                plane.Left = enemyLeft - plane.Width - 1;
            }
        }
        public int MinSpeed(int speed) {
            if (speed<1)
            {
                return 1;
            }
            else
            {
                return speed;
            }
        }
    }
}
