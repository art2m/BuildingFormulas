//  Coversions.cs
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
    /// Conversions class.
    /// </summary>
    public class Conversions
    {
        /// <summary>
        /// Initializes a new instance of the<see cref=
        /// "BuildingFormulas.Conversions"/> class.
        /// </summary>
        public Conversions()
        {
        }

        /// <summary>
        /// Converts the cubic inches to cubic feet.
        /// </summary>
        /// <returns>The cubic inches to cubic feet.</returns>
        /// <param name="cubicInches">Cubic inches.</param>
        public double ConvertCubicInchesToCubicFeet(double cubicInches)
        {
            double cubicFeet = 0;
            const double CubicFtIn = 1728;

            cubicFeet = cubicInches / CubicFtIn;

            return cubicFeet;
        }

        /// <summary>
        /// Converts the cubic inches to cubic yards.
        /// </summary>
        /// <returns>The cubic inches to cubic yards.</returns>
        /// <param name="cubicInches">Cubic inches.</param>
        public double ConvertCubicInchesToCubicYards(double cubicInches)
        {
            double cubicYard = 0;
            const double CubicYdIn = 46656;

            cubicYard = cubicInches / CubicYdIn;

            return cubicYard;
        }

        /// <summary>
        /// Converts the cubic feet to cubic inches.
        /// </summary>
        /// <returns>The cubic feet to cubic inches.</returns>
        /// <param name="cubicFeet">Cubic feet.</param>
        public double ConvertCubicFeetToCubicInches(double cubicFeet)
        {
            double cubicInches = 0;
            const double CubicFtIn = 1728;

            cubicInches = cubicFeet * CubicFtIn;
            return cubicInches;
        }

        /// <summary>
        /// Converts the cubic feet to cubic yards.
        /// </summary>
        /// <returns>The cubic feet to cubic yards.</returns>
        /// <param name="cubicFeet">Cubic feet.</param>
        public double ConvertCubicFeetToCubicYards(double cubicFeet)
        {
            double cubicInches = 0;
            double cubicYards = 0;

            cubicInches = this.ConvertCubicFeetToCubicInches(cubicFeet);
            cubicYards = this.ConvertCubicInchesToCubicYards(cubicInches);

            return cubicYards;
        }

        /// <summary>
        /// Converts the cubic yards to cubic inches.
        /// </summary>
        /// <returns>The cubic yards to cubic inches.</returns>
        /// <param name="cubicYards">Cubic yards.</param>
        private double ConvertCubicYardsToCubicInches(double cubicYards)
        {
            double cubicInches = 0;
            const double CubicYdIn = 46656;

            cubicInches = cubicYards * CubicYdIn;

            return cubicInches;
        }

        /// <summary>
        /// Converts the cubic yards to cubic feet.
        /// </summary>
        /// <returns>The cubic yards to cubic feet.</returns>
        /// <param name="cubicYards">Cubic yards.</param>
        private double ConvertCubicYardsToCubicFeet(double cubicYards)
        {
            double cubicInches = 0;
            double cubicFeet = 0;

            cubicInches = this.ConvertCubicYardsToCubicInches(cubicYards);
            cubicFeet = this.ConvertCubicInchesToCubicFeet(cubicInches);

            return cubicFeet;
        }
    }
} 