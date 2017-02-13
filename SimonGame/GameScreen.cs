using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            

               
        }
    }
}
