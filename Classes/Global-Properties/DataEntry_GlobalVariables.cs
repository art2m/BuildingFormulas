﻿//  DataEntry_GlobalVariables.cs
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
	/// <summary>
	/// Data entry global variables.
	/// </summary>
	public static class DataEntry_GlobalVariables
	{
		private static string inputFileName = string.Empty;

		/// <summary>
		/// Gets or sets the shape to solve for.
		/// This is by Main Window when the user 
		/// selects Button for shape to solve for.
		/// </summary>
		/// <value>The shape to solve for.</value>
		public static string ShapeToSolveFor
		{
			get;
			set;
		}

		/// <summary>
		/// Gets or sets the input file name user entered.
		/// </summary>
		/// <value>The input file name user entered.</value>
		public static string InputFileNameUserEntered
		{
			get
			{
				return inputFileName;
			}

			set
			{
				InputFileNameUserEntered = value;
			}
		}
	}
}