
// This file has been generated by the GUI designer. Do not modify.
namespace BuildingFormulas
{
	public partial class InputDialog
	{
		private global::Gtk.VBox vbox3;
		
		private global::Gtk.Label lblInfo;
		
		private global::Gtk.Entry txtFileName;
		
		private global::Gtk.Button buttonCancel;
		
		private global::Gtk.Button buttonOk;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget BuildingFormulas.InputDialog
			this.WidthRequest = 600;
			this.HeightRequest = 200;
			this.Name = "BuildingFormulas.InputDialog";
			this.Title = global::Mono.Unix.Catalog.GetString ("Enter a name for the file.");
			this.WindowPosition = ((global::Gtk.WindowPosition)(1));
			this.Modal = true;
			this.BorderWidth = ((uint)(8));
			this.Resizable = false;
			this.AllowGrow = false;
			this.DefaultWidth = 400;
			this.DefaultHeight = 200;
			// Internal child BuildingFormulas.InputDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.WidthRequest = 400;
			w1.Name = "dlgInputBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dlgInputBox.Gtk.Box+BoxChild
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.lblInfo = new global::Gtk.Label ();
			this.lblInfo.HeightRequest = 35;
			this.lblInfo.Name = "lblInfo";
			this.lblInfo.LabelProp = global::Mono.Unix.Catalog.GetString ("Enter a name to save this file as.");
			this.vbox3.Add (this.lblInfo);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.lblInfo]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.txtFileName = new global::Gtk.Entry ();
			this.txtFileName.HeightRequest = 50;
			this.txtFileName.CanFocus = true;
			this.txtFileName.Name = "txtFileName";
			this.txtFileName.IsEditable = true;
			this.txtFileName.MaxLength = 100;
			this.txtFileName.InvisibleChar = '●';
			this.vbox3.Add (this.txtFileName);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.txtFileName]));
			w3.Position = 1;
			w3.Expand = false;
			w3.Fill = false;
			w1.Add (this.vbox3);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(w1 [this.vbox3]));
			w4.Position = 0;
			// Internal child BuildingFormulas.InputDialog.ActionArea
			global::Gtk.HButtonBox w5 = this.ActionArea;
			w5.Name = "dialog1_ActionArea";
			w5.Spacing = 10;
			w5.BorderWidth = ((uint)(5));
			w5.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseStock = true;
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = "gtk-cancel";
			this.AddActionWidget (this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w6 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w5 [this.buttonCancel]));
			w6.Expand = false;
			w6.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-ok";
			this.AddActionWidget (this.buttonOk, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w7 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w5 [this.buttonOk]));
			w7.Position = 1;
			w7.Expand = false;
			w7.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Show ();
			this.buttonCancel.Clicked += new global::System.EventHandler (this.OnBtnCancelClicked);
			this.buttonOk.Clicked += new global::System.EventHandler (this.OnBtnOkClicked);
		}
	}
}