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

    /// <summary>
    /// Validate data.
    /// </summary>
    public class ValidateData
    {
        /// <summary>
        /// My message.
        /// </summary>
        private MyMessages myMsg = new MyMessages();

        /// <summary>
        /// The name of the class.
        /// </summary>
        private const string ThisClassName = "ValidateData";

        private string errMsg = null;

        /// <summary>
        /// Initializes a new instance of the <see cref=
        /// "BuildingFormulas.ValidateData"/> class.
        /// </summary>
        public ValidateData()
        {

        }

        /// <summary>
        /// Validates data exists or not.
        /// CheckTo see if data exists or not. Can be
        /// null as not all fields are needed for specific
        /// data.
        /// </summary>
        /// <returns><c>true</c>, if data in text box 
        /// was validated, 
        /// <c>false</c> otherwise return false.</returns>
        /// <param name="data">String to be validated data.</param>
        public bool ValidateDataExists(string data)
        {
            bool retVal = false;
            const string MethodName = "public bool ValidateDataExists(" +
                                      " string data)";

            errMsg = "All data entry boxes must have a numeric value.\n " +
            "Enter 0 for no data.";

            if (string.IsNullOrEmpty(data))
            {
                myMsg.BuildErrorString(ThisClassName, MethodName, errMsg, "");

                return retVal;
            }
            else if (string.IsNullOrWhiteSpace(data))
            {
                myMsg.BuildErrorString(ThisClassName, MethodName, errMsg, "");
                return retVal;
            }

            retVal = true;
            return retVal;
        }

        /// <summary>
        /// Validates the data is a numeric value.
        /// </summary>
        /// <returns><c>true</c>, if data is numeric value was validated, 
        /// <c>false</c> otherwise.</returns>
        /// <param name="data">String to be validated data</param>
        public bool ValidateDataIsNumericValue(string data)
        {
            bool retVal;
            int num;
            const string MethodName = 
                "public bool ValidateDataIsNumericValue(string data)";

            retVal = int.TryParse(data, out num);
            if (!retVal)
            {
                return retVal;
            }

            retVal = true;
            return retVal;
        }

        /// <summary>
        /// Validates the data is greater then zero.
        /// </summary>
        /// <returns><c>true</c>, if data is greater then zero was validated, 
        /// <c>false</c> otherwise.</returns>
        /// <param name="data">String to be validated data.</param>
        public bool ValidateDataIsGreaterThenZero(string data)
        {
            bool retVal = false;
            bool val;
            int num;

            val = int.TryParse(data, out num);
            if (!val)
            {
                return retVal;
            }

            if (num < 1)
            {
                return retVal;
            }

            retVal = true;
            return retVal;
        }

        /// <summary>
        /// Validates the text boxes not empty.
        /// </summary>
        /// <returns><c>true</c>, if text boxes not 
        /// empty was validated, <c>false</c> otherwise.</returns>
        /// <param name="values">The values array of strings.</param>
        /// <param name="cnt">The count of items in array.</param>
        public bool ValidateTextBoxesNotEmpty(string[] values, int cnt)
        {
            bool retVal = true;
            string val = null;

            for (int i = 0; i < cnt; i++)
            {
                val = values[cnt].Trim();
                retVal = ValidateDataExists(val);
                if (!retVal)
                {
                    break;
                }
            }

            return retVal;
        }

        /// <summary>
        /// Validates the text boxes have numeric value.
        /// </summary>
        /// <returns><c>true</c>, if text boxes have 
        /// numeric value was validated, 
        /// <c>false</c> otherwise.</returns>
        /// <param name="values">The values array of strings.</param>
        /// <param name="cnt">The count of items in array.</param>
        public bool ValidateTextBoxesHaveNumericValue(string[] values, int cnt)
        {
            bool retVal = true;
            string val = null;

            for (int i = 0; i < cnt; i++)
            {
                val = values[cnt].Trim();
                retVal = ValidateDataIsNumericValue(val);
                if (!retVal)
                {
                    break;
                }
            }

            return retVal;
        }

        /// <summary>
        /// Validates the text boxes have value greater then zero.
        /// </summary>
        /// <returns><c>true</c>, if text boxes have 
        /// value greater then zero was validated, 
        /// <c>false</c> otherwise.</returns>
        /// <param name="values">The values array of strings.</param>
        /// <param name="cnt">The count of items in the array.</param>
        public bool ValidateTextBoxesHaveValueGreaterThenZero(
            string[] values, int cnt)
        {
            bool retVal = true;
            string val = null;
            for (int i = 0; i < cnt; i++)
            {
                val = values[cnt].Trim();
                retVal = ValidateDataIsGreaterThenZero(val);
                if (!retVal)
                {
                    break;
                }
            }

            return retVal;
        }

    }
}