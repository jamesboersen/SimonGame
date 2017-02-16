using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace SimonGame
{
    public partial class GameScreen : UserControl
    {
        public GameScreen()
        {
            InitializeComponent();


            //Clears the global list
            Form1.Pattern.Clear();

            //Refreshes the page
            Refresh();

            //Pause the program for a bit 
            Thread.Sleep(1000);          
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            //Plays ComputerTurn
            ComputerTurn();

            //Adding Sounds to Array
            Form1.player[0] = new SoundPlayer(SimonGame.Properties.Resources.green);
            Form1.player[1] = new SoundPlayer(SimonGame.Properties.Resources.red);
            Form1.player[2] = new SoundPlayer(SimonGame.Properties.Resources.blue);
            Form1.player[3] = new SoundPlayer(SimonGame.Properties.Resources.yellow);
            Form1.player[4] = new SoundPlayer(SimonGame.Properties.Resources.mistake);
        }

        //Increasing difficulty
        int progress = 1;

        //Automates computers turn
        private void ComputerTurn()
        {
            //Random Number generator
            Random rnd = new Random();


            for (int i = 0; i < 4; i++)
            {
                Form1.Pattern.Add(rnd.Next(1, 5));
            }

            //going through the list and outputing with different colors
            for (int i = 0; i < progress; i++)
            {      
                //If Pattern is 1 then flash green          
                if (Form1.Pattern[i] == 1)
                {
                    greenButton.BackColor = Color.Gray;
                    Refresh();
                    Thread.Sleep(500);
                    Form1.player[0].Play();
                    Refresh();
                    greenButton.BackColor = Color.Green;
                    Refresh();
                    Thread.Sleep(500);
                }
                //If Pattern is 2 then flash Red
                if (Form1.Pattern[i] == 2)
                {
                    redButton.BackColor = Color.Gray;
                    Refresh();
                    Thread.Sleep(500);
                    Form1.player[1].Play();
                    Refresh();
                    redButton.BackColor = Color.Red;
                    Refresh();
                    Thread.Sleep(500);
                }            
                //If Pattern is 3 then flash blue
                if (Form1.Pattern[i] == 3)
                {
                    blueButton.BackColor = Color.Gray;
                    Refresh();
                    Thread.Sleep(500);
                    Form1.player[2].Play();
                    Refresh();
                    blueButton.BackColor = Color.Blue;
                    Refresh();
                    Thread.Sleep(500);
                } 
                //If Pattern is 4 then flash yellow
                if (Form1.Pattern[i] == 4)
                {
                    yellowButton.BackColor = Color.Gray;
                    Refresh();
                    Thread.Sleep(500);
                    Form1.player[3].Play();
                    Refresh();
                    yellowButton.BackColor = Color.Yellow;
                    Refresh();
                    Thread.Sleep(500);
                }
            }
        }
    }
}
