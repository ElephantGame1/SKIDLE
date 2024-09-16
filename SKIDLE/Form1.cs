using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SKIDLE.UserControls;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Text.RegularExpressions;
using SKIDLE.CrossFormsDesigner;
using FastColoredTextBoxNS;
using SKIDLE.UI;
using SKIDLE.Properties;
using Microsoft.CSharp;
using System.CodeDom.Compiler;
using System.Reflection;
using System.Linq.Expressions;

namespace SKIDLE
{
    public partial class skidle : Form
    {
        IMenuStrip ims = new IMenuStrip();
        bool fullscreen = false;
        public skidle()
        {
            InitializeComponent();
        }

        private void открытьФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "All files (*.) | *.";
            if (openFile.ShowDialog() != DialogResult.Cancel)
            {
                FileInfo fi = new FileInfo(openFile.FileName);
                codeTab tab = new codeTab();
                tabControl.Tabs.Add(tab);
                tabControl.SelectedTab = tab;
                tab.code.OpenFile(fi.FullName);
                tab.Text = fi.Name;
                tab.Name = fi.FullName;
                tab.LoadTopMenuLabel();
                loadStruct(tab.code.Text);
            }
            UseWaitCursor = false;
        }

        private void открытьТерминалToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            if (splitContainer2.Panel2Collapsed == true)
                splitContainer2.Panel2Collapsed = false;
            else
                splitContainer2.Panel2Collapsed = true;
            //Theme();
            UseWaitCursor = false;
        }

        private void RunMenu_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            if (split.Panel1Collapsed == true)
            {
                split.Panel1Collapsed = false;
            }
            else
            {
                split.Panel1Collapsed = true;
            }
            if (splitContainer1.Panel2Collapsed == true)
            {
                splitContainer1.Panel2Collapsed = false;
                splitContainer1.Panel1Collapsed = true;
            }
            if (splitContainer3.Panel2Collapsed == true)
            {
                splitContainer3.Panel2Collapsed = false;
                splitContainer3.Panel1Collapsed = true;
            }
            UseWaitCursor = false;
        }
        private void запуститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            if (DinRun.Checked == true)
            {
                if (tabControl.SelectedTab.Name != "") сохранитьToolStripMenuItem_Click(sender, e); else сохранитьКакToolStripMenuItem_Click(sender, e);
                foreach (var item in Directory.GetFiles(Globals.exts))
                {
                    if (tabControl.SelectedTab.Text.Split('.')[1] == item.Split('.')[0])
                    {
                        ConfigFile c = new ConfigFile(item);
                        if(c.GetProperty("ext").Split('|')[2].Contains(".jar"))
                            Process.Start("java","-jar "+ c.GetProperty("ext").Split('|')[2] + " "+tabControl.SelectedTab.Name);
                        else
                            Process.Start(c.GetProperty("ext").Split('|')[2], tabControl.SelectedTab.Name);
                        MessageBox.Show("java "+"-jar "+ c.GetProperty("ext").Split('|')[2] + " " + tabControl.SelectedTab.Name);
                    }
                }
            }
            else if (StatRun.Checked == true)
            {
                if (RunPath.Text != "") сохранитьToolStripMenuItem_Click(sender, e); else сохранитьКакToolStripMenuItem_Click(sender, e);
                foreach (var item in Directory.GetFiles(Globals.exts))
                {
                    if (tabControl.SelectedTab.Text.Split('.')[1] == item.Split('.')[0])
                    {
                        ConfigFile c = new ConfigFile(item);
                        if (c.GetProperty("ext").Split('|')[2].Contains(".jar"))
                            Process.Start("java", "-jar " + c.GetProperty("ext").Split('|')[2] + " " + RunPath.Text);
                        else
                            Process.Start(c.GetProperty("ext").Split('|')[2], RunPath.Text);
                    }
                }
            }
           
            UseWaitCursor = false;
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            if (tabControl.Tabs.Count > 0)
            {
                var myCode = (codeTab)tabControl.Tabs[tabControl.SelectedIndex];
                if (File.Exists(tabControl.SelectedTab.Name))
                {
                    File.WriteAllText(tabControl.SelectedTab.Name, myCode.code.Text);
                    loadStruct(myCode.code.Text);
                }
                else
                {
                    сохранитьКакToolStripMenuItem_Click(sender, e);
                }
            }
            UseWaitCursor = false;
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            var myCode = (codeTab)tabControl.Tabs[tabControl.SelectedIndex];
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "All files (*.) | *.";
            if (save.ShowDialog() != DialogResult.Cancel)
            {
                FileInfo fi = new FileInfo(save.FileName);
                File.WriteAllText(fi.FullName, myCode.code.Text);
                myCode.Text = fi.Name;
                myCode.Name = fi.FullName;
                myCode.LoadTopMenuLabel();
                loadStruct(myCode.code.Text);
            }
            UseWaitCursor = false;
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            codeTab tab = new codeTab();
            tabControl.Tabs.Add(tab);
            tabControl.SelectedTab = tab;
            tab.Text = "untitled";
            tab.code.Focus();
            UseWaitCursor = false;
        }

        private void skidle_Load(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            structure.treeView.NodeMouseDoubleClick += TreeView_NodeMouseDoubleClick;
            RunPath.CustomButton.Click += CustomButton_Click;
            ConsoleOpen();
            DinRun.Checked = true;
            split.Panel1Collapsed = true;
            splitContainer1.Panel2Collapsed = true;
            splitContainer2.Panel2Collapsed = true;
            splitContainer3.Panel2Collapsed = true;
            ConfigFile config = new ConfigFile(Globals.User + "configure.conf");

            //Theme(Globals.themes + config.GetProperty("theme"));
            Lang(config.GetProperty("language"));
            //
            //load user
            //
            loadUserFiles();
            menuStrip.Renderer = new ToolStripProfessionalRenderer(ims);
           // LaunchCodeApp(sender, e, Globals.User+"main.cs");
            UseWaitCursor = false;
        }
        /// <summary>
        /// Launch dinamic compilation no work((
        /// </summary>
        public void LaunchCodeApp(object sender, EventArgs e, string src)
        {
            открытьТерминалToolStripMenuItem_Click(sender, e);
            var console = (ConsoleTab)TabControlWithTerminals.Tabs[TabControlWithTerminals.SelectedIndex];
            var param = new CompilerParameters
            {
                GenerateExecutable = false,
                IncludeDebugInformation = false,
                GenerateInMemory = true
            };
            param.ReferencedAssemblies.Add("System.dll");
            param.ReferencedAssemblies.Add("System.Xml.dll");
            param.ReferencedAssemblies.Add("System.Data.dll");
            param.ReferencedAssemblies.Add("System.Core.dll");
            param.ReferencedAssemblies.Add("System.Xml.Linq.dll");
            param.ReferencedAssemblies.Add("System.Windows.Forms.dll");

            var codeProvider = new CSharpCodeProvider();
            var results = codeProvider.CompileAssemblyFromFile(param, src);

            if (results.Errors.HasErrors)
            {
                foreach (var error in results.Errors)
                {
                    console.WriteLine(error.ToString());
                }
            }
            else
            {
                object o = results.
                            CompiledAssembly.
                            CreateInstance("runtime.Program");
                console.WriteLine(o.ToString());
            }
        }
        private void loadUserFiles()
        {
            UseWaitCursor = true;
            if (File.Exists(Globals.User + "files.txt") && File.ReadAllLines(Globals.User + "files.txt").Length > 0)
            {
                foreach (var file in File.ReadAllLines(Globals.User + "files.txt"))
                {
                    try
                    {
                        FileInfo fi = new FileInfo(file);
                        codeTab tab = new codeTab();
                        tabControl.Tabs.Add(tab);
                        tabControl.SelectedTab = tab;
                        tab.code.OpenFile(fi.FullName);
                        tab.Text = fi.Name;
                        tab.Name = fi.FullName;
                        tab.LoadTopMenuLabel();
                        loadStruct(tab.code.Text);
                    }
                    catch
                    {

                    }
                }
            }
            if (File.Exists(Globals.User + "workfolder.txt") && File.ReadAllLines(Globals.User + "workfolder.txt").Length > 0)
            {
                try
                {
                    explorer.Nodes.Clear();
                    split.Panel1Collapsed = false;
                    DirectoryInfo dfo = new DirectoryInfo(File.ReadAllText(Globals.User + "workfolder.txt"));
                    var nody = explorer.Nodes.Add(dfo.Name, dfo.Name);
                    nody.Tag = dfo;
                }
                catch
                {

                }
            }
            foreach(Manina.Windows.Forms.Tab item in tabControl.Tabs)
            {
                try
                {
                    if (item.Text == new ConfigFile(Globals.User + "user.txt").GetProperty("selfile"))
                        tabControl.SelectedTab = item;
                }
                catch
                {

                }
            }
            UseWaitCursor = false;
        }
        private void TreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            UseWaitCursor = true;
            var myCode = (codeTab)tabControl.Tabs[tabControl.SelectedIndex];
            RegexOptions opt = RegexOptions.None;
            Range range = myCode.code.Selection.Clone();
            Place startPlace = range.Start;
            range.Normalize();
            try
            {
                startPlace = range.Start;
                //
                if (range.Start >= startPlace)
                    range.End = new Place(myCode.code.GetLineLength(myCode.code.LinesCount - 1), myCode.code.LinesCount - 1);
                else
                    range.End = startPlace;
                foreach (var r in range.GetRangesByLines(e.Node.Text, opt))
                {
                    myCode.code.Selection = r;
                    myCode.code.DoSelectionVisible();
                    myCode.code.Invalidate();
                    return;
                }
            }
            catch { }
            UseWaitCursor = false;
        }

        private void CustomButton_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                RunPath.Text = ofd.FileName;
            }
            UseWaitCursor = false;
        }

        private void ExplorerMenu_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            if(split.Panel1Collapsed == false)
            {
                split.Panel1Collapsed = true;
            }
            else
            {
                split.Panel1Collapsed = false;
            }
            if (splitContainer1.Panel1Collapsed == true)
            {
                splitContainer1.Panel2Collapsed = true;
                splitContainer1.Panel1Collapsed = false;
            }
            UseWaitCursor = false;
        }

        public void LoadCFA(string file)
        {
            UseWaitCursor = true;
            if (tabControl.Tabs.Count > 0)
            {
                foreach (Manina.Windows.Forms.Tab item in tabControl.Tabs)
                {
                    if (file !=item.Name)
                    {
                        FileInfo fi = new FileInfo(file);
                        codeTab tab = new codeTab();
                        tabControl.Tabs.Add(tab);
                        tabControl.SelectedTab = tab;
                        tab.code.OpenFile(fi.FullName);
                        tab.Text = fi.Name;
                        tab.Name = fi.FullName;
                        tab.LoadTopMenuLabel();
                        loadStruct(tab.code.Text);
                        tab.RefreshCode();
                    }
                    else tabControl.SelectedTab = item;
                }
            }
            else
            {
                FileInfo fi = new FileInfo(file);
                codeTab tab = new codeTab();
                tabControl.Tabs.Add(tab);
                tabControl.SelectedTab = tab;
                tab.code.OpenFile(fi.FullName);
                tab.Text = fi.Name;
                tab.Name = fi.FullName;
                tab.LoadTopMenuLabel();
                loadStruct(tab.code.Text);
                tab.RefreshCode();
            }
            UseWaitCursor = false;
        }

        public void LoadFCMD(string[] files)
        {
            UseWaitCursor = true;
            if (tabControl.Tabs.Count > 0)
            {
                foreach (var file in files)
                {
                    foreach (Manina.Windows.Forms.Tab item in tabControl.Tabs)
                    {
                        if (file != item.Name)
                        {
                            FileInfo fi = new FileInfo(file);
                            codeTab tab = new codeTab();
                            tabControl.Tabs.Add(tab);
                            tabControl.SelectedTab = tab;
                            tab.code.OpenFile(fi.FullName);
                            tab.Text = fi.Name;
                            tab.Name = fi.FullName;
                            tab.RefreshCode();
                            tab.LoadTopMenuLabel();
                            loadStruct(tab.code.Text);
                        }
                    }
                }
            }
            else
            {
                foreach (var file in files)
                {
                    FileInfo fi = new FileInfo(file);
                    codeTab tab = new codeTab();
                    tabControl.Tabs.Add(tab);
                    tabControl.SelectedTab = tab;
                    tab.code.OpenFile(fi.FullName);
                    tab.Text = fi.Name;
                    tab.Name = fi.FullName;
                    tab.RefreshCode();
                    tab.LoadTopMenuLabel();
                    loadStruct(tab.code.Text);
                }
            }
            UseWaitCursor = false;
        }

        private void открытьПапкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            FolderBrowserDialog fbr = new FolderBrowserDialog();
            if(fbr.ShowDialog() != DialogResult.Cancel)
            {
                explorer.Nodes.Clear();
                split.Panel1Collapsed = false;
                DirectoryInfo dfo = new DirectoryInfo(fbr.SelectedPath);
                var nody = explorer.Nodes.Add(dfo.Name, dfo.Name);
                nody.Tag = dfo;
            }
            UseWaitCursor = false;
        }

        private void explorer_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            UseWaitCursor = true;
            if (e.Node.Tag == null)
            {

            }
            else if (e.Node.Tag.GetType() == typeof(DirectoryInfo))
            {
                e.Node.Nodes.Clear();

                foreach (var item in Directory.GetDirectories(((DirectoryInfo)e.Node.Tag).FullName))
                {
                    DirectoryInfo di = new DirectoryInfo(item);
                    var node = e.Node.Nodes.Add(di.Name, di.Name);
                    node.Tag = di;
                }
                foreach (var item in Directory.GetFiles(((DirectoryInfo)e.Node.Tag).FullName))
                {
                    FileInfo fi = new FileInfo(item);                  
                    var node = e.Node.Nodes.Add(fi.Name, fi.Name);
                    node.Tag = fi;
                }
                e.Node.Expand();
            }
            else
            {
                FileInfo fi = new FileInfo(((FileInfo)e.Node.Tag).FullName);
                codeTab tab = new codeTab();
                tabControl.Tabs.Add(tab);
                tabControl.SelectedTab = tab;
                tab.code.OpenFile(fi.FullName);
                tab.Text = fi.Name;
                tab.Name = fi.FullName;
                tab.LoadTopMenuLabel();
                loadStruct(tab.code.Text);
            }
            UseWaitCursor = false;
        }

        private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            var myCode = (codeTab)tabControl.Tabs[tabControl.SelectedIndex];
            myCode.code.Cut();
            UseWaitCursor = false;
        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            var myCode = (codeTab)tabControl.Tabs[tabControl.SelectedIndex];
            myCode.code.Copy();
            UseWaitCursor = false;
        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            var myCode = (codeTab)tabControl.Tabs[tabControl.SelectedIndex];
            myCode.code.Paste();
            UseWaitCursor = false;
        }

        private void найтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            var myCode = (codeTab)tabControl.Tabs[tabControl.SelectedIndex];
            myCode.code.ShowFindDialog();
            UseWaitCursor = false;
        }

        private void перейтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            var myCode = (codeTab)tabControl.Tabs[tabControl.SelectedIndex];
            myCode.code.ShowGoToDialog();
            UseWaitCursor = false;
        }

        private void заменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            var myCode = (codeTab)tabControl.Tabs[tabControl.SelectedIndex];
            myCode.code.ShowReplaceDialog();
            UseWaitCursor = false;
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            tabControl.Tabs.Remove(tabControl.SelectedTab);
            UseWaitCursor = false;
        }

        private void закрытьВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            explorer.Nodes.Clear();
            tabControl.Tabs.Clear();
            split.Panel1Collapsed = true;
            UseWaitCursor = false;
        }

        private void настройкиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Manina.Windows.Forms.Tab tab = new Manina.Windows.Forms.Tab();
            tab.Text = "Settings";
            tabControl.Tabs.Add(tab);
            tabControl.SelectedTab = tab;
            SettingsTabControl settings = new SettingsTabControl();
            settings.Dock = DockStyle.Fill;
            tab.Controls.Add(settings);
            //Theme();
            UseWaitCursor = false;
        }

        private void createFile_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            try
            {
                CreateForm create = new CreateForm(explorer.SelectedNode.Tag.ToString());
                create.Show();
            }
            catch { }
            UseWaitCursor = false;
        }

        private void openInExplorer_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Process.Start("explorer", explorer.SelectedNode.Tag.ToString());
            UseWaitCursor = false;
        }

        private void rename_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            CreateForm create = new CreateForm(explorer.SelectedNode.Tag.ToString());
            create.Show();
            create.Rename = false;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            try
            {
                if (explorer.SelectedNode.Tag.ToString().Contains("."))
                {
                    FileInfo fi = new FileInfo(explorer.SelectedNode.Tag.ToString());
                    File.Delete(explorer.SelectedNode.Tag.ToString());
                }
                else
                {
                    FileInfo di = new FileInfo(explorer.SelectedNode.Tag.ToString());
                    Directory.Delete(explorer.SelectedNode.Tag.ToString());
                }
            }
            catch
            {

            }
            UseWaitCursor = false;
        }
        private void переместитьModuleInModulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            File.Copy(tabControl.SelectedTab.Name, Globals.languages + "modules\\");
        }
        private void explorer_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                explorerContMenu.Show(explorer, e.Location);
        }

        private void loadStruct(string text)
        {
            UseWaitCursor = true;
            var myCode = (codeTab)tabControl.Tabs[tabControl.SelectedIndex];
            structure.code = myCode.code;
            structure.LoadStructure();
            UseWaitCursor = false;
        }

        //
        //themes
        //
        #region themes
        public void Theme() => Theme(Globals.themes + new ConfigFile(Globals.User + "configure.conf").GetProperty("theme"));
        private void Theme(string data)
        {/*
            UseWaitCursor = true;
            ConfigFile c = new ConfigFile(data);
            ExplorerMenu.BackgroundImage = Resources.files1;
            run.BackgroundImage = Resources.run1;
            structureBTN.BackgroundImage = Resources.classBTN1;
            extensions.BackgroundImage = Resources.download;
            menuStrip.BackColor = c.GetColor("menuStripBackColor");
            menuStrip.ForeColor = c.GetColor("menuStripForeColor");
            ims.BackColor = c.GetColor("menuStripBackColor");
            leftMenu.BackColor = c.GetColor("leftMenuBackColor");
            split.Panel1.BackColor = c.GetColor("splitPanel1BackColor");
            explorerPanelTitle.BackColor = c.GetColor("explorerPanelTitleBackColor");
            panelStructureTitle.BackColor = c.GetColor("panelStructureTitle");
            explorer.BackColor = c.GetColor("explorerBackColor");
            explorer.ForeColor = c.GetColor("explorerForeColor");
            structure.treeView.BackColor = c.GetColor("structuretreeViewBackColor");
            structure.treeView.ForeColor = c.GetColor("structuretreeViewForeColor");
            BackColor = c.GetColor("BackColor");
            ForeColor = c.GetColor("ForeColor");
            explorerContMenu.ForeColor = c.GetColor("explorerContMenuForeColor");
            explorerContMenu.BackColor = c.GetColor("explorerContMenuBackColor");
            foreach (Control item in leftMenu.Controls)
            {
                item.BackColor = c.GetColor("leftMenuItem");
            }
            foreach (ToolStripMenuItem item in menuStrip.Items)
            {
                item.ForeColor = c.GetColor("itemForeColor");
                item.BackColor = c.GetColor("itemBackColor");
                foreach (ToolStripMenuItem item1 in item.DropDownItems)
                {
                    item1.ForeColor = c.GetColor("item1ForeColor");
                    item1.BackColor = c.GetColor("item1BackColor");
                }
            }
            foreach (Manina.Windows.Forms.Tab item in tabControl.Tabs)
            {
                item.BackColor = c.GetColor("backcoloredit");
                item.ForeColor = c.GetColor("ForeColor");
            }
            UseWaitCursor = false;
            */
        }

        #endregion

        //
        //Languages
        //
        #region languages
        private void Lang(string name)
        {
            UseWaitCursor = true;
            ConfigFile config = new ConfigFile(Globals.locales+name+".conf");
            файлToolStripMenuItem.Text = config.GetProperty("file");
            сохранитьToolStripMenuItem.Text = config.GetProperty("save");
            сохранитьКакToolStripMenuItem.Text = config.GetProperty("saveAs");
            открытьПапкуToolStripMenuItem.Text = config.GetProperty("openFolder");
            открытьФайлToolStripMenuItem.Text = config.GetProperty("open");
            создатьToolStripMenuItem.Text = config.GetProperty("create");
            закрытьВсеToolStripMenuItem.Text = config.GetProperty("closeAll");
            закрытьToolStripMenuItem.Text = config.GetProperty("close");
            выйтиToolStripMenuItem.Text = config.GetProperty("exit");
            правкаToolStripMenuItem.Text = config.GetProperty("edit");
            вырезатьToolStripMenuItem.Text = config.GetProperty("cut");
            копироватьToolStripMenuItem.Text = config.GetProperty("copy");
            вставитьToolStripMenuItem.Text = config.GetProperty("paste");
            найтиToolStripMenuItem.Text = config.GetProperty("find");
            перейтиToolStripMenuItem.Text = config.GetProperty("goto");
            заменитьToolStripMenuItem.Text = config.GetProperty("replace");
            настройкиToolStripMenuItem3.Text = config.GetProperty("settings");
            запуститьToolStripMenuItem.Text = config.GetProperty("run");
            запускToolStripMenuItem.Text = config.GetProperty("subrun");
            терминалToolStripMenuItem.Text = config.GetProperty("terminal");
            открытьТерминалToolStripMenuItem.Text = config.GetProperty("subterminal");
            metroLabel1.Text = config.GetProperty("explorer");
            structureTitle.Text = config.GetProperty("structure");
            createFile.Text = config.GetProperty("eCreate");
            openInExplorer.Text = config.GetProperty("eOpenInExplorer");
            переместитьModuleInModulesToolStripMenuItem.Text = config.GetProperty("eCopyInModules");
            rename.Text = config.GetProperty("eRename");
            delete.Text = config.GetProperty("eDelete");
            Text = config.GetProperty("title");
            UseWaitCursor = false;
        }

        #endregion

        private void structureBTN_Click(object sender, EventArgs e)
        {
            if(split.Panel1Collapsed == true)
            {
                split.Panel1Collapsed = false;
            }
            else
            {
                split.Panel1Collapsed = true;
            }
            if(splitContainer1.Panel2Collapsed == true)
            {
                splitContainer1.Panel2Collapsed = false;
                splitContainer1.Panel1Collapsed = true;
            }
            if (splitContainer3.Panel2Collapsed == false)
            {
                splitContainer3.Panel2Collapsed = true;
                splitContainer3.Panel1Collapsed = false;
            }
        }
        private void ConsoleOpen()
        {
            ConsoleTab tab = new ConsoleTab();
            tab.Text = "new terminal";
            TabControlWithTerminals.Tabs.Add(tab);
        }
        private void newTerminal(object sender, EventArgs e)
        {
            ConsoleTab tab = new ConsoleTab();
            tab.Text = "new terminal";
            TabControlWithTerminals.Tabs.Add(tab);
            allProcessesToolStripMenuItem.DropDownItems.Clear();
            foreach(Manina.Windows.Forms.Tab item in TabControlWithTerminals.Tabs)
                allProcessesToolStripMenuItem.DropDownItems.Add(item.Text);
        }
        private void отчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogMenu log = new LogMenu();
            log.Show();
            log.fShow(Globals.Main + "log.txt");
        }
        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl.Tabs.Remove(tabControl.SelectedTab);
        }
        private void модулиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModuleToGit mtg = new ModuleToGit();
            mtg.Show();
        }

        private void skidle_FormClosing(object sender, FormClosingEventArgs e)
        {
            UseWaitCursor = true;
            try {
                List<string> list = new List<string>();
                list.Clear();
                File.WriteAllText(Globals.User + "user.txt", "");
                new ConfigFile(Globals.User + "user.txt").SetProperty("selfile", tabControl.SelectedTab.Text);
                if (tabControl.Tabs.Count > 0)
                {
                    foreach (Manina.Windows.Forms.Tab item in tabControl.Tabs)
                    {
                        if (item.Text != "Settings" && item.Text != "Extensions Browser")
                        {
                            tabControl.SelectedTab = item;
                            var myCode = (codeTab)tabControl.Tabs[tabControl.SelectedIndex];
                            if (File.Exists(item.Name))
                            {
                                File.WriteAllText(item.Name, myCode.code.Text);
                                loadStruct(myCode.code.Text);
                            }
                            else
                            {
                                tabControl.SelectedTab = item;
                                myCode = (codeTab)tabControl.Tabs[tabControl.SelectedIndex];
                                SaveFileDialog save = new SaveFileDialog();
                                save.Filter = "All files (*.) | *.";
                                if (save.ShowDialog() != DialogResult.Cancel)
                                {
                                    FileInfo fi = new FileInfo(save.FileName);
                                    File.WriteAllText(fi.FullName, myCode.code.Text);
                                    myCode.Text = fi.Name;
                                    myCode.Name = fi.FullName;
                                    myCode.LoadTopMenuLabel();
                                    loadStruct(myCode.code.Text);
                                }
                            }
                        }
                        if (item.Name.Contains("."))
                        {
                            list.Add(item.Name);
                            File.WriteAllLines(Globals.User + "files.txt", list);
                        }
                    }
                }
                else if (File.Exists(Globals.User + "files.txt"))
                    File.WriteAllText(Globals.User + "files.txt", "");
                if (explorer.Nodes.Count > 0)
                    File.WriteAllText(Globals.User + "workfolder.txt", explorer.Nodes[0].Tag.ToString());
                else if (File.Exists(Globals.User + "workfolder.txt"))
                    File.WriteAllText(Globals.User + "workfolder.txt", "");
            }
            catch { }
            UseWaitCursor = false;
        }

        private void tabControl_PageChanged(object sender, Manina.Windows.Forms.PageChangedEventArgs e)
        {
            
        }

        private void allProcessesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            allProcessesToolStripMenuItem.DropDownItems.Clear();
            foreach (Manina.Windows.Forms.Tab item in TabControlWithTerminals.Tabs)
                allProcessesToolStripMenuItem.DropDownItems.Add(item.Text);
            UseWaitCursor = false;
        }

        private void allProcessesToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            UseWaitCursor = true;
            foreach (Manina.Windows.Forms.Tab item in TabControlWithTerminals.Tabs)
            {
                if (item.Text == e.ClickedItem.Text)
                    TabControlWithTerminals.SelectedTab = item;
            }
            UseWaitCursor = false;
        }

        private void сохранитьВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            List<string> list = new List<string>();
            list.Clear();
            File.WriteAllText(Globals.User + "user.txt", "");
            new ConfigFile(Globals.User + "user.txt").SetProperty("selfile", tabControl.SelectedTab.Text);
            if (tabControl.Tabs.Count > 0)
            {
                foreach (Manina.Windows.Forms.Tab item in tabControl.Tabs)
                {
                    if (item.Text != "Settings" && item.Text != "Extensions Browser")
                    {
                        tabControl.SelectedTab = item;
                        var myCode = (codeTab)tabControl.Tabs[tabControl.SelectedIndex];
                        if (File.Exists(item.Name))
                        {
                            File.WriteAllText(item.Name, myCode.code.Text);
                            loadStruct(myCode.code.Text);
                        }
                        else
                        {
                            tabControl.SelectedTab = item;
                            myCode = (codeTab)tabControl.Tabs[tabControl.SelectedIndex];
                            SaveFileDialog save = new SaveFileDialog();
                            save.Filter = "All files (*.) | *.";
                            if (save.ShowDialog() != DialogResult.Cancel)
                            {
                                FileInfo fi = new FileInfo(save.FileName);
                                File.WriteAllText(fi.FullName, myCode.code.Text);
                                myCode.Text = fi.Name;
                                myCode.Name = fi.FullName;
                                myCode.LoadTopMenuLabel();
                                loadStruct(myCode.code.Text);
                            }
                        }
                    }
                    if (item.Name.Contains("."))
                    {
                        list.Add(item.Name);
                        File.WriteAllLines(Globals.User + "files.txt", list);
                    }
                }
            }
            else if (File.Exists(Globals.User + "files.txt"))
                File.WriteAllText(Globals.User + "files.txt", "");
            if (explorer.Nodes.Count > 0)
                File.WriteAllText(Globals.User + "workfolder.txt", explorer.Nodes[0].Tag.ToString());
            else if (File.Exists(Globals.User + "workfolder.txt"))
                File.WriteAllText(Globals.User + "workfolder.txt", "");
            UseWaitCursor = false;
        }

        private void skidle_DragEnter(object sender, DragEventArgs e)
        {
            UseWaitCursor = true;
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
            UseWaitCursor = false;
        }

        private void skidle_DragDrop(object sender, DragEventArgs e)
        {
            UseWaitCursor = true;
            LoadFCMD((string[])e.Data.GetData(DataFormats.FileDrop));
            UseWaitCursor = false;
        }

        private void explorer_DragDrop(object sender, DragEventArgs e)
        {
            UseWaitCursor = true;
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            FileInfo getDir = new FileInfo(files[0]);
            if (explorer.Nodes.Count >= 0)
            {
                foreach (var item in files)
                {
                    FileInfo dfo = new FileInfo(item);
                    var nody = explorer.Nodes[0].Nodes.Add(dfo.Name, dfo.Name);
                    nody.Tag = dfo;
                }
            }
            UseWaitCursor = false;
        }

        private void explorer_DragEnter(object sender, DragEventArgs e)
        {
            UseWaitCursor = true;
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
            UseWaitCursor = false;
        }
        private bool AskDragOption;
        private void explorer_ItemDrag(object sender, ItemDragEventArgs e)
        {
            if ((e.Item as TreeNode).Tag == null) return;
            if ((e.Button == MouseButtons.Left) || (e.Button == MouseButtons.Right))
            {
                AskDragOption = (e.Button == MouseButtons.Right);
                explorer.DoDragDrop((e.Item as TreeNode).Tag as Obj, DragDropEffects.All);
            }
        }

        private void explorer_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Obj)))
            {
                TreeView tv = (sender as TreeView);
                {
                    if (AskDragOption) e.Effect = DragDropEffects.Link;
                    else if ((e.KeyState == 9)) e.Effect = DragDropEffects.Copy;
                    else
                        e.Effect = DragDropEffects.Move;
                }
            }
        }

        private void окнаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            окнаToolStripMenuItem.DropDownItems.Clear();
            foreach(Manina.Windows.Forms.Tab item in tabControl.Tabs)
                окнаToolStripMenuItem.DropDownItems.Add(item.Text);
            //Theme();
            UseWaitCursor = false;
        }

        private void окнаToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            UseWaitCursor = true;
            foreach (Manina.Windows.Forms.Tab item in tabControl.Tabs)
            {
                if (item.Text == e.ClickedItem.Text)
                    tabControl.SelectedTab = item;
            }
            UseWaitCursor = false;
        }

        private void extensions_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            ExtensionsTab tab = new ExtensionsTab();
            tabControl.Tabs.Add(tab);
            tabControl.SelectedTab = tab;
            UseWaitCursor = false;
        }

        private void updateExplorer_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            try
            {
                explorer.CollapseAll();
                explorer.ExpandAll();
            }
            catch { }
            UseWaitCursor = false;
        }

        private void UnExpand_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            try
            {
                explorer.CollapseAll();
            }
            catch { }
            UseWaitCursor = false;
        }
        private void воВесьЭкранToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(fullscreen == false)
            {
                fullscreen = true;
                this.TopMost = true;
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                fullscreen = false;
                this.TopMost = false;
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Normal;
            }
        }
    }
    class Obj:object
    {

    }
    public class IMenuStrip : ProfessionalColorTable
    {
        public Color BackColor { get; set; }
        public IMenuStrip()
        {
            // see notes
            base.UseSystemColors = false;
        }
        public override System.Drawing.Color MenuBorder
        {
            get { return Color.Red; }
        }
        public override System.Drawing.Color MenuItemBorder
        {
            get { return BackColor; }
        }
        public override Color MenuItemSelected
        {
            get { return Color.FromArgb(95,20,20,20); }
        }
    }
}

