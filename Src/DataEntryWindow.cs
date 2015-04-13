﻿
//  DataEntryWindow.cs
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
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
namespace BuildingFormulas
{
    using System;
    using degb = DataEntry_GlobalVariables;
    using rss = RectangleSquareSolve;

    /// <summary>
    /// Data entry window.
    /// </summary>
    public partial class DataEntryWindow : Gtk.Window
    {
        /// <summary>
        /// The name of the class.
        /// </summary>
        private const string ClassName = 
            "public partial class DataEntryWindow : Gtk.Window";

        /// <summary>
        /// The name of the method.
        /// </summary> 
        private string methodName;

        /// <summary>
        /// My message.
        /// </summary> 
        private MyMessages myMsg = new MyMessages();

        /// <summary>
        /// Create object of class ValidateData.
        /// </summary>
        private ValidateData vd = new ValidateData();

        /// <summary>
        /// The state of the solve.
        /// If true then solve button depresed by user.
        /// We are going to solve for the entered data.
        /// If false then we are currently filling the
        /// labels with information telling user what
        /// data they need to enter.
        /// </summary>
        private bool solveState = false;

        /// <summary>
        /// The error message.
        /// </summary>
        private string errMsg = null;

        /// <summary>
        /// Initializes a new instance of the 
        /// <see cref="BuildingFormulas.DataEntryWindow"/> class.
        /// </summary>
        public DataEntryWindow()
            : base(Gtk.WindowType.Toplevel)
        {
            this.Build();  
        }

        #region SHOW LABELS FOR CUBIC AREA SHAPES

        /// <summary>
        /// Shows the labels for cubic area circle data entry.
        /// </summary>
        public void ShowLabelsForCubicAreaCircleDataEntry()
        {
            lblYards.Visible = true;
            lblFeet.Visible = true;
            lblInches.Visible = true;
            lblCubicYards.Visible = true;
            lblCubicFeet.Visible = true;
            lblCubicInches.Visible = true;
            lblEnter1.Visible = true;
            lblEnter2.Visible = true;
            lblEnter3.Visible = false;

            this.FillLabelsForCubicAreaCircle();
            this.ShowTextBoxesForCubicAreCircleDataEntry();
        }

        /// <summary>
        /// Shows the labels for cubic area cone data entry.
        /// </summary>
        public void ShowLabelsForCubicAreaConeDataEntry()
        {
            lblYards.Visible = true;
            lblFeet.Visible = true;
            lblInches.Visible = true;
            lblCubicYards.Visible = true;
            lblCubicFeet.Visible = true;
            lblCubicInches.Visible = true;
            lblEnter1.Visible = true;
            lblEnter2.Visible = true;
            lblEnter3.Visible = false;

            this.FillLabelsForCubicAreaCone();
            this.ShowTextBoxesForCubicAreaConeDataEntry();
        }

        /// <summary>
        /// Shows the labels for cubic area cylinder data entry.
        /// </summary>
        public void ShowLabelsForCubicAreaCylinderDataEntry()
        {
            lblYards.Visible = true;
            lblFeet.Visible = true;
            lblInches.Visible = true;
            lblCubicYards.Visible = true;
            lblCubicFeet.Visible = true;
            lblCubicInches.Visible = true;
            lblEnter1.Visible = true;
            lblEnter2.Visible = true;
            lblEnter3.Visible = false;

            this.FillLabelsForCubicAreaCylinder();
            this.ShowTextBoxesForCubicAreaCylinderDataEntry();
        }

        /// <summary>
        /// Shows the labels for cubic area hexagon data entry.
        /// </summary>
        public void ShowLabelsForCubicAreaHexagonDataEntry()
        {
            this.FillLabelsForCubicAreaHexagon();
            this.ShowTextBoxesForCubicAreaHexagonDataEntry();
        }

        /// <summary>
        /// Shows the label for cubic area octagon data entry.
        /// </summary>
        public void ShowLabelForCubicAreaOctagonDataEntry()
        {
            this.FillLabelsForCubicAreaOctagon();
            this.ShowTextBoxesForCubicAreaOctagonDataEntry();
        }

        /// <summary>
        /// Shows the label for cubic area pyramid rectangle 
        /// square base data entry.
        /// </summary>
        public void ShowLabelForCubicAreaPyramidRectangleSquareBaseDataEntry()
        {
            lblYards.Visible = true;
            lblFeet.Visible = true;
            lblInches.Visible = true;
            lblCubicYards.Visible = true;
            lblCubicFeet.Visible = true;
            lblCubicInches.Visible = true;
            lblEnter1.Visible = true;
            lblEnter2.Visible = true;
            lblEnter3.Visible = true;

            this.FillLabelsForCubicAreaPyramidRectangleSquareBase();
            this.ShowTextBoxesForCubicAreaPyramidRectangleSquareBaseDataEntry();
        }

        /// <summary>
        /// Shows the label for cubic area pyramid triangle base data entry.
        /// </summary>
        public void ShowLabelForCubicAreaPyramidTriangleBaseDataEntry()
        {
            this.FillLabelsForCubicAreaPyramidTriangleBase();
            this.ShowTextBoxesForCubicAreaPyramidTriangleBase();
        }

        /// <summary>
        /// Shows the labels for cubic area rectangle square data entry.
        /// Hide any labels not needed.
        /// </summary>
        public void ShowLabelsForCubicAreaRectangleSquareDataEntry()
        {
            lblYards.Visible = true;
            lblFeet.Visible = true;
            lblInches.Visible = true;
            lblCubicYards.Visible = true;
            lblCubicFeet.Visible = true;
            lblCubicInches.Visible = true;
            lblEnter1.Visible = true;
            lblEnter2.Visible = true;
            lblEnter3.Visible = true;

            this.FillLabelsForCubicAreaRectagleSquare();
            this.ShowTextBoxesForCubicAreaRectangleSquareDataEntry();
        }

        /// <summary>
        /// Shows the labels for cubic area triangle data entry.
        /// </summary>
        public void ShowLabelsForCubicAreaTriangleDataEntry()
        {
            lblYards.Visible = true;
            lblFeet.Visible = true;
            lblInches.Visible = true;
            lblCubicYards.Visible = true;
            lblCubicFeet.Visible = true;
            lblCubicInches.Visible = true;
            lblEnter1.Visible = true;
            lblEnter2.Visible = true;
            lblEnter3.Visible = true;
            this.FillLabelsForCubicAreaTriangle();
            this.ShowTextBoxesForCubicAreaTriangleDataEntry();
        }

