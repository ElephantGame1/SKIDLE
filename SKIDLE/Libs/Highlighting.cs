using FastColoredTextBoxNS;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;

namespace SKIDLE
{
    public class HighLighting
    {
        protected Regex SPKAttributeRegex,
                      SPKClassNameRegex;

        protected Regex SPKCommentRegex1,
                      SPKCommentRegex2,
                      SPKCommentRegex3;

        protected Regex SPKKeywordRegex;
        protected Regex SPKNumberRegex;
        protected Regex SPKStringRegex;
        protected Regex SPKFunRegex;
        protected Regex SPKFClassRegex;
        protected Regex SPKEnumRegex;
        protected Regex SPKVarRegex;

        protected static readonly Platform platformType = PlatformType.GetOperationSystemPlatform();
        public static RegexOptions RegexCompiledOption
        {
            get
            {
                if (platformType == Platform.X86)
                    return RegexOptions.Compiled;
                else
                    return RegexOptions.None;
            }
        }

        private Style FunStyle = new TextStyle(new SolidBrush(Color.FromArgb(103, 216, 239)), null, FontStyle.Regular);
        private Style BlueSlateStyle = new TextStyle(Brushes.DarkSlateBlue, null, FontStyle.Regular);
        private Style TealStyle = new TextStyle(new SolidBrush(Color.FromArgb(249, 36, 100)), null, FontStyle.Regular);
        private Style CommentStyle = new TextStyle(Brushes.Gray, null, FontStyle.Bold);
        private Style LightBlueStyle = new TextStyle(Brushes.LightBlue, null, FontStyle.Bold);
        private Style AddStyle = new TextStyle(Brushes.Orange, null, FontStyle.Regular);
        private Style VSfc = new TextStyle(new SolidBrush(Color.FromArgb(155, 77, 220)), null, FontStyle.Italic);
        private Style TurquoiseStyle = new TextStyle(Brushes.Turquoise, null, FontStyle.Regular);
        private Style MediumPurpleStyle = new TextStyle(Brushes.Fuchsia, null, FontStyle.Regular);
        private Style CharStyle = new TextStyle(Brushes.DarkOrange, null, FontStyle.Regular);

