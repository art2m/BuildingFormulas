
// This file has been generated by the GUI designer. Do not modify.
namespace BuildingFormulas
{
	public partial class dlgDisplayStoredData
	{
		private global::Gtk.VBox vbox2;
		
		private global::Gtk.HBox hbox1;
		
		private global::Gtk.Table tblDataStore;
		
		private global::Gtk.Label lblDepth;
		
		private global::Gtk.Label lblFeet;
		
		private global::Gtk.Label lblInches;
		
		private global::Gtk.Label lblLength;
		
		private global::Gtk.Label lblWidth;
		
		private global::Gtk.Label lblYards;
		
		private global::Gtk.Entry txtDepthFtCm;
		
		private global::Gtk.Entry txtDepthInMm;
		
		private global::Gtk.Entry txtDepthYdM;
		
		private global::Gtk.Entry txtLengthFtCm;
		
		private global::Gtk.Entry txtLengthInMm;
		
		private global::Gtk.Entry txtLengthYdM;
		
		private global::Gtk.Entry txtWidthFtCm;
		
		private global::Gtk.Entry txtWidthInMm;
		
		private global::Gtk.Entry txtWidthYdM;
		
		private global::Gtk.Table table1;
		
		private global::Gtk.Entry entry7;
		
		private global::Gtk.Entry entry8;
		
		private global::Gtk.Label lblRecPos;
		
		private global::Gtk.Label lblVolFtCm;
		
		private global::Gtk.Label lblVolInMm;
		
		private global::Gtk.Label lblVolYdM;
		
		private global::Gtk.Entry txtVolYdM;
		
		private global::Gtk.HButtonBox hbtnboxContData;
		
		private global::Gtk.Button btnCancel;
		
