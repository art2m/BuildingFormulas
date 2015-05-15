//
//  InputDialog.cs
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
	using Gtk;

	/// <summary>
	/// Input dialog.
	/// </summary>
	public partial class InputDialog : Gtk.Dialog
	{
		/// <summary>
		/// The name of the file.
		/// </summary>
		private string fileName = string.Empty;

		/// <summary>
		/// Initializes a new instance of the 
		/// <see cref="BuildingFormulas.InputDialog"/> class.
		/// </summary>
		public InputDialog()
		{
			this.Build();
		}

		/// <summary>
		/// Raises the button ok clicked event.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">Instance containing the event data.</param>
		protected void OnBtnOkClicked(object sender, EventArgs e)
		{
			MyMessages myMsg = new MyMessages();


//			string infoMsg = "You must enter a file name or select cancel.";
//
//			if (string.IsNullOrEmpty(txtFileName.text))
//			{
//				myMsg.ShowInformationMessage(infoMsg);
//			}
//            else
//            {
//                txtFileName.Text = txtFileName.Text.Trim();
//
//                DataEntry_GlobalVariables.InputFileNameUserEntered = 
//                    txtFileName.Text;
//            }
//			
		}

		/// <summary>
		/// Raises the button cancel clicked event.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">Instance containing the event data.</param>
		protected void OnBtnCancelClicked(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}
	}
}

