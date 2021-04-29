using System;
using System.Diagnostics;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yatzi
{
    public partial class Form1 : Form
    {
        PictureBox[] myPictureBoxes;
        
        public Form1()
        {
            InitializeComponent();
            myPictureBoxes = new PictureBox[] { pictureBox1, pictureBox2, pictureBox3, pictureBox5, pictureBox4 };
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            Teningar teningar = new Teningar();
            teningar.kastaTeningum();
            for (int i = 0; i < teningar.teningar.Length; i++){
                myPictureBoxes[i].ImageLocation = @"C:\Users\fridjon14\source\repos\Yatzi\Yatzi\images\white\" + teningar.teningar[i] + ".png";
                Debug.WriteLine(teningar.teningar[i]);
               // pictureBox1.ImageLocation = @"C:\Users\fridjon14\source\repos\Yatzi\Yatzi\images\white\" + teningar.teningar[i] + ".png";
            }
        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBox teningur = sender as PictureBox;
            for(int i = 0; i < myPictureBoxes.Length; i++)
            {
                if(myPictureBoxes[i] == teningur)
                {
                   // myPictureBoxes[i].ImageLocation = @"C:\Users\fridjon14\source\repos\Yatzi\Yatzi\images\white\" + teningar.teningar[i] + ".png";

                }
            }

        }
    }
}
