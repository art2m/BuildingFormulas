//
//  StoreStadard.cs
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
	/// Cubic area square rectangle.
	/// </summary>
	public struct SquareRectangleStruct
	{
		/// <summary>
		/// The type of the solve.
		/// </summary>
		public string SolveType;

		/// <summary>
		/// The length.
		/// </summary>
		public string LengthYards;

		/// <summary>
		/// The length feet.
		/// </summary>
		public string LengthFeet;

		/// <summary>
		/// The length inches.
		/// </summary>
		public string LengthInches;

		/// <summary>
		/// The width.
		/// </summary>
		public string WidthYards;

		/// <summary>
		/// The width feet.
		/// </summary>
		public string WidthFeet;

		/// <summary>
		/// The width inches.
		/// </summary>
		public string WidthInches;

		/// <summary>
		/// The depth.
		/// </summary>
		public string DepthYards;

		/// <summary>
		/// The depth feet.
		/// </summary>
		public string DepthFeet;

		/// <summary>
		/// The depth inches.
		/// </summary>
		public string DepthInches;

		/// <summary>
		/// The total yards.
		/// </summary>
		public string TotalYards;

		/// <summary>
		/// The total feet.
		/// </summary>
		public string TotalFeet;

		/// <summary>
		/// The total inches.
		/// </summary>
		public string TotalInches;

		/// <summary>
		/// Stores the cubic standard.
		/// </summary>
		/// <param name="solveType">Solve type.</param>
		/// <param name="lengthYards">Length yards.</param>
		/// <param name="lengthFeet">Length feet.</param>
		/// <param name="lengthInches">Length inches.</param>
		/// <param name="widthYards">Width yards.</param>
		/// <param name="widthFeet">Width feet.</param>
		/// <param name="widthInches">Width inches.</param>
		/// <param name="depthYards">Depth yards.</param>
		/// <param name="depthFeet">Depth feet.</param>
		/// <param name="depthInches">Depth inches.</param>
		/// <param name="totalYards">Total yards.</param>
		/// <param name="totalFeet">Total feet.</param>
		/// <param name="totalInches">Total inches.</param>
		public void StoreVolumeStandard(
			string solveType,
			string depthYards,
			string depthFeet,
			string depthInches,
			string lengthYards,
			string lengthFeet,
			string lengthInches,
			string widthYards,
			string widthFeet,
			string widthInches,
			string totalYards,
			string totalFeet,
			string totalInches)
		{
			this.SolveType = solveType;
			this.LengthYards = lengthYards;
			this.LengthFeet = lengthFeet;
			this.LengthInches = lengthInches;
			this.WidthYards = widthYards;
			this.WidthFeet = widthFeet;
			this.WidthInches = widthInches;
			this.DepthYards = depthYards;
			this.DepthFeet = depthFeet;
			this.DepthInches = depthInches;
			this.TotalYards = totalYards;
			this.TotalFeet = totalFeet;
			this.TotalInches = totalInches;
		}
	}
	#endregion STRUCTURE DECLERATION

	/// <summary>
	/// Store cubic standard collection.
	/// </summary>
	public static class StoreRectangleSquareVolumeStandardCollection
	{
		/// <summary>
		/// The name of the class.
		/// </summary>
		private const string MyClassName = 
			"public static class StoreCubicStandardCollection";

		/// <summary>
		/// My message class creates and displays messages.
		/// </summary>
		private static MyMessages myMsg = new MyMessages();
       
		/// <summary>
		/// The cubic list.
		/// </summary>
		private static List<SquareRectangleStruct> dataList = new 
            List<SquareRectangleStruct>();

		/// <summary>
		/// Adds the new item.
		/// </summary>
		/// <returns><c>true</c>, if new item was added, 
		/// <c>false</c> otherwise.</returns>
		/// <param name="dataStruct">Data struct.</param>
		public static bool AddNewItem(SquareRectangleStruct dataStruct)
		{
			bool retVal = false;

			const string ErrMsg = "Invalid argument passed.";
			const string MethodName = "public static bool AddNewItem(" +
			                                   "CubicAreaSquareRectangle dataStruct)";

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
		/// <see cref="BuildingFormulas.CubicAreaSquareRectangle"/>.</returns>
		/// <param name="index">Index of item to get.</param>
		public static SquareRectangleStruct GetItemAt(int index)
		{
			SquareRectangleStruct dataStruct = new SquareRectangleStruct();

			const string MethodName =
				"public static CubicAreaSquareRectangle GetItemAt(int index)";

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