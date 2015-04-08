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
        private const string ClassName = "Class: MainWindow";

        /// <summary>
        /// Create object of MyMessages class
        /// </summary>
        private MyMessages myMsg = new MyMessages();

        /// <summary>
        /// The dew.
        /// </summary>
        private DataEntryWindow dew = new DataEntryWindow();

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
                DataEntryWindow dew = new DataEntryWindow();
                
                this.errMsg = "Not Implemented.";
                
                degb.ShapeToSolveFor = "circle";
                degb.SolveForFormulas = "cubic";
                
                dew.ShowAll();
                dew.ShowLabelsForCubicAreaCircleDataEntry();
            }
            catch (NotImplementedException ex)
            {
                this.myMsg.BuildErrorString(
                    ClassName, 
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
            const string MethodName = "protected void " +
                                      "OnCubicAreaConeActionActivated(" +
                                      "object sender, EventArgs e)";

            try
            {   
                DataEntryWindow dew = new DataEntryWindow();

                this.errMsg = "Not Implemented.";

                degb.ShapeToSolveFor = "cone";
                degb.SolveForFormulas = "cubic";

                dew.ShowAll();
                dew.ShowLabelsForCubicAreaConeDataEntry();
            }
            catch (NotImplementedException ex)
            {
                this.myMsg.BuildErrorString(
                    ClassName, 
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
            const string MethodName = "protected void " +
                                      "OnCubicAreaCylinderActionActivated(" +
                                      "object sender, EventArgs e)";

            try
            { 
                DataEntryWindow dew = new DataEntryWindow();

                this.errMsg = "Not Implemented.";

                degb.ShapeToSolveFor = "cylinder";
                degb.SolveForFormulas = "cubic";

                dew.ShowAll();
                dew.ShowLabelsForCubicAreaCylinderDataEntry();
            }
            catch (NotImplementedException ex)
            {
                this.myMsg.BuildErrorString(
                    ClassName, 
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
                DataEntryWindow dew = new DataEntryWindow();

                this.errMsg = "Not Implemented.";

                degb.ShapeToSolveFor = "hexagon";
                degb.SolveForFormulas = "cubic";

                dew.ShowAll();
                dew.ShowLabelsForCubicAreaHexagonDataEntry();
            }
            catch (NotImplementedException ex)
            {
                this.myMsg.BuildErrorString(
                    ClassName, 
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
                DataEntryWindow dew = new DataEntryWindow();

                this.errMsg = "Not Implemented.";

                degb.ShapeToSolveFor = "octagon";
                degb.SolveForFormulas = "cubic";

                dew.ShowAll();
                dew.ShowLabelForCubicAreaOctagonDataEntry();
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
                DataEntryWindow dew = new DataEntryWindow();

                this.errMsg = "Not Implemented.";

                degb.ShapeToSolveFor = "pyramid-rectangle";
                degb.SolveForFormulas = "cubic";

                dew.ShowAll();
                dew.ShowLabelForCubicAreaPyramidRectangleSquareBaseDataEntry();
            }
            catch (NotImplementedException ex)
            {
                this.myMsg.BuildErrorString(
                    ClassName, 
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
                DataEntryWindow dew = new DataEntryWindow();
                
                this.errMsg = "Not Implemented.";
                
                degb.ShapeToSolveFor = "pyramid-square";
                degb.SolveForFormulas = "cubic";
                
                dew.ShowAll();
                dew.ShowLabelForCubicAreaPyramidRectangleSquareBaseDataEntry();
            }
            catch (NotImplementedException ex)
            {
                this.myMsg.BuildErrorString(
                    ClassName, 
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
                DataEntryWindow dew = new DataEntryWindow();
                
                this.errMsg = "Not Implemented.";
                
                degb.ShapeToSolveFor = "pyramid-triangle";
                degb.SolveForFormulas = "cubic";
                
                dew.ShowAll();
                dew.ShowLabelForCubicAreaPyramidTriangleBaseDataEntry();
            }
            catch (NotImplementedException ex)
            {
                this.myMsg.BuildErrorString(
                    ClassName, 
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
            try
            {
                DataEntryWindow dew = new DataEntryWindow();

                degb.ShapeToSolveFor = "rectangle";
                degb.SolveForFormulas = "cubic";

                dew.ShowAll();
                dew.ShowLabelsForCubicAreaRectangleSquareDataEntry();              
            }
            catch (NotImplementedException ex)
            {
                this.myMsg.ShowInformationMessage(ex.ToString()); 
            }
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

            try
            {


                degb.ShapeToSolveFor = "square";
                degb.SolveForFormulas = "cubic";

                dew.ShowAll();
                dew.ShowLabelsForCubicAreaRectangleSquareDataEntry();
            }
            catch (NotImplementedException ex)
            {
                this.myMsg.ShowInformationMessage(ex.ToString());
            }
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
                DataEntryWindow dew = new DataEntryWindow();  

                degb.ShapeToSolveFor = "triangle";
                degb.SolveForFormulas = "cubic";

                dew.ShowAll();
                dew.ShowLabelsForCubicAreaTriangleDataEntry();
            }
            catch (NotImplementedException ex)
            {
                this.myMsg.ShowInformationMessage(ex.ToString());
            }
        }

        #endregion END CUBIC SHAPES MENU ITEMS
    }
}
