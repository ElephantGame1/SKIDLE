using FastColoredTextBoxNS;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace SKIDLE.UserControls
{
    public class codeTab : Manina.Windows.Forms.Tab
    {
        Style invisibleCharsStyle = new InvisibleCharsRenderer(Pens.Gray);

        MenuStrip topMenuStrip;
        MenuStrip bottomMenuStrip;
        ToolStripLabel stripLabel;
        ToolStripLabel stripLabel1;

        HighLighting highLighting = new HighLighting();
        public FastCTBox code;
        public AutoForce ACmenu;
        public ContextMenuStrip cms;
        public int linesForDocMap = 150;
        FastColoredTextBoxNS.DocumentMap documentMap;
        private System.ComponentModel.IContainer components;
        private ContextMenuStrip contextMenu;
        private ToolStripMenuItem cut;
        private ToolStripMenuItem copy;
        private ToolStripMenuItem paste;
        private ToolStripMenuItem find;
        private ToolStripMenuItem Igoto;
        private ToolStripMenuItem replace;
        private ToolStripMenuItem comment;
        SplitContainer split;
        private ToolStripItem bookmark;
        private ToolStripItem delbookmark;

        public codeTab()
        {
            InitializeComponent();
            iEvents();
        }

        private void iEvents()
        {
            cut.Click += Cut_Click;
            copy.Click += Copy_Click;
            paste.Click += Paste_Click;
            find.Click += Find_Click;
            Igoto.Click += Igoto_Click;
            replace.Click += Replace_Click;
            comment.Click += Comment_Click;
            bookmark.Click += Bookmark_Click;
            delbookmark.Click += Delbookmark_Click;
            code.KeyUp += Code_KeyUp;
            code.KeyDown += Code_KeyDown;
            code.MouseClick += Code_MouseClick;
        }

        private void Delbookmark_Click(object sender, EventArgs e)
        {
            code.UnbookmarkLine(code.Selection.ToLine);
        }

        private void Bookmark_Click(object sender, EventArgs e)
        {
            code.BookmarkColor = Color.Red;
            code.BookmarkLine(code.Selection.ToLine);    
        }

        private void Comment_Click(object sender, EventArgs e)
        {
            code.CommentSelected("#");
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(codeTab));
            this.code = new SKIDLE.UserControls.FastCTBox();
            this.contextMenu = new ContextMenuStrip();
            this.ACmenu = new AutoForce(code);
            this.cut = new System.Windows.Forms.ToolStripMenuItem();
            this.copy = new System.Windows.Forms.ToolStripMenuItem();
            this.paste = new System.Windows.Forms.ToolStripMenuItem();
            this.find = new System.Windows.Forms.ToolStripMenuItem();
            this.Igoto = new System.Windows.Forms.ToolStripMenuItem();
            this.replace = new System.Windows.Forms.ToolStripMenuItem();
            bookmark = new ToolStripMenuItem();
            delbookmark = new ToolStripMenuItem();
            this.topMenuStrip = new System.Windows.Forms.MenuStrip();
            this.stripLabel = new System.Windows.Forms.ToolStripLabel();
            this.bottomMenuStrip = new System.Windows.Forms.MenuStrip();
            this.stripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.documentMap = new FastColoredTextBoxNS.DocumentMap();
            this.split = new System.Windows.Forms.SplitContainer();
            this.comment = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.code)).BeginInit();
            this.contextMenu.SuspendLayout();
            this.topMenuStrip.SuspendLayout();
            this.bottomMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.split)).BeginInit();
            this.split.Panel1.SuspendLayout();
            this.split.Panel2.SuspendLayout();
            this.split.SuspendLayout();
            this.SuspendLayout();
            // 
            // code
            // 
            this.code.AutoCompleteBrackets = true;
            this.code.AutoCompleteBracketsList = new char[] {
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
            this.ACmenu.SetAutocompleteMenu(this.code, this.ACmenu);
            this.code.AutoIndentCharsPatterns = "^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\r\n^\\s*(case|default)\\s*[^:]*" +
    "(?<range>:)\\s*(?<range>[^;]+);";
            this.code.AutoScrollMinSize = new System.Drawing.Size(2, 14);
            this.code.BackBrush = null;
            this.code.BackColor = Color.WhiteSmoke;
            this.code.CharHeight = 14;
            this.code.CharWidth = 8;
            this.code.ContextMenuStrip = this.contextMenu;
            this.code.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.code.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.code.Dock = System.Windows.Forms.DockStyle.Fill;
            this.code.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.code.ForeColor = System.Drawing.Color.Black;
            this.code.IndentBackColor = Color.Azure;
            this.code.IsReplaceMode = false;
            this.code.LineNumberColor = System.Drawing.Color.Black;
            this.code.Location = new System.Drawing.Point(0, 24);
            this.code.Name = "code";
            this.code.Paddings = new System.Windows.Forms.Padding(0);
            this.code.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.code.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("code.ServiceColors")));
            this.code.Size = new System.Drawing.Size(25, 0);
            this.code.TabIndex = 0;
            this.code.Zoom = 100;
            this.code.TextChanging += new System.EventHandler<FastColoredTextBoxNS.TextChangingEventArgs>(this.Code_TextChanging);
            this.code.Load += new System.EventHandler(this.Code_Load);
            this.code.TextChangedDelayed += Code_TextChangedDelayed;
            this.code.SelectionColor = Color.Aqua;
            
            // 
            // contextMenu
            // 
            contextMenu.Width = 20;
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cut,
            this.copy,
            this.paste,
            this.comment,
            this.bookmark,
            this.delbookmark});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(127, 158);
            // 
            // cut
            // 
            this.cut.Name = "cut";
            this.cut.Size = new System.Drawing.Size(126, 22);
            this.cut.Text = "Cut";
            // 
            // copy
            // 
            this.copy.Name = "copy";
            this.copy.Size = new System.Drawing.Size(126, 22);
            this.copy.Text = "Copy";
            // 
            // paste
            // 
            this.paste.Name = "paste";
            this.paste.Size = new System.Drawing.Size(126, 22);
            this.paste.Text = "Paste";
            // 
            // find
            // 
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(126, 22);
            this.find.Text = "Find";
            // 
            // Igoto
            // 
            this.Igoto.Name = "Igoto";
            this.Igoto.Size = new System.Drawing.Size(126, 22);
            this.Igoto.Text = "GoTo";
            // 
            // replace
            // 
            this.replace.Name = "replace";
            this.replace.Size = new System.Drawing.Size(126, 22);
            this.replace.Text = "Replace";
            // 
            // bookmark
            // 
            this.bookmark.Name = "bookmark";
            this.bookmark.Size = new System.Drawing.Size(126, 22);
            this.bookmark.Text = "Bookmark";
            // 
            // delbookmark
            // 
            this.delbookmark.Name = "delbookmark";
            this.delbookmark.Size = new System.Drawing.Size(126, 22);
            this.delbookmark.Text = "Unbookmark";
            // 
            // ACmenu
            // 
            this.ACmenu.AllowsTabKey = true;
            this.ACmenu.Colors = ((AutocompleteMenuNS.Colors)(resources.GetObject("ACmenu.Colors")));
            this.ACmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ACmenu.ImageList = null;
            this.ACmenu.Items = new string[0];
            this.ACmenu.TargetControlWrapper = null;
            // 
            // topMenuStrip
            // 
            this.topMenuStrip.BackColor = Color.White;
            this.topMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripLabel});
            this.topMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.topMenuStrip.Name = "topMenuStrip";
            this.topMenuStrip.Size = new System.Drawing.Size(25, 24);
            this.topMenuStrip.TabIndex = 0;
            this.topMenuStrip.Click += CodeTab_Click;
            // 
            // stripLabel
            // 
            this.stripLabel.ForeColor = System.Drawing.Color.Black;
            this.stripLabel.Name = "stripLabel";
            this.stripLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // bottomMenuStrip
            // 
            this.bottomMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(0)))), ((int)(((byte)(123)))));
            this.bottomMenuStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripLabel1});
            this.bottomMenuStrip.Location = new System.Drawing.Point(0, -24);
            this.bottomMenuStrip.Name = "bottomMenuStrip";
            this.bottomMenuStrip.Size = new System.Drawing.Size(25, 24);
            this.bottomMenuStrip.TabIndex = 0;
            // 
            // stripLabel1
            // 
            this.stripLabel1.ForeColor = System.Drawing.Color.White;
            this.stripLabel1.Name = "stripLabel1";
            this.stripLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // cms
            // 
            this.cms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(0)))), ((int)(((byte)(135)))));
            this.cms.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cms.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cms.Name = "cms";
            this.cms.Size = new System.Drawing.Size(61, 4);
            // 
            // documentMap
            // 
            this.documentMap.BackColor = Color.WhiteSmoke;
            this.documentMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.documentMap.ForeColor = System.Drawing.Color.Maroon;
            this.documentMap.Location = new System.Drawing.Point(0, 0);
            this.documentMap.Name = "documentMap";
            this.documentMap.Scale = 0.8F;
            this.documentMap.Size = new System.Drawing.Size(25, 0);
            this.documentMap.TabIndex = 0;
            this.documentMap.Target = this.code;
            // 
            // split
            // 
            this.split.Dock = System.Windows.Forms.DockStyle.Fill;
            this.split.Location = new System.Drawing.Point(0, 0);
            this.split.Name = "split";
            // 
            // split.Panel1
            // 
            this.split.Panel1.Controls.Add(this.code);
            this.split.Panel1.Controls.Add(this.topMenuStrip);
            this.split.Panel1.Controls.Add(this.bottomMenuStrip);
            // 
            // split.Panel2
            // 
            this.split.Panel2.Controls.Add(this.documentMap);
            this.split.Size = new System.Drawing.Size(0, 0);
            this.split.SplitterDistance = 25;
            this.split.TabIndex = 1;
            // 
            // comment
            // 
            this.comment.Name = "comment";
            this.comment.Size = new System.Drawing.Size(126, 22);
            this.comment.Text = "Comment";
            // 
            // codeTab
            // 
            this.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
           // this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(0)))), ((int)(((byte)(115)))));
            this.Controls.Add(this.split);
            this.ForeColor = System.Drawing.Color.Black;
            ((System.ComponentModel.ISupportInitialize)(this.code)).EndInit();
            this.contextMenu.ResumeLayout(false);
            this.topMenuStrip.ResumeLayout(false);
            this.topMenuStrip.PerformLayout();
            this.bottomMenuStrip.ResumeLayout(false);
            this.bottomMenuStrip.PerformLayout();
            this.split.Panel1.ResumeLayout(false);
            this.split.Panel1.PerformLayout();
            this.split.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.split)).EndInit();
            this.split.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void CodeTab_Click(object sender, EventArgs e)
        {
            this.stripLabel.Click += StripLabel_Click;
            if (stripLabel.Text != "")
                Clipboard.SetText(this.Name);
        }

        private void StripLabel_Click(object sender, EventArgs e)
        {
            if (stripLabel.Text != "")
                Clipboard.SetText(this.Name);
        }

        private void Code_TextChangedDelayed(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
        {
            RefreshCode();
            HighlightInvisibleChars(e.ChangedRange);
            code.CurrentLineColor = Color.FromArgb(50,80, 80, 80);
        }

        private void HighlightInvisibleChars(Range range)
        {
            ConfigFile config = new ConfigFile(Globals.User + "configure.conf");
            range.ClearStyle(invisibleCharsStyle);
            if (config.GetProperty("InvisibleCharsRenderer") == "true")
                range.SetStyle(invisibleCharsStyle, @".$|.\r\n|\s");
        }

        private void Code_KeyUp(object sender, KeyEventArgs e)
        {
            var line = code.PositionToPlace(code.SelectionStart);
            int ichar = line.iChar + 1;
            int iline = code.Selection.FromLine + 1;
            stripLabel1.Text = "Col:" + ichar + " Line: " + iline;
        }

        private void Code_KeyDown(object sender, KeyEventArgs e)
        {
            var line = code.PositionToPlace(code.SelectionStart);
            int ichar = line.iChar + 1;
            int iline = code.Selection.FromLine + 1;
            stripLabel1.Text = "Col:" + ichar + " Line: " + iline;
        }

        private void Code_MouseClick(object sender, MouseEventArgs e)
        {
            var line = code.PositionToPlace(code.SelectionStart);
            int ichar = line.iChar + 1;
            int iline = code.Selection.FromLine + 1;
            stripLabel1.Text = "Col:" + ichar + " Line: " + iline;
        }

        private void Igoto_Click(object sender, EventArgs e)
        {
            code.ShowGoToDialog();
        }

        private void Replace_Click(object sender, EventArgs e)
        {
            code.ShowReplaceDialog();
        }

        private void Find_Click(object sender, EventArgs e)
        {
            code.ShowFindDialog();
        }

        private void Paste_Click(object sender, EventArgs e)
        {
            code.Paste();
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            code.Copy();
        }

        private void Cut_Click(object sender, EventArgs e)
        {
            code.Cut();
        }

        private void Code_Load(object sender, EventArgs e)
        {
            HighlightingCode();
            LoadTopMenuLabel();
            RefreshCode();
            ConfigFile config = new ConfigFile(Globals.User + "configure.conf");
            try { LoadConfig(config); } catch { }
            //Theme(Globals.themes + config.GetProperty("theme"));
            Lang(Globals.locales + config.GetProperty("language") + ".conf");
            
            code.Select();
            if (code.Lines.Count > linesForDocMap)
            {
                split.Panel2Collapsed = false;
            }
            else
            {
                split.Panel2Collapsed = true;
            }
        }

        private void HighlightingCode()
        {
            if (Text.Contains(".cs"))
                code.Language = Language.CSharp;
            else if (Text.Contains(".vb"))
                code.Language = Language.VB;
            else if (Text.Contains(".html"))
                code.Language = Language.HTML;
            else if (Text.Contains(".xml"))
                code.Language = Language.XML;
            else if (Text.Contains(".sql"))
                code.Language = Language.SQL;
            else if (Text.Contains(".js"))
                code.Language = Language.JS;
            else if (Text.Contains(".json"))
                code.Language = Language.JSON;
            else if (Text.Contains(".lua"))
                code.Language = Language.Lua;
            else if (Text.Contains(".php"))
                code.Language = Language.PHP;
            else
                code.TextChangedDelayed += new EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(highLighting._HighLighting);
            code.Name = this.Name;
        }

        private void LoadConfig(ConfigFile config)
        {
            if (config.GetProperty("ireplacemode") == "true")
                code.IsReplaceMode = true;
            else
                code.IsReplaceMode = false;
            code.Zoom = int.Parse(config.GetProperty("zoom"));
            linesForDocMap = int.Parse(config.GetProperty("documentmapMinLines"));
            //code.BackColor = Color.FromArgb(int.Parse(config.GetProperty("backcolor").Split(',')[0]), int.Parse(config.GetProperty("backcolor").Split(',')[1]),int.Parse(config.GetProperty("backcolor").Split(',')[2]));
        }


        private void Lang(string data)
        {
            ConfigFile config = new ConfigFile(data);
            cut.Text = config.GetProperty("cut");
            copy.Text = config.GetProperty("copy");
            paste.Text = config.GetProperty("paste");
            find.Text = config.GetProperty("find");
            Igoto.Text = config.GetProperty("goto");
            replace.Text = config.GetProperty("replace");
        }

        private void Theme(string data)
        {
            /*
            ConfigFile c = new ConfigFile(data);
            this.BackColor = c.GetColor("backcoloredit");
            this.documentMap.BackColor = c.GetColor("docmapBackColor");
            this.contextMenu.BackColor = c.GetColor("contMenuBackColor");
            this.contextMenu.ForeColor = c.GetColor("contMenuForeColor");
            this.bottomMenuStrip.BackColor = c.GetColor("BackColor");
            this.topMenuStrip.BackColor = c.GetColor("backcoloredit");
            this.code.BackColor = c.GetColor("backcoloredit");
            this.code.DisabledColor = c.GetColor("disabledColor");
            this.code.IndentBackColor = c.GetColor("indentBackColor");
            this.code.SelectionColor = c.GetColor("selectionColor");
            this.code.LineNumberColor = c.GetColor("linenumberColor");
            code.ForeColor = c.GetColor("forecolor");
            */
        }

        public void LoadTopMenuLabel()
        {
            if (this.Name != "")
            {
                split.Panel1.Controls.Add(topMenuStrip);
                string replace = this.Name.Replace('\\', '>');
                stripLabel.Text = replace;
            }
            else
            {
                split.Panel1.Controls.Remove(topMenuStrip);
            }
        }

        private void Code_TextChanging(object sender, FastColoredTextBoxNS.TextChangingEventArgs e)
        {
            LoadTopMenuLabel();
            var line = code.PositionToPlace(code.SelectionStart);
            int ichar = line.iChar + 1;
            int iline = code.Selection.FromLine + 1;
            stripLabel1.Text = "Col:" + ichar + " Line: " + iline;
            if (code.Lines.Count > linesForDocMap)
            {
                split.Panel2Collapsed = false;
            }
            else
            {
                split.Panel2Collapsed = true;
            }
        }

        public async void RefreshCode()
        {
            await System.Threading.Tasks.Task.Run(() => {
                HighlightingCode();
                ACmenu.autoForce();
                
            });
           
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            //if (keyData == (Keys.Control | Keys.D1))
            //    this.code.Text = this.code.Text + "fun fun1{\n   \n}\n";
            //if (keyData == (Keys.Control | Keys.D2))
            //    this.code.Text = this.code.Text + "struct struct1{\n   \n}\n";
            //if (keyData == (Keys.Control | Keys.D3))
            //    this.code.Text = this.code.Text + "class class1{\n   \n}\n";
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }

    public class InvisibleCharsRenderer : Style
    {
        Pen pen;

        public InvisibleCharsRenderer(Pen pen)
        {
            this.pen = pen;
        }

        public override void Draw(Graphics gr, Point position, Range range)
        {
            var tb = range.tb;
            using (Brush brush = new SolidBrush(pen.Color))
                foreach (var place in range)
                {
                    switch (tb[place].c)
                    {
                        case ' ':
                            var point = tb.PlaceToPoint(place);
                            point.Offset(tb.CharWidth / 2, tb.CharHeight / 2);
                            gr.DrawLine(pen, point.X, point.Y, point.X + 1, point.Y);
                            break;
                    }

                    if (tb[place.iLine].Count - 1 == place.iChar)
                    {
                        var point = tb.PlaceToPoint(place);
                        point.Offset(tb.CharWidth, 0);
                        gr.DrawString("¶", tb.Font, brush, point);
                    }
                }
        }
    }
    public class FastCTBox : FastColoredTextBoxNS.FastColoredTextBox
    {
        public FastCTBox()
        {
        }
    }
}