        #endregion SHOW LABELS FOR CUBIC AREA SHAPES

        #region BUTTON CLICK EVENTS

        /// <summary>
        /// Raises the button close event.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">instance containing the event data.</param>
        protected void OnBtnClose(object sender, EventArgs e)
        {
            this.Destroy();
        }

        /// <summary>
        /// Raises the button solve clicked event.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Instance containing the event data.</param>
        protected void OnBtnSolveClicked(object sender, EventArgs e)
        {
            this.solveState = true;

            // Starts the solve for formula.
            this.CubicAreaShape();
        }

        /// <summary>
        /// Raises the button store result clicked event.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Instance containing the event data.</param>
        protected void OnBtnStoreResultClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Raises the button display stored clicked event.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Instance containing the event data.</param>
        protected void OnBtnDisplayStoredClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Raises the button clear stored clicked event.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Instance containing the event data.</param>
        protected void OnBtnClearStoredClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Raises the button metric clicked event.
        /// </summary>
        /// <param name="sender">"The source of the event.">Sender.</param>
        /// <param name="e">Instance containing the event data.</param>
        protected void OnBtnMetricClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Raises the button standard clicked event.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Instance containing the event data.</param>
        protected void OnBtnStandardClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Raises the button clear form clicked event.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Instance containing the event data.</param>
        protected void OnBtnClearFormClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Raises the button print form clicked event.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Instance containing the event data.</param>
        protected void OnBtnPrintFormClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Raises the button print stored clicked event.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Instance containing the event data.</param>
        protected void OnBtnPrintStoredClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Raises the button save form clicked event.
        /// </summary>
        /// <param name="sender">The source fo the event.</param>
        /// <param name="e">Instance containing the event data.</param>
        protected void OnBtnSaveFormClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Checks for match to cubic area.
        /// </summary>
        /// <returns><c>true</c>, if for match to cubic area was checked, 
        /// <c>false</c> otherwise.</returns>
        private bool CheckForMatchToCubicArea()
        {
            bool retVal = false;
            int val = 0;

            val = string.Compare(
                degb.CubicAreaCompare,
                degb.SolveForFormulas, 
                true);

            if (val != 0)
            {   
                retVal = false;
                return retVal;
            }

            retVal = true;
            return retVal;           
        }

        #endregion BUTTON CLICK EVENTS

        #region FIND CUBIC AREA SHAPE TO SOLVE FOR

        /// <summary>
        /// Cubics the area shape.
        /// </summary>
        private void CubicAreaShape()
        {
            const int Match = 0; 

            if (string.Compare(
                    degb.CircleCompare,
                    degb.ShapeToSolveFor) == Match)
            {
                this.SolveForCubicAreaCircle();      
            }
            else if (string.Compare(
                         degb.ConeCompare, 
                         degb.ShapeToSolveFor) == Match)
            {
                this.SolveForCubicAreaCone();
            }
            else if (string.Compare(
                         degb.CylinderCompare, 
                         degb.ShapeToSolveFor) == Match)
            {
                this.SolveForCubicAreaCylinder();     
            }
            else if (string.Compare(
                         degb.HexagonCompare, 
                         degb.ShapeToSolveFor) == Match)
            {
                this.SolveForCubicAreaHexagon();
            }
            else if (string.Compare(
                         degb.OcatagonCompare, 
                         degb.ShapeToSolveFor) == Match)
            {
                this.SolveForCubicAreaOctagon();           
            }
            else if (string.Compare(
                         degb.PyramidRectangleCompare, 
                         degb.ShapeToSolveFor) == Match)
            {
                this.SolveForCubicAreaPyramidRectangleBase();
            }
            else if (string.Compare(
                         degb.PyramidTriangleCompare,
                         degb.ShapeToSolveFor) == Match)
            {
                this.SolveForCubicAreaPyramidTriangleBase();           
            }
            else if (string.Compare(
                         degb.RectangleCompare, 
                         degb.ShapeToSolveFor) == Match)
            {
                this.SolveForCubicAreaRectangle();
            }
            else if (string.Compare(
                         degb.SquareCompare, 
                         degb.ShapeToSolveFor) == Match)
            {
                this.SolveForCubicAreaSquare();          
            }
            else if (string.Compare(
                         degb.TriangleCompare,
                         degb.ShapeToSolveFor) == Match)
            {
                this.SolveForCubicAreaTriangle();
            }
            else
            {
                throw new NotImplementedException();
            }                  
        }

        #endregion FIND CUBIC AREA SHAPE TO SOLVE FOR

        #region FILL LABELS FOR CUBIC AREA FORMULAS

        /// <summary>
        /// Fills the labels for cubic area circle.
        /// </summary>
        private void FillLabelsForCubicAreaCircle()
        {
            lblYards.Text = degb.YardsLabelCaption;
            lblFeet.Text = degb.FeetLabelCaption;
            lblInches.Text = degb.InchesLabelCaption;
            lblEnter1.Text = degb.DiameterLabelCaption;
            lblEnter2.Text = degb.HeightLabelCaption;
            lblCubicYards.Text = degb.AreaInCubicYardsLabelCaption;
            lblCubicFeet.Text = degb.AreaInCubicFeetLabelCaption;
            lblCubicInches.Text = degb.AreaInCubicInchesLabelCaption;
        }

        /// <summary>
        /// Fills the labels for cubic area cone.
        /// </summary>
        private void FillLabelsForCubicAreaCone()
        {
            lblYards.Text = degb.YardsLabelCaption;
            lblFeet.Text = degb.FeetLabelCaption;
            lblInches.Text = degb.InchesLabelCaption;
            lblEnter1.Text = degb.DiameterLabelCaption;
            lblEnter2.Text = degb.SlantHeightLabelCaption;
            lblCubicYards.Text = degb.AreaInCubicYardsLabelCaption;
            lblCubicFeet.Text = degb.AreaInCubicFeetLabelCaption;
            lblCubicInches.Text = degb.AreaInCubicInchesLabelCaption;
        }

        /// <summary>
        /// Fills the labels for cubic area cylinder.
        /// </summary>
        private void FillLabelsForCubicAreaCylinder()
        {
            lblYards.Text = degb.YardsLabelCaption;
            lblFeet.Text = degb.FeetLabelCaption;
            lblInches.Text = degb.InchesLabelCaption;
            lblEnter1.Text = degb.DiameterLabelCaption;
            lblEnter2.Text = degb.HeightLabelCaption;
            lblCubicYards.Text = degb.AreaInCubicYardsLabelCaption;
            lblCubicFeet.Text = degb.AreaInCubicFeetLabelCaption;
            lblCubicInches.Text = degb.AreaInCubicInchesLabelCaption;
        }

