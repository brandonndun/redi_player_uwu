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
    public partial class FormGameOver : Form
    {
        public FormGameOver()
        {
            InitializeComponent();
        }
        //public battlephase formbattle = new battlephase();
        private void button2_Click(object sender, EventArgs e)
        {
            battlephase.gamecount--;
            
            
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FormGameOver_Load(object sender, EventArgs e)
        {

        }
    }
}
