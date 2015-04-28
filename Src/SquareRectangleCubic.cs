//  SquareRectangleCubicArea.cs
//
//  Author:
//       art2m <>
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
    /// Square rectangle cubic area.
    /// </summary>
    public partial class SquareRectangleCubicArea : Gtk.Window
    {
        /// <summary>
        /// The name of the class.
        /// </summary>
        private const string MyClassName = 
            "public partial class SquareRectangleCubicArea : Gtk.Window";
       
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
        /// Create object of class ValidateData.
        /// </summary>
        private ValidateData vd = new ValidateData();

        /// <summary>
        /// The conv object decleration.
        /// </summary>
        private Conversions conv = new Conversions();

        /// <summary>
        /// The rss object decleration.
        /// </summary>
        private RectangleSquareSolve rss = new RectangleSquareSolve();

        /// <summary>
        /// The error message.
        /// </summary>
        private string errMsg = null;

        /// <summary>
        /// The name of the method.
        /// </summary> 
        private string methodName;

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
        /// <see cref="BuildingFormulas.SquareRectangleCubicArea"/> class.
        /// </summary>
        public SquareRectangleCubicArea()
            : base(Gtk.WindowType.Toplevel)
        {
            this.Build();

            this.metricUnits = false;
            this.standardUnits = true;
            btnStandard.Label = "Sandard On:";
            btnMetric.Label = "Metric Off:";
            this.SetCubicAreaLabelsStandardUnits();
            this.ShowUnitsCurrentlyBeingUsed();
        }

        #region BUTTON CLICKED EVENTS

        /// <summary>
        /// Raises the button clear form clicked event.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Instance containing the event data.</param>
        protected void OnBtnClearFormClicked(object sender, EventArgs e)
        {
            this.ClearData();
        }

        /// <summary>
        /// Raises the button clear store clicked event.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Instance containing the event data.</param>
        protected void OnBtnClearStoreClicked(object sender, EventArgs e)
        {
            StoreCubicStandardCollection.ClearArray();
        }

        /// <summary>
        /// Raises the button close clicked event.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Instance containing the event data.</param>
        protected void OnBtnCloseClicked(object sender, EventArgs e)
        {
            this.Destroy();
        }

        /// <summary>
        /// Raises the button convert clicked event.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Instance containing the event data..</param>
        protected void OnBtnConvertClicked(object sender, EventArgs e)
        {
            if (this.standardUnits)
            {
                this.metricUnits = true;
                this.standardUnits = false;
                this.SetCubicAreaLabelsMetricUnits();
                this.ConvertStandardUnitsDataToMetricUnits();
                lblInfo.Text = "Converted standard units to metric units.";
            }
            else if (this.metricUnits)
            {
                this.metricUnits = false;
                this.standardUnits = true;
                this.SetCubicAreaLabelsStandardUnits();
                this.ConvertMetricUnitsDataToStandardUnits();
                lblInfo.Text = "Converted metric units to standard units.";
            }
        }

        /// <summary>
        /// Raises the button display store clicked event.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Instance containing the event data.</param>
        protected void OnBtnDisplayStoreClicked(object sender, EventArgs e)
        {
            dlgDisplayStoredData dlgdsd = new dlgDisplayStoredData();
            dlgdsd.ShowAll();
        }

        /// <summary>
        /// Raises the button metric clicked event.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Instance containing the event data.</param>
        protected void OnBtnMetricClicked(object sender, EventArgs e)
        {
            this.metricUnits = true;
            this.standardUnits = false;
            btnStandard.Label = "Standard OFF:";
            btnMetric.Label = "Metric On:";
            this.SetCubicAreaLabelsMetricUnits();
            this.ShowUnitsCurrentlyBeingUsed();
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
        /// Raises the button solve clicked event.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Instance containing the event data.</param>
        protected void OnBtnSolveClicked(object sender, EventArgs e)
        {
            btnSolve.Sensitive = false;
            this.ShapeFormulaToSolveFor();
        }

        /// <summary>
        /// Raises the button standard clicked event.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Instance containing the event data.</param>
        protected void OnBtnStandardClicked(object sender, EventArgs e)
        {
            this.metricUnits = false;
            this.standardUnits = true;
            btnStandard.Label = "Standard On:";
            btnMetric.Label = "Metric Off:";
            this.SetCubicAreaLabelsStandardUnits();
            this.ShowUnitsCurrentlyBeingUsed();
        }

        /// <summary>
        /// Raises the button store results clicked event.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Instance containing the event data.</param>
        protected void OnBtnStoreResultsClicked(object sender, EventArgs e)
        {
            CubicAreaSquareRectangleStruct structRecSqCubic = new 
                CubicAreaSquareRectangleStruct();

            structRecSqCubic.StoreCubicStandard(
                degb.ShapeToSolveFor, 
                txtDepthYard.Text,
                txtDepthFeet.Text,
                txtDepthInches.Text,
                txtLengthYard.Text,
                txtLengthFeet.Text,
                txtLengthInches.Text,
                txtWidthYard.Text,
                txtWidthFeet.Text,
                txtWidthInches.Text,
                txtCubicYards.Text,
                txtCubicFeet.Text,
                txtCubicInches.Text);

            StoreCubicStandardCollection.AddNewItem(structRecSqCubic);
        }

        #endregion BUTTON CLICKED EVENTS


        #region VALIDATE DATA STRINGS NOT NULL OR EMPTY

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

                txtDepthFeet.Text = txtDepthFeet.Text.Trim();
                retVal = this.vd.ValidateDataExists(txtDepthFeet.Text);
                if (retVal)
                {
                    return retVal;
                }
                else
                {   
                    // Place a zero in textbox and return true.
                    txtDepthFeet.Text = "0";
                    return retVal = true;
                }
            }
            catch (FormatException ex)
            {
                this.errMsg = 
                    "Depth in feet entry not a valid numeric value."; 
                this.myMsg.BuildErrorString(
                    MyClassName, 
                    this.methodName, 
                    this.errMsg,
                    ex.ToString());  

                // Error so return false.
                return retVal;
            }
            catch (OverflowException ex)
            {
                this.errMsg = 
                    "Depth in feet entry numeric value is to large.";
                this.myMsg.BuildErrorString(
                    MyClassName, 
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

                txtDepthInches.Text = txtDepthInches.Text.Trim();
                if (this.vd.ValidateDataExists(txtDepthInches.Text))
                {
                    return retVal = true;
                }
                else
                {
                    // Place a zero in textbox and return true.
                    txtDepthInches.Text = "0";
                    return retVal = true;
                }
            }
            catch (FormatException ex)
            {
                this.errMsg =
                    "Depth in inches entry not a valid numeric value."; 
                this.myMsg.BuildErrorString(
                    MyClassName, 
                    this.methodName, 
                    this.errMsg,
                    ex.ToString());   

                // Error so return false.
                return retVal;
            }
            catch (OverflowException ex)
            {
                this.errMsg =
                    "Depth in inches entry numeric value is to large.";
                this.myMsg.BuildErrorString(
                    MyClassName, 
                    this.methodName, 
                    this.errMsg,
                    ex.ToString());

                // Error so return false.
                return retVal;
            }
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

                txtDepthYard.Text = txtDepthYard.Text.Trim();

                // Check to see if box is empty.
                retVal = this.vd.ValidateDataExists(txtDepthYard.Text);
                if (retVal)
                {
                    return retVal;     
                }
                else
                {
                    // Place a zero in textbox and return true.
                    txtDepthYard.Text = "0";
                    return retVal = true;
                }
            }
            catch (FormatException ex)
            {
                this.errMsg = 
                    "Depth in yards entry not a valid numeric value."; 
                this.myMsg.BuildErrorString(
                    MyClassName, 
                    this.methodName, 
                    this.errMsg,
                    ex.ToString());

                // Error so return false.
                return retVal;
            }
            catch (OverflowException ex)
            {
                this.errMsg = 
                    "Depth in yards entry numeric value is to large.";
                this.myMsg.BuildErrorString(
                    MyClassName, 
                    this.methodName, 
                    this.errMsg,
                    ex.ToString());
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

                txtLengthFeet.Text = txtLengthFeet.Text.Trim();
                retVal = this.vd.ValidateDataExists(txtLengthFeet.Text);
                if (retVal)
                {
                    return retVal;
                }
                else
                {   
                    // Place a zero in textbox and return true.
                    txtLengthFeet.Text = "0";
                    return retVal = true;
                }
            }
            catch (FormatException ex)
            {
                this.errMsg =
                    "Length in feet entry not a valid numeric value."; 
                this.myMsg.BuildErrorString(
                    MyClassName, 
                    this.methodName, 
                    this.errMsg,
                    ex.ToString());  

                // Error so return false.
                return retVal;
            }
            catch (OverflowException ex)
            {
                this.errMsg =
                    "Length in feet entry numeric value is to large.";
                this.myMsg.BuildErrorString(
                    MyClassName, 
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

                txtLengthInches.Text = txtLengthInches.Text.Trim();
                if (this.vd.ValidateDataExists(txtLengthInches.Text))
                {
                    return retVal = true;
                }
                else
                {
                    // Place a zero in textbox and return true.
                    txtLengthInches.Text = "0";
                    return retVal = true;
                }
            }
            catch (FormatException ex)
            {
                this.errMsg =
                    "Length in inches entry not a valid numeric value."; 
                this.myMsg.BuildErrorString(
                    MyClassName, 
                    this.methodName, 
                    this.errMsg,
                    ex.ToString());   

                // Error so return false.
                return retVal;
            }
            catch (OverflowException ex)
            {
                this.errMsg =
                    "Length in inches entry numeric value is to large.";
                this.myMsg.BuildErrorString(
                    MyClassName, 
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

                txtLengthYard.Text = txtLengthYard.Text.Trim();
                if (this.vd.ValidateDataExists(txtLengthYard.Text))
                {
                    return retVal = true;
                }
                else
                {
                    // Place a zero in textbox and return true.
                    txtLengthYard.Text = "0";
                    return retVal = true;
                }
            }
            catch (FormatException ex)
            {
                this.errMsg = 
                    "Length in yards entry not a valid numeric value."; 
                this.myMsg.BuildErrorString(
                    MyClassName, 
                    this.methodName, 
                    this.errMsg,
                    ex.ToString());   

                // Error so return false.
                return retVal;
            }
            catch (OverflowException ex)
            {
                this.errMsg = 
                    "Length in yards entry numeric value is to large.";
                this.myMsg.BuildErrorString(
                    MyClassName, 
                    this.methodName, 
                    this.errMsg,
                    ex.ToString());

                // Error so return false.
                return retVal;
            }
        }

        /// <summary>
        /// Validates the text boxes feet not empty.
        /// </summary>
        /// <returns><c>true</c>, if text boxes feet 
        /// not empty was validated, <c>false</c> 
        /// otherwise.</returns>
        private bool ValidateTextBoxesFeetNotEmpty()
        {
            bool retVal = false;

            this.methodName = "private bool ValidateTextBoxesFeetNotEmpty()";

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

            return retVal;
        }

        /// <summary>
        /// Validates the cubic area inches square shape.
        /// </summary>
        /// <returns><c>true</c>, if cubic area inches square 
        /// shape was validated, <c>false</c> otherwise.</returns>
        private bool ValidateTextBoxesInchesNotEmpty()
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

            return retVal;
        }

        /// <summary>
        /// Validates the cubic area yards square shape.
        /// </summary>
        /// <returns><c>true</c>, if cubic area yards 
        /// square shape was validated, <c>false</c> 
        /// otherwise.</returns>
        private bool ValidateTextBoxesNotEmpty()
        {
            bool retVal = false;

            this.methodName = "private bool ValidateTextBoxesNotEmpty()";

            retVal = this.ValidateTextBoxYardsNotEmpty();
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

                txtWidthFeet.Text = txtWidthFeet.Text.Trim();
                retVal = this.vd.ValidateDataExists(txtWidthFeet.Text);
                if (retVal)
                {
                    return retVal;
                }
                else
                {   
                    // Place a zero in textbox and return true.
                    txtWidthFeet.Text = "0";
                    return retVal = true;
                }
            }
            catch (FormatException ex)
            {
                this.errMsg = 
                    "Width in feet entry not a valid numeric value."; 
                this.myMsg.BuildErrorString(
                    MyClassName, 
                    this.methodName, 
                    this.errMsg,
                    ex.ToString());  

                // Error so return false.
                return retVal;
            }
            catch (OverflowException ex)
            {
                this.errMsg =
                    "Width in feet entry numeric value is to large.";
                this.myMsg.BuildErrorString(
                    MyClassName, 
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

                txtWidthInches.Text = txtWidthInches.Text.Trim();
                if (this.vd.ValidateDataExists(txtWidthInches.Text))
                {
                    return retVal = true;
                }
                else
                {
                    // Place a zero in textbox and return true.
                    txtWidthInches.Text = "0";
                    return retVal = true;
                }
            }
            catch (FormatException ex)
            {
                this.errMsg =
                    "Width in inches entry not a valid numeric value."; 
                this.myMsg.BuildErrorString(
                    MyClassName, 
                    this.methodName, 
                    this.errMsg,
                    ex.ToString());   

                // Error so return false.
                return retVal;
            }
            catch (OverflowException ex)
            {
                this.errMsg =
                    "Width in inches entry numeric value is to large.";
                this.myMsg.BuildErrorString(
                    MyClassName, 
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

                txtWidthYard.Text = txtWidthYard.Text.Trim();
                if (this.vd.ValidateDataExists(txtWidthYard.Text))
                {
                    return retVal = true;
                }
                else
                {
                    // Place a zero in textbox and return true.
                    txtWidthYard.Text = "0";
                    return retVal = true;
                }
            }
            catch (FormatException ex)
            {
                this.errMsg =
                    "Width in yards entry not a valid numeric value."; 
                this.myMsg.BuildErrorString(
                    MyClassName, 
                    this.methodName, 
                    this.errMsg,
                    ex.ToString());   

                // Error so return false.
                return retVal;
            }
            catch (OverflowException ex)
            {
                this.errMsg =
                    "Width in yards entry numeric value is to large.";
                this.myMsg.BuildErrorString(
                    MyClassName, 
                    this.methodName, 
                    this.errMsg,
                    ex.ToString());

                // Error so return false.
                return retVal;
            }
        }

        /// <summary>
        /// Validates the text box yards not empty.
        /// </summary>
        /// <returns><c>true</c>, if text box yards not 
        /// empty was validated, <c>false</c> 
        /// otherwise.</returns>
        private bool ValidateTextBoxYardsNotEmpty()
        {
            bool retVal = false;

            this.methodName = "private bool ValidateTextBoxYardsNotEmpty()";

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
                
            return retVal;
        }

        #endregion VALIDATE DATA STRINGS NOT NULL OR EMPTY

        #region VALIDATE DATA CONTAINS NUMERIC STRING

        /// <summary>
        /// Validates the text boxes depth feet has numeric value.
        /// </summary>
        /// <returns><c>true</c>, if text boxes depth feet has 
        /// numeric value was validated, <c>false</c> 
        /// otherwise.</returns>
        private bool ValidateTextBoxesDepthFeetHasNumericValue()
        {
            bool retVal = false;

            try
            {
                this.methodName = 
                    "private bool ValidateTextBoxesDepthFeetHasNumericValue()";

                retVal = 
                    this.vd.ValidateDataIsNumericValue(txtDepthFeet.Text);
                if (!retVal)
                {
                    this.errMsg =
                        "Depth in feet entry not a valid numeric value."; 
                    this.myMsg.ShowErrMessage(this.errMsg);

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
                this.errMsg =
                    "Depth in feet entry not a valid numeric value."; 
                this.myMsg.BuildErrorString(
                    MyClassName, 
                    this.methodName, 
                    this.errMsg,
                    ex.ToString());   

                // Error so return false.
                return retVal;
            }
            catch (OverflowException ex)
            {
                this.errMsg =
                    "Depth in feet entry numeric value is to large.";
                this.myMsg.BuildErrorString(
                    MyClassName, 
                    this.methodName, 
                    this.errMsg,
                    ex.ToString());

                // Error so return false.
                return retVal;
            }
        }

        /// <summary>
        /// Validates the text box depth inches has numeric value.
        /// </summary>
        /// <returns><c>true</c>, if text box depth inches has 
        /// numeric value was validated, <c>false</c> 
        /// otherwise.</returns>
        private bool ValidateTextBoxDepthInchesHasNumericValue()
        {
            bool retVal = false;

            try
            {
                this.methodName = 
                    "private bool ValidateTextBoxDepthInchesHasNumericValue()";

                retVal = 
                    this.vd.ValidateDataIsNumericValue(txtDepthInches.Text);
                if (!retVal)
                {
                    this.errMsg = 
                        "Depth in inches entry not a valid numeric value."; 
                    this.myMsg.ShowErrMessage(this.errMsg);

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
                this.errMsg =
                    "Depth in inches entry not a valid numeric value."; 
                this.myMsg.BuildErrorString(
                    MyClassName, 
                    this.methodName, 
                    this.errMsg,
                    ex.ToString());   

                // Error so return false.
                return retVal;
            }
            catch (OverflowException ex)
            {
                this.errMsg =
                    "Depth in inches entry numeric value is to large.";
                this.myMsg.BuildErrorString(
                    MyClassName, 
                    this.methodName, 
                    this.errMsg,
                    ex.ToString());

                // Error so return false.
                return retVal;
            }
        }

        /// <summary>
        /// Validates the text boxes depth yard has numeric value.
        /// </summary>
        /// <returns><c>true</c>, if text boxes depth yard has 
        /// numeric value was validated, <c>false</c> 
        /// otherwise.</returns>
        private bool ValidateTextBoxesDepthYardHasNumericValue()
        {
            bool retVal = false;

            try
            {
                this.methodName = 
                    "private bool ValidateTextBoxesDepthYardHasNumericValue()";

                retVal = 
                    this.vd.ValidateDataIsNumericValue(txtDepthYard.Text);
                if (!retVal)
                {
                    this.errMsg = 
                        "Depth in yards entry not a valid numeric value."; 
                    this.myMsg.ShowErrMessage(this.errMsg); 

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
                this.errMsg =
                    "Depth in yards entry not a valid numeric value."; 
                this.myMsg.BuildErrorString(
                    MyClassName, 
                    this.methodName, 
                    this.errMsg,
                    ex.ToString());   

                // Error so return false.
                return retVal;
            }
            catch (OverflowException ex)
            {
                this.errMsg =
                    "Depth in yards entry numeric value is to large.";
                this.myMsg.BuildErrorString(
                    MyClassName, 
                    this.methodName, 
                    this.errMsg,
                    ex.ToString());

                // Error so return false.
                return retVal;
            }
        }

        /// <summary>
        /// Validates the text boxes feet has numeric value.
        /// </summary>
        /// <returns><c>true</c>, if text boxes feet has 
        /// numeric value was validated, <c>false</c>
        /// otherwise.</returns>
        private bool ValidateTextBoxesFeetHasNumericValue()
        {
            bool retVal = false;
            string message = null;

            this.methodName = "private bool ValidateTextBoxesFeetHasNumericValue()";

            retVal = this.vd.ValidateDataIsNumericValue(txtDepthFeet.Text);
            if (!retVal)
            {
                message = "The depth in feet must have a numeric value. " +
                "Enter zero if it is not going to be used.";
                this.myMsg.ShowErrMessage(message);

                return retVal;
            }

            retVal = this.vd.ValidateDataIsNumericValue(txtLengthFeet.Text);
            if (!retVal)
            {
                message = "The length in feet must have a numeric value. " +
                "Enter zero if it is not going to be used.";
                this.myMsg.ShowErrMessage(message);

                return retVal;
            }

            retVal = this.vd.ValidateDataIsNumericValue(txtWidthFeet.Text);
            if (!retVal)
            {
                message = "The width in feet must have a numeric value. " +
                "Enter zero if it is not going to be used.";
                this.myMsg.ShowErrMessage(message);

                return retVal;
            }

            return retVal;
        }


        /// <summary>
        /// Validates the text boxes have numeric string value.
        /// </summary>
        /// <returns><c>true</c>, if text boxes have numeric 
        /// string value was validated, <c>false</c> 
        /// otherwise.</returns>
        private bool ValidateTextBoxesHaveNumericStringValue()
        {
            bool retVal = false;

            this.methodName = 
                "private bool ValidateTextBoxesHaveNumericStringValue()";

            retVal = this.ValidateTextBoxYardsHasNumericValue();
            if (!retVal)
            {
                return retVal;
            }

            retVal = this.ValidateTextBoxesFeetHasNumericValue();
            if (!retVal)
            {
                return retVal;
            }

            retVal = this.ValidateTextBoxInchesHasNumericValue();
            if (!retVal)
            {
                return retVal;
            }

            return retVal;
        }

        /// <summary>
        /// Validates the text box inches has numeric value.
        /// </summary>
        /// <returns><c>true</c>, if text box inches has 
        /// numeric value was validated, <c>false</c> 
        /// otherwise.</returns>
        private bool ValidateTextBoxInchesHasNumericValue()
        {
            bool retVal = false;
            string message = null;

            this.methodName = 
                "private bool ValidateTextBoxInchesHasNumericValue()";

            retVal = this.vd.ValidateDataIsNumericValue(txtDepthInches.Text);
            if (!retVal)
            {
                message = "The depth in inches must have a numeric value. " +
                "Enter zero if it is not going to be used.";
                this.myMsg.ShowErrMessage(message);

                return retVal;
            }

            retVal = this.vd.ValidateDataIsNumericValue(txtLengthInches.Text);
            if (!retVal)
            {
                message = "The length in inches must have a numeric value. " +
                "Enter zero if it is not going to be used.";
                this.myMsg.ShowErrMessage(message);

                return retVal;
            }

            retVal = this.vd.ValidateDataIsNumericValue(txtWidthInches.Text);
            if (!retVal)
            {
                message = "The width in inches must have a numeric value. " +
                "Enter zero if it is not going to be used.";
                this.myMsg.ShowErrMessage(message);

                return retVal;
            }

            return retVal;
        }

        /// <summary>
        /// Validates the cubic square length feet numeric.
        /// </summary>
        /// <returns><c>true</c>, if cubic square length 
        /// feet numeric was validated, <c>false</c> 
        /// otherwise.</returns>
        private bool ValidateCubicSquareLengthFeetNumeric()
        {
            bool retVal = false;

            try
            {
                this.methodName = 
                    "private bool ValidateCubicSquareLengthFeetNumeric()";

                retVal = 
                    this.vd.ValidateDataIsNumericValue(txtLengthFeet.Text);
                if (!retVal)
                {
                    this.errMsg = 
                        "Length in feet entry not a valid numeric value."; 
                    this.myMsg.ShowErrMessage(this.errMsg);

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
                this.errMsg =
                    "Length in feet entry not a valid numeric value."; 
                this.myMsg.BuildErrorString(
                    MyClassName, 
                    this.methodName, 
                    this.errMsg,
                    ex.ToString());   

                // Error so return false.
                return retVal;
            }
            catch (OverflowException ex)
            {
                this.errMsg =
                    "Length in feet entry numeric value is to large.";
                this.myMsg.BuildErrorString(
                    MyClassName, 
                    this.methodName, 
                    this.errMsg,
                    ex.ToString());

                // Error so return false.
                return retVal;
            }
        }

        /// <summary>
        /// Validates the cubic square length inches numeric.
        /// </summary>
        /// <returns><c>true</c>, if cubic square length 
        /// inches numeric was validated, <c>false</c> 
        /// otherwise.</returns>
        private bool ValidateCubicSquareLengthInchesNumeric()
        {
            bool retVal = false;

            try
            {
                this.methodName = 
                    "private bool ValidateCubicSquareLengthInchesNumeric()";

                retVal = 
                    this.vd.ValidateDataIsNumericValue(txtLengthInches.Text);
                if (!retVal)
                {
                    this.errMsg =
                        "Length in inches entry not a valid numeric value."; 
                    this.myMsg.ShowErrMessage(this.errMsg);

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
                this.errMsg =
                    "Length in inches entry not a valid numeric value."; 
                this.myMsg.BuildErrorString(
                    MyClassName, 
                    this.methodName, 
                    this.errMsg,
                    ex.ToString());   

                // Error so return false.
                return retVal;
            }
            catch (OverflowException ex)
            {
                this.errMsg =
                    "Length in inches entry numeric value is to large.";
                this.myMsg.BuildErrorString(
                    MyClassName, 
                    this.methodName, 
                    this.errMsg,
                    ex.ToString());

                // Error so return false.
                return retVal;
            }
        }

        /// <summary>
        /// Validates the cubic square length yards numeric.
        /// </summary>
        /// <returns><c>true</c>, if cubic square length 
        /// yards numeric was validated, <c>false</c> 
        /// otherwise.</returns>
        private bool ValidateCubicSquareLengthYardsNumeric()
        {
            bool retVal = false;

            try
            {
                this.methodName = 
                    "private bool ValidateCubicSquareLengthYardsNumeric()";

                retVal = 
                    this.vd.ValidateDataIsNumericValue(txtLengthYard.Text);
                if (!retVal)
                {
                    this.errMsg =
                        "Depth in yards entry not a valid numeric value."; 
                    this.myMsg.ShowErrMessage(this.errMsg); 

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
                this.errMsg =
                    "Length in yards entry not a valid numeric value."; 
                this.myMsg.BuildErrorString(
                    MyClassName, 
                    this.methodName, 
                    this.errMsg,
                    ex.ToString());   

                // Error so return false.
                return retVal;
            }
            catch (OverflowException ex)
            {
                this.errMsg = 
                    "Length in yards entry numeric value is to large.";
                this.myMsg.BuildErrorString(
                    MyClassName, 
                    this.methodName, 
                    this.errMsg,
                    ex.ToString());

                // Error so return false.
                return retVal;
            }
        }

        /// <summary>
        /// Validates the cubic squard width feet numeric.
        /// </summary>
        /// <returns><c>true</c>, if cubic squard width feet 
        /// numeric was validated, <c>false</c> 
        /// otherwise.</returns>
        private bool ValidateCubicSquardWidthFeetNumeric()
        {
            bool retVal = false;

            try
            {
                this.methodName = 
                    "private bool ValidateCubicSquardWidthFeetNumeric()";

                retVal = 
                    this.vd.ValidateDataIsNumericValue(txtWidthFeet.Text);
                if (!retVal)
                {
                    this.errMsg =
                        "Width in feet entry not a valid numeric value."; 
                    this.myMsg.ShowErrMessage(this.errMsg);

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
                this.errMsg =
                    "Width in feet entry not a valid numeric value."; 
                this.myMsg.BuildErrorString(
                    MyClassName, 
                    this.methodName, 
                    this.errMsg,
                    ex.ToString());   

                // Error so return false.
                return retVal;
            }
            catch (OverflowException ex)
            {
                this.errMsg =
                    "Width in feet entry numeric value is to large.";
                this.myMsg.BuildErrorString(
                    MyClassName, 
                    this.methodName, 
                    this.errMsg,
                    ex.ToString());

                // Error so return false.
                return retVal;
            }
        }

        /// <summary>
        /// Validates the cubic square width inches numeric.
        /// </summary>
        /// <returns><c>true</c>, if cubic square width inches 
        /// numeric was validated, <c>false</c> 
        /// otherwise.</returns>
        private bool ValidateCubicSquareWidthInchesNumeric()
        {
            bool retVal = false;

            try
            {
                this.methodName = 
                    "private bool ValidateCubicSquareWidthInchesNumeric()";

                retVal = 
                    this.vd.ValidateDataIsNumericValue(txtWidthInches.Text);
                if (!retVal)
                {
                    this.errMsg =
                        "Width in inches entry not a valid numeric value."; 
                    this.myMsg.ShowErrMessage(this.errMsg);

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
                this.errMsg = 
                    "Width in inches entry not a valid numeric value."; 
                this.myMsg.BuildErrorString(
                    MyClassName, 
                    this.methodName, 
                    this.errMsg,
                    ex.ToString());   

                // Error so return false.
                return retVal;
            }
            catch (OverflowException ex)
            {
                this.errMsg = 
                    "Width in inches entry numeric value is to large.";
                this.myMsg.BuildErrorString(
                    MyClassName, 
                    this.methodName, 
                    this.errMsg,
                    ex.ToString());

                // Error so return false.
                return retVal;
            }
        }

        /// <summary>
        /// Validates the text box yards has numeric value.
        /// </summary>
        /// <returns><c>true</c>, if text box yards has 
        /// numeric value was validated, 
        /// <c>false</c> otherwise.</returns>
        private bool ValidateTextBoxYardsHasNumericValue()
        {
            bool retVal = false;
            string message = null;

            this.methodName = "private bool ValidateTextBoxYardsHasNumericValue()";           

            retVal = this.vd.ValidateDataIsNumericValue(txtDepthYard.Text);
            if (!retVal)
            {
                message = "The depth in yards must have a numeric value. " +
                "Enter zero if it is not going to be used.";
                this.myMsg.ShowErrMessage(message);

                return retVal;
            }

            retVal = this.vd.ValidateDataIsNumericValue(txtLengthYard.Text);
            if (!retVal)
            {
                message = "The length in yards must have a numeric value. " +
                "Enter zero if it is not going to be used.";
                this.myMsg.ShowErrMessage(message);

                return retVal;
            }

            retVal = this.vd.ValidateDataIsNumericValue(txtWidthYard.Text);
            if (!retVal)
            {
                message = "The width in yards must have a numeric value. " +
                "Enter zero if it is not going to be used.";
                this.myMsg.ShowErrMessage(message);

                return retVal;
            }

            return retVal;
        }

        /// <summary>
        /// Validates the cubic square width yards numeric.
        /// </summary>
        /// <returns><c>true</c>, if cubic square width yards 
        /// numeric was validated, <c>false</c> 
        /// otherwise.</returns>
        private bool ValidateCubicSquareWidthYardsNumeric()
        {
            bool retVal = false;

            try
            {
                this.methodName = 
                    "private bool ValidateCubicSquareWidthYardsNumeric()";

                retVal = 
                    this.vd.ValidateDataIsNumericValue(txtWidthYard.Text);
                if (!retVal)
                {
                    this.errMsg = 
                        "Width in yards entry not a valid numeric value."; 
                    this.myMsg.ShowErrMessage(this.errMsg); 

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
                this.errMsg =
                    "Width in yards entry not a valid numeric value."; 
                this.myMsg.BuildErrorString(
                    MyClassName, 
                    this.methodName, 
                    this.errMsg,
                    ex.ToString());   

                // Error so return false.
                return retVal;
            }
            catch (OverflowException ex)
            {
                this.errMsg =
                    "Width in yards entry numeric value is to large.";
                this.myMsg.BuildErrorString(
                    MyClassName, 
                    this.methodName, 
                    this.errMsg,
                    ex.ToString());

                // Error so return false.
                return retVal;
            }
        }

        #endregion VALIDATE DATA CONTAINS NUMERIC STRING

        #region VALIDATE DATA CONTAINS NUMERIC STRING > ZERO

        /// <summary>
        /// Validates the text boxes have numeric value greater than zero.
        /// </summary>
        /// <returns><c>true</c>, if text boxes have numeric value 
        /// greater than zero was validated, <c>false</c> 
        /// otherwise.</returns>
        private bool ValidateTextBoxesHaveNumericValueGreaterThanZero()
        {
            bool retVal = false;

            this.methodName = "private bool " +
            "ValidateTextBoxesHaveNumericValueGreaterThanZero()";

            retVal = this.ValidateBoxDepthYdFtInchHasValueGreaterThanZero();
            if (!retVal)
            {
                return retVal;
            }

            retVal = this.ValidateBoxLengthYdFtInchHasValueGreaterThanZero();
            if (!retVal)
            {
                return retVal;
            }

            retVal = this.ValidateBoxWidthYdFtInchHasValueGreaterThanZero();
            if (!retVal)
            {
                return retVal;
            }

            return retVal;
        }

        /// <summary>
        /// Validates the box depth yd ft inch has value greater than zero.
        /// </summary>
        /// <returns><c>true</c>, if box depth yd ft inch has value 
        /// greater than zero was validated, <c>false</c> 
        /// otherwise.</returns>
        private bool ValidateBoxDepthYdFtInchHasValueGreaterThanZero()
        {
            bool retVal = false;
            string message = null;

            this.methodName = "private bool " +
            "ValidateBoxDepthYdFtInchHasValueGreaterThanZero()";

            retVal = this.vd.ValidateDataIsGreaterThenZero(txtDepthYard.Text);
            if (retVal)
            {
                return retVal;
            }

            retVal = this.vd.ValidateDataIsGreaterThenZero(txtDepthFeet.Text);
            if (retVal)
            {
                return retVal;
            }

            retVal = this.vd.ValidateDataIsGreaterThenZero(txtDepthInches.Text);
            if (retVal)
            {
                return retVal;
            }

            message = "At leas one of the depth values yards, feet or inches " +
            "must containe a numeric value greater then zero.";           
            this.myMsg.ShowErrMessage(message);

            return retVal;
        }

        /// <summary>
        /// Validates the box length yd ft inch has value greater than zero.
        /// </summary>
        /// <returns><c>true</c>, if box length yd ft inch has 
        /// value greater than zero was validated, 
        /// <c>false</c> otherwise.</returns>
        private bool ValidateBoxLengthYdFtInchHasValueGreaterThanZero()
        {
            bool retVal = false;
            string message = null;

            this.methodName = "private bool " +
            "ValidateBoxLengthYdFtInchHasValueGreaterThanZero()";

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

            retVal = this.vd.ValidateDataIsGreaterThenZero(
                txtLengthInches.Text);
            if (retVal)
            {
                return retVal;
            }

            message = "At leas one of the Length values yards, feet or " +
            "inches must containe a numeric value greater then zero.";
            this.myMsg.ShowErrMessage(message);

            return retVal;
        }

        /// <summary>
        /// Validates the box width yd ft inch has value greater than zero.
        /// </summary>
        /// <returns><c>true</c>, if box width yd ft inch has value 
        /// greater than zero was validated, 
        /// <c>false</c> otherwise.</returns>
        private bool ValidateBoxWidthYdFtInchHasValueGreaterThanZero()
        {
            bool retVal = false;
            string message = null;

            this.methodName = "private bool " +
            "ValidateBoxWidthYdFtInchHasValueGreaterThanZero()";

            retVal = this.vd.ValidateDataIsGreaterThenZero(txtWidthYard.Text);
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

            message = "At leas one of the width values yards, feet or " +
            "inches must containe a numeric value greater then zero.";
            this.myMsg.ShowErrMessage(message);

            return retVal;
        }

        /// <summary>
        /// Validates the cubic square depth yards greater then zero.
        /// </summary>
        /// <returns><c>true</c>, if cubic square depth yards 
        /// greater then zero was validated, <c>false</c> 
        /// otherwise.</returns>
        private bool ValidateCubicSquareDepthYardsGreaterThenZero()
        {
            bool retVal = false;

            try
            {
                this.methodName = 
                    "private bool ValidateCubicSquareWidthYardsNumeric()";

                retVal = 
                    this.vd.ValidateDataIsGreaterThenZero(txtDepthYard.Text);

                return retVal;
            }
            catch (FormatException ex)
            {
                this.errMsg = 
                    "Depth in yards entry not a valid numeric value."; 
                this.myMsg.BuildErrorString(
                    MyClassName, 
                    this.methodName, 
                    this.errMsg,
                    ex.ToString());   

                // Error so return false.
                return retVal;
            }
            catch (OverflowException ex)
            {
                this.errMsg = 
                    "Depth in yards entry numeric value is to large.";
                this.myMsg.BuildErrorString(
                    MyClassName, 
                    this.methodName, 
                    this.errMsg,
                    ex.ToString());

                // Error so return false.
                return retVal;
            }
        }

        /// <summary>
        /// Validates the cubic square depth feet greater then zero.
        /// </summary>
        /// <returns><c>true</c>, if cubic square depth feet 
        /// greater then zero was validated, <c>false</c> 
        /// otherwise.</returns>
        private bool ValidateCubicSquareDepthFeetGreaterThenZero()
        {
            bool retVal = false;

            try
            {
                this.methodName = 
                    "private bool " +
                "ValidateCubicSquareDepthFeetGreaterThenZero()";

                retVal = 
                    this.vd.ValidateDataIsGreaterThenZero(txtDepthFeet.Text);

                return retVal;
            }
            catch (FormatException ex)
            {
                this.errMsg = 
                    "Depth in feet entry not a valid numeric value."; 
                this.myMsg.BuildErrorString(
                    MyClassName, 
                    this.methodName, 
                    this.errMsg,
                    ex.ToString());   

                // Error so return false.
                return retVal;
            }
            catch (OverflowException ex)
            {
                this.errMsg =
                    "Depth in feet entry numeric value is to large.";
                this.myMsg.BuildErrorString(
                    MyClassName, 
                    this.methodName, 
                    this.errMsg,
                    ex.ToString());

                // Error so return false.
                return retVal;
            }
        }

        /// <summary>
        /// Validates the cubic square depth inches greater then zero.
        /// </summary>
        /// <returns><c>true</c>, if cubic square depth inches 
        /// greater then zero was validated, <c>false</c> 
        /// otherwise.</returns>
        private bool ValidateCubicSquareDepthInchesGreaterThenZero()
        {
            bool retVal = false;

            try
            {
                this.methodName = "private bool " +
                "ValidateCubicSquareDepthInchesGreaterThenZero()";

                retVal = 
                    this.vd.ValidateDataIsGreaterThenZero(txtDepthInches.Text);

                return retVal;
            }
            catch (FormatException ex)
            {
                this.errMsg =
                    "Depth in inches entry not a valid numeric value."; 
                this.myMsg.BuildErrorString(
                    MyClassName, 
                    this.methodName, 
                    this.errMsg,
                    ex.ToString());   

                // Error so return false.
                return retVal;
            }
            catch (OverflowException ex)
            {
                this.errMsg =
                    "Depth in inches entry numeric value is to large.";
                this.myMsg.BuildErrorString(
                    MyClassName, 
                    this.methodName, 
                    this.errMsg,
                    ex.ToString());

                // Error so return false.
                return retVal;
            }
        }

        /// <summary>
        /// Validates the cubic area square lenght yards greater then zero.
        /// </summary>
        /// <returns><c>true</c>, if cubic area square lenght yards 
        /// greater then zero was validated, <c>false</c> 
        /// otherwise.</returns>
        private bool ValidateCubicAreaSquareLenghtYardsGreaterThenZero()
        {
            bool retVal = false;

            try
            {
                this.methodName = 
                    "private bool " +
                "ValidateCubicAreaSquareLenghtYardsGreaterThenZero()";

                retVal = 
                    this.vd.ValidateDataIsGreaterThenZero(txtLengthYard.Text);

                return retVal;
            }
            catch (FormatException ex)
            {
                this.errMsg =
                    "Length in yards entry not a valid numeric value."; 
                this.myMsg.BuildErrorString(
                    MyClassName, 
                    this.methodName, 
                    this.errMsg,
                    ex.ToString());   

                // Error so return false.
                return retVal;
            }
            catch (OverflowException ex)
            {
                this.errMsg =
                    "Length in yards entry numeric value is to large.";
                this.myMsg.BuildErrorString(
                    MyClassName, 
                    this.methodName, 
                    this.errMsg,
                    ex.ToString());

                // Error so return false.
                return retVal;
            }
        }

        /// <summary>
        /// Validaes the cubic area square length feet greater then zero.
        /// </summary>
        /// <returns><c>true</c>, if cubic area square length feet 
        /// greater then zero was validaed, <c>false</c> 
        /// otherwise.</returns>
        private bool ValidaeCubicAreaSquareLengthFeetGreaterThenZero()
        {
            bool retVal = false;

            try
            {
                this.methodName = 
                    "private bool " +
                "ValidaeCubicAreaSquareLengthFeetGreaterThenZero()";

                retVal = 
                    this.vd.ValidateDataIsGreaterThenZero(txtLengthFeet.Text);

                return retVal;
            }
            catch (FormatException ex)
            {
                this.errMsg =
                    "Length in feet entry not a valid numeric value."; 
                this.myMsg.BuildErrorString(
                    MyClassName, 
                    this.methodName, 
                    this.errMsg,
                    ex.ToString());   

                // Error so return false.
                return retVal;
            }
            catch (OverflowException ex)
            {
                this.errMsg =
                    "Length in feet entry numeric value is to large.";
                this.myMsg.BuildErrorString(
                    MyClassName, 
                    this.methodName, 
                    this.errMsg,
                    ex.ToString());

                // Error so return false.
                return retVal;
            }
        }

        /// <summary>
        /// Validates the cubic area square length inches greater then zero.
        /// </summary>
        /// <returns><c>true</c>, if cubic area square length inches 
        /// greater then zero was validated, <c>false</c> 
        /// otherwise.</returns>
        private bool ValidateCubicAreaSquareLengthInchesGreaterThenZero()
        {
            bool retVal = false;

            try
            {
                this.methodName = "private bool " +
                "ValidateCubicAreaSquareLengthInchesGreaterThenZero()";

                retVal = 
                    this.vd.ValidateDataIsGreaterThenZero(txtLengthInches.Text);

                return retVal;
            }
            catch (FormatException ex)
            {
                this.errMsg =
                    "Length in inches entry not a valid numeric value."; 
                this.myMsg.BuildErrorString(
                    MyClassName, 
                    this.methodName, 
                    this.errMsg,
                    ex.ToString());   

                // Error so return false.
                return retVal;
            }
            catch (OverflowException ex)
            {
                this.errMsg =
                    "Length in inches entry numeric value is to large.";
                this.myMsg.BuildErrorString(
                    MyClassName, 
                    this.methodName, 
                    this.errMsg,
                    ex.ToString());

                // Error so return false.
                return retVal;
            }
        }

        /// <summary>
        /// Validates the cubic area square width yards greater then zero.
        /// </summary>
        /// <returns><c>true</c>, if cubic area square width yards 
        /// greater then zero was validated, <c>false</c> 
        /// otherwise.</returns>
        private bool ValidateCubicAreaSquareWidthYardsGreaterThenZero()
        {
            bool retVal = false;

            try
            {
                this.methodName = 
                    "private bool " +
                "ValidateCubicAreaSquareWidthYardsGreaterThenZero()";

                retVal = 
                    this.vd.ValidateDataIsGreaterThenZero(txtWidthYard.Text);

                return retVal;
            }
            catch (FormatException ex)
            {
                this.errMsg = 
                    "Width in yards entry not a valid numeric value."; 
                this.myMsg.BuildErrorString(
                    MyClassName, 
                    this.methodName, 
                    this.errMsg,
                    ex.ToString());   

                // Error so return false.
                return retVal;
            }
            catch (OverflowException ex)
            {
                this.errMsg =
                    "Width in yards entry numeric value is to large.";
                this.myMsg.BuildErrorString(
                    MyClassName, 
                    this.methodName, 
                    this.errMsg,
                    ex.ToString());

                // Error so return false.
                return retVal;
            }
        }

        /// <summary>
        /// Validates the cubic area square width feet greater then zero.
        /// </summary>
        /// <returns><c>true</c>, if cubic area square width feet 
        /// greater then zero was validated, <c>false</c> 
        /// otherwise.</returns>
        private bool ValidateCubicAreaSquareWidthFeetGreaterThenZero()
        {
            bool retVal = false;

            try
            {
                this.methodName = 
                    "private bool " +
                "ValidateCubicAreaSquareWidthFeetGreaterThenZero()";

                retVal = 
                    this.vd.ValidateDataIsGreaterThenZero(txtWidthFeet.Text);

                return retVal;
            }
            catch (FormatException ex)
            {
                this.errMsg =
                    "Width in feet entry not a valid numeric value."; 
                this.myMsg.BuildErrorString(
                    MyClassName, 
                    this.methodName, 
                    this.errMsg,
                    ex.ToString());   

                // Error so return false.
                return retVal;
            }
            catch (OverflowException ex)
            {
                this.errMsg =
                    "Width in feet entry numeric value is to large.";
                this.myMsg.BuildErrorString(
                    MyClassName, 
                    this.methodName, 
                    this.errMsg,
                    ex.ToString());

                // Error so return false.
                return retVal;
            }
        }

        /// <summary>
        /// Validates the cubic area square with inches greater then zero.
        /// </summary>
        /// <returns><c>true</c>, if cubic area square with inches 
        /// greater then zero was validated, <c>false</c> 
        /// otherwise.</returns>
        private bool ValidateCubicAreaSquareWdithInchesGreaterThenZero()
        {
            bool retVal = false;

            try
            {
                this.methodName = "private bool " +
                "ValidateCubicAreaSquareWithInchesGreaterThenZero()";

                retVal = 
                    this.vd.ValidateDataIsGreaterThenZero(txtWidthInches.Text);

                return retVal;
            }
            catch (FormatException ex)
            {
                this.errMsg =
                    "Width in inches entry not a valid numeric value."; 
                this.myMsg.BuildErrorString(
                    MyClassName, 
                    this.methodName, 
                    this.errMsg,
                    ex.ToString());   

                // Error so return false.
                return retVal;
            }
            catch (OverflowException ex)
            {
                this.errMsg =
                    "Width in inches entry numeric value is to large.";
                this.myMsg.BuildErrorString(
                    MyClassName, 
                    this.methodName, 
                    this.errMsg,
                    ex.ToString());

                // Error so return false.
                return retVal;
            }
        }

        #endregion VALIDATE DATA CONTAINS NUMERIC STRING > ZERO

        #region CLEAR ALL DATA

        /// <summary>
        /// Clears the data from rectangle square solve.
        /// </summary>
        private void ClearData()
        {
            txtDepthYard.Text = "0";
            txtDepthFeet.Text = "0";
            txtDepthInches.Text = "0";

            txtLengthYard.Text = "0";
            txtLengthFeet.Text = "0";
            txtLengthFeet.Text = "0";

            txtWidthYard.Text = "0";
            txtWidthFeet.Text = "0";
            txtWidthInches.Text = "0";

            this.math.DepthInYards = 0;
            this.math.DepthInFeet = 0;
            this.math.DepthInInches = 0;
            this.math.LengthInYards = 0;
            this.math.LengthInFeet = 0;
            this.math.LengthInInches = 0;
            this.math.WidthInYards = 0;
            this.math.WidthInFeet = 0;
            this.math.WidthInInches = 0;
            this.math.TotalCubicYards = 0;
            this.math.TotalCubicFeet = 0;
            this.math.TotalCubicInches = 0;
        }

        /// <summary>
        /// Clears the text boxes solve for rectangle square solve.
        /// </summary>
        private void ClearTextBoxesSolveForRectangleSquareSolve()
        {
            txtCubicYards.Text = "0";
            txtCubicFeet.Text = "0";
            txtCubicInches.Text = "0";
        }

        #endregion CLEAR ALL DATA

        #region FILL RECTANGLE SQUARE DATA WITH DATA FROM TEXTBOXES

        /// <summary>
        /// Fills the data with data from text boxes.
        /// </summary>
        /// <returns><c>true</c>, if data with data 
        /// from text boxes was filled, <c>false</c> 
        /// otherwise.</returns>
        private bool FillDataWithDataFromTextBoxes()
        {
            bool retVal = false;

            this.methodName = "private bool FillDataWithDataFromTextBoxes()";
            try
            {
                double val = 0;

                val = this.conv.ConvertStringToDouble(txtDepthYard.Text);
                this.math.DepthInYards = val;
                val = this.conv.ConvertStringToDouble(txtDepthFeet.Text);
                this.math.DepthInFeet = val;
                val = this.conv.ConvertStringToDouble(txtDepthInches.Text);
                this.math.DepthInInches = val;

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

                return retVal = true;
            }
            catch (FormatException ex)
            {
                this.errMsg = "Encountered error converting numeric string " +
                "to integer value.";
                this.myMsg.BuildErrorString(
                    MyClassName, 
                    this.methodName, 
                    this.errMsg,
                    ex.ToString());   

                // Error so return false.
                return retVal;
            }
            catch (OverflowException ex)
            {
                this.errMsg = "Encountered error converting numeric string " +
                "to integer value.";
                this.myMsg.BuildErrorString(
                    MyClassName, 
                    this.methodName, 
                    this.errMsg,
                    ex.ToString());

                // Error so return false.
                return retVal;
            }
        }

        #endregion FILL RECTANGLE SQUARE DATA WITH DATA FROM TEXTBOXES

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

            val = this.rss.GetTheDepthTotalInches(
                this.math.DepthInYards, 
                this.math.DepthInFeet, 
                this.math.DepthInInches);
            if (val <= 0)
            {
                return retVal;
            }
            else
            {
                this.math.DepthTotalInches = val;
            }

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

        #region SOLVE FOR RECTANGLE SQUARE CUBIC AREA

        /// <summary>
        /// Shapes and the formula to solve for.
        /// </summary>
        private void ShapeFormulaToSolveFor()
        {    
            int val = 0;           

            val = string.Compare(
                degb.ShapeToSolveFor, 
                this.shape.RectangleShape);

            if (val == 0)
            {
                if (this.metricUnits)
                {
                    this.SolveForCubicAreaRectangleSquare();
                }
                else if (this.standardUnits)
                {
                    this.SolveForCubicRectangleSquareStandard();
                }
            }

            val = string.Compare(degb.ShapeToSolveFor, this.shape.SquareShape);
            if (val == 0)
            {   
                if (this.metricUnits)
                {
                    this.SolveForCubicRectangleSquareMetric();
                }
                else if (this.standardUnits)
                {
                    this.SolveForCubicRectangleSquareStandard();
                }
            }
        }


        /// <summary>
        /// Solves for cubic area square.
        /// </summary>
        private void SolveForCubicAreaRectangleSquare()
        {
            bool retVal = false;

            retVal = this.ValidateTextBoxesNotEmpty();

            if (!retVal)
            {
                return;
            }

            retVal = this.ValidateTextBoxesHaveNumericStringValue();
            if (!retVal)
            {
                return;
            }

            retVal = this.ValidateTextBoxesHaveNumericValueGreaterThanZero();
            if (!retVal)
            {
                return;
            }

            retVal = this.FillDataWithDataFromTextBoxes();
            if (!retVal)
            {
                return;
            }

            retVal = this.ConvertDataToInches();
            if (!retVal)
            {
                return;
            }

            this.SolveForCubicRectangleSquareStandard();
        }


        /// <summary>
        /// Solves for cubic rectangle square standard.
        /// </summary>
        private void SolveForCubicRectangleSquareStandard()
        {
            bool retVal = false;
            double val = 0;

            this.methodName = 
                "private bool SolveForCubicInchesRectangleSquare()";

            retVal = this.FillDataWithDataFromTextBoxes();
            if (!retVal)
            {
                return;
            }

            retVal = this.ConvertDataToInches();  
            if (!retVal)
            {
                return;
            }

            val = this.rss.SolveForCubicAreaYards(
                this.math.DepthTotalInches, 
                this.math.LengthTotalInches, 
                this.math.WidthTotalInches);

            txtCubicYards.Text = val.ToString();

            val = this.rss.SolveForCubicAreaFeet(
                this.math.DepthTotalInches,
                this.math.LengthTotalInches,
                this.math.WidthTotalInches);

            txtCubicFeet.Text = val.ToString();

            val = this.rss.SolveForCubicAreaInches(
                this.math.DepthTotalInches,
                this.math.LengthTotalInches,
                this.math.WidthTotalInches);

            txtCubicInches.Text = val.ToString();
        }

        /// <summary>
        /// Solves for cubic rectangle square metric.
        /// </summary>
        private void SolveForCubicRectangleSquareMetric()
        {
            throw new NotImplementedException();
        }

        #endregion SOLVE FOR RECTANGLE SQUARE CUBIC AREA

        #region SET UNITS CURENTLY BEING USED

        /// <summary>
        /// Shows the units currently being used.
        /// </summary>
        private void ShowUnitsCurrentlyBeingUsed()
        {
            if (this.standardUnits)
            {
                lblInfo.Text = "Using standard units.";
            }
            else if (this.metricUnits)
            {
                lblInfo.Text = "Using metric units.";
            }
            else
            {
                this.standardUnits = true;
                this.metricUnits = false;
                lblInfo.Text = "Using standard units.";
            }
        }

        /// <summary>
        /// Sets the cubic area labels standard units.
        /// </summary>
        private void SetCubicAreaLabelsStandardUnits()
        {
            lblCubicYards.Text = "Total Cubic Area In Yards:";
            lblCubicFeet.Text = "Total Cubic Area In Feet:";
            lblCubicInches.Text = "Total Cubic Area In Inches:";
        }

        /// <summary>
        /// Sets the cubic area labels metric units.
        /// </summary>
        private void SetCubicAreaLabelsMetricUnits()
        {
            lblCubicYards.Text = "Total Cubic Area In Meters:";
            lblCubicFeet.Text = "Total Cubic Area In Centimeters:";
            lblCubicInches.Text = "Total Cubic Area In Millimeters:";
        }

        #endregion SET UNITS CURENTLY BEING USED

        /// <summary>
        /// Converts the standard units data to metric units.
        /// </summary>
        private void ConvertStandardUnitsDataToMetricUnits()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Converts the metric units data to standard units.
        /// </summary>
        private void ConvertMetricUnitsDataToStandardUnits()
        {
            throw new NotImplementedException();
        }
    }
}