        /// <summary>
        /// Fills the labels for cubic area hexagon.
        /// </summary>
        private void FillLabelsForCubicAreaHexagon()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Fills the labels for cubic area octagon.
        /// </summary>
        private void FillLabelsForCubicAreaOctagon()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Fills the labels for cubic area pyramid.
        /// </summary>
        private void FillLabelsForCubicAreaPyramidRectangleSquareBase()
        {
            // Holds yards, feet, inches caption.
            lblYards.Text = degb.YardsLabelCaption;
            lblFeet.Text = degb.FeetLabelCaption;
            lblInches.Text = degb.InchesLabelCaption;

            // Holds measurements entered by user.
            lblEnter1.Text = degb.LengthLabelCaption;
            lblEnter2.Text = degb.WidthLabelCaption;
            lblEnter3.Text = degb.HeightLabelCaption;

            // Holds cubic area sum.
            lblCubicYards.Text = degb.AreaInCubicYardsLabelCaption;
            lblCubicFeet.Text = degb.AreaInCubicFeetLabelCaption;
            lblCubicInches.Text = degb.AreaInCubicInchesLabelCaption;
        }

        /// <summary>
        /// Fills the labels for cubic area pyramid triangle base.
        /// </summary>
        private void FillLabelsForCubicAreaPyramidTriangleBase()
        {
            // Holds yards, feet, inches caption.
            lblYards.Text = degb.YardsLabelCaption;
            lblFeet.Text = degb.FeetLabelCaption;
            lblInches.Text = degb.InchesLabelCaption;

            // Holds measurements entered by user.
            lblEnter1.Text = degb.LengthLabelCaption;
            lblEnter2.Text = degb.WidthLabelCaption;
            lblEnter3.Text = degb.HeightLabelCaption;

            // Holds cubic area sum.
            lblCubicYards.Text = degb.AreaInCubicYardsLabelCaption;
            lblCubicFeet.Text = degb.AreaInCubicFeetLabelCaption;
            lblCubicInches.Text = degb.AreaInCubicInchesLabelCaption;
        }

        /// <summary>
        /// Fills the labels for cubic area rectagle.
        /// </summary>
        private void FillLabelsForCubicAreaRectagleSquare()
        {
            // Holds yards, feet inches caption.
            lblYards.Text = degb.YardsLabelCaption;
            lblFeet.Text = degb.FeetLabelCaption;
            lblInches.Text = degb.InchesLabelCaption;

            // Holds measurements entered by user.
            lblEnter1.Text = degb.DepthLabelCaption;
            lblEnter2.Text = degb.LengthLabelCaption;
            lblEnter3.Text = degb.WidthLabelCaption;

            // Holds cubic area sum.
            lblCubicYards.Text = degb.AreaInCubicYardsLabelCaption;
            lblCubicFeet.Text = degb.AreaInCubicFeetLabelCaption;
            lblCubicInches.Text = degb.AreaInCubicInchesLabelCaption;
        }

        /// <summary>
        /// Fills the labels for cubic area triangle.
        /// </summary>
        private void FillLabelsForCubicAreaTriangle()
        {
            // Holds yards, feet inches caption.
            lblYards.Text = degb.YardsLabelCaption;
            lblFeet.Text = degb.FeetLabelCaption;
            lblInches.Text = degb.InchesLabelCaption;

            // Holds measurements entered by user.
            lblEnter1.Text = degb.BaseLabelCaption;
            lblEnter2.Text = degb.HeightLabelCaption;
            lblEnter3.Text = degb.DepthLabelCaption;

            // Holds cubic area sum.
            lblCubicYards.Text = degb.AreaInCubicYardsLabelCaption;
            lblCubicFeet.Text = degb.AreaInCubicFeetLabelCaption;
            lblCubicInches.Text = degb.AreaInCubicInchesLabelCaption;
        }

        #endregion FILL LABELS FOR CUBIC AREA FORMULAS

        #region SHOW ENTRY BOXES FOR CUBIC AREA SHAPES

        /// <summary>
        /// Shows the text boxes for cubic are circle data entry.
        /// </summary>
        private void ShowTextBoxesForCubicAreCircleDataEntry()
        {
            // Holds diameter
            txtBoxYard1.Visible = true;
            txtBoxFeet1.Visible = true;
            txtBoxInches1.Visible = true;

            // Holds height.
            txtBoxYard2.Visible = true;
            txtBoxFeet2.Visible = true;
            txtBoxInches2.Visible = true;

            // Not used.
            txtBoxYard3.Visible = false;
            txtBoxFeet3.Visible = false;
            txtBoxInches3.Visible = false;

            // Holds cubic area sum.
            txtCubicYards.Visible = true;
            txtCubicFeet.Visible = true;
            txtCubicInches.Visible = true;
        }

        /// <summary>
        /// Shows the text boxes for cubic area cone data entry.
        /// </summary>
        private void ShowTextBoxesForCubicAreaConeDataEntry()
        {
            // Holds diameter.
            txtBoxYard1.Visible = true;
            txtBoxFeet1.Visible = true;
            txtBoxInches1.Visible = true;

            // Holds height.
            txtBoxYard2.Visible = true;
            txtBoxFeet2.Visible = true;
            txtBoxInches2.Visible = true;

            // Not used.
            txtBoxYard3.Visible = false;
            txtBoxFeet3.Visible = false;
            txtBoxInches3.Visible = false;

            // Holds cubic area sum.
            txtCubicYards.Visible = true;
            txtCubicFeet.Visible = true;
            txtCubicInches.Visible = true;
        }

        /// <summary>
        /// Shows the text boxes for cubic area cylinder data entry.
        /// </summary>
        private void ShowTextBoxesForCubicAreaCylinderDataEntry()
        {
            // Holds diameter.
            txtBoxYard1.Visible = true;
            txtBoxFeet1.Visible = true;
            txtBoxInches1.Visible = true;

            // Holds height
            txtBoxYard2.Visible = true;
            txtBoxFeet2.Visible = true;
            txtBoxInches2.Visible = true;

            // Not used.
            txtBoxYard3.Visible = false;
            txtBoxFeet3.Visible = false;
            txtBoxInches3.Visible = false;

            // Holds cubic area sum
            txtCubicYards.Visible = true;
            txtCubicFeet.Visible = true;
            txtCubicInches.Visible = true;
        }

