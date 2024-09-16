
namespace SKIDLE
{
    partial class CreateForm
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
            this.path = new MetroFramework.Controls.MetroTextBox();
            this.Accept = new MetroFramework.Controls.MetroButton();
            this.Cancel = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // path
            // 
            this.path.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.path.CustomButton.Image = null;
            this.path.CustomButton.Location = new System.Drawing.Point(270, 2);
            this.path.CustomButton.Name = "";
            this.path.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.path.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.path.CustomButton.TabIndex = 1;
            this.path.CustomButton.Text = "Ok";
            this.path.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.path.CustomButton.UseSelectable = true;
            this.path.CustomButton.Visible = false;
            this.path.Lines = new string[0];
            this.path.Location = new System.Drawing.Point(1, 0);
            this.path.MaxLength = 32767;
            this.path.Name = "path";
            this.path.PasswordChar = '\0';
            //this.path.PromptText = "Create File/Directory";
            this.path.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.path.SelectedText = "";
            this.path.SelectionLength = 0;
            this.path.SelectionStart = 0;
            this.path.Size = new System.Drawing.Size(292, 24);
            this.path.TabIndex = 0;
            this.path.UseSelectable = true;
            this.path.WaterMark = "Create File/Directory";
            this.path.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.path.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Accept
            // 
            this.Accept.Highlight = true;
            this.Accept.Location = new System.Drawing.Point(348, 0);
            this.Accept.Name = "Accept";
            this.Accept.Size = new System.Drawing.Size(24, 24);
            this.Accept.Style = MetroFramework.MetroColorStyle.Blue;
            this.Accept.TabIndex = 1;
            this.Accept.Text = "Ok";
            this.Accept.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Accept.UseSelectable = true;
            this.Accept.Click += new System.EventHandler(this.Accept_Click);
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Highlight = true;
            this.Cancel.Location = new System.Drawing.Point(294, 0);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(53, 24);
            this.Cancel.Style = MetroFramework.MetroColorStyle.Blue;
            this.Cancel.TabIndex = 2;
            this.Cancel.Text = "Cancel";
            this.Cancel.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Cancel.UseSelectable = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // CreateForm
            // 
            this.AcceptButton = this.Accept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(373, 24);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Accept);
            this.Controls.Add(this.path);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create";
            this.Load += new System.EventHandler(this.CreateForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton Accept;
        private MetroFramework.Controls.MetroButton Cancel;
        public MetroFramework.Controls.MetroTextBox path;
    }
}