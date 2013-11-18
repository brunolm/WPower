using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WPower.Properties;

namespace WPower
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                this.Location = Settings.Default.StartLocation;
            }
            catch { }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Settings.Default.StartLocation = this.Location;
                Settings.Default.Save();
            }
            catch
            {
                
            }
        }

        private void btnPowerOff_Click(object sender, EventArgs e)
        {
            WinPower.Execute(WinPower.PowerOption.PowerOff);
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            WinPower.Execute(WinPower.PowerOption.Reboot);
        }

        private void btnSleep_Click(object sender, EventArgs e)
        {
            WinPower.Execute(WinPower.PowerOption.Sleep);
        }

        private void btnHibernate_Click(object sender, EventArgs e)
        {
            WinPower.Execute(WinPower.PowerOption.Hibernate);
        }
    }
}