        /// <summary>
        /// Shows the text boxes for cubic area hexagon data entry.
        /// </summary>
        private void ShowTextBoxesForCubicAreaHexagonDataEntry()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Shows the text boxes for cubic area octagon data entry.
        /// </summary>
        private void ShowTextBoxesForCubicAreaOctagonDataEntry()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Shows the text boxes for cubic area pyramid data entry.
        /// </summary>
        private void 
ShowTextBoxesForCubicAreaPyramidRectangleSquareBaseDataEntry()
        {
            const string MethodName = 
                "private void ShowTextBoxesForCubicArea" +
                "PyramidRectangleSquareBaseDataEntry()";

            // Holds length
            txtBoxYard1.Visible = true;
            txtBoxFeet1.Visible = true;
            txtBoxInches1.Visible = true;

            // Holds width
            txtBoxYard2.Visible = true;
            txtBoxFeet2.Visible = true;
            txtBoxInches2.Visible = true;

            // Holds height
            txtBoxYard3.Visible = true;
            txtBoxFeet3.Visible = true;
            txtBoxInches3.Visible = true;

            // Holds cubic area sum
            txtCubicYards.Visible = true;
            txtCubicFeet.Visible = true;
            txtCubicInches.Visible = true;
        }

        /// <summary>
        /// Shows the text boxes for cubic area pyramid triangle base.
        /// </summary>
        private void ShowTextBoxesForCubicAreaPyramidTriangleBase()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Shows the text boxes for cubic area rectangle square data entry.
        /// Hide any text boxes not needed.
        /// </summary>
        private void ShowTextBoxesForCubicAreaRectangleSquareDataEntry()
        {
            // Holds depth 
            txtBoxYard1.Visible = true;
            txtBoxFeet1.Visible = true;           
            txtBoxInches1.Visible = true;

            // Holds length
            txtBoxYard2.Visible = true;
            txtBoxFeet2.Visible = true;
            txtBoxInches2.Visible = true;

            // Holds width
            txtBoxYard3.Visible = true;
            txtBoxFeet3.Visible = true;
            txtBoxInches3.Visible = true;

            // Holds cubic area sum
            txtCubicYards.Visible = true;
            txtCubicFeet.Visible = true;
            txtCubicInches.Visible = true;
        }

        /// <summary>
        /// Shows the text boxes for cubic area triangle data entry.
        /// </summary>
        private void ShowTextBoxesForCubicAreaTriangleDataEntry()
        {
            // Holds base 
            txtBoxYard1.Visible = true;
            txtBoxFeet1.Visible = true;           
            txtBoxInches1.Visible = true;

            // Holds length
            txtBoxYard2.Visible = true;
            txtBoxFeet2.Visible = true;
            txtBoxInches2.Visible = true;

            // Holds depth
            txtBoxYard3.Visible = true;
            txtBoxFeet3.Visible = true;
            txtBoxInches3.Visible = true;

            // Holds cubic area sum
            txtCubicYards.Visible = true;
            txtCubicFeet.Visible = true;
            txtCubicInches.Visible = true;
        }

        #endregion SHOW ENTRY BOXES FOR CUBIC AREA SHAPES

        #region SOLVE FOR CUBIC AREA SHAPES

        /// <summary>
        /// Solves for cubic area circle.
        /// </summary>
        private void SolveForCubicAreaCircle()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Solves for cubic area cone.
        /// </summary>
        private void SolveForCubicAreaCone()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Solves for cubic area cylinder.
        /// </summary>
        private void SolveForCubicAreaCylinder()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Solves for cubic area hexagon.
        /// </summary>
        private void SolveForCubicAreaHexagon()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Solves for cubic area octagon.
        /// </summary>
        private void SolveForCubicAreaOctagon()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Solves for cubic area pyramid rectangle base.
        /// </summary>
        private void SolveForCubicAreaPyramidRectangleBase()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Solves for cubic area pyramid triangle base.
        /// </summary>
        private void SolveForCubicAreaPyramidTriangleBase()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Solves for cubic area rectangle.
        /// </summary>
        private void SolveForCubicAreaRectangle()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Solves for cubic area square.
        /// </summary>
        private void SolveForCubicAreaSquare()
        {
            bool val = false;
            // this.ClearDataFromRectangleSquareSolve();
            // Check For data in boxes. Put 0 if none found.
            val = this.ValidateCubicAreaYardsSquareShape();

            if (!val)
            {
                return; 
            }

            val = this.ValidateCubicAreaFeetSquareShape();
            if (!val)
            {
                return;
            }

            val = this.ValidateCubicAreaInchesSquareShape();

            // Check that all boxes have a numeric value.
            if (!val)
            {
                return;
            }

            val = this.ValidateCubicSquareDepthYardNumeric();
            if (!val)
            {
                return;
            }

            val = this.ValidateCubicSquareDepthFeetNumeric();
            if (!val)
            {
                return;
            }

            val = this.ValidateCubicSquareDepthInchesNumeric();           
            if (!val)
            {
                return;
            }

            val = this.ValidateCubicSquareLengthYardsNumeric();
            if (!val)
            {
                return;
            }

            val = this.ValidateCubicSquareLengthFeetNumeric();
            if (!val)
            {
                return;
            }

            val = this.ValidateCubicSquareLengthInchesNumeric();
            if (!val)
            {
                return;
            }

            val = this.ValidateCubicSquareWidthYardsNumeric();
            if (!val)
            {
                return;
            }

            val = this.ValidateCubicSquardWidthFeetNumeric();
            if (!val)
            {
                return;
            }

            val = this.ValidateCubicSquareWidthInchesNumeric();
            if (!val)
            {
                return;
            }
        }

        /// <summary>
        /// Solves for cubic area triangle.
        /// </summary>
        private void SolveForCubicAreaTriangle()
        {
            throw new NotImplementedException();
        }

        #endregion SOLVE FOR CUBIC AREA SHAPES

        #region VALIDATE CUBIC AREA SQUARE RECTANGLE

        /// <summary>
        /// Validates the cubic area yards square shape.
        /// </summary>
        /// <returns><c>true</c>, if cubic area yards 
        /// square shape was validated, <c>false</c> 
        /// otherwise.</returns>
        private bool ValidateCubicAreaYardsSquareShape()
        {
            bool retVal = false;

            // Depth settings for squard.
            retVal = this.ValidateDepthYardsStringValueNotEmpty();
            if (!retVal)
            {
                // Error in called function user must fix
                return retVal;
            }

            retVal = this.ValidateLengthYardsStringValueNotEmpty();
            if (!retVal)
            {
                // Error in called function user must fix.
                return retVal;
            }

            retVal = this.ValidateWidthYardsStringValueNotEmpty();
            if (!retVal)
            {
                // Error in called function user must fix.
                return retVal;
            }

            // rss.RectangleDepthInYards = 

            // rss.RectangleDepthInFeet =            

            // rss.RectangleDepthInInches =           

            // Length settings for square. 
            return retVal = true;
        }

