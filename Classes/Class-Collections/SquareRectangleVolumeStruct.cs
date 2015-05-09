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
	public struct SquareRectangleVolumeStruct
	{
		/// <summary>
		/// The type of the solve.
		/// </summary>
		private string SolveType;

		/// <summary>
		/// The length.
		/// </summary>
		private string LengthYards;

		/// <summary>
		/// The length feet.
		/// </summary>
		private string LengthFeet;

		/// <summary>
		/// The length inches.
		/// </summary>
		private string LengthInches;

		/// <summary>
		/// The width.
		/// </summary>
		private string WidthYards;

		/// <summary>
		/// The width feet.
		/// </summary>
		private string WidthFeet;

		/// <summary>
		/// The width inches.
		/// </summary>
		private string WidthInches;

		/// <summary>
		/// The depth.
		/// </summary>
		private string DepthYards;

		/// <summary>
		/// The depth feet.
		/// </summary>
		private string DepthFeet;

		/// <summary>
		/// The depth inches.
		/// </summary>
		private string DepthInches;

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
		/// The name of the method.
		/// </summary>
		private static string methodName = null;

		/// <summary>
		/// The error message object decleration.
		/// </summary>
		private static string errMsg = null;

		/// <summary>
		/// The cubic list.
		/// </summary>
		private static List<SquareRectangleVolumeStruct> dataList = new 
            List<SquareRectangleVolumeStruct>();

		/// <summary>
		/// Adds the new item.
		/// </summary>
		/// <returns><c>true</c>, if new item was added, 
		/// <c>false</c> otherwise.</returns>
		/// <param name="dataStruct">Data struct.</param>
		public static bool AddNewItem(SquareRectangleVolumeStruct dataStruct)
		{
			bool retVal = false;

			methodName = "public static bool AddNewItem(" +
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
				errMsg = "Invalid argument passed.";
				myMsg.BuildErrorString(
					MyClassName, 
					methodName, 
					errMsg,
					ex.ToString());
				return false;
			}
		}

		/// <summary>
		/// Clears the dataList array.
		/// </summary>
		public static void ClearArray()
		{
			methodName = "public static void ClearArray()";

			errMsg = "Encountered error while clearing the collection.";

			dataList.Clear();
		}

		/// <summary>
		/// Gets the total items count.
		/// </summary>
		/// <returns>The item count.</returns>
		public static int GetItemCount()
		{
			int retVal = 0;

			methodName = "public static int GetItemCount()";

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

			try
			{
				methodName = "public static bool RemoveItemAt(int index)";

				errMsg = "Encountered error while removing item at: " + index;
                
				dataList.RemoveAt(index);
                
				// All ok return true
				retVal = true;
                
				return retVal;
			}
			catch (IndexOutOfRangeException ex)
			{
				myMsg.BuildErrorString(
					MyClassName, 
					methodName, 
					errMsg,
					ex.ToString());
				return retVal;
			}
			catch (ArgumentException ex)
			{
				myMsg.BuildErrorString(
					MyClassName, 
					methodName, 
					errMsg,
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
		public static SquareRectangleVolumeStruct GetItemAt(int index)
		{
			SquareRectangleVolumeStruct dataStruct = new 
                SquareRectangleVolumeStruct();
			try
			{   
				methodName = "public static " +
				"CubicAreaSquareRectangle GetItemAt(int index)";
                
				dataStruct = dataList[index];
                
				return dataStruct;
			}
			catch (IndexOutOfRangeException ex)
			{
				myMsg.BuildErrorString(
					MyClassName, 
					methodName, 
					errMsg,
					ex.ToString());

				return dataStruct;
			}
			catch (ArgumentException ex)
			{
				myMsg.BuildErrorString(
					MyClassName, 
					methodName, 
					errMsg,
					ex.ToString());

				return dataStruct;
			}
		}
	}
}