//
//  StoreRectangleSquareVolumeMetricCollection.cs
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
	public struct SquareRectangleMetricStruct
	{
		/// <summary>
		/// The type of the solve.
		/// </summary>
		public string SolveType;

		/// <summary>
		/// The length.
		/// </summary>
		public string LengthMeters;

		/// <summary>
		/// The length feet.
		/// </summary>
		public string LengthCentimeters;

		/// <summary>
		/// The length inches.
		/// </summary>
		public string LengthMillimeters;

		/// <summary>
		/// The width.
		/// </summary>
		public string WidthMeters;

		/// <summary>
		/// The width feet.
		/// </summary>
		public string WidthCentimeters;

		/// <summary>
		/// The width inches.
		/// </summary>
		public string WidthMillimeters;

		/// <summary>
		/// The depth.
		/// </summary>
		public string DepthMeters;

		/// <summary>
		/// The depth feet.
		/// </summary>
		public string DepthCentimeters;

		/// <summary>
		/// The depth inches.
		/// </summary>
		public string DepthMillimeters;

		/// <summary>
		/// The total yards.
		/// </summary>
		public string TotalMeters;

		/// <summary>
		/// The total feet.
		/// </summary>
		public string TotalCentimeters;

		/// <summary>
		/// The total inches.
		/// </summary>
		public string TotalMillimeters;

		/// <summary>
		/// Stores the volume standard.
		/// </summary>
		/// <param name="solveType">Solve type.</param>
		/// <param name="DepthMeters">Depth meters.</param>
		/// <param name="DepthCentimeters">Depth centimeters.</param>
		/// <param name="DepthMillimeters">Depth millimeters.</param>
		/// <param name="LengthMeters">Length meters.</param>
		/// <param name="LengthCentimeters">Length centimeters.</param>
		/// <param name="LengthMillimeters">Length millimeters.</param>
		/// <param name="WidthMeters">Width meters.</param>
		/// <param name="WidthCentimeters">Width centimeters.</param>
		/// <param name="WidthMillimeters">Width millimeters.</param>
		/// <param name="TotalMeters">Total meters.</param>
		/// <param name="TotalCentimeters">Total centimeters.</param>
		/// <param name="TotalMillimeters">Total millimeters.</param>
		public void StoreVolumeMetric(
			string solveType,
			string DepthMeters,
			string DepthCentimeters,
			string DepthMillimeters,
			string LengthMeters,
			string LengthCentimeters,
			string LengthMillimeters,
			string WidthMeters,
			string WidthCentimeters,
			string WidthMillimeters,
			string TotalMeters,
			string TotalCentimeters,
			string TotalMillimeters)
		{
			this.SolveType = solveType;
			this.LengthMeters = LengthMeters;
			this.LengthCentimeters = LengthCentimeters;
			this.LengthMillimeters = LengthMillimeters;
			this.WidthMeters = WidthMeters;
			this.WidthCentimeters = WidthCentimeters;
			this.WidthMillimeters = WidthMillimeters;
			this.DepthMeters = DepthMeters;
			this.DepthCentimeters = DepthCentimeters;
			this.DepthMillimeters = DepthMillimeters;
			this.TotalMeters = TotalMeters;
			this.TotalCentimeters = TotalCentimeters;
			this.TotalMillimeters = TotalMillimeters;
		}
	}
	#endregion STRUCTURE DECLERATION

	/// <summary>
	/// Store rectangle square volume metric collection.
	/// </summary>
	public class StoreRectangleSquareVolumeMetricCollection
	{
		/// <summary>
		/// Initializes a new instance of the <see 
		/// cref="BuildingFormulas.StoreRectangleSquareVolumeMetricCollection"
		/// /> class.
		/// </summary>
		public StoreRectangleSquareVolumeMetricCollection()
		{
		}

		/// <summary>
		/// My message class creates and displays messages.
		/// </summary>
		private static MyMessages myMsg = new MyMessages();

		/// <summary>
		/// The cubic list.
		/// </summary>
		private static List<SquareRectangleMetricStruct> dataList = new 
            List<SquareRectangleMetricStruct>();

		/// <summary>
		/// Adds the new item.
		/// </summary>
		/// <returns><c>true</c>, if new item was added, 
		/// <c>false</c> otherwise.</returns>
		/// <param name="dataStruct">Data struct.</param>
		public static bool AddNewItem(SquareRectangleMetricStruct dataStruct)
		{
			bool retVal = false;

			const string ErrMsg = "Invalid argument passed.";


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
					errMsg,
					ex.ToString());
				return retVal;
			}
			catch (ArgumentException ex)
			{
				const string ErrMsg = "Encountered error with argument.";
				myMsg.BuildErrorString(
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
		public static SquareRectangleMetricStruct GetItemAt(int index)
		{
			SquareRectangleMetricStruct dataStruct = new 
                SquareRectangleMetricStruct();

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
					errMsg,
					ex.ToString());

				return dataStruct;
			}
			catch (ArgumentException ex)
			{
				const string ErrMsg = "Encountered error with argument.";
				myMsg.BuildErrorString(
					ErrMsg,
					ex.ToString());

				return dataStruct;
			}
		}
	}
}

