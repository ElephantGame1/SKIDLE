using FastColoredTextBoxNS;
using SKIDLE.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SKIDLE
{
    public class AutoForce : AutocompleteMenuNS.AutocompleteMenu
    {
        FastCTBox code;
        public AutoForce(FastCTBox code)
        {
            this.code = code;
        }

        public void autoForce()
        {
            this.Items = null;
            this.MinFragmentLength = 1;
            List<String> keywords = new List<string>();
            IList<string> lines = code.Lines;

            string mod = Globals.languages + "SpecialKey" + "//modules.conf";
            string mf = Globals.languages + "SpecialKey" + "//" + new ConfigFile(mod).GetProperty("mf");
            string af = Globals.languages + "SpecialKey" + "//" + "autoforce.dict";
            string ms = new ConfigFile(mod).GetProperty("ms");
            string libs = new ConfigFile(mod).GetProperty("libs");

            try
            {
                for (int i = 0; i < File.ReadAllLines(mf).Length; i++)
                {
                    if (File.ReadAllLines(mf)[i].Contains(ms.Split('.')[1] + ":"))
                    {
                        int s = i++;
                        do
                        {
                            keywords.Add(File.ReadAllLines(mf)[s].Trim(' '));
                            s++;
                        }
                        while (!File.ReadAllLines(mf)[s].Contains(";"));
                    }
                    foreach (var lib in libs.Split(','))
                        foreach (var iline in lines)
                        {
                            if (iline.Contains("Add " + lib))
                                if (File.ReadAllLines(mf)[i].Contains(lib + ":"))
                                {
                                    int s = i++;
                                    do
                                    {
                                        keywords.Add(File.ReadAllLines(mf)[s].Trim(' '));
                                        s++;
                                    }
                                    while (!File.ReadAllLines(mf)[s].Contains(";"));
                                }
                        }
                }
            }
            catch { }
            foreach (var iline in lines)
            {
                try
                {
                    for (int o = 0; o < File.ReadAllLines(af).Length; o++)
                        if (iline.Contains(File.ReadAllLines(af)[o]))
                        {
                            string q = iline.Trim(' ', '(', ')');
                            q = q.Split(' ')[1];
                            q = q.Split('=', '(', ')', ' ', '{', '}')[0];
                            keywords.Add(q);
                        }
                }
                catch { }
            }

            for (int i = 0; i < keywords.Count; i++)
            {
                this.AddItem(keywords[i]);
            }
        }
    }
}