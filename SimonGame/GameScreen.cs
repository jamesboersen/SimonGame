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
        //Automates computers turn
        private void ComputerTurn()
        {
            //Random Number generator
            Random rnd = new Random();
            int rndnumber = rnd.Next(1, 4);

            //adding colors to list
            Form1.Pattern.Add(1);
            Form1.Pattern.Add(2);
            Form1.Pattern.Add(3);
            Form1.Pattern.Add(4);

            //going through the list and outputing with different colors
            for (int i = 0; i <= 4; i++)
            {                
                if (i == 1)
                {
                    greenButton.BackColor = Color.LimeGreen;
                    Thread.Sleep(500);
                }
                if (i == 2)
                {
                    redButton.BackColor = Color.Crimson;
                    Thread.Sleep(500);
                }            
                if (i == 3)
                {
                    blueButton.BackColor = Color.LightBlue;
                    Thread.Sleep(500);
                } 
                if (i == 4)
                {
                    yellowButton.BackColor = Color.LightYellow;
                    Thread.Sleep(500);
                }
            }
        }
    }
}
