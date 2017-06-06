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
	string what = string.Empty;
	protected void OnEntryWhatChanged(object sender, EventArgs e)
	{
		what = entryWhat.Text;
		context_id = statusbar.GetContextId (what);
		statusbar.Push (context_id, what);
	}
	string where = string.Empty;
	static uint context_id ;
	protected void OnEntryWhereChanged(object sender, EventArgs e)
	{
		where = entryWhere.Text;
		context_id = statusbar.GetContextId (where);
		statusbar.Push (context_id, where);

	}
}
