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
    public partial class FormGameplay : Form
    {
        public FormGameplay()
        {
            InitializeComponent();
            //biar transparan
            pictureBoxFloor.Controls.Add(pictureBoxChara);
            pictureBoxChara.BackColor = Color.Transparent;

            pictureBoxFloor.Controls.Add(pictureBoxUwu);
            pictureBoxUwu.BackColor = Color.Transparent;
            pictureBoxFloor.Controls.Add(pictureBoxDoge);
            pictureBoxDoge.BackColor = Color.Transparent;
            pictureBoxFloor.Controls.Add(pictureBoxDerp);
            pictureBoxDerp.BackColor = Color.Transparent;
            pictureBoxFloor.Controls.Add(pictureBoxMonke);
            pictureBoxMonke.BackColor = Color.Transparent;

            pictureBoxFloor.Controls.Add(pictureBoxButtonItem);
            pictureBoxButtonItem.BackColor = Color.Transparent;

            pictureBoxFloor.Controls.Add(pictureBoxButtonEqt);
            pictureBoxButtonEqt.BackColor = Color.Transparent;

        }
        public battlephase formbattle = new battlephase();
        public int count = 0;
        public int countto = 0;
        public Random random = new Random();
        //counter karakter
        public static int counterChara = 1;
        //counter kiri atau kanan
        public static int counterArah = 1;
        private void FormGameplay_Load(object sender, EventArgs e)
        {
            timerBattle.Stop();
            countto = random.Next(8, 13);
        }

        private void FormGameplay_KeyPress(object sender, KeyPressEventArgs e)
        {
            

        }

        private void FormGameplay_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
            {
                timerBattle.Start();
                pictureBoxFloor.Image = Properties.Resources.FloorDUp;
                counterArah = 1;
                if (counterChara == 1)
                {
                    pictureBoxChara.Image = Properties.Resources.UwUD;
                }
                if (counterChara == 2)
                {
                    pictureBoxChara.Image = Properties.Resources.DogeD;
                }
                if (counterChara == 3)
                {
                    pictureBoxChara.Image = Properties.Resources.MonkeD;
                }
                if (counterChara == 4)
                {
                    pictureBoxChara.Image = Properties.Resources.DerpD;
                }
            }
            if (e.KeyCode == Keys.A)
            {
                timerBattle.Start();
                pictureBoxFloor.Image = Properties.Resources.FloorAUp;
                counterArah = 0;
                if (counterChara == 1)
                {
                    pictureBoxChara.Image = Properties.Resources.UwuA;
                }
                if (counterChara == 2)
                {
                    pictureBoxChara.Image = Properties.Resources.DogeA;
                }
                if (counterChara == 3)
                {
                    pictureBoxChara.Image = Properties.Resources.MonkeA;
                }
                if (counterChara == 4)
                {
                    pictureBoxChara.Image = Properties.Resources.DerpA;
                }
            }
            if (e.KeyCode == Keys.S)
            {
                timerBattle.Stop();
                countto = random.Next(1, 13);
                pictureBoxFloor.Image = Properties.Resources.FloorSteadyUp;
                if (counterArah == 1)
                {
                    if (counterChara == 1)
                    {
                        pictureBoxChara.Image = Properties.Resources.UwUSteadyR;
                    }
                    if (counterChara == 2)
                    {
                        pictureBoxChara.Image = Properties.Resources.DogeSR;
                    }
                    if (counterChara == 3)
                    {
                        pictureBoxChara.Image = Properties.Resources.MonkeSR;
                    }
                    if (counterChara == 4)
                    {
                        pictureBoxChara.Image = Properties.Resources.DerpSR;
                    }
                }
                if (counterArah == 0)
                {
                    if (counterChara == 1)
                    {
                        pictureBoxChara.Image = Properties.Resources.UwUSteadyL;
                    }
                    if (counterChara == 2)
                    {
                        pictureBoxChara.Image = Properties.Resources.DogeSL;
                    }
                    if (counterChara == 3)
                    {
                        pictureBoxChara.Image = Properties.Resources.MonkeSL;
                    }
                    if (counterChara == 4)
                    {
                        pictureBoxChara.Image = Properties.Resources.DerpSL;
                    }
                }
            }
        }

        
        

        private void FormGameplay_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
            {
                

            }
            if (e.KeyCode == Keys.A)
            {
                
                
            }


        }

        private void pictureBoxFloor_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxBody_Click(object sender, EventArgs e)
        {

        }


        private void pictureBoxHead_Click(object sender, EventArgs e)
        {

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void FormGameplau_KeyUp(object sender, KeyEventArgs e)
        {

        }
        private void radioButtonUwU_CheckedChanged(object sender, EventArgs e)
        {
           
        }
        private void radioButtonDoge_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        private void radioButtonMonke_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        private void RadioButtonDerp_CheckedChanged(object sender, EventArgs e)
        {
            
        }


        private void pictureBoxUwu_Click(object sender, EventArgs e)
        {
            counterChara = 1;

            pictureBoxFloor.Image = Properties.Resources.FloorSteadyUp;
            if (counterArah == 1)
            {
                pictureBoxChara.Image = Properties.Resources.UwUSteadyR;
            }
            if(counterArah == 0)
            {
                pictureBoxChara.Image = Properties.Resources.UwUSteadyL;
            }
        }

        private void pictureBoxDoge_Click(object sender, EventArgs e)
        {
            counterChara = 2;

            pictureBoxFloor.Image = Properties.Resources.FloorSteadyUp;
            if (counterArah == 1)
            {
                pictureBoxChara.Image = Properties.Resources.DogeSR;
            }
            if (counterArah == 0)
            {
                pictureBoxChara.Image = Properties.Resources.DogeSL;
            }
        }

        private void pictureBoxMonke_Click(object sender, EventArgs e)
        {
            counterChara = 3;

            pictureBoxFloor.Image = Properties.Resources.FloorSteadyUp;
            if (counterArah == 1)
            {
                pictureBoxChara.Image = Properties.Resources.MonkeSR;
            }
            if (counterArah == 0)
            {
                pictureBoxChara.Image = Properties.Resources.MonkeSL;
            }
        }

        private void pictureBoxDerp_Click(object sender, EventArgs e)
        {
            counterChara = 4;

            pictureBoxFloor.Image = Properties.Resources.FloorSteadyUp;
            if (counterArah == 1)
            {
                pictureBoxChara.Image = Properties.Resources.DerpSR;
            }
            if (counterArah == 0)
            {
                pictureBoxChara.Image = Properties.Resources.DerpSL;
            }
        }

        private void timerBattle_Tick(object sender, EventArgs e)
        {
            tick();
        }
        private void tick()
        {
            if (count < countto) count++;
            else if (count == countto)
            {
                timerBattle.Stop();
                count = 0;
                countto = random.Next(8, 13);
                formbattle.ShowDialog();
            }
        }

        private void pictureBoxButtonItem_Click(object sender, EventArgs e)
        {
            FormItem myForm = new FormItem();
            myForm.ShowDialog();
        }

        private void pictureBoxButtonEqt_Click(object sender, EventArgs e)
        {
            SystemAttack myForm = new SystemAttack();
            myForm.ShowDialog();
        }
    }
}
