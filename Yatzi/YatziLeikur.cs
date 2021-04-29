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
            for(int i = 0; i < stigatafla.Length; i++)
            {
                stigatafla[i] = -1;
            }
        }
        public int[] getStigatafla() { return stigatafla; }
        public void setStig(int index, int score)
        {
            stigatafla[index] = score;
            
        }

        public int summaEinnTilSex(int value, Teningar teningar)
        {
            int sum = 0;
            for (int i = 0; i < teningar.teningar.Length; i++)
                if( teningar.teningar[i] == value)
                {
                    sum += value;
                }
            return sum;
        }
        public int nEins(int fjoldi, Teningar teningar)
        {
            for(int i = 6; i > 0; i--)
            {
                int count = 0;
                for (int j = 0; j < teningar.teningar.Length; j++)
                {
                    if (i == teningar.teningar[j])
                    {
                        count++;
                    }
                    if(count >= fjoldi)
                    {
                        return j * fjoldi;
                    }

                }
            }
            return 0;
        }
        public int tvoPor(Teningar teningar)
        {
            int[] tidniTafla = new int[] { 0, 0, 0, 0, 0, 0 };
            for( int j = 6; j > 0; j--)
                for(int i = 0; i < teningar.teningar.Length; i++)
                {
                    if(j == teningar.teningar[i])
                    {
                        tidniTafla[j - 1] += 1;
                    }
                }
            int fjoldiPara = 0;
            int sum = 0;
            for(int i = 6; i > 0; i--)
            {
                if(tidniTafla[i - 1] >= 2)
                {
                    sum += 2 * i;
                    fjoldiPara += 1;
                }
            }
            
            return sum;
        }
    }
}
//int[] ten = teningar.getTeningar();
//Array.Sort(ten);