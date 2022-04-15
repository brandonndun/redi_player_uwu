namespace Battle_System
{
    partial class FormMenu
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
            this.pictureBoxBegin = new System.Windows.Forms.PictureBox();
            this.pictureBoxName = new System.Windows.Forms.PictureBox();
            this.pictureBoxMenu = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBegin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxBegin
            // 
            this.pictureBoxBegin.Image = global::Battle_System.Properties.Resources.ClickToBegin;
            this.pictureBoxBegin.Location = new System.Drawing.Point(254, 406);
            this.pictureBoxBegin.Name = "pictureBoxBegin";
            this.pictureBoxBegin.Size = new System.Drawing.Size(802, 347);
            this.pictureBoxBegin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBegin.TabIndex = 2;
            this.pictureBoxBegin.TabStop = false;
            this.pictureBoxBegin.Click += new System.EventHandler(this.picBoxBegin_Click);
            this.pictureBoxBegin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picBoxPlay_MouseClick);
            // 
            // pictureBoxName
            // 
            this.pictureBoxName.Image = global::Battle_System.Properties.Resources.Name;
            this.pictureBoxName.Location = new System.Drawing.Point(114, -111);
            this.pictureBoxName.Name = "pictureBoxName";
            this.pictureBoxName.Size = new System.Drawing.Size(1048, 532);
            this.pictureBoxName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxName.TabIndex = 1;
            this.pictureBoxName.TabStop = false;
            this.pictureBoxName.Click += new System.EventHandler(this.pictureBoxName_Click);
            // 
            // pictureBoxMenu
            // 
            this.pictureBoxMenu.Image = global::Battle_System.Properties.Resources.BgMenu;
            this.pictureBoxMenu.Location = new System.Drawing.Point(-1, -1);
            this.pictureBoxMenu.Name = "pictureBoxMenu";
            this.pictureBoxMenu.Size = new System.Drawing.Size(1265, 674);
            this.pictureBoxMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxMenu.TabIndex = 0;
            this.pictureBoxMenu.TabStop = false;
            this.pictureBoxMenu.Click += new System.EventHandler(this.pictureBoxMenu_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.pictureBoxBegin);
            this.Controls.Add(this.pictureBoxName);
            this.Controls.Add(this.pictureBoxMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Redi Player UwU";
            this.Load += new System.EventHandler(this.FormMenu_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBegin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenu)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMenu;
        private System.Windows.Forms.PictureBox pictureBoxName;
        private System.Windows.Forms.PictureBox pictureBoxBegin;
    }
}