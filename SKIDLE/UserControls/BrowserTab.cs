using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKIDLE.UserControls
{
    public partial class BrowserTab : Manina.Windows.Forms.Tab
    {
        public BrowserTab(string url)
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(63, 0, 123);
            this.Text = "[browser]";
            web.Url = new Uri(url);
        }
    }
}
