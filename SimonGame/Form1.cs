using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace SimonGame
{
    public partial class Form1 : Form
    {
        //Creating a global list to hold pattern of computer
        public static List<int> Pattern = new List<int>();

        //Creating a global int to keep track of user pattern
        public static int guess;

        //Array for sounds
        public static SoundPlayer[] player = new SoundPlayer[5];


        public Form1()
        {
            InitializeComponent();

            Form f = this.FindForm();
            f.Controls.Remove(this);

            MainScreen ms = new MainScreen();
            f.Controls.Add(ms);
        }
    }
}
