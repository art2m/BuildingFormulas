//  MainWindow.cs
//
//  Author:
//       art2m <art2m@live.com>
//
//  Copyright (c) 2015 art2m
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.

namespace BuildingFormulas
{
	using System;
	using Gtk;
	using degb = DataEntry_GlobalVariables;


	/// <summary>
	/// Main window.
	/// </summary>
	public partial class MainWindow : Gtk.Window
	{
		/// <summary>
		/// The name of the class.
		/// </summary>
		private const string MyMyClassName = "Class: MainWindow";

		/// <summary>
		/// Create object of MyMessages class
		/// </summary>
		private MyMessages myMsg = new MyMessages();

		private Shapes shape = new Shapes();

		/// <summary>
		/// The error message.
		/// </summary>
		private string errMsg = null;

		/// <summary>
		/// Initializes a new instance of the 
		/// <see cref="BuildingFormulas.MainWindow"/> class.
		/// </summary>
		public MainWindow()
			: base(Gtk.WindowType.Toplevel)
		{
			this.Build();
		}

		#region BUTTON AND MENU QUIT PROGRAM

		/// <summary>
		/// Raises the delete event event.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="a">instance containing the event data.</param>
		protected void OnDeleteEvent(object sender, DeleteEventArgs a)
		{
			Application.Quit();
			a.RetVal = true;
		}

		/// <summary>
		/// Raises the quit building formulas action activated event.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">instance containing the event data.</param>
		protected void OnQuitBuildingFormulasActionActivated(
			object sender, 
			EventArgs e)
		{
			Application.Quit();
		}

		/// <summary>
		/// Raises the button quit clicked event.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">instance containing the event data.</param>
		protected void OnBtnQuitClicked(object sender, EventArgs e)
		{
			Application.Quit();
		}

		#endregion END BUTTON AND MENU QUIT PROGRAM

		#region CUBIC SHAPES MENU ITEMS

		/// <summary>
		/// Raises the button cubic area circle action activated event.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">Instance containing the event data.</param>
		protected void OnBtnCubicAreaCircleActionActivated(
			object sender, EventArgs e)
		{
			const string MethodName = "protected void " +
			                                   "OnBtnCubicAreaCircleActionActivated(" +
			                                   "object sender, EventArgs e)";

			try
			{
//                DataEntryWindow dew = new DataEntryWindow();
                
				this.errMsg = "Not Implemented.";
                
				degb.ShapeToSolveFor = shape.CircleShape;

                
//                dew.ShowAll();
//                dew.ShowLabelsForCubicAreaCircleDataEntry();
			}
			catch (NotImplementedException ex)
			{
				this.myMsg.BuildErrorString(
					MyMyClassName, 
					MethodName, 
					this.errMsg,
					ex.ToString());
			}
		}

		/// <summary>
		/// Raises the cubic area cone action activated event.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">instance containing the event data.</param>
		protected void OnCubicAreaConeActionActivated(
			object sender, 
			EventArgs e)
		{
			const string MethodName = 
				"protected void OnCubicAreaConeActionActivated(" +
				"object sender, EventArgs e)";

			ConeVolume cc = new ConeVolume();

			try
			{   
//                DataEntryWindow dew = new DataEntryWindow();

				this.errMsg = "Not Implemented.";

				degb.ShapeToSolveFor = shape.ConeShape;

				cc.ShowAll();

			}
			catch (NotImplementedException ex)
			{
				this.myMsg.BuildErrorString(
					MyMyClassName, 
					MethodName, 
					this.errMsg,
					ex.ToString());
			}
		}

		/// <summary>
		/// Raises the cubic area cylinder action activated event.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">instance containing the event data.</param>
		protected void OnCubicAreaCylinderActionActivated(
			object sender, 
			EventArgs e)
		{  
			const string MethodName = 
				"protected void OnCubicAreaCylinderActionActivated(" +
				"object sender, EventArgs e)";

			try
			{ 
				CylinderVolume cyc = new CylinderVolume();

				this.errMsg = "Not Implemented.";

				degb.ShapeToSolveFor = shape.CylinderShape;

				cyc.ShowAll();

			}
			catch (NotImplementedException ex)
			{
				this.myMsg.BuildErrorString(
					MyMyClassName, 
					MethodName, 
					this.errMsg,
					ex.ToString());
			}
		}

