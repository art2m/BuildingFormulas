//
//  Printing.cs
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
	using System.IO;
	using System.Diagnostics;

	/// <summary>
	/// Printing.
	/// </summary>
	public class Printing
	{
		private const string ThisClassName = "public class Printing";

		/// <summary>
		/// Initializes a new instance of the 
		/// <see cref="BuildingFormulas.Printing"/> class.
		/// </summary>
		public Printing()
		{
		}

		/// <summary>
		/// Prints the document file.
		/// </summary>
		/// <param name="filePath">File path of document to be printed.</param>
		public void PrintDocumentFile(string filePath)
		{
			bool retVal = false;
			bool returnVal = false;
			string errMsg = string.Empty;
			string dat = string.Empty;

			//System.Diagnostics.ProcessStartInfo psi = new 
			//System.Diagnostics.ProcessStartInfo();
			Process proc = new Process();

			const string MethodName = 
				"public void PrintDocumentFile(string filePath)";			

			MyMessages myMsg = new MyMessages();

			try
			{
				returnVal = File.Exists(filePath);

				if (!returnVal)
				{
					errMsg = "File path for file to be printed is invalid." +
					" Exit printing.";
					myMsg.BuildErrorString(ThisClassName, MethodName, errMsg,
						dat);
					return;
				}

				proc.StartInfo.FileName = filePath;
				proc.StartInfo.UseShellExecute = false;
				//proc.RedirectStandardOutput = true;
                
				proc.StartInfo.Arguments = "lpr";
				//proc.Arguments = "test";
//				System.Diagnostics.Process p = 
//					System.Diagnostics.Process.Start(proc);              
				//p.WaitForExit();  
				retVal = proc.Start();

				//retVal = p.ExitCode;

				if (retVal == false)
				{
					errMsg = "Error unable to print. Is your printer on." +
					" Is the linux package lpr installed.";
					myMsg.BuildErrorString(ThisClassName, MethodName, errMsg,
						dat);
					return;
				}

			}
			catch (ArgumentNullException ex)
			{
				errMsg = "File path for file to be printed is invalid." +
				" Exit printing.";
				myMsg.BuildErrorString(ThisClassName, MethodName, errMsg,
					ex.ToString());
				return; 
			}
			catch (InvalidOperationException ex)
			{
				errMsg = "File path for file to be printed is invalid." +
				" Exit printing.";
				myMsg.BuildErrorString(ThisClassName, MethodName, errMsg,
					ex.ToString());
				return; 
			}			
		}

	}
}

