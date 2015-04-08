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
        /// My message.
        /// </summary>
        private MyMessages myMsg = new MyMessages();

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

        /// <summary>
        /// Gets the what to solve for.
        /// Get the Type such as cubic area.
        /// Get shape to solve for such as rectangle square
        /// circle etc...
        /// </summary>
        public void GetWhatToSolveFor()
        {
            bool val;
            const string MethodName = 
                "private void CreateLabelsForDataNeeded()";

            try
            {

                // Check to see if type is cubic.

                val = this.CheckForMatchToCubicArea();
                if (!val)
                {
                    // check next type other then cubic area
                }
                else
                {
                    this.CubicAreaShape();
                }
            }
            catch (ArgumentNullException ex)
            {
                this.myMsg.BuildErrorString(
                    ClassName, 
                    MethodName, 
                    this.errMsg,
                    ex.ToString());
            }
        }

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
            solveState = true;
            GetWhatToSolveFor();
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
            this.solveState = true;

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
                // Type formula to use such as cubic
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

        /// <summary>
        /// Cubics the area shape.
        /// </summary>
        private void CubicAreaShape()
        {
            const int Match = 0; 

            if (string.Compare(
                    degb.ConeCompare, 
                    degb.ShapeToSolveFor) == Match)
            {
                // if true then we are solving for the user clicked
                // the btn solve.
                if (this.solveState)
                {
                    throw new NotImplementedException();
                }
                else
                {
                    // Window just started so we are going to figure out 
                    // What labels are needed and fill them in for this
                    // type.
                }
            }
            else if (string.Compare(
                         degb.CylinderCompare, 
                         degb.ShapeToSolveFor) == Match)
            {
                // if true then we are solving for the user clicked
                // the btn solve.
                if (this.solveState)
                {
                    throw new NotImplementedException();
                }
                else
                {
                    // Window just started so we are going to figure out 
                    // What labels are needed and fill them in for this
                    // type.
                }
            }
            else if (string.Compare(
                         degb.HexagonCompare, 
                         degb.ShapeToSolveFor) == Match)
            {
                if (this.solveState)
                {
                    // if true then we are solving for the user clicked
                    // the btn solve.
                }
                else
                {
                    // Window just started so we are going to figure out 
                    // What labels are needed and fill them in for this
                    // type.
                }
            }
            else if (string.Compare(
                         degb.OcatagonCompare, 
                         degb.ShapeToSolveFor) == Match)
            {
                // if true then we are solving for the user clicked
                // the btn solve.
                if (this.solveState)
                {
                    throw new NotImplementedException();
                }
                else
                {
                    // Window just started so we are going to figure out 
                    // What labels are needed and fill them in for this
                    // type.
                }
            }
            else if (string.Compare(
                         degb.PyramidCompare, 
                         degb.ShapeToSolveFor) == Match)
            {
                if (this.solveState)
                {
                    // if true then we are solving for the user clicked
                    // the btn solve.
                }
                else
                {
                    // Window just started so we are going to figure out 
                    // What labels are needed and fill them in for this
                    // type.
                }
            }
            else if (string.Compare(
                         degb.RectangleCompare, 
                         degb.ShapeToSolveFor) == Match)
            {
                if (this.solveState)
                {
                    // if true then we are solving for the user clicked
                    // the btn solve.
                }
                else
                {
                    // Window just started so we are going to figure out 
                    // What labels are needed and fill them in for this
                    // type.
                    this.ShowLabelsForCubicAreaRectangleSquareDataEntry();
                    this.ShowTextBoxesForCubicAreaRectangleSquareDataEntry();

                    this.FillLabelsForCubicAreaRectagle();
                }
            }
            else if (string.Compare(
                         degb.SquareCompare, 
                         degb.ShapeToSolveFor) == Match)
            {
                if (this.solveState)
                {
                    // if true then we are solving for the user clicked
                    // the btn solve.
                }
                else
                {
                    // Window just started so we are going to figure out 
                    // What labels are needed and fill them in for this
                    // type.
                    this.FillLabelsForCubicAreaSquare();
                }
            }
            else
            {
                throw new NotImplementedException();
            }                  
        }

        #region Fill Labels For Cubic Area

        /// <summary>
        /// Fills the labels for cubic area cone.
        /// </summary>
        private void FillLabelsForCubicAreaCone()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Fills the labels for cubic area cylinder.
        /// </summary>
        private void FillLabelsForCubicAreaCylinder()
        {
            throw new NotImplementedException();
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
        private void FillLabelsForCubicAreaPyramid()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Fills the labels for cubic area rectagle.
        /// </summary>
        private void FillLabelsForCubicAreaRectagle()
        {
            lblYards.Text = degb.YardsLabelCaption;
            lblFeet.Text = degb.FeetLabelCaption;
            lblInches.Text = degb.InchesLabelCaption;
            lblDepth.Text = degb.DepthLabelCaption;
            lblLength.Text = degb.LengthLabelCaption;
            lblWidth.Text = degb.WidthLabelCaption;
            lblCubicYards.Text = degb.AreaInCubicYardsLabelCaption;
            lblCubicFeet.Text = degb.AreaInCubicFeetLabelCaption;
            lblCubicInches.Text = degb.AreaInCubicInchesLabelCaption;
        }

        /// <summary>
        /// Fills the labels for cubic area square.
        /// </summary>
        private void FillLabelsForCubicAreaSquare()
        {
            lblYards.Text = degb.YardsLabelCaption;
            lblFeet.Text = degb.FeetLabelCaption;
            lblInches.Text = degb.InchesLabelCaption;
            lblDepth.Text = degb.DepthLabelCaption;
            lblLength.Text = degb.LengthLabelCaption;
            lblWidth.Text = degb.WidthLabelCaption;
            lblCubicYards.Text = degb.AreaInCubicYardsLabelCaption;
            lblCubicFeet.Text = degb.AreaInCubicFeetLabelCaption;
            lblCubicInches.Text = degb.AreaInCubicInchesLabelCaption;
        }

        #endregion Fill Labels For Cubic Area

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
            lblCubicFeet.Visible = true;
            lblCubicYards.Visible = true;
            lblCubicFeet.Visible = true;
            lblCubicInches.Visible = true;

            FillLabelsForCubicAreaSquare();
            FillLabelsForCubicAreaRectagle();
        }

        /// <summary>
        /// Shows the text boxes for cubic area rectangle square data entry.
        /// Hide any text boxes not needed.
        /// </summary>
        private void ShowTextBoxesForCubicAreaRectangleSquareDataEntry()
        {
            txtDepthYd.Visible = true;
            txtDepthFt.Visible = true;
            txtDepthIn.Visible = true;
        }
    }
}