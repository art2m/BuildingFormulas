//  RectangleSquareData.cs
//  
//  Author:
//       art2m <art2m@chartermi.net>
//  
//  Copyright (c) 2013 art2m
// 
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU Lesser General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
// 
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU Lesser General Public License for more details.
// 
//  You should have received a copy of the GNU Lesser General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>

namespace BuildingFormulas
{
    /// <summary>
    /// Data entry.
    /// </summary>
    public class DataEntry
    {
        #region PROPERTIES - STORE YARDS FEET INCHES AS STRINGS

        /// <summary>
        /// Store the words "Enter Depth:"
        /// </summary>
        private readonly string enterDpthLblTxt = "Enter Depth:";

        /// <summary>
        /// store the words "Enter Length:".
        /// </summary>
        private readonly string enterLenLblTxt = "Enter Length:";

        /// <summary>
        /// Store the words "Enter Width:".
        /// </summary>
        private readonly string enterWthLblTxt = "Enter Width:";

        /// <summary>
        /// Store the words "Enter Height:".
        /// </summary>
        private readonly string enterHeightlblTxt = "Enter Height:";

        /// <summary>
        /// Store the words "Enter Radius:";
        /// </summary>
        private readonly string enterRadiuslblTxt = "Enter Radius:";

        /// <summary>
        /// Store the words "Area In Cubic Yards:".
        /// </summary>
        private readonly string totalCubicYdsLblTxt =
            "Area In Cubic Yards:";

        /// <summary>
        /// Store the words "Area In Cubic Inches:";
        /// </summary>
        private readonly string totalCubicInLblTxt = 
            "Area In Cubic Inches:";

        /// <summary>
        /// Store the words "Area In Cubic Feet:".
        /// </summary>
        private readonly string totalCubicFtLblTxt = 
            "Area In Cubic Feet:";

        /// <summary>
        /// Gets or sets the entered width yard value.
        /// Data set by value user entered in the width
        /// textbox.
        /// </summary>
        /// <value>The entered width yard value.</value>
        public string EnteredWidthYardValue
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the width feet value.
        /// Data set by value user entered in the
        /// width textbox.
        /// </summary>
        /// <value>The width feet value.</value>
        public string WidthFeetValue
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the width inches value.
        /// Data set by value user entered in the 
        /// width textbox.
        /// </summary>
        /// <value>The width inches value.</value>
        public string WidthInchesValue
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the depth yard value.
        /// Data set by value user entered in the
        /// depth textbox.
        /// </summary>
        /// <value>The depth yard value.</value>
        public string DepthYardValue
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the depth feet value.
        /// Data set by value user entered in the
        /// depth textbox.
        /// </summary>
        /// <value>The depth feet value.</value>
        public string DepthFeetValue
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the depth inches value.
        /// Data set by value the user entered in
        /// the depth textbox.
        /// </summary>
        /// <value>The depth inches value.</value>
        public string DepthInchesValue
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the length yard value.
        /// Data set by value the user entered in 
        /// the length textbox.
        /// </summary>
        /// <value>The length yard value.</value>
        public string LengthYardValue
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the length feet value.
        /// data set by value the user entered in
        /// the length textbox.
        /// </summary>
        /// <value>The length feet value.</value>
        public string LengthFeetValue
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the length inches value.
        /// data set by the value the user entered in
        /// the length textbox.
        /// </summary>
        /// <value>The length inches value.</value>
        public string LengthInchesValue
        {
            get;
            set;
        }

        #endregion END PROPERTIES - STORE YARDS FEET INCHES AS STRING

        #region PROPERTIES - DATA ENTRY LABEL NAMES

        /// <summary>
        /// Gets the enter depth label text.
        /// If formula user is running requires depth 
        /// data entry then this label string will 
        /// be used.
        /// </summary>
        /// <value>The enter depth label text.</value>
        public string EnterDepthLabelText
        {
            get { return this.enterDpthLblTxt; }
        }

        /// <summary>
        /// Gets the enter length label text.
        /// If formula user is running requires Length 
        /// data entry.Then this label string will be used.
        /// </summary>
        /// <value>The enter length label text.</value>
        public string EnterLengthLabelText
        {
            get { return this.enterLenLblTxt; }
        }

        /// <summary>
        /// Gets the enter width label text.
        /// If formula user is running requires width 
        /// data entry.Then this label string will be used.
        /// </summary>
        /// <value>The enter width label text.</value>
        public string EnterWidthLabelText
        {
            get { return this.enterWthLblTxt; }
        }

        /// <summary>
        /// Gets the enter height label text.
        /// If formula user is running requires height
        /// Data entry. Then this label string will be 
        /// used.
        /// </summary>
        /// <value>The enter height label text.</value>
        public string EnterHeightLabelText
        {
            get { return this.enterHeightlblTxt; }
        }

        /// <summary>
        /// Gets the enter radius label text.
        /// If formula user is running requires radius
        /// data entry. Then this label string will
        /// be used.
        /// </summary>
        /// <value>The enter radius label text.</value>
        public string EnterRadiusLabelText
        {
            get { return this.enterRadiuslblTxt; }
        }

        /// <summary>
        /// Gets the total cubic yards label text.
        /// If the formula the user has run requires 
        /// an answer in Total Cubic Yards. Then this
        /// string will be put onto the label.
        /// </summary>
        /// <value>The total cubic yards label text.</value>
        public string TotalCubicYardsLabelText
        {
            get { return this.totalCubicYdsLblTxt; }
        }

        /// <summary>
        /// Gets the total cubic feet label text.
        /// If the formula the user has run requires an 
        /// answer in Total Cubic Feet. Then this string
        /// will be put onto the label.
        /// </summary>
        /// <value>The total cubic feet label text.</value>
        public string TotalCubicFeetLabelText
        {
            get { return this.totalCubicFtLblTxt; }
        }

        /// <summary>
        /// Gets the total cubic inches label text.
        /// If the formula the user has run requires an
        /// answer in Total Cubic Inches. Then this 
        /// string will be put onto the label.
        /// </summary>
        /// <value>The total cubic inches label text.</value>
        public string TotalCubicInchesLabelText
        {
            get { return this.totalCubicInLblTxt; }
        }

        #endregion PROPERTIES - DATA ENTRY LABEL NAMES
    }
}