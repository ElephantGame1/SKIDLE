
namespace SKIDLE.UserControls
{
    partial class General
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
            this.title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.themeComboBox = new MetroFramework.Controls.MetroComboBox();
            this.pathToSPK = new MetroFramework.Controls.MetroTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title.Location = new System.Drawing.Point(292, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(103, 31);
            this.title.TabIndex = 0;
            this.title.Text = "General";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.metroLabel1);
            this.panel1.Controls.Add(this.themeComboBox);
            this.panel1.Controls.Add(this.pathToSPK);
            this.panel1.Location = new System.Drawing.Point(0, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 461);
            this.panel1.TabIndex = 1;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(0, 70);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(50, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Theme";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // themeComboBox
            // 
            this.themeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.themeComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.themeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.themeComboBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.themeComboBox.FormattingEnabled = true;
            this.themeComboBox.ItemHeight = 23;
            this.themeComboBox.Location = new System.Drawing.Point(60, 70);
            this.themeComboBox.Name = "themeComboBox";
            this.themeComboBox.PromptText = "theme";
            this.themeComboBox.Size = new System.Drawing.Size(622, 29);
            this.themeComboBox.TabIndex = 1;
            this.themeComboBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.themeComboBox.UseCustomBackColor = true;
            this.themeComboBox.UseCustomForeColor = true;
            this.themeComboBox.UseSelectable = true;
            this.themeComboBox.DropDown += new System.EventHandler(this.themeComboBox_DropDown);
            this.themeComboBox.SelectedIndexChanged += new System.EventHandler(this.themeComboBox_SelectedIndexChanged);
            // 
            // pathToSPK
            // 
            this.pathToSPK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.pathToSPK.CustomButton.Image = null;
            this.pathToSPK.CustomButton.Location = new System.Drawing.Point(657, 1);
            this.pathToSPK.CustomButton.Name = "";
            this.pathToSPK.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.pathToSPK.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.pathToSPK.CustomButton.TabIndex = 1;
            this.pathToSPK.CustomButton.Text = "Ok";
            this.pathToSPK.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.pathToSPK.CustomButton.UseSelectable = true;
            this.pathToSPK.Lines = new string[0];
            this.pathToSPK.Location = new System.Drawing.Point(3, 30);
            this.pathToSPK.MaxLength = 32767;
            this.pathToSPK.Name = "pathToSPK";
            this.pathToSPK.PasswordChar = '\0';
            //this.pathToSPK.PromptText = "Compiler path";
            this.pathToSPK.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.pathToSPK.SelectedText = "";
            this.pathToSPK.SelectionLength = 0;
            this.pathToSPK.SelectionStart = 0;
            this.pathToSPK.ShowButton = true;
            this.pathToSPK.Size = new System.Drawing.Size(679, 23);
            this.pathToSPK.TabIndex = 0;
            this.pathToSPK.UseCustomBackColor = true;
            this.pathToSPK.UseCustomForeColor = true;
            this.pathToSPK.UseSelectable = true;
            this.pathToSPK.UseStyleColors = true;
            this.pathToSPK.WaterMark = "Compiler path";
            this.pathToSPK.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.pathToSPK.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // General
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(0)))), ((int)(((byte)(123)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.title);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "General";
            this.Size = new System.Drawing.Size(685, 495);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTextBox pathToSPK;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox themeComboBox;
    }
}
