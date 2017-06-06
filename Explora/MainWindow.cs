using System;
using Gtk;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

public partial class MainWindow : Gtk.Window
{
	Explora.SearcherUi lib = null;
	System.Threading.Tasks.Task tarea;
	public MainWindow() : base(Gtk.WindowType.Toplevel)
	{
		Build();
		lib = new Explora.SearcherUi();
		lib.FileFounderEvent += fileFound;
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
		context_id = statusbar.GetContextId(what);
		statusbar.Push(context_id, what);
	}

	string where = string.Empty;
	static uint context_id;

	protected void OnEntryWhereChanged(object sender, EventArgs e)
	{
		where = entryWhere.Text;
		context_id = statusbar.GetContextId(where);
		statusbar.Push(context_id, where);
	}

	void fileFound(FileInfo file)
	{
		Gtk.Application.Invoke(delegate
		{
			//richTextBox.Clear();
			if (file != null)
			{
				textview1.Buffer.Text += file.FullName + "\n";
			}
			else
			{
				textview1.Buffer.Text += "End\n";
				buttonBuscarR.Sensitive = true;
				buttonBuscarA.Sensitive = true;
			}
		});
	}

	CancellationTokenSource cs = null;
	/// <summary>
	/// Ons the button buscar AC licked.
	/// </summary>
	/// <param name="sender">Sender.</param>
	/// <param name="e">E.</param>
    protected void OnButtonBuscarAClicked(object sender, EventArgs e)
	{
		try
		{
			//btnAction.Enabled = false;
			cs = new CancellationTokenSource();
			textview1.Buffer.Text += "Buscando: => *" + entryWhat.Text + "* /(amplia).\n";
			//lib.SearchFileinDirectory(new DirectoryInfo(txtWhere.Text),"*"+txtWhat.Text+"*");
			tarea = new Task(() => lib.SearchFileinDirectory(new DirectoryInfo(entryWhere.Text), "*" + entryWhat.Text + "*", cs));
			tarea.Start();
		}
		catch (Exception ex)
		{
			Debug.WriteLine(ex.Message);
		}
	}

	protected void OnButtonBuscarRClicked(object sender, EventArgs e)
	{
		buttonBuscarR.Sensitive = false;
		buttonBuscarA.Sensitive = false;
		cs = new CancellationTokenSource();
		textview1.Buffer.Text +="Buscando: => "+ entryWhat.Text +"\n";
		tarea = new Task(() =>lib.SearchFileinDirectory(new DirectoryInfo(entryWhere.Text), entryWhat.Text, cs));
		tarea.Start();
	}

	protected void OnButtonCancelClicked(object sender, EventArgs e)
	{
		cs.Cancel();
		textview1.Buffer.Text += "Canceled for your action ...\n";
		buttonBuscarA.Sensitive = true;
		buttonBuscarR.Sensitive = true;
	}

	protected void OnButtonCleanClicked(object sender, EventArgs e)
	{
		textview1.Buffer.Clear();
	}
}