
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.VBox vbox1;
	private global::Gtk.Label NameLabel;
	private global::Gtk.Entry NameField;
	private global::Gtk.Button SubmitButton;
	private global::Gtk.ScrolledWindow GtkScrolledWindow;
	private global::Gtk.TextView OutputTextView;
	
	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox ();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.NameLabel = new global::Gtk.Label ();
		this.NameLabel.Name = "NameLabel";
		this.NameLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Enter your name");
		this.vbox1.Add (this.NameLabel);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.NameLabel]));
		w1.Position = 0;
		w1.Expand = false;
		w1.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.NameField = new global::Gtk.Entry ();
		this.NameField.CanFocus = true;
		this.NameField.Name = "NameField";
		this.NameField.Text = global::Mono.Unix.Catalog.GetString ("World");
		this.NameField.IsEditable = true;
		this.NameField.ActivatesDefault = true;
		this.NameField.InvisibleChar = '●';
		this.vbox1.Add (this.NameField);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.NameField]));
		w2.Position = 1;
		w2.Expand = false;
		w2.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.SubmitButton = new global::Gtk.Button ();
		this.SubmitButton.CanDefault = true;
		this.SubmitButton.CanFocus = true;
		this.SubmitButton.Name = "SubmitButton";
		this.SubmitButton.UseUnderline = true;
		this.SubmitButton.Label = global::Mono.Unix.Catalog.GetString ("Submit");
		this.vbox1.Add (this.SubmitButton);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.SubmitButton]));
		w3.Position = 2;
		w3.Expand = false;
		w3.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
		this.GtkScrolledWindow.Name = "GtkScrolledWindow";
		this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
		this.OutputTextView = new global::Gtk.TextView ();
		this.OutputTextView.CanFocus = true;
		this.OutputTextView.Name = "OutputTextView";
		this.OutputTextView.Editable = false;
		this.GtkScrolledWindow.Add (this.OutputTextView);
		this.vbox1.Add (this.GtkScrolledWindow);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.GtkScrolledWindow]));
		w5.PackType = ((global::Gtk.PackType)(1));
		w5.Position = 3;
		this.Add (this.vbox1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 400;
		this.DefaultHeight = 300;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
	}
}