
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.Fixed fixed1;

	private global::Gtk.Entry entry1;

	private global::Gtk.Button button1;

	private global::Gtk.ComboBox combobox1;

	private global::Gtk.Label userinputtxt;

	private global::Gtk.Label outputlabel;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.fixed1 = new global::Gtk.Fixed();
		this.fixed1.Name = "fixed1";
		this.fixed1.HasWindow = false;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.entry1 = new global::Gtk.Entry();
		this.entry1.CanFocus = true;
		this.entry1.Name = "entry1";
		this.entry1.IsEditable = true;
		this.entry1.InvisibleChar = '●';
		this.fixed1.Add(this.entry1);
		global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.entry1]));
		w1.X = 124;
		w1.Y = 44;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.button1 = new global::Gtk.Button();
		this.button1.CanFocus = true;
		this.button1.Name = "button1";
		this.button1.UseUnderline = true;
		this.button1.Label = global::Mono.Unix.Catalog.GetString("Convert");
		this.fixed1.Add(this.button1);
		global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.button1]));
		w2.X = 171;
		w2.Y = 106;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.combobox1 = global::Gtk.ComboBox.NewText();
		this.combobox1.AppendText(global::Mono.Unix.Catalog.GetString("mile to km"));
		this.combobox1.AppendText(global::Mono.Unix.Catalog.GetString("km to mile"));
		this.combobox1.Name = "combobox1";
		this.combobox1.Active = 0;
		this.fixed1.Add(this.combobox1);
		global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.combobox1]));
		w3.X = 146;
		w3.Y = 9;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.userinputtxt = new global::Gtk.Label();
		this.userinputtxt.Name = "userinputtxt";
		this.userinputtxt.LabelProp = global::Mono.Unix.Catalog.GetString("mile:");
		this.fixed1.Add(this.userinputtxt);
		global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.userinputtxt]));
		w4.X = 88;
		w4.Y = 47;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.outputlabel = new global::Gtk.Label();
		this.outputlabel.Name = "outputlabel";
		this.outputlabel.LabelProp = global::Mono.Unix.Catalog.GetString("Click convert to see result");
		this.fixed1.Add(this.outputlabel);
		global::Gtk.Fixed.FixedChild w5 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.outputlabel]));
		w5.X = 125;
		w5.Y = 77;
		this.Add(this.fixed1);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 394;
		this.DefaultHeight = 188;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.button1.Clicked += new global::System.EventHandler(this.OnBtnClick);
		this.combobox1.Changed += new global::System.EventHandler(this.OnCboxChanged);
	}
}