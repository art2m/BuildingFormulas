//
//  CylinderCubic.cs
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
    /// Cylinder cubic. Finds the cubic area of a rectangle.
    /// </summary>
    public partial class CylinderCubic : Gtk.Window
    {
        /// <summary>
        /// The name of the this class.
        /// </summary>
        private const string ThisClassName = 
            "public partial class CylinderCubic : Gtk.Window";

        /// <summary>
        /// My message.
        /// </summary> 
        private MyMessages myMsg = new MyMessages();

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
        /// The cys.
        /// </summary>
        private CylinderSolve cys = new CylinderSolve();

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
        /// <see cref="BuildingFormulas.CylinderCubic"/> class.
        /// </summary>
        public CylinderCubic()
            : base(Gtk.WindowType.Toplevel)
        {
            this.Build();
        }

        #region BUTTON CLICKED EVENTS

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
        /// Raises the button close clicked event.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Instance containing the event data.</param>
        protected void OnBtnCloseClicked(object sender, EventArgs e)
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
        /// Raises the button metric clicked event.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Instance containing the event data.</param>
        protected void OnBtnMetricClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Raises the button new cylinder clicked event.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Instance containing the event data.</param>
        protected void OnBtnNewCylinderClicked(object sender, EventArgs e)
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
        /// <param name="e">Instance conatining the event data.</param>
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
        /// Raises the button store result clicked event.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Instance containing the event data.</param>
        protected void OnBtnStoreResultClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion BUTTON CLICKED EVENTS

        #region IUserGui implementation

        /// <summary>
        /// Clears the data.
        /// </summary>
        private void ClearData()
        {
            txtDiameterYard.Text = "0";
            txtDiameterFeet.Text = "0";
            txtDiameterInches.Text = "0";

            txtCubicYards.Text = "0";
            txtCubicFeet.Text = "0";
            txtCubicInches.Text = "0";

            this.math.DiameterYard = 0;
            this.math.HeightYard = 0;
            this.math.DiameterFeet = 0;
            this.math.HeightFeet = 0;
            this.math.DiameterInches = 0;
            this.math.HeightInches = 0;
            this.math.DiameterTotalInches = 0;
            this.math.HeightTotalInches = 0;
        }

        /// <summary>
        /// Clears the text boxes cubic area.
        /// </summary>
        private void ClearTextBoxesCubicArea()
        {
            txtCubicYards.Text = "0";
            txtCubicFeet.Text = "0";
            txtCubicInches.Text = "0";
        }

        /// <summary>
        /// Fills the values with data from text boxes.
        /// </summary>
        /// <returns><c>true</c>, if values with data 
        /// from text boxes was filled, 
        /// <c>false</c> otherwise.</returns>
        private bool FillValuesWithDataFromTextBoxes()
        {
            bool retVal = false;
            double val = 0;
            const string MethodName = 
                "public bool FillValuesWithDataFromTextBoxes()";
            const string ErrMsg = "Encountered error converting " +
                                  "numeric string to double value.";

            try
            {
                val = this.conv.ConvertStringToDouble(
                    txtDiameterYard.Text.Trim());
                this.math.DiameterYard = val;
                val = this.conv.ConvertStringToDouble(
                    txtDiameterFeet.Text.Trim());
                this.math.DiameterFeet = val;
                val = this.conv.ConvertStringToDouble(
                    txtDiameterInches.Text.Trim());
                this.math.DiameterInches = val;
                
                val = this.conv.ConvertStringToDouble(
                    txtHeightYard.Text.Trim());
                this.math.HeightYard = val;
                val = this.conv.ConvertStringToDouble(
                    txtHeightFeet.Text.Trim());
                this.math.HeightFeet = val;
                val = this.conv.ConvertStringToDouble(
                    txtHeightInches.Text.Trim());
                this.math.HeightInches = val;

                return retVal = true;
            }
            catch (FormatException ex)
            {
                this.myMsg.BuildErrorString(
                    ThisClassName, 
                    MethodName, 
                    ErrMsg,
                    ex.ToString());   

                // Error so return false.
                return retVal;
            }
            catch (OverflowException ex)
            {
                this.myMsg.BuildErrorString(
                    ThisClassName,
                    MethodName,
                    ErrMsg,
                    ex.ToString());
                return retVal;
            }
        }

        /// <summary>
        /// Converts the data to inches.
        /// </summary>
        /// <returns><c>true</c>, if data 
        /// to inches was converted, 
        /// <c>false</c> otherwise.</returns>
        private bool ConvertDataToInches()
        {
            bool retVal = false;
            double val = 0;
            const string Diameter = "diameter";
            const string Height = "height";
            const string MethodName = "public bool ConvertDataToInches()";

            val = this.cys.GetTheDiameterTotalInches(
                this.math.DiameterYard,
                this.math.DiameterFeet,
                this.math.DiameterInches);
            retVal = this.vd.ValidateTotalSumIsGreaterThenZero(val, Diameter);
            if (!retVal)
            {
                return retVal;
            }
            else
            {
                this.math.DiameterTotalInches = val;
            }

            val = this.cys.GetTheHeightTotalInches(
                this.math.HeightYard,
                this.math.HeightFeet,
                this.math.HeightInches);
            retVal = this.vd.ValidateTotalSumIsGreaterThenZero(val, Height);
            if (!retVal)
            {
                return retVal;
            }
            else
            {
                this.math.HeightTotalInches = val;
            }

            return retVal = true;
        }

        /// <summary>
        /// Converts the metric units data to standard units.
        /// </summary>
        private void ConvertMetricUnitsDataToStandardUnits()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Converts the standard units data to metric units.
        /// </summary>
        private void ConvertStandardUnitsDataToMetricUnits()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Validates the cubic area rectangle square data.
        /// </summary>
        /// <returns><c>true</c>, if cubic area rectangle 
        /// square data was validated, 
        /// <c>false</c> otherwise.</returns>
        private bool ValidateCubicAreaCylinderData()
        {           
            bool retVal = false;
            const int Cnt = 6;
            string[] values = new string[Cnt];           

            values[0] = txtDiameterYard.Text.Trim();
            values[1] = txtDiameterFeet.Text.Trim();
            values[2] = txtDiameterInches.Text.Trim();
            values[3] = txtHeightYard.Text.Trim();
            values[4] = txtHeightFeet.Text.Trim();
            values[5] = txtHeightInches.Text.Trim();

            retVal = this.vd.ValidateUserDataNotNullNotEmpty(values, Cnt);
            if (!retVal)
            {
                return retVal;
            }

            retVal = this.vd.ValidateUserDataHasNumericValue(values, Cnt);
            if (!retVal)
            {
                return retVal;
            }

            return retVal = true;
        }

        /// <summary>
        /// Solves for metric units standard units.
        /// </summary>
        private void SolveForMetricUnitsStandardUnits()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Solves for cubic standard.
        /// </summary>
        private void SolveForCubicStandard()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Solves for cubic metric.
        /// </summary>
        private void SolveForCubicMetric()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Shows the units currently being used.
        /// </summary>
        private void ShowUnitsCurrentlyBeingUsed()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets the cubic area labels standard units.
        /// </summary>
        private void SetCubicAreaLabelsStandardUnits()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets the cubic area labels metric units.
        /// </summary>
        private void SetCubicAreaLabelsMetricUnits()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}