		/// <summary>
		/// Raises the cubic area hexagon action activated event.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">instance containing the event data.</param>
		protected void OnCubicAreaHexagonActionActivated(
			object sender, 
			EventArgs e)
		{
			const string MethodName = "protected void " +
			                                   "OnCubicAreaHexagonActionActivated(" +
			                                   "object sender, EventArgs e)";
			try
			{
//                DataEntryWindow dew = new DataEntryWindow();

				this.errMsg = "Not Implemented.";

				degb.ShapeToSolveFor = shape.HexagonShape;

//                dew.ShowAll();
//                dew.ShowLabelsForCubicAreaHexagonDataEntry();
			}
			catch (NotImplementedException ex)
			{
				this.myMsg.BuildErrorString(
					MyMyClassName, 
					MethodName, 
					this.errMsg,
					ex.ToString());
			}
		}

		/// <summary>
		/// Raises the cubic area octagon action activated event.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">instance containing the event data.</param>
		protected void OnCubicAreaOctagonActionActivated(
			object sender, 
			EventArgs e)
		{
			const string MethodName = "protected void " +
			                                   "OnCubicAreaOctagonActionActivated(" +
			                                   "object sender, EventArgs e)";

			try
			{ 
//                DataEntryWindow dew = new DataEntryWindow();

				this.errMsg = "Not Implemented.";

				degb.ShapeToSolveFor = shape.OctagonShape;

//                dew.ShowAll();
//                dew.ShowLabelForCubicAreaOctagonDataEntry();
			}
			catch (NotImplementedException ex)
			{
				this.myMsg.ShowInformationMessage(ex.ToString());
			}
		}

		/// <summary>
		/// Raises the button pyramid rectangel base clicked event.
		/// </summary>
		/// <param name="sender">The source fo the event.</param>
		/// <param name="e">Instance containing the event data.</param>
		protected void OnBtnPyramidRectangelBaseActionActivated(
			object sender, EventArgs e)
		{
			const string MethodName = "protected void " +
			                                   "OnBtnPyramidRectangelBase" +
			                                   "ActionActivated(" +
			                                   " object sender, EventArgs e)";
			try
			{
//                DataEntryWindow dew = new DataEntryWindow();

				this.errMsg = "Not Implemented.";

				degb.ShapeToSolveFor = shape.PyramidRectangleShape;

//                dew.ShowAll();
//                dew.ShowLabelForCubicAreaPyramidRectangleSquareBaseDataEntry();
			}
			catch (NotImplementedException ex)
			{
				this.myMsg.BuildErrorString(
					MyMyClassName, 
					MethodName, 
					this.errMsg,
					ex.ToString());
			}
		}

		/// <summary>
		/// Raises the button pyramid square base action activated event.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">Instant containing the event data.</param>
		protected void OnBtnPyramidSquareBaseActionActivated(
			object sender, EventArgs e)
		{
			const string MethodName = "protected void " +
			                                   "OnBtnPyramidSquareBaseActionActivated(" +
			                                   "object sender, EventArgs e)";

			try
			{
//                DataEntryWindow dew = new DataEntryWindow();
                
				this.errMsg = "Not Implemented.";
                
				degb.ShapeToSolveFor = shape.PyramidSquareShape;                
//                dew.ShowAll();
//                dew.ShowLabelForCubicAreaPyramidRectangleSquareBaseDataEntry();
			}
			catch (NotImplementedException ex)
			{
				this.myMsg.BuildErrorString(
					MyMyClassName, 
					MethodName, 
					this.errMsg,
					ex.ToString());  
			}
		}

		/// <summary>
		/// Raises the button pyramid with triangle base clicked event.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">Instance containing the event data.</param>
		protected void OnBtnPyramidWithTriangleBaseActionActivated(
			object sender, EventArgs e)
		{
			const string MethodName = "protected void " +
			                                   "OnBtnPyramidWithTriangleBase" +
			                                   "ActionActivatedctivated(" +
			                                   "object sender, EventArgs e)";
           
