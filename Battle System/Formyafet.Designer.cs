namespace Battle_System
{
    partial class SystemAttack
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
            this.ButtonFirst = new System.Windows.Forms.RadioButton();
            this.ButtonSecond = new System.Windows.Forms.RadioButton();
            this.ButtonThird = new System.Windows.Forms.RadioButton();
            this.ButtonFourth = new System.Windows.Forms.RadioButton();
            this.comboBoxMenuWeapon = new System.Windows.Forms.ComboBox();
            this.labelJudul = new System.Windows.Forms.Label();
            this.labelDesc = new System.Windows.Forms.Label();
            this.None = new System.Windows.Forms.RadioButton();
            this.pictureBoxUwu = new System.Windows.Forms.PictureBox();
            this.pictureBoxDoge = new System.Windows.Forms.PictureBox();
            this.pictureBoxMonke = new System.Windows.Forms.PictureBox();
            this.pictureBoxDerp = new System.Windows.Forms.PictureBox();
            this.pictureBoxDisplay = new System.Windows.Forms.PictureBox();
            this.pictureBoxbgEqt = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUwu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDoge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMonke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDerp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxbgEqt)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonFirst
            // 
            this.ButtonFirst.AutoSize = true;
            this.ButtonFirst.Location = new System.Drawing.Point(697, 168);
            this.ButtonFirst.Name = "ButtonFirst";
            this.ButtonFirst.Size = new System.Drawing.Size(14, 13);
            this.ButtonFirst.TabIndex = 1;
            this.ButtonFirst.TabStop = true;
            this.ButtonFirst.UseVisualStyleBackColor = true;
            this.ButtonFirst.CheckedChanged += new System.EventHandler(this.ButtonFirst_CheckedChanged);
            // 
            // ButtonSecond
            // 
            this.ButtonSecond.AutoSize = true;
            this.ButtonSecond.Location = new System.Drawing.Point(697, 236);
            this.ButtonSecond.Name = "ButtonSecond";
            this.ButtonSecond.Size = new System.Drawing.Size(14, 13);
            this.ButtonSecond.TabIndex = 2;
            this.ButtonSecond.TabStop = true;
            this.ButtonSecond.UseVisualStyleBackColor = true;
            this.ButtonSecond.CheckedChanged += new System.EventHandler(this.ButtonSecond_CheckedChanged);
            // 
            // ButtonThird
            // 
            this.ButtonThird.AutoSize = true;
            this.ButtonThird.Location = new System.Drawing.Point(697, 301);
            this.ButtonThird.Name = "ButtonThird";
            this.ButtonThird.Size = new System.Drawing.Size(14, 13);
            this.ButtonThird.TabIndex = 3;
            this.ButtonThird.TabStop = true;
            this.ButtonThird.UseVisualStyleBackColor = true;
            this.ButtonThird.CheckedChanged += new System.EventHandler(this.ButtonThird_CheckedChanged);
            // 
            // ButtonFourth
            // 
            this.ButtonFourth.AutoSize = true;
            this.ButtonFourth.Location = new System.Drawing.Point(697, 370);
            this.ButtonFourth.Name = "ButtonFourth";
            this.ButtonFourth.Size = new System.Drawing.Size(14, 13);
            this.ButtonFourth.TabIndex = 4;
            this.ButtonFourth.TabStop = true;
            this.ButtonFourth.UseVisualStyleBackColor = true;
            this.ButtonFourth.CheckedChanged += new System.EventHandler(this.ButtonFourth_CheckedChanged);
            // 
            // comboBoxMenuWeapon
            // 
            this.comboBoxMenuWeapon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMenuWeapon.FormattingEnabled = true;
            this.comboBoxMenuWeapon.Location = new System.Drawing.Point(324, 37);
            this.comboBoxMenuWeapon.Name = "comboBoxMenuWeapon";
            this.comboBoxMenuWeapon.Size = new System.Drawing.Size(282, 25);
            this.comboBoxMenuWeapon.TabIndex = 5;
            this.comboBoxMenuWeapon.Text = "Choose your equipment!";
            this.comboBoxMenuWeapon.SelectedIndexChanged += new System.EventHandler(this.comboBoxMenuWeapon_SelectedIndexChanged);
            this.comboBoxMenuWeapon.SelectedValueChanged += new System.EventHandler(this.comboBoxMenuWeapon_SelectedValueChanged);
            // 
            // labelJudul
            // 
            this.labelJudul.AutoSize = true;
            this.labelJudul.Font = new System.Drawing.Font("Snap ITC", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJudul.Location = new System.Drawing.Point(31, 236);
            this.labelJudul.Name = "labelJudul";
            this.labelJudul.Size = new System.Drawing.Size(173, 35);
            this.labelJudul.TabIndex = 6;
            this.labelJudul.Text = "Equipment";
            // 
            // labelDesc
            // 
            this.labelDesc.AutoSize = true;
            this.labelDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDesc.Location = new System.Drawing.Point(32, 282);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(120, 25);
            this.labelDesc.TabIndex = 7;
            this.labelDesc.Text = "Description";
            this.labelDesc.Click += new System.EventHandler(this.labelDesc_Click);
            // 
            // None
            // 
            this.None.AutoSize = true;
            this.None.Location = new System.Drawing.Point(37, 421);
            this.None.Name = "None";
            this.None.Size = new System.Drawing.Size(51, 17);
            this.None.TabIndex = 8;
            this.None.TabStop = true;
            this.None.Text = "None";
            this.None.UseVisualStyleBackColor = true;
            this.None.CheckedChanged += new System.EventHandler(this.None_CheckedChanged);
            // 
            // pictureBoxUwu
            // 
            this.pictureBoxUwu.Image = global::Battle_System.Properties.Resources.ButtonUwU;
            this.pictureBoxUwu.Location = new System.Drawing.Point(715, 145);
            this.pictureBoxUwu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxUwu.Name = "pictureBoxUwu";
            this.pictureBoxUwu.Size = new System.Drawing.Size(65, 63);
            this.pictureBoxUwu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUwu.TabIndex = 13;
            this.pictureBoxUwu.TabStop = false;
            // 
            // pictureBoxDoge
            // 
            this.pictureBoxDoge.Image = global::Battle_System.Properties.Resources.ButtonDoge;
            this.pictureBoxDoge.Location = new System.Drawing.Point(715, 210);
            this.pictureBoxDoge.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxDoge.Name = "pictureBoxDoge";
            this.pictureBoxDoge.Size = new System.Drawing.Size(65, 63);
            this.pictureBoxDoge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDoge.TabIndex = 12;
            this.pictureBoxDoge.TabStop = false;
            // 
            // pictureBoxMonke
            // 
            this.pictureBoxMonke.Image = global::Battle_System.Properties.Resources.ButtonMonke;
            this.pictureBoxMonke.Location = new System.Drawing.Point(715, 278);
            this.pictureBoxMonke.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxMonke.Name = "pictureBoxMonke";
            this.pictureBoxMonke.Size = new System.Drawing.Size(65, 63);
            this.pictureBoxMonke.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMonke.TabIndex = 11;
            this.pictureBoxMonke.TabStop = false;
            // 
            // pictureBoxDerp
            // 
            this.pictureBoxDerp.Image = global::Battle_System.Properties.Resources.ButtonDerp1;
            this.pictureBoxDerp.Location = new System.Drawing.Point(715, 345);
            this.pictureBoxDerp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxDerp.Name = "pictureBoxDerp";
            this.pictureBoxDerp.Size = new System.Drawing.Size(65, 63);
            this.pictureBoxDerp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDerp.TabIndex = 10;
            this.pictureBoxDerp.TabStop = false;
            // 
            // pictureBoxDisplay
            // 
            this.pictureBoxDisplay.ErrorImage = null;
            this.pictureBoxDisplay.Location = new System.Drawing.Point(355, 145);
            this.pictureBoxDisplay.Name = "pictureBoxDisplay";
            this.pictureBoxDisplay.Size = new System.Drawing.Size(228, 219);
            this.pictureBoxDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDisplay.TabIndex = 0;
            this.pictureBoxDisplay.TabStop = false;
            // 
            // pictureBoxbgEqt
            // 
            this.pictureBoxbgEqt.Image = global::Battle_System.Properties.Resources.bgEqt;
            this.pictureBoxbgEqt.Location = new System.Drawing.Point(-1, -2);
            this.pictureBoxbgEqt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxbgEqt.Name = "pictureBoxbgEqt";
            this.pictureBoxbgEqt.Size = new System.Drawing.Size(949, 554);
            this.pictureBoxbgEqt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxbgEqt.TabIndex = 9;
            this.pictureBoxbgEqt.TabStop = false;
            // 
            // SystemAttack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 547);
            this.Controls.Add(this.pictureBoxUwu);
            this.Controls.Add(this.pictureBoxDoge);
            this.Controls.Add(this.pictureBoxMonke);
            this.Controls.Add(this.pictureBoxDerp);
            this.Controls.Add(this.None);
            this.Controls.Add(this.labelDesc);
            this.Controls.Add(this.labelJudul);
            this.Controls.Add(this.comboBoxMenuWeapon);
            this.Controls.Add(this.ButtonFourth);
            this.Controls.Add(this.ButtonThird);
            this.Controls.Add(this.ButtonSecond);
            this.Controls.Add(this.ButtonFirst);
            this.Controls.Add(this.pictureBoxDisplay);
            this.Controls.Add(this.pictureBoxbgEqt);
            this.MaximizeBox = false;
            this.Name = "SystemAttack";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUwu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDoge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMonke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDerp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxbgEqt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDisplay;
        private System.Windows.Forms.RadioButton ButtonFirst;
        private System.Windows.Forms.RadioButton ButtonSecond;
        private System.Windows.Forms.RadioButton ButtonThird;
        private System.Windows.Forms.RadioButton ButtonFourth;
        private System.Windows.Forms.ComboBox comboBoxMenuWeapon;
        private System.Windows.Forms.Label labelJudul;
        private System.Windows.Forms.Label labelDesc;
        private System.Windows.Forms.RadioButton None;
        private System.Windows.Forms.PictureBox pictureBoxbgEqt;
        private System.Windows.Forms.PictureBox pictureBoxDerp;
        private System.Windows.Forms.PictureBox pictureBoxMonke;
        private System.Windows.Forms.PictureBox pictureBoxDoge;
        private System.Windows.Forms.PictureBox pictureBoxUwu;
    }
}