        /// <summary>
        /// Validates the cubic area feet square shape.
        /// </summary>
        /// <returns><c>true</c>, if cubic area feet 
        /// square shape was validated, <c>false</c> 
        /// otherwise.</returns>
        private bool ValidateCubicAreaFeetSquareShape()
        {
            bool retVal = false;

            retVal = this.ValidateDepthFeetStringValueNotEmpty();
            if (!retVal)
            {
                // Error in called function user must fix
                return retVal;
            }

            retVal = this.ValidateLengthFeetStringValueNotEmpty();
            if (!retVal)
            {
                // Error in called function user must fix.
                return retVal;
            }

            retVal = this.ValidateWidthFeetStringValueNotEmpty();
            if (!retVal)
            {
                // Error in called function user must fix.
                return retVal;
            }

            return retVal = true;
        }

        /// <summary>
        /// Validates the cubic area inches square shape.
        /// </summary>
        /// <returns><c>true</c>, if cubic area inches square 
        /// shape was validated, <c>false</c> otherwise.</returns>
        private bool ValidateCubicAreaInchesSquareShape()
        {
            bool retVal = false;

            retVal = this.ValidateDepthInchesStringValueNotEmpty();
            if (!retVal)
            {
                // Error in called function user must fix.
                return retVal;
            }

            retVal = this.ValidateLengthInchesStringValueNotEmpty();
            if (!retVal)
            {
                // Error in called function user must fix.
                return retVal;
            }

            retVal = this.ValidateWidthInchesStringValueNotEmpty();
            if (!retVal)
            {
                // Error in called function user must fix.
                return retVal;
            }

            return retVal = true;
        }

        /// <summary>
        /// Clears the data from rectangle square solve.
        /// </summary>
        private void ClearDataFromRectangleSquareSolve()
        {
            rss.RectangleDepthInYards = 0;
            rss.RectangleDepthInFeet = 0;
            rss.RectangleDepthInInches = 0;
            rss.RectangleLengthInYards = 0;
            rss.RectangleLengthInFeet = 0;
            rss.RectangleLengthInInches = 0;
            rss.RectangleWidthInYards = 0;
            rss.RectangleWidthInFeet = 0;
            rss.RectangleWidthInInches = 0;
            rss.CubicYardsInCubicRectangle = 0;
            rss.CubicFeetInCubicRectangle = 0;
            rss.CubicInchesInCubicRectangle = 0;
        }

        /// <summary>
        /// Validates the depth yards string value.
        /// </summary>
        /// <returns><c>true</c>, if depth yards string 
        /// value was validated, <c>false</c> 
        /// otherwise.</returns>
        private bool ValidateDepthYardsStringValueNotEmpty()
        {
            bool retVal = false;

            try
            {
                this.methodName = "private void " +
                "ValidateTextBoxOneYardsStringValue()";

                txtBoxYard1.Text = txtBoxYard1.Text.Trim();

                // Check to see if box is empty.
                retVal = this.vd.ValidateDataExists(txtBoxYard1.Text);
                if (retVal)
                {
                    return retVal;     
                }
                else
                {
                    // Place a zero in textbox and return true.
                    txtBoxYard1.Text = "0";
                    return retVal = true;
                }
            }
            catch (FormatException ex)
            {
                this.errMsg = degb.DepthName +
                " in yards entry not a valid numeric value."; 
                this.myMsg.BuildErrorString(
                    ClassName, 
                    this.methodName, 
                    this.errMsg,
                    ex.ToString());

                // Error so return false.
                return retVal;
            }
            catch (OverflowException ex)
            {
                this.errMsg = degb.DepthName +
                " in yards entry numeric value is to large.";
                this.myMsg.BuildErrorString(
                    ClassName, 
                    this.methodName, 
                    this.errMsg,
                    ex.ToString());
                return retVal;
            }
        }

        /// <summary>
        /// Validates the depth feet string value not empty.
        /// </summary>
        /// <returns><c>true</c>, if depth feet string 
        /// value not empty was validated, 
        /// <c>false</c> otherwise.</returns>
        private bool ValidateDepthFeetStringValueNotEmpty()
        {
            bool retVal = false;

            try
            {
                this.methodName = 
            "private void ValidateTextBoxOneFeetStringValue()";

                txtBoxFeet1.Text = txtBoxFeet1.Text.Trim();
                retVal = this.vd.ValidateDataExists(txtBoxFeet1.Text);
                if (retVal)
                {
                    return retVal;
                }
                else
                {   
                    // Place a zero in textbox and return true.
                    txtBoxFeet1.Text = "0";
                    return retVal = true;
                }
            }
            catch (FormatException ex)
            {
                this.errMsg = degb.DepthName +
                " in feet entry not a valid numeric value."; 
                this.myMsg.BuildErrorString(
                    ClassName, 
                    this.methodName, 
                    this.errMsg,
                    ex.ToString());  

                // Error so return false.
                return retVal;
            }
            catch (OverflowException ex)
            {
                this.errMsg = degb.DepthName +
                " in feet entry numeric value is to large.";
                this.myMsg.BuildErrorString(
                    ClassName, 
                    this.methodName, 
                    this.errMsg,
                    ex.ToString());

                // Error so return false.
                return retVal;
            }
        }

        /// <summary>
        /// Validates the depth inches string value not empty.
        /// </summary>
        /// <returns><c>true</c>, if depth inches string 
        /// value not empty was validated, 
        /// <c>false</c> otherwise.</returns>
        private bool ValidateDepthInchesStringValueNotEmpty()
        {
            bool retVal = false;

            try
            {
                this.methodName = 
        "private void ValidateTextBoxOneInchesStringValue()";

                txtBoxInches1.Text = txtBoxInches1.Text.Trim();
                if (this.vd.ValidateDataExists(txtBoxInches1.Text))
                {
                    return retVal = true;
                }
                else
                {
                    // Place a zero in textbox and return true.
                    txtBoxInches1.Text = "0";
                    return retVal = true;
                }
            }
            catch (FormatException ex)
            {
                this.errMsg = degb.DepthName +
                " in inches entry not a valid numeric value."; 
                this.myMsg.BuildErrorString(
                    ClassName, 
                    this.methodName, 
                    this.errMsg,
                    ex.ToString());   

                // Error so return false.
                return retVal;
            }
            catch (OverflowException ex)
            {
                this.errMsg = degb.DepthName +
                " in inches entry numeric value is to large.";
                this.myMsg.BuildErrorString(
                    ClassName, 
                    this.methodName, 
                    this.errMsg,
                    ex.ToString());

                // Error so return false.
                return retVal;
            }
        }

