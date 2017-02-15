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
                if (Form1.Pattern[i] == 1)
                {
                    greenButton.BackColor = Color.Gray;
                    Refresh();
                    Thread.Sleep(500);
                    greenButton.BackColor = Color.Green;
                    Refresh();
                    Thread.Sleep(500);
                }
                if (Form1.Pattern[i] == 2)
                {
                    redButton.BackColor = Color.Gray;
                    Refresh();
                    Thread.Sleep(500);
                    redButton.BackColor = Color.Red;
                    Refresh();
                    Thread.Sleep(500);
                }            
                if (Form1.Pattern[i] == 3)
                {
                    blueButton.BackColor = Color.Gray;
                    Refresh();
                    Thread.Sleep(500);
                    blueButton.BackColor = Color.Blue;
                    Refresh();
                    Thread.Sleep(500);
                } 
                if (Form1.Pattern[i] == 4)
                {
                    yellowButton.BackColor = Color.Gray;
                    Refresh();
                    Thread.Sleep(500);
                    yellowButton.BackColor = Color.Yellow;
                    Refresh();
                    Thread.Sleep(500);
                }
            }
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            ComputerTurn();
        }
    }
}
