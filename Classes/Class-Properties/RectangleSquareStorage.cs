//  RectangleSquareStorage.cs
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
    /// Rectangle square storage.
    /// </summary>
    public static class RectangleSquareStorage
    {
        /// <summary>
        /// The cubic inches rectangle.
        /// </summary>
        private static double cubicInchesRectangle = 0;

        /// <summary>
        /// The cubic feet rectangle.
        /// </summary>
        private static double cubicFeetRectangle = 0;

        /// <summary>
        /// The cubic yards rectangle.
        /// </summary>
        private static double cubicYardsRectangle = 0;

        /// <summary>
        /// Gets or sets the cubic inches rectangle.
        /// </summary>
        /// <value>The cubic inches rectangle.</value>
        public static double CubicInchesRectangle
        {
            get { return cubicInchesRectangle; }
            set { cubicInchesRectangle = value; }
        }

        /// <summary>
        /// Gets or sets the cubic feet rectangle.
        /// </summary>
        /// <value>The cubic feet rectangle.</value>
        public static double CubicFeetRectangle
        {
            get { return cubicFeetRectangle; }
            set { cubicFeetRectangle = value; }
        }

        /// <summary>
        /// Gets or sets the cubic yards rectangle.
        /// </summary>
        /// <value>The cubic yards rectangle.</value>
        public static double CubicYardsRectangle
        {
            get { return cubicYardsRectangle; }
            set { cubicYardsRectangle = value; }
        }

        /// <summary>
        /// Clears all data stored.
        /// </summary>
        /// <returns><c>true</c>, if all data stored was cleared, 
        /// <c>false</c> otherwise.</returns>
        public static bool ClearAllDataStored()
        {
            bool retVal = false;

            cubicInchesRectangle = 0;
            cubicFeetRectangle = 0;
            cubicYardsRectangle = 0;

            // All Ok 
            retVal = true;
            return retVal;
        }
    }
} 