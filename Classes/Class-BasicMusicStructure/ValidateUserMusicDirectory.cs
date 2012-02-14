//  
//  clsToplevelMusicDirectory.cs
//  
//  Author:
//       art2m <art2m@live.com>
// 
//  Copyright (c) 2012 art2m
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
using System.Diagnostics;
using System.Windows.Forms;

namespace MusicManager
{
	public class ValidateUserMusicDirectory
	{
		
		private MyMessages clsMsg = new MyMessages ();
		string methodName = "";
		string errMsg = "";
		string className = "clsToplevelMusicDirectory";
		//Get the number of folder levels to the
		//music files. set to one to account for 
		//the toplevel music directory.
		int intFolderCnt = 1;
		
		public ValidateUserMusicDirectory ()
		{
		} //End Constructor
		
		
		#region Toplevel Music directory
		
	
		/// <summary>
		/// Method -- public void ValidateMusicDirectory (string strMDir)
		/// 
		/// Validates the music directory.
		/// Make sure that the folder the user selected does contain music.
		/// </summary>
		/// <param name='strMDir'>
		/// String M dir.
		/// </param>
		public void ValidateMusicDirectory (string strMDir)
		{
			bool retVal = false;		
			
			
			try {
				methodName = "public void ValidateMusicDirectory (string strMDir)";
				errMsg = "Encountered error while checking directory for .mp3 file. ";
	 			 	
				foreach (string strDir in Directory.GetDirectories (strMDir)) {
					//Do notloop no more already found .mp3 music file.
					if (!UserEnviormentInfo.ToplevelMusicDirectoryFound) {
						retVal = CheckForMusicFile (strDir);
	 			 			
						if (retVal) {	
							//Set to true found toplevel music dir with music files.
							UserEnviormentInfo.ToplevelMusicDirectoryFound = true;
											
							Application.DoEvents ();							
							//MusicPathStructure.NumberOfFoldersLevelsToSongFiles = intFolderCnt;
							//Console.WriteLine (intFolderCnt.ToString ());
							break;
	 			 				  					
						} else { //Continue to loop no directory with music found 
							ValidateMusicDirectory (strDir);
						}
	 			 			
					} //End if(!bolMp3)
	 			 		
				} //End loop foreach (string strDir in Directory.GetDirectories (strMDir))
			} catch (DirectoryNotFoundException ex) {
				clsMsg.BuildErrorString (className, methodName, errMsg, ex.Message.ToString ()); 	
			} catch (PathTooLongException ex) {
				clsMsg.BuildErrorString (className, methodName, errMsg, ex.Message.ToString ()); 		
			}
			
			
		} //End Method public void ValidateMusicDirectory(string strMDir)
		
		
		
		
		/// <summary>
		/// Method -- public bool CheckForVariousArtistFolder (string strMDir)
		/// 
		/// Checks for various artist folder.
		/// </summary>
		/// <returns>
		/// The for various artist folder.
		/// </returns>
		/// <param name='strMDir'>
		/// return true if found false if not.
		/// </param>
		public bool CheckForVariousArtistFolder (string strMDir)
		{
			bool retVal = false;		
			int intPos = 0;
			const string strVarious = "Various";
			int intVLen = strVarious.Length;
			string strPath = "";
			
			
			try {
				methodName = "public void ValidateMusicDirectory (string strMDir)";
				errMsg = "Encountered error while checking directory for .mp3 file. ";
 			 	
				foreach (string strDir in Directory.GetDirectories (strMDir)) {
					strPath = strPath.Trim ();		
					intPos = strPath.IndexOf (strVarious, StringComparison.OrdinalIgnoreCase);
					
					//Possible Various Artist folder found. Various is contained in the
					//folder name.
					if (intPos > 0) {
						
						//Check to see if the string is only Various and not 
						//Various-Rock or some other combination. Looking for an Artist
						//Folder that only says various.
						int intLen = strPath.Length;
						if (intLen == intVLen) {
							//Found Folder various Artist.
							Application.DoEvents ();
							//MusicPathStructure.VariousArtistFolder = true;
							retVal = true;
							return retVal;							
						}
					} 			 		
					
				} //End loop foreach (string strPath in Directory.GetDirectories (strMDir))
				
				//No various artist folder found.
				return retVal;
			} catch (DirectoryNotFoundException ex) {
				clsMsg.BuildErrorString (className, methodName, errMsg, ex.Message.ToString ()); 
				return retVal;
			} catch (PathTooLongException ex) {
				clsMsg.BuildErrorString (className, methodName, errMsg, ex.Message.ToString ()); 	
				return retVal;
			}
			
			
		} //End Method public bool CheckForVariousArtistFolder (string strMDir)
		
		/// <summary>
		/// Method -- private bool CheckForMusicFile (string strDirPath)
		/// 
		/// Check to see if there Directory path passed in 
		/// Has any .mp3 files contained in it or not. 
		/// There may be other types music, data or image 
		/// files but all this Method is concerend with is that there are .mp3 files 
		/// in this directory. or there is not any .mp3 files in this directory.
		/// </summary>
		/// <returns>
		/// false if no files found or no mp3 files found
		/// true if .mp3 files found.
		/// </returns>
		/// <param name='strDirPath'>
		/// If set to <c>true</c> string M path.
		/// </param>
		private bool CheckForMusicFile (string strDirPath)
		{
			bool retVal = false;
			FileInfo fInfo = null;
						
			try {
				methodName = "public bool CheckForMusicFile (string strDirPath)";
				errMsg = "Encountered error while checking directory for .mp3 files. ";
				
				if (!Directory.Exists (strDirPath)) {
					throw new DirectoryNotFoundException ("Directory not found error.  " + strDirPath);
				}
				
				intFolderCnt = intFolderCnt + 1;
				string[] strFiles = Directory.GetFiles (strDirPath);
				
				Console.WriteLine (strDirPath);
				Console.WriteLine (strFiles.Length);
				//Check to see if there are any files in the array
				//if there is not then return false. 
				if (strFiles.Length < 1) {
					return false;
				}
				
				foreach (string strFile in strFiles) {
					fInfo = new FileInfo (strFile);
					Console.WriteLine (fInfo.Extension);
					
					//Check to see if any of the files in the directory are .mp3 files
					//if there is return true. 
					if (string.Compare (fInfo.Extension, ".mp3", true) == 0) {
						retVal = true;
						return retVal; // music file found retrun true.
					}
					return retVal;
					
				}			
				
			} catch (FileNotFoundException ex) {
				clsMsg.BuildErrorString (className, methodName, errMsg, ex.Message.ToString ());
				return retVal;	
			} catch (PathTooLongException ex) {
				clsMsg.BuildErrorString (className, methodName, errMsg, ex.Message.ToString ());
				return retVal;	
			}
			
			return retVal;
		} //End Method private bool CheckForMusicFile(string strDirPath)
		
		
#endregion //Toplevel Music directory
		
		
		
	} //End class clsVAlidateToplevelMusicDirectory
	
} //End namespace MusicManager

