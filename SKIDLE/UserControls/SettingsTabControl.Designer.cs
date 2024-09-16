
using SKIDLE.UI;
using System.Windows.Forms;

namespace SKIDLE.UserControls
{
    partial class SettingsTabControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.ver = new System.Windows.Forms.Label();
            this.about = new System.Windows.Forms.Button();
            this.txteditor = new System.Windows.Forms.Button();
            this.main = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.general = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.Button();
            this.anim = new System.Windows.Forms.Timer(this.components);
            this.leftPanel.SuspendLayout();
            this.main.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.leftPanel.Controls.Add(this.ver);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.leftPanel.Location = new System.Drawing.Point(0, 411);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(739, 10);
            this.leftPanel.TabIndex = 0;
            // 
            // ver
            // 
            this.ver.AutoSize = true;
            this.ver.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ver.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ver.Location = new System.Drawing.Point(0, -3);
            this.ver.Name = "ver";
            this.ver.Size = new System.Drawing.Size(22, 13);
            this.ver.TabIndex = 1;
            this.ver.Text = "ver";
            // 
            // about
            // 
            this.about.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.about.FlatAppearance.BorderSize = 0;
            this.about.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.about.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.about.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.about.Image = global::SKIDLE.Properties.Resources.icons8_info_32__1_;
            this.about.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.about.ImageKey = "icons8-info-32 (1).png";
            this.about.Location = new System.Drawing.Point(0, 87);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(145, 29);
            this.about.TabIndex = 2;
            this.about.Text = "About";
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // txteditor
            // 
            this.txteditor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.txteditor.FlatAppearance.BorderSize = 0;
            this.txteditor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txteditor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txteditor.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txteditor.Image = global::SKIDLE.Properties.Resources.icons8_edit_32__1_;
            this.txteditor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txteditor.ImageKey = "icons8-edit-32 (1).png";
            this.txteditor.Location = new System.Drawing.Point(0, 58);
            this.txteditor.Name = "txteditor";
            this.txteditor.Size = new System.Drawing.Size(145, 29);
            this.txteditor.TabIndex = 1;
            this.txteditor.Text = "Editor";
            this.txteditor.Click += new System.EventHandler(this.txteditor_Click);
            // 
            // main
            // 
            this.main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.main.Controls.Add(this.title);
            this.main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main.Location = new System.Drawing.Point(125, 0);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(614, 411);
            this.main.TabIndex = 1;
            this.main.Paint += new System.Windows.Forms.PaintEventHandler(this.main_Paint);
            // 
            // title
            // 
            this.title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.title.Location = new System.Drawing.Point(214, 156);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(162, 26);
            this.title.TabIndex = 0;
            this.title.Text = "Welcome, User!";
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(48)))), ((int)(((byte)(50)))));
            this.panel.Controls.Add(this.about);
            this.panel.Controls.Add(this.txteditor);
            this.panel.Controls.Add(this.general);
            this.panel.Controls.Add(this.menu);
            this.panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(125, 411);
            this.panel.TabIndex = 2;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // general
            // 
            this.general.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.general.FlatAppearance.BorderSize = 0;
            this.general.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.general.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.general.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.general.Image = global::SKIDLE.Properties.Resources.icons8_home_page_32__1_;
            this.general.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.general.ImageKey = "icons8-home-page-64 (1).png";
            this.general.Location = new System.Drawing.Point(0, 29);
            this.general.Name = "general";
            this.general.Padding = new System.Windows.Forms.Padding(2);
            this.general.Size = new System.Drawing.Size(145, 29);
            this.general.TabIndex = 0;
            this.general.Text = "General";
            this.general.UseVisualStyleBackColor = true;
            this.general.Click += new System.EventHandler(this.general_Click);
            // 
            // menu
            // 
            this.menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.menu.FlatAppearance.BorderSize = 0;
            this.menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menu.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.menu.Image = global::SKIDLE.Properties.Resources.icons8_menu_32__1_;
            this.menu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu.ImageKey = "icons8-info-32 (1).png";
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(145, 29);
            this.menu.TabIndex = 3;
            this.menu.Text = "Menu";
            this.menu.Click += new System.EventHandler(this.button1_Click);
            // 
            // anim
            // 
            this.anim.Interval = 10;
            this.anim.Tick += new System.EventHandler(this.anim_Tick);
            // 
            // SettingsTabControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.main);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.leftPanel);
            this.Name = "SettingsTabControl";
            this.Size = new System.Drawing.Size(739, 421);
            this.Load += new System.EventHandler(this.SettingsTabControl_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.main.ResumeLayout(false);
            this.main.PerformLayout();
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel main;
        private Button about;
        private Button txteditor;
        private Button general;
        private Label title;
        private Label ver;
        private Panel panel;
        private Button menu;
        private Timer anim;
    }
}
