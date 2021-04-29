using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Yatzi
{
    public partial class Form1 : Form
    {
        PictureBox[] myPictureBoxes;
        Button[] myButtons;
        Label[] myLabels;
        Teningar teningar = new Teningar();
        YatziLeikur leikur = new YatziLeikur();

        public Form1()
        {
            InitializeComponent();
            myPictureBoxes = new PictureBox[] { pictureBox1, pictureBox2, pictureBox3, pictureBox5, pictureBox4 };
            myButtons = new Button[] { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15 };
            myLabels = new Label[] { label1, label2, label3, label4, label5, label6, label7, label8, label9, label10, label11, label12, label13, label14, label15, label17 };
        }



        private void button16_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            teningar.kastaTeningum();
            enableOnotadirButtons();
            for (int i = 0; i < teningar.teningar.Length; i++){
                teningar.synaTeninga(i, myPictureBoxes[i]);
            }
            if(teningar.kostEftir == 0)
            {
                button.Enabled = false;
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBox teningur = sender as PictureBox;
            for(int i = 0; i < myPictureBoxes.Length; i++)
            {
                if(myPictureBoxes[i] == teningur)
                {
                    teningar.toggleGeymdur(i);
                    teningar.synaTeninga(i, myPictureBoxes[i]);
                }
            }

         
        }
        private void enableOnotadirButtons()
        {
            Debug.WriteLine("Enable unused buttons");
            int[] stig;
            stig = leikur.getStigatafla();
            Debug.WriteLine(stig.Length - 1);
         
            for (int i = 0; i < stig.Length - 1; i++)
            {
                if (stig[i] == -1)
                {
                    myButtons[i].Enabled = true;
                }
            }
        
        }

        private void disableAllirButtons()
        {
            Debug.WriteLine("Disable");
            for(int i = 0; i < myButtons.Length; i++)
            {
                myButtons[i].Enabled = false;
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            int buttonNumer = Array.IndexOf(myButtons, button);
            switch (buttonNumer)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    leikur.setStig(buttonNumer, leikur.summaEinnTilSex(buttonNumer + 1, teningar));
                    break;
                case 6:

                    break;
            }
            synaStigatoflu();
            disableAllirButtons();
            nyUmferd();

        }
        public void nyUmferd()
        {
            teningar = new Teningar();
            button16.Enabled = true;
        }
        public void synaStigatoflu() 
        {
            int[] stigatafla = leikur.getStigatafla();
            for(int i = 0; i < stigatafla.Length; i++)
            {
                if(stigatafla[i] != -1)
                {
                    myLabels[i].Text = stigatafla[i].ToString();
                }
            }

        }
    }
}