        /// <summary>
        /// Validates the length yards string value not empty.
        /// </summary>
        /// <returns><c>true</c>, if length yards string value 
        /// not empty was validated, <c>false</c> 
        /// otherwise.</returns>
        private bool ValidateLengthYardsStringValueNotEmpty()
        {
            bool retVal = false;

            try
            {
                this.methodName = 
                    "private bool ValidateLengthYardsStringValueNotEmpty()";

                txtBoxYard2.Text = txtBoxYard2.Text.Trim();
                if (this.vd.ValidateDataExists(txtBoxYard2.Text))
                {
                    return retVal = true;
                }
                else
                {
                    // Place a zero in textbox and return true.
                    txtBoxYard2.Text = "0";
                    return retVal = true;
                }
            }
            catch (FormatException ex)
            {
                this.errMsg = degb.LengthName +
                " in yards entry not a valid numeric value."; 
                this.myMsg.BuildErrorString(
                    ClassName, 
                    this.methodName, 
                    this.errMsg,
                    ex.ToString());   

                // Error so return false.
                return retVal;
            }
            catch (OverflowException ex)
            {
                this.errMsg = degb.LengthName +
                " in yards entry numeric value is to large.";
                this.myMsg.BuildErrorString(
                    ClassName, 
                    this.methodName, 
                    this.errMsg,
                    ex.ToString());

                // Error so return false.
                return retVal;
            }
        }

        /// <summary>
        /// Validates the length feet string value not empty.
        /// </summary>
        /// <returns><c>true</c>, if length feet string value 
        /// not empty was validated, <c>false</c> 
        /// otherwise.</returns>
        private bool ValidateLengthFeetStringValueNotEmpty()
        {
            bool retVal = false;

            try
            {
                this.methodName = 
                    "private bool ValidateLengthFeetStringValueNotEmpty()";

                txtBoxFeet2.Text = txtBoxFeet2.Text.Trim();
                retVal = this.vd.ValidateDataExists(txtBoxFeet2.Text);
                if (retVal)
                {
                    return retVal;
                }
                else
                {   
                    // Place a zero in textbox and return true.
                    txtBoxFeet2.Text = "0";
                    return retVal = true;
                }
            }
            catch (FormatException ex)
            {
                this.errMsg = degb.LengthName +
                " in feet entry not a valid numeric value."; 
                this.myMsg.BuildErrorString(
                    ClassName, 
                    this.methodName, 
                    this.errMsg,
                    ex.ToString());  

                // Error so return false.
                return retVal;
            }
            catch (OverflowException ex)
            {
                this.errMsg = degb.LengthName +
                " in feet entry numeric value is to large.";
                this.myMsg.BuildErrorString(
                    ClassName, 
                    this.methodName, 
                    this.errMsg,
                    ex.ToString());

                // Error so return false.
                return retVal;
            }
        }

        /// <summary>
        /// Validates the length inches string value not empty.
        /// </summary>
        /// <returns><c>true</c>, if length inches string value 
        /// not empty was validated, <c>false</c> 
        /// otherwise.</returns>
        private bool ValidateLengthInchesStringValueNotEmpty()
        {
            bool retVal = false;

            try
            {
                this.methodName = 
                    "private bool ValidateLengthInchesStringValueNotEmpty()";

                txtBoxInches2.Text = txtBoxInches2.Text.Trim();
                if (this.vd.ValidateDataExists(txtBoxInches2.Text))
                {
                    return retVal = true;
                }
                else
                {
                    // Place a zero in textbox and return true.
                    txtBoxInches2.Text = "0";
                    return retVal = true;
                }
            }
            catch (FormatException ex)
            {
                this.errMsg = degb.LengthName +
                " in inches entry not a valid numeric value."; 
                this.myMsg.BuildErrorString(
                    ClassName, 
                    this.methodName, 
                    this.errMsg,
                    ex.ToString());   

                // Error so return false.
                return retVal;
            }
            catch (OverflowException ex)
            {
                this.errMsg = degb.LengthName +
                " in inches entry numeric value is to large.";
                this.myMsg.BuildErrorString(
                    ClassName, 
                    this.methodName, 
                    this.errMsg,
                    ex.ToString());

                // Error so return false.
                return retVal;
            }
        }

        /// <summary>
        /// Validates the width yards string value not empty.
        /// </summary>
        /// <returns><c>true</c>, if width yards string value 
        /// not empty was validated, <c>false</c> 
        /// otherwise.</returns>
        private bool ValidateWidthYardsStringValueNotEmpty()
        {
            bool retVal = false;

            try
            {
                this.methodName = 
                    "private bool ValidateWidthYardsStringValueNotEmpty()";

                txtBoxYard3.Text = txtBoxYard3.Text.Trim();
                if (this.vd.ValidateDataExists(txtBoxYard3.Text))
                {
                    return retVal = true;
                }
                else
                {
                    // Place a zero in textbox and return true.
                    txtBoxYard3.Text = "0";
                    return retVal = true;
                }
            }
            catch (FormatException ex)
            {
                this.errMsg = degb.WidthName +
                " in yards entry not a valid numeric value."; 
                this.myMsg.BuildErrorString(
                    ClassName, 
                    this.methodName, 
                    this.errMsg,
                    ex.ToString());   

                // Error so return false.
                return retVal;
            }
            catch (OverflowException ex)
            {
                this.errMsg = degb.WidthName +
                " in yards entry numeric value is to large.";
                this.myMsg.BuildErrorString(
                    ClassName, 
                    this.methodName, 
                    this.errMsg,
                    ex.ToString());

                // Error so return false.
                return retVal;
            }
        }

