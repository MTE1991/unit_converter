using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void OnBtnClick(object sender, EventArgs e)
    {
        if (this.combobox1.ActiveText == "mile to km")
        {
            double val = Convert.ToDouble(this.entry1.Text) * 1.60934; // Input value
            this.outputlabel.Text = this.entry1.Text + " mile = " + Convert.ToString(val) + " km";
        }
        else if (this.combobox1.ActiveText == "km to mile") {
            double val = Convert.ToDouble(this.entry1.Text) * 0.621371; // Input value
            this.outputlabel.Text = this.entry1.Text + " km = " + Convert.ToString(val) + " mile";
        }
    }

    protected void OnCboxChanged(object sender, EventArgs e)
    {
        if (this.combobox1.ActiveText == "km to mile")
            this.userinputtxt.Text = "km:";
        else if (this.combobox1.ActiveText == "mile to km")
            this.userinputtxt.Text = "mile:";
    }
}
