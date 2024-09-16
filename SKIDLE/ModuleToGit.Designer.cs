
namespace SKIDLE
{
    partial class ModuleToGit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.title = new MetroFramework.Controls.MetroLabel();
            this.minSPK = new MetroFramework.Controls.MetroComboBox();
            this.email = new MetroFramework.Controls.MetroTextBox();
            this.desc = new MetroFramework.Controls.MetroTextBox();
            this.pub = new MetroFramework.Controls.MetroButton();
            this.pathtoFolder = new MetroFramework.Controls.MetroTextBox();
            this.author = new MetroFramework.Controls.MetroTextBox();
            this.versionModule = new MetroFramework.Controls.MetroTextBox();
            this.NameModule = new MetroFramework.Controls.MetroTextBox();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.InfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.title.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.title.Location = new System.Drawing.Point(12, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(107, 25);
            this.title.TabIndex = 0;
            this.title.Text = "Параметры";
            this.title.UseCustomBackColor = true;
            this.title.UseCustomForeColor = true;
            // 
            // minSPK
            // 
            this.minSPK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.minSPK.FormattingEnabled = true;
            this.minSPK.ItemHeight = 23;
            this.minSPK.Items.AddRange(new object[] {
            "SPK1",
            "SPK2",
            "SPK3"});
            this.minSPK.Location = new System.Drawing.Point(12, 191);
            this.minSPK.Name = "minSPK";
            this.minSPK.PromptText = "Мин. версия СПК";
            this.minSPK.Size = new System.Drawing.Size(243, 29);
            this.minSPK.TabIndex = 1;
            this.minSPK.UseCustomBackColor = true;
            this.minSPK.UseCustomForeColor = true;
            this.minSPK.UseSelectable = true;
            // 
            // email
            // 
            this.email.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.email.CustomButton.Image = null;
            this.email.CustomButton.Location = new System.Drawing.Point(221, 1);
            this.email.CustomButton.Name = "";
            this.email.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.email.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.email.CustomButton.TabIndex = 1;
            this.email.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.email.CustomButton.UseSelectable = true;
            this.email.CustomButton.Visible = false;
            this.email.Lines = new string[0];
            this.email.Location = new System.Drawing.Point(12, 162);
            this.email.MaxLength = 32767;
            this.email.Name = "email";
            this.email.PasswordChar = '\0';
            //this.email.PromptText = "Эл. Почта";
            this.email.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.email.SelectedText = "";
            this.email.SelectionLength = 0;
            this.email.SelectionStart = 0;
            this.email.Size = new System.Drawing.Size(243, 23);
            this.email.TabIndex = 2;
            this.email.UseCustomBackColor = true;
            this.email.UseCustomForeColor = true;
            this.email.UseSelectable = true;
            this.email.WaterMark = "Эл. Почта";
            this.email.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.email.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // desc
            // 
            this.desc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.desc.CustomButton.Image = null;
            this.desc.CustomButton.Location = new System.Drawing.Point(304, 1);
            this.desc.CustomButton.Name = "";
            this.desc.CustomButton.Size = new System.Drawing.Size(189, 189);
            this.desc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.desc.CustomButton.TabIndex = 1;
            this.desc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.desc.CustomButton.UseSelectable = true;
            this.desc.CustomButton.Visible = false;
            this.desc.Lines = new string[0];
            this.desc.Location = new System.Drawing.Point(12, 226);
            this.desc.MaxLength = 32767;
            this.desc.Multiline = true;
            this.desc.Name = "desc";
            this.desc.PasswordChar = '\0';
            //this.desc.PromptText = "Описание";
            this.desc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.desc.SelectedText = "";
            this.desc.SelectionLength = 0;
            this.desc.SelectionStart = 0;
            this.desc.Size = new System.Drawing.Size(494, 191);
            this.desc.TabIndex = 3;
            this.desc.UseCustomBackColor = true;
            this.desc.UseCustomForeColor = true;
            this.desc.UseSelectable = true;
            this.desc.WaterMark = "Описание";
            this.desc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.desc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pub
            // 
            this.pub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pub.Location = new System.Drawing.Point(414, 423);
            this.pub.Name = "pub";
            this.pub.Size = new System.Drawing.Size(92, 23);
            this.pub.TabIndex = 4;
            this.pub.Text = "Опубликовать";
            this.pub.UseCustomBackColor = true;
            this.pub.UseCustomForeColor = true;
            this.pub.UseSelectable = true;
            this.pub.Click += new System.EventHandler(this.pub_Click);
            // 
            // pathtoFolder
            // 
            this.pathtoFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.pathtoFolder.CustomButton.Image = null;
            this.pathtoFolder.CustomButton.Location = new System.Drawing.Point(221, 1);
            this.pathtoFolder.CustomButton.Name = "";
            this.pathtoFolder.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.pathtoFolder.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.pathtoFolder.CustomButton.TabIndex = 1;
            this.pathtoFolder.CustomButton.Text = "...";
            this.pathtoFolder.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.pathtoFolder.CustomButton.UseSelectable = true;
            this.pathtoFolder.Lines = new string[0];
            this.pathtoFolder.Location = new System.Drawing.Point(12, 133);
            this.pathtoFolder.MaxLength = 32767;
            this.pathtoFolder.Name = "pathtoFolder";
            this.pathtoFolder.PasswordChar = '\0';
            //this.pathtoFolder.PromptText = "Путь до файла";
            this.pathtoFolder.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.pathtoFolder.SelectedText = "";
            this.pathtoFolder.SelectionLength = 0;
            this.pathtoFolder.SelectionStart = 0;
            this.pathtoFolder.ShowButton = true;
            this.pathtoFolder.Size = new System.Drawing.Size(243, 23);
            this.pathtoFolder.TabIndex = 5;
            this.pathtoFolder.UseCustomBackColor = true;
            this.pathtoFolder.UseCustomForeColor = true;
            this.pathtoFolder.UseSelectable = true;
            this.pathtoFolder.WaterMark = "Путь до файла";
            this.pathtoFolder.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.pathtoFolder.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // author
            // 
            this.author.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.author.CustomButton.Image = null;
            this.author.CustomButton.Location = new System.Drawing.Point(221, 1);
            this.author.CustomButton.Name = "";
            this.author.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.author.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.author.CustomButton.TabIndex = 1;
            this.author.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.author.CustomButton.UseSelectable = true;
            this.author.CustomButton.Visible = false;
            this.author.Lines = new string[0];
            this.author.Location = new System.Drawing.Point(263, 133);
            this.author.MaxLength = 32767;
            this.author.Name = "author";
            this.author.PasswordChar = '\0';
           //this.author.PromptText = "Автор";
            this.author.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.author.SelectedText = "";
            this.author.SelectionLength = 0;
            this.author.SelectionStart = 0;
            this.author.Size = new System.Drawing.Size(243, 23);
            this.author.TabIndex = 6;
            this.author.UseCustomBackColor = true;
            this.author.UseCustomForeColor = true;
            this.author.UseSelectable = true;
            this.author.WaterMark = "Автор";
            this.author.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.author.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // versionModule
            // 
            this.versionModule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.versionModule.CustomButton.Image = null;
            this.versionModule.CustomButton.Location = new System.Drawing.Point(221, 1);
            this.versionModule.CustomButton.Name = "";
            this.versionModule.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.versionModule.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.versionModule.CustomButton.TabIndex = 1;
            this.versionModule.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.versionModule.CustomButton.UseSelectable = true;
            this.versionModule.CustomButton.Visible = false;
            this.versionModule.Lines = new string[0];
            this.versionModule.Location = new System.Drawing.Point(263, 162);
            this.versionModule.MaxLength = 32767;
            this.versionModule.Name = "versionModule";
            this.versionModule.PasswordChar = '\0';
            //this.versionModule.PromptText = "Версия модуля";
            this.versionModule.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.versionModule.SelectedText = "";
            this.versionModule.SelectionLength = 0;
            this.versionModule.SelectionStart = 0;
            this.versionModule.Size = new System.Drawing.Size(243, 23);
            this.versionModule.TabIndex = 7;
            this.versionModule.UseCustomBackColor = true;
            this.versionModule.UseCustomForeColor = true;
            this.versionModule.UseSelectable = true;
            this.versionModule.WaterMark = "Версия модуля";
            this.versionModule.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.versionModule.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // NameModule
            // 
            // 
            // 
            // 
            this.NameModule.CustomButton.Image = null;
            this.NameModule.CustomButton.Location = new System.Drawing.Point(221, 1);
            this.NameModule.CustomButton.Name = "";
            this.NameModule.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.NameModule.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NameModule.CustomButton.TabIndex = 1;
            this.NameModule.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NameModule.CustomButton.UseSelectable = true;
            this.NameModule.CustomButton.Visible = false;
            this.NameModule.Lines = new string[0];
            this.NameModule.Location = new System.Drawing.Point(14, 46);
            this.NameModule.MaxLength = 32767;
            this.NameModule.Name = "NameModule";
            this.NameModule.PasswordChar = '\0';
            //this.NameModule.PromptText = "Название модуля";
            this.NameModule.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NameModule.SelectedText = "";
            this.NameModule.SelectionLength = 0;
            this.NameModule.SelectionStart = 0;
            this.NameModule.Size = new System.Drawing.Size(243, 23);
            this.NameModule.TabIndex = 8;
            this.NameModule.UseCustomBackColor = true;
            this.NameModule.UseCustomForeColor = true;
            this.NameModule.UseSelectable = true;
            this.NameModule.WaterMark = "Название модуля";
            this.NameModule.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.NameModule.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // InfoPanel
            // 
            this.InfoPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.InfoPanel.Controls.Add(this.richTextBox1);
            this.InfoPanel.Controls.Add(this.metroLabel1);
            this.InfoPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.InfoPanel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.InfoPanel.Location = new System.Drawing.Point(512, 0);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(229, 448);
            this.InfoPanel.TabIndex = 9;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.richTextBox1.Location = new System.Drawing.Point(3, 34);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(226, 414);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "На вашем пк что то должно быть...";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.metroLabel1.Location = new System.Drawing.Point(0, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(121, 25);
            this.metroLabel1.TabIndex = 10;
            this.metroLabel1.Text = "Информация";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // ModuleToGit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 448);
            this.Controls.Add(this.InfoPanel);
            this.Controls.Add(this.NameModule);
            this.Controls.Add(this.versionModule);
            this.Controls.Add(this.author);
            this.Controls.Add(this.pathtoFolder);
            this.Controls.Add(this.pub);
            this.Controls.Add(this.desc);
            this.Controls.Add(this.email);
            this.Controls.Add(this.minSPK);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ModuleToGit";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "ModuleToGit";
            this.Load += new System.EventHandler(this.ModuleToGit_Load);
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel title;
        private MetroFramework.Controls.MetroComboBox minSPK;
        private MetroFramework.Controls.MetroTextBox email;
        private MetroFramework.Controls.MetroTextBox desc;
        private MetroFramework.Controls.MetroButton pub;
        private MetroFramework.Controls.MetroTextBox pathtoFolder;
        private MetroFramework.Controls.MetroTextBox author;
        private MetroFramework.Controls.MetroTextBox versionModule;
        private MetroFramework.Controls.MetroTextBox NameModule;
        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}