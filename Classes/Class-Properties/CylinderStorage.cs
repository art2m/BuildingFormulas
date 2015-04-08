//  CylinderStorage.cs
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
    /// Cylinder storage.
    /// </summary>
    public static class CylinderStorage
    {
        /// <summary>
        /// The cubic inches cylinder.
        /// </summary>
        private static double cubicInchesCylinder = 0;

        /// <summary>
        /// The cubic feet cylinder.
        /// </summary>
        private static double cubicFeetCylinder = 0;

        /// <summary>
        /// The cubic yards cylinder.
        /// </summary>
        private static double cubicYardsCylinder = 0;

        /// <summary>
        /// Gets or sets the cubic inches cylinder.
        /// </summary>
        /// <value>The cubic inches cylinder.</value>
        public static double CubicInchesCylinder
        {
            get { return cubicInchesCylinder; }
            set { cubicInchesCylinder = value; }
        }

        /// <summary>
        /// Gets or sets the cubic feet cylinder.
        /// </summary>
        /// <value>The cubic feet cylinder.</value>
        public static double CubicFeetCylinder
        {
            get { return cubicFeetCylinder; }
            set { cubicFeetCylinder = value; }
        }

        /// <summary>
        /// Gets or sets the cubic yards cylinder.
        /// </summary>
        /// <value>The cubic yards cylinder.</value>
        public static double CubicYardsCylinder
        {
            get { return cubicYardsCylinder; }
            set { cubicYardsCylinder = value; }
        }

        /// <summary>
        /// Clears all data stored.
        /// </summary>
        /// <returns><c>true</c>, if all data stored was cleared, 
        /// <c>false</c> otherwise.</returns>
        public static bool ClearAllDataStored()
        {
            bool retVal = false;

            cubicInchesCylinder = 0;
            cubicFeetCylinder = 0;
            cubicYardsCylinder = 0;

            // All Ok 
            retVal = true;
            return retVal;
        }
    }
}