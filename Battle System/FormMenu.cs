using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battle_System
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        public static int player1health = 100;
        public static int player1attack = 10;
        public static int player1defense = 0;
        public static int player1speed = 10;
        public static int player1lvl = 1;

        public static int player2health = 100;
        public static int player2attack = 10;
        public static int player2defense = 0;
        public static int player2speed = 10;
        public static int player2lvl = 1;

        public static int player3health = 100;
        public static int player3attack= 10;
        public static int player3defense = 0;
        public static int player3speed = 10;
        public static int player3lvl = 1;

        public static int player4health = 100;
        public static int player4attack = 10;
        public static int player4defense = 0;
        public static int player4speed = 10;
        public static int player4lvl = 1;


        private void picBoxBegin_Click(object sender, EventArgs e)
        {
            //to open a new form
            FormStory myForm = new FormStory();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }
        private void FormMenu_Load_1(object sender, EventArgs e)
        {
            //transparent begin picture box
            pictureBoxMenu.Controls.Add(pictureBoxBegin);
            pictureBoxBegin.BackColor = Color.Transparent;

            //transparent game name picture box
            pictureBoxMenu.Controls.Add(pictureBoxName);
            pictureBoxName.BackColor = Color.Transparent;
        }







        private void picBoxPlay_MouseClick(object sender, MouseEventArgs e)
        {
          
        }

        private void picBoxName_Click(object sender, EventArgs e)
        {

        }

        private void picBoxPlay_Click_1(object sender, EventArgs e)
        {

        }
        private void picBoxUIMenu_Click(object sender, EventArgs e)
        {

        }

        private void picBoxPlay_Click(object sender, EventArgs e)
        {

        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxMenu_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxName_Click(object sender, EventArgs e)
        {

        }
    }
}
