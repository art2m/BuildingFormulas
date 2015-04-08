//
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
            this.ClearDataFromRectangleSquareSolve();
            this.ValidateCubicAreaSquare();
        }

        /// <summary>
        /// Solves for cubic area triangle.
        /// </summary>
        private void SolveForCubicAreaTriangle()
        {
            throw new NotImplementedException();
        }

        #endregion SOLVE FOR CUBIC AREA SHAPES

        /// <summary>
        /// Validates the cubic area square.
        /// </summary>
        private void ValidateCubicAreaSquare()
        {
            // Depth settings for squard.
            rss.RectangleDepthInYards = 
                this.ValidateTextBoxOneYardsStringValue();
            rss.RectangleDepthInFeet = 
                this.ValidateTextBoxOneFeetStringValue();
            rss.RectangleDepthInInches = 
                this.ValidateTextBoxOneInchesStringValue();

            // Length settings for square.
            this.ValidateTextBoxTwoYardsStringValue();
            rss.RectangleLengthInFeet = 
                this.ValidateTextBoxTwoFeetStringValue();
            rss.RectangleLengthInInches =
                this.ValidateTextBoxTwoInchesStringValue();

            // Width settings for squared.
            rss.RectangleWidthInYards = 
                this.ValidateTextBoxThreeYardsStringValue();
            rss.RectangleWidthInFeet = 
                this.ValidateTextBoxThreeFeetStringValue();
            rss.RectangleWidthInInches = 
                this.ValidateTextBoxThreeInchesStringValue();
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

        #region VALIDATE DATA ENTERED IN TEXT BOXES.

        /// <summary>
        /// Validates the text box one yards string value.
        /// </summary>
        /// <returns>If all ok return int val. If not return
        /// -1.</returns>
        private int ValidateTextBoxOneYardsStringValue()
        {
            int retVal = -1;

            try
            {
                this.methodName = "private void " +
                "ValidateTextBoxOneYardsStringValue()";

                txtBoxYard1.Text = txtBoxYard1.Text.Trim();
                if (this.vd.ValidateDataExists(txtBoxYard1.Text))
                {
                    if (this.vd.ValidateDataIsNumericValue(txtBoxYard1.Text))
                    {
                        if (this.vd.ValidateDataIsGreaterThenZero(
                                txtBoxYard1.Text))
                        {
                            if (retVal > -1)
                            {
                                // Valid int so return value.
                                retVal = Convert.ToInt32(txtBoxYard1.Text);
                            }
                            else
                            {
                                // Not valid -1
                                return retVal;
                            }
                        }
                        else if (this.vd.ValidateDataIsGreaterThenMinusOne(
                                     txtBoxYard1.Text))
                        {
                            if (retVal > -1)
                            {
                                // Valid int 0 this box might not be used by 
                                // user so 0 is valid.
                                retVal = Convert.ToInt32(txtBoxYard1.Text);
                            }
                            else
                            {
                                // Not valid -1
                                return retVal;
                            }
                        }
                        else
                        {
                            // value is -1 or less
                            return retVal;
                        }
                    }
                    else
                    {
                        this.errMsg = degb.DepthName +
                        " in yards is not a numeric value.";
                        this.myMsg.ShowErrMessage(this.errMsg);

                        // Error so return -1 not valid.
                        return retVal;
                    }
                }
                else
                {
                    this.errMsg = degb.DepthName +
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
                this.errMsg = degb.DepthName +
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
                this.errMsg = degb.DepthName +
                " in yards entry numeric value is to large.";
                this.myMsg.BuildErrorString(
                    ClassName, 
                    this.methodName, 
                    this.errMsg,
                    ex.ToString());

                // Error so return -1 not valid.
                return retVal;
            }

            // Error so return -1 not valid.
            return retVal;
        }

        /// <summary>
        /// Validates the text box one feet string value.
        /// </summary>
        /// <returns>If all ok return int val. If not return
        /// -1.</returns>
        private int ValidateTextBoxOneFeetStringValue()
        {
            int retVal = -1;

            try
            {
                this.methodName = 
                    "private void ValidateTextBoxOneFeetStringValue()";

                txtBoxFeet1.Text = txtBoxFeet1.Text.Trim();
                if (this.vd.ValidateDataExists(txtBoxFeet1.Text))
                {
                    if (this.vd.ValidateDataIsNumericValue(txtBoxFeet1.Text))
                    {
                        if (this.vd.ValidateDataIsGreaterThenZero(
                                txtBoxFeet1.Text))
                        {
                            // Valid int so return value.
                            retVal = Convert.ToInt32(txtBoxFeet1.Text);
                        }
                    }
                    else
                    {
                        this.errMsg = degb.DepthName +
                        " in feet is not a numeric value.";
                        this.myMsg.ShowErrMessage(this.errMsg);

                        // Error so return -1 not valid.
                        return retVal;
                    }
                }
                else
                {
                    this.errMsg = degb.DepthName +
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
                this.errMsg = degb.DepthName +
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
                this.errMsg = degb.DepthName +
                " in feet entry numeric value is to large.";
                this.myMsg.BuildErrorString(
                    ClassName, 
                    this.methodName, 
                    this.errMsg,
                    ex.ToString());

                // Error so return -1 not valid.
                return retVal;
            }

            // Error so return -1 not valid.
            return retVal;
        }

        /// <summary>
        /// Validates the text box one inches string value.
        /// </summary>
        /// <returns>If all ok return int val. If not return
        /// -1</returns>
        private int ValidateTextBoxOneInchesStringValue()
        {
            int retVal = -1;

            try
            {
                this.methodName = 
                    "private void ValidateTextBoxOneInchesStringValue()";

                txtBoxInches1.Text = txtBoxInches1.Text.Trim();
                if (this.vd.ValidateDataExists(txtBoxInches1.Text))
                {
                    if (this.vd.ValidateDataIsNumericValue(txtBoxInches1.Text))
                    {
                        if (this.vd.ValidateDataIsGreaterThenZero(
                                txtBoxInches1.Text))
                        {
                            // Valid int so return value.
                            retVal = Convert.ToInt32(txtBoxInches1.Text);
                        }
                    }
                    else
                    {
                        this.errMsg = degb.DepthName +
                        " in inches is not a numeric value.";
                        this.myMsg.ShowErrMessage(this.errMsg);

                        // Error so return -1 not valid.
                        return retVal;
                    }
                }
                else
                {
                    this.errMsg = degb.DepthName +
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
                this.errMsg = degb.DepthName +
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
                this.errMsg = degb.DepthName +
                " in inches entry numeric value is to large.";
                this.myMsg.BuildErrorString(
                    ClassName, 
                    this.methodName, 
                    this.errMsg,
                    ex.ToString());

                // Error so return -1 not valid.
                return retVal;
            }

            // Error so return -1 not valid.
            return retVal;
        }

        /// <summary>
        /// Validates the text box two yards string value.
        /// </summary>
        /// <returns>If all ok return int val. If not return
        /// -1</returns>
        private int ValidateTextBoxTwoYardsStringValue()
        {
            int retVal = -1;

            try
            {
                this.methodName = "private void " +
                "ValidateTextBoxTwoYardsStringValue()";

                txtBoxYard2.Text = txtBoxYard2.Text.Trim();
                if (this.vd.ValidateDataExists(txtBoxYard2.Text))
                {
                    if (this.vd.ValidateDataIsNumericValue(txtBoxYard2.Text))
                    {
                        if (this.vd.ValidateDataIsGreaterThenZero(
                                txtBoxYard2.Text))
                        {
                            // Valid int so return value.
                            retVal = Convert.ToInt32(txtBoxYard2.Text);
                        }
                    }
                    else
                    {
                        this.errMsg = degb.LengthName +
                        " in yards is not a numeric value.";
                        this.myMsg.ShowErrMessage(this.errMsg);

                        // Error so return -1 not valid.
                        return retVal;
                    }
                }
                else
                {
                    this.errMsg = degb.LengthName +
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
                this.errMsg = degb.LengthName +
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
                this.errMsg = degb.LengthName +
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
        /// Validates the text box two feet string value.
        /// </summary>
        /// <returns>If all ok return int val. If not return
        /// -1.</returns>
        private int ValidateTextBoxTwoFeetStringValue()
        {
            int retVal = -1;

            try
            {
                this.methodName = 
                    "private void ValidateTextBoxTwoFeetStringValue()";

                txtBoxFeet2.Text = txtBoxFeet2.Text.Trim();
                if (this.vd.ValidateDataExists(txtBoxFeet2.Text))
                {
                    if (this.vd.ValidateDataIsNumericValue(txtBoxFeet2.Text))
                    {
                        if (this.vd.ValidateDataIsGreaterThenZero(
                                txtBoxFeet2.Text))
                        {
                            // Valid int so return value.
                            retVal = Convert.ToInt32(txtBoxFeet2.Text);
                            return retVal;
                        }
                    }
                    else
                    {
                        this.errMsg = degb.LengthName +
                        " in feet is not a numeric value.";
                        this.myMsg.ShowErrMessage(this.errMsg);

                        // Error so return -1 not valid.
                        return retVal;
                    }
                }
                else
                {
                    this.errMsg = degb.LengthName +
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
                this.errMsg = degb.LengthName +
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
                this.errMsg = degb.LengthName +
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
        /// Validates the text box two inches string value.
        /// </summary>
        /// <returns>If all ok return int val. If not return
        /// -1.</returns>
        private int ValidateTextBoxTwoInchesStringValue()
        {
            int retVal = -1;

            try
            {
                this.methodName = 
                    "private void ValidateTextBoxTwoInchesStringValue()";

                txtBoxInches2.Text = txtBoxInches2.Text.Trim();
                if (this.vd.ValidateDataExists(txtBoxInches2.Text))
                {
                    if (this.vd.ValidateDataIsNumericValue(txtBoxInches2.Text))
                    {
                        if (this.vd.ValidateDataIsGreaterThenZero(
                                txtBoxInches2.Text))
                        {   
                            // Valid int so return value.
                            retVal = Convert.ToInt32(txtBoxInches2.Text);
                        }
                    }
                    else
                    {
                        this.errMsg = degb.LengthName +
                        " in inches is not a numeric value.";
                        this.myMsg.ShowErrMessage(this.errMsg);

                        // Error so return -1 not valid.
                        return retVal;
                    }
                }
                else
                {
                    this.errMsg = degb.LengthName +
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
                this.errMsg = degb.LengthName +
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
                this.errMsg = degb.LengthName +
                " in inches entry numeric value is to large.";
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
                        if (this.vd.ValidateDataIsGreaterThenZero(
                                txtBoxYard3.Text))
                        {
                            // Valid int so return value.
                            retVal = Convert.ToInt32(txtBoxYard3.Text);
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
                        if (this.vd.ValidateDataIsGreaterThenZero(
                                txtBoxFeet3.Text))
                        {   
                            // Valid int so return value.
                            retVal = Convert.ToInt32(txtBoxFeet3.Text);
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
                        if (this.vd.ValidateDataIsGreaterThenZero(
                                txtBoxInches3.Text))
                        {   // Valid int so return value.
                            retVal = Convert.ToInt32(txtBoxInches3.Text);
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

        #endregion VALIDATE DATA ENTERED IN TEXT BOXES.
    }
}