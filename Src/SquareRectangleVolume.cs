//  SquareRectangleCubicArea.cs
//
//  Author:
//       art2m <>
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

/// <summary>
/// Square rectangle volume.
/// Finds the volume of a rectangle
/// or square. Uses standard units 
/// or metric units to solve for 
/// square or rectangle.
/// </summary>
namespace BuildingFormulas
{
	using System;
	using System.IO;
	using System.Diagnostics;
	using System.Text;
	using Gtk;
	using degb = DataEntry_GlobalVariables;
	using StdStore = StoreRectangleSquareVolumeStandardCollection;
	using MetricStore = StoreRectangleSquareVolumeMetricCollection;


	/// <summary>
	/// Square rectangle cubic area.
	/// </summary>
	public partial class SquareRectangleVolume : Gtk.Window
	{
		/// <summary>
		/// The name of the class.
		/// </summary>
		private const string ThisClassName = 
			"public partial class SquareRectangleCubicArea : Gtk.Window";
       
		/// <summary>
		/// My message.
		/// </summary> 
		private MyMessages myMsg = new MyMessages();

		/// <summary>
		/// The math object decleration.
		/// </summary>
		private MyMath math = new MyMath();

		/// <summary>
		/// Create object of class ValidateData.
		/// </summary>
		private ValidateData vd = new ValidateData();

		/// <summary>
		/// The conv object decleration.
		/// </summary>
		private Conversions conv = new Conversions();

		/// <summary>
		/// The rss object decleration.
		/// </summary>
		private RectangleSquareSolveStandard rss = new 
            RectangleSquareSolveStandard();

		/// <summary>
		/// The rsm object decleration.
		/// </summary>
		private RectangleSquareSolveMetric rsm = new 
            RectangleSquareSolveMetric();

		/// <summary>
		/// The standard units of meassurement.
		/// being used when true.
		/// </summary>
		private bool standardUnits = false;

		/// <summary>
		/// The metric units of meassurement.
		/// being used when true.
		/// </summary>
		private bool metricUnits = false;

		/// <summary>
		/// The current position in the stored records.
		/// </summary>
		private int recPos = 0;

		/// <summary>
		/// Initializes a new instance of the 
		/// <see cref="BuildingFormulas.SquareRectangleCubicArea"/> class.
		/// initialize settings on SquareRectangleVolume.cs start up.
		/// </summary>
		public SquareRectangleVolume()
			: base(Gtk.WindowType.Toplevel)
		{
			this.Build();

			this.ClearData();
			this.metricUnits = false;
			this.standardUnits = true;
			btnStandard.Label = "Sandard On:";
			btnMetric.Label = "Metric Off:";
			this.SetCubicAreaLabelsStandardUnits();
			this.ShowUnitsCurrentlyBeingUsed();
			hbtnboxEditStore.Sensitive = false;

		}

		#region BUTTON CLICKED EVENTS

		/// <summary>
		/// Raises the button new item clicked event.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">Instance containing the event data.</param>
		protected void OnBtnNewItemClicked(object sender, EventArgs e)
		{
			this.ClearData();
		}

		/// <summary>
		/// Raises the button clear store clicked event.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">Instance containing the event data.</param>
		protected void OnBtnClearStoreClicked(object sender, EventArgs e)
		{
			StdStore.ClearArray();
		}

		/// <summary>
		/// Raises the button close clicked event.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">Instance containing the event data.</param>
		protected void OnBtnCloseClicked(object sender, EventArgs e)
		{
			this.Destroy();
		}

		/// <summary>
		/// Raises the button display store clicked event.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">Instance containing the event data.</param>
		protected void OnBtnDisplayStoreClicked(object sender, EventArgs e)
		{
			int stdCnt = StdStore.GetItemCount();
			if (standardUnits == true)
			{
				if (StdStore.GetItemCount() > 0)
				{					 
					btnClearStore.Sensitive = false;
					btnDisplayStore.Sensitive = false;
					btnMetric.Sensitive = false;
					btnNewItem.Sensitive = false;
					btnSaveForm.Sensitive = false;
					btnSaveStored.Sensitive = false;
					btnSolve.Sensitive = false;
					btnStandard.Sensitive = false;
					btnStore.Sensitive = false;

					hbtnboxEditStore.Sensitive = true;
					btnFirst.Click();
				} 
			}
			else if (metricUnits == true)
			{
				if (MetricStore.GetItemCount() > 0)
				{
					hbtnboxEditStore.Sensitive = true;
					btnClearStore.Sensitive = false;
					btnDisplayStore.Sensitive = false;
					btnMetric.Sensitive = false;
					btnNewItem.Sensitive = false;
					btnSaveForm.Sensitive = false;
					btnSaveStored.Sensitive = false;
					btnSolve.Sensitive = false;
					btnStandard.Sensitive = false;
					btnStore.Sensitive = false;
					
					hbtnboxEditStore.Sensitive = true;

					btnFirst.Click();
				}
			}
		}

		/// <summary>
		/// Raises the button metric clicked event.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">Instance containing the event data.</param>
		protected void OnBtnMetricClicked(object sender, EventArgs e)
		{
			this.metricUnits = true;
			this.standardUnits = false;
			btnStandard.Label = "Standard OFF:";
			btnMetric.Label = "Metric On:";
			this.SetCubicAreaLabelsMetricUnits();
			this.ShowUnitsCurrentlyBeingUsed();
			this.SolveForMetricUnitsStandardUnits();
		}

		/// <summary>
		/// Raises the button save form to file clicked event.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">Instance containing the event data.</param>
		protected void OnBtnSaveFormToFileClicked(object sender, EventArgs e)
		{
			SaveDataFromForm();
		}