        /// <summary>
        /// Validates the width feet string value not empty.
        /// </summary>
        /// <returns><c>true</c>, if width feet string value 
        /// not empty was validated, <c>false</c> 
        /// otherwise.</returns>
        private bool ValidateWidthFeetStringValueNotEmpty()
        {
            bool retVal = false;

            try
            {
                this.methodName = 
                    "private bool ValidateWidthFeetStringValueNotEmpty()";

                txtBoxFeet3.Text = txtBoxFeet3.Text.Trim();
                retVal = this.vd.ValidateDataExists(txtBoxFeet3.Text);
                if (retVal)
                {
                    return retVal;
                }
                else
                {   
                    // Place a zero in textbox and return true.
                    txtBoxFeet3.Text = "0";
                    return retVal = true;
                }
            }
            catch (FormatException ex)
            {
                this.errMsg = degb.WidthName +
                " in feet entry not a valid numeric value."; 
                this.myMsg.BuildErrorString(
                    ClassName, 
                    this.methodName, 
                    this.errMsg,
                    ex.ToString());  

                // Error so return false.
                return retVal;
            }
            catch (OverflowException ex)
            {
                this.errMsg = degb.WidthName +
                " in feet entry numeric value is to large.";
                this.myMsg.BuildErrorString(
                    ClassName, 
                    this.methodName, 
                    this.errMsg,
                    ex.ToString());

                // Error so return false.
                return retVal;
            }
        }

        /// <summary>
        /// Thises the validate width inches string value not empty.
        /// </summary>
        /// <returns><c>true</c>, if validate width inches string value 
        /// not empty was thised, <c>false</c> otherwise.</returns>
        private bool ValidateWidthInchesStringValueNotEmpty()
        {
            bool retVal = false;

            try
            {
                this.methodName = 
                    "private bool ValidateWidthInchesStringValueNotEmpty()";

                txtBoxInches3.Text = txtBoxInches3.Text.Trim();
                if (this.vd.ValidateDataExists(txtBoxInches3.Text))
                {
                    return retVal = true;
                }
                else
                {
                    // Place a zero in textbox and return true.
                    txtBoxInches3.Text = "0";
                    return retVal = true;
                }
            }
            catch (FormatException ex)
            {
                this.errMsg = degb.WidthName +
                " in inches entry not a valid numeric value."; 
                this.myMsg.BuildErrorString(
                    ClassName, 
                    this.methodName, 
                    this.errMsg,
                    ex.ToString());   

                // Error so return false.
                return retVal;
            }
            catch (OverflowException ex)
            {
                this.errMsg = degb.WidthName +
                " in inches entry numeric value is to large.";
                this.myMsg.BuildErrorString(
                    ClassName, 
                    this.methodName, 
                    this.errMsg,
                    ex.ToString());

                // Error so return false.
                return retVal;
            }
        }

        /// <summary>
        /// Validates the cubic square yard numeric.
        /// </summary>
        /// <returns><c>true</c>, if cubic square yard 
        /// numeric was validated, <c>false</c> 
        /// otherwise.</returns>
        private bool ValidateCubicSquareDepthYardNumeric()
        {
            bool retVal = false;

            try
            {
                methodName = 
                    "private bool ValidateCubicSquareDepthYardNumeric()";
                
                retVal = vd.ValidateDataIsNumericValue();
                if (!retVal)
                {
                    this.errMsg = degb.DepthName +
                    " in yards entry not a valid numeric value."; 
                    this.myMsg.BuildErrorString(
                        ClassName, 
                        this.methodName, 
                        this.errMsg,
                        ex.ToString());   
                
                    return retVal;
                }
                else
                {
                    // All ok.
                    return retVal = true;
                }
            }
            catch (FormatException ex)
            {
                this.errMsg = degb.DepthName +
                " in yards entry not a valid numeric value."; 
                this.myMsg.BuildErrorString(
                    ClassName, 
                    this.methodName, 
                    this.errMsg,
                    ex.ToString());   

                // Error so return false.
                return retVal;
            }
            catch (OverflowException ex)
            {
                this.errMsg = degb.DepthName +
                " in yards entry numeric value is to large.";
                this.myMsg.BuildErrorString(
                    ClassName, 
                    this.methodName, 
                    this.errMsg,
                    ex.ToString());

                // Error so return false.
                return retVal;
            }
        }

        /// <summary>
        /// Validates the cubic square depth feet numeric.
        /// </summary>
        /// <returns><c>true</c>, if cubic square depth feet 
        /// numeric was validated, <c>false</c> 
        /// otherwise.</returns>
        private bool ValidateCubicSquareDepthFeetNumeric()
        {
            bool retVal = false;

            try
            {
                methodName = 
                    "private bool ValidateCubicSquareDepthYardNumeric()";

                retVal = vd.ValidateDataIsNumericValue();
                if (!retVal)
                {
                    this.errMsg = degb.DepthName +
                    " in feet entry not a valid numeric value."; 
                    this.myMsg.BuildErrorString(
                        ClassName, 
                        this.methodName, 
                        this.errMsg,
                        ex.ToString());   

                    return retVal;
                }
                else
                {
                    // All ok.
                    return retVal = true;
                }
            }
            catch (FormatException ex)
            {
                this.errMsg = degb.DepthName +
                " in feet entry not a valid numeric value."; 
                this.myMsg.BuildErrorString(
                    ClassName, 
                    this.methodName, 
                    this.errMsg,
                    ex.ToString());   

                // Error so return false.
                return retVal;
            }
            catch (OverflowException ex)
            {
                this.errMsg = degb.DepthName +
                " in feet entry numeric value is to large.";
                this.myMsg.BuildErrorString(
                    ClassName, 
                    this.methodName, 
                    this.errMsg,
                    ex.ToString());

                // Error so return false.
                return retVal;
            }
        }

        private bool ValidateCubicSquareDepthInchesNumeric()
        {
            throw new NotImplementedException();
        }


        bool ValidateCubicSquareLengthYardsNumeric()
        {
            throw new NotImplementedException();
        }

        bool ValidateCubicSquareLengthFeetNumeric()
        {
            throw new NotImplementedException();
        }

        bool ValidateCubicSquareLengthInchesNumeric()
        {
            throw new NotImplementedException();
        }

        bool ValidateCubicSquareWidthYardsNumeric()
        {
            throw new NotImplementedException();
        }

        bool ValidateCubicSquardWidthFeetNumeric()
        {
            throw new NotImplementedException();
        }

        bool ValidateCubicSquareWidthInchesNumeric()
        {
            throw new NotImplementedException();
        }

        #endregion VALIDATE CUBIC AREA SQUARE RECTANGLE





