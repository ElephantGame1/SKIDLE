
namespace SKIDLE.UserControls
{
    partial class ExtensionExp
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
            this.icon = new System.Windows.Forms.PictureBox();
            this.author = new System.Windows.Forms.Label();
            this.version = new System.Windows.Forms.Label();
            this.extDesc = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.title.Location = new System.Drawing.Point(4, 4);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(0, 28);
            this.title.TabIndex = 0;
            // 
            // icon
            // 
            this.icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.icon.Location = new System.Drawing.Point(9, 36);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(100, 100);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon.TabIndex = 1;
            this.icon.TabStop = false;
            // 
            // author
            // 
            this.author.AutoSize = true;
            this.author.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.author.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.author.Location = new System.Drawing.Point(115, 36);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(0, 21);
            this.author.TabIndex = 2;
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.version.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.version.Location = new System.Drawing.Point(115, 64);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(0, 21);
            this.version.TabIndex = 3;
            // 
            // extDesc
            // 
            this.extDesc.AutoSize = true;
            this.extDesc.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.extDesc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.extDesc.Location = new System.Drawing.Point(115, 92);
            this.extDesc.Name = "extDesc";
            this.extDesc.Size = new System.Drawing.Size(0, 21);
            this.extDesc.TabIndex = 4;
            // 
            // description
            // 
            this.description.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.description.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.description.ForeColor = System.Drawing.SystemColors.Window;
            this.description.Location = new System.Drawing.Point(0, 143);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(1005, 370);
            this.description.TabIndex = 5;
            this.description.Text = "";
            // 
            // ExtensionExp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.description);
            this.Controls.Add(this.extDesc);
            this.Controls.Add(this.version);
            this.Controls.Add(this.author);
            this.Controls.Add(this.icon);
            this.Controls.Add(this.title);
            this.Name = "ExtensionExp";
            this.Size = new System.Drawing.Size(1005, 516);
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label title;
        public System.Windows.Forms.PictureBox icon;
        public System.Windows.Forms.Label author;
        public System.Windows.Forms.Label version;
        public System.Windows.Forms.Label extDesc;
        public System.Windows.Forms.RichTextBox description;
    }
}