		/// <summary>
		/// Raises the button save stored to file clicked event.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">Instance containing the event datea.</param>
		protected void OnBtnSaveStoredToFileClicked(object sender, EventArgs e)
		{
			SaveDataFromStore();
		}

		/// <summary>
		/// Raises the button solve clicked event.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">Instance containing the event data.</param>
		protected void OnBtnSolveClicked(object sender, EventArgs e)
		{
			//btnSolve.Sensitive = false;
			this.SolveForMetricUnitsStandardUnits();
		}

		/// <summary>
		/// Raises the button standard clicked event.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">Instance containing the event data.</param>
		protected void OnBtnStandardClicked(object sender, EventArgs e)
		{
			this.metricUnits = false;
			this.standardUnits = true;
			btnStandard.Label = "Standard On:";
			btnMetric.Label = "Metric Off:";
			this.SetCubicAreaLabelsStandardUnits();
			this.ShowUnitsCurrentlyBeingUsed();
			this.SolveForMetricUnitsStandardUnits();
		}

		/// <summary>
		/// Raises the button store results clicked event.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">Instance containing the event data.</param>
		protected void OnBtnStoreResultsClicked(object sender, EventArgs e)
		{
                            
			if (standardUnits == true)
			{
				SquareRectangleStruct strctRecSqVol = new 
                             SquareRectangleStruct();
                
				strctRecSqVol.StoreVolumeStandard(
					degb.ShapeToSolveFor, 
					txtDepthYard.Text,
					txtDepthFeet.Text,
					txtDepthInches.Text,
					txtLengthYard.Text,
					txtLengthFeet.Text,
					txtLengthInches.Text,
					txtWidthYard.Text,
					txtWidthFeet.Text,
					txtWidthInches.Text,
					txtCubicYards.Text,
					txtCubicFeet.Text,
					txtCubicInches.Text);
				StdStore.AddNewItem(
					strctRecSqVol);
			}
			else if (metricUnits == true)
			{
				SquareRectangleMetricStruct strctRecSqMetricVol = new
                    SquareRectangleMetricStruct();
				strctRecSqMetricVol.StoreVolumeMetric(
					degb.ShapeToSolveFor, 
					txtDepthYard.Text,
					txtDepthFeet.Text,
					txtDepthInches.Text,
					txtLengthYard.Text,
					txtLengthFeet.Text,
					txtLengthInches.Text,
					txtWidthYard.Text,
					txtWidthFeet.Text,
					txtWidthInches.Text,
					txtCubicYards.Text,
					txtCubicFeet.Text,
					txtCubicInches.Text);
				MetricStore.AddNewItem(
					strctRecSqMetricVol);
			}
			
		}

		protected void OnBtnMoveFirstClicked(object sender, EventArgs e)
		{
			bool retVal = false;
			int stdCnt = StdStore.GetItemCount();
			int metCnt = MetricStore.GetItemCount();
			const string first = "First";

			if (standardUnits == true)
			{
				if (stdCnt >= 0)
				{	
					recPos = 0;

					retVal = FillStandardTextBoxesWithDataFromStore();
					Debug.Assert(retVal == true);
					if (!retVal)
					{
						return;
					}

					SetButtonRecordState(stdCnt, recPos, first);
				}
			}
			else if (metricUnits == true)
			{
				if (MetricStore.GetItemCount() >= 0)
				{
					recPos = 0;

					retVal = FillMetricTextBoxesWithDataFromStroe();  
					Debug.Assert(retVal == false);
					if (!retVal)
					{
						return;
					}

					SetButtonRecordState(metCnt, recPos, first);
				}
			}
		}

		protected void OnbtnMoveNextClicked(object sender, EventArgs e)
		{ 
			bool retVal = false;
			int stdCnt = StdStore.GetItemCount();
			int metCnt = MetricStore.GetItemCount();
			const string next = "Next";
			int tmp = 0;

			if (standardUnits == true)
			{	
				tmp = recPos;

				recPos = recPos + 1;

				retVal = FillStandardTextBoxesWithDataFromStore();
				Debug.Assert(retVal == true);
				if (!retVal)
				{
					recPos = tmp;
					return;
				}
				

				Debug.Assert(recPos <= stdCnt, "Next recPos !<= stdCnt");
				SetButtonRecordState(stdCnt, recPos, next);

			}
			else if (metricUnits == true)
			{
				tmp = recPos;

				recPos = recPos + 1;

				retVal = FillMetricTextBoxesWithDataFromStroe();
				Debug.Assert(retVal == true);
				if (!retVal)
				{
					recPos = tmp;
					return;
				}

				Debug.Assert(recPos <= metCnt);
				SetButtonRecordState(metCnt, recPos, next);
			}
		}

		protected void OnBtnMovePreviousClicked(object sender, EventArgs e)
		{
			bool retVal = false;
			int stdCnt = StdStore.GetItemCount();
			int metCnt = MetricStore.GetItemCount();
			int tmp = 0;
			const string previous = "Previous";

			if (standardUnits == true)
			{     
				tmp = recPos;

				recPos = recPos - 1;
				retVal = FillStandardTextBoxesWithDataFromStore();

				Debug.Assert(retVal == true);
				if (!retVal)
				{
					recPos = tmp;
					return;
				}

				Debug.Assert(recPos >= 0, "Previous RecPos !>= 0");

				SetButtonRecordState(stdCnt, recPos, previous);
			}
			else if (metricUnits == true)
			{
				tmp = recPos;
				recPos = recPos - 1;
				retVal = FillMetricTextBoxesWithDataFromStroe();
				Debug.Assert(retVal == true);
				if (!retVal)
				{
					recPos = tmp;
					return;
				}

				Debug.Assert(recPos >= 0);
				SetButtonRecordState(metCnt, recPos, previous);
			}

		}