        /// <summary>
        /// Validates the text box three yards string value.
        /// </summary>
        /// <returns>If all ok return int val. If not return
        /// -1</returns>
        private int ValidateTextBoxThreeYardsStringValue()
        {
            int retVal = -1;

            try
            {
                this.methodName = "private void " +
                "ValidateTextBoxThreeYardsStringValue()";

                txtBoxYard3.Text = txtBoxYard3.Text.Trim();
                if (this.vd.ValidateDataExists(txtBoxYard3.Text))
                {
                    if (this.vd.ValidateDataIsNumericValue(txtBoxYard3.Text))
                    {
                        if (this.vd.ValidateDataIsGreaterThenMinusOne(
                                txtBoxYard3.Text))
                        {
                            // Valid int so return value.
                            retVal = Convert.ToInt32(txtBoxYard3.Text);
                            return retVal;
                        }
                        else
                        {
                            // Invalid return -1
                            return retVal;
                        }
                    }
                    else
                    {
                        this.errMsg = degb.WidthName +
                        " in yards is not a numeric value.";
                        this.myMsg.ShowErrMessage(this.errMsg);

                        // Error so return -1 not valid.
                        return retVal;
                    }
                }
                else
                {
                    this.errMsg = degb.WidthName +
                    " in yards has no value entered.\n" +
                    " You must place a 0 or larger numeric value\n" +
                    " in this box.";
                    this.myMsg.ShowErrMessage(this.errMsg);

                    // Error so return -1 not valid.
                    return retVal;
                }
            }
            catch (FormatException ex)
            {
                this.errMsg = degb.WidthName +
                " in yards entry not a valid numeric value."; 
                this.myMsg.BuildErrorString(
                    ClassName, 
                    this.methodName, 
                    this.errMsg,
                    ex.ToString());

                // Error so return -1 not valid.
                return retVal;
            }
            catch (OverflowException ex)
            {
                this.errMsg = degb.WidthName +
                " in yards entry numeric value is to large.";
                this.myMsg.BuildErrorString(
                    ClassName, 
                    this.methodName, 
                    this.errMsg,
                    ex.ToString());

                // Error so return -1 not valid.
                return retVal;
            }

            // Should never get here but if I do return -1 as error
            return retVal;
        }

        /// <summary>
        /// Validates the text box three feet string value.
        /// If not ok exit with error message and return -1. 
        /// If ok then return int value greater then -1;
        /// </summary>
        /// <returns>If all ok return int. If not return
        /// -1</returns>
        private int ValidateTextBoxThreeFeetStringValue()
        {
            int retVal = -1;

            try
            {
                this.methodName = 
                    "private void ValidateTextBoxThreeFeetStringValue()";

                txtBoxFeet3.Text = txtBoxFeet3.Text.Trim();
                if (this.vd.ValidateDataExists(txtBoxFeet3.Text))
                {
                    if (this.vd.ValidateDataIsNumericValue(txtBoxFeet3.Text))
                    {
                        if (this.vd.ValidateDataIsGreaterThenMinusOne(
                                txtBoxFeet3.Text))
                        {   
                            // Valid int so return value.
                            retVal = Convert.ToInt32(txtBoxFeet3.Text);
                            return retVal;
                        }
                        else
                        {
                            // Invalid return -1
                            return retVal;
                        }
                    }
                    else
                    {
                        this.errMsg = degb.WidthName +
                        " in feet is not a numeric value.";
                        this.myMsg.ShowErrMessage(this.errMsg);

                        // Error so return -1 not valid.
                        return retVal;
                    }
                }
                else
                {
                    this.errMsg = degb.WidthName +
                    " in feet has no value entered.\n" +
                    " You must place a 0 or larger numeric value\n" +
                    " in this box.";
                    this.myMsg.ShowErrMessage(this.errMsg);

                    // Error so return -1 not valid.
                    return retVal;
                }
            }
            catch (FormatException ex)
            {
                this.errMsg = degb.WidthName +
                " in feet entry not a valid numeric value."; 
                this.myMsg.BuildErrorString(
                    ClassName, 
                    this.methodName, 
                    this.errMsg,
                    ex.ToString());  

                // Error so return -1 not valid.
                return retVal;
            }
            catch (OverflowException ex)
            {
                this.errMsg = degb.WidthName +
                " in feet entry numeric value is to large.";
                this.myMsg.BuildErrorString(
                    ClassName, 
                    this.methodName, 
                    this.errMsg,
                    ex.ToString());

                // Error so return -1 not valid.
                return retVal;
            }

            // Should never get here but if I do return -1 as error
            return retVal;
        }

        /// <summary>
        /// Validates the text box three inches string value.
        /// If not ok exit with error message and return -1. 
        /// If ok then return int value greater then -1;
        /// </summary>
        /// <returns>If all ok return int val. If not return
        /// -1</returns>
        private int ValidateTextBoxThreeInchesStringValue()
        {
            int retVal = -1;

            try
            {
                this.methodName = 
                    "private void ValidateTextBoxThreeInchesStringValue()";

                txtBoxInches3.Text = txtBoxInches3.Text.Trim();
                if (this.vd.ValidateDataExists(txtBoxInches3.Text))
                {
                    if (this.vd.ValidateDataIsNumericValue(txtBoxInches3.Text))
                    {
                        if (this.vd.ValidateDataIsGreaterThenMinusOne(
                                txtBoxInches3.Text))
                        {   // Valid int so return value.
                            retVal = Convert.ToInt32(txtBoxInches3.Text);
                            return retVal;
                        }
                        else
                        {
                            // Invalid return -1
                            return retVal;
                        }
                    }
                    else
                    {
                        this.errMsg = degb.WidthName +
                        " in inches is not a numeric value.";
                        this.myMsg.ShowErrMessage(this.errMsg);

                        // Error so return -1 not valid.
                        return retVal;
                    }
                }
                else
                {
                    this.errMsg = degb.WidthName +
                    " in inches has no value entered.\n" +
                    " You must place a 0 or larger numeric value\n" +
                    " in this box.";
                    this.myMsg.ShowErrMessage(this.errMsg);

                    // Error so return -1 not valid.
                    return retVal;
                }
            }
            catch (FormatException ex)
            {
                this.errMsg = degb.WidthName +
                " in inches entry not a valid numeric value."; 
                this.myMsg.BuildErrorString(
                    ClassName, 
                    this.methodName, 
                    this.errMsg,
                    ex.ToString());  

                // Error so return -1 not valid.
                return retVal;
            }
            catch (OverflowException ex)
            {
                this.errMsg = degb.WidthName +
                " in inches entry numeric value is to large.";
                this.myMsg.BuildErrorString(
                    ClassName, 
                    this.methodName, 
                    this.errMsg,
                    ex.ToString());

                // Error so return -1 not valid
                return retVal;
            }

            // Should never get here but if I do return -1 as error
            return retVal;
        }

       
    }
}