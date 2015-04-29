//  ValidateData.cs
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
    using System.Text;

    /// <summary>
    /// Validate data.
    /// </summary>
    public class ValidateData
    {
        /// <summary>
        /// The name of the class.
        /// </summary>
        private const string ThisClassName = "ValidateData";

        /// <summary>
        /// My message.
        /// </summary>
        private MyMessages myMsg = new MyMessages();

        /// <summary>
        /// Initializes a new instance of the <see cref=
        /// "BuildingFormulas.ValidateData"/> class.
        /// </summary>
        public ValidateData()
        {
        }

        /// <summary>
        /// Validates the total sum is greater then zero.
        /// </summary>
        /// <returns><c>true</c>, if total sum is greater then 
        /// zero was validated, <c>false</c> 
        /// otherwise.</returns>
        /// <param name="totalVal">Total value.</param>
        /// <param name="typeUnits">The typeUnits contains width
        /// height length etc...</param>
        public bool ValidateTotalSumIsGreaterThenZero(
            double totalVal, 
            string typeUnits)
        {
            bool retVal = false;
            string errMsg = null;
            const string MethodName = 
                "public bool ValidateTotalSumIsGreaterThenZero(" +
                "double totalVal, string Dimension)";
            if (totalVal <= 0)
            {
                errMsg = "One of the " + typeUnits + " values must be " +
                "greater then zero.";
                this.myMsg.BuildErrorString(
                    ThisClassName, 
                    MethodName, 
                    errMsg, 
                    string.Empty);

                return retVal;
            }

            return retVal = true;
        }

        /// <summary>
        /// Validates the text boxes not empty.
        /// </summary>
        /// <returns><c>true</c>, if text boxes not 
        /// empty was validated, <c>false</c> otherwise.</returns>
        /// <param name="values">The values array of strings.</param>
        /// <param name="cnt">The count of items in array.</param>
        public bool ValidateUserDataNotNullNotEmpty(string[] values, int cnt)
        {
            bool retVal = true;
            const string MethodName = "public bool " +
                                      "ValidateUserDataNotNullNotEmpty(" +
                                      "string[] values, int cnt)";

            string errMsg = 
                "All data entry boxes must have a numeric value. " +
                Environment.NewLine + "Enter 0 for no data.";
               
            try
            {
                for (int i = 0; i < cnt; i++)
                {
                    if (string.IsNullOrEmpty(values[i]))
                    {
                        this.myMsg.BuildErrorString(
                            ThisClassName, 
                            MethodName,
                            errMsg, 
                            string.Empty);

                        retVal = false;
                        break;
                    }
                    else if (string.IsNullOrWhiteSpace(values[i]))
                    {
                        this.myMsg.BuildErrorString(
                            ThisClassName, 
                            MethodName,
                            errMsg, 
                            string.Empty);
                        retVal = false;  
                        break;
                    }
                    else
                    {
                        retVal = true;
                    }
                }
                        
                return retVal;
            }
            catch (IndexOutOfRangeException)
            {
                this.myMsg.BuildErrorString(
                    ThisClassName, 
                    MethodName, 
                    errMsg,
                    string.Empty);  
                return retVal = false;
            }
        }

        /// <summary>
        /// Validates the text boxes have numeric value.
        /// </summary>
        /// <returns><c>true</c>, if text boxes have 
        /// numeric value was validated, 
        /// <c>false</c> otherwise.</returns>
        /// <param name="values">The values array of strings.</param>
        /// <param name="cnt">The count of items in array.</param>
        public bool ValidateUserDataHasNumericValue(string[] values, int cnt)
        {
            bool retVal = true;
            int num = 0;
            string data = null;
            const string MethodName = "public bool " +
                                      "ValidateUserDataHasNumericValue(" +
                                      "string[] values, int cnt)";

            string errMsg = 
                "All data entry boxes must have a numeric value. " +
                Environment.NewLine + "Enter 0 for no data.";
           
            try
            {
                for (int i = 0; i < cnt; i++)
                {
                    data = values[i];
                    retVal = int.TryParse(data, out num);
                    if (!retVal)
                    {
                        this.myMsg.BuildErrorString(
                            ThisClassName, 
                            MethodName, 
                            errMsg, 
                            string.Empty);
                        retVal = false;
                        break;
                    }
                    else
                    {
                        retVal = true;
                    }
                }

                return retVal;
            }
            catch (IndexOutOfRangeException)
            {
                this.myMsg.BuildErrorString(
                    ThisClassName, 
                    MethodName, 
                    errMsg,
                    string.Empty);
                return retVal = false;
            }                    
        }

        /// <summary>
        /// Validates the text boxes have value greater then zero.
        /// </summary>
        /// <returns><c>true</c>, if text boxes have 
        /// value greater then zero was validated, 
        /// <c>false</c> otherwise.</returns>
        /// <param name="values">The values array of strings.</param>
        /// <param name="cnt">The count of items in the array.</param>
        public bool ValidateUserDataHasValueGreaterThenZero(
            string[] values, int cnt)
        {
            bool retVal = true;
            string data = null;
            int num = 0;
            const string MethodName = "public bool " +
                                      "ValidateUserDataHasValue" +
                                      "GreaterThenZero(" +
                                      "string[] values, int cnt)";
            string errMsg = 
                "At least one dimension box in each row must have a" +
                Environment.NewLine + "value greater then zero.";

            for (int i = 0; i < cnt; i++)
            {
                data = values[i];
                retVal = int.TryParse(data, out num);
                if (!retVal)
                {
                    this.myMsg.BuildErrorString(
                        ThisClassName, 
                        MethodName, 
                        errMsg, 
                        string.Empty);
                    retVal = false;
                    break;
                }

                if (num < 1)
                {
                    this.myMsg.BuildErrorString(
                        ThisClassName, 
                        MethodName, 
                        errMsg, 
                        string.Empty);
                    retVal = false;
                    break;
                }
                else
                {
                    retVal = true;
                }
            }

            return retVal;
        }
    }
}