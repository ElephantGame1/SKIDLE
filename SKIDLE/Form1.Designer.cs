using System.Net.Mail;

namespace SKIDLE
{
    partial class skidle
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(skidle));
            this.split = new System.Windows.Forms.SplitContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.explorer = new SKIDLE.BufferedTreeView();
            this.explorerPanelTitle = new System.Windows.Forms.Panel();
            this.createFolder = new System.Windows.Forms.Button();
            this.cfExplorer = new System.Windows.Forms.Button();
            this.updateExplorer = new System.Windows.Forms.Button();
            this.UnExpand = new System.Windows.Forms.Button();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.structure = new SKIDLE.UserControls.StructureControl();
            this.panelStructureTitle = new System.Windows.Forms.Panel();
            this.structureTitle = new MetroFramework.Controls.MetroLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.DinRun = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.RunPath = new MetroFramework.Controls.MetroTextBox();
            this.StatRun = new System.Windows.Forms.RadioButton();
            this.codeLaunchScript = new MetroFramework.Controls.MetroTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.RunLabel = new MetroFramework.Controls.MetroLabel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tabControl = new Manina.Windows.Forms.TabControl();
            this.TabControlWithTerminals = new Manina.Windows.Forms.TabControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newTerminalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allProcessesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.переместитьModuleInModulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьВсеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьПапкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьВсеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вырезатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.найтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.перейтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.окнаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.констукторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.структураКодаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проводникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выполнитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.терминалToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.расширенияToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.воВесьЭкранToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.окнаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.терминалToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьТерминалToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запуститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запускToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leftMenu = new SKIDLE.UI.RenPanel();
            this.extensions = new System.Windows.Forms.Button();
            this.run = new System.Windows.Forms.Button();
            this.structureBTN = new System.Windows.Forms.Button();
            this.ExplorerMenu = new System.Windows.Forms.Button();
            this.explorerContMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.createFile = new System.Windows.Forms.ToolStripMenuItem();
            this.openInExplorer = new System.Windows.Forms.ToolStripMenuItem();
            this.rename = new System.Windows.Forms.ToolStripMenuItem();
            this.delete = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.split)).BeginInit();
            this.split.Panel1.SuspendLayout();
            this.split.Panel2.SuspendLayout();
            this.split.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.explorerPanelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.panelStructureTitle.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabMenu.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.leftMenu.SuspendLayout();
            this.explorerContMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // split
            // 
            this.split.Dock = System.Windows.Forms.DockStyle.Fill;
            this.split.Location = new System.Drawing.Point(25, 27);
            this.split.Name = "split";
            // 
            // split.Panel1
            // 
            this.split.Panel1.Controls.Add(this.splitContainer1);
            // 
            // split.Panel2
            // 
            this.split.Panel2.Controls.Add(this.splitContainer2);
            this.split.Size = new System.Drawing.Size(1076, 546);
            this.split.SplitterDistance = 186;
            this.split.TabIndex = 3;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.explorer);
            this.splitContainer1.Panel1.Controls.Add(this.explorerPanelTitle);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Size = new System.Drawing.Size(186, 546);
            this.splitContainer1.SplitterDistance = 66;
            this.splitContainer1.TabIndex = 0;
            // 
            // explorer
            // 
            this.explorer.AllowDrop = true;
            this.explorer.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.explorer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.explorer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.explorer.FullRowSelect = true;
            this.explorer.imageList = null;
            this.explorer.ItemHeight = 22;
            this.explorer.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.explorer.Location = new System.Drawing.Point(0, 19);
            this.explorer.Name = "explorer";
            this.explorer.ShowNodeToolTips = true;
            this.explorer.ShowPlusMinus = false;
            this.explorer.ShowRootLines = false;
            this.explorer.Size = new System.Drawing.Size(186, 47);
            this.explorer.TabIndex = 0;
            this.explorer.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.explorer_ItemDrag);
            this.explorer.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.explorer_NodeMouseClick);
            this.explorer.DragDrop += new System.Windows.Forms.DragEventHandler(this.explorer_DragDrop);
            this.explorer.DragEnter += new System.Windows.Forms.DragEventHandler(this.explorer_DragEnter);
            this.explorer.DragOver += new System.Windows.Forms.DragEventHandler(this.explorer_DragOver);
            this.explorer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.explorer_MouseClick);
            // 
            // explorerPanelTitle
            // 
            this.explorerPanelTitle.Controls.Add(this.createFolder);
            this.explorerPanelTitle.Controls.Add(this.cfExplorer);
            this.explorerPanelTitle.Controls.Add(this.updateExplorer);
            this.explorerPanelTitle.Controls.Add(this.UnExpand);
            this.explorerPanelTitle.Controls.Add(this.metroLabel1);
            this.explorerPanelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.explorerPanelTitle.Location = new System.Drawing.Point(0, 0);
            this.explorerPanelTitle.Name = "explorerPanelTitle";
            this.explorerPanelTitle.Size = new System.Drawing.Size(186, 19);
            this.explorerPanelTitle.TabIndex = 1;
            // 
            // createFolder
            // 
            this.createFolder.BackgroundImage = global::SKIDLE.Properties.Resources.folder;
            this.createFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.createFolder.Dock = System.Windows.Forms.DockStyle.Right;
            this.createFolder.FlatAppearance.BorderSize = 0;
            this.createFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createFolder.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createFolder.Location = new System.Drawing.Point(110, 0);
            this.createFolder.Name = "createFolder";
            this.createFolder.Size = new System.Drawing.Size(19, 19);
            this.createFolder.TabIndex = 4;
            this.createFolder.UseVisualStyleBackColor = false;
            this.createFolder.Click += new System.EventHandler(this.createFile_Click);
            // 
            // cfExplorer
            // 
            this.cfExplorer.BackgroundImage = global::SKIDLE.Properties.Resources.file;
            this.cfExplorer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cfExplorer.Dock = System.Windows.Forms.DockStyle.Right;
            this.cfExplorer.FlatAppearance.BorderSize = 0;
            this.cfExplorer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cfExplorer.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cfExplorer.Location = new System.Drawing.Point(129, 0);
            this.cfExplorer.Name = "cfExplorer";
            this.cfExplorer.Size = new System.Drawing.Size(19, 19);
            this.cfExplorer.TabIndex = 3;
            this.cfExplorer.UseVisualStyleBackColor = false;
            this.cfExplorer.Click += new System.EventHandler(this.createFile_Click);
            // 
            // updateExplorer
            // 
            this.updateExplorer.BackgroundImage = global::SKIDLE.Properties.Resources.update;
            this.updateExplorer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.updateExplorer.Dock = System.Windows.Forms.DockStyle.Right;
            this.updateExplorer.FlatAppearance.BorderSize = 0;
            this.updateExplorer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateExplorer.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateExplorer.Location = new System.Drawing.Point(148, 0);
            this.updateExplorer.Name = "updateExplorer";
            this.updateExplorer.Size = new System.Drawing.Size(19, 19);
            this.updateExplorer.TabIndex = 2;
            this.updateExplorer.UseVisualStyleBackColor = false;
            this.updateExplorer.Click += new System.EventHandler(this.updateExplorer_Click);
            // 
            // UnExpand
            // 
            this.UnExpand.BackgroundImage = global::SKIDLE.Properties.Resources.collapse;
            this.UnExpand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.UnExpand.Dock = System.Windows.Forms.DockStyle.Right;
            this.UnExpand.FlatAppearance.BorderSize = 0;
            this.UnExpand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UnExpand.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UnExpand.Location = new System.Drawing.Point(167, 0);
            this.UnExpand.Name = "UnExpand";
            this.UnExpand.Size = new System.Drawing.Size(19, 19);
            this.UnExpand.TabIndex = 1;
            this.UnExpand.UseVisualStyleBackColor = false;
            this.UnExpand.Click += new System.EventHandler(this.UnExpand_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(0, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(90, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Проводник";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.structure);
            this.splitContainer3.Panel1.Controls.Add(this.panelStructureTitle);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.label2);
            this.splitContainer3.Panel2.Controls.Add(this.DinRun);
            this.splitContainer3.Panel2.Controls.Add(this.label1);
            this.splitContainer3.Panel2.Controls.Add(this.RunPath);
            this.splitContainer3.Panel2.Controls.Add(this.StatRun);
            this.splitContainer3.Panel2.Controls.Add(this.codeLaunchScript);
            this.splitContainer3.Panel2.Controls.Add(this.panel1);
            this.splitContainer3.Size = new System.Drawing.Size(186, 476);
            this.splitContainer3.SplitterDistance = 67;
            this.splitContainer3.TabIndex = 0;
            // 
            // structure
            // 
            this.structure.BackColor = System.Drawing.SystemColors.Control;
            this.structure.code = null;
            this.structure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.structure.Location = new System.Drawing.Point(0, 19);
            this.structure.Margin = new System.Windows.Forms.Padding(2);
            this.structure.Name = "structure";
            this.structure.Size = new System.Drawing.Size(186, 48);
            this.structure.TabIndex = 0;
            // 
            // panelStructureTitle
            // 
            this.panelStructureTitle.Controls.Add(this.structureTitle);
            this.panelStructureTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStructureTitle.Location = new System.Drawing.Point(0, 0);
            this.panelStructureTitle.Name = "panelStructureTitle";
            this.panelStructureTitle.Size = new System.Drawing.Size(186, 19);
            this.panelStructureTitle.TabIndex = 3;
            // 
            // structureTitle
            // 
            this.structureTitle.AutoSize = true;
            this.structureTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.structureTitle.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.structureTitle.Location = new System.Drawing.Point(0, 0);
            this.structureTitle.Name = "structureTitle";
            this.structureTitle.Size = new System.Drawing.Size(80, 19);
            this.structureTitle.TabIndex = 1;
            this.structureTitle.Text = "Структура";
            this.structureTitle.UseCustomBackColor = true;
            this.structureTitle.UseCustomForeColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(0, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 28);
            this.label2.TabIndex = 9;
            this.label2.Text = "Запуск файла в\r\nвыбранной вкладке";
            // 
            // DinRun
            // 
            this.DinRun.AutoSize = true;
            this.DinRun.Dock = System.Windows.Forms.DockStyle.Top;
            this.DinRun.Location = new System.Drawing.Point(0, 111);
            this.DinRun.Name = "DinRun";
            this.DinRun.Size = new System.Drawing.Size(186, 22);
            this.DinRun.TabIndex = 6;
            this.DinRun.TabStop = true;
            this.DinRun.Text = "Дин.Запуск";
            this.DinRun.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "Запуск только одного\r\nопр. файла";
            // 
            // RunPath
            // 
            // 
            // 
            // 
            this.RunPath.CustomButton.Image = null;
            this.RunPath.CustomButton.Location = new System.Drawing.Point(166, 1);
            this.RunPath.CustomButton.Name = "";
            this.RunPath.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.RunPath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.RunPath.CustomButton.TabIndex = 1;
            this.RunPath.CustomButton.Text = "...";
            this.RunPath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.RunPath.CustomButton.UseSelectable = true;
            this.RunPath.Dock = System.Windows.Forms.DockStyle.Top;
            this.RunPath.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.RunPath.Lines = new string[0];
            this.RunPath.Location = new System.Drawing.Point(0, 62);
            this.RunPath.MaxLength = 32767;
            this.RunPath.Name = "RunPath";
            this.RunPath.PasswordChar = '\0';
            this.RunPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.RunPath.SelectedText = "";
            this.RunPath.SelectionLength = 0;
            this.RunPath.SelectionStart = 0;
            this.RunPath.ShowButton = true;
            this.RunPath.Size = new System.Drawing.Size(186, 21);
            this.RunPath.TabIndex = 7;
            this.RunPath.UseCustomBackColor = true;
            this.RunPath.UseCustomForeColor = true;
            this.RunPath.UseSelectable = true;
            this.RunPath.WaterMark = "Path to file";
            this.RunPath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.RunPath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // StatRun
            // 
            this.StatRun.AutoSize = true;
            this.StatRun.Dock = System.Windows.Forms.DockStyle.Top;
            this.StatRun.Location = new System.Drawing.Point(0, 40);
            this.StatRun.Name = "StatRun";
            this.StatRun.Size = new System.Drawing.Size(186, 22);
            this.StatRun.TabIndex = 5;
            this.StatRun.TabStop = true;
            this.StatRun.Text = "Стат. запуск";
            this.StatRun.UseVisualStyleBackColor = true;
            // 
            // codeLaunchScript
            // 
            // 
            // 
            // 
            this.codeLaunchScript.CustomButton.Image = null;
            this.codeLaunchScript.CustomButton.Location = new System.Drawing.Point(166, 1);
            this.codeLaunchScript.CustomButton.Name = "";
            this.codeLaunchScript.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.codeLaunchScript.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.codeLaunchScript.CustomButton.TabIndex = 1;
            this.codeLaunchScript.CustomButton.Text = "...";
            this.codeLaunchScript.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.codeLaunchScript.CustomButton.UseSelectable = true;
            this.codeLaunchScript.Dock = System.Windows.Forms.DockStyle.Top;
            this.codeLaunchScript.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.codeLaunchScript.Lines = new string[0];
            this.codeLaunchScript.Location = new System.Drawing.Point(0, 19);
            this.codeLaunchScript.MaxLength = 32767;
            this.codeLaunchScript.Name = "codeLaunchScript";
            this.codeLaunchScript.PasswordChar = '\0';
            this.codeLaunchScript.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.codeLaunchScript.SelectedText = "";
            this.codeLaunchScript.SelectionLength = 0;
            this.codeLaunchScript.SelectionStart = 0;
            this.codeLaunchScript.ShowButton = true;
            this.codeLaunchScript.Size = new System.Drawing.Size(186, 21);
            this.codeLaunchScript.TabIndex = 10;
            this.codeLaunchScript.UseCustomBackColor = true;
            this.codeLaunchScript.UseCustomForeColor = true;
            this.codeLaunchScript.UseSelectable = true;
            this.codeLaunchScript.WaterMark = "Script of Code Launch";
            this.codeLaunchScript.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.codeLaunchScript.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.metroLabel2);
            this.panel1.Controls.Add(this.RunLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 19);
            this.panel1.TabIndex = 4;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel2.Location = new System.Drawing.Point(57, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(71, 15);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "не доступно";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // RunLabel
            // 
            this.RunLabel.AutoSize = true;
            this.RunLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.RunLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.RunLabel.Location = new System.Drawing.Point(0, 0);
            this.RunLabel.Name = "RunLabel";
            this.RunLabel.Size = new System.Drawing.Size(57, 19);
            this.RunLabel.TabIndex = 1;
            this.RunLabel.Text = "Запуск";
            this.RunLabel.UseCustomBackColor = true;
            this.RunLabel.UseCustomForeColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tabControl);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.TabControlWithTerminals);
            this.splitContainer2.Size = new System.Drawing.Size(886, 546);
            this.splitContainer2.SplitterDistance = 406;
            this.splitContainer2.TabIndex = 2;
            // 
            // tabControl
            // 
            this.tabControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = -1;
            this.tabControl.ShowCloseTabButtons = true;
            this.tabControl.Size = new System.Drawing.Size(886, 406);
            this.tabControl.TabIndex = 1;
            this.tabControl.TabSize = new System.Drawing.Size(125, 23);
            this.tabControl.TabSizing = Manina.Windows.Forms.TabSizing.Fixed;
            // 
            // TabControlWithTerminals
            // 
            this.TabControlWithTerminals.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TabControlWithTerminals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControlWithTerminals.Location = new System.Drawing.Point(0, 0);
            this.TabControlWithTerminals.Name = "TabControlWithTerminals";
            this.TabControlWithTerminals.SelectedIndex = -1;
            this.TabControlWithTerminals.ShowCloseTabButtons = true;
            this.TabControlWithTerminals.Size = new System.Drawing.Size(886, 136);
            this.TabControlWithTerminals.TabIndex = 0;
            this.TabControlWithTerminals.TabSize = new System.Drawing.Size(95, 23);
            this.TabControlWithTerminals.TabSizing = Manina.Windows.Forms.TabSizing.Fixed;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTerminalToolStripMenuItem,
            this.allProcessesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(886, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newTerminalToolStripMenuItem
            // 
            this.newTerminalToolStripMenuItem.Name = "newTerminalToolStripMenuItem";
            this.newTerminalToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.newTerminalToolStripMenuItem.Text = "New Terminal";
            this.newTerminalToolStripMenuItem.Click += new System.EventHandler(this.newTerminal);
            // 
            // allProcessesToolStripMenuItem
            // 
            this.allProcessesToolStripMenuItem.Name = "allProcessesToolStripMenuItem";
            this.allProcessesToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.allProcessesToolStripMenuItem.Text = "All processes";
            this.allProcessesToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.allProcessesToolStripMenuItem_DropDownItemClicked);
            this.allProcessesToolStripMenuItem.Click += new System.EventHandler(this.allProcessesToolStripMenuItem_Click);
            // 
            // tabMenu
            // 
            this.tabMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.переместитьModuleInModulesToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.Size = new System.Drawing.Size(253, 48);
            // 
            // переместитьModuleInModulesToolStripMenuItem
            // 
            this.переместитьModuleInModulesToolStripMenuItem.Name = "переместитьModuleInModulesToolStripMenuItem";
            this.переместитьModuleInModulesToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.переместитьModuleInModulesToolStripMenuItem.Text = "Переместить module in modules";
            this.переместитьModuleInModulesToolStripMenuItem.Click += new System.EventHandler(this.переместитьModuleInModulesToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.правкаToolStripMenuItem,
            this.видToolStripMenuItem,
            this.окнаToolStripMenuItem,
            this.терминалToolStripMenuItem,
            this.запуститьToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip.Size = new System.Drawing.Size(1101, 27);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem,
            this.сохранитьВсеToolStripMenuItem,
            this.открытьПапкуToolStripMenuItem,
            this.настройкиToolStripMenuItem3,
            this.открытьФайлToolStripMenuItem,
            this.создатьToolStripMenuItem,
            this.закрытьВсеToolStripMenuItem,
            this.закрытьToolStripMenuItem,
            this.выйтиToolStripMenuItem});
            this.файлToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(52, 21);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
            // 
            // сохранитьВсеToolStripMenuItem
            // 
            this.сохранитьВсеToolStripMenuItem.Name = "сохранитьВсеToolStripMenuItem";
            this.сохранитьВсеToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            this.сохранитьВсеToolStripMenuItem.Text = "Сохранить Все";
            this.сохранитьВсеToolStripMenuItem.Click += new System.EventHandler(this.сохранитьВсеToolStripMenuItem_Click);
            // 
            // открытьПапкуToolStripMenuItem
            // 
            this.открытьПапкуToolStripMenuItem.Name = "открытьПапкуToolStripMenuItem";
            this.открытьПапкуToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.O)));
            this.открытьПапкуToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            this.открытьПапкуToolStripMenuItem.Text = "Открыть папку";
            this.открытьПапкуToolStripMenuItem.Click += new System.EventHandler(this.открытьПапкуToolStripMenuItem_Click);
            // 
            // настройкиToolStripMenuItem3
            // 
            this.настройкиToolStripMenuItem3.Name = "настройкиToolStripMenuItem3";
            this.настройкиToolStripMenuItem3.Size = new System.Drawing.Size(265, 22);
            this.настройкиToolStripMenuItem3.Text = "Настройки";
            this.настройкиToolStripMenuItem3.Click += new System.EventHandler(this.настройкиToolStripMenuItem1_Click);
            // 
            // открытьФайлToolStripMenuItem
            // 
            this.открытьФайлToolStripMenuItem.Name = "открытьФайлToolStripMenuItem";
            this.открытьФайлToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.открытьФайлToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            this.открытьФайлToolStripMenuItem.Text = "Открыть файл";
            this.открытьФайлToolStripMenuItem.Click += new System.EventHandler(this.открытьФайлToolStripMenuItem_Click);
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            this.создатьToolStripMenuItem.Text = "Создать новый файл ";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // закрытьВсеToolStripMenuItem
            // 
            this.закрытьВсеToolStripMenuItem.Name = "закрытьВсеToolStripMenuItem";
            this.закрытьВсеToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            this.закрытьВсеToolStripMenuItem.Text = "Закрыть все";
            this.закрытьВсеToolStripMenuItem.Click += new System.EventHandler(this.закрытьВсеToolStripMenuItem_Click);
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            this.выйтиToolStripMenuItem.Text = "Выйти";
            this.выйтиToolStripMenuItem.Click += new System.EventHandler(this.выйтиToolStripMenuItem_Click);
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вырезатьToolStripMenuItem,
            this.копироватьToolStripMenuItem,
            this.вставитьToolStripMenuItem,
            this.найтиToolStripMenuItem,
            this.перейтиToolStripMenuItem,
            this.заменитьToolStripMenuItem});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(65, 21);
            this.правкаToolStripMenuItem.Text = "Правка";
            // 
            // вырезатьToolStripMenuItem
            // 
            this.вырезатьToolStripMenuItem.Name = "вырезатьToolStripMenuItem";
            this.вырезатьToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.вырезатьToolStripMenuItem.Text = "Вырезать";
            this.вырезатьToolStripMenuItem.Click += new System.EventHandler(this.вырезатьToolStripMenuItem_Click);
            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.копироватьToolStripMenuItem.Text = "Копировать";
            this.копироватьToolStripMenuItem.Click += new System.EventHandler(this.копироватьToolStripMenuItem_Click);
            // 
            // вставитьToolStripMenuItem
            // 
            this.вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            this.вставитьToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.вставитьToolStripMenuItem.Text = "Вставить";
            this.вставитьToolStripMenuItem.Click += new System.EventHandler(this.вставитьToolStripMenuItem_Click);
            // 
            // найтиToolStripMenuItem
            // 
            this.найтиToolStripMenuItem.Name = "найтиToolStripMenuItem";
            this.найтиToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.найтиToolStripMenuItem.Text = "Найти";
            this.найтиToolStripMenuItem.Click += new System.EventHandler(this.найтиToolStripMenuItem_Click);
            // 
            // перейтиToolStripMenuItem
            // 
            this.перейтиToolStripMenuItem.Name = "перейтиToolStripMenuItem";
            this.перейтиToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.перейтиToolStripMenuItem.Text = "Перейти";
            this.перейтиToolStripMenuItem.Click += new System.EventHandler(this.перейтиToolStripMenuItem_Click);
            // 
            // заменитьToolStripMenuItem
            // 
            this.заменитьToolStripMenuItem.Name = "заменитьToolStripMenuItem";
            this.заменитьToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.заменитьToolStripMenuItem.Text = "Заменить";
            this.заменитьToolStripMenuItem.Click += new System.EventHandler(this.заменитьToolStripMenuItem_Click);
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.окнаToolStripMenuItem1,
            this.констукторToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.структураКодаToolStripMenuItem,
            this.проводникToolStripMenuItem,
            this.выполнитьToolStripMenuItem1,
            this.терминалToolStripMenuItem1,
            this.расширенияToolStripMenuItem1,
            this.настройкиToolStripMenuItem2,
            this.воВесьЭкранToolStripMenuItem});
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            this.видToolStripMenuItem.Size = new System.Drawing.Size(43, 21);
            this.видToolStripMenuItem.Text = "Вид";
            // 
            // окнаToolStripMenuItem1
            // 
            this.окнаToolStripMenuItem1.Name = "окнаToolStripMenuItem1";
            this.окнаToolStripMenuItem1.Size = new System.Drawing.Size(169, 22);
            this.окнаToolStripMenuItem1.Text = "Окна";
            this.окнаToolStripMenuItem1.Click += new System.EventHandler(this.окнаToolStripMenuItem_Click);
            // 
            // констукторToolStripMenuItem
            // 
            this.констукторToolStripMenuItem.Name = "констукторToolStripMenuItem";
            this.констукторToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.констукторToolStripMenuItem.Text = "Констуктор";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            // 
            // структураКодаToolStripMenuItem
            // 
            this.структураКодаToolStripMenuItem.Name = "структураКодаToolStripMenuItem";
            this.структураКодаToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.структураКодаToolStripMenuItem.Text = "Структура кода";
            this.структураКодаToolStripMenuItem.Click += new System.EventHandler(this.structureBTN_Click);
            // 
            // проводникToolStripMenuItem
            // 
            this.проводникToolStripMenuItem.Name = "проводникToolStripMenuItem";
            this.проводникToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.проводникToolStripMenuItem.Text = "Проводник";
            this.проводникToolStripMenuItem.Click += new System.EventHandler(this.ExplorerMenu_Click);
            // 
            // выполнитьToolStripMenuItem1
            // 
            this.выполнитьToolStripMenuItem1.Name = "выполнитьToolStripMenuItem1";
            this.выполнитьToolStripMenuItem1.Size = new System.Drawing.Size(169, 22);
            this.выполнитьToolStripMenuItem1.Text = "Выполнить";
            this.выполнитьToolStripMenuItem1.Click += new System.EventHandler(this.RunMenu_Click);
            // 
            // терминалToolStripMenuItem1
            // 
            this.терминалToolStripMenuItem1.Name = "терминалToolStripMenuItem1";
            this.терминалToolStripMenuItem1.Size = new System.Drawing.Size(169, 22);
            this.терминалToolStripMenuItem1.Text = "Терминал";
            this.терминалToolStripMenuItem1.Click += new System.EventHandler(this.открытьТерминалToolStripMenuItem_Click);
            // 
            // расширенияToolStripMenuItem1
            // 
            this.расширенияToolStripMenuItem1.Name = "расширенияToolStripMenuItem1";
            this.расширенияToolStripMenuItem1.Size = new System.Drawing.Size(169, 22);
            this.расширенияToolStripMenuItem1.Text = "Расширения";
            this.расширенияToolStripMenuItem1.Visible = false;
            this.расширенияToolStripMenuItem1.Click += new System.EventHandler(this.extensions_Click);
            // 
            // настройкиToolStripMenuItem2
            // 
            this.настройкиToolStripMenuItem2.Name = "настройкиToolStripMenuItem2";
            this.настройкиToolStripMenuItem2.Size = new System.Drawing.Size(169, 22);
            this.настройкиToolStripMenuItem2.Text = "Настройки";
            this.настройкиToolStripMenuItem2.Visible = false;
            this.настройкиToolStripMenuItem2.Click += new System.EventHandler(this.настройкиToolStripMenuItem1_Click);
            // 
            // воВесьЭкранToolStripMenuItem
            // 
            this.воВесьЭкранToolStripMenuItem.Name = "воВесьЭкранToolStripMenuItem";
            this.воВесьЭкранToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.воВесьЭкранToolStripMenuItem.Text = "Во весь экран";
            this.воВесьЭкранToolStripMenuItem.Click += new System.EventHandler(this.воВесьЭкранToolStripMenuItem_Click);
            // 
            // окнаToolStripMenuItem
            // 
            this.окнаToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.окнаToolStripMenuItem.Name = "окнаToolStripMenuItem";
            this.окнаToolStripMenuItem.Size = new System.Drawing.Size(52, 21);
            this.окнаToolStripMenuItem.Text = "Окна";
            this.окнаToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.окнаToolStripMenuItem_DropDownItemClicked);
            this.окнаToolStripMenuItem.Click += new System.EventHandler(this.окнаToolStripMenuItem_Click);
            // 
            // терминалToolStripMenuItem
            // 
            this.терминалToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьТерминалToolStripMenuItem});
            this.терминалToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.терминалToolStripMenuItem.Name = "терминалToolStripMenuItem";
            this.терминалToolStripMenuItem.Size = new System.Drawing.Size(81, 21);
            this.терминалToolStripMenuItem.Text = "Терминал";
            // 
            // открытьТерминалToolStripMenuItem
            // 
            this.открытьТерминалToolStripMenuItem.Name = "открытьТерминалToolStripMenuItem";
            this.открытьТерминалToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.открытьТерминалToolStripMenuItem.Text = "Открыть Терминал";
            this.открытьТерминалToolStripMenuItem.Click += new System.EventHandler(this.открытьТерминалToolStripMenuItem_Click);
            // 
            // запуститьToolStripMenuItem
            // 
            this.запуститьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.запускToolStripMenuItem});
            this.запуститьToolStripMenuItem.Name = "запуститьToolStripMenuItem";
            this.запуститьToolStripMenuItem.Size = new System.Drawing.Size(79, 21);
            this.запуститьToolStripMenuItem.Text = "Запустить";
            // 
            // запускToolStripMenuItem
            // 
            this.запускToolStripMenuItem.Name = "запускToolStripMenuItem";
            this.запускToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.запускToolStripMenuItem.Text = "Запуск";
            this.запускToolStripMenuItem.Click += new System.EventHandler(this.запуститьToolStripMenuItem_Click);
            // 
            // leftMenu
            // 
            this.leftMenu.Controls.Add(this.extensions);
            this.leftMenu.Controls.Add(this.run);
            this.leftMenu.Controls.Add(this.structureBTN);
            this.leftMenu.Controls.Add(this.ExplorerMenu);
            this.leftMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftMenu.Location = new System.Drawing.Point(0, 27);
            this.leftMenu.Name = "leftMenu";
            this.leftMenu.Size = new System.Drawing.Size(25, 546);
            this.leftMenu.TabIndex = 2;
            // 
            // extensions
            // 
            this.extensions.BackgroundImage = global::SKIDLE.Properties.Resources.download__2_;
            this.extensions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.extensions.Dock = System.Windows.Forms.DockStyle.Top;
            this.extensions.FlatAppearance.BorderSize = 0;
            this.extensions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.extensions.Location = new System.Drawing.Point(0, 66);
            this.extensions.Name = "extensions";
            this.extensions.Size = new System.Drawing.Size(25, 22);
            this.extensions.TabIndex = 5;
            this.extensions.UseVisualStyleBackColor = false;
            this.extensions.Visible = false;
            this.extensions.Click += new System.EventHandler(this.extensions_Click);
            // 
            // run
            // 
            this.run.BackgroundImage = global::SKIDLE.Properties.Resources.run2;
            this.run.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.run.Dock = System.Windows.Forms.DockStyle.Top;
            this.run.FlatAppearance.BorderSize = 0;
            this.run.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.run.Location = new System.Drawing.Point(0, 44);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(25, 22);
            this.run.TabIndex = 3;
            this.run.UseVisualStyleBackColor = false;
            this.run.Click += new System.EventHandler(this.RunMenu_Click);
            // 
            // structureBTN
            // 
            this.structureBTN.BackgroundImage = global::SKIDLE.Properties.Resources.classBTN;
            this.structureBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.structureBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.structureBTN.FlatAppearance.BorderSize = 0;
            this.structureBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.structureBTN.Location = new System.Drawing.Point(0, 22);
            this.structureBTN.Name = "structureBTN";
            this.structureBTN.Size = new System.Drawing.Size(25, 22);
            this.structureBTN.TabIndex = 4;
            this.structureBTN.UseVisualStyleBackColor = false;
            this.structureBTN.Visible = false;
            this.structureBTN.Click += new System.EventHandler(this.structureBTN_Click);
            // 
            // ExplorerMenu
            // 
            this.ExplorerMenu.BackgroundImage = global::SKIDLE.Properties.Resources.files2;
            this.ExplorerMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExplorerMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.ExplorerMenu.FlatAppearance.BorderSize = 0;
            this.ExplorerMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExplorerMenu.Location = new System.Drawing.Point(0, 0);
            this.ExplorerMenu.Name = "ExplorerMenu";
            this.ExplorerMenu.Size = new System.Drawing.Size(25, 22);
            this.ExplorerMenu.TabIndex = 2;
            this.ExplorerMenu.UseVisualStyleBackColor = false;
            this.ExplorerMenu.Click += new System.EventHandler(this.ExplorerMenu_Click);
            // 
            // explorerContMenu
            // 
            this.explorerContMenu.BackColor = System.Drawing.Color.White;
            this.explorerContMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createFile,
            this.openInExplorer,
            this.rename,
            this.delete});
            this.explorerContMenu.Name = "explorerContMenu";
            this.explorerContMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.explorerContMenu.Size = new System.Drawing.Size(200, 92);
            // 
            // createFile
            // 
            this.createFile.Name = "createFile";
            this.createFile.Size = new System.Drawing.Size(199, 22);
            this.createFile.Text = "Создать";
            this.createFile.Click += new System.EventHandler(this.createFile_Click);
            // 
            // openInExplorer
            // 
            this.openInExplorer.Name = "openInExplorer";
            this.openInExplorer.Size = new System.Drawing.Size(199, 22);
            this.openInExplorer.Text = "Открыть в проводнике";
            this.openInExplorer.Click += new System.EventHandler(this.openInExplorer_Click);
            // 
            // rename
            // 
            this.rename.Name = "rename";
            this.rename.Size = new System.Drawing.Size(199, 22);
            this.rename.Text = "Переименовать";
            this.rename.Click += new System.EventHandler(this.rename_Click);
            // 
            // delete
            // 
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(199, 22);
            this.delete.Text = "Удалить";
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // skidle
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1101, 573);
            this.Controls.Add(this.split);
            this.Controls.Add(this.leftMenu);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "skidle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SKIDLE";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.skidle_FormClosing);
            this.Load += new System.EventHandler(this.skidle_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.skidle_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.skidle_DragEnter);
            this.split.Panel1.ResumeLayout(false);
            this.split.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.split)).EndInit();
            this.split.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.explorerPanelTitle.ResumeLayout(false);
            this.explorerPanelTitle.PerformLayout();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.panelStructureTitle.ResumeLayout(false);
            this.panelStructureTitle.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabMenu.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.leftMenu.ResumeLayout(false);
            this.explorerContMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem терминалToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьТерминалToolStripMenuItem;
        private UI.RenPanel leftMenu;
        private System.Windows.Forms.SplitContainer split;
        private System.Windows.Forms.Button ExplorerMenu;
        private System.Windows.Forms.ToolStripMenuItem открытьПапкуToolStripMenuItem;
        private BufferedTreeView explorer;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вырезатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem найтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem перейтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьВсеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.Button run;
        private System.Windows.Forms.ContextMenuStrip explorerContMenu;
        private System.Windows.Forms.ToolStripMenuItem createFile;
        private System.Windows.Forms.ToolStripMenuItem openInExplorer;
        private System.Windows.Forms.ToolStripMenuItem rename;
        private System.Windows.Forms.ToolStripMenuItem delete;
        private System.Windows.Forms.Panel explorerPanelTitle;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private UserControls.StructureControl structure;
        private System.Windows.Forms.Panel panelStructureTitle;
        private MetroFramework.Controls.MetroLabel structureTitle;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button structureBTN;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ContextMenuStrip tabMenu;
        private System.Windows.Forms.ToolStripMenuItem переместитьModuleInModulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton DinRun;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox RunPath;
        private System.Windows.Forms.RadioButton StatRun;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLabel RunLabel;
        private System.Windows.Forms.ToolStripMenuItem сохранитьВсеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem окнаToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newTerminalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allProcessesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem окнаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem констукторToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem структураКодаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проводникToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выполнитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem терминалToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem расширенияToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem воВесьЭкранToolStripMenuItem;
        private System.Windows.Forms.Button extensions;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.Button createFolder;
        private System.Windows.Forms.Button cfExplorer;
        private System.Windows.Forms.Button updateExplorer;
        private System.Windows.Forms.Button UnExpand;
        private MetroFramework.Controls.MetroTextBox codeLaunchScript;
        private System.Windows.Forms.ToolStripMenuItem запуститьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запускToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem3;
        private Manina.Windows.Forms.TabControl tabControl;
        private Manina.Windows.Forms.TabControl TabControlWithTerminals;
    }
}

