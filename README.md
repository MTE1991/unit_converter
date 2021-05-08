# Unit Converter 1.0

This is made with gtk# 2.0 and visual studio 2019. It's a simple gui app which converts one base unit to another. 

Download [Source Code](https://github.com/MTE1991/unit_converter/archive/refs/heads/main.zip)

Program.cs:

```c#
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

```
