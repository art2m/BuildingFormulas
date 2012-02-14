//  
//  clsFileBrowser.cs
//  
//  Author:
//       art2m <art2m@live.com>
// 
//  Copyright (c) 2011 art2m
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


/*********************************************************************************
 * clsFieBrowser
 * This class is used to display the directory browser so as the user can select
 * what directory his music is located in. It then checks to see if it is a 
 * valid directory and if the music directory selected has music files in it.
 *  
 * ******************************************************************************/
using System;
using System.IO;

using Gtk;

namespace MusicManager
{
	public class DisplayFileBrowser
	{
       
		private string methodName = null;
		private string errMsg = null;
		private string className = "clsFileBrowser";
		
		public DisplayFileBrowser ()
		{
		} // End Constuctor
        
		
#region Display Directory Browser Start At Personal Directory
		
		
		/// <summary>
		/// Method -- public void SelectToplevelMusicDirectory
		/// 
		/// Display FileChooser so user can Selects the toplevel music 
		/// directory. Then verify that the user has selected a directory 
		/// conaining .mp3 files.
		/// </summary>
		public void SelectToplevelMusicDirectory ()
		{
            
            
			FileChooserDialog fcd = null;			
			string strMsg = "Select Music Directory.";
			string strPath = null;
			string strMPath = null;			
			
			try {
				ValidateUserMusicDirectory clsTmd = new 
                    ValidateUserMusicDirectory ();
                
				methodName = "public void SelectToplevelMusicDirectory ()";               
 
				strPath = UserEnviormentInfo.UserName;
 
				fcd = new FileChooserDialog (strMsg, null, 
                    FileChooserAction.SelectFolder, 
                    "Cancel", ResponseType.Cancel,
                    "Open", ResponseType.Accept);
                
				fcd.DefaultResponse = ResponseType.Accept;
				//Add starting folder to filechooserdialog
				fcd.SetCurrentFolder (strPath);
 
				if (fcd.Run () == (int)ResponseType.Accept) {
					strMPath = fcd.CurrentFolder.ToString ();
					fcd.Destroy ();
					//Validate toplevel music directory.
					clsTmd.ValidateMusicDirectory (strMPath);           
 
				} else { //user did not make a selection.
					//just fall threw no file selected or user selected cancel.
					fcd.Destroy ();
				}
			} catch (System.IO.IOException ex) {
				errMsg = "Encountered error while selecting Music " +
                  "  directory. ";  
                
				MyMessages clsMsg = new MyMessages ();
				clsMsg.BuildErrorString (className, methodName, errMsg, 
                    ex.Message.ToString ());                
			}			
		} //End Method
		
		
	
#endregion Display Directory Browser Start At Personal Directory	
	
		
	} //End class clsFileBrowser
	
} //End Namespace MusicManager

