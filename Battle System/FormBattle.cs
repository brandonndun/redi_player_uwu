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


namespace Battle_System
{

    public partial class battlephase : Form
       
    {
        System.Media.SoundPlayer wahahahaha = new System.Media.SoundPlayer(@"C:\Users\erick\Source\Repos\HiItsNiko\SAASAASAA\Battle System\wahlovania.wav");
        System.Media.SoundPlayer defdance = new System.Media.SoundPlayer(@"C:\Users\erick\Downloads\New folder\defdance.wav");
        System.Media.SoundPlayer rageawake = new System.Media.SoundPlayer(@"C:\Users\erick\Source\Repos\HiItsNiko\SAASAASAA\Battle System\rage.wav");
        System.Media.SoundPlayer vimvigor = new System.Media.SoundPlayer(@"C:\Users\erick\Source\Repos\HiItsNiko\SAASAASAA\Battle System\vimvigor.wav");
        static FormMenu form1 = new FormMenu();

        public FormGameOver gameover = new FormGameOver();
        public FormItem formitem = new FormItem();
        static public int gamecount = 0;

        public int atkchose;

        public Random random = new Random();
       

        public int enemychoose = 0;
        public int minigame1count = 0;
        public int minigame2count = 0;
        public int minigame3count = 0;
        

        public int count3 = 0;
        public int count2 = 0;

        public int enemy1atk;
        public int enemy2atk;
        public int enemy3atk;

        public int enemy1health;
        public int enemy2health;
        public int enemy3health;

        public int enemy1speed;
        public int enemy2speed;
        public int enemy3speed;

        public int enemy1choice;
        public int enemy2choice;
        public int enemy3choice;

        public string enemyname1;
        public string enemyname2;
        public string enemyname3;

        public int hero1health;
        public int hero1maxhealth = 100;
        public int hero1atk;
        public int hero1def;
        public int hero1spd;
        public int hero1lvl;

        public int hero2health;
        public int hero2maxhealth = 100;
        public int hero2atk;
        public int hero2def;
        public int hero2spd;
        public int hero2lvl;

        public int hero3health;
        public int hero3maxhealth = 100;
        public int hero3atk;
        public int hero3def;
        public int hero3spd;
        public int hero3lvl;

        public int hero4health;
        public int hero4maxhealth = 100;
        public int hero4atk;
        public int hero4def;
        public int hero4spd;
        public int hero4lvl;


        public battlephase()
            
        {                    
            
            InitializeComponent();

            pictureBoxBgBattle.Controls.Add(enemypic1);
            enemypic1.BackColor = Color.Transparent;
            pictureBoxBgBattle.Controls.Add(enemypic2);
            enemypic2.BackColor = Color.Transparent;
            pictureBoxBgBattle.Controls.Add(enemypic3);
            enemypic3.BackColor = Color.Transparent;
        }
        
        

