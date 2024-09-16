using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SKIDLE.UserControls
{
    public partial class TextEditor : UserControl
    {
        public TextEditor()
        {
            InitializeComponent();
            title.Location = new Point(this.Size.Width / 2-50, title.Location.Y);
        }
    }
}
