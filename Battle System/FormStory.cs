using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Media;

namespace Battle_System
{
    public partial class FormStory : Form
    {
        System.Media.SoundPlayer intro = new System.Media.SoundPlayer(@"C:\Users\erick\Downloads\a.wav");
        public FormStory()
        {
            InitializeComponent();
        }
        private void FormStory_Load(object sender, EventArgs e)
        {
            //intro.Play();
        }
        private void FormStory_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void FormStory_KeyDown(object sender, KeyEventArgs e)
        {
            //opening gameplay form using f key
            if (e.KeyCode == Keys.F)
            {
                intro.Stop();
                FormGameplay myForm = new FormGameplay();
                this.Hide();
                myForm.ShowDialog();
                this.Close();
            }
        }

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