        private void enemyloader()
        {
            gamecount++;
            if (gamecount == 1)
            {
                //vimvigor.PlayLooping();
                enemy1atk = 5;
                enemy1health = 120;
                enemyhealth1.Maximum = enemy1health;
                enemyhealth1.Value = enemy1health;
                enemy1speed = 9;
                
                enemy2atk = 5;
                enemy2health = 120;
                enemyhealth2.Maximum = enemy2health;
                enemyhealth2.Value = enemy2health;
                enemy2speed = 9;
                
                enemy3atk = 5;
                enemy3health = 120;
                enemyhealth3.Maximum = enemy3health;
                enemyhealth3.Value = enemy3health;
                enemy3speed = 9;
                healthupdate();
            }
            if (gamecount == 2)
            {
                //vimvigor.PlayLooping();
                enemy1atk = 9;
                enemy1health = 130;
                enemyhealth1.Maximum = enemy1health;
                enemyhealth1.Value = enemy1health;
                enemy1speed = 9;
                
                enemy2atk = 7;
                enemy2health = 140;
                enemyhealth2.Maximum = enemy2health;
                enemyhealth2.Value = enemy2health;
                enemy2speed = 9;
                
                enemy3atk = 5;
                enemy3health = 120;
                enemyhealth3.Maximum = enemy3health;
                enemyhealth3.Value = enemy3health;
                enemy3speed = 9;
                healthupdate();

            }
            if (gamecount == 3)
            {
                //rageawake.PlayLooping();
                enemy1atk = 7;
                enemy1health = 150;
                enemyhealth1.Maximum = enemy1health;
                enemyhealth1.Value = enemy1health;
                enemy1speed = 9;
                
                enemy2atk = 7;
                enemy2health = 150;
                enemyhealth2.Maximum = enemy2health;
                enemyhealth2.Value = enemy2health;
                enemy2speed = 9;
                
                enemy3atk = 7;
                enemy3health = 150;
                enemyhealth3.Maximum = enemy3health;
                enemyhealth3.Value = enemy3health;
                enemy3speed = 9;
                healthupdate();

            }
            if (gamecount == 4)
            {
                //vimvigor.PlayLooping();
                enemy1atk = 20;
                enemy1health = 200;
                enemyhealth1.Maximum = enemy1health;
                enemyhealth1.Value = enemy1health;
                enemy1speed = 9;
                
                enemy2atk = 5;
                enemy2health = 150;
                enemyhealth2.Maximum = enemy2health;
                enemyhealth2.Value = enemy2health;
                enemy2speed = 9;
                
                enemy3atk = 15;
                enemy3health = 120;
                enemyhealth3.Maximum = enemy3health;
                enemyhealth3.Value = enemy3health;
                enemy3speed = 9;
                healthupdate();
            }
            if (gamecount == 5)
            {
                //rageawake.PlayLooping();
                enemy1atk = 13;
                enemy1health = 170;
                enemyhealth1.Maximum = enemy1health;
                enemyhealth1.Value = enemy1health;
                enemy1speed = 9;
                
                enemy2atk = 13;
                enemy2health = 170;
                enemyhealth2.Maximum = enemy2health;
                enemyhealth2.Value = enemy2health;
                enemy2speed = 9;
               
                enemy3atk = 13;
                enemy3health = 170;
                enemyhealth3.Maximum = enemy3health;
                enemyhealth3.Value = enemy3health;
                enemy3speed = 9;
                healthupdate();

            }
            if (gamecount == 6)
            {
                //vimvigor.PlayLooping();
                enemy1atk = 20;
                enemy1health = 200;
                enemyhealth1.Maximum = enemy1health;
                enemyhealth1.Value = enemy1health;
                enemy1speed = 9;
                
                enemy2atk = 20;
                enemy2health = 200;
                enemyhealth2.Maximum = enemy2health;
                enemyhealth2.Value = enemy2health;
                enemy2speed = 9;

                enemy3atk = 20;
                enemy3health = 220;
                enemyhealth3.Maximum = enemy3health;
                enemyhealth3.Value = enemy3health;
                enemy3speed = 9;
                healthupdate();

            }
            if (gamecount == 7)
            {
                //rageawake.PlayLooping();
                enemy1atk = 21;
                enemy1health = 240;
                enemyhealth1.Maximum = enemy1health;
                enemyhealth1.Value = enemy1health;
                enemy1speed = 9;
                
                enemy2atk = 18;
                enemy2health = 190;
                enemyhealth2.Maximum = enemy2health;
                enemyhealth2.Value = enemy2health;
                enemy2speed = 9;
                
                enemy3atk = 30;
                enemy3health = 150;
                enemyhealth3.Maximum = enemy3health;
                enemyhealth3.Value = enemy3health;
                enemy3speed = 9;
                healthupdate();

            }
            if (gamecount == 8)
            {
                pictureBoxBgBattle.Image = Properties.Resources.battlebg2;
                enemypic2.Image = Properties.Resources.demon_header;
                this.enemypic2.Size = new System.Drawing.Size(769, 221);
                enemypic2.Location = new Point(412, 59);
                this.enemypic2.SizeMode = PictureBoxSizeMode.StretchImage;
                //wahahahaha.PlayLooping();

                enemypic1.Hide();
                enemypic3.Hide();
                enemyhealth1.Hide();
                enemyhealth3.Hide();

                
                
                
                enemy2atk = 40;
                enemy2health = 1000;
                enemyhealth2.Maximum = enemy2health;
                enemyhealth2.Value = enemy2health;
                enemy2speed = 9;
                
                

                healthupdate();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            outerupdate();
            enemyloader();
            minigametimer1.Interval = 100;
            minigametimer1.Tick += minigame1;
            minigame3button.Hide();
            minigametimer2.Interval = 100;
            minigametimer2.Tick += minigame2;
            minigametimer3.Interval = 100;
            minigametimer3.Tick += minigame3;
            label2.Hide();
            textBox1.Hide();
            herotimer1.Tick += wait1;
            herotimer2.Tick += wait2;
            herotimer3.Tick += wait3;
            herotimer4.Tick += wait4;
            herotimer1.Interval = 100;
            herotimer2.Interval = 100;
            herotimer3.Interval = 100;
            herotimer4.Interval = 100;
            herotimer1.Start();
            herotimer2.Start();
            herotimer3.Start();
            herotimer4.Start();
            globaltimer.Interval = 100;
            globaltimer.Start();
            globaltimer.Tick += enemyaction;
            speedbar1.Value = 0;
            speedbar1.Minimum = 0;
            Speedbar2.Minimum = 0;
            Speedbar3.Minimum = 0;
            Speedbar4.Minimum = 0;
            speedbar1.Maximum = 100;
            Speedbar2.Maximum = 100;
            Speedbar3.Maximum = 100;
            Speedbar4.Maximum = 100;
            HealthBar1.Maximum = Convert.ToInt32(hero1maxhealth);
            Healthbar2.Maximum = Convert.ToInt32(hero2maxhealth);
            Healthbar3.Maximum = Convert.ToInt32(hero3maxhealth);
            Healthbar4.Maximum = Convert.ToInt32(hero4maxhealth);
            HealthBar1.Minimum = 0;
            Healthbar2.Minimum = 0;
            Healthbar3.Minimum = 0;
            Healthbar4.Minimum = 0;
            HealthBar1.Value = Convert.ToInt32(hero1health);
            Healthbar2.Value = Convert.ToInt32(hero2health);
            Healthbar3.Value = Convert.ToInt32(hero3health);
            Healthbar4.Value = Convert.ToInt32(hero4health);
            
            
            Attackbutton1.Enabled = false;
            Skillbutton1.Enabled = false;
            Itembutton1.Enabled = false;

            Attackbutton2.Enabled = false;
            Skillbutton2.Enabled = false;
            Itembutton2.Enabled = false;
            
            Attackbutton3.Enabled = false;
            Skillbutton3.Enabled = false;
            Itemsbutton3.Enabled = false;

            Attackbutton4.Enabled = false;
            Skillbutton4.Enabled = false;
            Itemsbutton4.Enabled = false;
            targeting1.Hide();
            targeting2.Hide();
            targeting3.Hide();
        }
        private void enemyaction(object enemy1, EventArgs enemy1event)
        {
            if (enemyhealth1.Value > 0)
            {
                if (enemy1speed < 100) enemy1speed += 10;
                else
                {
                    enemy1choice = random.Next(0, 3);
                    enemy1speed = 0;


                    if (enemy1choice == 0 && hero1health > 0) hero1health -= enemy1atk - hero1def;
                    else if (enemy1choice == 0 && hero1health == 0)
                    {
                        if (hero2health != 0) hero2health -= enemy1atk - hero2def;
                        else if (hero3health != 0) hero3health -= enemy1atk - hero3def;
                        else if (hero4health != 0) hero4health -= enemy1atk - hero4def;
                    }

                    if (enemy1choice == 1 && hero2health > 0) hero2health -= enemy1atk - hero2def;
                    else if (enemy1choice == 1 && hero2health == 0)
                    {
                        if (hero1health != 0) hero1health -= enemy1atk - hero1def;
                        else if (hero3health != 0) hero3health -= enemy1atk - hero3def;
                        else if (hero4health != 0) hero4health -= enemy1atk - hero4def;
                    }
                    
                    if (enemy1choice == 2 && hero3health > 0) hero3health -= enemy1atk - hero3def;
                    else if (enemy1choice == 2 && hero3health == 0)
                    {
                        if (hero1health != 0) hero1health -= enemy1atk - hero1def;
                        else if (hero2health != 0) hero2health -= enemy1atk - hero2def;
                        else if (hero4health != 0) hero4health -= enemy1atk - hero3def;
                    }

                    if (enemy1choice == 3 && hero4health > 0) hero4health -= enemy1atk - hero4def;
                    else if (enemy1choice == 3 && hero4health == 0)
                    {
                        if (hero1health != 0) hero1health -= enemy1atk - hero1def;
                        else if (hero2health != 0) hero2health -= enemy1atk - hero2def;
                        else if (hero4health != 0) hero4health -= enemy1atk - hero4def;
                    }
                   
                    healthupdate();
                }
            }
            if (enemyhealth2.Value > 0)
            {
                if (enemy2speed < 100) enemy2speed += 10;
                else
                {
                    enemy2choice = random.Next(0, 3);
                    enemy2speed = 0;


                    if (enemy2choice == 0 && hero1health > 0) hero1health -= enemy2atk - hero1def;
                    else if (enemy2choice == 0 && hero1health == 0)
                    {
                        if (hero2health != 0) hero2health -= enemy2atk - hero2def;
                        else if (hero3health != 0) hero3health -= enemy2atk - hero3def;
                        else if (hero4health != 0) hero4health -= enemy2atk - hero4def;
                    }

                    if (enemy2choice == 1 && hero2health > 0) hero2health -= enemy2atk - hero2def;
                    else if (enemy2choice == 1 && hero2health == 0)
                    {
                        if (hero1health != 0) hero1health -= enemy2atk - hero1def;
                        else if (hero3health != 0) hero3health -= enemy2atk - hero3def;
                        else if (hero4health != 0) hero4health -= enemy2atk - hero4def;
                    }

                    if (enemy2choice == 2 && hero3health > 0) hero3health -= enemy2atk - hero3def;
                    else if (enemy2choice == 2 && hero3health == 0)
                    {
                        if (hero1health != 0) hero1health -= enemy2atk - hero1def;
                        else if (hero2health != 0) hero2health -= enemy2atk - hero2def;
                        else if (hero4health != 0) hero4health -= enemy2atk - hero4def;
                    }

                    if (enemy2choice == 3 && hero4health > 0) hero4health -= enemy2atk - hero4def;
                    else if (enemy2choice == 3 && hero4health == 0)
                    {
                        if (hero1health != 0) hero1health -= enemy2atk - hero1def;
                        else if (hero2health != 0) hero2health -= enemy2atk - hero2def;
                        else if (hero4health != 0) hero4health -= enemy2atk - hero3def;
                    }

                    healthupdate();
                }
            }
            if (enemyhealth3.Value > 0)
            {
                if (enemy3speed < 100) enemy3speed += 10;
                else
                {
                    enemy3choice = random.Next(0, 3);
                    enemy3speed = 0;


                    if (enemy3choice == 0 && hero1health > 0) hero1health -= enemy3atk - hero1def;
                    else if (enemy3choice == 0 && hero1health == 0)
                    {
                        if (hero2health != 0) hero2health -= enemy3atk - hero2def;
                        else if (hero3health != 0) hero3health -= enemy3atk - hero3def;
                        else if (hero4health != 0) hero4health -= enemy3atk - hero4def;
                    }

                    if (enemy3choice == 1 && hero2health > 0) hero2health -= enemy3atk - hero2def;
                    else if (enemy3choice == 1 && hero2health == 0)
                    {
                        if (hero1health != 0) hero1health -= enemy3atk - hero1def;
                        else if (hero3health != 0) hero3health -= enemy3atk - hero3def;
                        else if (hero4health != 0) hero4health -= enemy3atk - hero4def;
                    }

                    if (enemy3choice == 2 && hero3health > 0) hero3health -= enemy3atk - hero3def;
                    else if (enemy3choice == 2 && hero3health == 0)
                    {
                        if (hero1health != 0) hero1health -= enemy3atk - hero1def;
                        else if (hero2health != 0) hero2health -= enemy3atk - hero2def;
                        else if (hero4health != 0) hero4health -= enemy3atk - hero4def;
                    }

                    if (enemy3choice == 3 && hero4health > 0) hero4health -= enemy3atk - hero4def;
                    else if (enemy3choice == 3 && hero4health == 0)
                    {
                        if (hero1health != 0) hero1health -= enemy3atk - hero1def;
                        else if (hero2health != 0) hero2health -= enemy3atk - hero2def;
                        else if (hero3health != 0) hero3health -= enemy3atk - hero3def;
                    }

                    healthupdate();
                }
            }
            if (enemyhealth1.Value <= 0 && enemyhealth2.Value <= 0  && enemyhealth3.Value <= 0)
            {
                speedbar1.Value = 0;
                Speedbar2.Value = 0;
                Speedbar3.Value = 0;
                Speedbar4.Value = 0;
                //wahahahaha.Stop();
                //vimvigor.Stop();
                //rageawake.Stop();
                //defdance.Play();
                if (gamecount == 1)
                {
                    globaltimer.Stop();
                    hero1lvl += 1;
                    hero1atk += 3;
                    hero2lvl += 1;
                    hero2atk += 2;
                    hero3lvl += 1;
                    hero3atk += 3;
                    hero4lvl += 1;
                    hero4atk += 3;
                    hero1def += 1;
                    hero2def += 2;
                    hero3def += 1;
                    hero3def += 2;
                    MessageBox.Show("you win. The Enemy Dropped some instant rawon packets ");
                    FormItem.Rawon += 2;
                    this.Close();
                    
                }
                if (gamecount == 2)
                {
                    globaltimer.Stop();
                    hero1lvl += 1;
                    hero1atk += 3;
                    hero2lvl += 1;
                    hero2atk += 2;
                    hero3lvl += 1;
                    hero3atk += 3;
                    hero4lvl += 1;
                    hero4atk += 3;
                    hero1def += 1;
                    hero2def += 2;
                    hero3def += 1;
                    hero3def += 2;
                    MessageBox.Show("You win, i guess you are my little pogchamp come here.");
                    this.Close();
                }
                if (gamecount == 3)
                {
                    globaltimer.Stop();
                    hero1lvl += 1;
                    hero1atk += 3;
                    hero2lvl += 1;
                    hero2atk += 2;
                    hero3lvl += 1;
                    hero3atk += 3;
                    hero4lvl += 1;
                    hero4atk += 3;
                    hero1def += 1;
                    hero2def += 2;
                    hero3def += 1;
                    hero3def += 2;
                    MessageBox.Show("you win, ternyata yang membuat virus kali ini adalah abang mie goreng sebelah, agar kamu tidak memberitahu siapa - siapa dia memberikan 4 bungkus mie goreng");
                    FormItem.MiGoreng += 4;
                    this.Close();
                }
                if (gamecount == 4)
                {
                    globaltimer.Stop();
                    hero1lvl += 1;
                    hero1atk += 3;
                    hero2lvl += 1;
                    hero2atk += 2;
                    hero3lvl += 1;
                    hero3atk += 3;
                    hero4lvl += 1;
                    hero4atk += 3;
                    hero1def += 1;
                    hero2def += 2;
                    hero3def += 1;
                    hero3def += 2;
                    MessageBox.Show("sick win bruh");
                    this.Close();
                }
                if (gamecount == 5)
                {
                    globaltimer.Stop();
                    hero1lvl += 1;
                    hero1atk += 3;
                    hero2lvl += 1;
                    hero2atk += 2;
                    hero3lvl += 1;
                    hero3atk += 3;
                    hero4lvl += 1;
                    hero4atk += 3;
                    hero1def += 1;
                    hero2def += 2;
                    hero3def += 1;
                    hero3def += 2;
                    MessageBox.Show("meh you got lucky");
                    this.Close();
                }
                if (gamecount == 6)
                {
                    globaltimer.Stop();
                    hero1lvl += 1;
                    hero1atk += 3;
                    hero2lvl += 1;
                    hero2atk += 2;
                    hero3lvl += 1;
                    hero3atk += 3;
                    hero4lvl += 1;
                    hero4atk += 3;
                    hero1def += 1;
                    hero2def += 2;
                    hero3def += 1;
                    hero3def += 2;
                    MessageBox.Show("oh! you won... good for you i guess. while i have to narrate this *redacted*. at least you got food");
                    FormItem.Rawon += 3;
                    FormItem.NasiGoreng += 2;
                    this.Close();
                }
                if (gamecount == 7)
                {
                    globaltimer.Stop();
                    hero1lvl += 1;
                    hero1atk += 3;
                    hero2lvl += 1;
                    hero2atk += 2;
                    hero3lvl += 1;
                    hero3atk += 3;
                    hero4lvl += 1;
                    hero4atk += 3;
                    hero1def += 1;
                    hero2def += 2;
                    hero3def += 1;
                    hero3def += 2;
                    MessageBox.Show("kalian menang, sebagai penghargaan kalian boleh makan 4 porsi rendang nasi goreng");
                    FormItem.MiGoreng += 2;
                    FormItem.Rendang += 4;
                    this.Close();
                }
                if (gamecount == 8)
                {
                    globaltimer.Stop();
                    hero1lvl += 1;
                    hero1atk += 3;
                    hero2lvl += 1;
                    hero2atk += 2;
                    hero3lvl += 1;
                    hero3atk += 3;
                    hero4lvl += 1;
                    hero4atk += 3;
                    hero1def += 1;
                    hero2def += 2;
                    hero3def += 1;
                    hero3def += 2;
                    MessageBox.Show("you've defeated the mysterious figure");
                    this.Close();
                }
                if (hero1health == 0) herotimer1.Stop();
                if (hero2health == 0) herotimer2.Stop();
                if (hero3health == 0) herotimer3.Stop();
                if (hero4health == 0) herotimer4.Stop();
               
                
                updateouter();
            }
        }
        private void cekgameover()
        {
            if (hero1health == 0 && hero2health == 0 && hero3health == 0 && hero4health == 0)
            {
                //wahahahaha.Stop();
                //vimvigor.Stop();
                //rageawake.Stop();
                globaltimer.Stop();
                hero1health = 100;
                hero2health = 100;
                hero3health = 100;
                hero4health = 100;
                updateouter();
                gameover.ShowDialog();
                this.Close();
            }
        }
    //the timer system for 'turns' of sorts
    private void wait1 (object hero1, EventArgs hero1event)
        {
            if (speedbar1.Value > 100 ) speedbar1.Value = 100;
            if (speedbar1.Value < 100 && hero1health != 0) speedbar1.Value += hero1spd;

            else
            {
                if (hero1health != 0 )action1(hero1, hero1event);
            }
        }
        private void wait2 (object hero2, EventArgs hero2event)
        {
            if (Speedbar2.Value > 100) Speedbar2.Value = 100;
            if (Speedbar2.Value < 100 && hero2health != 0) Speedbar2.Value += hero2spd;

            else
            {
              if (hero2health != 0)   action2(hero2, hero2event);
            }
        }
        private void wait3 (object hero3, EventArgs hero3event)
        {
            if (Speedbar3.Value > 100) Speedbar3.Value = 100;
            if (Speedbar3.Value < 100 && hero3health != 0) Speedbar3.Value += hero3spd;

            else
            {
                if (hero3health != 0)  action3(hero3, hero3event);
            }
        }
        private void wait4 (object hero4, EventArgs hero4event)
        {
            if (Speedbar4.Value > 100) Speedbar4.Value = 100;
            if (Speedbar4.Value < 100 && hero4health != 0) Speedbar4.Value += hero4spd;

            else
            {
             if (hero4health != 0)   action4(hero4, hero4event);
            }
        }
        //shows when the player can move
        private void action1 (object hero1, EventArgs hero1event)
        {
            herotimer1.Stop();
            Attackbutton1.Enabled = true;
            Skillbutton1.Enabled = true;
            Itembutton1.Enabled = true;
        }
        private void action2 (object hero2, EventArgs hero2event)
        {
            herotimer2.Stop();
            Attackbutton2.Enabled = true;
            Skillbutton2.Enabled = true;
            Itembutton2.Enabled = true;
        }
        private void action3 (object hero3, EventArgs hero3event)
        {
            herotimer3.Stop();
            Attackbutton3.Enabled = true;
            Skillbutton3.Enabled = true;
            Itemsbutton3.Enabled = true;
        }
        private void action4 (object hero4, EventArgs hero4event)
        {
            herotimer4.Stop();
            Attackbutton4.Enabled = true;
            Skillbutton4.Enabled = true;
            Itemsbutton4.Enabled = true;
        }
        //milih attack
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            atkchose = 2;
            targeting2.Show();
            targeting1.Hide();
            targeting3.Hide();
        }
        private void enemypic1_Click(object sender, EventArgs e)
        {
            atkchose = 1;
            targeting1.Show();
            targeting2.Hide();
            targeting3.Hide();
        }

