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

namespace SKIDLE.UserControls
{
    public partial class General : UserControl
    {
        ConfigFile config;
        public General()
        {
            InitializeComponent();
            title.Location = new Point(this.Size.Width / 2-50, title.Location.Y);
            pathToSPK.CustomButton.Click += OkPathSPK;
            config = new ConfigFile("configure.conf");
            pathToSPK.Text = config.GetProperty("compilerPK");
        }

        private void OkPathSPK(object sender, EventArgs e)
        {
            config.SetProperty("compilerSPK", pathToSPK.Text);
        }

        private void themeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            config.SetProperty("theme", themeComboBox.SelectedItem.ToString());
        }

        private void themeComboBox_DropDown(object sender, EventArgs e)
        {
            themeComboBox.Items.Clear();
            foreach(string item in Directory.GetFiles(Globals.themes))
                themeComboBox.Items.Add(new FileInfo(item).Name);
        }
    }
}
