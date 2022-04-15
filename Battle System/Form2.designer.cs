namespace Battle_System
{
    partial class FormItem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tombol1 = new System.Windows.Forms.Button();
            this.tombol2 = new System.Windows.Forms.Button();
            this.tombol3 = new System.Windows.Forms.Button();
            this.tombol4 = new System.Windows.Forms.Button();
            this.labelNamaMakanan = new System.Windows.Forms.Label();
            this.ItemList = new System.Windows.Forms.ComboBox();
            this.labelJumlah = new System.Windows.Forms.Label();
            this.DeskripsiMakanan = new System.Windows.Forms.Label();
            this.pictureItem = new System.Windows.Forms.PictureBox();
            this.pictureBoxBgItem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBgItem)).BeginInit();
            this.SuspendLayout();
            // 
            // tombol1
            // 
            this.tombol1.Location = new System.Drawing.Point(742, 173);
            this.tombol1.Name = "tombol1";
            this.tombol1.Size = new System.Drawing.Size(75, 60);
            this.tombol1.TabIndex = 0;
            this.tombol1.Text = "Player UwU";
            this.tombol1.UseVisualStyleBackColor = true;
            this.tombol1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tombol2
            // 
            this.tombol2.Location = new System.Drawing.Point(742, 258);
            this.tombol2.Name = "tombol2";
            this.tombol2.Size = new System.Drawing.Size(75, 60);
            this.tombol2.TabIndex = 1;
            this.tombol2.Text = "Player Doge";
            this.tombol2.UseVisualStyleBackColor = true;
            this.tombol2.Click += new System.EventHandler(this.tombol2_Click);
            // 
            // tombol3
            // 
            this.tombol3.Location = new System.Drawing.Point(844, 173);
            this.tombol3.Name = "tombol3";
            this.tombol3.Size = new System.Drawing.Size(75, 60);
            this.tombol3.TabIndex = 2;
            this.tombol3.Text = "Player Monke";
            this.tombol3.UseVisualStyleBackColor = true;
            this.tombol3.Click += new System.EventHandler(this.tombol3_Click);
            // 
            // tombol4
            // 
            this.tombol4.Location = new System.Drawing.Point(844, 258);
            this.tombol4.Name = "tombol4";
            this.tombol4.Size = new System.Drawing.Size(75, 60);
            this.tombol4.TabIndex = 3;
            this.tombol4.Text = "Player Derp";
            this.tombol4.UseVisualStyleBackColor = true;
            this.tombol4.Click += new System.EventHandler(this.tombol4_Click);
            // 
            // labelNamaMakanan
            // 
            this.labelNamaMakanan.AutoSize = true;
            this.labelNamaMakanan.BackColor = System.Drawing.SystemColors.GrayText;
            this.labelNamaMakanan.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNamaMakanan.ForeColor = System.Drawing.SystemColors.Window;
            this.labelNamaMakanan.Location = new System.Drawing.Point(443, 196);
            this.labelNamaMakanan.Name = "labelNamaMakanan";
            this.labelNamaMakanan.Size = new System.Drawing.Size(0, 31);
            this.labelNamaMakanan.TabIndex = 5;
            this.labelNamaMakanan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelNamaMakanan.Click += new System.EventHandler(this.label1_Click);
            // 
            // ItemList
            // 
            this.ItemList.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ItemList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemList.ForeColor = System.Drawing.SystemColors.Window;
            this.ItemList.FormattingEnabled = true;
            this.ItemList.Location = new System.Drawing.Point(200, 173);
            this.ItemList.Name = "ItemList";
            this.ItemList.Size = new System.Drawing.Size(130, 23);
            this.ItemList.TabIndex = 6;
            this.ItemList.Text = "Choose your Food!";
            this.ItemList.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelJumlah
            // 
            this.labelJumlah.AutoSize = true;
            this.labelJumlah.BackColor = System.Drawing.SystemColors.GrayText;
            this.labelJumlah.ForeColor = System.Drawing.SystemColors.Window;
            this.labelJumlah.Location = new System.Drawing.Point(351, 180);
            this.labelJumlah.Name = "labelJumlah";
            this.labelJumlah.Size = new System.Drawing.Size(0, 13);
            this.labelJumlah.TabIndex = 7;
            this.labelJumlah.Click += new System.EventHandler(this.label2_Click);
            // 
            // DeskripsiMakanan
            // 
            this.DeskripsiMakanan.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.DeskripsiMakanan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeskripsiMakanan.ForeColor = System.Drawing.SystemColors.Window;
            this.DeskripsiMakanan.Location = new System.Drawing.Point(196, 379);
            this.DeskripsiMakanan.Name = "DeskripsiMakanan";
            this.DeskripsiMakanan.Size = new System.Drawing.Size(601, 72);
            this.DeskripsiMakanan.TabIndex = 8;
            this.DeskripsiMakanan.Click += new System.EventHandler(this.DeskripsiMakanan_Click);
            // 
            // pictureItem
            // 
            this.pictureItem.Location = new System.Drawing.Point(28, 163);
            this.pictureItem.Name = "pictureItem";
            this.pictureItem.Size = new System.Drawing.Size(147, 139);
            this.pictureItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureItem.TabIndex = 4;
            this.pictureItem.TabStop = false;
            this.pictureItem.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBoxBgItem
            // 
            this.pictureBoxBgItem.Image = global::Battle_System.Properties.Resources.Kitchen;
            this.pictureBoxBgItem.Location = new System.Drawing.Point(0, -2);
            this.pictureBoxBgItem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxBgItem.Name = "pictureBoxBgItem";
            this.pictureBoxBgItem.Size = new System.Drawing.Size(947, 551);
            this.pictureBoxBgItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBgItem.TabIndex = 9;
            this.pictureBoxBgItem.TabStop = false;
            this.pictureBoxBgItem.Click += new System.EventHandler(this.pictureBoxBgItem_Click);
            // 
            // FormItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 547);
            this.Controls.Add(this.DeskripsiMakanan);
            this.Controls.Add(this.labelJumlah);
            this.Controls.Add(this.ItemList);
            this.Controls.Add(this.labelNamaMakanan);
            this.Controls.Add(this.pictureItem);
            this.Controls.Add(this.tombol4);
            this.Controls.Add(this.tombol3);
            this.Controls.Add(this.tombol2);
            this.Controls.Add(this.tombol1);
            this.Controls.Add(this.pictureBoxBgItem);
            this.MaximizeBox = false;
            this.Name = "FormItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Items";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBgItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tombol1;
        private System.Windows.Forms.Button tombol2;
        private System.Windows.Forms.Button tombol3;
        private System.Windows.Forms.Button tombol4;
        private System.Windows.Forms.PictureBox pictureItem;
        private System.Windows.Forms.Label labelNamaMakanan;
        private System.Windows.Forms.ComboBox ItemList;
        private System.Windows.Forms.Label labelJumlah;
        private System.Windows.Forms.Label DeskripsiMakanan;
        private System.Windows.Forms.PictureBox pictureBoxBgItem;
    }
}