        private void enemypic3_Click(object sender, EventArgs e)
        {
            atkchose = 3;
            targeting3.Show();
            targeting2.Hide();
            targeting1.Hide();
        }
        //attacking
        private void Attackbutton1_Click(object sender, EventArgs e)
        {

            if (atkchose == 1) enemy1health -= hero1atk * 3;
            if (atkchose == 2) enemy2health -= hero1atk * 3;
            if (atkchose == 3) enemy3health -= hero1atk * 3;

            speedbar1.Value = 0;
            Attackbutton1.Enabled = false;
            Skillbutton1.Enabled = false;
            Itembutton1.Enabled = false;
            healthupdate();
            herotimer1.Start();
        }
        private void Attackbutton2_Click(object sender, EventArgs e)
        {
            if (atkchose == 1) enemy1health -= hero2atk * 3;
            if (atkchose == 2) enemy2health -= hero2atk * 3;
            if (atkchose == 3) enemy3health -= hero2atk * 3;

            Speedbar2.Value = 0;
            Attackbutton2.Enabled = false;
            Skillbutton2.Enabled = false;
            Itembutton2.Enabled = false;
            healthupdate();
            herotimer2.Start();
        }

        private void Attackbutton3_Click(object sender, EventArgs e)
        {
            if (atkchose == 1) enemy1health -= hero3atk * 3;
            if (atkchose == 2) enemy2health -= hero3atk * 3;
            if (atkchose == 3) enemy3health -= hero3atk * 3;

            Speedbar3.Value = 0;
            Attackbutton3.Enabled = false;
            Skillbutton3.Enabled = false;
            Itemsbutton3.Enabled = false;
            healthupdate();
            herotimer3.Start();
        }

