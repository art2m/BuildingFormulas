//
//  StoreCylinderCubicStandardCollection.cs
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
	using System.Collections.Generic;

	#region STRUCTURE DECLERATION

	/// <summary>
	/// Cubic area cylinder struct.
	/// </summary>
	public struct CylinderVolumeStruct
	{
		/// <summary>
		/// The type of the solve.
		/// </summary>
		private string SolveType;

		/// <summary>
		/// The diameter yards.
		/// </summary>
		private string DiameterYards;

		/// <summary>
		/// The diameter feet.
		/// </summary>
		private string DiameterFeet;

		/// <summary>
		/// The diameter inches.
		/// </summary>
		private string DiameterInches;

		/// <summary>
		/// The height yards.
		/// </summary>
		private string HeightYards;

		/// <summary>
		/// The height feet.
		/// </summary>
		private string HeightFeet;

		/// <summary>
		/// The height inches.
		/// </summary>
		private string HeightInches;

		/// <summary>
		/// The total yards.
		/// </summary>
		private string TotalYards;

		/// <summary>
		/// The total feet.
		/// </summary>
		private string TotalFeet;

		/// <summary>
		/// The total inches.
		/// </summary>
		private string TotalInches;

		/// <summary>
		/// Stores the cubic standard.
		/// </summary>
		/// <param name="solveType">Solve type.</param>
		/// <param name="diameterYards">Diameter yards.</param>
		/// <param name="diameterFeet">Diameter feet.</param>
		/// <param name="diameterInches">Diameter inches.</param>
		/// <param name="heightYards">Height yards.</param>
		/// <param name="heightFeet">Height feet.</param>
		/// <param name="heightInches">Height inches.</param>
		/// <param name="totalYards">Total yards.</param>
		/// <param name="totalFeet">Total feet.</param>
		/// <param name="totalInches">Total inches.</param>
		public void StoreVolumeStandard(
			string solveType,
			string diameterYards,
			string diameterFeet,
			string diameterInches,
			string heightYards,
			string heightFeet,
			string heightInches,
			string totalYards,
			string totalFeet,
			string totalInches)
		{
			this.SolveType = solveType;
			this.DiameterYards = diameterYards;
			this.DiameterFeet = diameterFeet;
			this.DiameterInches = diameterInches;
			this.HeightYards = heightYards;
			this.HeightFeet = heightFeet;
			this.HeightInches = heightInches;
			this.TotalYards = totalYards;
			this.TotalFeet = totalFeet;
			this.TotalInches = totalInches;
		}
	}

	#endregion STRUCTURE DECLERATION

	/// <summary>
	/// Store cylinder cubic standard collection.
	/// </summary>
	public static class StoreCylinderVolumeStandardCollection
	{
		/// <summary>
		/// The name of the class.
		/// </summary>
		private const string MyClassName = 
			"StoreCylinderCubicStandardCollection";

		/// <summary>
		/// My message class creates and displays messages.
		/// </summary>
		private static MyMessages myMsg = new MyMessages();

		/// <summary>
		/// The cubic list.
		/// </summary>
		private static List<CylinderVolumeStruct> dataList = new 
            List<CylinderVolumeStruct>();

		/// <summary>
		/// Adds the new item.
		/// </summary>
		/// <returns><c>true</c>, if new item was added, 
		/// <c>false</c> otherwise.</returns>
		/// <param name="dataStruct">Data struct.</param>
		public static bool AddNewItem(CylinderVolumeStruct dataStruct)
		{
			bool retVal = false;

			const string ErrMsg = "Invalid argument passed.";
			const string MethodName = "public static bool AddNewItem(" +
			                                   "CubicAreaSCylinderStruct dataStruct)";

			try
			{
				dataList.Add(dataStruct);

				// All ok return true. 
				retVal = true;

				return retVal;
			}
			catch (ArgumentException ex)
			{
				myMsg.BuildErrorString(
					MyClassName, 
					MethodName, 
					ErrMsg,
					ex.ToString());
				return false;
			}
		}

		/// <summary>
		/// Clears the dataList array.
		/// </summary>
		public static void ClearArray()
		{
			const string MethodName = "public static void ClearArray()";
			const string ErrMsg = 
				"Encountered error while clearing the array.";

			dataList.Clear();
		}

		/// <summary>
		/// Gets the total items count.
		/// </summary>
		/// <returns>The item count.</returns>
		public static int GetItemCount()
		{
			int retVal = 0;

			const string MethodName = "public static int GetItemCount()";

			retVal = dataList.Count;

			return retVal;
		}

		/// <summary>
		/// Removes the item at index.
		/// </summary>
		/// <returns>The <see cref="System.Boolean"/>.</returns>
		/// <param name="index">Index of item to remove.</param>
		public static bool RemoveItemAt(int index)
		{
			bool retVal = false;
			const string MethodName = 
				"public static bool RemoveItemAt(int index)";

			try
			{                
				dataList.RemoveAt(index);

				// All ok return true
				retVal = true;

				return retVal;
			}
			catch (IndexOutOfRangeException ex)
			{
				string errMsg = 
					"Encountered error while removing item at: " + index;
				myMsg.BuildErrorString(
					MyClassName, 
					MethodName, 
					errMsg,
					ex.ToString());
				return retVal;
			}
			catch (ArgumentException ex)
			{
				const string ErrMsg = "Encountered error with argument.";
				myMsg.BuildErrorString(
					MyClassName, 
					MethodName, 
					ErrMsg,
					ex.ToString());
				return retVal;
			}
		}

		/// <summary>
		/// Gets the item at index.
		/// </summary>
		/// <returns>The 
		/// <see cref="BuildingFormulas.CubicAreaSquareRectangleStruct"/>.
		/// </returns>
		/// <param name="index">The index.</param>
		public static CylinderVolumeStruct GetItemAt(int index)
		{
			CylinderVolumeStruct dataStruct = new 
                CylinderVolumeStruct();

			const string MethodName = "public static " +
			                                   "CubicAreaCylinderStruct GetItemAt(" +
			                                   "int index)";

			try
			{   
				dataStruct = dataList[index];

				return dataStruct;
			}
			catch (IndexOutOfRangeException ex)
			{
				string errMsg =
					"Encountered error while removing item at: " + index;
				myMsg.BuildErrorString(
					MyClassName, 
					MethodName, 
					errMsg,
					ex.ToString());

				return dataStruct;
			}
			catch (ArgumentException ex)
			{
				const string ErrMsg = "Encountered error with argument.";
				myMsg.BuildErrorString(
					MyClassName, 
					MethodName, 
					ErrMsg,
					ex.ToString());

				return dataStruct;
			}
		}
	}
}