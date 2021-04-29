using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yatzi
{
    class YatziLeikur
    {
        private int[] stigatafla;


        public YatziLeikur()
        {
            stigatafla = new int[16];
            for (int i = 0; i < stigatafla.Length; i++)
            {
                stigatafla[i] = -1;
            }
        }
        public int[] getStigatafla() { return stigatafla; }
        public void setStig(int index, int score)
        {
            stigatafla[index] = score;

        }


        // leggur saman alla teninga með tilteknu gildi.
        public int summaEinnTilSex(int value, Teningar teningar)
        {
            int sum = 0;
            for (int i = 0; i < teningar.teningar.Length; i++)
                if (teningar.teningar[i] == value)
                {
                    sum += value;
                }
            return sum;
        }

        // Leitar að n eins teningum, tvennu, þrennu, fernu eða yatzi.
        public int nEins(int fjoldi, Teningar teningar)
        {
            for (int i = 6; i > 0; i--)
            {
                int count = 0;
                for (int j = 0; j < teningar.teningar.Length; j++)
                {
                    if (i == teningar.teningar[j])
                    {
                        count++;
                    }
                    if (count >= fjoldi)
                    {
                        return j * fjoldi;
                    }

                }
            }
            return 0;
        }

        // tvö pör
        public int tvoPor(Teningar teningar)
        {
            int[] tidniTafla = new int[] { 0, 0, 0, 0, 0, 0 };
            for (int j = 6; j > 0; j--)
                for (int i = 0; i < teningar.teningar.Length; i++)
                {
                    if (j == teningar.teningar[i])
                    {
                        tidniTafla[j - 1] += 1;
                    }
                }
            int fjoldiPara = 0;
            int sum = 0;
            for (int i = 6; i > 0; i--)
            {
                if (tidniTafla[i - 1] >= 2)
                {
                    sum += 2 * i;
                    fjoldiPara += 1;
                }
            }

            return sum;
        }

        // n = 1 - litla röð: 1-5 
        // n = 2 - stóra röð: 2-6
        public int rod(int n, Teningar teningar)
        {
            int[] ten = teningar.getTeningar();
            int sum = 0;
            Array.Sort(ten);
            for (int i = 0; i < ten.Length; i++)
            {
                if (i + n == ten[i])
                {
                    sum += i + n;
                }
                else
                {
                    sum = 0;
                }
            }
            return sum;
        }
        // staðfestir fullt hús
        public int fulltHus(Teningar teningar)
        {
            int[] ten = teningar.getTeningar();
            Array.Sort(ten);
            if ((ten[0] == ten[1] && ten[1] == ten[2]) && (ten[3] == ten[4]) || (ten[0] == ten[1] && ten[2] == ten[3]) && (ten[3] == ten[4]))
            {
                return summaAllra(teningar);
            }
            return 0;

        }

        // leggur saman gildi allra teninganna
        public int summaAllra(Teningar teningar)
        {
            int sum = 0;
            for (int i = 0; i < teningar.teningar.Length; i++)
            {
                sum += teningar.teningar[i];
            }
            return sum;
        }
        //tekur saman stigafjöldan fyrir ofan index
        //index = 16 finnur heildarstig
        //index = 6 finnur summu efstu 6 raða.
        public int heildarstig(int index)
        {
            int sum = 0;
            for (int i = 0; i < index; i++)
            {
                if (stigatafla[i] != -1)
                    sum += stigatafla[i];
            }
            return sum;
        }
    }
}
