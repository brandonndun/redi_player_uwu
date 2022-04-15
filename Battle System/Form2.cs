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
    public partial class FormItem : Form
    {
        public FormItem()
        {
            InitializeComponent();
        }
        public FormMenu formmenu = new FormMenu();

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
        private void Form2_Load(object sender, EventArgs e)
        {
            //Input list item di combo box
            outerupdate();
            ItemList.Items.Add("Rawon");
            ItemList.Items.Add("Nasi Goreng");
            ItemList.Items.Add("Mi Goreng");
            ItemList.Items.Add("Rendang");

            pictureBoxBgItem.Controls.Add(pictureItem);
            pictureItem.BackColor = Color.Transparent;


        }

        //MENG-INPUT JUMLAH ITEM
        public static int Rawon = 0;
        public static int NasiGoreng = 0;
        public static int MiGoreng = 0;
        public static int Rendang = 0;






        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            tombol1.Enabled = true;
            tombol2.Enabled = true;
            tombol3.Enabled = true;
            tombol4.Enabled = true;

            // CODE PENGATURAN BUTTON UNTUK MENENTUKAN JUMLAH ITEM, JIKA ITEM SUDAH DI ANGKA 0 , MAKA BUTTON SEMUA MATI

            if (ItemList.Text == "Rawon")
            {
                if (Rawon < 1)
                {
                    tombol1.Enabled = false;
                    tombol2.Enabled = false;
                    tombol3.Enabled = false;
                    tombol4.Enabled = false;
                }
          
                labelNamaMakanan.Text = "Rawon";
                DeskripsiMakanan.Text = "Rawon with local wisdom which ";
            }
            else if (ItemList.Text == "Nasi Goreng")
            {
                if (NasiGoreng < 1)
                {
                    tombol1.Enabled = false;
                    tombol2.Enabled = false;
                    tombol3.Enabled = false;
                    tombol4.Enabled = false;

                }
                labelNamaMakanan.Text = "Nasi Goreng";
            }
            else if (ItemList.Text == "Mi Goreng")
            {
                if (MiGoreng < 1)
                {
                    tombol1.Enabled = false;
                    tombol2.Enabled = false;
                    tombol3.Enabled = false;
                    tombol4.Enabled = false;

                }
                labelNamaMakanan.Text = "Mi Goreng";
            }
            else if (ItemList.Text == "Rendang")
            {
                if (Rendang < 1)
                {
                    tombol1.Enabled = false;
                    tombol2.Enabled = false;
                    tombol3.Enabled = false;
                    tombol4.Enabled = false;

                }
                labelNamaMakanan.Text = "Rendang";
            }
            
            // MENGELUARKAN JUMLAH ITEM DI LABEL 2

            if (ItemList.SelectedItem.ToString() == "Rawon")
            {
                labelJumlah.Text = "Amount : " + Rawon;
            }
            else if (ItemList.SelectedItem.ToString() == "Nasi Goreng")
            {
                labelJumlah.Text = "Amount : " + NasiGoreng;
            }
            else if (ItemList.SelectedItem.ToString() == "Mi Goreng")
            {
                labelJumlah.Text = "Amount : " + MiGoreng;
            }
            else if (ItemList.SelectedItem.ToString() == "Rendang")
            {
                labelJumlah.Text = "Amount : " + Rendang;
            }

            //CODE MENGUBAH GAMBAR YANG ADA DI PICTURE BOX AGAR SESUAI DENGAN ITEM YANG DIPILIH

            if (ItemList.Text == "Rawon")
            {
                pictureItem.Image = Properties.Resources.RAWON;
            }
            else if (ItemList.Text == "Nasi Goreng")
            {
                pictureItem.Image = Properties.Resources.Nasi_Goreng;
            }
            else if (ItemList.Text == "Mi Goreng")
            {
                pictureItem.Image = Properties.Resources.Mi_Goreng;
            }
            else if (ItemList.Text == "Rendang")
            {
                pictureItem.Image = Properties.Resources.Rendang;
            }

            //Code Menambahkan Deskripsi makanan

            if (ItemList.Text == "Rawon")
            {
                DeskripsiMakanan.Text = "Rawon instan merek Bamboe. heals you a bit. ";
            }
            else if (ItemList.Text == "Nasi Goreng")
            {
                DeskripsiMakanan.Text = "Nasi Goreng Ibunda. gives you determination. +atk ";
            }
            else if (ItemList.Text == "Mi Goreng")
            {
                DeskripsiMakanan.Text = "Indomie rasa ORigInAL. +def ";
            }
            else if (ItemList.Text == "Rendang")
            {
                DeskripsiMakanan.Text = "Rendang asli Minangkabau. heals a LOT";
            }



        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // CODE YANG DIMANA AGAR JUMLAH ITEM LIST JIKA DIPENCET TOMBOL BUTTON BISA MENGURANG

            if (ItemList.SelectedItem.ToString() == "Rawon")
            {
                if (hero1health >= 0)hero1health += 25;
                if (hero1health > 100) hero1health = 100;
                Rawon--;
                labelJumlah.Text = "Amount : " + Rawon;
                if (Rawon < 1)
                {
                    tombol1.Enabled = false;
                    tombol2.Enabled = false;
                    tombol3.Enabled = false;
                    tombol4.Enabled = false;

                }
            }
            else if (ItemList.SelectedItem.ToString() == "Nasi Goreng")
            {
                hero1atk += 2;
               
                NasiGoreng--;
                labelJumlah.Text = "Amount : " + NasiGoreng;
                if (NasiGoreng < 1)
                {
                    tombol1.Enabled = false;
                    tombol2.Enabled = false;
                    tombol3.Enabled = false;
                    tombol4.Enabled = false;

                }
            }
            else if (ItemList.SelectedItem.ToString() == "Mi Goreng")
            {
                hero1def += 2;
                
                MiGoreng--;
                labelJumlah.Text = "Amount : " + MiGoreng;
                if (MiGoreng < 1)
                {
                    tombol1.Enabled = false;
                    tombol2.Enabled = false;
                    tombol3.Enabled = false;
                    tombol4.Enabled = false;

                }
               
            }
            else if (ItemList.SelectedItem.ToString() == "Rendang")
            {
                if (hero1health >= 0)hero1health += 50;
                if (hero1health > 100) hero1health = 100;
                Rendang--;
                labelJumlah.Text = "Amount : " + Rendang;
                if (Rendang< 1)
                {
                    tombol1.Enabled = false;
                    tombol2.Enabled = false;
                    tombol3.Enabled = false;
                    tombol4.Enabled = false;

                }
            }
            updateouter();
        }

        private void tombol2_Click(object sender, EventArgs e)
        {
            if (ItemList.SelectedItem.ToString() == "Rawon")
            {
                if (hero2health >= 0)hero2health += 25;
                if (hero2health > 100) hero2health = 100;
                Rawon--;
                labelJumlah.Text = "Amount : " + Rawon;
                if (Rawon < 1)
                {
                    tombol1.Enabled = false;
                    tombol2.Enabled = false;
                    tombol3.Enabled = false;
                    tombol4.Enabled = false;

                }
            }
            else if (ItemList.SelectedItem.ToString() == "Nasi Goreng")
            {
                hero2atk += 2;
                NasiGoreng--;
                labelJumlah.Text = "Amount : " + NasiGoreng;
                if (NasiGoreng < 1)
                {
                    tombol1.Enabled = false;
                    tombol2.Enabled = false;
                    tombol3.Enabled = false;
                    tombol4.Enabled = false;

                }

            }
            else if (ItemList.SelectedItem.ToString() == "Mi Goreng")
            {
                hero2def += 2;
                MiGoreng--;
                labelJumlah.Text = "Amount : " + MiGoreng;
                if (MiGoreng < 1)
                {
                    tombol1.Enabled = false;
                    tombol2.Enabled = false;
                    tombol3.Enabled = false;
                    tombol4.Enabled = false;

                }

            }
            else if (ItemList.SelectedItem.ToString() == "Rendang")
            {
                if (hero2health >= 0)hero2health += 50;
                if (hero2health > 100) hero2health = 100;
                Rendang--;
                labelJumlah.Text = "Amount : " + Rendang;
                if (Rendang < 1)
                {
                    tombol1.Enabled = false;
                    tombol2.Enabled = false;
                    tombol3.Enabled = false;
                    tombol4.Enabled = false;

                }
            }
            updateouter();
        }

        private void tombol3_Click(object sender, EventArgs e)
        {
            if (ItemList.SelectedItem.ToString() == "Rawon")
            {
               if (hero3health >= 0) hero3health += 25;
                if (hero3health > 100) hero3health = 100;
                Rawon--;
                labelJumlah.Text = "Amount : " + Rawon;
                if (Rawon < 1)
                {
                    tombol1.Enabled = false;
                    tombol2.Enabled = false;
                    tombol3.Enabled = false;
                    tombol4.Enabled = false;

                }
            }
            else if (ItemList.SelectedItem.ToString() == "Nasi Goreng")
            {
                hero3atk += 2;
               NasiGoreng--;
                labelJumlah.Text = "Amount : " + NasiGoreng;
                if (NasiGoreng < 1)
                {
                    tombol1.Enabled = false;
                    tombol2.Enabled = false;
                    tombol3.Enabled = false;
                    tombol4.Enabled = false;

                }

            }
            else if (ItemList.SelectedItem.ToString() == "Mi Goreng")
            {
                hero3def += 2;
                MiGoreng--;
                labelJumlah.Text = "Amount : " + MiGoreng;
                if (MiGoreng < 1)
                {
                    tombol1.Enabled = false;
                    tombol2.Enabled = false;
                    tombol3.Enabled = false;
                    tombol4.Enabled = false;

                }

            }
            else if (ItemList.SelectedItem.ToString() == "Rendang")
            {
                if (hero3health >= 0) hero3health += 50;
                if (hero3health > 100) hero3health = 100;
                Rendang--;
                labelJumlah.Text = "Amount : " + Rendang;
                if (Rendang < 1)
                {
                    tombol1.Enabled = false;
                    tombol2.Enabled = false;
                    tombol3.Enabled = false;
                    tombol4.Enabled = false;

                }
            }
            updateouter();
        }

        private void tombol4_Click(object sender, EventArgs e)
        {
            if (ItemList.SelectedItem.ToString() == "Rawon")
            {
                if (hero4health >= 0) hero4health += 25;
                if (hero4health > 100) hero4health = 100;
                Rawon--;
                labelJumlah.Text = "Amount : " + Rawon;
                if (Rawon < 1)
                {
                    tombol1.Enabled = false;
                    tombol2.Enabled = false;
                    tombol3.Enabled = false;
                    tombol4.Enabled = false;

                }
            }
            else if (ItemList.SelectedItem.ToString() == "Nasi Goreng")
            {
                hero4atk += 2;
                NasiGoreng--;
                labelJumlah.Text = "Amount : " + NasiGoreng;
                if (NasiGoreng < 1)
                {
                    tombol1.Enabled = false;
                    tombol2.Enabled = false;
                    tombol3.Enabled = false;
                    tombol4.Enabled = false;

                }

            }
            else if (ItemList.SelectedItem.ToString() == "Mi Goreng")
            {
                hero4def += 2;
                MiGoreng--;
                labelJumlah.Text = "Amount : " + MiGoreng;
                if (MiGoreng < 1)
                {
                    tombol1.Enabled = false;
                    tombol2.Enabled = false;
                    tombol3.Enabled = false;
                    tombol4.Enabled = false;

                }

            }
            else if (ItemList.SelectedItem.ToString() == "Rendang")
            {
                if (hero4health >= 0) hero4health += 50;
                if (hero4health > 100) hero4health = 100;
                Rendang--;
                labelJumlah.Text = "Amount : " + Rendang;
                if (Rendang < 1)
                {
                    tombol1.Enabled = false;
                    tombol2.Enabled = false;
                    tombol3.Enabled = false;
                    tombol4.Enabled = false;

                }
            }
            updateouter();
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
            FormMenu.player2speed = hero1spd;
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

        private void DeskripsiMakanan_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxBgItem_Click(object sender, EventArgs e)
        {

        }
    }
    }

