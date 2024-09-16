using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SKIDLE
{
    internal static class Program
    {

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        [return: System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.Bool)]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        [return: System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.Bool)]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
           
            /// <summary>
            /// Главная точка входа для приложения.
            /// </summary>
            [STAThread]
        static void Main(string[] args)
        {

            Application.EnableVisualStyles();
            LoadAllExtAndLibs.Load();
            bool isNotRunning = true;
            ConfigFile config = new ConfigFile(Globals.User + "configure.conf");
            using (var mutex = new System.Threading.Mutex(true, Application.ProductName, out isNotRunning))
            {
                if (isNotRunning)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    if (args != null && args.Length > 0)
                    {
                        if (args.Length == 1)
                        {
                            String file = args[0];
                            if (Path.GetExtension(file) == ".")
                            {
                                skidle mf = new skidle();
                                mf.LoadCFA(file);
                                Application.EnableVisualStyles();
                                Application.Run(mf);
                            }
                            else
                            {
                                skidle mf = new skidle();
                                mf.LoadFCMD(args);
                                Application.EnableVisualStyles();
                                Application.Run(mf);
                            }
                        }
                        else
                        {
                            skidle mf = new skidle();
                            mf.LoadFCMD(args);
                            Application.EnableVisualStyles();
                            Application.Run(mf);

                        }
                    }
                    else
                    {
                        Application.EnableVisualStyles();
                        Application.SetCompatibleTextRenderingDefault(false);
                        Application.Run(new skidle());
                    }
                }
                else
                {
                    var curr = System.Diagnostics.Process.GetCurrentProcess();
                    foreach (var proc in System.Diagnostics.Process.GetProcessesByName(curr.ProcessName))
                    {
                        if (proc.Id != curr.Id)
                        {
                            ShowWindow(proc.MainWindowHandle, 9);
                            ShowWindow(proc.MainWindowHandle, 5);
                            SetForegroundWindow(proc.MainWindowHandle);
                            if (args != null && args.Length > 0)
                            {
                                if (args.Length == 1)
                                {
                                    String file = args[0];
                                    if (Path.GetExtension(file) == ".")
                                    {
                                        Application.EnableVisualStyles();
                                        MyWindowsApplicationBase appBase = new MyWindowsApplicationBase();
                                        appBase.StartupNextInstance += (sender, e) => { new skidle().LoadCFA(file); };
                                        appBase.Run(args);
                                    }
                                    else
                                    {
                                        Application.EnableVisualStyles();
                                        MyWindowsApplicationBase appBase = new MyWindowsApplicationBase();
                                        appBase.StartupNextInstance += (sender, e) => { new skidle().LoadFCMD(args); };
                                        appBase.Run(args);
                                    }
                                }
                                else
                                {
                                    Application.EnableVisualStyles();
                                    MyWindowsApplicationBase appBase = new MyWindowsApplicationBase();
                                    appBase.StartupNextInstance += (sender,e) => { new skidle().LoadFCMD(args); };
                                    appBase.Run(args);
                                }
                            }
                        }
                    }
                }
            }
        }
    }

    class MyWindowsApplicationBase : WindowsFormsApplicationBase
    {
        internal MyWindowsApplicationBase() : base()
        {

            this.IsSingleInstance = true;
            this.MainForm = new skidle();
        }
    }
}
