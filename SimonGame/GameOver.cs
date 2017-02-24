using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace SimonGame
{
    public partial class GameOver : UserControl
    {
        public GameOver()
        {
            InitializeComponent();

            //Rounds Played Output and counting rounds
            Form1.Pattern.Count();
            roundsPlayedOutput.Text = Convert.ToString(Form1.Pattern.Count());
        }


        private void endGameButton_Click(object sender, EventArgs e)
        {
            //When pressing the endgame button, go back to mainscreen
            Form f = this.FindForm();
            f.Controls.Remove(this);

            MainScreen ms = new MainScreen();
            f.Controls.Add(ms);
        }        
    }
}
