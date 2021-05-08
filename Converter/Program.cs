using System;
using Gtk;

namespace Converter
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Application.Init();
            MainWindow win = new MainWindow();
            win.Title = "Unit Converter 1.0";
            win.Show();
            Application.Run();
        }
    }
}
