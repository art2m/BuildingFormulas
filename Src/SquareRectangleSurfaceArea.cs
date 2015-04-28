//
//  SquareRectangleSurfaceAreaFormula.cs
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
    /// Square rectangle surface area.
    ///  users gui.
    /// </summary>
    public partial class SquareRectangleSurfaceArea : Gtk.Window
    {
        /// <summary>
        /// The vd.
        /// </summary>
        private ValidateData vd = new ValidateData();

        /// <summary>
        /// My message.
        /// </summary>
        private MyMessages myMsg = new MyMessages();

        /// <summary>
        /// The shape object decleration.
        /// </summary>
        private Shapes shape = new Shapes();

        /// <summary>
        /// The math object decleration.
        /// </summary>
        private MyMath math = new MyMath();

        /// <summary>
        /// The rss object decleration.
        /// </summary>
        private RectangleSquareSolve rss = new RectangleSquareSolve();

        /// <summary>
        /// The conv object decleration.
        /// </summary>
        private Conversions conv = new Conversions();

        /// <summary>
        /// The name of the class.
        /// </summary>
        private string className = "public partial class " +
                                   "SquareRectangleSurfaceAreaFormula : " +
                                   "Gtk.Window";

        /// <summary>
        /// The name of the method.
        /// </summary>
        private string methodName = null;

        /// <summary>
        /// The error message.
        /// </summary>
        private string errMsg = null;

        /// <summary>
        /// The standard units of meassurement.
        /// </summary>
        private bool standardUnits = false;

        /// <summary>
        /// The metric units of meassurement.
        /// </summary>
        private bool metricUnits = false;

        /// <summary>
        /// Initializes a new instance of the 
        /// <see cref="BuildingFormulas.SquareRectangleSurfaceArea"/> class.
        /// </summary>
        public SquareRectangleSurfaceArea()
            : base(Gtk.WindowType.Toplevel)
        {
            this.Build();
        }

        #region BUTTON CLICKED EVENTS

        /// <summary>
        /// Raises the button solve clicked event.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Instance containing the event data.</param>
        protected void OnBtnSolveClicked(object sender, EventArgs e)
        {     
            this.ShapeFormulaToSolveFor();
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
        /// Raises the button display store clicked event.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Instance containing the event data.</param>
        protected void OnBtnDisplayStoreClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Raises the button clear store clicked event.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Instance containing the event data.</param>
        protected void OnBtnClearStoreClicked(object sender, EventArgs e)
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
        /// Raises the button standard clicked event.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Instance containing the event data.</param>
        protected void OnBtnStandardClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Raises the button metric clicked event.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Instance containing the event data.</param>
        protected void OnBtnMetricClicked(object sender, EventArgs e)
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
        /// <param name="e">Instance conaining the event data.</param>
        protected void OnBtnPrintStoredClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Raises the button save form clicked event.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Instance containing the event data.</param>
        protected void OnBtnSaveFormClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Raises the button close clicked event.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Instance containing the event data.</param>
        protected void OnBtnCloseClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion BUTTON CLICKED EVENTS

        /// <summary>
        /// Shapes the formula to solve for.
        /// </summary>
        private void ShapeFormulaToSolveFor()
        {   
            int val = 0;

            val = string.Compare(
                degb.ShapeToSolveFor, 
                this.shape.RectangleShape);
            
            if (val == 0)
            {
                this.SolveForRectangleSurfaceArea();
            }

            val = string.Compare(degb.ShapeToSolveFor, this.shape.SquareShape);
            if (val == 0)
            {
                this.SolveForSquareSurfaceArea();
            }
        }

        /// <summary>
        /// Solves for square surface area.
        /// </summary>
        private void SolveForSquareSurfaceArea()
        {
            bool retVal = false;
            double val = 0;

            retVal = this.ValidateTextBoxesStringValue();
            if (!retVal)
            {
                return;
            }

            retVal = this.ValidateTextBoxesNumericValue();
            if (!retVal)
            {
                return;
            }

            retVal = this.ValidateTextBoxesValueGreaterThenZero();
            if (!retVal)
            {
                return;
            }

            this.FillDataWithDataFromTextboxes();

            this.ConvertDataToInches();

            val = this.rss.SolveForSurfaceAreaSquareYards(
                this.math.LengthTotalInches,
                this.math.WidthTotalInches);
            txtSurfaceYards.Text = val.ToString();

            val = this.rss.SolveForSurfaceAreaSquareFeet(
                this.math.LengthTotalInches,
                this.math.WidthTotalInches);
            txtSurfaceFeet.Text = val.ToString();

            val = this.rss.SolveForSurfaceAreaSquareInches(
                this.math.LengthTotalInches,
                this.math.WidthTotalInches);
            txtSurfaceInches.Text = val.ToString();            
        }

        /// <summary>
        /// Solves for rectangle surface area.
        /// </summary>
        private void SolveForRectangleSurfaceArea()
        {
            bool retVal = false;

            retVal = this.ValidateTextBoxesStringValue();
            if (!retVal)
            {
                return;
            }

            retVal = this.ValidateTextBoxesNumericValue();
            if (!retVal)
            {
                return;
            }

            retVal = this.ValidateTextBoxesValueGreaterThenZero();
            if (!retVal)
            {
                return;
            }

            this.FillDataWithDataFromTextboxes();

            retVal = this.ConvertDataToInches();
        }

        #region VALIDATION DATA

        /// <summary>
        /// Validates the text boxes string value.
        /// </summary>
        /// <returns><c>true</c>, if text boxes string 
        /// value was validated, 
        /// <c>false</c> otherwise.</returns>
        private bool ValidateTextBoxesStringValue()
        {
            bool retVal = false;

            retVal = this.ValidateTextBoxesYardsNotEmpty();
            if (!retVal)
            {
                return retVal;
            }

            retVal = this.ValidateTextBoxesFeetNotEmpty();
            if (!retVal)
            {
                return retVal;
            }

            retVal = this.ValidateTextBoxesInchesNotEmpty();
            if (!retVal)
            {
                return retVal;
            }

            return retVal = true;
        }

        /// <summary>
        /// Validates the text boxes numeric value.
        /// </summary>
        /// <returns><c>true</c>, if text boxes numeric 
        /// value was validated, <c>false</c> otherwise.</returns>
        private bool ValidateTextBoxesNumericValue()
        {
            bool retVal = false;

            retVal = this.ValidateTextBoxesYardsNumericValue();
            if (!retVal)
            {
                return retVal;
            }

            retVal = this.ValidateTextBoxesFeetNumericValue();
            if (!retVal)
            {
                return retVal;
            }

            retVal = this.ValidateTextBoxesInchesNumericValue();
            if (!retVal)
            {
                return retVal;
            }

            return retVal = true;
        }

        /// <summary>
        /// Validates the text boxes value greater then zero.
        /// </summary>
        /// <returns><c>true</c>, if text boxes 
        /// value greater then zero was validated, 
        /// <c>false</c> otherwise.</returns>
        private bool ValidateTextBoxesValueGreaterThenZero()
        {
            bool retVal = false;

            retVal = this.ValidateLengthYardFeetInchesValueGreaterThenZero();
            if (!retVal)
            {
                return retVal;
            }

            retVal = this.ValidateWidthYardFeetInchesValueGreaterThenZero();
            if (!retVal)
            {
                return retVal;
            }

            return retVal = true;
        }

        /// <summary>
        /// Validates the text boxes yards not empty.
        /// </summary>
        /// <returns><c>true</c>, if text boxes yards not empty was 
        /// validated, <c>false</c> otherwise.</returns>
        private bool ValidateTextBoxesYardsNotEmpty()
        {
            bool retVal = false;

            txtLengthYard.Text = txtLengthYard.Text.Trim();
            retVal = this.vd.ValidateDataExists(txtLengthYard.Text);
            if (!retVal)
            {
                return retVal;
            }

            txtWidthYard.Text = txtWidthYard.Text.Trim();
            retVal = this.vd.ValidateDataExists(txtWidthYard.Text);
            if (!retVal)
            {
                return retVal;
            }

            return retVal = true;
        }

        /// <summary>
        /// Validates the text boxes feet not empty.
        /// </summary>
        /// <returns><c>true</c>, if text boxes feet 
        /// not empty was validated, 
        /// <c>false</c> otherwise.</returns>
        private bool ValidateTextBoxesFeetNotEmpty()
        {
            bool retVal = false;

            txtLengthFeet.Text = txtLengthFeet.Text.Trim();
            retVal = this.vd.ValidateDataExists(txtLengthFeet.Text);
            if (!retVal)
            {
                return retVal;
            }

            retVal = this.vd.ValidateDataExists(txtWidthFeet.Text);
            if (!retVal)
            {
                return retVal;
            }

            return retVal = true;
        }

        /// <summary>
        /// Validates the text boxes inches not empty.
        /// </summary>
        /// <returns><c>true</c>, if text boxes inches 
        /// not empty was validated, 
        /// <c>false</c> otherwise.</returns>
        private bool ValidateTextBoxesInchesNotEmpty()
        {
            bool retVal = false;

            txtLengthInches.Text = txtLengthInches.Text.Trim();
            retVal = this.vd.ValidateDataExists(txtLengthInches.Text);
            if (!retVal)
            {
                return retVal;
            }

            retVal = this.vd.ValidateDataExists(txtWidthInches.Text);
            if (!retVal)
            {
                return retVal;
            }

            return retVal = true;
        }

        /// <summary>
        /// Validates the text boxes yards numeric value.
        /// </summary>
        /// <returns><c>true</c>, if text boxes yards 
        /// numeric value was validated, 
        /// <c>false</c> otherwise.</returns>
        private bool ValidateTextBoxesYardsNumericValue()
        {
            bool retVal = false;
             
            txtLengthYard.Text = txtLengthYard.Text.Trim();
            retVal = this.vd.ValidateDataIsNumericValue(txtLengthYard.Text);
            if (!retVal)
            {
                return retVal;
            }

            retVal = this.vd.ValidateDataIsNumericValue(txtWidthInches.Text);
            if (!retVal)
            {
                return retVal;
            }

            return retVal = true;
        }

        /// <summary>
        /// Validates the text boxes feet numeric value.
        /// </summary>
        /// <returns><c>true</c>, if text boxes feet 
        /// numeric value was validated, 
        /// <c>false</c> otherwise.</returns>
        private bool ValidateTextBoxesFeetNumericValue()
        {
            bool retVal = false;

            txtLengthFeet.Text = txtLengthFeet.Text.Trim();
            retVal = this.vd.ValidateDataIsNumericValue(txtLengthFeet.Text);
            if (!retVal)
            {
                return retVal;
            }

            retVal = this.vd.ValidateDataIsNumericValue(txtWidthFeet.Text);
            if (!retVal)
            {
                return retVal;
            }

            return retVal = true;
        }

        /// <summary>
        /// Validates the text boxes inches numeric value.
        /// </summary>
        /// <returns><c>true</c>, if text boxes inches 
        /// numeric value was validated, 
        /// <c>false</c> otherwise.</returns>
        private bool ValidateTextBoxesInchesNumericValue()
        {
            bool retVal = false;

            txtLengthInches.Text = txtLengthInches.Text.Trim();
            retVal = this.vd.ValidateDataIsNumericValue(txtLengthInches.Text);
            if (!retVal)
            {
                return retVal;
            }

            retVal = this.vd.ValidateDataIsNumericValue(txtWidthInches.Text);
            if (!retVal)
            {
                return retVal;
            }

            return retVal = true;
        }

        /// <summary>
        /// Validates the length yard feet inches value greater then zero.
        /// </summary>
        /// <returns><c>true</c>, if length yard feet inches 
        /// value greater then zero was validated, 
        /// <c>false</c> otherwise.</returns>
        private bool ValidateLengthYardFeetInchesValueGreaterThenZero()
        {
            bool retVal = false;

            retVal = this.vd.ValidateDataIsGreaterThenZero(txtLengthYard.Text);
            if (retVal)
            {
                return retVal;
            }

            retVal = this.vd.ValidateDataIsGreaterThenZero(txtLengthFeet.Text);
            if (retVal)
            {
                return retVal;
            }

            retVal = this.vd.ValidateDataIsGreaterThenZero(txtLengthInches.Text);
            if (retVal)
            {
                return retVal;
            }

            return retVal;
        }

        /// <summary>
        /// Validates the width yard feet inches value greater then zero.
        /// </summary>
        /// <returns><c>true</c>, if width yard feet inches value 
        /// greater then zero was validated, 
        /// <c>false</c> otherwise.</returns>
        private bool ValidateWidthYardFeetInchesValueGreaterThenZero()
        {
            bool retVal = false;

            retVal = this.vd.ValidateDataIsNumericValue(txtWidthYard.Text);
            if (retVal)
            {
                return retVal;
            }

            retVal = this.vd.ValidateDataIsGreaterThenZero(txtWidthFeet.Text);
            if (retVal)
            {
                return retVal;
            }

            retVal = this.vd.ValidateDataIsGreaterThenZero(txtWidthInches.Text);
            if (retVal)
            {
                return retVal;
            }

            return retVal;
        }

        #endregion VALIDATION DATA

        /// <summary>
        /// Fills the data with data from textboxes.
        /// </summary>
        private void FillDataWithDataFromTextboxes()
        {
            double val = 0;

            val = this.conv.ConvertStringToDouble(txtLengthYard.Text);
            this.math.LengthInYards = val;

            val = this.conv.ConvertStringToDouble(txtLengthFeet.Text);
            this.math.LengthInFeet = val;

            val = this.conv.ConvertStringToDouble(txtLengthInches.Text);
            this.math.LengthInInches = val;

            val = this.conv.ConvertStringToDouble(txtWidthYard.Text);
            this.math.WidthInYards = val;

            val = this.conv.ConvertStringToDouble(txtWidthFeet.Text);
            this.math.WidthInFeet = val;

            val = this.conv.ConvertStringToDouble(txtWidthInches.Text);
            this.math.WidthInInches = val;
        }

        #region CONVERT DATA

        /// <summary>
        /// Converts the data to inches.
        /// </summary>
        /// <returns><c>true</c>, if data to inches was converted, 
        /// <c>false</c> otherwise.</returns>
        private bool ConvertDataToInches()
        {
            bool retVal = false;
            double val = 0;

            this.methodName = "private bool ConvertDataToInches()";
           
            val = this.rss.GetTheLengthTotalInches(
                this.math.LengthInYards,
                this.math.LengthInFeet, 
                this.math.LengthInInches);

            if (val <= 0)
            {
                return retVal;
            }
            else
            {
                this.math.LengthTotalInches = val;
            }

            val = this.rss.GetTheWidthsTotalInches(
                this.math.WidthInYards,
                this.math.WidthInFeet, 
                this.math.WidthInInches);

            if (val <= 0)
            {
                return retVal;
            }
            else
            {
                this.math.WidthTotalInches = val;
            }

            return retVal = true;
        }

        #endregion CONVERT DATA
    }
}