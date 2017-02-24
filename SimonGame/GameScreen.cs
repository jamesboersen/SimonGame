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

            //Adding Random number to pattern
            Form1.Pattern.Add(rnd.Next(1, 5));


            //going through the list and outputing with different colors
            for (int i = 0; i < Form1.Pattern.Count(); i++)
            {
                //If Pattern is 1 then flash green and play sound         
                if (Form1.Pattern[i] == 1)
                {
                    //flashing button and playing a sound then changing back to original
                    greenButton.BackColor = Color.Gray;
                    Refresh();
                    Form1.player[0].Play();
                    Thread.Sleep(500);
                    Refresh();
                    greenButton.BackColor = Color.Green;
                    Refresh();
                    Thread.Sleep(500);
                }
                //If Pattern is 2 then flash Red and play sound
                if (Form1.Pattern[i] == 2)
                {
                    //flashing button and playing a sound then changing back to original
                    redButton.BackColor = Color.Gray;
                    Refresh();
                    Form1.player[1].Play();
                    Thread.Sleep(500);
                    Refresh();
                    redButton.BackColor = Color.Red;
                    Refresh();
                    Thread.Sleep(500);
                }
                //If Pattern is 3 then flash blue and play sound
                if (Form1.Pattern[i] == 3)
                {
                    //flashing button and playing a sound then changing back to original
                    blueButton.BackColor = Color.Gray;
                    Refresh();
                    Form1.player[2].Play();
                    Thread.Sleep(500);
                    Refresh();
                    blueButton.BackColor = Color.Blue;
                    Refresh();
                    Thread.Sleep(500);
                }
                //If Pattern is 4 then flash yellow and play sound
                if (Form1.Pattern[i] == 4)
                {
                    //flashing button and playing a sound then changing back to original
                    yellowButton.BackColor = Color.Gray;
                    Refresh();
                    Form1.player[3].Play();
                    Thread.Sleep(500);
                    Refresh();
                    yellowButton.BackColor = Color.Yellow;
                    Refresh();
                    Thread.Sleep(500);
                }
            }
        }

        //compares player guesses to pattern
        private void CompareMethod()
        {
            progress++;

            for (int i = 0; i < progress; i++)
            {
                //if pattern does not equal guest
                if (Form1.Pattern[i] != Form1.guess[i])
                {
                    //play mistake sound
                    Form1.player[4].Play();
                    
                    //goes to gamover screen
                    Form f = this.FindForm();
                    f.Controls.Remove(this);

                    GameOver go = new GameOver();
                    f.Controls.Add(go);
                }
                else
                {
                    //if it does, refresh the page
                    Refresh();
                }
            }

            //if progress equals Pattern, clear guess, and run computerTurn
            if (progress == Form1.Pattern.Count)
            {
                Form1.guess.Clear();
                progress = 0;
                Thread.Sleep(500);
                ComputerTurn();
            }
        }


        //What to do when greenButton is clicked
        private void greenButton_Click(object sender, EventArgs e)
        {
            //Flash color and play sound
            Form1.guess.Add(1);
            greenButton.BackColor = Color.Gray;
            Refresh();
            Thread.Sleep(500);
            Form1.player[0].Play();
            greenButton.BackColor = Color.Green;
            Refresh();
            Thread.Sleep(500);
            //Run the compareMethod
            CompareMethod();
        }

        //what to do if redButton is clicked
        private void redButton_Click(object sender, EventArgs e)
        {
            //Flash color and play sound
            Form1.guess.Add(2);
            redButton.BackColor = Color.Gray;
            Refresh();
            Thread.Sleep(500);
            Form1.player[1].Play();
            redButton.BackColor = Color.Red;
            Refresh();
            Thread.Sleep(500);
            //Run the compareMethod
            CompareMethod();
        }

        //what to do if blueButton is clicked
        private void blueButton_Click(object sender, EventArgs e)
        {
            //Flash color and play sound
            Form1.guess.Add(3);
            blueButton.BackColor = Color.Gray;
            Refresh();
            Thread.Sleep(500);
            Form1.player[2].Play();
            blueButton.BackColor = Color.Blue;
            Refresh();
            Thread.Sleep(500);
            //Run the compareMethod
            CompareMethod();
        }

        //what to do if yellowButton is clicked
        private void yellowButton_Click(object sender, EventArgs e)
        {
            //Flash color and play sound
            Form1.guess.Add(4);
            yellowButton.BackColor = Color.Gray;
            Refresh();
            Thread.Sleep(500);
            Form1.player[3].Play();
            yellowButton.BackColor = Color.Yellow;
            Refresh();
            Thread.Sleep(500);
            //Run the compareMethod
            CompareMethod();
        }
    }
}
