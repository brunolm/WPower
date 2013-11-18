namespace WPower
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnHibernate = new System.Windows.Forms.Button();
            this.btnSleep = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnPowerOff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHibernate
            // 
            this.btnHibernate.BackgroundImage = global::WPower.Properties.Resources.hibernate;
            this.btnHibernate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHibernate.ForeColor = System.Drawing.Color.White;
            this.btnHibernate.Location = new System.Drawing.Point(414, 12);
            this.btnHibernate.Name = "btnHibernate";
            this.btnHibernate.Size = new System.Drawing.Size(128, 128);
            this.btnHibernate.TabIndex = 3;
            this.btnHibernate.Text = "Hibernate";
            this.btnHibernate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHibernate.UseVisualStyleBackColor = true;
            this.btnHibernate.Click += new System.EventHandler(this.btnHibernate_Click);
            // 
            // btnSleep
            // 
            this.btnSleep.BackgroundImage = global::WPower.Properties.Resources.sleep;
            this.btnSleep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSleep.ForeColor = System.Drawing.Color.White;
            this.btnSleep.Location = new System.Drawing.Point(280, 12);
            this.btnSleep.Name = "btnSleep";
            this.btnSleep.Size = new System.Drawing.Size(128, 128);
            this.btnSleep.TabIndex = 2;
            this.btnSleep.Text = "Sleep";
            this.btnSleep.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSleep.UseVisualStyleBackColor = true;
            this.btnSleep.Click += new System.EventHandler(this.btnSleep_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.BackgroundImage = global::WPower.Properties.Resources.restart;
            this.btnRestart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRestart.ForeColor = System.Drawing.Color.White;
            this.btnRestart.Location = new System.Drawing.Point(146, 12);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(128, 128);
            this.btnRestart.TabIndex = 1;
            this.btnRestart.Text = "Restart";
            this.btnRestart.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnPowerOff
            // 
            this.btnPowerOff.BackgroundImage = global::WPower.Properties.Resources.poweroff;
            this.btnPowerOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPowerOff.ForeColor = System.Drawing.Color.White;
            this.btnPowerOff.Location = new System.Drawing.Point(12, 12);
            this.btnPowerOff.Name = "btnPowerOff";
            this.btnPowerOff.Size = new System.Drawing.Size(128, 128);
            this.btnPowerOff.TabIndex = 0;
            this.btnPowerOff.Text = "Shutdown";
            this.btnPowerOff.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPowerOff.UseVisualStyleBackColor = true;
            this.btnPowerOff.Click += new System.EventHandler(this.btnPowerOff_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 152);
            this.Controls.Add(this.btnHibernate);
            this.Controls.Add(this.btnSleep);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnPowerOff);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Power options";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPowerOff;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnSleep;
        private System.Windows.Forms.Button btnHibernate;
    }
}

