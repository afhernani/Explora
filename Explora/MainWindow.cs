﻿using System;
using Gtk;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;


public partial class MainWindow : Gtk.Window
{
	SearcherUi Lib;
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
