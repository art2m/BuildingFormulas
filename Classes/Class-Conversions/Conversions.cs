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
    using System;

    /// <summary>
    /// Conversions class.
    /// </summary>
    public class Conversions
    {
        /// <summary>
        /// The name of the class.
        /// </summary>
        private const string MyClassName = "public class Conversions";

        /// <summary>
        /// The math object decleration.
        /// </summary>
        private MyMath math = new MyMath();

        /// <summary>
        /// My message.
        /// </summary>
        private MyMessages myMsg = new MyMessages();
       
        /// <summary>
        /// The error message.
        /// </summary>
        private string errMsg = null;
       
        /// <summary>
        /// The name of the method.
        /// </summary>
        private string methodName = null;

        /// <summary>
        /// Initializes a new instance of the<see cref=
        /// "BuildingFormulas.Conversions"/> class.
        /// </summary>
        public Conversions()
        {
        }

        #region CONVERT CUBIC STANDARD UNITS TO CUBIC STANDARD UNITS

        /// <summary>
        /// Converts the cubic yards to cubic feet.
        /// </summary>
        /// <returns>The cubic yards to cubic feet.</returns>
        /// <param name="cubicYards">Cubic yards.</param>
        public double ConvertCubicYardsToCubicFeet(double cubicYards)
        {
            double retVal = 0;

            retVal = cubicYards * math.ConvertCubicYardsToCubicFeet;

            return retVal;           
        }

        /// <summary>
        /// Converts the cubic yards to cubic inches.
        /// </summary>
        /// <returns>The cubic yards to cubic inches.</returns>
        /// <param name="cubicYards">Cubic yards.</param>
        public double ConvertCubicYardsToCubicInches(double cubicYards)
        {
            double cubicInches = 0;

            cubicInches = cubicYards * this.math.ConvertCubicInchesToCubicYards;

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
        /// Converts the cubic feet to cubic inches.
        /// </summary>
        /// <returns>The cubic feet to cubic inches.</returns>
        /// <param name="cubicFeet">Cubic feet.</param>
        public double ConvertCubicFeetToCubicInches(double cubicFeet)
        {
            double cubicInches = 0;

            cubicInches = cubicFeet * this.math.CubicInchesInCubicFeet;
            return cubicInches;
        }

        /// <summary>
        /// Converts the cubic inches to cubic yards.
        /// </summary>
        /// <returns>The cubic inches to cubic yards.</returns>
        /// <param name="cubicInches">Cubic inches.</param>
        public double ConvertCubicInchesToCubicYards(double cubicInches)
        {
            double cubicYard = 0;

            this.methodName = "public double ConvertCubicInchesToCubicYards(" +
            "double cubicInches)";
           
            cubicYard = cubicInches / this.math.ConvertCubicInchesToCubicYards;
                
            return cubicYard;           
        }

        /// <summary>
        /// Converts the cubic inches to cubic feet.
        /// </summary>
        /// <returns>The cubic inches to cubic feet.</returns>
        /// <param name="cubicInches">Cubic inches.</param>
        public double ConvertCubicInchesToCubicFeet(double cubicInches)
        {
            double cubicFeet = 0;
           
            cubicFeet = cubicInches / this.math.CubicInchesInCubicFeet;
                
            return cubicFeet;
        }

        #endregion CONVERT CUBIC STANDARD UNITS TO CUBIC STANDARD UNITS

        #region CONVERT CUBIC STANDARD UNITS TO CUBIC METRIC UNITS

        /// <summary>
        /// Converts cubic yards to cubic meters.
        /// </summary>
        /// <returns>The cubic yards to cubic meters.</returns>
        /// <param name="yardsCubic">Yards cubic.</param>
        public double ConvertCubicYardsToCubicMeters(double yardsCubic)
        {
            double retVal = 0;

            this.methodName = "public double ConvertCubicYardsToCubicMeters(" +
            "double yardsCubic)";
          
            retVal = yardsCubic * this.math.ConvertCubicYardsToCubicMeters;
                
            return retVal;           
        }

        /// <summary>
        /// Converts cubic yards to cubic centimeters.
        /// </summary>
        /// <returns>The cubic yards to cubic centimeters.</returns>
        /// <param name="yardsCubic">Yards cubic.</param>
        public double ConvertCubicYardsToCubicCentimeters(double yardsCubic)
        {
            double retVal = 0;

            retVal = yardsCubic * this.math.ConvertCubicYardsToCubicCentimeters;

            return retVal;
        }

        /// <summary>
        /// Converts cubic yards to cubic millimeters.
        /// </summary>
        /// <returns>The cubic yards to cubic millimeters.</returns>
        /// <param name="yardsCubic">Yards cubic.</param>
        public double ConvertCubicYardsToCubicMillimeters(double yardsCubic)
        {
            double retVal = 0;

            retVal = yardsCubic * this.math.ConvertCubicYardsToCubicMillimeters;

            return retVal;
        }

        /// <summary>
        /// Converts cubic feet to cubic meters.
        /// </summary>
        /// <returns>The cubic feet to cubic meters.</returns>
        /// <param name="feetCubic">Feet cubic.</param>
        public double ConvertCubicFeetToCubicMeters(double feetCubic)
        {
            double retVal = 0;

            retVal = feetCubic * this.math.ConvertCubicFeetToCubicMeters;

            return retVal;
        }

        /// <summary>
        /// Converts cubic feet to cubic centimeters.
        /// </summary>
        /// <returns>The cubic feet to cubic centimeters.</returns>
        /// <param name="feetCubic">Feet cubic.</param>
        public double ConvertCubicFeetToCubicCentimeters(double feetCubic)
        {
            double retVal = 0;

            retVal = feetCubic * this.math.ConvertCubicFeetToCubicCentimeters;

            return retVal;
        }

        /// <summary>
        /// Converts cubic feet to cubic millimeters.
        /// </summary>
        /// <returns>The cubic feet to cubic millimeters.</returns>
        /// <param name="feetCubic">Feet cubic.</param>
        public double ConvertCubicFeetToCubicMillimeters(double feetCubic)
        {
            double retVal = 0;

            retVal = feetCubic * this.math.ConvertCubicFeetToCubicMillimeters;

            return retVal;
        }

        /// <summary>
        /// Converts cubic inches to cubic meters.
        /// </summary>
        /// <returns>The cubic inches to cubic meters.</returns>
        /// <param name="inchesCubic">Inches cubic.</param>
        public double ConvertCubicInchesToCubicMeters(double inchesCubic)
        {
            double retVal = 0;

            retVal = inchesCubic * this.math.ConvertCubicInchesToCubicMeters;

            return retVal;
        }

        /// <summary>
        /// Converts cubic inches to cubic centimeters.
        /// </summary>
        /// <returns>The cubic inches to cubic centimeters.</returns>
        /// <param name="inchesCubic">Inches cubic.</param>
        public double ConvertCubicInchesToCubicCentimeters(double inchesCubic)
        {
            double retVal = 0;

            retVal = inchesCubic * this.math.ConvertCubicInchesToCubicCentimeters;

            return retVal;
        }

        /// <summary>
        /// Converts cubic inches to cubic millimeters.
        /// </summary>
        /// <returns>The cubic inches to cubic millimeters.</returns>
        /// <param name="inchesCubic">Inches cubic.</param>
        public double ConvertCubicInchesToCubicMillimeters(double inchesCubic)
        {
            double retVal = 0;

            retVal = inchesCubic * this.math.ConvertCubicInchesToCubicMillimeters;

            return retVal;
        }

        #endregion CONVERT CUBIC STANDARD UNITS TO CUBIC METRIC UNITS

        #region CONVERT CUBIC METRIC UNITS TO CUBIC STANDARD UNITS

        /// <summary>
        /// Converts cubic meters to cubic yards.
        /// </summary>
        /// <returns>The cubic meters to cubic yards.</returns>
        /// <param name="metersCubic">Meters cubic.</param>
        public double ConvertCubicMetersToCubicYards(double metersCubic)
        {
            double retVal = 0;

            retVal = metersCubic * this.math.ConvertCubicYardsToCubicMeters;

            return retVal;
        }

        /// <summary>
        /// Converts the cubic centimeters to cubic yards.
        /// </summary>
        /// <returns>The cubic centimeters to cubic yards.</returns>
        /// <param name="centimetersCubic">Centimeters cubic.</param>
        public double ConvertCubicCentimetersToCubicYards(
            double centimetersCubic)
        {
            double retVal = 0;

            retVal = centimetersCubic * this.math.ConvertCubicYardsToCubicCentimeters;

            return retVal;
        }

        /// <summary>
        /// Converts the cubic millimeters to cubic yards.
        /// </summary>
        /// <returns>The cubic millimeters to cubic yards.</returns>
        /// <param name="millimetersCubic">Millimeters cubic.</param>
        public double ConvertCubicMillimetersToCubicYards(
            double millimetersCubic)
        {
            double retVal = 0;

            retVal = millimetersCubic * this.math.ConvertCubicYardsToCubicMillimeters;

            return retVal;
        }

        /// <summary>
        /// Converts cubic meters to cubic feet.
        /// </summary>
        /// <returns>The cubic meters to cubic feet.</returns>
        /// <param name="metersCubic">Meters cubic.</param>
        public double ConvertCubicMetersToCubicFeet(double metersCubic)
        {
            double retVal = 0;

            retVal = metersCubic * this.math.ConvertCubicFeetToCubicMeters;

            return retVal;
        }

        /// <summary>
        /// Converts cubic centimeters to cubic feet.
        /// </summary>
        /// <returns>The cubic centimeters to cubic feet.</returns>
        /// <param name="centimetersCubic">Centimeters cubic.</param>
        public double ConvertCubicCentimetersToCubicFeet(
            double centimetersCubic)
        {
            double retVal = 0;

            retVal = centimetersCubic * this.math.ConvertCubicFeetToCubicCentimeters;

            return retVal;
        }

        /// <summary>
        /// Converts the cubic millimeters to cubic feet.
        /// </summary>
        /// <returns>The cubic millimeters to cubic feet.</returns>
        /// <param name="millimetersCubic">Millimeters cubic.</param>
        public double ConvertCubicMillimetersToCubicFeet(
            double millimetersCubic)
        {
            double retVal = 0;

            retVal = millimetersCubic * this.math.ConvertCubicFeetToCubicMeters;

            return retVal;
        }

        /// <summary>
        /// Converts the cubic meters to cubic inches.
        /// </summary>
        /// <returns>The cubic meters to cubic inches.</returns>
        /// <param name="metersCubic">Meters cubic.</param>
        public double ConvertCubicMetersToCubicInches(double metersCubic)
        {
            double retVal = 0;

            retVal = metersCubic * this.math.ConvertCubicInchesToCubicMeters;

            return retVal;
        }

        /// <summary>
        /// Converts the cubic centimeters to cubic inches.
        /// </summary>
        /// <returns>The cubic centimeters to cubic inches.</returns>
        /// <param name="centimetersCubic">Centimeters cubic.</param>
        public double ConvertCubicCentimetersToCubicInches(
            double centimetersCubic)
        {
            double retVal = 0;

            retVal = centimetersCubic * this.math.ConvertCubicInchesToCubicCentimeters;

            return retVal;
        }

        /// <summary>
        /// Converts the cubic millimeters to cubic inches.
        /// </summary>
        /// <returns>The cubic millimeters to cubic inches.</returns>
        /// <param name="millimetersCubic">Millimeters cubic.</param>
        public double ConvertCubicMillimetersToCubicInches(
            double millimetersCubic)
        {
            double retVal = 0;

            retVal = millimetersCubic * this.math.ConvertCubicInchesToCubicMillimeters;

            return retVal;
        }

        #endregion #region CONVERT CUBIC METRIC UNITS TO CUBIC STANDARD UNITS

        #region CONVERT CUBIC METRIC UNITS TO CUBIC METRIC UNITS

        /// <summary>
        /// Converts the cubic meters to cubic centimeters.
        /// </summary>
        /// <returns>The cubic meters to cubic centimeters.</returns>
        /// <param name="metersCubic">Meters cubic.</param>
        public double ConvertCubicMetersToCubicCentimeters(double metersCubic)
        {
            double retVal = 0;

            retVal = metersCubic * this.math.ConvertCubicMetersToCubicCentimeters;

            return retVal;
        }

        /// <summary>
        /// Converts the cubic meters to cubic millimeters.
        /// </summary>
        /// <returns>The cubic meters to cubic millimeters.</returns>
        /// <param name="metersCubic">Meters cubic.</param>
        public double ConvertCubicMetersToCubicMillimeters(double metersCubic)
        {
            double retVal = 0;

            retVal = metersCubic * this.math.ConvertCubicMeterToCubicCentimeters;

            return retVal;
        }

        /// <summary>
        /// Converts the cubic centimeters to cubic meters.
        /// </summary>
        /// <returns>The cubic centimeters to cubic meters.</returns>
        /// <param name="centimetersCubic">Centimeters cubic.</param>
        public double ConvertCubicCentimetersToCubicMeters(
            double centimetersCubic)
        {
            double retVal = 0;

            retVal = centimetersCubic * this.math.ConvertCubicCentimetersToCubicMeters;

            return retVal;
        }

        /// <summary>
        /// Converts the cubic centimeters to cubic millimeters.
        /// </summary>
        /// <returns>The cubic centimeters to cubic millimeters.</returns>
        /// <param name="centimetersCubic">Centimeters cubic.</param>
        public double ConvertCubicCentimetersToCubicMillimeters(
            double centimetersCubic)
        {
            double retVal = 0;

            retVal = centimetersCubic * this.math.CubicCubicCentimeterToCubicMillimeters;

            return retVal;
        }

        /// <summary>
        /// Converts the cubic millimeters to cubic meters.
        /// </summary>
        /// <returns>The cubic millimeters to cubic meters.</returns>
        /// <param name="millimetersCubic">Millimeters cubic.</param>
        public double ConvertCubicMillimetersToCubicMeters(
            double millimetersCubic)
        {
            double retVal = 0;

            retVal = millimetersCubic * this.math.ConvertCubicMillimetersToCubicMeters;

            return retVal;
        }

        /// <summary>
        /// Converts the cubic millimeters to cubic centimeters.
        /// </summary>
        /// <returns>The cubic millimeters to cubic centimeters.</returns>
        /// <param name="millimetersCubic">Millimeters cubic.</param>
        public double ConvertCubicMillimetersToCubicCentimeters(
            double millimetersCubic)
        {
            double retVal = 0; 

            retVal = millimetersCubic * this.math.ConvertCubicCMillimetersToCubicCentimeters;

            return retVal;
        }

        #endregion CONVERT CUBIC METRIC UNITS TO CUBIC METRIC UNITS

        #region CONVERT STANDARD UNITS TO STANDARD UNITS

        /// <summary>
        /// Converts the inches to yards.
        /// </summary>
        /// <returns>The inches to yards.</returns>
        /// <param name="inches"> Return inches.</param>
        public double ConvertInchesToYards(double inches)
        {
            double retVal = 0;
            const double Val = 35;

            if (inches > Val)
            {
                retVal = inches / this.math.ConvertInchesToYards;
            }

            return retVal;
        }

        /// <summary>
        /// Converts the inches to feet.
        /// </summary>
        /// <returns>The inches to feet.</returns>
        /// <param name="inches">Return inches.</param>
        public double ConvertInchesToFeet(double inches)
        {
            double retVal = 0;
            const double Val = 11;

            if (inches > Val)
            {
                retVal = inches / this.math.ConvertInchesToFeet;
            }

            return retVal;
        }

        /// <summary>
        /// Converts the yards to inches.
        /// </summary>
        /// <returns>The yards to inches.</returns>
        /// <param name="yards">Return yards.</param>
        public double ConvertYardsToInches(double yards)
        {
            double retVal = 0;

            retVal = yards * this.math.ConvertInchesToYards;

            return retVal;
        }

        /// <summary>
        /// Converts the yards to feet.
        /// </summary>
        /// <returns>The yards to feet.</returns>
        /// <param name="yards">Return yards.</param>
        public double ConvertYardsToFeet(double yards)
        {
            double retVal = 0;

            retVal = yards * this.math.ConvertFeetToYards;

            return retVal;
        }

        /// <summary>
        /// Converts the feet to inches.
        /// </summary>
        /// <returns>The feet to inches.</returns>
        /// <param name="feet">Return feet.</param>
        public double ConvertFeetToInches(double feet)
        {
            double retVal = 0;

            retVal = feet * this.math.ConvertInchesToFeet;

            return retVal;
        }

        /// <summary>
        /// Converts the feet to yards.
        /// </summary>
        /// <returns>The feet to yards.</returns>
        /// <param name="feet">Converted feet.</param>
        public double ConvertFeetToYards(double feet)
        {
            double retVal = 0;

            retVal = feet / this.math.ConvertFeetToYards;

            return retVal;
        }

        #endregion CONVERT STANDARD UNITS TO STANDARD UNITS

        #region CONVERT METRIC UNITS TO METRIC UNITS

        /// <summary>
        /// Converts the meters to centimeters.
        /// </summary>
        /// <returns>The meters to centimeters.</returns>
        /// <param name="meters">Return meters.</param>
        public double ConvertMetersToCentimeters(double meters)
        {
            double retVal = 0;

            retVal = meters * this.math.ConvertMetersToCentimters;

            return retVal;
        }

        /// <summary>
        /// Converts the meters to millimeters.
        /// </summary>
        /// <returns>The meters to millimeters.</returns>
        /// <param name="meters">Return meters.</param>
        public double ConvertMetersToMillimeters(double meters)
        {
            double retVal = 0;

            retVal = meters * this.math.ConvertMetersToMillimters;

            return retVal;
        }

        /// <summary>
        /// Convertts the centimeters to meters.
        /// </summary>
        /// <returns>The centimeters to meters.</returns>
        /// <param name="centimeters">Return Centimeters.</param>
        public double ConverttCentimetersToMeters(double centimeters)
        {
            double retVal = 0;

            retVal = centimeters * this.math.ConvertCentimetersToMeters;

            return retVal;
        }

        /// <summary>
        /// Converts the centimeters to millimeters.
        /// </summary>
        /// <returns>The centimeters to millimeters.</returns>
        /// <param name="centimeters">Return centimeters.</param>
        public double ConvertCentimetersToMillimeters(double centimeters)
        {
            double retVal = 0;

            retVal = centimeters * this.math.ConvertCentimetersToMillimeters;

            return retVal;
        }

        /// <summary>
        /// Converts the millimeters to meters.
        /// </summary>
        /// <returns>The millimeters to meters.</returns>
        /// <param name="millimeters">Return millimeters.</param>
        public double ConvertMillimetersToMeters(double millimeters)
        {
            double retVal = 0;

            retVal = millimeters * this.math.ConvertMillimetersToMeters;

            return retVal;
        }

        /// <summary>
        /// Converts the millimeters to centimeters.
        /// </summary>
        /// <returns>The millimeters to centimeters.</returns>
        /// <param name="millimeters">Return millimeters.</param>
        public double ConvertMillimetersToCentimeters(double millimeters)
        {
            double retVal = 0;

            retVal = millimeters * this.math.ConvertMillimetersToCentimeters;

            return retVal;
        }

        #endregion CONVERT METRIC UNITS TO METRIC UNITS

        #region CONVERT FROM STANDARD UNITS TO METRIC UNITS

        /// <summary>
        /// Converts the yards to meters.
        /// </summary>
        /// <returns>The yards to meters.</returns>
        /// <param name="yards">Return yards.</param>
        public double ConvertYardsToMeters(double yards)
        {
            double retVal = 0;

            retVal = yards * this.math.ConvertYardsToMeters;

            return retVal;
        }

        /// <summary>
        /// Converts the yards to centimeters.
        /// </summary>
        /// <returns>The yards to centimeters.</returns>
        /// <param name="yards">Return yards.</param>
        public double ConvertYardsToCentimeters(double yards)
        {
            double retVal = 0;

            retVal = yards * this.math.ConvertCubicYardsToCubicCentimeters;

            return retVal;
        }

        /// <summary>
        /// Converts the yards to millimeters.
        /// </summary>
        /// <returns>The yards to millimeters.</returns>
        /// <param name="yards">Return yards.</param>
        public double ConvertYardsToMillimeters(double yards)
        {
            double retVal = 0;

            retVal = yards * this.math.ConvertCubicYardsToCubicMillimeters;

            return retVal;
        }

        /// <summary>
        /// Converts the feet to meters.
        /// </summary>
        /// <returns>The feet to meters.</returns>
        /// <param name="feet">Return feet.</param>
        public double ConvertFeetToMeters(double feet)
        {
            double retVal = 0;

            retVal = feet * this.math.ConvertCubicFeetToCubicMeters;

            return retVal;
        }

        /// <summary>
        /// Converts the feet to centimeters.
        /// </summary>
        /// <returns>The feet to centimeters.</returns>
        /// <param name="feet">Return feet.</param>
        public double ConvertFeetToCentimeters(double feet)
        {
            double retVal = 0;

            retVal = feet * this.math.ConvertCubicFeetToCubicCentimeters;

            return retVal;
        }

        /// <summary>
        /// Converts the feet to millimeters.
        /// </summary>
        /// <returns>The feet to millimeters.</returns>
        /// <param name="feet">return feet.</param>
        public double ConvertFeetToMillimeters(double feet)
        {
            double retVal = 0;

            retVal = feet * this.math.ConvertCubicFeetToCubicMillimeters;

            return retVal;
        }

        /// <summary>
        /// Converts the inches to meters.
        /// </summary>
        /// <returns>The inches to meters.</returns>
        /// <param name="inches">Return inches.</param>
        public double ConvertInchesToMeters(double inches)
        {
            double retVal = 0;

            retVal = inches * this.math.ConvertCubicInchesToCubicMeters;

            return retVal;
        }

        /// <summary>
        /// Converts the inches to centimeters.
        /// </summary>
        /// <returns>The inches to centimeters.</returns>
        /// <param name="inches">Return inches.</param>
        public double ConvertInchesToCentimeters(double inches)
        {
            double retVal = 0;

            retVal = inches * this.math.ConvertCubicInchesToCubicCentimeters;

            return retVal;
        }

        /// <summary>
        /// Converts the inches to millimeters.
        /// </summary>
        /// <returns>The inches to millimeters.</returns>
        /// <param name="inches">Return inches.</param>
        public double ConvertInchesToMillimeters(double inches)
        {
            double retVal = 0;

            retVal = inches * this.math.ConvertCubicInchesToCubicMillimeters;

            return retVal;
        }

        #endregion CONVERT FROM STANDARD UNITS TO METRIC UNITS

        #region CONVERT FROM METRIC UNITS TO STANDARD UNITS

        /// <summary>
        /// Converts the meters to yards.
        /// </summary>
        /// <returns>The meters to yards.</returns>
        /// <param name="meters">Return meters.</param>
        public double ConvertMetersToYards(double meters)
        {
            double retVal = 0;

            retVal = meters * this.math.ConvertMetersToYards;

            return retVal;
        }

        /// <summary>
        /// Converts the meters to feet.
        /// </summary>
        /// <returns>The meters to feet.</returns>
        /// <param name="meters">Return meters.</param>
        public double ConvertMetersToFeet(double meters)
        {
            double retVal = 0;

            retVal = meters * this.math.ConvertMetersToFeet;

            return retVal;
        }

        /// <summary>
        /// Converts the meters to inches.
        /// </summary>
        /// <returns>The meters to inches.</returns>
        /// <param name="meters"> Return meters.</param>
        public double ConvertMetersToInches(double meters)
        {
            double retVal = 0;

            retVal = meters * this.math.ConvertMetersToInches;

            return retVal;
        }

        /// <summary>
        /// Converts the centimeters to yards.
        /// </summary>
        /// <returns>The centimeters to yards.</returns>
        /// <param name="centimeters">Return centimeters.</param>
        public double ConvertCentimetersToYards(double centimeters)
        {
            double retVal = 0;

            retVal = centimeters * this.math.ConvertCentimetersToYards;

            return retVal;
        }

        /// <summary>
        /// Converts the centimeters to feet.
        /// </summary>
        /// <returns>The centimeters to feet.</returns>
        /// <param name="centimeters">return centimeters.</param>
        public double ConvertCentimetersToFeet(double centimeters)
        {
            double retVal = 0;

            retVal = centimeters * this.math.ConvertCentimetersToFeet;

            return retVal;
        }

        /// <summary>
        /// Converts the centimeters to inches.
        /// </summary>
        /// <returns>The centimeters to inches.</returns>
        /// <param name="centimeters">Return centimeters.</param>
        public double ConvertCentimetersToInches(double centimeters)
        {
            double retVal = 0;

            retVal = centimeters * this.math.ConvertCentimetersToInches;

            return retVal;
        }

        /// <summary>
        /// Converts the millimeters to yards.
        /// </summary>
        /// <returns>The millimeters to yards.</returns>
        /// <param name="millimeters">Return millimeters.</param>
        public double ConvertMillimetersToYards(double millimeters)
        {
            double retVal = 0;

            retVal = millimeters * this.math.ConvertMillimetersToYards;

            return retVal;
        }

        /// <summary>
        /// Converts the millimeters to feet.
        /// </summary>
        /// <returns>The millimeters to feet.</returns>
        /// <param name="millimeters">Return millimeters.</param>
        public double ConvertMillimetersToFeet(double millimeters)
        {
            double retVal = 0;

            retVal = millimeters * this.math.ConvertMillimetersToFeet;

            return retVal;
        }

        /// <summary>
        /// Converts the millimeters to inches.
        /// </summary>
        /// <returns>The millimeters to inches.</returns>
        /// <param name="millimeters">Return millimeters.</param>
        public double ConvertMillimetersToInches(double millimeters)
        {
            double retVal = 0;

            retVal = millimeters * this.math.ConvertMillimetersToInches;

            return retVal;
        }

        #endregion CONVERT FROM METRIC UNITS TO STANDARD UNITS

        #region CONVERT STRINGS TO NUMERIC VALUE

        /// <summary>
        /// Converts the string to double.
        /// </summary>
        /// <returns>The string to double.</returns>
        /// <param name="value">Return double.</param>
        public double ConvertStringToDouble(string value)
        {
            double retVal = 0;
            this.methodName = "public double " +
            "ConvertStringToDouble(string value)";

            try
            {
                retVal = Convert.ToDouble(value);

                return retVal;
            }
            catch (FormatException ex)
            {
                this.errMsg = "Encountered error converting numeric string " +
                "to integer value.";
                this.myMsg.BuildErrorString(
                    MyClassName, 
                    this.methodName, 
                    this.errMsg,
                    ex.ToString());   

                // Error so return false.
                return retVal;
            }
            catch (OverflowException ex)
            {
                this.errMsg = "Encountered error converting numeric string " +
                "to integer value.";
                this.myMsg.BuildErrorString(
                    MyClassName, 
                    this.methodName, 
                    this.errMsg,
                    ex.ToString());

                // Error so return false.
                return retVal;
            }
        }

        #endregion CONVERT STRINGS TO NUMERIC VALUE
    }
} 