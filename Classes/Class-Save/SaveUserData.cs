//
//  SaveUserData.cs
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
using System;
using System.IO;
using Gtk;

namespace BuildingFormulas
{
	public class SaveUserData
	{
        
		public SaveUserData()
		{
            
		}

		public string  SaveUsersFormData(string caption)
		{
			FileChooserDialog fcd = null;
			const string homePath = "~/";
			string savedPath = null;


			fcd = new FileChooserDialog(caption, null, FileChooserAction.Save,
				"Cancel", ResponseType.Cancel,
				"Ok", ResponseType.Accept);
//				caption, 
//				null, 
//				FileChooserAction.save, 
//				"Cancel", 
//				ResponseType.Cancel, 
//				"Open", 
//				ResponseType.Accept);

			fcd.DefaultResponse = ResponseType.Accept;

			// Add starting folder to filechooserdialog
			fcd.SetCurrentFolder(homePath);

			if (fcd.Run() == (int)ResponseType.Accept)
			{
				savedPath = fcd.Filename.ToString();
				fcd.Destroy();
				return savedPath; 

				// Validate toplevel music directory.
				//clsTmd.ValidateMusicDirectory (strMPath);  
			}
			else
			{ 
				// user did not make a selection.
				// just fall threw no file selected or user selected cancel.
				fcd.Destroy();
				return savedPath;
			}
		}
	}
}

