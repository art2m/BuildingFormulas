//
//  Math.cs
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
	/// Math. Const values used in math formulas.
	/// </summary>
	public class MyMath
	{
		#region STANDARD UNITS TO STANDARD UNITS

		/// <summary>
		/// The inches in one yard.
		/// </summary>
		private const double InchesInOneYard = 36;

		/// <summary>
		/// The inches in one foot.
		/// </summary>
		private const double InchesInOneFoot = 12;

		/// <summary>
		/// The yards in one foot.
		/// </summary>
		private const double YardsInOneFoot = 3;

		/// <summary>
		/// The cube sides.
		/// </summary>
		private const double CubeSides = 6;

		#endregion STANDARD UNITS

		#region STANDARD UNITS TO METRIC UNITS

		/// <summary>
		/// The meters in one yard.
		/// </summary>
		private const double MetersInOneYard = 0.9144;

		/// <summary>
		/// The meters in one foot.
		/// </summary>
		private const double MetersInOneFoot = 0.3048;

		/// <summary>
		/// The meters in one inch.
		/// </summary>
		private const double MetersInOneInch = 0.0254;

		/// <summary>
		/// The centimeters in one yard.
		/// </summary>
		private const double CentimetersInOneYard = 91.44;

		/// <summary>
		/// The centimeters in one foot.
		/// </summary>
		private const double CentimetersInOneFoot = 30.48;

		/// <summary>
		/// The centimeters in one inch.
		/// </summary>
		private const double CentimetersInOneInch = 2.54;

		/// <summary>
		/// The millimeters in one yard.
		/// </summary>
		private const double MillimetersInOneYard = 914.4;

		/// <summary>
		/// The millimeters in one foot.
		/// </summary>
		private const double MillimetersInOneFoot = 304.8;

		/// <summary>
		/// The millimeters in one inch.
		/// </summary>
		private const double MillimetersInOneInch = 25.4;

		#endregion CONVERT STANDARD UNITS TO METRIC UNITS

		#region CONVERT METRIC UNITS TO STANDARD UNITS

		/// <summary>
		/// The yards in one meter.
		/// </summary>
		private const double YardsInOneMeter = 1.0936133;

		/// <summary>
		/// The yards in one centimeter.
		/// </summary>
		private const double YardsInOneCentimeter = 0.01093613298;

		/// <summary>
		/// The yards in one millimeter.
		/// </summary>
		private const double YardsInOneMillimeter = 0.0010936133;

		/// <summary>
		/// The feet in one meter.
		/// </summary>
		private const double FeetInOneMeter = 3.2808399;

		/// <summary>
		/// The feet in one centimeter.
		/// </summary>
		private const double FeetInOneCentimeter = 0.03280839895;

		/// <summary>
		/// The feet in one millimeter.
		/// </summary>
		private const double FeetInOneMillimeter = 0.0032808399;

		/// <summary>
		/// The inches in one meter.
		/// </summary>
		private const double InchesInOneMeter = 39.3700787;

		/// <summary>
		/// The inches in one centimeter.
		/// </summary>
		private const double InchesInOneCentimeter = 0.3937007874;

		/// <summary>
		/// The inches in one millimeter.
		/// </summary>
		private const double InchesInOneMillimeter = 0.03937007874;

		#endregion CONVERT METRIC UNITS TO STANDARD UNITS

		#region METRIC UNITS TO METRIC UNITS

		/// <summary>
		/// The meters in one centimeter.
		/// </summary>
		private const double MetersInOneCentimeter = 0.01;

		/// <summary>
		/// The meters in one millimeter.
		/// </summary>
		private const double MetersInOneMillimeter = 0.001;

		/// <summary>
		/// The centimeters in one meter.
		/// </summary>
		private const double CentimetersInOneMeter = 100;

		/// <summary>
		/// The centimeters in one millimetr.
		/// </summary>
		private const double CentimetersInOneMillimetr = .1;

		/// <summary>
		/// The millimeters in one meter.
		/// </summary>
		private const double MillimetersInOneMeter = 1000;

		/// <summary>
		/// /*The millimeters in one centimeter.*/
		/// </summary>
		private const double MillimetersInOneCentimeter = 10;

		#endregion METRIC UNITS TO METRIC UNITS

		#region STANDARD CUBIC UNITS TO METRIC CUBIC UNITS VARIABLES

		/// <summary>
		/// The cubic meters in one cubic yard.
		/// </summary>
		private const double CubicMetersInOneCubicYard = 0.76455485798;

		/// <summary>
		/// The cubic centimeters in one cubic yard.
		/// </summary>
		private const double CubicCentimetersInOneCubicYard = 764554.857992;

		/// <summary>
		/// The cubic millimeters in one cubic yard.
		/// </summary>
		private const double CubicMillimetersInOneCubicYard = 764554858;

		/// <summary>
		/// The cubic meters in one cubic foot.
		/// </summary>
		private const double CubicMetersInOneCubicFoot = 0.02831684659;

		/// <summary>
		/// The cubic centimeters in one cubic foot.
		/// </summary>
		private const double CubicCentimetersInOneCubicFoot = 28316.8466;

		/// <summary>
		/// The cubic millimeters in one cubic foot.
		/// </summary>
		private const double CubicMillimetersInOneCubicFoot = 28316846.6;

		/// <summary>
		/// The cubic meters in one cubic inch.
		/// </summary>
		private const double CubicMetersInOneCubicInch = 0.000016387064;

		/// <summary>
		/// The cubic centimeters in one cubic inch.
		/// </summary>
		private const double CubicCentimetersInOneCubicInch = 16.387064;

		/// <summary>
		/// The cubic millimeters in one cubic inch.
		/// </summary>
		private const double CubicMillimetersInOneCubicInch = 16387.064;

		#endregion STANDARD CUBIC UNITS TO METRIC CUBIC UNITS VARIABLES

		#region METRIC CUBIC UNITS TO STANDARD CUBIC UNITS VARIABLES

		/// <summary>
		/// The cubic yards in one cubic meter.
		/// </summary>
		private const double CubicYardsInOneCubicMeter = 1.30795062;

		/// <summary>
		/// The cubic yards in one cubic centimeter.
		/// </summary>
		private const double CubicYardsInOneCubicCentimeter = 0.000001307950619;

		/// <summary>
		/// The cubic yard in one cubic millimeter.
		/// </summary>
		private const double CubicYardInOneCubicMillimeter = 0.000000001307;

		/// <summary>
		/// The cubic feet in one cubic meter.
		/// </summary>
		private const double CubicFeetInOneCubicMeter = 35.3146667;

		/// <summary>
		/// The cubic feet in one cubic centimeter.
		/// </summary>
		private const double CubicFeetInOneCubicCentimeter = 0.00003531466672;

		/// <summary>
		/// The cubic feet in one cubic millimeter.
		/// </summary>
		private const double CubicFeetInOneCubicMillimeter = 0.0000000353;

		/// <summary>
		/// The cubic inches in one cubic meter.
		/// </summary>
		private const double CubicInchesInOneCubicMeter = 61023.7441;

		/// <summary>
		/// The cubic inches in one cubic centimeter.
		/// </summary>
		private const double CubicInchesInOneCubicCentimeter = 0.06102374409;

		/// <summary>
		/// The cubic inches in one cubic millimeter.
		/// </summary>
		private const double CubicInchesInOneCubicMillimeter = 0.00006102374;

		#endregion METRIC UNITS TO STANDARD UNITS VARIABLES

		#region METRIC CUBIC UNITS TO METRIC CUBIC UNITS VARIABLES

		/// <summary>
		/// The cubic meters in one cubic centimeter.
		/// </summary>
		private const double CubicMetersInOneCubicCentimeter = 0.000001;

		/// <summary>
		/// The cubic millimeters in one cubic centimeter.
		/// </summary>
		private const double CubicMillimetersInOneCubicCentimeter = 1000;

		/// <summary>
		/// The cubic meters in one cubic millileters.
		/// </summary>
		private const double CubicMetersInOneCubicMillileters = 0.000000001;

		/// <summary>
		/// The cubic centimeters in one cubic millimeters.
		/// </summary>
		private const double CubicCentimetersInOneCubicMillimeters = 0.001;

		/// <summary>
		/// The cubic centimeters in one cubic meter.
		/// </summary>
		private const double CubicCentimetersInOneCubicMeter = 1000000;

		/// <summary>
		/// The cubic millileters in one cubic meter.
		/// </summary>
		private const double CubicMilliletersInOneCubicMeter = 1000000000;

		#endregion METRIC CUBIC UNITS TO METRIC CUBIC UNITS VARIABLES

		#region STANDARD CUBIC UNITS TO STANDARD CUBIC UNITS VARIABLES

		/// <summary>
		/// The cubic inches in one cubic foot.
		/// </summary>
		private const double CubicInchesInOneCubicFoot = 1728;

		/// <summary>
		/// The cubic inches in one cubic yard.
		/// </summary>
		private const double CubicInchesInOneCubicYard = 46656;

		/// <summary>
		/// The cubic yards in one cubic inch.
		/// </summary>
		private const double CubicYardsInOneCubicInch = 0.000021433471;

		/// <summary>
		/// The cubic feet in one cubic inch.
		/// </summary>
		private const double CubicFeetInOneCubicInch = 0.000578703704;

		/// <summary>
		/// The cubic feet in one cubic yard.
		/// </summary>
		private const double CubicFeetInOneCubicYard = 27;

		/// <summary>
		/// The cubic yards in one cubic foot.
		/// </summary>
		private const double CubicYardsInOneCubicFoot = 0.03703703704;

		#endregion STANDARD CUBIC UNITS TO STANDARD CUBIC UNITS VARIABLES

		#region PROPERTY VARIABLES: USER ENTERED SIZE DATA

		/// <summary>
		/// The depth in yards.
		/// </summary>
		private double depthYard = 0;

		/// <summary>
		/// The length in yards.
		/// </summary>
		private double lengthYard = 0;

		/// <summary>
		/// The width in yards.
		/// </summary>
		private double widthYard = 0;

		/// <summary>
		/// The diameter yard.
		/// </summary>
		private double diameterYard = 0;

		/// <summary>
		/// The height yard.
		/// </summary>
		private double heightYard = 0;

		/// <summary>
		/// The width in feet.
		/// </summary>
		private double widthFeet = 0;

		/// <summary>
		/// The depth in feet.
		/// </summary>
		private double depthFeet = 0;

		/// <summary>
		/// The length in feet.
		/// </summary>
		private double lengthFeet = 0;

		/// <summary>
		/// The diameter feet.
		/// </summary>
		private double diameterFeet = 0;

		/// <summary>
		/// The height feet.
		/// </summary>
		private double heightFeet = 0;

		/// <summary>
		/// The width in inches.
		/// </summary>
		private double widthInches = 0;

		/// <summary>
		/// The depth in inches.
		/// </summary>
		private double depthInches = 0;

		/// <summary>
		/// The length in inches.
		/// </summary>
		private double lengthInches = 0;

		/// <summary>
		/// The diameter inches.
		/// </summary>
		private double diameterInches = 0;

		/// <summary>
		/// The height inches.
		/// </summary>
		private double heightInches = 0;

		/// <summary>
		/// The depth total inches.
		/// </summary>
		private double depthTotalInches = 0;

		/// <summary>
		/// The length total inches.
		/// </summary>
		private double lengthTotalInches = 0;

		/// <summary>
		/// The width total inches.
		/// </summary>
		private double widthTotalInches = 0;

		/// <summary>
		/// The height total inches.
		/// </summary>
		private double heightTotalInches = 0;

		/// <summary>
		/// The diameter total inches.
		/// </summary>
		private double diameterTotalInches = 0;

		/// <summary>
		/// The total cubic yards.
		/// </summary>
		private double totalCubicYards = 0;

		/// <summary>
		/// The total cubic feet.
		/// </summary>
		private double totalCubicFeet = 0;

		/// <summary>
		/// The total cubic inches.
		/// </summary>
		private double totalCubicInches = 0;

		/// <summary>
		/// The depth meters.
		/// </summary>
		private double depthMeters = 0;

		/// <summary>
		/// The depth centimeters.
		/// </summary>
		private double depthCentimeters = 0;

		/// <summary>
		/// The depth millimeter.
		/// </summary>
		private double depthMillimeter = 0;

		/// <summary>
		/// The length meters.
		/// </summary>
		private double lengthMeters = 0;

		/// <summary>
		/// The length centimeters.
		/// </summary>
		private double lengthCentimeters = 0;

		/// <summary>
		/// The length millimeters.
		/// </summary>
		private double lengthMillimeters = 0;

		/// <summary>
		/// The width meters.
		/// </summary>
		private double widthMeters = 0;

		/// <summary>
		/// The width centimeters.
		/// </summary>
		private double widthCentimeters = 0;

		/// <summary>
		/// The width millimeters.
		/// </summary>
		private double widthMillimeters = 0;

		/// <summary>
		/// The total cubic meters.
		/// </summary>
		private double totalCubicMeters = 0;

		/// <summary>
		/// The total cubic centimeters.
		/// </summary>
		private double totalCubicCentimeters = 0;

		/// <summary>
		/// The total cubic millimeters.
		/// </summary>
		private double totalCubicMillimeters = 0;

		/// <summary>
		/// The depth total millimeters.
		/// </summary>
		private double depthTotalMillimeters = 0;

		/// <summary>
		/// The length total millimeters.
		/// </summary>
		private double lengthTotalMillimeters = 0;

		/// <summary>
		/// The width total millimeters.
		/// </summary>
		private double widthTotalMillimeters = 0;

		#endregion PROPERTY VARIABLES: USER ENTERED SIZE DATA

		/// <summary>
		/// The pi.
		/// </summary>
		private const double pi = 3.141592;

		/// <summary>
		/// Initializes a new instance of the 
		/// <see cref="BuildingFormulas.MyMath"/> class.
		/// </summary>
		public MyMath()
		{
		}

		/// <summary>
		/// Gets the pi value.
		/// </summary>
		/// <value>The pi value.</value>
		public double PiValue
		{
			get
			{
				return pi;
			}
		}

		#region PROPERTIES STANDARD UNITS TO STANDARD UNITS

		/// <summary>
		/// Gets the cubic feet in A cubic inches.
		/// </summary>
		/// <value>The cubic feet in A cubic inches.</value>
		public double CubicInchesInCubicFeet
		{
			get
			{
				return CubicFeetInOneCubicInch;
			}
		}

		/// <summary>
		/// Gets the cubic yards in A cubic inches.
		/// </summary>
		/// <value>The cubic yards in A cubic inches.</value>
		public double ConvertCubicInchesToCubicYards
		{
			get
			{
				return CubicYardsInOneCubicInch;
			}
		}

		/// <summary>
		/// Gets the cubic yard in A cubic feet.
		/// </summary>
		/// <value>The cubic yard in A cubic feet.</value>
		public double CubicYardsInCubicFeet
		{
			get
			{
				return this.CubicYardsInCubicFeet;
			}
		}

		/// <summary>
		/// Gets the cubic feet in A cubic yard.
		/// </summary>
		/// <value>The cubic feet in A cubic yard.</value>
		public double ConvertCubicYardToCubicFeet
		{
			get
			{
				return CubicFeetInOneCubicYard;
			}
		}

		/// <summary>
		/// Gets the cubic inches in cubic foot.
		/// </summary>
		/// <value>The cubic inches in cubic foot.</value>
		public double ConvertCubicFeetToCubicInches
		{
			get
			{
				return this.CubicInchesInCubicFeet;
			}
		}

		/// <summary>
		/// Gets the cubic inches in cubic yard.
		/// </summary>
		/// <value>The cubic inches in cubic yard.</value>
		public double ConvertCubicYardsToCubicInches
		{
			get
			{
				return CubicInchesInOneCubicYard;
			}
		}

		/// <summary>
		/// Gets the inches in yard.
		/// </summary>
		/// <value>The inches in a yard.</value>
		public double ConvertInchesToYards
		{
			get
			{
				return InchesInOneYard;
			}
		}

		/// <summary>
		/// Gets the inches in foot.
		/// </summary>
		/// <value>The inches in a foot.</value>
		public double ConvertInchesToFeet
		{
			get
			{
				return InchesInOneFoot;
			}
		}

		/// <summary>
		/// Gets the feet in a yard.
		/// </summary>
		/// <value>The feet in yards.</value>
		public double ConvertFeetToYards
		{
			get
			{
				return YardsInOneFoot;
			}
		}

		#endregion PROPERTIES STANDARD UNITS TO STANDARD UNITS

		/// <summary>
		/// Gets the number of sides in a cube.
		/// </summary>
		/// <value>The cube sides.</value>
		public double CubeNumberOfSides
		{
			get
			{
				return CubeSides;
			}
		}

		#region PROPERTIES STANDARD CUBIC UNITS TO METRIC CUBIC UNITS

		/// <summary>
		/// Gets the cubic meters in a cubic yard.
		/// </summary>
		/// <value>The cubic meters in cubic yard.</value>
		public double ConvertCubicYardsToCubicMeters
		{
			get
			{
				return CubicMetersInOneCubicYard;
			}
		}

		/// <summary>
		/// Gets the cubic centimeters in a cubic yard.
		/// </summary>
		/// <value>The cubic centimeters in cubic yard.</value>
		public double ConvertCubicYardsToCubicCentimeters
		{
			get
			{
				return CubicCentimetersInOneCubicYard;
			}
		}

		/// <summary>
		/// Gets the cubic millimeters in cubic yard.
		/// </summary>
		/// <value>The cubic millimeters in cubic yard.</value>
		public double ConvertCubicYardsToCubicMillimeters
		{
			get
			{
				return CubicMillimetersInOneCubicYard;
			}
		}

		/// <summary>
		/// Gets the cubic meters in a cubic foot.
		/// </summary>
		/// <value>The cubic meters cubic foot.</value>
		public double ConvertCubicFeetToCubicMeters
		{
			get
			{
				return CubicMetersInOneCubicFoot;
			}
		}

		/// <summary>
		/// Gets the cubic centimetes in a cubic foot.
		/// </summary>
		/// <value>The cubic centimetes cubic foot.</value>
		public double ConvertCubicFeetToCubicCentimeters
		{
			get
			{
				return CubicCentimetersInOneCubicFoot;
			}
		}

		/// <summary>
		/// Gets the cubic millimeters in a cubic foot.
		/// </summary>
		/// <value>The cubic millimeters cubic foot.</value>
		public double ConvertCubicFeetToCubicMillimeters
		{
			get
			{
				return CubicMillimetersInOneCubicFoot;
			}
		}

		/// <summary>
		/// Gets the cubic meters in a cubic inch.
		/// </summary>
		/// <value>The cubic meters in cubic inch.</value>
		public double ConvertCubicInchesToCubicMeters
		{
			get
			{
				return CubicMetersInOneCubicInch;
			}
		}

		/// <summary>
		/// Gets the cubic centimeters in a cubic inch.
		/// </summary>
		/// <value>The cubic centimeters in cubic inch.</value>
		public double ConvertCubicInchesToCubicCentimeters
		{
			get
			{
				return CubicCentimetersInOneCubicInch;
			}
		}

		/// <summary>
		/// Gets the cubic millimeters in a cubic inch.
		/// </summary>
		/// <value>The cubic millimeters in cubic inch.</value>
		public double ConvertCubicInchesToCubicMillimeters
		{
			get
			{
				return CubicMillimetersInOneCubicInch;
			}
		}

		#endregion PROPERTIES STANDARD CUBIC UNITS TO METRIC CUBIC UNITS

		#region PROPERTIES METRIC CUBIC UNITS TO STANDARD CUBIC UNITS

		/// <summary>
		/// Gets the cubic yards in a cubic meter.
		/// </summary>
		/// <value>The cubic yards in cubic meter.</value>
		public double ConvertCubicMetersToCubicYards
		{
			get
			{
				return CubicYardsInOneCubicMeter;
			}
		}

		/// <summary>
		/// Gets the cubic yards in a cubic centimeter.
		/// </summary>
		/// <value>The cubic yards in a cubic centimeter.</value>
		public double ConvertCubicCentimetersToCubicYards
		{
			get
			{
				return CubicYardsInOneCubicCentimeter;
			}
		}

		/// <summary>
		/// Gets the cubic yards in a cubic millimeter.
		/// </summary>
		/// <value>The cubic yards in cubic millimeter.</value>
		public double ConvertCubicMillimetersToCubicYards
		{
			get
			{
				return CubicYardInOneCubicMillimeter;
			}
		}

		/// <summary>
		/// Gets the cubic feet in a cubic meter.
		/// </summary>
		/// <value>The cubic feet in cubic meter.</value>
		public double ConvertCubicMeterstToCubicFeet
		{
			get
			{
				return CubicFeetInOneCubicMeter;
			}
		}

		/// <summary>
		/// Gets the cubic feet in a cubic centimeter.
		/// </summary>
		/// <value>The cubic feet in cubic centimeter.</value>
		public double ConvertCubicCentimetersToCubicFeet
		{
			get
			{
				return CubicFeetInOneCubicCentimeter;
			}
		}

		/// <summary>
		/// Gets the cubic feet in a cubic millimeter.
		/// </summary>
		/// <value>The cubic feet in cubic millimeter.</value>
		public double ConvertCubicMillimtersToCubicFeet
		{
			get
			{
				return CubicFeetInOneCubicMillimeter;
			}
		}

		/// <summary>
		/// Gets the cubic inches in a cubic meter.
		/// </summary>
		/// <value>The cubic inches in cubic meter.</value>
		public double ConvertCubicMetersToCubicInches
		{
			get
			{
				return CubicInchesInOneCubicMeter;
			}
		}

		/// <summary>
		/// Gets the cubic inches in a cubic centimeters.
		/// </summary>
		/// <value>The cubic inches in cubic centimeters.</value>
		public double ConvertCubicCentimetersToCubicInches
		{
			get
			{
				return CubicInchesInOneCubicCentimeter;
			}
		}

		/// <summary>
		/// Gets the cubic inches in a cubic millimeters.
		/// </summary>
		/// <value>The cubic inches in cubic millimeters.</value>
		public double ConvertCubicMillimetersToCubicInches
		{
			get
			{
				return CubicInchesInOneCubicMillimeter;
			}
		}

		#endregion PROPERTIES METRIC CUBIC UNITS TO STANDARD CUBIC UNITS

		#region PROPERTIES METRIC CUBIC UNITS TO METRIC CUBIC UNITS

		/// <summary>
		/// Gets the cubic centimeters in a cubic meter.
		/// </summary>
		/// <value>The cubic centimeters in cubic meter.</value>
		public double ConvertCubicMetersToCubicCentimeters
		{
			get
			{
				return CubicCentimetersInOneCubicMeter;
			}
		}

		/// <summary>
		/// Gets the cubic millimeters in a cubic meter.
		/// </summary>
		/// <value>The cubic millimeters in cubic meter.</value>
		public double ConvertCubicMeterToCubicCentimeters
		{
			get
			{
				return CubicMilliletersInOneCubicMeter;
			}
		}

		/// <summary>
		/// Gets the cubic meters in a cubic centimeter.
		/// </summary>
		/// <value>The cubic meters in cubic centimeter.</value>
		public double ConvertCubicCentimetersToCubicMeters
		{
			get
			{
				return CubicMetersInOneCubicCentimeter;
			}
		}

		/// <summary>
		/// Gets the cubic millimeters in a cubic centimeter.
		/// </summary>
		/// <value>The cubic millimeters in cubic centimeter.</value>
		public double CubicCubicCentimeterToCubicMillimeters
		{
			get
			{
				return CubicMillimetersInOneCubicCentimeter;
			}
		}

		/// <summary>
		/// Gets the cubic meters in a cubic millileters.
		/// </summary>
		/// <value>The cubic meters incubic millileters.</value>
		public double ConvertCubicMillimetersToCubicMeters
		{
			get
			{
				return CubicMetersInOneCubicMillileters;
			}
		}

		/// <summary>
		/// Gets the cubic centimeters in a cubic millimeters.
		/// </summary>
		/// <value>The cubic centimeters in cubic millimeters.</value>
		public double ConvertCubicCMillimetersToCubicCentimeters
		{
			get
			{
				return CubicCentimetersInOneCubicMillimeters;
			}
		}

		#endregion PROPERTIES METRIC CUBIC UNITS TO METRIC CUBIC UNITS

		#region PROPERTIES METRIC UNITS TO STANDARD UNITS

		/// <summary>
		/// Gets the convet meters to yards.
		/// </summary>
		/// <value>The convet meters to yards.</value>
		public double ConvertMetersToYards
		{
			get
			{
				return YardsInOneMeter;
			}
		}

		/// <summary>
		/// Gets the convert centimeters to yards.
		/// </summary>
		/// <value>The convert centimeters to yards.</value>
		public double ConvertCentimetersToYards
		{
			get
			{
				return YardsInOneCentimeter;
			}
		}

		/// <summary>
		/// Gets the convert millimeters to yards.
		/// </summary>
		/// <value>The convert millimeters to yards.</value>
		public double ConvertMillimetersToYards
		{
			get
			{
				return YardsInOneMillimeter;
			}
		}

		/// <summary>
		/// Gets the convert meters to feet.
		/// </summary>
		/// <value>The convert meters to feet.</value>
		public double ConvertMetersToFeet
		{
			get
			{
				return FeetInOneMeter;
			}
		}

		/// <summary>
		/// Gets the convert centimeters to feet.
		/// </summary>
		/// <value>The convert centimeters to feet.</value>
		public double ConvertCentimetersToFeet
		{
			get
			{
				return FeetInOneCentimeter;
			}
		}

		/// <summary>
		/// Gets the convert millimeters to feet.
		/// </summary>
		/// <value>The convert millimeters to feet.</value>
		public double ConvertMillimetersToFeet
		{
			get
			{
				return FeetInOneMillimeter;
			}
		}

		/// <summary>
		/// Gets the convert meters to inches.
		/// </summary>
		/// <value>The convert meters to inches.</value>
		public double ConvertMetersToInches
		{
			get
			{
				return InchesInOneMeter;
			}
		}

		/// <summary>
		/// Gets the convert centimeters to inches.
		/// </summary>
		/// <value>The convert centimeters to inches.</value>
		public double ConvertCentimetersToInches
		{
			get
			{
				return InchesInOneCentimeter;
			}
		}

		/// <summary>
		/// Gets the convert millimeters to inches.
		/// </summary>
		/// <value>The convert millimeters to inches.</value>
		public double ConvertMillimetersToInches
		{
			get
			{
				return InchesInOneMillimeter;
			}
		}

		#endregion PROPERTIES METRIC UNITS TO STANDARD UNITS

		#region PROPERTIES STANDARD UNITS TO METRIC UNITS

		/// <summary>
		/// Gets the convert yards to meters.
		/// </summary>
		/// <value>The convert yards to meters.</value>
		public double ConvertYardsToMeters
		{
			get
			{
				return MetersInOneYard;
			}
		}

		/// <summary>
		/// Gets the convert feet to meters.
		/// </summary>
		/// <value>The convert feet to meters.</value>
		public double ConvertFeetToMeters
		{
			get
			{
				return MetersInOneFoot;
			}
		}

		/// <summary>
		/// Gets the convert inches to meters.
		/// </summary>
		/// <value>The convert inches to meters.</value>
		public double ConvertInchesToMeters
		{
			get
			{
				return MetersInOneInch;
			}
		}

		/// <summary>
		/// Gets the convert yards to centimeters.
		/// </summary>
		/// <value>The convert yards to centimeters.</value>
		public double ConvertYardsToCentimeters
		{
			get
			{
				return CentimetersInOneYard;
			}
		}

		/// <summary>
		/// Gets the convert feet to centimeters.
		/// </summary>
		/// <value>The convert feet to centimeters.</value>
		public double ConvertFeetToCentimeters
		{
			get
			{
				return CentimetersInOneFoot;
			}
		}

		/// <summary>
		/// Gets the convert inches to centimeters.
		/// </summary>
		/// <value>The convert inches to centimeters.</value>
		public double ConvertInchesToCentimeters
		{
			get
			{
				return CentimetersInOneInch;
			}
		}

		/// <summary>
		/// Gets the convert yards to millimetrs.
		/// </summary>
		/// <value>The convert yards to millimetrs.</value>
		public double ConvertYardsToMillimetrs
		{
			get
			{
				return MillimetersInOneYard;
			}
		}

		/// <summary>
		/// Gets the convert feet to millimeters.
		/// </summary>
		/// <value>The convert feet to millimeters.</value>
		public double ConvertFeetToMillimeters
		{
			get
			{
				return MillimetersInOneFoot;
			}
		}

		/// <summary>
		/// Gets the convert inches to millimeters.
		/// </summary>
		/// <value>The convert inches to millimeters.</value>
		public double ConvertInchesToMillimeters
		{
			get
			{
				return MillimetersInOneInch;
			}
		}

		#endregion PROPERTIES STANDARD UNITS TO METRIC UNITS

		#region PROPERTIES METRIC UNITS TO METRIC UNITS

		/// <summary>
		/// Gets the convert centimeters to meters.
		/// </summary>
		/// <value>The convert centimeters to meters.</value>
		public double ConvertCentimetersToMeters
		{
			get
			{
				return MetersInOneCentimeter;
			}
		}

		/// <summary>
		/// Gets the convert millimeters to meters.
		/// </summary>
		/// <value>The convert millimeters to meters.</value>
		public double ConvertMillimetersToMeters
		{
			get
			{
				return MetersInOneMillimeter;
			}
		}

		/// <summary>
		/// Gets the convert meters to centimters.
		/// </summary>
		/// <value>The convert meters to centimters.</value>
		public double ConvertMetersToCentimters
		{
			get
			{
				return CentimetersInOneMeter;
			}
		}

		/// <summary>
		/// Gets the convert millimeters to centimeters.
		/// </summary>
		/// <value>The convert millimeters to centimeters.</value>
		public double ConvertMillimetersToCentimeters
		{
			get
			{
				return CentimetersInOneMillimetr;
			}
		}

		/// <summary>
		/// Gets the convert meters to millimters.
		/// </summary>
		/// <value>The convert meters to millimters.</value>
		public double ConvertMetersToMillimters
		{
			get
			{
				return MillimetersInOneMeter;
			}
		}

		/// <summary>
		/// Gets the convert centimeters to millimeters.
		/// </summary>
		/// <value>The convert centimeters to millimeters.</value>
		public double ConvertCentimetersToMillimeters
		{
			get
			{
				return MillimetersInOneCentimeter;
			}
		}

		/// <summary>
		/// Gets the convert cubci yards to cubic feet.
		/// </summary>
		/// <value>The convert cubci yards to cubic feet.</value>
		public double ConvertCubicYardsToCubicFeet
		{
			get
			{
				return CubicFeetInOneCubicYard;
			}
		}

		#endregion PROPERTIES METRIC UNITS TO METRIC UNITS

		#region USER ENTERED DATA

		/// <summary>
		/// Gets or sets the depth in yards.
		/// </summary>
		/// <value>The depth in yards.</value>
		public double DepthInYards
		{
			get
			{
				return this.depthYard;
			}

			set
			{
				this.depthYard = value;
			}
		}

		/// <summary>
		/// Gets or sets the length yard.
		/// </summary>
		/// <value>The length yard.</value>
		public double LengthInYards
		{
			get
			{
				return this.lengthYard;
			}

			set
			{
				this.lengthYard = value;
			}
		}

		/// <summary>
		/// Gets or sets the width yard.
		/// </summary>
		/// <value>The width yard.</value>
		public double WidthInYards
		{
			get
			{
				return this.widthYard;
			}

			set
			{
				this.widthYard = value;
			}
		}

		/// <summary>
		/// Gets or sets the diameter yard.
		/// </summary>
		/// <value>The diameter yard.</value>
		public double DiameterYard
		{
			get
			{
				return this.diameterYard;
			}

			set
			{
				this.diameterYard = value;
			}
		}

		/// <summary>
		/// Gets or sets the height yard.
		/// </summary>
		/// <value>The height yard.</value>
		public double HeightYard
		{
			get
			{
				return this.heightYard;
			}

			set
			{
				this.heightYard = value;
			}
		}

		/// <summary>
		/// Gets or sets the width feet.
		/// </summary>
		/// <value>The width feet.</value>
		public double WidthInFeet
		{
			get
			{
				return this.widthFeet;
			}

			set
			{
				this.widthFeet = value;
			}
		}

		/// <summary>
		/// Gets or sets the depth feet.
		/// </summary>
		/// <value>The depth feet.</value>
		public double DepthInFeet
		{
			get
			{
				return this.depthFeet;
			}

			set
			{
				this.depthFeet = value;
			}
		}

		/// <summary>
		/// Gets or sets the length feet.
		/// </summary>
		/// <value>The length feet.</value>
		public double LengthInFeet
		{
			get
			{
				return this.lengthFeet;
			}

			set
			{
				this.lengthFeet = value;
			}
		}

		/// <summary>
		/// Gets or sets the diameter feet.
		/// </summary>
		/// <value>The diameter feet.</value>
		public double DiameterFeet
		{
			get
			{
				return this.diameterFeet;
			}

			set
			{
				this.diameterFeet = value;
			}
		}

		/// <summary>
		/// Gets or sets the height feet.
		/// </summary>
		/// <value>The height feet.</value>
		public double HeightFeet
		{
			get
			{
				return this.heightFeet;
			}

			set
			{
				this.heightFeet = value;
			}
		}

		/// <summary>
		/// Gets or sets the width inches.
		/// </summary>
		/// <value>The width inches.</value>
		public double WidthInInches
		{
			get
			{
				return this.widthInches;
			}

			set
			{
				this.widthInches = value;
			}
		}

		/// <summary>
		/// Gets or sets the depth inches.
		/// </summary>
		/// <value>The depth inches.</value>
		public double DepthInInches
		{
			get
			{
				return this.depthInches;
			}

			set
			{
				this.depthInches = value;
			}
		}

		/// <summary>
		/// Gets or sets the length inches.
		/// </summary>
		/// <value>The length inches.</value>
		public double LengthInInches
		{
			get
			{
				return this.lengthInches;
			}

			set
			{
				this.lengthInches = value;
			}
		}

		/// <summary>
		/// Gets or sets the diameter inches.
		/// </summary>
		/// <value>The diameter inches.</value>
		public double DiameterInches
		{
			get
			{
				return this.diameterInches;
			}

			set
			{
				this.diameterInches = value;
			}
		}

		/// <summary>
		/// Gets or sets the height inches.
		/// </summary>
		/// <value>The height inches.</value>
		public double HeightInches
		{
			get
			{
				return this.heightInches;
			}

			set
			{
				this.heightInches = value;
			}
		}

		/// <summary>
		/// Gets or sets the depth total inches.
		/// </summary>
		/// <value>The depth total inches.</value>
		public double DepthTotalInches
		{
			get
			{
				return this.depthTotalInches;
			}

			set
			{
				this.depthTotalInches = value;
			}
		}

		/// <summary>
		/// Gets or sets the length total inches.
		/// </summary>
		/// <value>The length total inches.</value>
		public double LengthTotalInches
		{
			get
			{
				return this.lengthTotalInches;
			}

			set
			{
				this.lengthTotalInches = value;
			}
		}

		/// <summary>
		/// Gets or sets the width total inches.
		/// </summary>
		/// <value>The width total inches.</value>
		public double WidthTotalInches
		{
			get
			{
				return this.widthTotalInches;
			}

			set
			{
				this.widthTotalInches = value;
			}
		}

		/// <summary>
		/// Gets or sets the diameter total inches.
		/// </summary>
		/// <value>The diameter total inches.</value>
		public double DiameterTotalInches
		{
			get
			{
				return this.diameterTotalInches;
			}

			set
			{
				this.diameterTotalInches = value;
			}
		}

		/// <summary>
		/// Gets or sets the height total inches.
		/// </summary>
		/// <value>The height total inches.</value>
		public double HeightTotalInches
		{
			get
			{
				return this.heightTotalInches;
			}

			set
			{
				this.heightTotalInches = value;
			}
		}

		/// <summary>
		/// Gets or sets the total cubic yards.
		/// </summary>
		/// <value>The total cubic yards.</value>
		public double TotalCubicYards
		{
			get
			{
				return this.totalCubicYards;
			}

			set
			{
				this.totalCubicYards = value;
			}
		}

		/// <summary>
		/// Gets or sets the total cubic feet.
		/// </summary>
		/// <value>The total cubic feet.</value>
		public double TotalCubicFeet
		{
			get
			{
				return this.totalCubicFeet;
			}

			set
			{
				this.totalCubicFeet = value;
			}
		}

		/// <summary>
		/// Gets or sets the total cubic inches.
		/// </summary>
		/// <value>The total cubic inches.</value>
		public double TotalCubicInches
		{
			get
			{
				return this.totalCubicInches;
			}

			set
			{
				this.totalCubicInches = value;
			}
		}

		/// <summary>
		/// Gets or sets the depth meters.
		/// </summary>
		/// <value>The depth meters.</value>
		public double DepthMeters
		{
			get
			{
				return depthMeters;
			}

			set
			{
				depthMeters = value;
			}
		}

		/// <summary>
		/// Gets or sets the depth centimeters.
		/// </summary>
		/// <value>The depth centimeters.</value>
		public double DepthCentimeters
		{
			get
			{
				return depthCentimeters;
			}

			set
			{
				depthCentimeters = value;
			}
		}

		/// <summary>
		/// Gets or sets the depth millimeter.
		/// </summary>
		/// <value>The depth millimeter.</value>
		public double DepthMillimeter
		{
			get
			{
				return depthMillimeter;
			}

			set
			{
				depthMillimeter = value;
			}
		}

		/// <summary>
		/// Gets or sets the length meters.
		/// </summary>
		/// <value>The length meters.</value>
		public double LengthMeters
		{
			get
			{
				return lengthMeters;
			}

			set
			{
				lengthMeters = value;
			}
		}

		/// <summary>
		/// Gets or sets the length centimeters.
		/// </summary>
		/// <value>The length centimeters.</value>
		public double LengthCentimeters
		{
			get
			{
				return lengthCentimeters;
			}

			set
			{
				lengthCentimeters = value;
			}
		}

		/// <summary>
		/// Gets or sets the length millimeters.
		/// </summary>
		/// <value>The length millimeters.</value>
		public double LengthMillimeters
		{
			get
			{
				return lengthMillimeters;
			}

			set
			{
				lengthMillimeters = value;
			}
		}

		/// <summary>
		/// Gets or sets the width meters.
		/// </summary>
		/// <value>The width meters.</value>
		public double WidthMeters
		{
			get
			{
				return widthMeters;
			}

			set
			{
				widthMeters = value;
			}
		}

		/// <summary>
		/// Gets or sets the width centimeters.
		/// </summary>
		/// <value>The width centimeters.</value>
		public double WidthCentimeters
		{
			get
			{
				return widthCentimeters;
			}

			set
			{
				widthCentimeters = value;
			}
		}

		/// <summary>
		/// Gets or sets the width millimeters.
		/// </summary>
		/// <value>The width millimeters.</value>
		public double WidthMillimeters
		{
			get
			{
				return widthMillimeters;
			}

			set
			{
				widthMillimeters = value;
			}
		}

		/// <summary>
		/// Gets or sets the total cubic meters.
		/// </summary>
		/// <value>The total cubic meters.</value>
		public double TotalCubicMeters
		{
			get
			{
				return totalCubicMeters;
			}

			set
			{
				totalCubicMeters = value;
			}
		}

		/// <summary>
		/// Gets or sets the total cubic centimeters.
		/// </summary>
		/// <value>The total cubic centimeters.</value>
		public double TotalCubicCentimeters
		{
			get
			{
				return totalCubicCentimeters;
			}

			set
			{
				totalCubicCentimeters = value;
			}
		}

		/// <summary>
		/// Gets or sets the total cubic millimeters.
		/// </summary>
		/// <value>The total cubic millimeters.</value>
		public double TotalCubicMillimeters
		{
			get
			{
				return totalCubicMillimeters;
			}

			set
			{
				totalCubicMillimeters = value;
			}
		}

		/// <summary>
		/// Gets or sets the depth total millimeters.
		/// </summary>
		/// <value>The depth total millimeters.</value>
		public double DepthTotalMillimeters
		{
			get
			{
				return depthTotalMillimeters;
			}

			set
			{
				depthTotalMillimeters = value;
			}
		}

		/// <summary>
		/// Gets or sets the length total millimeters.
		/// </summary>
		/// <value>The length total millimeters.</value>
		public double LengthTotalMillimeters
		{
			get
			{
				return lengthTotalMillimeters;
			}

			set
			{
				lengthTotalMillimeters = value;
			}
		}

		/// <summary>
		/// Gets or sets the width total millimeters.
		/// </summary>
		/// <value>The width total millimeters.</value>
		public double WidthTotalMillimeters
		{
			get
			{
				return widthTotalMillimeters;
			}

			set
			{
				widthTotalMillimeters = value;
			}
		}

		#endregion USER ENTERED DATA
	}
}