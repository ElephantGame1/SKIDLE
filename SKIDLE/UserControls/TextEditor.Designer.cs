
using System.Drawing;

namespace SKIDLE.UserControls
{
    partial class TextEditor
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
            this.ServiceColors = new MetroFramework.Controls.MetroTextBox();
            this.SelectionColor = new MetroFramework.Controls.MetroTextBox();
            this.LineNumberColor = new MetroFramework.Controls.MetroTextBox();
            this.IndentBackColor = new MetroFramework.Controls.MetroTextBox();
            this.ForeColor = new MetroFramework.Controls.MetroTextBox();
            this.DisabledColor = new MetroFramework.Controls.MetroTextBox();
            this.CharWidth = new MetroFramework.Controls.MetroTextBox();
            this.CharHeight = new MetroFramework.Controls.MetroTextBox();
            this.BackColor = new MetroFramework.Controls.MetroTextBox();
            this.AutoScrollMinSize = new MetroFramework.Controls.MetroTextBox();
            this.AutoIndentCharsPatterns = new MetroFramework.Controls.MetroTextBox();
            this.zoom = new MetroFramework.Controls.MetroTextBox();
            this.iReplaceMode = new MetroFramework.Controls.MetroComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.title.Location = new System.Drawing.Point(251, 0);
            this.title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(137, 31);
            this.title.TabIndex = 2;
            this.title.Text = "Text Editor";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.ServiceColors);
            this.panel1.Controls.Add(this.SelectionColor);
            this.panel1.Controls.Add(this.LineNumberColor);
            this.panel1.Controls.Add(this.IndentBackColor);
            this.panel1.Controls.Add(this.ForeColor);
            this.panel1.Controls.Add(this.DisabledColor);
            this.panel1.Controls.Add(this.CharWidth);
            this.panel1.Controls.Add(this.CharHeight);
            this.panel1.Controls.Add(this.BackColor);
            this.panel1.Controls.Add(this.AutoScrollMinSize);
            this.panel1.Controls.Add(this.AutoIndentCharsPatterns);
            this.panel1.Controls.Add(this.zoom);
            this.panel1.Controls.Add(this.iReplaceMode);
            this.panel1.Location = new System.Drawing.Point(0, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 461);
            this.panel1.TabIndex = 3;
            // 
            // ServiceColors
            // 
            // 
            // 
            // 
            this.ServiceColors.CustomButton.Image = null;
            this.ServiceColors.CustomButton.Location = new System.Drawing.Point(351, 1);
            this.ServiceColors.CustomButton.Name = "";
            this.ServiceColors.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ServiceColors.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ServiceColors.CustomButton.TabIndex = 1;
            this.ServiceColors.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ServiceColors.CustomButton.UseSelectable = true;
            this.ServiceColors.CustomButton.Visible = false;
            this.ServiceColors.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ServiceColors.Lines = new string[0];
            this.ServiceColors.Location = new System.Drawing.Point(15, 359);
            this.ServiceColors.MaxLength = 32767;
            this.ServiceColors.Name = "ServiceColors";
            this.ServiceColors.PasswordChar = '\0';
            //this.ServiceColors.PromptText = "ServiceColors";
            this.ServiceColors.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ServiceColors.SelectedText = "";
            this.ServiceColors.SelectionLength = 0;
            this.ServiceColors.SelectionStart = 0;
            this.ServiceColors.Size = new System.Drawing.Size(373, 23);
            this.ServiceColors.TabIndex = 12;
            this.ServiceColors.UseCustomBackColor = true;
            this.ServiceColors.UseCustomForeColor = true;
            this.ServiceColors.UseSelectable = true;
            this.ServiceColors.WaterMark = "ServiceColors";
            this.ServiceColors.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ServiceColors.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // SelectionColor
            // 
            // 
            // 
            // 
            this.SelectionColor.CustomButton.Image = null;
            this.SelectionColor.CustomButton.Location = new System.Drawing.Point(351, 1);
            this.SelectionColor.CustomButton.Name = "";
            this.SelectionColor.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.SelectionColor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SelectionColor.CustomButton.TabIndex = 1;
            this.SelectionColor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SelectionColor.CustomButton.UseSelectable = true;
            this.SelectionColor.CustomButton.Visible = false;
            this.SelectionColor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SelectionColor.Lines = new string[0];
            this.SelectionColor.Location = new System.Drawing.Point(15, 330);
            this.SelectionColor.MaxLength = 32767;
            this.SelectionColor.Name = "SelectionColor";
            this.SelectionColor.PasswordChar = '\0';
            //this.SelectionColor.PromptText = "SelectionColor";
            this.SelectionColor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SelectionColor.SelectedText = "";
            this.SelectionColor.SelectionLength = 0;
            this.SelectionColor.SelectionStart = 0;
            this.SelectionColor.Size = new System.Drawing.Size(373, 23);
            this.SelectionColor.TabIndex = 11;
            this.SelectionColor.UseCustomBackColor = true;
            this.SelectionColor.UseCustomForeColor = true;
            this.SelectionColor.UseSelectable = true;
            this.SelectionColor.WaterMark = "SelectionColor";
            this.SelectionColor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SelectionColor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // LineNumberColor
            // 
            // 
            // 
            // 
            this.LineNumberColor.CustomButton.Image = null;
            this.LineNumberColor.CustomButton.Location = new System.Drawing.Point(351, 1);
            this.LineNumberColor.CustomButton.Name = "";
            this.LineNumberColor.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.LineNumberColor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.LineNumberColor.CustomButton.TabIndex = 1;
            this.LineNumberColor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.LineNumberColor.CustomButton.UseSelectable = true;
            this.LineNumberColor.CustomButton.Visible = false;
            this.LineNumberColor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LineNumberColor.Lines = new string[0];
            this.LineNumberColor.Location = new System.Drawing.Point(15, 301);
            this.LineNumberColor.MaxLength = 32767;
            this.LineNumberColor.Name = "LineNumberColor";
            this.LineNumberColor.PasswordChar = '\0';
            //this.LineNumberColor.PromptText = "LineNumberColor";
            this.LineNumberColor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.LineNumberColor.SelectedText = "";
            this.LineNumberColor.SelectionLength = 0;
            this.LineNumberColor.SelectionStart = 0;
            this.LineNumberColor.Size = new System.Drawing.Size(373, 23);
            this.LineNumberColor.TabIndex = 10;
            this.LineNumberColor.UseCustomBackColor = true;
            this.LineNumberColor.UseCustomForeColor = true;
            this.LineNumberColor.UseSelectable = true;
            this.LineNumberColor.WaterMark = "LineNumberColor";
            this.LineNumberColor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.LineNumberColor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // IndentBackColor
            // 
            // 
            // 
            // 
            this.IndentBackColor.CustomButton.Image = null;
            this.IndentBackColor.CustomButton.Location = new System.Drawing.Point(351, 1);
            this.IndentBackColor.CustomButton.Name = "";
            this.IndentBackColor.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.IndentBackColor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.IndentBackColor.CustomButton.TabIndex = 1;
            this.IndentBackColor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.IndentBackColor.CustomButton.UseSelectable = true;
            this.IndentBackColor.CustomButton.Visible = false;
            this.IndentBackColor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.IndentBackColor.Lines = new string[0];
            this.IndentBackColor.Location = new System.Drawing.Point(15, 272);
            this.IndentBackColor.MaxLength = 32767;
            this.IndentBackColor.Name = "IndentBackColor";
            this.IndentBackColor.PasswordChar = '\0';
            //this.IndentBackColor.PromptText = "IndentBackColor";
            this.IndentBackColor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.IndentBackColor.SelectedText = "";
            this.IndentBackColor.SelectionLength = 0;
            this.IndentBackColor.SelectionStart = 0;
            this.IndentBackColor.Size = new System.Drawing.Size(373, 23);
            this.IndentBackColor.TabIndex = 9;
            this.IndentBackColor.UseCustomBackColor = true;
            this.IndentBackColor.UseCustomForeColor = true;
            this.IndentBackColor.UseSelectable = true;
            this.IndentBackColor.WaterMark = "IndentBackColor";
            this.IndentBackColor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.IndentBackColor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ForeColor
            // 
            // 
            // 
            // 
            this.ForeColor.CustomButton.Image = null;
            this.ForeColor.CustomButton.Location = new System.Drawing.Point(351, 1);
            this.ForeColor.CustomButton.Name = "";
            this.ForeColor.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ForeColor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ForeColor.CustomButton.TabIndex = 1;
            this.ForeColor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ForeColor.CustomButton.UseSelectable = true;
            this.ForeColor.CustomButton.Visible = false;
            this.ForeColor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ForeColor.Lines = new string[0];
            this.ForeColor.Location = new System.Drawing.Point(15, 243);
            this.ForeColor.MaxLength = 32767;
            this.ForeColor.Name = "ForeColor";
            this.ForeColor.PasswordChar = '\0';
            //this.ForeColor.PromptText = "ForeColor";
            this.ForeColor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ForeColor.SelectedText = "";
            this.ForeColor.SelectionLength = 0;
            this.ForeColor.SelectionStart = 0;
            this.ForeColor.Size = new System.Drawing.Size(373, 23);
            this.ForeColor.TabIndex = 8;
            this.ForeColor.UseCustomBackColor = true;
            this.ForeColor.UseCustomForeColor = true;
            this.ForeColor.UseSelectable = true;
            this.ForeColor.WaterMark = "ForeColor";
            this.ForeColor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ForeColor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // DisabledColor
            // 
            // 
            // 
            // 
            this.DisabledColor.CustomButton.Image = null;
            this.DisabledColor.CustomButton.Location = new System.Drawing.Point(351, 1);
            this.DisabledColor.CustomButton.Name = "";
            this.DisabledColor.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.DisabledColor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.DisabledColor.CustomButton.TabIndex = 1;
            this.DisabledColor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.DisabledColor.CustomButton.UseSelectable = true;
            this.DisabledColor.CustomButton.Visible = false;
            this.DisabledColor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DisabledColor.Lines = new string[0];
            this.DisabledColor.Location = new System.Drawing.Point(15, 214);
            this.DisabledColor.MaxLength = 32767;
            this.DisabledColor.Name = "DisabledColor";
            this.DisabledColor.PasswordChar = '\0';
            //this.DisabledColor.PromptText = "DisabledColor";
            this.DisabledColor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DisabledColor.SelectedText = "";
            this.DisabledColor.SelectionLength = 0;
            this.DisabledColor.SelectionStart = 0;
            this.DisabledColor.Size = new System.Drawing.Size(373, 23);
            this.DisabledColor.TabIndex = 7;
            this.DisabledColor.UseCustomBackColor = true;
            this.DisabledColor.UseCustomForeColor = true;
            this.DisabledColor.UseSelectable = true;
            this.DisabledColor.WaterMark = "DisabledColor";
            this.DisabledColor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DisabledColor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // CharWidth
            // 
            // 
            // 
            // 
            this.CharWidth.CustomButton.Image = null;
            this.CharWidth.CustomButton.Location = new System.Drawing.Point(351, 1);
            this.CharWidth.CustomButton.Name = "";
            this.CharWidth.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.CharWidth.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.CharWidth.CustomButton.TabIndex = 1;
            this.CharWidth.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CharWidth.CustomButton.UseSelectable = true;
            this.CharWidth.CustomButton.Visible = false;
            this.CharWidth.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CharWidth.Lines = new string[0];
            this.CharWidth.Location = new System.Drawing.Point(15, 185);
            this.CharWidth.MaxLength = 32767;
            this.CharWidth.Name = "CharWidth";
            this.CharWidth.PasswordChar = '\0';
            //this.CharWidth.PromptText = "CharWidth";
            this.CharWidth.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CharWidth.SelectedText = "";
            this.CharWidth.SelectionLength = 0;
            this.CharWidth.SelectionStart = 0;
            this.CharWidth.Size = new System.Drawing.Size(373, 23);
            this.CharWidth.TabIndex = 6;
            this.CharWidth.UseCustomBackColor = true;
            this.CharWidth.UseCustomForeColor = true;
            this.CharWidth.UseSelectable = true;
            this.CharWidth.WaterMark = "CharWidth";
            this.CharWidth.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CharWidth.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // CharHeight
            // 
            // 
            // 
            // 
            this.CharHeight.CustomButton.Image = null;
            this.CharHeight.CustomButton.Location = new System.Drawing.Point(351, 1);
            this.CharHeight.CustomButton.Name = "";
            this.CharHeight.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.CharHeight.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.CharHeight.CustomButton.TabIndex = 1;
            this.CharHeight.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CharHeight.CustomButton.UseSelectable = true;
            this.CharHeight.CustomButton.Visible = false;
            this.CharHeight.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CharHeight.Lines = new string[0];
            this.CharHeight.Location = new System.Drawing.Point(15, 156);
            this.CharHeight.MaxLength = 32767;
            this.CharHeight.Name = "CharHeight";
            this.CharHeight.PasswordChar = '\0';
            //this.CharHeight.PromptText = "CharHeight";
            this.CharHeight.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CharHeight.SelectedText = "";
            this.CharHeight.SelectionLength = 0;
            this.CharHeight.SelectionStart = 0;
            this.CharHeight.Size = new System.Drawing.Size(373, 23);
            this.CharHeight.TabIndex = 5;
            this.CharHeight.UseCustomBackColor = true;
            this.CharHeight.UseCustomForeColor = true;
            this.CharHeight.UseSelectable = true;
            this.CharHeight.WaterMark = "CharHeight";
            this.CharHeight.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CharHeight.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BackColor
            // 
            // 
            // 
            // 
            this.BackColor.CustomButton.Image = null;
            this.BackColor.CustomButton.Location = new System.Drawing.Point(351, 1);
            this.BackColor.CustomButton.Name = "";
            this.BackColor.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.BackColor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.BackColor.CustomButton.TabIndex = 1;
            this.BackColor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BackColor.CustomButton.UseSelectable = true;
            this.BackColor.CustomButton.Visible = false;
            this.BackColor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackColor.Lines = new string[0];
            this.BackColor.Location = new System.Drawing.Point(15, 127);
            this.BackColor.MaxLength = 32767;
            this.BackColor.Name = "BackColor";
            this.BackColor.PasswordChar = '\0';
            //this.BackColor.PromptText = "BackColor";
            this.BackColor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.BackColor.SelectedText = "";
            this.BackColor.SelectionLength = 0;
            this.BackColor.SelectionStart = 0;
            this.BackColor.Size = new System.Drawing.Size(373, 23);
            this.BackColor.TabIndex = 4;
            this.BackColor.UseCustomBackColor = true;
            this.BackColor.UseCustomForeColor = true;
            this.BackColor.UseSelectable = true;
            this.BackColor.WaterMark = "BackColor";
            this.BackColor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.BackColor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // AutoScrollMinSize
            // 
            // 
            // 
            // 
            this.AutoScrollMinSize.CustomButton.Image = null;
            this.AutoScrollMinSize.CustomButton.Location = new System.Drawing.Point(351, 1);
            this.AutoScrollMinSize.CustomButton.Name = "";
            this.AutoScrollMinSize.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.AutoScrollMinSize.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.AutoScrollMinSize.CustomButton.TabIndex = 1;
            this.AutoScrollMinSize.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.AutoScrollMinSize.CustomButton.UseSelectable = true;
            this.AutoScrollMinSize.CustomButton.Visible = false;
            this.AutoScrollMinSize.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AutoScrollMinSize.Lines = new string[0];
            this.AutoScrollMinSize.Location = new System.Drawing.Point(15, 98);
            this.AutoScrollMinSize.MaxLength = 32767;
            this.AutoScrollMinSize.Name = "AutoScrollMinSize";
            this.AutoScrollMinSize.PasswordChar = '\0';
            //this.AutoScrollMinSize.PromptText = "AutoScrollMinSize";
            this.AutoScrollMinSize.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.AutoScrollMinSize.SelectedText = "";
            this.AutoScrollMinSize.SelectionLength = 0;
            this.AutoScrollMinSize.SelectionStart = 0;
            this.AutoScrollMinSize.Size = new System.Drawing.Size(373, 23);
            this.AutoScrollMinSize.TabIndex = 3;
            this.AutoScrollMinSize.UseCustomBackColor = true;
            this.AutoScrollMinSize.UseCustomForeColor = true;
            this.AutoScrollMinSize.UseSelectable = true;
            this.AutoScrollMinSize.WaterMark = "AutoScrollMinSize";
            this.AutoScrollMinSize.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.AutoScrollMinSize.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // AutoIndentCharsPatterns
            // 
            // 
            // 
            // 
            this.AutoIndentCharsPatterns.CustomButton.Image = null;
            this.AutoIndentCharsPatterns.CustomButton.Location = new System.Drawing.Point(351, 1);
            this.AutoIndentCharsPatterns.CustomButton.Name = "";
            this.AutoIndentCharsPatterns.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.AutoIndentCharsPatterns.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.AutoIndentCharsPatterns.CustomButton.TabIndex = 1;
            this.AutoIndentCharsPatterns.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.AutoIndentCharsPatterns.CustomButton.UseSelectable = true;
            this.AutoIndentCharsPatterns.CustomButton.Visible = false;
            this.AutoIndentCharsPatterns.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AutoIndentCharsPatterns.Lines = new string[0];
            this.AutoIndentCharsPatterns.Location = new System.Drawing.Point(15, 69);
            this.AutoIndentCharsPatterns.MaxLength = 32767;
            this.AutoIndentCharsPatterns.Name = "AutoIndentCharsPatterns";
            this.AutoIndentCharsPatterns.PasswordChar = '\0';
            //this.AutoIndentCharsPatterns.PromptText = "AutoIndentCharsPatterns";
            this.AutoIndentCharsPatterns.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.AutoIndentCharsPatterns.SelectedText = "";
            this.AutoIndentCharsPatterns.SelectionLength = 0;
            this.AutoIndentCharsPatterns.SelectionStart = 0;
            this.AutoIndentCharsPatterns.Size = new System.Drawing.Size(373, 23);
            this.AutoIndentCharsPatterns.TabIndex = 2;
            this.AutoIndentCharsPatterns.UseCustomBackColor = true;
            this.AutoIndentCharsPatterns.UseCustomForeColor = true;
            this.AutoIndentCharsPatterns.UseSelectable = true;
            this.AutoIndentCharsPatterns.WaterMark = "AutoIndentCharsPatterns";
            this.AutoIndentCharsPatterns.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.AutoIndentCharsPatterns.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // zoom
            // 
            // 
            // 
            // 
            this.zoom.CustomButton.Image = null;
            this.zoom.CustomButton.Location = new System.Drawing.Point(351, 1);
            this.zoom.CustomButton.Name = "";
            this.zoom.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.zoom.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.zoom.CustomButton.TabIndex = 1;
            this.zoom.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.zoom.CustomButton.UseSelectable = true;
            this.zoom.CustomButton.Visible = false;
            this.zoom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.zoom.Lines = new string[0];
            this.zoom.Location = new System.Drawing.Point(15, 40);
            this.zoom.MaxLength = 32767;
            this.zoom.Name = "zoom";
            this.zoom.PasswordChar = '\0';
           //this.zoom.PromptText = "Zoom";
            this.zoom.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.zoom.SelectedText = "";
            this.zoom.SelectionLength = 0;
            this.zoom.SelectionStart = 0;
            this.zoom.Size = new System.Drawing.Size(373, 23);
            this.zoom.TabIndex = 1;
            this.zoom.UseCustomBackColor = true;
            this.zoom.UseCustomForeColor = true;
            this.zoom.UseSelectable = true;
            this.zoom.WaterMark = "Zoom";
            this.zoom.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.zoom.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // iReplaceMode
            // 
            this.iReplaceMode.FormattingEnabled = true;
            this.iReplaceMode.ItemHeight = 23;
            this.iReplaceMode.Items.AddRange(new object[] {
            "False",
            "True"});
            this.iReplaceMode.Location = new System.Drawing.Point(15, 4);
            this.iReplaceMode.Name = "iReplaceMode";
            this.iReplaceMode.PromptText = "iReplaceMode";
            this.iReplaceMode.Size = new System.Drawing.Size(373, 29);
            this.iReplaceMode.TabIndex = 0;
            this.iReplaceMode.UseCustomBackColor = true;
            this.iReplaceMode.UseCustomForeColor = true;
            this.iReplaceMode.UseSelectable = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(0)))), ((int)(((byte)(123)))));
            this.panel2.Controls.Add(this.title);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(685, 42);
            this.panel2.TabIndex = 4;
            // 
            // TextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TextEditor";
            this.Size = new System.Drawing.Size(685, 495);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroComboBox iReplaceMode;
        private MetroFramework.Controls.MetroTextBox zoom;
        private MetroFramework.Controls.MetroTextBox AutoIndentCharsPatterns;
        private MetroFramework.Controls.MetroTextBox AutoScrollMinSize;
        private MetroFramework.Controls.MetroTextBox CharWidth;
        private MetroFramework.Controls.MetroTextBox CharHeight;
        private MetroFramework.Controls.MetroTextBox BackColor;
        private MetroFramework.Controls.MetroTextBox DisabledColor;
        private MetroFramework.Controls.MetroTextBox ForeColor;
        private MetroFramework.Controls.MetroTextBox IndentBackColor;
        private MetroFramework.Controls.MetroTextBox LineNumberColor;
        private MetroFramework.Controls.MetroTextBox ServiceColors;
        private MetroFramework.Controls.MetroTextBox SelectionColor;
        private System.Windows.Forms.Panel panel2;
    }
}
