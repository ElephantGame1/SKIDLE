using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SKIDLE
{
    public partial class ModuleToGit : Form
    {
        public ModuleToGit()
        {
            InitializeComponent();
            pathtoFolder.CustomButton.Click += CustomButton_Click;
        }

        private void CustomButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
                pathtoFolder.Text = ofd.FileName;
        }

        private void ModuleToGit_Load(object sender, EventArgs e)
        {
            ConfigFile config = new ConfigFile(Globals.User+"configure.conf");
            if (config.GetProperty("theme") == "dark")
                Dark();
            else
                Light();
            Lang(config.GetProperty("language"));
        }

        private void pub_Click(object sender, EventArgs e)
        {
            if(email.Text != "" && NameModule.Text != "" && pathtoFolder.Text != "" && versionModule.Text != "" && minSPK.Text != "" && author.Text != "" && desc.Text != "")
            {
                FileInfo fi = new FileInfo(pathtoFolder.Text);
                Directory.CreateDirectory(Globals.Main+"CreateModule\\"+NameModule.Text +"\\").Create();
                File.Copy(pathtoFolder.Text, Globals.Main + "CreateModule"+NameModule.Text +"\\"+ fi.Name);
                var xmlWriter = new XmlTextWriter(Globals.Main + "CreateModule" + NameModule.Text + "\\" + NameModule.Text+".xml", null);

                xmlWriter.WriteStartDocument();
                xmlWriter.WriteStartElement("module"); 
                xmlWriter.WriteStartElement("minspk");
                xmlWriter.WriteString(minSPK.Text);
                xmlWriter.WriteEndElement(); 
                xmlWriter.WriteStartElement("author");
                xmlWriter.WriteString(author.Text);
                xmlWriter.WriteEndElement();
                xmlWriter.WriteStartElement("email");
                xmlWriter.WriteString(email.Text);
                xmlWriter.WriteEndElement();
                xmlWriter.WriteStartElement("name");
                xmlWriter.WriteString(NameModule.Text);
                xmlWriter.WriteEndElement();
                xmlWriter.WriteStartElement("desc");
                xmlWriter.WriteString(desc.Text);
                xmlWriter.WriteEndElement();
                xmlWriter.WriteStartElement("version");
                xmlWriter.WriteString(versionModule.Text);
                xmlWriter.WriteEndElement();
                xmlWriter.WriteEndElement();

                xmlWriter.Close();

               
            } else
            {
                MessageBox.Show("error","error");
            }
        }

        private void Dark()
        {
            this.BackColor = Color.FromArgb(20,20,20);
            this.ForeColor = Color.White;
        }
        private void Light()
        {
            this.BackColor = Color.White;
            this.ForeColor = Color.Black;
        }
        private void Lang(string name)
        {
            ConfigFile config = new ConfigFile(Globals.Main+"\\Languages\\"+name+".conf");
            this.Text = config.GetProperty("mtitle");
            this.title.Text = config.GetProperty("mtitlePar");
            //this.pathtoFolder.PromptText = config.GetProperty("pathToFile");
            //this.email.PromptText = config.GetProperty("memail");
            //this.author.PromptText = config.GetProperty("mauthor");
            //this.versionModule.PromptText = config.GetProperty("mversion");
            //this.NameModule.PromptText = config.GetProperty("mname");
            this.minSPK.PromptText = config.GetProperty("mminspk");
            this.metroLabel1.Text = config.GetProperty("minfoTitle");
            //this.desc.PromptText = config.GetProperty("mdesc");
            this.pub.Text = config.GetProperty("mpub");
        }
    }
}
