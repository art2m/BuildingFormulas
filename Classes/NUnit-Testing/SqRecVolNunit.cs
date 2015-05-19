//
//  SqRecVolNunit.cs
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
	/// Sq rec vol nunit.
	/// </summary>
	public class SqRecVolNunit
	{
		/// <summary>
		/// The test count is used to select next test to be run.
		/// </summary>
		private int testCnt = 0;

		private bool depthBoxOne = false;

		private bool depthBoxTwo = false;

		private bool depthBoxThree = false;

		private bool lengthBoxOne = false;

		private bool lengthBoxTwo = false;

		private bool lengthBoxThree = false;

		private bool widthBoxOne = false;

		private bool widthBoxTwo = false;

		private bool widthBoxThree = false;


		/// <summary>
		/// Initializes a new instance of the 
		/// <see cref="BuildingFormulas.SqRecVolNunit"/> class.
		/// </summary>
		public SqRecVolNunit()
		{
		}

		/// <summary>
		/// Selects the next test to run.
		/// </summary>
		public void SelectNextTestToRun()
		{
			switch (testCnt)
			{
				case 0:
                    
					break;
				case 1:

					break;
				case 2:
					break;

				case 3:

					break;

				case 4:

					break;

				case 5:

					break;

				case 6:

					break;

				case 7:

					break;

				case 8:

					break;

				case 9:

					break;

				case 10:

					break;
			}
		}

		/// <summary>
		/// Sets the test to be run.
		/// change the number value to test
		/// to run for.
		/// </summary>
		/// <value>The select test to run.</value>
		public int SelectTestToRun
		{
			get
			{
				return testCnt; 
			}

			set
			{
				testCnt = value;
			}           
		}

		/// <summary>
		/// This test generates and array with random
		/// numbers to be used to fill the text boxes 
		/// for testing.
		/// </summary>
		/// <returns>The one.</returns>
		/// <param name="testNum">Test number.</param>
		public string[] TestValidData()
		{
			string[] testArray = new string[9];

			for (int i = 0; i < 9; i++)
			{
				Random rnd = new Random();
				int num = rnd.Next(1, 100);
				testArray[i] = num.ToString();
			}

			return testArray;
		}

		public string[] TestZeros()
		{
			string[] testArray = new string[9];

			for (int i = 0; i < 9; i++)
			{
				testArray[i] = "0";  
			}

			return testArray;
		}

		public string[] TestRandomZeroDepthBoxes()
		{            
			string[] testArray = new string[9];

			testArray = TestValidData();

			if (depthBoxOne == false)
			{
				testArray[0] = "0";  
				depthBoxOne = true;
			}
			else if (depthBoxTwo == false)
			{
				testArray[1] = "0";
				depthBoxTwo = true;
			}
			else if (depthBoxThree == false)
			{
				testArray[2] = "0"; 
				depthBoxThree = true;
			}
			else if (lengthBoxOne == false)
			{
				testArray[3] = "0";
				lengthBoxOne = true;
			}
			else if (lengthBoxTwo == false)
			{
				testArray[4] = "0";
				lengthBoxTwo = true;
			}
			else if (lengthBoxThree == false)
			{
				testArray[5] = "0";
				lengthBoxThree = true;
			}
			else if (widthBoxOne == false)
			{
				testArray[6] = "0";
				widthBoxOne = true;
			}
			else if (widthBoxTwo == false)
			{
				testArray[7] = "0";
				widthBoxTwo = true;
			}
			else if (widthBoxThree == false)
			{
				testArray[8] = "0";
				widthBoxThree = true;
			}
			else
			{
				for (int i = 0; i < 9; i++)
				{
					testArray[i] = "";
				}
							
			}
			return testArray;
		}

		public string[] TestWithOneEmptyValueInEachRow()
		{
			string[] testArray = new string[9]; 

			testArray = TestValidData();

			if (depthBoxOne == false)
			{
				testArray[0] = "";  
				depthBoxOne = true;
			}
			else if (depthBoxTwo == false)
			{
				testArray[1] = "";
				depthBoxTwo = true;
			}
			else if (depthBoxThree == false)
			{
				testArray[2] = ""; 
				depthBoxThree = true;
			}
			else if (lengthBoxOne == false)
			{
				testArray[3] = "";
				lengthBoxOne = true;
			}
			else if (lengthBoxTwo == false)
			{
				testArray[4] = "";
				lengthBoxTwo = true;
			}
			else if (lengthBoxThree == false)
			{
				testArray[5] = "";
				lengthBoxThree = true;
			}
			else if (widthBoxOne == false)
			{
				testArray[6] = "";
				widthBoxOne = true;
			}
			else if (widthBoxTwo == false)
			{
				testArray[7] = "";
				widthBoxTwo = true;
			}
			else if (widthBoxThree == false)
			{
				testArray[8] = "";
				widthBoxThree = true;
			}
			else
			{
				for (int i = 0; i < 9; i++)
				{
					testArray[i] = "";
				}

			}
			return testArray;
		}

		/// <summary>
		/// Tests the solve for units square volume. Select Standard button
		/// to test solve for standard units. Select Metric button
		/// to test solve for metric units. Test yards or meters 
		/// first. Then feet or Centimeters next. Then inches or 
		/// millimeters.
		/// </summary>
		/// <returns>The solve for units square.</returns>
		public string[] TestSolveForUnitsSquare()
		{
			string[] testArray = new string[9]; 

			testArray = TestZeros();

			if (depthBoxOne == false)
			{
				testArray[0] = "2"; 
				testArray[1] = "0";
				testArray[2] = "0";
				testArray[3] = "2";
				testArray[4] = "0";
				testArray[5] = "0";
				testArray[6] = "2";
				testArray[7] = "0";
				testArray[8] = "0";
				depthBoxOne = true;
			}
			else if (depthBoxTwo == false)
			{
				testArray[0] = "0"; 
				testArray[1] = "6";
				testArray[2] = "0";
				testArray[3] = "0";
				testArray[4] = "6";
				testArray[5] = "0";
				testArray[6] = "0";
				testArray[7] = "6";
				testArray[8] = "0";
				depthBoxTwo = true;
			}
			else if (depthBoxThree == false)
			{
				testArray[0] = "0"; 
				testArray[1] = "0";
				testArray[2] = "72";
				testArray[3] = "0";
				testArray[4] = "0";
				testArray[5] = "72";
				testArray[6] = "0";
				testArray[7] = "0";
				testArray[8] = "72";
				depthBoxThree = true;
			}
			else
			{
				for (int i = 0; i < 9; i++)
				{
					testArray[i] = "";
				}

			}
			return testArray;
		}

		/// <summary>
		/// Tests the solve for units rectangle volume. Select Standard button
		/// to test solve for standard units. Select Metric button
		/// to test solve for metric units. Test yards or meters 
		/// first. Then feet or Centimeters next. Then inches or 
		/// millimeters.
		/// </summary>
		/// <returns>The solve for units rectangle.</returns>
		public string[] TestSolveForUnitsRectangle()
		{
			string[] testArray = new string[9]; 

			testArray = TestZeros();

			if (depthBoxOne == false)
			{
				testArray[0] = "2"; 
				testArray[1] = "0";
				testArray[2] = "0";
				testArray[3] = "2";
				testArray[4] = "0";
				testArray[5] = "0";
				testArray[6] = "2";
				testArray[7] = "0";
				testArray[8] = "0";
				depthBoxOne = true;
			}
			else if (depthBoxTwo == false)
			{
				testArray[0] = "0"; 
				testArray[1] = "6";
				testArray[2] = "0";
				testArray[3] = "0";
				testArray[4] = "6";
				testArray[5] = "0";
				testArray[6] = "0";
				testArray[7] = "6";
				testArray[8] = "0";
				depthBoxTwo = true;
			}
			else if (depthBoxThree == false)
			{
				testArray[0] = "0"; 
				testArray[1] = "0";
				testArray[2] = "72";
				testArray[3] = "0";
				testArray[4] = "0";
				testArray[5] = "72";
				testArray[6] = "0";
				testArray[7] = "0";
				testArray[8] = "72";
				depthBoxThree = true;
			}
			else
			{
				for (int i = 0; i < 9; i++)
				{
					testArray[i] = "";
				}

			}
			return testArray;
		}
	}
}

