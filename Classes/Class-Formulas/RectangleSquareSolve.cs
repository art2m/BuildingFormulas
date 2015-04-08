//  RectangleSquareSolve.cs
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
    using System;

    /// <summary>
    /// Rectangle square solve.
    /// </summary>
    public static class RectangleSquareSolve
    {
        #region PROPERTY VARIABLES: USER ENTERED SIZE DATA

        /// <summary>
        /// The depth yd.
        /// </summary>
        private static int depthYd = 0;

        /// <summary>
        /// The length yd.
        /// </summary>
        private static int lengthYd = 0;

        /// <summary>
        /// The width yd.
        /// </summary>
        private static int widthYd = 0;

        /// <summary>
        /// The width ft.
        /// </summary>
        private static int widthFt = 0;

        /// <summary>
        /// The depth ft.
        /// </summary>
        private static int depthFt = 0;

        /// <summary>
        /// The length ft.
        /// </summary>
        private static int lengthFt = 0;

        /// <summary>
        /// The width in.
        /// </summary>
        private static int widthIn = 0;

        /// <summary>
        /// The depth in.
        /// </summary>
        private static int depthIn = 0;

        /// <summary>
        /// The length in.
        /// </summary>
        private static int lengthIn = 0;

        /// <summary>
        /// The depth total inches.
        /// </summary>
        private static int depthTotalInches;

        /// <summary>
        /// The length total inches.
        /// </summary>
        private static int lengthTotalInches;

        #endregion PROPERTY VARIABLES: USER ENTERED SIZE DATA

        /// <summary>
        /// The width total inches.
        /// </summary>
        private static int widthTotalInches;

        #region PROPERTIES VALUES FOR LENGTH, WIDTH, DEPTH

        /// <summary>
        /// Gets or sets the rectangle width in yards.
        /// </summary>
        /// <value>The rectangle width in yards.</value>
        public static int RectangleWidthInYards
        {
            get { return widthYd; }
            set { widthYd = value; }
        }

        /// <summary>
        /// Gets or sets the rectangle depth in yards.
        /// </summary>
        /// <value>The rectangle depth in yards.</value>
        public static int RectangleDepthInYards
        {
            get { return depthYd; }
            set { depthYd = value; }
        }

        /// <summary>
        /// Gets or sets the rectangle length in yards.
        /// </summary>
        /// <value>The rectangle length in yards.</value>
        public static int RectangleLengthInYards
        {
            get { return lengthYd; }
            set { lengthYd = value; }
        }

        /// <summary>
        /// Gets or sets the rectangle width in feet.
        /// </summary>
        /// <value>The rectangle width in feet.</value>
        public static int RectangleWidthInFeet
        {
            get { return widthFt; }
            set { widthFt = value; }
        }

        /// <summary>
        /// Gets or sets the rectangle depth in feet.
        /// </summary>
        /// <value>The rectangle depth in feet.</value>
        public static int RectangleDepthInFeet
        {
            get { return depthFt; }
            set { depthFt = value; }
        }

        /// <summary>
        /// Gets or sets the rectangle length in feet.
        /// </summary>
        /// <value>The rectangle length in feet.</value>
        public static int RectangleLengthInFeet
        {
            get { return lengthFt; }
            set { lengthFt = value; }
        }

        /// <summary>
        /// Gets or sets the rectangle width in inches.
        /// </summary>
        /// <value>The rectangle width in inches.</value>
        public static int RectangleWidthInInches
        {
            get { return widthIn; }
            set { widthIn = value; }
        }

        /// <summary>
        /// Gets or sets the rectangle depth in inches.
        /// </summary>
        /// <value>The rectangle depth in inches.</value>
        public static int RectangleDepthInInches
        {
            get { return depthIn; }
            set { depthIn = value; }
        }

        /// <summary>
        /// Gets or sets the rectangle length in inches.
        /// </summary>
        /// <value>The rectangle length in inches.</value>
        public static int RectangleLengthInInches
        {
            get { return lengthIn; }
            set { lengthIn = value; }
        }

        #endregion End PROPERTIES VALUES FOR LENGTH, WIDTH, DEPTH

        #region PROPERTIES TOTAL INCHES IN DEPTH, LENGTH AND WIDTH

        /// <summary>
        /// Gets or sets the cubic inches in cubic rectangle.
        /// </summary>
        /// <value>The cubic inches in cubic rectangle.</value>
        public static double CubicInchesInCubicRectangle
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the cubic feet in cubic rectangle.
        /// </summary>
        /// <value>The cubic feet in cubic rectangle.</value>
        public static double CubicFeetInCubicRectangle
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the cubic yards in cubic rectangle.
        /// </summary>
        /// <value>The cubic yards in cubic rectangle.</value>
        public static double CubicYardsInCubicRectangle
        {
            get;
            set;
        }

        /// <summary>
        /// Gets the depth total inches.
        /// </summary>
        public static void GetTheDepthTotalInches()
        {
            int inchesYd = 0;
            int inchesFt = 0;

            inchesYd = RectangleDepthInYards * 36;
            inchesFt = RectangleDepthInFeet * 12;
            depthTotalInches = inchesYd + inchesFt + RectangleDepthInInches;
        }

        /// <summary>
        /// Gets the length total inches.
        /// </summary>
        public static void GetTheLengthTotalInches()
        {
            int inchesYd = 0;
            int inchesFt = 0;

            inchesYd = RectangleLengthInYards * 36;
            inchesFt = RectangleLengthInFeet * 12;
            lengthTotalInches = inchesYd + inchesFt + RectangleLengthInInches;
        }

        /// <summary>
        /// Gets the widths total inches.
        /// </summary>
        public static void GetTheWidthsTotalInches()
        {
            int inchesYd = 0;
            int inchesFt = 0;
            widthTotalInches = inchesYd + inchesFt + RectangleWidthInInches;
        }

        #endregion PROPERTIES TOTAL INCHES IN DEPTH, LENGTH AND WIDTH

        #region METHODS SOLVE FOR CUBIC YARDS, FEET, INCHES IN RECTANGLE, SQUARE

        /// <summary>
        /// Solves for cubic area yards.
        /// </summary>
        /// <returns>The for cubic area yards.</returns>
        public static double SolveForCubicAreaYards()
        {
            Conversions conv = new Conversions();

            double retVal = 0;
            double cubicIn = 0;
            double cubicYd = 0;

            cubicIn = depthTotalInches * lengthTotalInches * widthTotalInches;

            cubicYd = conv.ConvertCubicInchesToCubicYards(cubicIn);

            retVal = Math.Round(cubicYd, 2);

            CubicYardsInCubicRectangle = retVal;

            return retVal;
        }

        /// <summary>
        /// Solves for cubic area feet.
        /// </summary>
        /// <returns>The for cubic area feet.</returns>
        public static double SolveForCubicAreaFeet()
        {
            Conversions conv = new Conversions();

            double retVal = 0;
            double cubicFt = 0;
            double cubicIn = 0;

            cubicIn = depthTotalInches * lengthTotalInches * widthTotalInches;

            cubicFt = conv.ConvertCubicInchesToCubicFeet(cubicIn);
            retVal = Math.Round(cubicFt, 2);

            CubicFeetInCubicRectangle = retVal;            

            return retVal;
        }

        /// <summary>
        /// Solves for cubic area inches.
        /// </summary>
        /// <returns>The for cubic area inches.</returns>
        public static double SolveForCubicAreaInches()
        {
            double retVal = 0;

            retVal = depthTotalInches * lengthTotalInches * widthTotalInches;

            CubicInchesInCubicRectangle = retVal;
            return retVal;
        }

        #endregion METHODS SOLVE FOR CUBIC YARDS, FEET, INCHES IN RECTANGLE
    }
}