		protected void OnBtnMoveLastClicked(object sender, EventArgs e)
		{  
			bool retVal = false;
			int stdCnt = StdStore.GetItemCount();
			int metCnt = MetricStore.GetItemCount();
			int tmp = 0;
			const string last = "Last";

			if (standardUnits == true)
			{   
				tmp = recPos;

				recPos = stdCnt - 1;   

				retVal = FillStandardTextBoxesWithDataFromStore();

				Debug.Assert(retVal == true);
				if (!retVal)
				{
					recPos = tmp;
					return;
				}

				SetButtonRecordState(stdCnt, recPos, last);
			}
			else if (metricUnits == true)
			{
				tmp = recPos;

				recPos = stdCnt - 1;

				retVal = FillMetricTextBoxesWithDataFromStroe();
				if (!retVal)
				{
					recPos = tmp;
					return;
				}

				SetButtonRecordState(metCnt, recPos, last);
			}

		}

		protected void OnBtnEditClicked(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		protected void OnBtnUpdateClicked(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		protected void OnBtnDeleteClicked(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		protected void OnBtnCancelClicked(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		protected void OnBtnDoneClicked(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}


		#endregion BUTTON CLICKED EVENTS

		#region CLEAR ALL DATA

		/// <summary>
		/// Clears the data from rectangle square solve.
		/// </summary>
		private void ClearData()
		{
			txtDepthYard.Text = "12"; //"0";
			txtDepthFeet.Text = "12"; //"0";
			txtDepthInches.Text = "12"; //"0";

			txtLengthYard.Text = "12"; //"0";
			txtLengthFeet.Text = "12"; //"0";
			txtLengthInches.Text = "12"; //"0";

			txtWidthYard.Text = "12"; //"0";
			txtWidthFeet.Text = "12"; //"0";
			txtWidthInches.Text = "12"; //"0";

			txtCubicYards.Text = "0";
			txtCubicFeet.Text = "0";
			txtCubicInches.Text = "0";

			this.math.DepthInYards = 0;
			this.math.DepthInFeet = 0;
			this.math.DepthInInches = 0;
			this.math.LengthInYards = 0;
			this.math.LengthInFeet = 0;
			this.math.LengthInInches = 0;
			this.math.WidthInYards = 0;
			this.math.WidthInFeet = 0;
			this.math.WidthInInches = 0;
			this.math.TotalCubicYards = 0;
			this.math.TotalCubicFeet = 0;
			this.math.TotalCubicInches = 0;
		}

		/// <summary>
		/// Clears the text boxes solve for rectangle square solve.
		/// </summary>
		private void ClearTextBoxesCubicArea()
		{
			txtCubicYards.Text = "0";
			txtCubicFeet.Text = "0";
			txtCubicInches.Text = "0";
		}

		#endregion CLEAR ALL DATA

		#region FILL RECTANGLE SQUARE DATA WITH DATA FROM TEXTBOXES

		/// <summary>
		/// Fills the data with data from text boxes.
		/// </summary>
		/// <returns><c>true</c>, if data with data 
		/// from text boxes was filled, <c>false</c> 
		/// otherwise.</returns>
		private bool FillStandardValuesWithDataFromTextBoxes()
		{
			bool retVal = false;
			const string MethodName = 
				"private bool FillDataWithDataFromTextBoxes()";
			const string errMsg = "Encountered error converting numeric " +
			                               "string to double value.";

			try
			{
				double val = 0;

				val = this.conv.ConvertStringToDouble(
					txtDepthYard.Text.Trim());
				this.math.DepthInYards = val;
				val = this.conv.ConvertStringToDouble(
					txtDepthFeet.Text.Trim());
				this.math.DepthInFeet = val;
				val = this.conv.ConvertStringToDouble(
					txtDepthInches.Text.Trim());
				this.math.DepthInInches = val;

				val = this.conv.ConvertStringToDouble(
					txtLengthYard.Text.Trim());
				this.math.LengthInYards = val;
				val = this.conv.ConvertStringToDouble(
					txtLengthFeet.Text.Trim());
				this.math.LengthInFeet = val;
				val = this.conv.ConvertStringToDouble(
					txtLengthInches.Text.Trim());
				this.math.LengthInInches = val;

				val = this.conv.ConvertStringToDouble(
					txtWidthYard.Text.Trim());
				this.math.WidthInYards = val;
				val = this.conv.ConvertStringToDouble(
					txtWidthFeet.Text.Trim());
				this.math.WidthInFeet = val;
				val = this.conv.ConvertStringToDouble(
					txtWidthInches.Text.Trim());
				this.math.WidthInInches = val;

				return retVal = true;
			}
			catch (FormatException ex)
			{

				this.myMsg.BuildErrorString(
					ThisClassName, 
					MethodName, 
					errMsg,
					ex.ToString());   

				// Error so return false.
				return retVal;
			}
			catch (OverflowException ex)
			{
				this.myMsg.BuildErrorString(
					ThisClassName, 
					MethodName, 
					errMsg,
					ex.ToString());

				// Error so return false.
				return retVal;
			}
		}

		/// <summary>
		/// Fills the metric values with data from text boxes.
		/// </summary>
		/// <returns><c>true</c>, if metric values with data from 
		/// text boxes was filled, <c>false</c> otherwise.</returns>
		private bool FillMetricValuesWithDataFromTextBoxes()
		{
			bool retVal = false;
			const string MethodName = 
				"private bool FillMetricValuesWithDataFromTextBoxes()";
			const string errMsg = "Encountered error converting numeric " +
			                               "string to double value.";

			try
			{
				double val = 0;

				val = this.conv.ConvertStringToDouble(
					txtDepthYard.Text.Trim());
				this.math.DepthMeters = val;
				val = this.conv.ConvertStringToDouble(
					txtDepthFeet.Text.Trim());
				this.math.DepthCentimeters = val;
				val = this.conv.ConvertStringToDouble(
					txtDepthInches.Text.Trim());
				this.math.DepthMillimeter = val;

				val = this.conv.ConvertStringToDouble(
					txtLengthYard.Text.Trim());
				this.math.LengthMeters = val;
				val = this.conv.ConvertStringToDouble(
					txtLengthFeet.Text.Trim());
				this.math.LengthCentimeters = val;
				val = this.conv.ConvertStringToDouble(
					txtLengthInches.Text.Trim());
				this.math.LengthMillimeters = val;

				val = this.conv.ConvertStringToDouble(
					txtWidthYard.Text.Trim());
				this.math.WidthMeters = val;
				val = this.conv.ConvertStringToDouble(
					txtWidthFeet.Text.Trim());
				this.math.WidthCentimeters = val;
				val = this.conv.ConvertStringToDouble(
					txtWidthInches.Text.Trim());
				this.math.WidthMillimeters = val;

				return retVal = true;
			}
			catch (FormatException ex)
			{

				this.myMsg.BuildErrorString(
					ThisClassName, 
					MethodName, 
					errMsg,
					ex.ToString());   

				// Error so return false.
				return retVal;
			}
			catch (OverflowException ex)
			{
				this.myMsg.BuildErrorString(
					ThisClassName, 
					MethodName, 
					errMsg,
					ex.ToString());

				// Error so return false.
				return retVal;
			}
		}

		#endregion FILL RECTANGLE SQUARE DATA WITH DATA FROM TEXTBOXES

		#region CONVERT DATA

		/// <summary>
		/// Converts the data to inches. Used to find cubic area.
		/// </summary>
		/// <returns><c>true</c>, if data to inches was converted, 
		/// <c>false</c> otherwise.</returns>
		private bool ConvertDataToInches()
		{
			bool retVal = false;
			double val = 0;
			const string Length = "length";
			const string Width = "width";
			const string Depth = "depth";

			const string MethodName = "private bool ConvertDataToInches()";

			val = this.rss.GetTheDepthTotalInches(
				this.math.DepthInYards, 
				this.math.DepthInFeet, 
				this.math.DepthInInches);
			retVal = this.vd.ValidateTotalSumIsGreaterThenZero(val, "Depth");
			if (!retVal)
			{
				return retVal;
			}
			else
			{
				this.math.DepthTotalInches = val;
			}

			val = this.rss.GetTheLengthTotalInches(
				this.math.LengthInYards,
				this.math.LengthInFeet, 
				this.math.LengthInInches);
			retVal = this.vd.ValidateTotalSumIsGreaterThenZero(val, "Length");
			if (val <= 0)
			{               
				return retVal;
			}
			else
			{
				this.math.LengthTotalInches = val;
			}

			val = this.rss.GetTheWidthsTotalInches(
				this.math.WidthInYards,
				this.math.WidthInFeet, 
				this.math.WidthInInches);
			retVal = this.vd.ValidateTotalSumIsGreaterThenZero(val, Width);
			if (val <= 0)
			{               
				return retVal;
			}
			else
			{
				this.math.WidthTotalInches = val;
			}

			return retVal = true;
		}

		private bool ConvertDataToMillimeters()
		{
			bool retVal = false;
			double val = 0;
			const string Length = "length";
			const string Width = "width";
			const string Depth = "depth";

			const string MethodName = "private bool ConvertDataToMillimeters()";

			val = this.rsm.GetDepthTotalMillimeters(
				this.math.DepthMeters,
				this.math.DepthCentimeters, 
				this.math.DepthMillimeter);
            
			retVal = this.vd.ValidateTotalSumIsGreaterThenZero(val, "Depth");
			if (!retVal)
			{
				return retVal;
			}
			else
			{
				this.math.DepthTotalMillimeters = val;
			}

			val = this.rsm.GetLengthTotalMillimeters(
				this.math.LengthMeters,
				this.math.LengthCentimeters, 
				this.math.LengthMillimeters);
			retVal = this.vd.ValidateTotalSumIsGreaterThenZero(val, "Length");
			if (val <= 0)
			{               
				return retVal;
			}
			else
			{
				this.math.LengthTotalMillimeters = val;
			}

			val = this.rsm.GetWidthsTotalMillimeters(
				this.math.WidthMeters,
				this.math.WidthCentimeters, 
				this.math.WidthMillimeters);
			retVal = this.vd.ValidateTotalSumIsGreaterThenZero(val, Width);
			if (val <= 0)
			{               
				return retVal;
			}
			else
			{
				this.math.WidthTotalMillimeters = val;
			}

			return retVal = true;
		}

		/// <summary>
		/// Converts the standard units data to metric units.
		/// </summary>
		private void ConvertStandardUnitsDataToMetricUnits()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Converts the metric units data to standard units.
		/// </summary>
		private void ConvertMetricUnitsDataToStandardUnits()
		{
			throw new NotImplementedException();
		}

		#endregion CONVERT DATA

		#region VALIDATE USER DATA

		/// <summary>
		/// Validates the cubic area rectangle square data.
		/// </summary>
		/// <returns><c>true</c>, if cubic area rectangle 
		/// square data was validated, 
		/// <c>false</c> otherwise.</returns>
		private bool ValidateCubicAreaRectangleSquareData()
		{
			bool retVal = false;
			const int Cnt = 9;
			string[] values = new string[Cnt];           

			values[0] = txtDepthYard.Text.Trim();
			values[1] = txtDepthFeet.Text.Trim();
			values[2] = txtDepthInches.Text.Trim();
			values[3] = txtLengthYard.Text.Trim();
			values[4] = txtLengthFeet.Text.Trim();
			values[5] = txtLengthInches.Text.Trim();
			values[6] = txtWidthYard.Text.Trim();
			values[7] = txtWidthFeet.Text.Trim();
			values[8] = txtWidthInches.Text.Trim();

			retVal = this.vd.ValidateUserDataNotNullNotEmpty(values, Cnt);
			if (!retVal)
			{
				return retVal;
			}

			retVal = this.vd.ValidateUserDataHasNumericValue(values, Cnt);
			if (!retVal)
			{
				return retVal;
			}

			return retVal = true;
		}

		#endregion VALIDATE USER DATA

		#region SOLVE FOR RECTANGLE SQUARE CUBIC AREA

		/// <summary>
		/// Shapes and the formula to solve for.
		/// </summary>
		private void SolveForMetricUnitsStandardUnits()
		{   
			bool retVal = false;

			if (this.metricUnits)
			{                
				retVal = this.ValidateCubicAreaRectangleSquareData();
				if (!retVal)
				{
					return;
				}

				retVal = this.FillMetricValuesWithDataFromTextBoxes();
				if (!retVal)
				{
					return;
				}

				retVal = this.ConvertDataToMillimeters();
				if (!retVal)
				{
					return;
				}

				SolveForCubicRectangleSquareMetric();
			}
			else if (this.standardUnits)
			{
				retVal = this.ValidateCubicAreaRectangleSquareData();
				if (!retVal)
				{
					return;
				}

				retVal = this.FillStandardValuesWithDataFromTextBoxes();
				if (!retVal)
				{
					return;
				}

				retVal = this.ConvertDataToInches();
				if (!retVal)
				{
					return;
				}

				this.SolveForCubicRectangleSquareStandard();
			}          
		}

		/// <summary>
		/// Solves for cubic rectangle square standard.
		/// </summary>
		private void SolveForCubicRectangleSquareStandard()
		{
			double val = 0;
			const string MethodName = 
				"private void SolveForCubicRectangleSquareStandard()";
			
			val = this.rss.SolveForVolumeYards(
				this.math.DepthTotalInches, 
				this.math.LengthTotalInches, 
				this.math.WidthTotalInches);

			txtCubicYards.Text = val.ToString();

			val = this.rss.SolveForVolumeFeet(
				this.math.DepthTotalInches,
				this.math.LengthTotalInches,
				this.math.WidthTotalInches);

			txtCubicFeet.Text = val.ToString();

			val = this.rss.SolveForVolumeInches(
				this.math.DepthTotalInches,
				this.math.LengthTotalInches,
				this.math.WidthTotalInches);

			txtCubicInches.Text = val.ToString();
		}

		/// <summary>
		/// Solves for cubic rectangle square metric.
		/// </summary>
		private void SolveForCubicRectangleSquareMetric()
		{
			double val = 0;

			val = this.rsm.SolveForVolumeMeters(
				this.math.DepthTotalMillimeters, 
				this.math.LengthTotalMillimeters, 
				this.math.WidthTotalMillimeters);

			txtCubicYards.Text = val.ToString();

			val = this.rsm.SolveForVolumeCentimeters(
				this.math.DepthTotalMillimeters,
				this.math.LengthTotalMillimeters,
				this.math.WidthTotalMillimeters);

			txtCubicFeet.Text = val.ToString();

			val = this.rsm.SolveForVolumeMillimeters(
				this.math.DepthTotalMillimeters,
				this.math.LengthTotalMillimeters,
				this.math.WidthTotalMillimeters);

			txtCubicInches.Text = val.ToString();
		}

		#endregion SOLVE FOR RECTANGLE SQUARE CUBIC AREA

		#region SET UNITS CURENTLY BEING USED

		/// <summary>
		/// Shows the units currently being used.
		/// </summary>
		private void ShowUnitsCurrentlyBeingUsed()
		{
			if (this.standardUnits)
			{
				lblInfo.Text = "Using standard units.";
			}
			else if (this.metricUnits)
			{
				lblInfo.Text = "Using metric units.";
			}
			else
			{
				this.standardUnits = true;
				this.metricUnits = false;
				lblInfo.Text = "Using standard units.";
			}
		}

		/// <summary>
		/// Sets the cubic area labels standard units.
		/// </summary>
		private void SetCubicAreaLabelsStandardUnits()
		{
			lblCubicYards.Text = "Total Cubic Area In Yards:";
			lblCubicFeet.Text = "Total Cubic Area In Feet:";
			lblCubicInches.Text = "Total Cubic Area In Inches:";
			lblYards.Text = "Yards";
			lblFeet.Text = "Feet";
			lblInches.Text = "Inches";
		}

		/// <summary>
		/// Sets the cubic area labels metric units.
		/// </summary>
		private void SetCubicAreaLabelsMetricUnits()
		{
			lblCubicYards.Text = "Total Cubic Area In Meters:";
			lblCubicFeet.Text = "Total Cubic Area In Centimeters:";
			lblCubicInches.Text = "Total Cubic Area In Millimeters:";
			lblYards.Text = "Meters";
			lblFeet.Text = "Centimeters";
			lblInches.Text = "Millimeters";
		}

		#endregion SET UNITS CURENTLY BEING USED

		#region SAVEING USER DATA

		/// <summary>
		/// Prints the data from form.
		/// </summary>
		private void SaveDataFromForm()
		{
			SaveUserData sud = new SaveUserData();
			string retVal = string.Empty;
			const int sizeElements = 12;
			string[] dataArray = new string[sizeElements];
			string errMsg = string.Empty;
			FileStream fs = null;

			try
			{
				retVal = sud.SaveUsersFormData(
					"Save file name. If file with same name exists will " +
					"overwrite. Create new file if name does not exist.");
                
				if (string.IsNullOrEmpty(retVal))
				{
					return;
				}
				else if (!File.Exists(retVal))
				{
					return;  
				}
                
				fs = File.Create(retVal);
				fs.Dispose();
                      
				dataArray = GetFormData();		

				if (dataArray == null || dataArray.Length < 1)
				{
					errMsg = "Fond no data to save. Exiting.";
					myMsg.ShowErrMessage(errMsg);
					return;
				}

				File.WriteAllLines(retVal, dataArray);

			}
			catch (IndexOutOfRangeException ex)
			{
				errMsg = "Encountered error dataArray out of bounds.";
				myMsg.BuildErrorString(errMsg, ex.ToString());
			}
			catch (ArgumentNullException ex)
			{
				errMsg = "Encountered error: found no data to save.";
				myMsg.BuildErrorString(errMsg, ex.ToString());
			}
			catch (ArgumentOutOfRangeException ex)
			{
				errMsg = "Encountered error: found no data to save.";
				myMsg.BuildErrorString(errMsg, ex.ToString()); 
			}
			catch (NotSupportedException ex)
			{
				errMsg = "Encountered error: unable to write data to file.";
				myMsg.BuildErrorString(errMsg, ex.ToString()); 
			}
			catch (IOException ex)
			{
				errMsg = "Encountered error: unable to write data to file.";
				myMsg.BuildErrorString(errMsg, ex.ToString()); 
			}
			catch (ArgumentException ex)
			{
				errMsg = "Encountered error: unable to write data to file.";
				myMsg.BuildErrorString(errMsg, ex.ToString());
			}
			catch (ObjectDisposedException ex)
			{
				errMsg = "Encountered error: invalid opertation.";
				myMsg.BuildErrorString(errMsg, ex.ToString());
			}
			finally
			{
				if (fs != null)
				{
					fs.Dispose();
				}
			}
		}

		/// <summary>
		/// Gets the form data.
		/// </summary>
		/// <returns>The form data.</returns>
		private string[] GetFormData()
		{
			string[] dataArray = null;
			string errMsg = string.Empty;
			const string MethodName = "private string[] GetFormData()";

			try
			{
				dataArray = new string[12];


				if (standardUnits == true)
				{
					dataArray[0] = "Depth in yards: " +
					txtDepthYard.Text.Trim();
					dataArray[1] = "Depth in feet: " + txtDepthFeet.Text.Trim();
					dataArray[2] = 
                                    "Depth in inches: " +
					txtDepthInches.Text.Trim();
                                
					dataArray[3] = "Length in yards: " +
					txtLengthYard.Text.Trim();
					dataArray[4] = "Length in feet: " +
					txtLengthFeet.Text.Trim();
					dataArray[5] = 
                                    "Length in inches: " +
					txtLengthInches.Text.Trim();
                                
					dataArray[6] = "Width in yards: " +
					txtWidthYard.Text.Trim();
					dataArray[7] = "Width in feet: " + txtWidthFeet.Text.Trim();
					dataArray[8] = "Width in inches: " +
					txtWidthInches.Text.Trim();
                                
					dataArray[9] = "Total volume in yards: " +
					txtCubicYards.Text;
					dataArray[10] = "Total volume in feet: " +
					txtCubicFeet.Text;
					dataArray[11] = 
                                    "Total volume in inches: " +
					txtCubicInches.Text;
				}
				else if (metricUnits == true)
				{
					dataArray[0] = "Depth in Meters: " +
					txtDepthYard.Text.Trim();
					dataArray[1] = "Depth in Centimeters: " +
					txtDepthFeet.Text.Trim();
					dataArray[2] = 
                        "Depth in Millimeters: " + txtDepthInches.Text.Trim();

					dataArray[3] = "Length in Meters: " +
					txtLengthYard.Text.Trim();
					dataArray[4] = "Length in Centimeters: " +
					txtLengthFeet.Text.Trim();
					dataArray[5] = 
                        "Length in Millimeters: " + txtLengthInches.Text.Trim();

					dataArray[6] = "Width in Meters: " +
					txtWidthYard.Text.Trim();
					dataArray[7] = "Width in Centimeters: " +
					txtWidthFeet.Text.Trim();
					dataArray[8] = "Width in Millimeters: " +
					txtWidthInches.Text.Trim();

					dataArray[9] = "Total volume in Meters: " +
					txtCubicYards.Text;
					dataArray[10] = "Total volume in Centimeters: " +
					txtCubicFeet.Text;
					dataArray[11] = 
                        "Total volume in Millimeters: " + txtCubicInches.Text;
				}
                
				return dataArray;
			}
			catch (IndexOutOfRangeException ex)
			{
				errMsg = "Encountered error while collecting data from form." +
				" Exiting printing."; 
				myMsg.BuildErrorString(ThisClassName, MethodName, errMsg,
					ex.ToString());
				return dataArray;
			}   
		}

		/// <summary>
		/// Prints the data from store.
		/// </summary>
		private void SaveDataFromStore()
		{
			SaveUserData sud = new SaveUserData();
			string retVal = string.Empty;
			const int sizeElements = 12;
			string errMsg = string.Empty;
			StreamWriter fileWriter = null;
			

			try
			{
				int cnt = 
					StdStore.GetItemCount();
                         
				if (cnt < 1)
				{
					errMsg = "Unable to save stored items as there are no " +
					"items stored.";
					myMsg.ShowInformationMessage(errMsg);
					return;
				}
                
				string[,] dataArray = new string[cnt, sizeElements];
                
				dataArray = GetStoredData();

			    
                
				if (dataArray == null || dataArray.Length < 1)
				{
					errMsg = "Fond no stored data to save. Exiting.";
					myMsg.ShowErrMessage(errMsg);
					return;
				}

				retVal = sud.SaveUsersFormData(
					"Save file name. If file with same name exists will " +
					"overwrite. Create new file if name does not exist.");

				if (string.IsNullOrEmpty(retVal))
				{
					return;
				}
				

				FileStream fs = File.Create(retVal);
				fs.Dispose();	
				
				fileWriter = new StreamWriter(retVal);

				for (int i = 0; i < cnt; i++)
				{
					fileWriter.WriteLine(dataArray[i, 0]);
					fileWriter.WriteLine(dataArray[i, 1]);
					fileWriter.WriteLine(dataArray[i, 2]);
					fileWriter.WriteLine(dataArray[i, 3]);
					fileWriter.WriteLine(dataArray[i, 4]);
					fileWriter.WriteLine(dataArray[i, 5]);
					fileWriter.WriteLine(dataArray[i, 6]);
					fileWriter.WriteLine(dataArray[i, 7]);
					fileWriter.WriteLine(dataArray[i, 8]);
					fileWriter.WriteLine(dataArray[i, 9]);
					fileWriter.WriteLine(dataArray[i, 10]);
					fileWriter.WriteLine(dataArray[i, 11]);
					fileWriter.WriteLine(Environment.NewLine);
				}

				fileWriter.Dispose();				
			}
			catch (IndexOutOfRangeException ex)
			{
				errMsg = "Encountered error dataArray out of bounds.";
				myMsg.BuildErrorString(errMsg, ex.ToString());
			}
			catch (ArgumentNullException ex)
			{
				errMsg = "Encountered error: found no data to save.";
				myMsg.BuildErrorString(errMsg, ex.ToString());
			}
			catch (ArgumentOutOfRangeException ex)
			{
				errMsg = "Encountered error: found no data to save.";
				myMsg.BuildErrorString(errMsg, ex.ToString()); 
			}
			catch (NotSupportedException ex)
			{
				errMsg = "Encountered error: unable to write data to file.";
				myMsg.BuildErrorString(errMsg, ex.ToString()); 
			}
			catch (IOException ex)
			{
				errMsg = "Encountered error: unable to write data to file.";
				myMsg.BuildErrorString(errMsg, ex.ToString()); 
			}
			catch (ArgumentException ex)
			{
				errMsg = "Encountered error: unable to write data to file.";
				myMsg.BuildErrorString(errMsg, ex.ToString());
			}
			catch (ObjectDisposedException ex)
			{
				errMsg = "Encountered error: invalid opertation.";
				myMsg.BuildErrorString(errMsg, ex.ToString());
			}
			finally
			{
				if (fileWriter.BaseStream != null)
				{
					fileWriter.Dispose();
				}
			}

		}

		/// <summary>
		/// Gets the stored data.
		/// </summary>
		/// <returns>The stored data.</returns>
		private string[,] GetStoredData()
		{
			int cnt = 
				StdStore.GetItemCount();
			SquareRectangleStruct srvs = new 
                SquareRectangleStruct();

			string[,] dataArray = new string[cnt, 12];

			for (int i = 0; i < cnt; i++)
			{
				srvs = 
                    StdStore.GetItemAt(i);
				dataArray[i, 0] = "Depth in yards: " + srvs.DepthYards;
				dataArray[i, 1] = "Depth in feet: " + srvs.DepthFeet;
				dataArray[i, 2] = "Depth in inches: " + srvs.DepthInches;
				dataArray[i, 3] = "Length in yards: " + srvs.LengthYards;
				dataArray[i, 4] = "Length in feet: " + srvs.LengthFeet;
				dataArray[i, 5] = "Length in inches: " + srvs.LengthInches;
				dataArray[i, 6] = "Width in yards: " + srvs.WidthYards;
				dataArray[i, 7] = "Width in feet: " + srvs.WidthFeet;
				dataArray[i, 8] = "Width in inches: " + srvs.WidthInches;
				dataArray[i, 9] = "Total volume yards: " + srvs.TotalYards;
				dataArray[i, 10] = "Total volume feet: " + srvs.TotalFeet;
				dataArray[i, 11] = "Total volume inches: " + srvs.TotalInches; 				
			}

			return dataArray;
		}

		/// <summary>
		/// Creates the temp file.
		/// </summary>
		/// <returns>The temp file.</returns>
		private string CreateTempFile()
		{
			string tmpPath = string.Empty;
			string errMsg = string.Empty;
			string dat = string.Empty;

			const string MethodName = "private string CreateTempFile()";

			try
			{
				tmpPath = System.IO.Path.GetTempFileName();
                      
				if (string.IsNullOrEmpty(tmpPath))
				{
					errMsg = "Unable to create temporary file for printing";

					myMsg.BuildErrorString(ThisClassName, MethodName, errMsg,
						dat);
					return tmpPath;
				}
                      
				if (!File.Exists(tmpPath))
				{
					errMsg = "Unable to create temporary file for printing";

					myMsg.BuildErrorString(ThisClassName, MethodName, errMsg,
						dat);
					return tmpPath;
				}

				// all ok.
				return tmpPath;
			}
			catch (IOException ex)
			{
				errMsg = "Unable to create temporary file for printing";

				myMsg.BuildErrorString(ThisClassName, MethodName, errMsg,
					ex.ToString());
				return tmpPath; 
			}
		}

		#endregion SAVEING USER DATA

		#region DISPLAY STORE DATA

		/// <summary>
		/// Fills the standard text boxes with data from store.
		/// </summary>
		/// <returns><c>true</c>, if standard text boxes with 
		/// data from store was filled, <c>false</c> 
		/// otherwise.</returns>
		private bool FillStandardTextBoxesWithDataFromStore()
		{
			SquareRectangleStruct srsv = new SquareRectangleStruct();            
			
			bool retVal = false;

			srsv = StdStore.GetItemAt(recPos);
			txtDepthYard.Text = srsv.DepthYards.ToString();
			txtDepthFeet.Text = srsv.DepthFeet.ToString();
			txtDepthInches.Text = srsv.DepthInches.ToString();
			txtLengthYard.Text = srsv.LengthYards.ToString();
			txtLengthFeet.Text = srsv.LengthFeet.ToString();
			txtLengthInches.Text = srsv.LengthInches.ToString();
			txtWidthYard.Text = srsv.WidthYards.ToString();
			txtWidthFeet.Text = srsv.WidthFeet.ToString();
			txtWidthInches.Text = srsv.WidthInches.ToString();
			txtCubicYards.Text = srsv.TotalYards.ToString();
			txtCubicFeet.Text = srsv.TotalFeet.ToString();
			txtCubicInches.Text = srsv.TotalInches.ToString(); 

			return retVal = true;
		}

		/// <summary>
		/// Fills the metric text boxes with data from stroe.
		/// </summary>
		/// <returns><c>true</c>, if metric text boxes with 
		/// data from stroe was filled, <c>false</c> 
		/// otherwise.</returns>
		private bool FillMetricTextBoxesWithDataFromStroe()
		{
			SquareRectangleMetricStruct srsmv = new 
                SquareRectangleMetricStruct();
            
			bool retVal = false;

			srsmv = MetricStore.GetItemAt(recPos);
			txtDepthYard.Text = srsmv.DepthMeters.ToString();
			txtDepthFeet.Text = srsmv.DepthCentimeters.ToString();
			txtDepthInches.Text = srsmv.DepthMillimeters.ToString();
			txtLengthYard.Text = srsmv.LengthMeters.ToString();
			txtLengthFeet.Text = srsmv.LengthCentimeters.ToString();
			txtLengthInches.Text = srsmv.LengthMillimeters.ToString();
			txtWidthYard.Text = srsmv.WidthMeters.ToString();
			txtWidthFeet.Text = srsmv.WidthCentimeters.ToString();
			txtWidthInches.Text = srsmv.WidthMillimeters.ToString();
			txtCubicYards.Text = srsmv.TotalMeters.ToString();
			txtCubicFeet.Text = srsmv.TotalCentimeters.ToString();
			txtCubicInches.Text = srsmv.TotalMillimeters.ToString();

			return retVal = true;
		}

		/// <summary>
		/// Sets the state of the button record.
		/// </summary>
		/// <param name="cnt">Count.</param>
		/// <param name="pos">Position.</param>
		/// <param name="btn">Button.</param>
		private void SetButtonRecordState(int cnt, int pos, string btn)
		{
			const string btnMoveFirst = "First";
			const string btnMovePrev = "Previous";
			const string btnMoveNext = "Next";
			const string btnMoveLast = "Last";

			if (string.Compare(btn, btnMoveFirst) == 0)
			{
				if (cnt < 1)
				{
					btnFirst.Sensitive = false;
					btnNext.Sensitive = false;
					btnPrevious.Sensitive = false;
					btnLast.Sensitive = false;
				}
				else if (cnt > 0)
				{
					btnFirst.Sensitive = false;
					btnNext.Sensitive = true;
					btnPrevious.Sensitive = false;
					btnLast.Sensitive = true;
				}              
			}
			else if (string.Compare(btn, btnMovePrev) == 0)
			{
				if (recPos == 0)
				{
					btnFirst.Sensitive = false;
					btnNext.Sensitive = true;
					btnPrevious.Sensitive = false;
					btnLast.Sensitive = true;
				}
				else if (recPos > 0)
				{
					btnFirst.Sensitive = true;
					btnPrevious.Sensitive = true;
					btnNext.Sensitive = true;
					btnLast.Sensitive = true;
				}
			}
			else if (string.Compare(btn, btnMoveNext) == 0)
			{                
				if (recPos == (cnt - 1))
				{
					btnFirst.Sensitive = true;
					btnPrevious.Sensitive = true;
					btnNext.Sensitive = false;
					btnLast.Sensitive = false;
				}
				if ((cnt - 1) > recPos)
				{
					btnFirst.Sensitive = true;
					btnPrevious.Sensitive = true;
					btnNext.Sensitive = true;
					btnLast.Sensitive = true;
				}
			}
			else if (string.Compare(btn, btnMoveLast) == 0)
			{
				if (cnt < 1)
				{
					btnFirst.Sensitive = false;
					btnNext.Sensitive = false;
					btnPrevious.Sensitive = false;
					btnLast.Sensitive = false; 
				}

				if (recPos == (cnt - 1) && cnt > 0)
				{
					btnFirst.Sensitive = true;
					btnPrevious.Sensitive = true;
					btnNext.Sensitive = false;
					btnLast.Sensitive = false;
				}

				if (recPos < (cnt - 1) && cnt > 0)
				{
					btnFirst.Sensitive = true;
					btnPrevious.Sensitive = true;
					btnNext.Sensitive = true;
					btnLast.Sensitive = true;
				}

//                if (recPos == (cnt - 1) && cnt == 0)
//				{
//					btnFirst.Sensitive = false;
//					btnPrevious.Sensitive = false;
//					btnNext.Sensitive = false;
//					btnLast.Sensitive = false;
//				}
			}
		}

		#endregion DISPLAY STORE DATA
	}
}