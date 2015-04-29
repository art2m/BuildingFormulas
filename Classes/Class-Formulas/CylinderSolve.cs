//
//  CylinderSolve.cs
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

    /// <summary>
    /// Cylinder solve.
    /// </summary>
    public class CylinderSolve
    {
        /// <summary>
        /// The math object decleration.
        /// </summary>
        private MyMath math = new MyMath();


        /// <summary>
        /// Initializes a new instance of the 
        /// <see cref="BuildingFormulas.CylinderSolve"/> 
        /// class.
        /// </summary>
        public CylinderSolve()
        {
        }

        /// <summary>
        /// Gets the diameter total inches.
        /// </summary>
        /// <returns>The the diameter total inches.</returns>
        /// <param name="diameterYards">diameter yards.</param>
        /// <param name="diameterFeet">diameter feet.</param>
        /// <param name="diameterInches">diameter inches.</param>
        public double GetTheDiameterTotalInches(
            double diameterYards,
            double diameterFeet,
            double diameterInches)
        {
            double inchesYd = 0;
            double inchesFt = 0;
            double retVal = 0;

            inchesYd = diameterYards * this.math.ConvertInchesToYards;
            inchesFt = diameterFeet * this.math.ConvertInchesToFeet;
            retVal = inchesYd + inchesFt + diameterInches;

            return retVal;

        }

        /// <summary>
        /// Gets the height total inches.
        /// </summary>
        /// <returns>The the height total inches.</returns>
        /// <param name="heightYards">Height yards.</param>
        /// <param name="heightFeet">Height feet.</param>
        /// <param name="heightInches">Height inches.</param>
        public double GetTheHeightTotalInches(
            double heightYards,
            double heightFeet,
            double heightInches)
        {
            double inchesYd = 0;
            double inchesFt = 0;
            double retVal = 0;

            inchesYd = heightYards * this.math.ConvertInchesToYards;
            inchesFt = heightFeet * this.math.ConvertInchesToFeet;
            retVal = inchesYd + inchesFt + heightInches;

            return retVal;
        }

        /// <summary>
        /// Solves for cubic area yards.
        /// </summary>
        /// <returns>The for cubic area yards.</returns>
        /// <param name="diameterTotalInches">Diameter total inches.</param>
        /// <param name="heightTotalInches">Height total inches.</param>
        public double SolveForCubicAreaYards(
            double diameterTotalInches, 
            double heightTotalInches)
        {
            Conversions conv = new Conversions();

            double retVal = 0;
            double cubicIn = 0;
            double cubicYd = 0;  
            double radius = 0;

            radius = diameterTotalInches / 2;

            cubicIn = math.PiValue * radius * radius * heightTotalInches;
           

            cubicYd = conv.ConvertCubicInchesToCubicYards(cubicIn);

            retVal = Math.Round(cubicYd, 2);

            return retVal;
        }

        /// <summary>
        /// Solves for cubic area feet.
        /// </summary>
        /// <returns>The for cubic area feet.</returns>
        /// <param name="diameterTotalInches">Diameter total inches.</param>
        /// <param name="heightTotalInches">Height total inches.</param>
        public double SolveForCubicAreaFeet(
            double diameterTotalInches, 
            double heightTotalInches)
        {
            Conversions conv = new Conversions();

            double retVal = 0;
            double cubicFt = 0;
            double cubicIn = 0;
            double radius = 0;

            radius = diameterTotalInches / 2;

            cubicIn = math.PiValue * radius * radius * heightTotalInches;

            cubicFt = conv.ConvertCubicInchesToCubicFeet(cubicIn);
            retVal = Math.Round(cubicFt, 2);

            return retVal;
        }

        /// <summary>
        /// Solves for cubic area inches.
        /// </summary>
        /// <returns>The for cubic area inches.</returns>
        /// <param name="diameterTotalInches">Diameter total inches.</param>
        /// <param name="heightTotalInches">Height total inches.</param>
        public double SolveForCubicAreaInches(
            double diameterTotalInches, 
            double heightTotalInches)
        {
            double retVal = 0;
            double radius = 0;

            radius = diameterTotalInches / 2;

            retVal = math.PiValue * radius * radius * heightTotalInches;

            return retVal;
        }
    }
}

