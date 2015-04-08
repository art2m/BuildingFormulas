
// 
//  ValidateCylinderCircle.cs
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
    class ValidateCylinderCircle
    {
        MyMessages myMsg = new MyMessages();
        string errMsg = null;


#region VALIDATE TEXT BOX HAS STRING VALUE

        /// <summary>
        /// Method -- public bool IsThereValueInWidthYards()
        /// 
        /// Check to see that the user has entered a value for
        /// yards. 
        /// 
        /// return false if no value entered true if ok.
        /// 
        /// </summary>
        /// <returns></returns>
        public bool IsThereValueInWidthYards()
        {
            bool retVal = true;

            if (String.IsNullOrEmpty(RecDat.WidthYardValue))
            {
                errMsg = "You must enter a value into the width " +
                    Environment.NewLine +
                    "yards entry box. " + Environment.NewLine +
                    "Enter whole numbers no decimals. " +
                    Environment.NewLine +
                    "Enter zero for no value.";
                myMsg.ShowErrMessage(errMsg);
                retVal = false;
            }

            return retVal;
        } //End public bool IsThereValueInWidthYards()


        /// <summary>
        /// Method -- public bool IsThereValueInWidthFeet()
        /// 
        /// Check to see that the user has entered a value for
        /// feet. 
        /// 
        /// return false if no value entered true if ok.
        /// 
        /// </summary>
        /// <returns></returns>
        public bool IsThereValueInWidthFeet()
        {
            bool retVal = true;

            if (String.IsNullOrEmpty(RecDat.WidthFeetValue))
            {
                errMsg = "You must enter a value into the width " +
                    Environment.NewLine +
                "feet entry box. " + Environment.NewLine +
                "Enter whole numbers no decimals. " + Environment.NewLine +
                "Enter zero for no value.";
                myMsg.ShowErrMessage(errMsg);
                retVal = false;
            }

            return retVal;
        } //End public bool IsThereValueInWidthFeet()


        /// <summary>
        /// Method -- public bool IsThereValueInWidthInches()
        /// 
        /// Check to see that the user has entered a value for
        /// inches. 
        /// 
        /// return false if no value entered true if ok.
        /// 
        /// </summary>
        /// <returns></returns>
        public bool IsThereValueInWidthInches()
        {
            bool retVal = true;

            if (String.IsNullOrEmpty(RecDat.WidthInchesValue))
            {
                errMsg = "You must enter a value into the width " +
                    Environment.NewLine + "inches entry box. " +
                    Environment.NewLine + "Enter whole numbers no decimals. " +
                    Environment.NewLine + "Enter zero for no value.";
                myMsg.ShowErrMessage(errMsg);
                retVal = false;
            }

            return retVal;
        } //End public bool IsThereValueInWidthInches()


        /// <summary>
        /// Method -- public bool IsThereValueInDepthYards()
        /// 
        /// Check to see that the user has entered a value for
        /// yards. 
        /// 
        /// return false if no value entered true if ok.
        /// 
        /// </summary>
        /// <returns></returns>
        public bool IsThereValueInDepthYards()
        {
            bool retVal = true;

            if (String.IsNullOrEmpty(RecDat.DepthYardValue))
            {
                errMsg = "You must enter a value into the depth " +
                    Environment.NewLine + "yards entry box. " +
                    Environment.NewLine + "Enter whole numbers no decimals. " +
                    Environment.NewLine + "Enter zero for no value.";
                myMsg.ShowErrMessage(errMsg);
                retVal = false;
            }

            return retVal;
        } //End public bool IsThereValueInDepthYards()


        /// <summary>
        /// Method -- public bool IsThereValueInDepthFeet()
        /// 
        ///  Check to see that the user has entered a value for
        /// feet. 
        /// 
        /// return false if no value entered true if ok.
        /// 
        /// </summary>
        /// <returns></returns>
        public bool IsThereValueInDepthFeet()
        {
            bool retVal = true;

            if (String.IsNullOrEmpty(RecDat.DepthFeetValue))
            {
                errMsg = "You must enter a value into the depth " +
                    Environment.NewLine + "feet entry box. " +
                    Environment.NewLine + "Enter whole numbers no decimals. " +
                    Environment.NewLine + "Enter zero for no value.";
                myMsg.ShowErrMessage(errMsg);
                retVal = false;
            }

            return retVal;
        } //End public bool IsThereValueInDepthFeet()


        /// <summary>
        /// Method -- public bool IsThereValueInDepthInches()
        /// 
        /// Check to see that the user has entered a value for
        /// inches. 
        /// 
        /// return false if no value entered true if ok.
        /// 
        /// </summary>
        /// <returns></returns>
        public bool IsThereValueInDepthInches()
        {
            bool retVal = true;

            if (String.IsNullOrEmpty(RecDat.DepthInchesValue))
            {
                errMsg = "You must enter a value into the depth " +
                    Environment.NewLine + "inches entry box. " +
                    Environment.NewLine + "Enter whole numbers no decimals. " +
                    Environment.NewLine + "Enter zero for no value.";
                myMsg.ShowErrMessage(errMsg);
                retVal = false;
            }

            return retVal;
        } //End public bool IsThereValueInDepthInches()


        /// <summary>
        /// Method -- public bool IsThereValueInLengthYards()
        /// 
        /// Check to see that the user has entered a value for
        /// yards. 
        /// 
        /// return false if no value entered true if ok.
        /// 
        /// </summary>
        /// <returns></returns>
        public bool IsThereValueInLengthYards()
        {
            bool retVal = true;

            if (String.IsNullOrEmpty(RecDat.LengthYardValue))
            {
                errMsg = "You must enter a value into the length " +
                    Environment.NewLine + "yards entry box. " +
                    Environment.NewLine + "Enter whole numbers no decimals. " +
                    Environment.NewLine + "Enter zero for no value.";
                myMsg.ShowErrMessage(errMsg);
                retVal = false;
            }

            return retVal;
        } //End public bool IsThereValueInLengthYards()


        /// <summary>
        /// Method -- public bool IsThereValueInLengthFeet()
        /// 
        /// Check to see that the user has entered a value for
        /// feet. 
        /// 
        /// return false if no value entered true if ok.
        /// 
        /// </summary>
        /// <returns></returns>
        public bool IsThereValueInLengthFeet()
        {
            bool retVal = true;

            if (String.IsNullOrEmpty(RecDat.LengthFeetValue))
            {
                errMsg = "You must enter a value into the length " +
                    Environment.NewLine + "feet entry box. " +
                    Environment.NewLine + "Enter whole numbers no decimals. " +
                    Environment.NewLine + "Enter zero for no value.";
                myMsg.ShowErrMessage(errMsg);
                retVal = false;
            }

            return retVal;
        } ///End public bool IsThereValueInLengthFeet()



        /// <summary>
        /// Method -- public bool IsThereValueInLengthFeet()
        /// 
        /// Check to see that the user has entered a value for
        /// Inches. 
        /// 
        /// return false if no value entered true if ok.
        /// 
        /// </summary>
        /// <returns></returns>
        public bool IsThereValueInLengthInches()
        {
            bool retVal = true;

            if (String.IsNullOrEmpty(RecDat.LengthInchesValue))
            {
                errMsg = "You must enter a value into the length " +
                    Environment.NewLine + "inches entry box. " +
                    Environment.NewLine + "Enter whole numbers no decimals. " +
                    Environment.NewLine + "Enter zero for no value. ";
                myMsg.ShowErrMessage(errMsg);
                retVal = false;
            }

            return retVal;
        } //End public bool IsThereValueInLengthInches()


#endregion END VALIDATE TEXT BOX HAS STRING VALUE



#region CHECK THAT STRING IS NUMERIC VALUE

        /// <summary>
        /// Method -- public bool CheckWidthYardsValueIsIntegerNumeric()
        ///           
        /// Check that the user has entered valid numeric values into
        /// the width yards entry box.
        /// 
        /// </summary>
        /// <returns></returns>
        public bool CheckWidthYardsValueIsIntegerNumeric()
        {
            bool retVal = true;
            int num = 0;


            retVal = Int32.TryParse(RecDat.WidthYardValue, out num);

            if (!retVal)
            {
                errMsg = "You must enter numeric values into the width " +
                    Environment.NewLine + "yards entry box. Enter only whole " +
                    Environment.NewLine + "numbers no decimals.";
                myMsg.ShowErrMessage(errMsg);
                retVal = false;
            }

            return retVal;
        } //End public bool CheckWidthYardsValueIsIntegerNumeric()


        /// <summary>
        /// -Method -- public bool CheckWidthFeetValueIsIntegerNumeric()
        /// 
        /// Check that the user has entered valid numeric values into
        /// the width feet entry box.
        /// 
        /// </summary>
        /// <returns></returns>
        public bool CheckWidthFeetValueIsIntegerNumeric()
        {
            bool retVal = true;
            int num = 0;

            retVal = Int32.TryParse(RecDat.WidthFeetValue, out num);

            if (!retVal)
            {
                errMsg = "You must enter numeric values into the width " +
                    Environment.NewLine + "feet entry box. Enter only whole " +
                    Environment.NewLine + "numbers no decimals.";
                myMsg.ShowErrMessage(errMsg);
                retVal = false;
            }

            return retVal;
        } //End public bool CheckWidthFeetValueIsIntegerNumeric()


        /// <summary>
        /// Method -- public bool CheckWidthInchesValueIsIntegerNumeric()
        /// 
        /// Check that the user has entered valid numeric values into
        /// the width inches entry box.
        /// 
        /// </summary>
        /// <returns></returns>
        public bool CheckWidthInchesValueIsIntegerNumeric()
        {
            bool retVal = true;
            int num = 0;

            retVal = Int32.TryParse(RecDat.WidthInchesValue, out num);

            if (!retVal)
            {
                errMsg = "You must enter numeric values into the width " +
                    Environment.NewLine + "inches entry box. Enter only " +
                    Environment.NewLine + " whole numbers no decimals.";
                myMsg.ShowErrMessage(errMsg);
                retVal = false;
            }

            return retVal;
        } //End public bool CheckWidthInchesValueIsIntegerNumeric()


        /// <summary>
        /// Method -- public bool CheckDepthYardsValueIsIntegerNumeric()
        /// 
        /// Check that the user has entered valid numeric values into
        /// the depth yards entry box.
        /// 
        /// </summary>
        /// <returns></returns>
        public bool CheckDepthYardsValueIsIntegerNumeric()
        {
            bool retVal = true;
            int num = 0;

            retVal = Int32.TryParse(RecDat.DepthYardValue, out num);

            if (!retVal)
            {
                errMsg = "You must enter numeric values into the depth " +
                    Environment.NewLine + "yards entry box. Enter only whole " +
                    Environment.NewLine + "numbers no decimals.";
                myMsg.ShowErrMessage(errMsg);
                retVal = false;
            }

            return retVal;
        } //End public bool CheckDepthYardsValueIsIntegerNumeric()



        /// <summary>
        /// Method -- public bool CheckDepthFeetValueIsIntegerNumeric()
        /// 
        /// Check that the user has entered valid numeric values into
        /// the depth feet entry box.
        /// 
        /// </summary>
        /// <returns></returns>
        public bool CheckDepthFeetValueIsIntegerNumeric()
        {
            bool retVal = true;
            int num = 0;

            retVal = Int32.TryParse(RecDat.DepthFeetValue, out num);

            if (!retVal)
            {
                errMsg = "You must enter numeric values into the depth " +
                    Environment.NewLine + "feet entry box. Enter only whole " +
                    Environment.NewLine + "numbers no decimals.";
                myMsg.ShowErrMessage(errMsg);
                retVal = false;
            }

            return retVal;
        } //End public bool CheckDepthFeetValueIsIntegerNumeric()



        /// <summary>
        /// Method -- public bool CheckDepthInchesIsIntegerNumeric()
        /// 
        /// Check that the user has entered valid numeric values into
        /// the depth inches entry box.
        /// 
        /// </summary>
        /// <returns></returns>
        public bool CheckDepthInchesIsIntegerNumeric()
        {
            bool retVal = true;
            int num = 0;

            retVal = Int32.TryParse(RecDat.DepthInchesValue, out num);

            if (!retVal)
            {
                errMsg = "You must enter numeric values into the depth " +
                    Environment.NewLine + "iches entry box. Enter only whole " +
                    Environment.NewLine + "numbers no decimals.";
                myMsg.ShowErrMessage(errMsg);
                retVal = false;
            }

            return retVal;

        } //End public bool CheckDepthInchesIsIntegerNumeric()


        /// <summary>
        /// Method -- public bool CheckLengthYardsIsIntegerNumeric()
        /// 
        /// Check that the user has entered valid numeric values into
        /// the length yards entry box.
        /// 
        /// </summary>
        /// <returns></returns>
        public bool CheckLengthYardsIsIntegerNumeric()
        {
            bool retVal = true;
            int num = 0;

            retVal = Int32.TryParse(RecDat.LengthYardValue, out num);

            if (!retVal)
            {
                errMsg = "You must enter numeric values into the length " +
                    Environment.NewLine + "yards entry box. Enter only whole " +
                    Environment.NewLine + "numbers no decimals.";
                myMsg.ShowErrMessage(errMsg);
                retVal = false;
            }

            return retVal;
        } //End public bool CheckLengthYardsIsIntegerNumeric()


        /// <summary>
        /// Method -- public bool CheckLengthFeetIsIntegerNumeric()
        /// 
        /// Check that the user has entered valid numeric values into
        /// the length feet entry box.
        /// 
        /// </summary>
        /// <returns></returns>
        public bool CheckLengthFeetIsIntegerNumeric()
        {
            bool retVal = true;
            int num = 0;

            retVal = Int32.TryParse(RecDat.LengthFeetValue, out num);

            if (!retVal)
            {
                errMsg = "You must enter numeric values into the length " +
                    Environment.NewLine + "feet entry box. Enter only whole " +
                    Environment.NewLine + "numbers no decimals.";
                myMsg.ShowErrMessage(errMsg);
                retVal = false;
            }

            return retVal;
        } //End public bool CheckLengthFeetIsIntegerNumeric()


        /// <summary>
        /// Method -- public bool CheckLengthInchesIsIntegerNumeric()
        /// 
        /// Check that the user has entered valid numeric values into
        /// the length inches entry box.
        /// 
        /// </summary>
        /// <returns></returns>
        public bool CheckLengthInchesIsIntegerNumeric()
        {
            bool retVal = true;
            int num = 0;

            retVal = Int32.TryParse(RecDat.LengthInchesValue, out num);

            if (!retVal)
            {
                errMsg = "You must enter numeric values into the length " +
                    Environment.NewLine + "inches entry box. Enter only " +
                    Environment.NewLine + "whole numbers no decimals.";
                myMsg.ShowErrMessage(errMsg);
                retVal = false;
            }

            return retVal;

        } //End public bool CheckLengthInchesIsIntegerNumeric()


#endregion End CHECK THAT STRING IS NUMERIC VALUE



#region VALIDATE VALUE GREATER THEN ZERO

        /// <summary>
        /// Method -- public bool CheckWidthYardsValueGreaterThenZero(int val)
        /// 
        /// Check that a value greater then zero is stored before using it 
        /// to find the cubic area of a rectangle or square.
        /// 
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public bool CheckWidthYardsValueGreaterThenZero(int val)
        {
            bool retVal = true;

            if (val == 0 | val < 0)
            {
                retVal = false;
            }

            return retVal;
        } //End  public bool CheckWidthYardsValueGreaterThenZero(int val)


        /// <summary>
        /// Method -- public bool CheckWidthFeetValueGreaterThenZero()
        /// 
        ///  Check that a value greater then zero is stored before using it 
        /// to find the cubic area of a rectangle or square.
        /// 
        /// </summary>
        /// <returns></returns>
        public bool CheckWidthFeetValueGreaterThenZero(int val)
        {
            bool retVal = true;

            if (val == 0 | val < 0)
            {
                retVal = false;
            }

            return retVal;

        } //End public bool CheckWidthFeetValueGreaterThenZero()


        /// <summary>
        /// Method -- public bool CheckWidthInchesValueGreaterThenZero()
        /// 
        /// Check that a value greater then zero is stored before using it 
        /// to find the cubic area of a rectangle or square.
        /// 
        /// </summary>
        /// <returns></returns>
        public bool CheckWidthInchesValueGreaterThenZero(int val)
        {
            bool retVal = true;
            if (val == 0 | val < 0)
            {
                retVal = false;
            }
            return retVal;
        } //End public bool CheckWidthInchesValueGreaterThenZero()


        /// <summary>
        /// Method -- public bool CheckDepthYardsValueGreaterThenZero()
        /// 
        /// Check that a value greater then zero is stored before using it 
        /// to find the cubic area of a rectangle or square.
        /// 
        /// </summary>
        /// <returns></returns>
        public bool CheckDepthYardsValueGreaterThenZero(int val)
        {
            bool retVal = true;
            if (val == 0 | val < 0)
            {
                retVal = false;
            }
            return retVal;
        } //End public bool CheckDepthYardsValueGreaterThenZero()


        /// <summary>
        /// Method -- public bool CheckDepthFeetValueGreaterThenZero()
        /// 
        /// Check that a value greater then zero is stored before using it 
        /// to find the cubic area of a rectangle or square.
        /// 
        /// </summary>
        /// <returns></returns>
        public bool CheckDepthFeetValueGreaterThenZero(int val)
        {
            bool retVal = true;
            if (val == 0 | val < 0)
            {
                retVal = false;
            }
            return retVal;
        } //End public bool CheckDepthFeetValueGreaterThenZero()


        /// <summary>
        /// Method -- public bool CheckDepthInchesValueGreaterThenZero()
        /// 
        /// Check that a value greater then zero is stored before using it 
        /// to find the cubic area of a rectangle or square.
        /// 
        /// </summary>
        /// <returns></returns>
        public bool CheckDepthInchesValueGreaterThenZero(int val)
        {
            bool retVal = true;
            if (val == 0 | val < 0)
            {
                retVal = false;
            }
            return retVal;
        } //End public bool CheckDepthInchesValueGreaterThenZero()


        /// <summary>
        /// Method -- public bool CheckLengthYardsValueGreaterThenZero()
        /// 
        /// Check that a value greater then zero is stored before using it 
        /// to find the cubic area of a rectangle or square.
        /// 
        /// </summary>
        /// <returns></returns>
        public bool CheckLengthYardsValueGreaterThenZero(int val)
        {
            bool retVal = true;
            if (val == 0 | val < 0)
            {
                retVal = false;
            }
            return retVal;
        } //End public bool CheckLengthYardsValueGreaterThenZero()

        /// <summary>
        /// Method -- public bool CheckLengthFeetValueGreaterThenZero()
        /// 
        /// Check that a value greater then zero is stored before using it 
        /// to find the cubic area of a rectangle or square.
        /// 
        /// </summary>
        /// <returns></returns>
        public bool CheckLengthFeetValueGreaterThenZero(int val)
        {
            bool retVal = true;
            if (val == 0 | val < 0)
            {
                retVal = false;
            }
            return retVal;
        } //End public bool CheckLengthFeetValueGreaterThenZero()

        /// <summary>
        /// Method -- public bool CheckLengthInchesValueGreaterThenZero()
        /// 
        ///  Check that a value greater then zero is stored before using it 
        /// to find the cubic area of a rectangle or square.
        /// 
        /// </summary>
        /// <returns></returns>
        public bool CheckLengthInchesValueGreaterThenZero(int val)
        {
            bool retVal = true;
            if (val == 0 | val < 0)
            {
                retVal = false;
            }
            return retVal;
        } //End public bool CheckLengthInchesValueGreaterThenZero()


        /// <summary>
        /// Method -- public bool 
        ///             CheckWidthYardsFeetInchesValueGreaterThenZero()
        /// 
        /// Width must have at least one value for yards, feet or inches
        /// that is greater then zero. Or cubic area can not be found.
        /// 
        /// </summary>
        /// <returns></returns>
        public bool CheckWidthYardsFeetInchesValueGreaterThenZero()
        {
            bool retVal = false;
            int yard = RectangleSquareSolve.RectangleWidthInYards;
            int feet = RectangleSquareSolve.RectangleWidthInFeet;
            int inches = RectangleSquareSolve.RectangleWidthInInches;

            if (yard > 0)
            {
                retVal = true;
                return retVal;
            }
            else if (feet > 0)
            {
                retVal = true;
                return retVal;
            }
            else if (inches > 0)
            {
                retVal = true;
                return retVal;
            }

            //No value greater then zero. One has to be in 
            //order to figure cubic area.
            errMsg = "At least one of the values for width yards, " +
                    Environment.NewLine + "feet or inches must have a value " +
                    Environment.NewLine + "greater then zero.";
            myMsg.ShowErrMessage(errMsg);
            return retVal;
        } //End  public bool CheckWidthYardsFeetInchesValueGreaterThenZero()


        /// <summary>
        /// Method -- public bool 
        ///             CheckDepthYardsFeetInchesValueGreaterThenZero()
        /// 
        /// Depth must have at least one value for yards, feet or inches
        /// that is greater then zero. Or cubic area can not be found.
        /// 
        /// </summary>
        /// <returns></returns>
        public bool CheckDepthYardsFeetInchesValueGreaterThenZero()
        {
            bool retVal = true;

            int yard = RectangleSquareSolve.RectangleDepthInYards;
            int feet = RectangleSquareSolve.RectangleDepthInFeet;
            int inches = RectangleSquareSolve.RectangleDepthInInches;

            if (yard > 0)
            {
                retVal = true;
                return retVal;
            }
            else if (feet > 0)
            {
                retVal = true;
                return retVal;
            }
            else if (inches > 0)
            {
                retVal = true;
                return retVal;
            }

            //No value greater then zero. One has to be in 
            //order to figure cubic area.
            errMsg = "At least one of the values for depth yards, " +
                      Environment.NewLine + "feet or inches must have a " +
                      Environment.NewLine + "value greater then zero.";
            myMsg.ShowErrMessage(errMsg);
            return retVal;

        } //End public bool CheckDepthYardsFeetInchesValueGreaterThenZero()


        /// <summary>
        /// Method -- public bool 
        ///         CheckLengthYardsFeetInchesValueGreaterThenZero()
        /// 
        /// Length must have at least one value for yards, feet or inches
        /// that is greater then zero. Or cubic area can not be found.
        /// 
        /// </summary>
        /// <returns></returns>
        public bool CheckLengthYardsFeetInchesValueGreaterThenZero()
        {
            bool retVal = true;

            int yard = RectangleSquareSolve.RectangleLengthInYards;
            int feet = RectangleSquareSolve.RectangleLengthInFeet;
            int inches = RectangleSquareSolve.RectangleLengthInInches;

            if (yard > 0)
            {
                retVal = true;
                return retVal;
            }
            else if (feet > 0)
            {
                retVal = true;
                return retVal;
            }
            else if (inches > 0)
            {
                retVal = true;
                return retVal;
            }

            //No value greater then zero. One has to be in 
            //order to figure cubic area.
            errMsg = "At least one of the values for length yards, " +
                     Environment.NewLine + "feet or inches must have a " +
                     Environment.NewLine + "value greater then zero.";
            myMsg.ShowErrMessage(errMsg);
            return retVal;
        } //End public bool CheckLengthYardsFeetInchesValueGreaterThenZero()


#endregion End VALIDATE VALUE GREATER THEN ZERO


    } //End Class ValidateCylinderCircle.cs

} //End Namespace BuildingFormulas
