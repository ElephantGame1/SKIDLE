
namespace SKIDLE.UserControls
{
    partial class ConsoleTab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsoleTab));
            this.console = new SKIDLE.UserControls.Console();
            ((System.ComponentModel.ISupportInitialize)(this.console)).BeginInit();
            this.SuspendLayout();
            // 
            // console
            // 
            this.console.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.console.AutoIndentCharsPatterns = "^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\r\n^\\s*(case|default)\\s*[^:]*" +
    "(?<range>:)\\s*(?<range>[^;]+);";
            this.console.AutoScrollMinSize = new System.Drawing.Size(2, 14);
            this.console.BackBrush = null;
            this.console.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.console.CharHeight = 14;
            this.console.CharWidth = 8;
            this.console.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.console.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.console.Dock = System.Windows.Forms.DockStyle.Fill;
            this.console.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.console.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.console.IsReadLineMode = false;
            this.console.IsReplaceMode = false;
            this.console.LineNumberColor = System.Drawing.Color.Azure;
            this.console.Location = new System.Drawing.Point(0, 0);
            this.console.Name = "console";
            this.console.Paddings = new System.Windows.Forms.Padding(0);
            this.console.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.console.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("console.ServiceColors")));
            this.console.ServiceLinesColor = System.Drawing.Color.Black;
            this.console.ShowLineNumbers = false;
            this.console.Size = new System.Drawing.Size(483, 319);
            this.console.TabIndex = 1;
            this.console.Zoom = 100;
            // 
            // ConsoleTab
            // 
            this.Controls.Add(this.console);
            this.Name = "ConsoleTab";
            this.Size = new System.Drawing.Size(483, 319);
            ((System.ComponentModel.ISupportInitialize)(this.console)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Console console;
    }
}
