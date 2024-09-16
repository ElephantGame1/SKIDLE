using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SKIDLE
{
    public class LoadAllExtAndLibs
    {
        public static void Load()
        {
            ConfigFile user = new ConfigFile(Globals.User + "configure.conf");
            foreach (var extf in Directory.GetFiles(Globals.exts))
            {
                ConfigFile ext = new ConfigFile(extf);
                try {
                    AssociationFile.CreateAssociation(Assembly.GetExecutingAssembly().EntryPoint.DeclaringType.FullName, ext.GetProperty("ext").Split('|')[0], ext.GetProperty("ext").Split('|')[4], System.Reflection.Assembly.GetExecutingAssembly().Location, ext.GetProperty("ext").Split('|')[3] + ",0", AssociationFile.KeyHiveSmall.CurrentUser); }
                catch
                {
                    try {
                        AssociationFile.SelfCreateAssociation(ext.GetProperty("ext").Split('|')[0], AssociationFile.KeyHiveSmall.ClassesRoot, ext.GetProperty("ext").Split('|')[4]); }
                    catch
                    {
                        try
                        {
                            AssociationFile.SelfCreateAssociation(ext.GetProperty("ext").Split('|')[0], AssociationFile.KeyHiveSmall.ClassesRoot, ext.GetProperty("ext").Split('|')[3]); }
                        catch {
                            AssociationFile.SelfCreateAssociation(ext.GetProperty("ext").Split('|')[0], AssociationFile.KeyHiveSmall.ClassesRoot, "source file"); }
                    }
                }
            }
        }
    }
}
