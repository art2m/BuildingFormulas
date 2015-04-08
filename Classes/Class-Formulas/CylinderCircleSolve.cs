
// 
//  CylinderCircleSolve.cs
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


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuildingFormulas
{
    class CylinderCircleSolvecs
    {

        private static double pi = 3.14159265;

#region PROPERTIES VALUES FOR DIAMETER, HEIGHT

        private static int diameterYd = 0;
        public static int CylinderDiameterInYards
        {
            get { return diameterYd; }
            set { diameterYd = value; }
        }

        private static int heightYd = 0;
        public static int CylinderHeightInYards
        {
            get { return heightYd; }
            set { heightYd = value; }
        }


        private static int diameterFt = 0;
        public static int CylinderDiameterInFeet
        {
            get { return diameterFt; }
            set { diameterFt = value; }
        }

        private static int heightFt = 0;
        public static int CylinderHeightInFeet
        {
            get { return heightFt; }
            set { heightFt = value; }
        }

        private static int diameterIn = 0;
        public static int CylinderDiameterInInches
        {
            get { return diameterIn; }
            set { diameterIn = value; }
        }


        private static int heightIn = 0;
        public static int CylinderHeightInInches
        {
            get { return heightIn; }
            set { heightIn = value; }
        }


      

#endregion End PROPERTIES VALUES FOR DIAMETER, HEIGHT



#region PROPERTIES TOTAL INCHES IN DIAMETER, HEIGHT

        private static int diameterTotalInches;
        public static void GetTheDiameterTotalInches()
        {
            int inchesYd = 0;
            int InchesFt = 0;

            inchesYd = CylinderDiameterInYards * 36;
            InchesFt = CylinderDiameterInFeet * 12;
            diameterTotalInches = inchesYd + InchesFt + CylinderDiameterInInches;

        } //End public static void GetTheDiameterTotalInches()


        private static int heightTotalInches;
        public static void GetTheHeightTotalInches()
        {
            int inchesYd = 0;
            int inchesFt = 0;

            inchesYd = CylinderHeightInYards * 36;
            inchesFt = CylinderHeightInFeet * 12;
            heightTotalInches = inchesYd + inchesFt + CylinderHeightInInches;

        } //End public static void GetTheHeightTotalInches()       

#endregion End PROPERTIES VALUES FOR DIAMETER, HEIGHT



#region PROPERTIES TOTAL CUBIC INCHES, FEET, YARDS IN CYLINDER, CIRCLE

        private static double cubicInches;
        public static double CubicInchesInCubicCylinder
        {
            get { return cubicInches; }
            set { cubicInches = value; }
        }

        private static double cubicFeet;
        public static double CubicFeetInCubicCylinder
        {
            get { return cubicFeet; }
            set { cubicFeet = value; }
        }

        private static double cubicYards;
        public static double CubicYardsInCubicCylinder
        {
            get { return cubicYards; }
            set { cubicYards = value; }
        }

#endregion End PROPERTIES TOTAL CUBIC INCHES, FEET, YARDS IN CYLINDER, CIRCLE



#region METHODS SOLVE FOR CUBIC YARDS, FEET, INCHES IN CYLINDER, CIRCLE

        public static double SolveForCubicAreaYards()
        {
            Conversions conv = new Conversions();

            double retVal = 0;
            double cubicIn = 0;
            double cubicYd = 0;
            double radiusTotalInches;
            
            radiusTotalInches = diameterYd / 2;

            cubicIn = pi * diameterTotalInches * diameterTotalInches * heightTotalInches;

            cubicYd = conv.ConvertCubicInchesToCubicYards(cubicIn);

            retVal = Math.Round(cubicYd, 2);

            CubicYardsInCubicCylinder = retVal;

            return retVal;
        } //End public static double SolveForCubicAreaYards()


        public static double SolveForCubicAreaFeet()
        {
            Conversions conv = new Conversions();

            double retVal = 0;
            double cubicFt = 0;
            double cubicIn = 0;

            cubicIn = diameterTotalInches * heightTotalInches * widthTotalInches;

            cubicFt = conv.ConvertCubicInchesToCubicFeet(cubicIn);
            retVal = Math.Round(cubicFt, 2);

            CubicFeetInCubicCylinder = retVal;


            return retVal;
        } //End public static  double SolveForCubicAreaFeet()


        public static double SolveForCubicAreaInches()
        {
            double retVal = 0;

            retVal = diameterTotalInches * heightTotalInches * widthTotalInches;

            CubicInchesInCubicCylinder = retVal;
            return retVal;

        } //End public static  double SolveForCubicAreaInches() 

#endregion End MEHTOD SOLVE FOR CUBIC YARDS, FEET, INCHES IN CYLINDER, CIRCLE


    } //End class CylinderCircleSolve.cs

} //End Namespace BuildingFormulas