		private global::Gtk.Button btnClose;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget BuildingFormulas.dlgDisplayStoredData
			this.WidthRequest = 800;
			this.HeightRequest = 600;
			this.Name = "BuildingFormulas.dlgDisplayStoredData";
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.BorderWidth = ((uint)(8));
			this.DefaultWidth = 800;
			this.DefaultHeight = 600;
			// Internal child BuildingFormulas.dlgDisplayStoredData.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.tblDataStore = new global::Gtk.Table (((uint)(4)), ((uint)(4)), false);
			this.tblDataStore.WidthRequest = 670;
			this.tblDataStore.HeightRequest = 186;
			this.tblDataStore.Name = "tblDataStore";
			this.tblDataStore.RowSpacing = ((uint)(6));
			this.tblDataStore.ColumnSpacing = ((uint)(6));
			this.tblDataStore.BorderWidth = ((uint)(4));
			// Container child tblDataStore.Gtk.Table+TableChild
			this.lblDepth = new global::Gtk.Label ();
			this.lblDepth.WidthRequest = 142;
			this.lblDepth.HeightRequest = 30;
			this.lblDepth.Name = "lblDepth";
			this.lblDepth.LabelProp = global::Mono.Unix.Catalog.GetString ("Depth:");
			this.tblDataStore.Add (this.lblDepth);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.tblDataStore [this.lblDepth]));
			w2.TopAttach = ((uint)(1));
			w2.BottomAttach = ((uint)(2));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tblDataStore.Gtk.Table+TableChild
			this.lblFeet = new global::Gtk.Label ();
			this.lblFeet.WidthRequest = 159;
			this.lblFeet.HeightRequest = 24;
			this.lblFeet.Name = "lblFeet";
			this.lblFeet.LabelProp = global::Mono.Unix.Catalog.GetString ("Feet");
			this.tblDataStore.Add (this.lblFeet);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.tblDataStore [this.lblFeet]));
			w3.LeftAttach = ((uint)(2));
			w3.RightAttach = ((uint)(3));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tblDataStore.Gtk.Table+TableChild
			this.lblInches = new global::Gtk.Label ();
			this.lblInches.WidthRequest = 159;
			this.lblInches.HeightRequest = 24;
			this.lblInches.Name = "lblInches";
			this.lblInches.LabelProp = global::Mono.Unix.Catalog.GetString ("Inches");
			this.tblDataStore.Add (this.lblInches);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.tblDataStore [this.lblInches]));
			w4.LeftAttach = ((uint)(3));
			w4.RightAttach = ((uint)(4));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tblDataStore.Gtk.Table+TableChild
			this.lblLength = new global::Gtk.Label ();
			this.lblLength.WidthRequest = 142;
			this.lblLength.HeightRequest = 30;
			this.lblLength.Name = "lblLength";
			this.lblLength.LabelProp = global::Mono.Unix.Catalog.GetString ("Length:");
			this.tblDataStore.Add (this.lblLength);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.tblDataStore [this.lblLength]));
			w5.TopAttach = ((uint)(2));
			w5.BottomAttach = ((uint)(3));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tblDataStore.Gtk.Table+TableChild
			this.lblWidth = new global::Gtk.Label ();
			this.lblWidth.WidthRequest = 142;
			this.lblWidth.HeightRequest = 30;
			this.lblWidth.Name = "lblWidth";
			this.lblWidth.LabelProp = global::Mono.Unix.Catalog.GetString ("Width:");
			this.tblDataStore.Add (this.lblWidth);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.tblDataStore [this.lblWidth]));
			w6.TopAttach = ((uint)(3));
			w6.BottomAttach = ((uint)(4));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tblDataStore.Gtk.Table+TableChild
			this.lblYards = new global::Gtk.Label ();
			this.lblYards.WidthRequest = 159;
			this.lblYards.HeightRequest = 24;
			this.lblYards.Name = "lblYards";
			this.lblYards.LabelProp = global::Mono.Unix.Catalog.GetString ("Yards");
			this.tblDataStore.Add (this.lblYards);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.tblDataStore [this.lblYards]));
			w7.LeftAttach = ((uint)(1));
			w7.RightAttach = ((uint)(2));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tblDataStore.Gtk.Table+TableChild
			this.txtDepthFtCm = new global::Gtk.Entry ();
			this.txtDepthFtCm.CanFocus = true;
			this.txtDepthFtCm.Name = "txtDepthFtCm";
			this.txtDepthFtCm.IsEditable = true;
			this.txtDepthFtCm.InvisibleChar = '●';
			this.tblDataStore.Add (this.txtDepthFtCm);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.tblDataStore [this.txtDepthFtCm]));
			w8.TopAttach = ((uint)(1));
			w8.BottomAttach = ((uint)(2));
			w8.LeftAttach = ((uint)(2));
			w8.RightAttach = ((uint)(3));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tblDataStore.Gtk.Table+TableChild
			this.txtDepthInMm = new global::Gtk.Entry ();
			this.txtDepthInMm.CanFocus = true;
			this.txtDepthInMm.Name = "txtDepthInMm";
			this.txtDepthInMm.IsEditable = true;
			this.txtDepthInMm.InvisibleChar = '●';
			this.tblDataStore.Add (this.txtDepthInMm);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.tblDataStore [this.txtDepthInMm]));
			w9.TopAttach = ((uint)(1));
			w9.BottomAttach = ((uint)(2));
			w9.LeftAttach = ((uint)(3));
			w9.RightAttach = ((uint)(4));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tblDataStore.Gtk.Table+TableChild
			this.txtDepthYdM = new global::Gtk.Entry ();
			this.txtDepthYdM.CanFocus = true;
			this.txtDepthYdM.Name = "txtDepthYdM";
			this.txtDepthYdM.IsEditable = true;
			this.txtDepthYdM.InvisibleChar = '●';
			this.tblDataStore.Add (this.txtDepthYdM);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.tblDataStore [this.txtDepthYdM]));
			w10.TopAttach = ((uint)(1));
			w10.BottomAttach = ((uint)(2));
			w10.LeftAttach = ((uint)(1));
			w10.RightAttach = ((uint)(2));
			w10.XOptions = ((global::Gtk.AttachOptions)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tblDataStore.Gtk.Table+TableChild
			this.txtLengthFtCm = new global::Gtk.Entry ();
			this.txtLengthFtCm.CanFocus = true;
			this.txtLengthFtCm.Name = "txtLengthFtCm";
			this.txtLengthFtCm.IsEditable = true;
			this.txtLengthFtCm.InvisibleChar = '●';
			this.tblDataStore.Add (this.txtLengthFtCm);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.tblDataStore [this.txtLengthFtCm]));
			w11.TopAttach = ((uint)(2));
			w11.BottomAttach = ((uint)(3));
			w11.LeftAttach = ((uint)(2));
			w11.RightAttach = ((uint)(3));
			w11.XOptions = ((global::Gtk.AttachOptions)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tblDataStore.Gtk.Table+TableChild
			this.txtLengthInMm = new global::Gtk.Entry ();
			this.txtLengthInMm.CanFocus = true;
			this.txtLengthInMm.Name = "txtLengthInMm";
			this.txtLengthInMm.IsEditable = true;
			this.txtLengthInMm.InvisibleChar = '●';
			this.tblDataStore.Add (this.txtLengthInMm);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.tblDataStore [this.txtLengthInMm]));
			w12.TopAttach = ((uint)(2));
			w12.BottomAttach = ((uint)(3));
			w12.LeftAttach = ((uint)(3));
			w12.RightAttach = ((uint)(4));
			w12.XOptions = ((global::Gtk.AttachOptions)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tblDataStore.Gtk.Table+TableChild
			this.txtLengthYdM = new global::Gtk.Entry ();
			this.txtLengthYdM.CanFocus = true;
			this.txtLengthYdM.Name = "txtLengthYdM";
			this.txtLengthYdM.IsEditable = true;
			this.txtLengthYdM.InvisibleChar = '●';
			this.tblDataStore.Add (this.txtLengthYdM);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.tblDataStore [this.txtLengthYdM]));
			w13.TopAttach = ((uint)(2));
			w13.BottomAttach = ((uint)(3));
			w13.LeftAttach = ((uint)(1));
			w13.RightAttach = ((uint)(2));
			w13.XOptions = ((global::Gtk.AttachOptions)(4));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tblDataStore.Gtk.Table+TableChild
			this.txtWidthFtCm = new global::Gtk.Entry ();
			this.txtWidthFtCm.CanFocus = true;
			this.txtWidthFtCm.Name = "txtWidthFtCm";
			this.txtWidthFtCm.IsEditable = true;
			this.txtWidthFtCm.InvisibleChar = '●';
			this.tblDataStore.Add (this.txtWidthFtCm);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.tblDataStore [this.txtWidthFtCm]));
			w14.TopAttach = ((uint)(3));
			w14.BottomAttach = ((uint)(4));
			w14.LeftAttach = ((uint)(2));
			w14.RightAttach = ((uint)(3));
			w14.XOptions = ((global::Gtk.AttachOptions)(4));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tblDataStore.Gtk.Table+TableChild
			this.txtWidthInMm = new global::Gtk.Entry ();
			this.txtWidthInMm.CanFocus = true;
			this.txtWidthInMm.Name = "txtWidthInMm";
			this.txtWidthInMm.IsEditable = true;
			this.txtWidthInMm.InvisibleChar = '●';
			this.tblDataStore.Add (this.txtWidthInMm);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.tblDataStore [this.txtWidthInMm]));
			w15.TopAttach = ((uint)(3));
			w15.BottomAttach = ((uint)(4));
			w15.LeftAttach = ((uint)(3));
			w15.RightAttach = ((uint)(4));
			w15.XOptions = ((global::Gtk.AttachOptions)(4));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tblDataStore.Gtk.Table+TableChild
			this.txtWidthYdM = new global::Gtk.Entry ();
			this.txtWidthYdM.CanFocus = true;
			this.txtWidthYdM.Name = "txtWidthYdM";
			this.txtWidthYdM.IsEditable = true;
			this.txtWidthYdM.InvisibleChar = '●';
			this.tblDataStore.Add (this.txtWidthYdM);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.tblDataStore [this.txtWidthYdM]));
			w16.TopAttach = ((uint)(3));
			w16.BottomAttach = ((uint)(4));
			w16.LeftAttach = ((uint)(1));
			w16.RightAttach = ((uint)(2));
			w16.XOptions = ((global::Gtk.AttachOptions)(4));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			this.hbox1.Add (this.tblDataStore);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.tblDataStore]));
			w17.Position = 1;
			w17.Expand = false;
			w17.Fill = false;
			this.vbox2.Add (this.hbox1);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox1]));
			w18.Position = 0;
			w18.Expand = false;
			w18.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.table1 = new global::Gtk.Table (((uint)(4)), ((uint)(2)), false);
			this.table1.WidthRequest = 524;
			this.table1.HeightRequest = 186;
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.entry7 = new global::Gtk.Entry ();
			this.entry7.WidthRequest = 348;
			this.entry7.HeightRequest = 30;
			this.entry7.CanFocus = true;
			this.entry7.Name = "entry7";
			this.entry7.IsEditable = false;
			this.entry7.InvisibleChar = '●';
			this.table1.Add (this.entry7);
			global::Gtk.Table.TableChild w19 = ((global::Gtk.Table.TableChild)(this.table1 [this.entry7]));
			w19.TopAttach = ((uint)(2));
			w19.BottomAttach = ((uint)(3));
			w19.LeftAttach = ((uint)(1));
			w19.RightAttach = ((uint)(2));
			w19.XOptions = ((global::Gtk.AttachOptions)(4));
			w19.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.entry8 = new global::Gtk.Entry ();
			this.entry8.WidthRequest = 348;
			this.entry8.HeightRequest = 30;
			this.entry8.CanFocus = true;
			this.entry8.Name = "entry8";
			this.entry8.IsEditable = false;
			this.entry8.InvisibleChar = '●';
			this.table1.Add (this.entry8);
			global::Gtk.Table.TableChild w20 = ((global::Gtk.Table.TableChild)(this.table1 [this.entry8]));
			w20.TopAttach = ((uint)(3));
			w20.BottomAttach = ((uint)(4));
			w20.LeftAttach = ((uint)(1));
			w20.RightAttach = ((uint)(2));
			w20.XOptions = ((global::Gtk.AttachOptions)(4));
			w20.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lblRecPos = new global::Gtk.Label ();
			this.lblRecPos.WidthRequest = 348;
			this.lblRecPos.HeightRequest = 30;
			this.lblRecPos.Name = "lblRecPos";
			this.lblRecPos.LabelProp = global::Mono.Unix.Catalog.GetString ("label11");
			this.table1.Add (this.lblRecPos);
			global::Gtk.Table.TableChild w21 = ((global::Gtk.Table.TableChild)(this.table1 [this.lblRecPos]));
			w21.LeftAttach = ((uint)(1));
			w21.RightAttach = ((uint)(2));
			w21.XOptions = ((global::Gtk.AttachOptions)(4));
			w21.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lblVolFtCm = new global::Gtk.Label ();
			this.lblVolFtCm.WidthRequest = 348;
			this.lblVolFtCm.HeightRequest = 30;
			this.lblVolFtCm.Name = "lblVolFtCm";
			this.lblVolFtCm.LabelProp = global::Mono.Unix.Catalog.GetString ("Feet-Centimeters");
			this.table1.Add (this.lblVolFtCm);
			global::Gtk.Table.TableChild w22 = ((global::Gtk.Table.TableChild)(this.table1 [this.lblVolFtCm]));
			w22.TopAttach = ((uint)(2));
			w22.BottomAttach = ((uint)(3));
			w22.XOptions = ((global::Gtk.AttachOptions)(4));
			w22.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lblVolInMm = new global::Gtk.Label ();
			this.lblVolInMm.WidthRequest = 348;
			this.lblVolInMm.HeightRequest = 30;
			this.lblVolInMm.Name = "lblVolInMm";
			this.lblVolInMm.LabelProp = global::Mono.Unix.Catalog.GetString ("Inches-Millimeters");
			this.table1.Add (this.lblVolInMm);
			global::Gtk.Table.TableChild w23 = ((global::Gtk.Table.TableChild)(this.table1 [this.lblVolInMm]));
			w23.TopAttach = ((uint)(3));
			w23.BottomAttach = ((uint)(4));
			w23.XOptions = ((global::Gtk.AttachOptions)(4));
			w23.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lblVolYdM = new global::Gtk.Label ();
			this.lblVolYdM.WidthRequest = 348;
			this.lblVolYdM.HeightRequest = 30;
			this.lblVolYdM.Name = "lblVolYdM";
			this.lblVolYdM.LabelProp = global::Mono.Unix.Catalog.GetString ("Yards-Meters");
			this.table1.Add (this.lblVolYdM);
			global::Gtk.Table.TableChild w24 = ((global::Gtk.Table.TableChild)(this.table1 [this.lblVolYdM]));
			w24.TopAttach = ((uint)(1));
			w24.BottomAttach = ((uint)(2));
			w24.XOptions = ((global::Gtk.AttachOptions)(4));
			w24.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.txtVolYdM = new global::Gtk.Entry ();
			this.txtVolYdM.WidthRequest = 348;
			this.txtVolYdM.HeightRequest = 30;
			this.txtVolYdM.CanFocus = true;
			this.txtVolYdM.Name = "txtVolYdM";
			this.txtVolYdM.IsEditable = false;
			this.txtVolYdM.InvisibleChar = '●';
			this.table1.Add (this.txtVolYdM);
			global::Gtk.Table.TableChild w25 = ((global::Gtk.Table.TableChild)(this.table1 [this.txtVolYdM]));
			w25.TopAttach = ((uint)(1));
			w25.BottomAttach = ((uint)(2));
			w25.LeftAttach = ((uint)(1));
			w25.RightAttach = ((uint)(2));
			w25.XOptions = ((global::Gtk.AttachOptions)(4));
			w25.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox2.Add (this.table1);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.table1]));
			w26.Position = 1;
			w26.Expand = false;
			w26.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbtnboxContData = new global::Gtk.HButtonBox ();
			this.hbtnboxContData.WidthRequest = 772;
			this.hbtnboxContData.HeightRequest = 60;
			this.hbtnboxContData.Name = "hbtnboxContData";
			this.vbox2.Add (this.hbtnboxContData);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbtnboxContData]));
			w27.Position = 2;
			w27.Expand = false;
			w27.Fill = false;
			w1.Add (this.vbox2);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(w1 [this.vbox2]));
			w28.Position = 0;
			// Internal child BuildingFormulas.dlgDisplayStoredData.ActionArea
			global::Gtk.HButtonBox w29 = this.ActionArea;
			w29.Name = "dialog1_ActionArea";
			w29.Spacing = 10;
			w29.BorderWidth = ((uint)(5));
			w29.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.btnCancel = new global::Gtk.Button ();
			this.btnCancel.WidthRequest = 100;
			this.btnCancel.HeightRequest = 38;
			this.btnCancel.CanDefault = true;
			this.btnCancel.CanFocus = true;
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.UseStock = true;
			this.btnCancel.UseUnderline = true;
			this.btnCancel.BorderWidth = ((uint)(4));
			this.btnCancel.Label = "gtk-cancel";
			this.AddActionWidget (this.btnCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w30 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w29 [this.btnCancel]));
			w30.Expand = false;
			w30.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.btnClose = new global::Gtk.Button ();
			this.btnClose.WidthRequest = 100;
			this.btnClose.HeightRequest = 38;
			this.btnClose.CanDefault = true;
			this.btnClose.CanFocus = true;
			this.btnClose.Name = "btnClose";
			this.btnClose.UseStock = true;
			this.btnClose.UseUnderline = true;
			this.btnClose.BorderWidth = ((uint)(4));
			this.btnClose.Label = "gtk-close";
			this.AddActionWidget (this.btnClose, -7);
			global::Gtk.ButtonBox.ButtonBoxChild w31 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w29 [this.btnClose]));
			w31.Position = 1;
			w31.Expand = false;
			w31.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Show ();
		}
	}
}
