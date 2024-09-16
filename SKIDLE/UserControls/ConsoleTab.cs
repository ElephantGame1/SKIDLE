using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SKIDLE.UserControls
{
    public partial class ConsoleTab : Manina.Windows.Forms.Tab
    {
        public ConsoleTab()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            CreateConsole();
        }
        private async void CreateConsole()
        {
            await Task.Run(() => {
                bool stop = false;
                string text = "";
                do
                {
                    console.WriteLine("&> ");
                    text = console.ReadLine();
                    console.Command(text);
                    this.Text = text;
                } while (text != "" && stop != true);

            });
        }
        public async void WriteLine(string text)
        {
            await Task.Run(() => {
                bool stop = false;
                do
                {
                    console.WriteLine("&> ");
                    text = console.ReadLine();
                    console.Command(text);
                    this.Text = text;
                } while (text != "" && stop != true);

            });
            console.WriteLine(text);
        }
    }
}
