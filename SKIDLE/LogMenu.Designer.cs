
namespace SKIDLE
{
    partial class LogMenu
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
            this.log = new System.Windows.Forms.TextBox();
            this.Ok = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.delete = new MetroFramework.Controls.MetroButton();
            this.close = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // log
            // 
            this.log.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.log.Location = new System.Drawing.Point(0, 0);
            this.log.Multiline = true;
            this.log.Name = "log";
            this.log.ReadOnly = true;
            this.log.Size = new System.Drawing.Size(545, 399);
            this.log.TabIndex = 0;
            // 
            // Ok
            // 
            this.Ok.Dock = System.Windows.Forms.DockStyle.Right;
            this.Ok.Location = new System.Drawing.Point(470, 0);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(75, 26);
            this.Ok.TabIndex = 1;
            this.Ok.Text = "Ok";
            this.Ok.UseCustomBackColor = true;
            this.Ok.UseCustomForeColor = true;
            this.Ok.UseSelectable = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.delete);
            this.metroPanel1.Controls.Add(this.close);
            this.metroPanel1.Controls.Add(this.Ok);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 399);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(545, 26);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.UseCustomForeColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // delete
            // 
            this.delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.delete.Location = new System.Drawing.Point(320, 0);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 26);
            this.delete.TabIndex = 2;
            this.delete.Text = "Delete";
            this.delete.UseCustomBackColor = true;
            this.delete.UseCustomForeColor = true;
            this.delete.UseSelectable = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // close
            // 
            this.close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.close.Dock = System.Windows.Forms.DockStyle.Right;
            this.close.Location = new System.Drawing.Point(395, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 26);
            this.close.TabIndex = 3;
            this.close.Text = "Close";
            this.close.UseCustomBackColor = true;
            this.close.UseCustomForeColor = true;
            this.close.UseSelectable = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // LogMenu
            // 
            this.AcceptButton = this.Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.close;
            this.ClientSize = new System.Drawing.Size(545, 425);
            this.Controls.Add(this.log);
            this.Controls.Add(this.metroPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LogMenu";
            this.Text = "LogMenu";
            this.Load += new System.EventHandler(this.LogMenu_Load);
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox log;
        private MetroFramework.Controls.MetroButton Ok;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton delete;
        private MetroFramework.Controls.MetroButton close;
    }
}