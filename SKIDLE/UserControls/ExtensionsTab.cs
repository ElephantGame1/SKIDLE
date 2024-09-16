using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKIDLE.UserControls
{
    public class ExtensionsTab : Manina.Windows.Forms.Tab
    {
        public ExtensionsTab()
        {
            this.BackColor = Color.FromArgb(25,25,25);
            this.ForeColor = Color.White;
            ExtensionsUC extensionsUC = new ExtensionsUC();
            extensionsUC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Controls.Add(extensionsUC);
            this.Text = "Extensions Browser";
        }
    }
}
