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
	public class RectangleSquareSolveStandard
	{
		/// <summary>
		/// The math object decleration.
		/// </summary>
		private MyMath math = new MyMath();

		/// <summary>
		/// Initializes a new instance of the 
		/// <see cref="BuildingFormulas.RectangleSquareSolve"/> class.
		/// </summary>
		public RectangleSquareSolveStandard()
		{
		}

		#region GET TOTAL INCHES

		/// <summary>
		/// Gets the depth total inches.
		/// </summary>
		/// <returns>The the depth total inches.</returns>
		/// <param name="depthInYards">Depth in yards.</param>
		/// <param name="depthInFeet">Depth in feet.</param>
		/// <param name="depthInInches">Depth in inches.</param>
		public double GetTheDepthTotalInches(
			double depthInYards,
			double depthInFeet, 
			double depthInInches)
		{
			double inchesYd = 0;
			double inchesFt = 0;
			double retVal = 0;

			inchesYd = depthInYards * this.math.ConvertInchesToYards;
			inchesFt = depthInFeet * this.math.ConvertInchesToFeet;
			retVal = inchesYd + inchesFt + depthInInches;

			return retVal;
		}

		/// <summary>
		/// Gets the length total inches.
		/// </summary>
		/// <returns>The the length total inches.</returns>
		/// <param name="lengthInYards">Length in yards.</param>
		/// <param name="lengthInFeet">Length in feet.</param>
		/// <param name="lengthInInches">Length in inches.</param>
		public double GetTheLengthTotalInches(
			double lengthInYards, 
			double lengthInFeet, 
			double lengthInInches)
		{
			double inchesYd = 0;
			double inchesFt = 0;
			double retVal = 0;

			inchesYd = lengthInYards * this.math.ConvertInchesToYards;
			inchesFt = lengthInFeet * this.math.ConvertInchesToFeet;
			retVal = inchesYd + inchesFt + lengthInInches;

			return retVal;
		}

		/// <summary>
		/// Gets the widths total inches.
		/// </summary>
		/// <returns>The the widths total inches.</returns>
		/// <param name="widthInYards">Width in yards.</param>
		/// <param name="widthInFeet">Width in feet.</param>
		/// <param name="widthInInches">Width in inches.</param>
		public double GetTheWidthsTotalInches(
			double widthInYards,
			double widthInFeet,
			double widthInInches)
		{
			double inchesYd = 0;
			double inchesFt = 0;
			double retVal = 0;

			inchesYd = widthInYards * this.math.ConvertInchesToYards;
			inchesFt = widthInFeet * this.math.ConvertInchesToFeet;
			retVal = inchesYd + inchesFt + widthInInches;
			return retVal;
		}

		#endregion GET TOTAL INCHES

		#region METHODS SOLVE FOR CUBIC YARDS, FEET, INCHES IN RECTANGLE, SQUARE

		/// <summary>
		/// Solves for cubic area yards.
		/// </summary>
		/// <returns>The for cubic area yards.</returns>
		/// <param name="depthTotalInches">Depth total inches.</param>
		/// <param name="lengthTotalinches">Length totalinches.</param>
		/// <param name="widthTotalInches">Width total inches.</param>
		public double SolveForVolumeYards(
			double depthTotalInches, 
			double lengthTotalinches, 
			double widthTotalInches)
		{
			Conversions conv = new Conversions();

			double retVal = 0;
			double cubicIn = 0;
			double cubicYd = 0;

			cubicIn = depthTotalInches * lengthTotalinches * widthTotalInches;

			cubicYd = conv.ConvertCubicInchesToCubicYards(cubicIn);

			retVal = Math.Round(cubicYd, 2);

			return retVal;
		}

		/// <summary>
		/// Solves for cubic area feet.
		/// </summary>
		/// <returns>The for cubic area feet.</returns>
		/// <param name="depthTotalInches">Depth total inches.</param>
		/// <param name="lengthTotalInches">Length total inches.</param>
		/// <param name="widthTotalInches">Width total inches.</param>
		public double SolveForVolumeFeet(
			double depthTotalInches,
			double lengthTotalInches, 
			double widthTotalInches)
		{
			Conversions conv = new Conversions();

			double retVal = 0;
			double cubicFt = 0;
			double cubicIn = 0;

			cubicIn = depthTotalInches * lengthTotalInches * widthTotalInches;

			cubicFt = conv.ConvertCubicInchesToCubicFeet(cubicIn);
			retVal = Math.Round(cubicFt, 2);

			return retVal;
		}

		/// <summary>
		/// Solves for cubic area inches.
		/// </summary>
		/// <returns>The for cubic area inches.</returns>
		/// <param name="depthTotalInches">Depth total inches.</param>
		/// <param name="lengthTotalInches">Length total inches.</param>
		/// <param name="widthTotalInches">Width total inches.</param>
		public double SolveForVolumeInches(
			double depthTotalInches,
			double lengthTotalInches,
			double widthTotalInches)
		{
			double retVal = 0;

			retVal = depthTotalInches * lengthTotalInches * widthTotalInches;

			return retVal;
		}

		#endregion METHODS SOLVE FOR CUBIC YARDS, FEET, INCHES IN RECTANGLE

		#region METHODS SOLVE FOR SURFACE AREA YARDS, FEET INCHES

		/// <summary>
		/// Solves for surface area square yards.
		/// </summary>
		/// <returns>The for surface area square yards.</returns>
		/// <param name="lengthTotalInches">Length total inches.</param>
		/// <param name="widthTotalInches">Width total inches.</param>
		public double SolveForSurfaceAreaSquareYards(
			double lengthTotalInches, 
			double widthTotalInches)
		{
			Conversions conv = new Conversions();

			double retVal = 0;
			double sum = 0;

			sum = lengthTotalInches + widthTotalInches;

			retVal = sum * this.math.CubeNumberOfSides;

			retVal = conv.ConvertInchesToYards(retVal);

			return retVal;
		}

		/// <summary>
		/// Solves for surface area square feet.
		/// </summary>
		/// <returns>The for surface area square feet.</returns>
		/// <param name="lengthTotalInches">Length total inches.</param>
		/// <param name="widthTotalInches">Width total inches.</param>
		public double SolveForSurfaceAreaSquareFeet(
			double lengthTotalInches,
			double widthTotalInches)
		{
			Conversions conv = new Conversions();

			double retVal = 0;
			double sum = 0;  

			sum = lengthTotalInches + widthTotalInches;

			retVal = sum * this.math.CubeNumberOfSides;

			retVal = conv.ConvertInchesToFeet(retVal);

			return retVal;
		}

		/// <summary>
		/// Solves for surface area square inches.
		/// </summary>
		/// <returns>The for surface area square inches.</returns>
		/// <param name="lengthTotalInches">Length total inches.</param>
		/// <param name="widthTotalInches">Width total inches.</param>
		public double SolveForSurfaceAreaSquareInches(
			double lengthTotalInches,
			double widthTotalInches)
		{
			double retVal = 0;
			double sum = 0;     
           
			sum = lengthTotalInches + widthTotalInches;

			retVal = sum * this.math.CubeNumberOfSides;

			return retVal;
		}

		#endregion METHODS SOLVE FOR SURFACE AREA YARDS, FEET INCHES
	}
}