        private void Attackbutton4_Click(object sender, EventArgs e)
        {
            if (atkchose == 1) enemy1health -= hero4atk * 3;
            if (atkchose == 2) enemy2health -= hero4atk * 3;
            if (atkchose == 3) enemy3health -= hero4atk * 3;

            Speedbar4.Value = 0;
            Attackbutton4.Enabled = false;
            Skillbutton4.Enabled = false;
            Itemsbutton4.Enabled = false;
            healthupdate();
            herotimer4.Start();
        }
        //skill 1 semoga tanganny gk luka or something
        private void Skillbutton1_Click(object sender, EventArgs e)
        {
            herotimer1.Stop();
            speedbar1.Value = 0;
            textBox1.Show();
            label1.Text = "ph'nglui mglw'nafh Cthugha Fomalhaut n'gha-ghaa naf'lthagn.";
            Attackbutton1.Enabled = false;
            Skillbutton1.Enabled = false;
            Itembutton1.Enabled = false;
            minigametimer1.Start();
        }
        private void minigame1(object player1, EventArgs player)
        {
            if (minigame1count != 20)
            {
                minigame1count++;
            }
            else
            {
                label1.Hide();
                if (label1.Text == textBox1.Text)
                {
                    if (atkchose == 1) enemy1health -= 70;
                    if (atkchose == 2) enemy2health -= 70;
                    if (atkchose == 3) enemy3health -= 70;
                    herotimer1.Start();
                    Attackbutton1.Enabled = true;
                    Skillbutton1.Enabled = true;
                    Itembutton1.Enabled = true;
                }


                else hero1health -= hero1health;
                healthupdate(); 
                minigametimer1.Stop();
                textBox1.Hide();
            }
            
        }
        //skill 2 button mash
        private void Skillbutton2_Click(object sender, EventArgs e)
        {
            herotimer2.Stop();
            Speedbar2.Value = 0;
            label2.Show();
            minigametimer2.Start();
            Attackbutton2.Enabled = false;
            Itembutton2.Enabled = false;

        }
        private void minigame2 (object sender, EventArgs e)
        {
         
            if (minigame2count < 20) minigame2count++;
            else
            {
                label2.Hide();
                if (count2 > 100)
                {
                    if (atkchose == 1) enemy1health -= hero2atk * 10;
                    if (atkchose == 2) enemy2health -= hero2atk * 10;
                    if (atkchose == 3) enemy3health -= hero2atk * 10;
                    herotimer2.Start();
                    Attackbutton2.Enabled = true;
                    Skillbutton2.Enabled = true;
                    Itembutton2.Enabled = true;
                }
                else hero2health -= hero2health;
                minigame2count = 0;
                count2 = 0;
                minigametimer2.Stop();
                healthupdate();
                Skillbutton2.Enabled = false;
            }
            
            
        }
        private void Skillbutton2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) count2++;
        }
        //skill 3 a sort of speed aiming? don't know what this is called
        private void Skillbutton3_Click(object sender, EventArgs e)
        {
            herotimer3.Stop();
            Speedbar3.Value = 0;
            minigame3button.Show();
            minigametimer3.Start();
            Attackbutton3.Enabled = false;
            Skillbutton3.Enabled = false;
            Itemsbutton3.Enabled = false;
        }
        private void minigame3(object sender, EventArgs e)
        {

            if (minigame3count < 20) minigame3count++;
            else
            {
                if (count3 >= 25)
                {
                    if (atkchose == 1) enemy1health -= hero3atk * 9;
                    if (atkchose == 2) enemy2health -= hero3atk * 9;
                    if (atkchose == 3) enemy3health -= hero3atk * 9;
                    herotimer3.Start();
                    Attackbutton4.Enabled = true;
                    Skillbutton4.Enabled = true;
                    Itemsbutton4.Enabled = true;
                }
                else hero3health -= hero3health;
                
                healthupdate();
                minigametimer3.Stop();
                minigame3button.Hide();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int random1 = random.Next(48, 402 );
            int random2 = random.Next(157, 1067);
            count3++;
            
            minigame3button.Location = new System.Drawing.Point(random2, random1);
        }



        
        //skill karakter 4 dengan kata lain heal
        private void Skillbutton4_Click(object sender, EventArgs e)
        {
            Speedbar4.Value = 0;
            if (hero1health != 0 )hero1health += 25;
            if (hero1health > 100) hero1health = 100;
            if(hero2health != 0) hero2health += 25;
            if (hero2health > 100) hero2health = 100;
            if (hero3health != 0) hero3health += 25;
            if (hero3health > 100) hero3health = 100;
            if (hero4health != 0) hero4health -= 50;
            if (hero4health < 0) hero4health = 0;
            healthupdate();
        }

        

        
        //update every move
        private void healthupdate()
        {
            if (enemy1health < 0) enemy1health = 0;
            enemyhealth1.Value = enemy1health;
            if (enemy2health < 0) enemy2health = 0;
            enemyhealth2.Value = enemy2health;
            if (enemy3health < 0) enemy3health = 0;
            enemyhealth3.Value = enemy3health;
            if (hero1health < 0) hero1health = 0;
            if (hero2health < 0) hero2health = 0;
            if (hero3health < 0) hero3health = 0;
            if (hero4health < 0) hero4health = 0;
            HealthBar1.Value = hero1health;
            Healthbar2.Value = hero2health;
            Healthbar3.Value = hero3health;
            Healthbar4.Value = hero4health;

        }
        public void outerupdate()
        {
            hero1health = FormMenu.player1health;
            hero1atk = FormMenu.player1attack;
            hero1def = FormMenu.player1defense;
            hero1spd = FormMenu.player1speed;
            hero1lvl = FormMenu.player1lvl;

            hero2health = FormMenu.player2health;
            hero2atk = FormMenu.player2attack;
            hero2def = FormMenu.player2defense;
            hero2spd = FormMenu.player2speed;
            hero2lvl = FormMenu.player2lvl;

            hero3health = FormMenu.player1health;
            hero3atk = FormMenu.player3attack;
            hero3def = FormMenu.player3defense;
            hero3spd = FormMenu.player3speed;
            hero3lvl = FormMenu.player3lvl;

            hero4health = FormMenu.player4health;
            hero4atk = FormMenu.player4attack;
            hero4def = FormMenu.player4defense;
            hero4spd = FormMenu.player4speed;
            hero4lvl = FormMenu.player4lvl;


        }
        public void updateouter()
        {
             FormMenu.player1health = hero1health;
             FormMenu.player1attack = hero1atk;
            FormMenu.player1defense = hero1def;
             FormMenu.player1speed = hero1spd;
            FormMenu.player1lvl = hero1lvl;

            FormMenu.player2health = hero1health;
            FormMenu.player2attack = hero1atk;
            FormMenu.player2defense = hero1def;
            FormMenu.player2speed   = hero1spd;
            FormMenu.player2lvl = hero1lvl;

            FormMenu.player3health = hero3health;
            FormMenu.player3attack = hero3atk;
            FormMenu.player3defense = hero3def;
            FormMenu.player3speed = hero3spd;
            FormMenu.player3lvl = hero3lvl;

            FormMenu.player4health = hero4health;
            FormMenu.player4attack = hero4atk;
            FormMenu.player4defense = hero4def;
            FormMenu.player4speed = hero4spd;
            FormMenu.player4lvl = hero4lvl;
        }


        private void Itembutton1_Click(object sender, EventArgs e)
        {
            formitem.ShowDialog();
        }

        private void Itembutton2_Click(object sender, EventArgs e)
        {
            formitem.ShowDialog();
        }

        private void Itemsbutton3_Click(object sender, EventArgs e)
        {
            formitem.ShowDialog();
        }

        private void Itemsbutton4_Click(object sender, EventArgs e)
        {
            formitem.ShowDialog();

        }

        private void globaltimer_Tick(object sender, EventArgs e)
        {
            cekgameover();
        }
    }
}
    
    

