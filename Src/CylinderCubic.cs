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
        /// <see cref="BuildingFormulas.CylinderCubic"/> class.
        /// </summary>
        public CylinderCubic()
            : base(Gtk.WindowType.Toplevel)
        {
            this.Build();
        }

        #region BUTTON CLICKED EVENTS

        protected void OnBtnClearStoreClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        protected void OnBtnCloseClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        protected void OnBtnDisplayStoreClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        protected void OnBtnMetricClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        protected void OnBtnNewCylinderClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        protected void OnBtnPrintFormClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        protected void OnBtnPrintStoredClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        protected void OnBtnSolveClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        protected void OnBtnStandardClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        protected void OnBtnStoreResultClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion BUTTON CLICKED EVENTS

        #region VALIDATE DATA STRINGS NOT NULL OR EMPTY

        private bool ValidateCircumferenceFeetStringValueNotEmpty()
        {
            bool retVal = false;

            return retVal;
        }

        #endregion VALIDATE DATA STRINGS NOT NULL OR EMPTY
    }
}