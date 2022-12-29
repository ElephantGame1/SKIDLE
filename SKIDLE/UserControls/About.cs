﻿using System;
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
    public partial class About : UserControl
    {
        public About()
        {
            InitializeComponent();
            title.Location = new Point(this.Size.Width / 2-50, title.Location.Y);
        }

        private void About_Load(object sender, EventArgs e)
        {
            aboutText.SelectionColor = Color.FromArgb(60, 60, 60, 60);
            aboutText.SelectionBackColor = Color.FromArgb(60, 60, 60, 60);
        }
    }
}
