using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows;

namespace SKIDLE
{
    public class ConfigFile
    {
        string file;
        public ConfigFile(string file) // получаем файл
        {
            this.file = file;
        }

        public string GetComment(string title)
        {
            if (File.Exists(file))
            {
                foreach(var line in File.ReadAllLines(file))
                {
                    if (line.Contains("[" + title + ":"))
                    {
                        return line.Split(':')[1].TrimEnd(']');
                    }
                }
            }
            return title;
        }
        public string GetProperty(string property)
        {
            if (File.Exists(file))
            {
                foreach (var line in File.ReadAllLines(file))
                {
                    if (line.Contains(property)&& !line.StartsWith("#"))
                        return line.Split(':')[1].Trim(' ','"');
                }
            }
            else return "file not found";
            return property;
        }
        public Color GetColor(string property)
        {
            if (File.Exists(file))
            {
                string l = GetProperty(property);
                if (l.Contains(","))
                {
                    try { Color c = Color.FromArgb(int.Parse(l.Split(',')[0]), int.Parse(l.Split(',')[1]), int.Parse(l.Split(',')[2]), int.Parse(l.Split(',')[3])); return Color.FromArgb(c.ToArgb()); } catch { Color c = Color.FromArgb(int.Parse(l.Split(',')[0]), int.Parse(l.Split(',')[1]), int.Parse(l.Split(',')[2])); return Color.FromArgb(c.ToArgb()); }
                }
                else { try {return Color.FromName(l); } catch { } }
            }
            else{
                MessageBox.Show("file not found"+ file,file);
            }
            return Color.White;
        }

        public void SetProperty(string property,string name)
        {
            if (File.Exists(file))
            {
                string check = property + ":" + "\"" + name + "\"";
                string checki = property + ":" + name;
                string content = File.ReadAllText(file);

                if (content.Contains(check)|| content.Contains(checki))
                {
                    ReProperty(property, name);
                }
                else
                {
                    string newcontent = content + "\n" + check;
                    File.WriteAllText(file, newcontent);
                }
            }
        }   
        public void ReProperty(string property,string newname)
        {
            if (File.Exists(file))
            {
                foreach(var line in File.ReadAllLines(file))
                {
                    if (line.Contains(property) && !line.StartsWith("#"))
                    {
                        string content = File.ReadAllText(file);
                        string propname = line.Split(':')[1].Trim(' ', '"');
                        string reline = property + ":" + propname.Replace(propname, newname);
                        string newcontent = content.Replace(line,reline);
                        File.WriteAllText(file, newcontent);
                    }
                    else { }
                }
            }
        }
    }
}
