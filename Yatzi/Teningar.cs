using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yatzi
{
    // Heldur utan um teninga
    class Teningar
    {
        public int[] teningar;
        public Boolean[] geyma;


        public Teningar() {
            teningar = new int[5];
            geyma = new Boolean[5];

            Random random = new Random();

            for (int i = 0; i < teningar.Length; i++)
            {
                int tala = random.Next(1, 6);
                Debug.WriteLine("nr: " + i + " =");

                teningar[i] = tala;
                Debug.WriteLine(teningar[i]);

                geyma[i] = false;
            }

        }
        public void kastaTeningum()
        {
            Random random = new Random();

            for (int i = 0; i < teningar.Length; i++)
            {
                if (!geyma[i])
                {
                    teningar[i] = random.Next(1, 6);
                }
            }
        }
        public void toggleGeymdur(int index)
        {
            geyma[index] = !geyma[index];
        }
        public Boolean erGeymdur(int index)
        {
            return geyma[index];
        }
    }
}