			try
			{
//                DataEntryWindow dew = new DataEntryWindow();
                
				this.errMsg = "Not Implemented.";
                
				degb.ShapeToSolveFor = shape.PyramidTriangleShape;
                
//                dew.ShowAll();
//                dew.ShowLabelForCubicAreaPyramidTriangleBaseDataEntry();
			}
			catch (NotImplementedException ex)
			{
				this.myMsg.BuildErrorString(
					MyMyClassName, 
					MethodName, 
					this.errMsg,
					ex.ToString());    
			}
		}

		/// <summary>
		/// Raises the cubic area rectangle action activated event.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">instance containing the event data.</param>
		protected void OnCubicAreaRectangleActionActivated(
			object sender, 
			EventArgs e)
		{           
			const string MethodName = "protected void " +
			                                   "OnCubicArea" +
			                                   "RectangleActionActivated(" +
			                                   "object sender, EventArgs e)";
			SquareRectangleVolume sqRecEntData = 
				new SquareRectangleVolume();

			degb.ShapeToSolveFor = shape.RectangleShape;

			sqRecEntData.ShowAll();     
		}

		/// <summary>
		/// Raises the cubic area square action activated event.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">instance containing the event data.</param>
		protected void OnCubicAreaSquareActionActivated(
			object sender, 
			EventArgs e)
		{
			const string MethodName = "protected void " +
			                                   "OnCubicAreaSquareActionActivated(" +
			                                   "object sender, EventArgs e)";
           
			SquareRectangleVolume sqRecEntData = 
				new SquareRectangleVolume();
          
			degb.ShapeToSolveFor = shape.SquareShape;

			sqRecEntData.ShowAll();           
		}

		/// <summary>
		/// Raises the button cubic area triangle action activated event.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">Instance containing the event data.</param>
		protected void OnBtnCubicAreaTriangleActionActivated(
			object sender, EventArgs e)
		{
			const string MethodName = "protected void " +
			                                   "OnBtnCubicAreaTriangleActionActivated(" +
			                                   "object sender, EventArgs e)";
			try
			{               
				degb.ShapeToSolveFor = shape.TriangleShape;

			}
			catch (NotImplementedException ex)
			{
				this.myMsg.ShowInformationMessage(ex.ToString());
			}
		}

		#endregion END CUBIC SHAPES MENU ITEMS

		#region SURFACE AREA MENU ITEMS

		protected void OnMenuCircleSurfaceAreaActivated(
			object sender, 
			EventArgs e)
		{
			degb.ShapeToSolveFor = shape.CircleShape;
		}

		protected void OnMenuCylinderSurfaceAreaActivated(
			object sender, 
			EventArgs e)
		{
			degb.ShapeToSolveFor = shape.CylinderShape;
		}


		protected void OnMenuConeSurfaceAreaActivated(
			object sender, 
			EventArgs e)
		{
			degb.ShapeToSolveFor = shape.ConeShape;
		}

		protected void OnMenuPyramidSurfaceAreaActivated(
			object sender, 
			EventArgs e)
		{

			throw new NotImplementedException();
		}

		protected void OnMenuTriangleSurfaceAreaActivated(
			object sender, 
			EventArgs e)
		{
			degb.ShapeToSolveFor = shape.TriangleShape; 
		}

		protected void OnMenuHexagonSurfaceAreaActivated(
			object sender, 
			EventArgs e)
		{
			degb.ShapeToSolveFor = shape.HexagonShape;
		}

		protected void OnMenuOctagonSurfaceAreaActivated(
			object sender, 
			EventArgs e)
		{
			degb.ShapeToSolveFor = shape.OctagonShape;
		}

		protected void OnMenuRectangleSurfaceAreaActivated(
			object sender, 
			EventArgs e)
		{
			SquareRectangleSurfaceArea sqrSA = 
				new SquareRectangleSurfaceArea();

			degb.ShapeToSolveFor = shape.RectangleShape;

			sqrSA.ShowAll();
		}

		protected void OnMenuSquareSurfaceAreaActivated(
			object sender, 
			EventArgs e)
		{
			SquareRectangleSurfaceArea sqrSA = 
				new SquareRectangleSurfaceArea();

			degb.ShapeToSolveFor = shape.SquareShape;
           
			sqrSA.ShowAll();
		}

		#endregion SURFACE AREA MENU ITEMS
	}
}
