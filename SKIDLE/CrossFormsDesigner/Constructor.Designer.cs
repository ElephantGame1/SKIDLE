
namespace SKIDLE.CrossFormsDesigner
{
    partial class Constructor
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.demo1 = new SKIDLE.CrossFormsDesigner.Demo();
            this.all = new System.Windows.Forms.Panel();
            this.LabelProp = new System.Windows.Forms.Panel();
            this.Type = new System.Windows.Forms.Label();
            this.OnClickProp = new MetroFramework.Controls.MetroTextBox();
            this.LabelID = new MetroFramework.Controls.MetroTextBox();
            this.LabelPosY = new MetroFramework.Controls.MetroTextBox();
            this.LabelPosX = new MetroFramework.Controls.MetroTextBox();
            this.LabelHeight = new MetroFramework.Controls.MetroTextBox();
            this.LabelWidht = new MetroFramework.Controls.MetroTextBox();
            this.TextLabel = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ControlsBox = new System.Windows.Forms.ComboBox();
            this.properties = new System.Windows.Forms.Label();
            this.elements = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.all.SuspendLayout();
            this.LabelProp.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.elements);
            this.splitContainer1.Size = new System.Drawing.Size(1111, 691);
            this.splitContainer1.SplitterDistance = 961;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.splitContainer2.Panel1.Controls.Add(this.demo1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.all);
            this.splitContainer2.Panel2.Controls.Add(this.ControlsBox);
            this.splitContainer2.Panel2.Controls.Add(this.properties);
            this.splitContainer2.Panel2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.splitContainer2.Panel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.splitContainer2.Size = new System.Drawing.Size(961, 691);
            this.splitContainer2.SplitterDistance = 751;
            this.splitContainer2.TabIndex = 0;
            // 
            // demo1
            // 
            this.demo1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.demo1.Location = new System.Drawing.Point(3, 3);
            this.demo1.Name = "demo1";
            this.demo1.Padding = new System.Windows.Forms.Padding(3);
            this.demo1.Size = new System.Drawing.Size(560, 517);
            this.demo1.TabIndex = 0;
            // 
            // all
            // 
            this.all.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.all.Controls.Add(this.LabelProp);
            this.all.Dock = System.Windows.Forms.DockStyle.Fill;
            this.all.Location = new System.Drawing.Point(0, 48);
            this.all.Name = "all";
            this.all.Size = new System.Drawing.Size(206, 643);
            this.all.TabIndex = 5;
            // 
            // LabelProp
            // 
            this.LabelProp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.LabelProp.Controls.Add(this.Type);
            this.LabelProp.Controls.Add(this.OnClickProp);
            this.LabelProp.Controls.Add(this.LabelID);
            this.LabelProp.Controls.Add(this.LabelPosY);
            this.LabelProp.Controls.Add(this.LabelPosX);
            this.LabelProp.Controls.Add(this.LabelHeight);
            this.LabelProp.Controls.Add(this.LabelWidht);
            this.LabelProp.Controls.Add(this.TextLabel);
            this.LabelProp.Controls.Add(this.label2);
            this.LabelProp.Location = new System.Drawing.Point(6, 6);
            this.LabelProp.Name = "LabelProp";
            this.LabelProp.Size = new System.Drawing.Size(198, 492);
            this.LabelProp.TabIndex = 2;
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Type.Location = new System.Drawing.Point(0, 473);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(38, 19);
            this.Type.TabIndex = 16;
            this.Type.Text = "Type";
            // 
            // OnClickProp
            // 
            // 
            // 
            // 
            this.OnClickProp.CustomButton.Image = null;
            this.OnClickProp.CustomButton.Location = new System.Drawing.Point(176, 1);
            this.OnClickProp.CustomButton.Name = "";
            this.OnClickProp.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.OnClickProp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.OnClickProp.CustomButton.TabIndex = 1;
            this.OnClickProp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.OnClickProp.CustomButton.UseSelectable = true;
            this.OnClickProp.CustomButton.Visible = false;
            this.OnClickProp.Dock = System.Windows.Forms.DockStyle.Top;
            this.OnClickProp.Lines = new string[0];
            this.OnClickProp.Location = new System.Drawing.Point(0, 157);
            this.OnClickProp.MaxLength = 32767;
            this.OnClickProp.Name = "OnClickProp";
            this.OnClickProp.PasswordChar = '\0';
            //this.OnClickProp.PromptText = "OnClick";
            this.OnClickProp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.OnClickProp.SelectedText = "";
            this.OnClickProp.SelectionLength = 0;
            this.OnClickProp.SelectionStart = 0;
            //this.OnClickProp.ShortcutsEnabled = true;
            this.OnClickProp.Size = new System.Drawing.Size(198, 23);
            this.OnClickProp.TabIndex = 15;
            this.OnClickProp.UseCustomBackColor = true;
            this.OnClickProp.UseCustomForeColor = true;
            this.OnClickProp.UseSelectable = true;
            this.OnClickProp.WaterMark = "OnClick";
            this.OnClickProp.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.OnClickProp.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.OnClickProp.TextChanged += new System.EventHandler(this.OnClickProp_TextChanged);
            // 
            // LabelID
            // 
            // 
            // 
            // 
            this.LabelID.CustomButton.Image = null;
            this.LabelID.CustomButton.Location = new System.Drawing.Point(176, 1);
            this.LabelID.CustomButton.Name = "";
            this.LabelID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.LabelID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.LabelID.CustomButton.TabIndex = 1;
            this.LabelID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.LabelID.CustomButton.UseSelectable = true;
            this.LabelID.CustomButton.Visible = false;
            this.LabelID.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelID.Lines = new string[0];
            this.LabelID.Location = new System.Drawing.Point(0, 134);
            this.LabelID.MaxLength = 32767;
            this.LabelID.Name = "LabelID";
            this.LabelID.PasswordChar = '\0';
            //this.LabelID.PromptText = "Id";
            this.LabelID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.LabelID.SelectedText = "";
            this.LabelID.SelectionLength = 0;
            this.LabelID.SelectionStart = 0;
            //this.LabelID.ShortcutsEnabled = true;
            this.LabelID.Size = new System.Drawing.Size(198, 23);
            this.LabelID.TabIndex = 14;
            this.LabelID.UseCustomBackColor = true;
            this.LabelID.UseCustomForeColor = true;
            this.LabelID.UseSelectable = true;
            this.LabelID.WaterMark = "Id";
            this.LabelID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.LabelID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.LabelID.TextChanged += new System.EventHandler(this.LabelID_TextChanged);
            // 
            // LabelPosY
            // 
            // 
            // 
            // 
            this.LabelPosY.CustomButton.Image = null;
            this.LabelPosY.CustomButton.Location = new System.Drawing.Point(176, 1);
            this.LabelPosY.CustomButton.Name = "";
            this.LabelPosY.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.LabelPosY.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.LabelPosY.CustomButton.TabIndex = 1;
            this.LabelPosY.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.LabelPosY.CustomButton.UseSelectable = true;
            this.LabelPosY.CustomButton.Visible = false;
            this.LabelPosY.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelPosY.Lines = new string[0];
            this.LabelPosY.Location = new System.Drawing.Point(0, 111);
            this.LabelPosY.MaxLength = 32767;
            this.LabelPosY.Name = "LabelPosY";
            this.LabelPosY.PasswordChar = '\0';
            //this.LabelPosY.PromptText = "Position Y";
            this.LabelPosY.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.LabelPosY.SelectedText = "";
            this.LabelPosY.SelectionLength = 0;
            this.LabelPosY.SelectionStart = 0;
            this.LabelPosY.Size = new System.Drawing.Size(198, 23);
            this.LabelPosY.TabIndex = 13;
            this.LabelPosY.UseCustomBackColor = true;
            this.LabelPosY.UseCustomForeColor = true;
            this.LabelPosY.UseSelectable = true;
            this.LabelPosY.WaterMark = "Position Y";
            this.LabelPosY.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.LabelPosY.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.LabelPosY.TextChanged += new System.EventHandler(this.LabelPosY_TextChanged);
            // 
            // LabelPosX
            // 
            // 
            // 
            // 
            this.LabelPosX.CustomButton.Image = null;
            this.LabelPosX.CustomButton.Location = new System.Drawing.Point(176, 1);
            this.LabelPosX.CustomButton.Name = "";
            this.LabelPosX.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.LabelPosX.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.LabelPosX.CustomButton.TabIndex = 1;
            this.LabelPosX.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.LabelPosX.CustomButton.UseSelectable = true;
            this.LabelPosX.CustomButton.Visible = false;
            this.LabelPosX.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelPosX.Lines = new string[0];
            this.LabelPosX.Location = new System.Drawing.Point(0, 88);
            this.LabelPosX.MaxLength = 32767;
            this.LabelPosX.Name = "LabelPosX";
            this.LabelPosX.PasswordChar = '\0';
            //this.LabelPosX.PromptText = "Position X";
            this.LabelPosX.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.LabelPosX.SelectedText = "";
            this.LabelPosX.SelectionLength = 0;
            this.LabelPosX.SelectionStart = 0;
            this.LabelPosX.Size = new System.Drawing.Size(198, 23);
            this.LabelPosX.TabIndex = 12;
            this.LabelPosX.UseCustomBackColor = true;
            this.LabelPosX.UseCustomForeColor = true;
            this.LabelPosX.UseSelectable = true;
            this.LabelPosX.WaterMark = "Position X";
            this.LabelPosX.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.LabelPosX.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.LabelPosX.TextChanged += new System.EventHandler(this.LabelPosX_TextChanged);
            // 
            // LabelHeight
            // 
            // 
            // 
            // 
            this.LabelHeight.CustomButton.Image = null;
            this.LabelHeight.CustomButton.Location = new System.Drawing.Point(176, 1);
            this.LabelHeight.CustomButton.Name = "";
            this.LabelHeight.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.LabelHeight.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.LabelHeight.CustomButton.TabIndex = 1;
            this.LabelHeight.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.LabelHeight.CustomButton.UseSelectable = true;
            this.LabelHeight.CustomButton.Visible = false;
            this.LabelHeight.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelHeight.Lines = new string[0];
            this.LabelHeight.Location = new System.Drawing.Point(0, 65);
            this.LabelHeight.MaxLength = 32767;
            this.LabelHeight.Name = "LabelHeight";
            this.LabelHeight.PasswordChar = '\0';
            //this.LabelHeight.PromptText = "Height";
            this.LabelHeight.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.LabelHeight.SelectedText = "";
            this.LabelHeight.SelectionLength = 0;
            this.LabelHeight.SelectionStart = 0;
            this.LabelHeight.Size = new System.Drawing.Size(198, 23);
            this.LabelHeight.TabIndex = 11;
            this.LabelHeight.UseCustomBackColor = true;
            this.LabelHeight.UseCustomForeColor = true;
            this.LabelHeight.UseSelectable = true;
            this.LabelHeight.WaterMark = "Height";
            this.LabelHeight.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.LabelHeight.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.LabelHeight.TextChanged += new System.EventHandler(this.LabelHeight_TextChanged);
            // 
            // LabelWidht
            // 
            // 
            // 
            // 
            this.LabelWidht.CustomButton.Image = null;
            this.LabelWidht.CustomButton.Location = new System.Drawing.Point(176, 1);
            this.LabelWidht.CustomButton.Name = "";
            this.LabelWidht.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.LabelWidht.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.LabelWidht.CustomButton.TabIndex = 1;
            this.LabelWidht.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.LabelWidht.CustomButton.UseSelectable = true;
            this.LabelWidht.CustomButton.Visible = false;
            this.LabelWidht.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelWidht.Lines = new string[0];
            this.LabelWidht.Location = new System.Drawing.Point(0, 42);
            this.LabelWidht.MaxLength = 32767;
            this.LabelWidht.Name = "LabelWidht";
            this.LabelWidht.PasswordChar = '\0';
            //this.LabelWidht.PromptText = "Width";
            this.LabelWidht.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.LabelWidht.SelectedText = "";
            this.LabelWidht.SelectionLength = 0;
            this.LabelWidht.SelectionStart = 0;
            this.LabelWidht.Size = new System.Drawing.Size(198, 23);
            this.LabelWidht.TabIndex = 10;
            this.LabelWidht.UseCustomBackColor = true;
            this.LabelWidht.UseCustomForeColor = true;
            this.LabelWidht.UseSelectable = true;
            this.LabelWidht.WaterMark = "Width";
            this.LabelWidht.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.LabelWidht.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.LabelWidht.TextChanged += new System.EventHandler(this.LabelWidht_TextChanged);
            // 
            // TextLabel
            // 
            // 
            // 
            // 
            this.TextLabel.CustomButton.Image = null;
            this.TextLabel.CustomButton.Location = new System.Drawing.Point(176, 1);
            this.TextLabel.CustomButton.Name = "";
            this.TextLabel.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextLabel.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextLabel.CustomButton.TabIndex = 1;
            this.TextLabel.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextLabel.CustomButton.UseSelectable = true;
            this.TextLabel.CustomButton.Visible = false;
            this.TextLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TextLabel.Lines = new string[0];
            this.TextLabel.Location = new System.Drawing.Point(0, 19);
            this.TextLabel.MaxLength = 32767;
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.PasswordChar = '\0';
            //this.TextLabel.PromptText = "Text";
            this.TextLabel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextLabel.SelectedText = "";
            this.TextLabel.SelectionLength = 0;
            this.TextLabel.SelectionStart = 0;
            this.TextLabel.Size = new System.Drawing.Size(198, 23);
            this.TextLabel.TabIndex = 9;
            this.TextLabel.UseCustomBackColor = true;
            this.TextLabel.UseCustomForeColor = true;
            this.TextLabel.UseSelectable = true;
            this.TextLabel.WaterMark = "Text";
            this.TextLabel.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextLabel.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TextLabel.TextChanged += new System.EventHandler(this.TextLabel_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Control";
            // 
            // ControlsBox
            // 
            this.ControlsBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ControlsBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.ControlsBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ControlsBox.ForeColor = System.Drawing.SystemColors.Menu;
            this.ControlsBox.FormattingEnabled = true;
            this.ControlsBox.Location = new System.Drawing.Point(0, 21);
            this.ControlsBox.Name = "ControlsBox";
            this.ControlsBox.Size = new System.Drawing.Size(206, 27);
            this.ControlsBox.TabIndex = 6;
            this.ControlsBox.DropDown += new System.EventHandler(this.ControlsBox_DropDown);
            this.ControlsBox.SelectedValueChanged += new System.EventHandler(this.ControlsBox_SelectedValueChanged);
            // 
            // properties
            // 
            this.properties.AutoSize = true;
            this.properties.Dock = System.Windows.Forms.DockStyle.Top;
            this.properties.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.properties.Location = new System.Drawing.Point(0, 0);
            this.properties.Name = "properties";
            this.properties.Size = new System.Drawing.Size(83, 21);
            this.properties.TabIndex = 0;
            this.properties.Text = "Свойства";
            // 
            // elements
            // 
            this.elements.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.elements.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.elements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elements.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.elements.ForeColor = System.Drawing.SystemColors.Info;
            this.elements.FormattingEnabled = true;
            this.elements.ImeMode = System.Windows.Forms.ImeMode.On;
            this.elements.ItemHeight = 20;
            this.elements.Items.AddRange(new object[] {
            "Button",
            "ComboBox",
            "Label"});
            this.elements.Location = new System.Drawing.Point(0, 0);
            this.elements.Name = "elements";
            this.elements.Size = new System.Drawing.Size(146, 691);
            this.elements.Sorted = true;
            this.elements.TabIndex = 0;
            this.elements.SelectedValueChanged += new System.EventHandler(this.elements_SelectedValueChanged);
            // 
            // Constructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Controls.Add(this.splitContainer1);
            this.Name = "Constructor";
            this.Size = new System.Drawing.Size(1111, 691);
            this.Load += new System.EventHandler(this.Constructor_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.all.ResumeLayout(false);
            this.LabelProp.ResumeLayout(false);
            this.LabelProp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListBox elements;
        public Demo demo1;
        private System.Windows.Forms.Panel LabelProp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label properties;
        private MetroFramework.Controls.MetroTextBox LabelHeight;
        private MetroFramework.Controls.MetroTextBox LabelWidht;
        private MetroFramework.Controls.MetroTextBox TextLabel;
        private MetroFramework.Controls.MetroTextBox LabelID;
        private MetroFramework.Controls.MetroTextBox LabelPosY;
        private MetroFramework.Controls.MetroTextBox LabelPosX;
        private System.Windows.Forms.ComboBox ControlsBox;
        private System.Windows.Forms.Panel all;
        private MetroFramework.Controls.MetroTextBox OnClickProp;
        private System.Windows.Forms.Label Type;
    }
}
