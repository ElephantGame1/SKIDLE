using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SKIDLE
{
    public partial class LogMenu : Form
    {
        string file = "";
        public LogMenu()
        {
            InitializeComponent();
        }
        public void fShow(string file)
        {
            this.file = file;
            if (file.Contains("."))
                log.Text = File.ReadAllText(file);
        }
        private void Ok_Click(object sender, EventArgs e)
        {
            close_Click(sender, e);
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            close_Click(sender, e);
            File.WriteAllText(file, "");
        }

        private void LogMenu_Load(object sender, EventArgs e)
        {
            ConfigFile config = new ConfigFile(Globals.User + "configure.conf");
            if (config.GetProperty("theme") == "dark")
                Dark();
            else
                Light();
        }

        private void Light()
        {
            metroPanel1.BackColor = SystemColors.Control;
            log.BackColor = SystemColors.Control;
            metroPanel1.ForeColor = Color.Black;
            log.ForeColor = Color.Black;
        }

        private void Dark()
        {
            metroPanel1.BackColor = Color.FromArgb(45,45,45);
            log.BackColor = Color.FromArgb(45, 45, 45);
            metroPanel1.ForeColor = Color.White;
            log.ForeColor = Color.White;
        }
    }
}
