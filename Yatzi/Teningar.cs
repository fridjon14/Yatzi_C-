using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Resources;

namespace Yatzi
{
    // Heldur utan um teninga
    class Teningar
    {
        public int[] teningar;
        public Boolean[] geyma;
        public int kostEftir;


        public Teningar() {
            teningar = new int[5];
            geyma = new Boolean[5];
            kostEftir = 3;


            for (int i = 0; i < teningar.Length; i++)
            {
                teningar[i] = 0;
                geyma[i] = false;
                kostEftir = 3;
            }

        }
        public void kastaTeningum()
        {
            Random random = new Random();
            for (int i = 0; i < teningar.Length; i++)
            {
                if (!erGeymdur(i))
                {
                    teningar[i] = random.Next(1, 7);
                }
            }
            kostEftir--;
        }
        public void toggleGeymdur(int index)
        {
            geyma[index] = !geyma[index];
        }
        public Boolean erGeymdur(int index)
        {
            return geyma[index];
        }
        public void synaTeninga(int index, PictureBox pBox)
        {
            
            if (erGeymdur(index))
            {
                switch (teningar[index])
                {
                    case 1:
                        pBox.Image = Properties.Resources.b1;
                        break;

                    case 2:
                        pBox.Image = Properties.Resources.b2;
                        break;
                    case 3:
                        pBox.Image = Properties.Resources.b3;
                        break;
                    case 4:
                        pBox.Image = Properties.Resources.b4;
                        break;
                    case 5:
                        pBox.Image = Properties.Resources.b5;
                        break;
                    case 6:
                        pBox.Image = Properties.Resources.b6;
                        break;
                }
                // ResourceManager rm = new ResourceManager("Images", this.GetType().Assembly);
                //pBox.Image = Properties.Resources.b + index);
               // pBox.Image = (System.Drawing.Image)rm.GetObject("b0.png"); 
            }
            else
            {
                switch (teningar[index])
                {
                    case 1:
                        pBox.Image = Properties.Resources._1;
                        break;
                    case 2:
                        pBox.Image = Properties.Resources._2;
                        break;
                    case 3:
                        pBox.Image = Properties.Resources._3;
                        break;
                    case 4:
                        pBox.Image = Properties.Resources._4;
                        break;
                    case 5:
                        pBox.Image = Properties.Resources._5;
                        break;
                    case 6:
                        pBox.Image = Properties.Resources._6;
                        break;
                }
                //ResourceManager rm = new ResourceManager("Images", this.GetType().Assembly);
                //pBox.Image = Properties.Resources.b1; 
                //(System.Drawing.Image)rm.GetObject("Images/0.png");
                // pBox.Image = (@"" + teningar[index] + ".png");
            }
        }
        public int[] getTeningar() { return teningar; }
        
    }
}
