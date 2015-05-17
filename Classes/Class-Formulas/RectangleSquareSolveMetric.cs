//
//  RectangleSquareSolveMetric.cs
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

	public class RectangleSquareSolveMetric
	{
		/// <summary>
		/// The math.
		/// </summary>
		private MyMath math = new MyMath();

		public RectangleSquareSolveMetric()
		{
		}

		#region GET TOTAL MILLIMETERS

		/// <summary>
		/// Gets the depth total millimeters.
		/// </summary>
		/// <returns>The the depth total millimeters.</returns>
		/// <param name="depthInMeters">Depth in meters.</param>
		/// <param name="depthInCentimeters">Depth in centimeters.</param>
		/// <param name="depthInMillimeters">Depth in millimeters.</param>
		public double GetDepthTotalMillimeters(
			double depthInMeters,
			double depthInCentimeters, 
			double depthInMillimeters)
		{
			double millimetersMeters = 0;
			double millimetersCentermeters = 0;
			double retVal = 0;

			millimetersMeters = depthInMeters *
			this.math.ConvertMetersToMillimters;
                  
			millimetersCentermeters = depthInCentimeters *
			this.math.ConvertCentimetersToMillimeters;
                  
			retVal = millimetersMeters + millimetersCentermeters +
			depthInMillimeters;

			return retVal;
		}

		/// <summary>
		/// Gets the length total millimeters.
		/// </summary>
		/// <returns>The the length total millimeters.</returns>
		/// <param name="lengthInMeters">Length in meters.</param>
		/// <param name="lengthInCentimeters">Length in centimeters.</param>
		/// <param name="lengthInMillimeters">Length in millimeters.</param>
		public double GetLengthTotalMillimeters(
			double lengthInMeters, 
			double lengthInCentimeters, 
			double lengthInMillimeters)
		{
			double millimetersMeters = 0;
			double millimetersCentimeters = 0;
			double retVal = 0;

			millimetersMeters = lengthInMeters *
			this.math.ConvertMetersToMillimters;
                  
			millimetersCentimeters = lengthInCentimeters *
			this.math.ConvertCentimetersToMillimeters;
                  
			retVal = millimetersMeters + millimetersCentimeters +
			lengthInMillimeters;

			return retVal;
		}

		/// <summary>
		/// Gets the widths total millimeters.
		/// </summary>
		/// <returns>The the widths total millimeters.</returns>
		/// <param name="widthInMeters">Width in meters.</param>
		/// <param name="widthInCentimeters">Width in centimeters.</param>
		/// <param name="widthInMillimeters">Width in millimeters.</param>
		public double GetWidthsTotalMillimeters(
			double widthInMeters,
			double widthInCentimeters,
			double widthInMillimeters)
		{
			double millimetersMeters = 0;
			double millimetersCentimeters = 0;
			double retVal = 0;

			millimetersMeters = widthInMeters *
			this.math.ConvertMetersToMillimters;
                  
			millimetersCentimeters = widthInCentimeters *
			this.math.ConvertCentimetersToMillimeters;
			retVal = millimetersMeters + millimetersCentimeters +
			widthInMillimeters;
			return retVal;
		}

		#endregion GET TOTAL MILLIMETERS

		#region SOLVE FOR CUBIC METERS, CENTIMETERS, MILLIMETERS

		/// <summary>
		/// Solves for volume meters.
		/// </summary>
		/// <returns>The for volume meters.</returns>
		/// <param name="depthTotalMillimeters">Depth total 
		/// millimeters.</param>
		/// <param name="lengthTotalMillimeters">Length total 
		/// millimeters.</param>
		/// <param name="widthTotalMillimeters">Width total 
		/// millimeters.</param>
		public double SolveForVolumeMeters(
			double depthTotalMillimeters, 
			double lengthTotalMillimeters, 
			double widthTotalMillimeters)
		{
			Conversions conv = new Conversions();

			double retVal = 0;
			double cubicMillimeters = 0;
			double cubicMeters = 0;

			cubicMillimeters = depthTotalMillimeters * lengthTotalMillimeters *
			widthTotalMillimeters;

			cubicMeters = 
                conv.ConvertCubicMillimetersToCubicMeters(cubicMillimeters);

			retVal = Math.Round(cubicMeters, 2);

			return retVal;
		}

		/// <summary>
		/// Solves for volume centimeters.
		/// </summary>
		/// <returns>The for volume centimeters.</returns>
		/// <param name="depthTotalMillimeters">Depth total 
		/// millimeters.</param>
		/// <param name="lengthTotalMillimeters">Length total 
		/// millimeters.</param>
		/// <param name="widthTotalMillimeters">Width total 
		/// millimeters.</param>
		public double SolveForVolumeCentimeters(
			double depthTotalMillimeters,
			double lengthTotalMillimeters, 
			double widthTotalMillimeters)
		{
			Conversions conv = new Conversions();

			double retVal = 0;
			double cubicCentimeters = 0;
			double cubicMillimeters = 0;

			cubicMillimeters = depthTotalMillimeters * lengthTotalMillimeters *
			widthTotalMillimeters;

			cubicCentimeters = 
                conv.ConvertCubicMillimetersToCubicCentimeters(
				cubicMillimeters);
            
			retVal = Math.Round(cubicCentimeters, 2);

			return retVal;
		}

		public double SolveForVolumeMillimeters(
			double depthTotalMillimeters,
			double lengthTotalMillimeters,
			double widthTotalMillimeters)
		{
			double retVal = 0;

			retVal = depthTotalMillimeters * lengthTotalMillimeters *
			widthTotalMillimeters;

			return retVal;
		}

		#endregion SOLVE FOR CUBIC METERS, CENTIMETERS, MILLIMETERS
	}
}