        public void _HighLighting(object sender, TextChangedEventArgs e)
        {
            e.ChangedRange.BeginUpdate();
            e.ChangedRange.tb.SelectionColor = Color.Gray;
            e.ChangedRange.ClearFoldingMarkers();
            e.ChangedRange.tb.CommentPrefix = "#";
            e.ChangedRange.tb.LeftBracket = '(';
            e.ChangedRange.tb.RightBracket = ')';
            e.ChangedRange.tb.LeftBracket2 = '{';
            e.ChangedRange.tb.RightBracket2 = '}';
            e.ChangedRange.tb.BracketsHighlightStrategy = BracketsHighlightStrategy.Strategy2;

            e.ChangedRange.tb.AutoIndentCharsPatterns = @"{|}|[|]|""|""|(|)";

            e.ChangedRange.ClearStyle(MediumPurpleStyle, CommentStyle, TurquoiseStyle, VSfc, AddStyle, LightBlueStyle);
            if (SPKStringRegex == null)
                InitSPKRegex();

            e.ChangedRange.SetStyle(CharStyle, SPKStringRegex);

            e.ChangedRange.SetStyle(CommentStyle, SPKCommentRegex1);
            e.ChangedRange.SetStyle(CommentStyle, SPKCommentRegex2);
            e.ChangedRange.SetStyle(CommentStyle, SPKCommentRegex3);

            e.ChangedRange.SetStyle(TealStyle, @"var");
            e.ChangedRange.SetStyle(FunStyle, @"fun|class|switch|case");
            e.ChangedRange.SetStyle(CharStyle, @"return");
            e.ChangedRange.SetStyle(VSfc, @"if|for|while|do|else|stop|continue|enum");
            e.ChangedRange.SetStyle(TurquoiseStyle, @"toStr|toInt|toFloat|toByte|toShort|toLong|toDouble|ref|length|Array|strReplace|strSplit");
            e.ChangedRange.SetStyle(LightBlueStyle, @"Null|True|False|protected:|private:");
            e.ChangedRange.SetStyle(MediumPurpleStyle, @"input|out");
            e.ChangedRange.SetStyle(AddStyle, @"Add");
            e.ChangedRange.SetStyle(CharStyle, @"{|}|[|]|""|""|\'|\'|:|;|(|)|!|@|#|$|%|^|&");

            //clear folding markers
            e.ChangedRange.ClearFoldingMarkers();
            //set folding markers
            e.ChangedRange.SetFoldingMarkers("{", "}"); //allow to collapse brackets block
            e.ChangedRange.SetFoldingMarkers(@"#region\b", @"#endregion\b"); //allow to collapse #region blocks

            IList<string> line = e.ChangedRange.tb.Lines;
            for (int i = 0; i < line.Count; i++)
            {
                try
                {
                    if (line[i].Contains("var"))
                    {
                        string q = line[i].Trim(' ');
                        q = q.Split(' ')[1];
                        q = q.Split('=', ' ', '(', ')', '{', '}')[0];
                        e.ChangedRange.SetStyle(BlueSlateStyle, SPKVarRegex);
                    }
                    else
                     if (line[i].Contains("enum"))
                    {
                        string q = line[i].Trim(' ');
                        q = q.Split(' ')[1];
                        q = q.Split('=', ' ', '(', ')', '{', '}')[0];
                        e.ChangedRange.SetStyle(BlueSlateStyle, SPKEnumRegex);
                    }
                    else
                    if (line[i].Contains("class"))
                    {
                        string q = line[i].Trim(' ');
                        q = q.Split(' ')[1];
                        q = q.Split('=', ' ', '(', ')', '{', '}')[0];
                        e.ChangedRange.SetStyle(BlueSlateStyle, SPKFClassRegex);
                    }
                    else
                    if (line[i].Contains("fun"))
                    {
                        string q = line[i].Trim(' ');
                        q = q.Split(' ')[1];
                        q = q.Split('=', ' ', '(', ')', '{', '}')[0];
                        e.ChangedRange.SetStyle(BlueSlateStyle, SPKFunRegex);
                    }
                }
                catch { }
            }

            foreach (var item in Directory.GetFiles(Globals.SpecialKey + "modules\\", "*.spk"))
            {
                FileInfo fi = new FileInfo(item);
                string dfName = fi.Name.Split(".spk"[0])[0];
                if (e.ChangedRange.tb.Text.Contains("Add " + dfName))
                {
                    List<string> LinesFromFile = new List<string>(File.ReadAllLines(item));

                    for (int i = 0; i < LinesFromFile.Count; i++)
                    {
                        try
                        {
                            if (LinesFromFile[i].Contains("fun") || LinesFromFile[i].Contains("enum") || LinesFromFile[i].Contains("class"))
                            {
                                string q = LinesFromFile[i].Trim(' ');
                                q = q.Split(' ')[1];
                                q = q.Split('=', ' ', '(', ')', '{', '}')[0];
                                e.ChangedRange.SetStyle(BlueSlateStyle, q);
                            }
                        }
                        catch { }
                    }
                }
                else { }
            }
        }
        protected void SPKAutoIndentNeeded(object sender, AutoIndentEventArgs args)
        {
            //block {}
            if (Regex.IsMatch(args.LineText, @"^[^""']*\{.*\}[^""']*$"))
                return;
            //start of block {}
            if (Regex.IsMatch(args.LineText, @"^[^""']*\{"))
            {
                args.ShiftNextLines = args.TabLength;
                return;
            }
            //end of block {}
            if (Regex.IsMatch(args.LineText, @"}[^""']*$"))
            {
                args.Shift = -args.TabLength;
                args.ShiftNextLines = -args.TabLength;
                return;
            }
            //label
            if (Regex.IsMatch(args.LineText, @"^\s*\w+\s*:\s*($|//)") &&
                !Regex.IsMatch(args.LineText, @"^\s*default\s*:"))
            {
                args.Shift = -args.TabLength;
                return;
            }
            if (Regex.IsMatch(args.LineText, @"^\s*(case|default)\b.*:\s*($|//)"))
            {
                args.Shift = -args.TabLength / 2;
                return;
            }
            if (Regex.IsMatch(args.PrevLineText, @"^\s*(if|do|for|foreach|while|[\}\s]*else)\b[^{]*$"))
                if (!Regex.IsMatch(args.PrevLineText, @"(;\s*$)|(;\s*//)"))
                {
                    args.Shift = args.TabLength;
                    return;
                }
        }
        protected void InitSPKRegex()
        {

            SPKStringRegex =
                new Regex(
                    @"
                            # Character definitions:
                            '
                            (?> # disable backtracking
                              (?:
                                \\[^\r\n]|    # escaped meta char
                                [^'\r\n]      # any character except '
                              )*
                            )
                            '?
                            |
                            # Normal string & verbatim strings definitions:
                            (?<verbatimIdentifier>@)?         # this group matches if it is an verbatim string
                            ""
                            (?> # disable backtracking
                              (?:
                                # match and consume an escaped character including escaped double quote ("") char
                                (?(verbatimIdentifier)        # if it is a verbatim string ...
                                  """"|                         #   then: only match an escaped double quote ("") char
                                  \\.                         #   else: match an escaped sequence
                                )
                                | # OR
            
                                # match any char except double quote char ("")
                                [^""]
                              )*
                            )
                            ""
                        ",
                    RegexOptions.ExplicitCapture | RegexOptions.Singleline | RegexOptions.IgnorePatternWhitespace |
                    RegexCompiledOption
                    );

            SPKCommentRegex1 = new Regex(@"#.*$", RegexOptions.Multiline | RegexCompiledOption);
            SPKCommentRegex2 = new Regex(@"(/#*.*?\*/)|(/\*.*)", RegexOptions.Singleline | RegexCompiledOption);
            SPKCommentRegex3 = new Regex(@"(/#*.*?\*/)|(.*\*/)",
                                            RegexOptions.Singleline | RegexOptions.RightToLeft | RegexCompiledOption);
            SPKNumberRegex = new Regex(@"\b\d+[\.]?\d*([eE]\-?\d+)?[lLdDfF]?\b|\b0x[a-fA-F\d]+\b",
                                          RegexCompiledOption);
            SPKAttributeRegex = new Regex(@"^\s*(?<range>\[.+?\])\s*$", RegexOptions.Multiline | RegexCompiledOption);
            SPKClassNameRegex = new Regex(@"\b(class|enum|fun)\s+(?<range>\w+?)\b", RegexCompiledOption);
            SPKVarRegex = new Regex(@"\b(var)\s+(?<range>\w+?)\b", RegexCompiledOption);
            SPKFClassRegex = new Regex(@"\b(class)\s+(?<range>\w+?)\b", RegexCompiledOption);
            SPKEnumRegex = new Regex(@"\b(enum)\s+(?<range>\w+?)\b", RegexCompiledOption);
            SPKFunRegex = new Regex(@"\b(fun)\s+(?<range>\w+?)\b", RegexCompiledOption);
            SPKKeywordRegex =
                new Regex(
                    @"\b(Add|fun|class|if|for|while|do|else|stop|continue|switch|case|enum|toStr|toInt|toFloat|toByte|toShort|toLong|toDouble|ref|length|Array|strReplace|strSplit|var|Null|True|False|protected:|private:|input|out|return)\b|#region\b|#endregion\b",
                    RegexCompiledOption);
        }
    }
}