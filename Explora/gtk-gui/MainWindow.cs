
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.VBox vbox1;

	private global::Gtk.HBox hbox1;

	private global::Gtk.Label labelWhat;

	private global::Gtk.Entry entryWhat;

	private global::Gtk.HBox hbox2;

	private global::Gtk.Label labelWhere;

	private global::Gtk.Entry entryWhere;

	private global::Gtk.HBox hbox4;

	private global::Gtk.ScrolledWindow GtkScrolledWindow;

	private global::Gtk.TextView textview1;

	private global::Gtk.VBox vbox4;

	private global::Gtk.Button buttonBuscarA;

	private global::Gtk.Button buttonBuscarR;

	private global::Gtk.Button buttonCancel;

	private global::Gtk.Button buttonClean;

	private global::Gtk.Statusbar statusbar;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		this.BorderWidth = ((uint)(2));
		this.AllowShrink = true;
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.labelWhat = new global::Gtk.Label();
		this.labelWhat.Name = "labelWhat";
		this.labelWhat.LabelProp = global::Mono.Unix.Catalog.GetString("What: ");
		this.hbox1.Add(this.labelWhat);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.labelWhat]));
		w1.Position = 0;
		w1.Expand = false;
		w1.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.entryWhat = new global::Gtk.Entry();
		global::Gtk.Tooltips w2 = new Gtk.Tooltips();
		w2.SetTip(this.entryWhat, "what is looking for ...", "what is looking for ...");
		this.entryWhat.CanFocus = true;
		this.entryWhat.Name = "entryWhat";
		this.entryWhat.IsEditable = true;
		this.entryWhat.InvisibleChar = '●';
		this.hbox1.Add(this.entryWhat);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.entryWhat]));
		w3.Position = 1;
		this.vbox1.Add(this.hbox1);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox1]));
		w4.Position = 0;
		w4.Expand = false;
		w4.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox2 = new global::Gtk.HBox();
		this.hbox2.Name = "hbox2";
		this.hbox2.Spacing = 6;
		// Container child hbox2.Gtk.Box+BoxChild
		this.labelWhere = new global::Gtk.Label();
		this.labelWhere.Name = "labelWhere";
		this.labelWhere.LabelProp = global::Mono.Unix.Catalog.GetString("Where: ");
		this.hbox2.Add(this.labelWhere);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.labelWhere]));
		w5.Position = 0;
		w5.Expand = false;
		w5.Fill = false;
		// Container child hbox2.Gtk.Box+BoxChild
		this.entryWhere = new global::Gtk.Entry();
		w2.SetTip(this.entryWhere, "over where I can begening", "over where I can begening");
		this.entryWhere.CanFocus = true;
		this.entryWhere.Name = "entryWhere";
		this.entryWhere.IsEditable = true;
		this.entryWhere.InvisibleChar = '●';
		this.hbox2.Add(this.entryWhere);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.entryWhere]));
		w6.Position = 1;
		this.vbox1.Add(this.hbox2);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox2]));
		w7.Position = 1;
		w7.Expand = false;
		w7.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox4 = new global::Gtk.HBox();
		this.hbox4.Name = "hbox4";
		this.hbox4.Spacing = 6;
		// Container child hbox4.Gtk.Box+BoxChild
		this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
		this.GtkScrolledWindow.Name = "GtkScrolledWindow";
		this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
		this.textview1 = new global::Gtk.TextView();
		this.textview1.CanFocus = true;
		this.textview1.Name = "textview1";
		this.GtkScrolledWindow.Add(this.textview1);
		this.hbox4.Add(this.GtkScrolledWindow);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.GtkScrolledWindow]));
		w9.Position = 0;
		// Container child hbox4.Gtk.Box+BoxChild
		this.vbox4 = new global::Gtk.VBox();
		this.vbox4.Name = "vbox4";
		this.vbox4.Spacing = 6;
		// Container child vbox4.Gtk.Box+BoxChild
		this.buttonBuscarA = new global::Gtk.Button();
		w2.SetTip(this.buttonBuscarA, "it make a great searcher", "it make a great searcher");
		this.buttonBuscarA.CanFocus = true;
		this.buttonBuscarA.Name = "buttonBuscarA";
		this.buttonBuscarA.UseUnderline = true;
		this.buttonBuscarA.Label = global::Mono.Unix.Catalog.GetString("Busca (a)");
		this.vbox4.Add(this.buttonBuscarA);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.buttonBuscarA]));
		w10.Position = 0;
		w10.Expand = false;
		w10.Fill = false;
		// Container child vbox4.Gtk.Box+BoxChild
		this.buttonBuscarR = new global::Gtk.Button();
		w2.SetTip(this.buttonBuscarR, "it is a restrictic searshing", "it is a restrictic searshing");
		this.buttonBuscarR.CanFocus = true;
		this.buttonBuscarR.Name = "buttonBuscarR";
		this.buttonBuscarR.UseUnderline = true;
		this.buttonBuscarR.Label = global::Mono.Unix.Catalog.GetString("Busca (R)");
		this.vbox4.Add(this.buttonBuscarR);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.buttonBuscarR]));
		w11.Position = 1;
		w11.Expand = false;
		w11.Fill = false;
		// Container child vbox4.Gtk.Box+BoxChild
		this.buttonCancel = new global::Gtk.Button();
		w2.SetTip(this.buttonCancel, "Cancel searching", "Cancel searching");
		this.buttonCancel.CanFocus = true;
		this.buttonCancel.Name = "buttonCancel";
		this.buttonCancel.UseUnderline = true;
		this.buttonCancel.Label = global::Mono.Unix.Catalog.GetString("Cancel");
		this.vbox4.Add(this.buttonCancel);
		global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.buttonCancel]));
		w12.Position = 2;
		w12.Expand = false;
		w12.Fill = false;
		// Container child vbox4.Gtk.Box+BoxChild
		this.buttonClean = new global::Gtk.Button();
		w2.SetTip(this.buttonClean, "Clean text area.", "Clean text area.");
		this.buttonClean.CanFocus = true;
		this.buttonClean.Name = "buttonClean";
		this.buttonClean.UseUnderline = true;
		this.buttonClean.Label = global::Mono.Unix.Catalog.GetString("Clear");
		this.vbox4.Add(this.buttonClean);
		global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.buttonClean]));
		w13.Position = 3;
		w13.Expand = false;
		w13.Fill = false;
		this.hbox4.Add(this.vbox4);
		global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.vbox4]));
		w14.Position = 1;
		w14.Expand = false;
		w14.Fill = false;
		this.vbox1.Add(this.hbox4);
		global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox4]));
		w15.Position = 2;
		// Container child vbox1.Gtk.Box+BoxChild
		this.statusbar = new global::Gtk.Statusbar();
		this.statusbar.Name = "statusbar";
		this.statusbar.Spacing = 6;
		this.vbox1.Add(this.statusbar);
		global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.statusbar]));
		w16.PackType = ((global::Gtk.PackType)(1));
		w16.Position = 3;
		w16.Expand = false;
		w16.Fill = false;
		this.Add(this.vbox1);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 473;
		this.DefaultHeight = 292;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.entryWhat.Changed += new global::System.EventHandler(this.OnEntryWhatChanged);
		this.entryWhere.Changed += new global::System.EventHandler(this.OnEntryWhereChanged);
	}
}
