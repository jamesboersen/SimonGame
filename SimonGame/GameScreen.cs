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
            //Adding Sounds to Array
            Form1.player[0] = new SoundPlayer(SimonGame.Properties.Resources.green);
            Form1.player[1] = new SoundPlayer(SimonGame.Properties.Resources.red);
            Form1.player[2] = new SoundPlayer(SimonGame.Properties.Resources.blue);
            Form1.player[3] = new SoundPlayer(SimonGame.Properties.Resources.yellow);
            Form1.player[4] = new SoundPlayer(SimonGame.Properties.Resources.mistake);

            //Delays the game to start
            Thread.Sleep(1000);

            //Plays ComputerTurn
            ComputerTurn();


        }

        //Increasing difficulty
        int progress = 0;

        //Automates computers turn
        private void ComputerTurn()
        {
            //Random Number generator
            Random rnd = new Random();

            Form1.Pattern.Add(rnd.Next(1, 5));


            //going through the list and outputing with different colors
            for (int i = 0; i < Form1.Pattern.Count(); i++)
            {
                //If Pattern is 1 then flash green and play sound         
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
                //If Pattern is 2 then flash Red and play sound
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
                //If Pattern is 3 then flash blue and play sound
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
                //If Pattern is 4 then flash yellow and play sound
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
                Form1.guess.Clear();
                progress = 0;
            }
        }

        private void greenButton_Click(object sender, EventArgs e)
        {
            Form1.guess.Add(1);
            if (Form1.guess[progress] == 1)
            {
                greenButton.BackColor = Color.Gray;
                Refresh();
                Thread.Sleep(500);
                Form1.player[0].Play();
                greenButton.BackColor = Color.Green;
                Refresh();
                Thread.Sleep(500);
                progress++;
                if (progress == Form1.Pattern.Count())
                {
                    ComputerTurn();
                }
                else
                {
                    Form f = this.FindForm();
                    f.Controls.Remove(this);

                    GameOver go = new GameOver();
                    f.Controls.Add(go);
                }
            }

        }

        private void redButton_Click(object sender, EventArgs e)
        {
            Form1.guess.Add(2);
            if (Form1.guess[progress] == 2)
            {
                redButton.BackColor = Color.Gray;
                Refresh();
                Thread.Sleep(500);
                Form1.player[1].Play();
                redButton.BackColor = Color.Red;
                Refresh();
                Thread.Sleep(500);
                progress++;

                if (progress == Form1.Pattern.Count())
                {
                    ComputerTurn();
                }
                else
                {
                    Form f = this.FindForm();
                    f.Controls.Remove(this);

                    GameOver go = new GameOver();
                    f.Controls.Add(go);
                }

            }
        }

        private void blueButton_Click(object sender, EventArgs e)
        {
            Form1.guess.Add(3);
            if (Form1.guess[progress] == 3)
            {
                blueButton.BackColor = Color.Gray;
                Refresh();
                Thread.Sleep(500);
                Form1.player[2].Play();
                blueButton.BackColor = Color.Blue;
                Refresh();
                Thread.Sleep(500);
                progress++;

                if (progress == Form1.Pattern.Count())
                {
                    ComputerTurn();
                }
                else
                {
                    Form f = this.FindForm();
                    f.Controls.Remove(this);

                    GameOver go = new GameOver();
                    f.Controls.Add(go);
                }
            }
        }

        private void yellowButton_Click(object sender, EventArgs e)
        {
            Form1.guess.Add(4);
            if (Form1.guess[progress] == 4)
            {
                yellowButton.BackColor = Color.Gray;
                Refresh();
                Thread.Sleep(500);
                Form1.player[3].Play();
                yellowButton.BackColor = Color.Yellow;
                Refresh();
                Thread.Sleep(500);
                progress++;

                if (progress == Form1.Pattern.Count())
                {
                    ComputerTurn();
                }
                else
                {
                    Form f = this.FindForm();
                    f.Controls.Remove(this);

                    GameOver go = new GameOver();
                    f.Controls.Add(go);
                }
            }
        }
    }
}
