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
    public partial class ExtensionsUC : UserControl
    {
        public ExtensionsUC()
        {
            InitializeComponent();
        }

        private void ExtensionsUC_Load(object sender, EventArgs e)
        {
            LoadAllFiles();
        }

        private void LoadAllFiles()
        {
            listofExtensions.Nodes.Clear();
            foreach (var item in Directory.GetFiles(Globals.locales))
            {
                var tag = listofExtensions.Nodes.Add(item, new FileInfo(item).Name);
                tag.Tag = new DirectoryInfo(item);
            }
            foreach (var itemTyLox in Directory.GetFiles(Globals.exts))
            {
                var tag = listofExtensions.Nodes.Add(itemTyLox,new FileInfo(itemTyLox).Name);
                tag.Tag = new DirectoryInfo(itemTyLox);
            }
            foreach (var itemTyLox in Directory.GetFiles(Globals.themes))
            {
                var tag = listofExtensions.Nodes.Add(itemTyLox,new FileInfo(itemTyLox).Name);
                tag.Tag = new DirectoryInfo(itemTyLox);
            }
        }

        private void listofExtensions_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            ConfigFile c = new ConfigFile(e.Node.Name);
            try { exp.title.Text = c.GetProperty("titlepkg"); } catch { }
            try { exp.author.Text = c.GetProperty("authorpkg"); } catch { }
            try { exp.version.Text = c.GetProperty("verpkg"); } catch { }
            try { exp.extDesc.Text = c.GetProperty("extDeskpkg"); } catch { }
            try { exp.description.Text = c.GetProperty("deskpkg"); } catch { }
            try { exp.icon.ImageLocation = Globals.icons + c.GetProperty("iconpkg"); } catch { }
        }
    }
}
