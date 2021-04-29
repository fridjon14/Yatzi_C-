using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                pBox.ImageLocation = @"C:\Users\fridjon14\source\repos\Yatzi\Yatzi\images\blue\" + teningar[index] + ".png";
            }
            else
            {
                pBox.ImageLocation = @"C:\Users\fridjon14\source\repos\Yatzi\Yatzi\images\white\" + teningar[index] + ".png";
            }
        }
        public int[] getTeningar() { return teningar; }
        
    }
}
