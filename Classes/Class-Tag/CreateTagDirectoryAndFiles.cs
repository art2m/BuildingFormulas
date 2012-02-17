//  
//  clsCreateTagDirectoryAndFiles.cs
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

namespace MusicManager
{
	public  class CreateTagDirectoryAndFiles
	{
		
		private  string methodName = "";
		private  string errMsg = "";
		private const string className = "";
		//private  bool bolInCorrectTag = false;
		//private  bool bolCorrectTag = false;
		
		
	
		
		#region CreateDirectory & File Set Attributes
		
		public  bool CreateTagFolderAndFiles (int intTag)
		{
			bool retVal = false;
			string strDirPath = "";
			
			try {
				methodName = "private  bool CreateTagFolderAndFiles(" +
                                                              " int intTag)";
				
				//true if directory created and hid false if not.
				retVal = CreateSongTagDirectory (ref strDirPath);
				
				if (!retVal)
					return retVal; //Returned error so exist and return false.
				
				if (String.IsNullOrEmpty (strDirPath))
					return retVal; //Return false dirpath not created.							
				
				//Create File CorrectTags.dat Return is true if created 
				//else false.
				if (intTag == 1) {	
					retVal = CreateCorrectSongTagsFile (strDirPath);						
					if (!retVal)
						return retVal; //File creation failed.
					
					//file creation succeded Set bolCorrectTag true.					
					//bolCorrectTag = true; //set true write to 
					//CorrectTags.dat file. 
					//bolInCorrectTag = false; 
					//do not write to IncorrectTags.dat					
					//Create file IncorrectTags.dat Return is true if 
					//created else false.	
				} else if (intTag == 2) { 
					retVal = CreateInCorrectSongTagsFile (strDirPath);
					
					if (!retVal)
						return retVal; //File creation failed.
					
					//File creation succeded Set bolIncorrectTag true.
					//bolInCorrectTag = true; //Set true write to IncorrectTags.dat
					//bolCorrectTag = false; //Do not write to CorrectTags.dat
				
					//Incorrect value passed in  return false;
				} else {
					return retVal;
				}
				
				//if all ok return true.
				return retVal;
			} catch 
			(IOException ex) {
				errMsg = "Failed to write tag information to file.";
				MyMessages clsMsg = new MyMessages ();
				clsMsg.BuildErrorString (className, methodName, errMsg, 
                                                    ex.Message.ToString ());
				return retVal;
			}		
			
		} //End Method
		
		
		/// <summary>
		/// Method -- private  bool CreateWriteSongTagsDirectory()
		/// 
		/// Creates the MusicManagerProg Directory.
		/// </summary>
		/// <returns>
		/// return true if successful false if not.
		/// </returns>
		private  bool CreateSongTagDirectory (ref string strDirPath)
		{
			bool retVal = false;
			
			
			try {
				methodName = "private bool CreateSongTagDirectory()";	
				
				///Get user home directory path.		
				string strUserHome = UserEnviormentInfo.UserHomeDirectoryPath;
							
				
				//Get the name of the Folder to hold the WriteData in.
				string strFolder = 
                            UserEnviormentInfo.GetIncorrectCorrectTagFolderName;
					
				strDirPath = System.IO.Path.Combine (strUserHome, strFolder);
					
				bool bolExists = Directory.Exists (strDirPath);
				//Create Directory if it does not exist.
				if (!bolExists) {
					Directory.CreateDirectory (strDirPath);
				}
				
				retVal = HideMusicManageProgDirectory (strDirPath);
				
				//All ok				
				return retVal;
			} catch (IOException ex) {
				errMsg = "Unable to create MusicManagerProg " +
                                                  " directory " + strDirPath;
				MyMessages clsMsg = new MyMessages ();
				clsMsg .BuildErrorString (className, methodName, errMsg, 
                                                    ex.Message.ToString ());
				return retVal;
			} catch (UnauthorizedAccessException ex) {
				errMsg = "You do not have nessicary permissions to acces " +
                                            " this directory. " + strDirPath;	
				MyMessages clsMsg = new MyMessages ();
				clsMsg.BuildErrorString (className, methodName, errMsg, 
                                                    ex.Message.ToString ());
				return retVal;
			}
			
			
		} //End Method 
		
		
		/// <summary>
		/// Method -- private  bool CreateInCorrectSongTagsFile(string 
		///                                                         strDirPath)
		/// 
		/// Create the file InCorrectTags.dat This file will hold a list 
		/// of song paths
		/// that have missing tag information or corrupt tags.
		/// </summary>
		/// <returns>
		/// true if file created and hidden else false.
		/// </returns>
		/// <param name='strDirPath'>
		/// If true file created and set to hidden file. else false.
		/// </param>
		private  bool CreateInCorrectSongTagsFile (string strDirPath)
		{
			bool retVal = false;
			
			string strFilePath = "";
			
			try {
				methodName = "private bool CreateInCorrectSongTagsFile(string" +
                                                                " strDirPath)";
				
				string strFileName = UserEnviormentInfo.GetInCorrectFileName;
				
				strFilePath = System.IO.Path.Combine (strDirPath, strFileName);
				
				File.Create (strFilePath);	
				
				retVal = HideFileInCorrectTags (strFilePath);			
				
				return retVal;
			} catch (IOException ex) {
				errMsg = "Encountered erorr while creating. " + strFilePath;
				MyMessages clsMsg = new MyMessages ();
				clsMsg.BuildErrorString (className, methodName, errMsg, 
                                                       ex.Message.ToString ());
				return retVal;
			}
			
		} //End Method
		
		
		
		/// <summary>
		/// Method -- private  bool CreateCorrectSongTagsFile(string strDirPath)
		/// 
		/// Create the file CorrectTags.dat This file will hold a list of 
		/// song paths
		/// that have Correct tag information.
		/// </summary>
		/// <returns>
		/// true if file created and hidden false if not.
		/// </returns>
		/// <param name='strDirPath'>
		/// If set to <c>true</c> string dir path.
		/// </param>
		private  bool CreateCorrectSongTagsFile (string strDirPath)
		{
			bool retVal = false;
			string strFilePath = "";
			
			try {
				methodName = "private bool CreateCorrectSongTagsFile()";
				
				string strFileName = UserEnviormentInfo.GetCorrectFileName;
				
				strFilePath = System.IO.Path.Combine (strDirPath, strFileName);
				
				File.Create (strFilePath);
				
				retVal = HideFileCorrectTags (strFilePath);
				
				return retVal;
			} catch (IOException ex) {
				errMsg = "Encountered erorr while creating. " + strFilePath;
				MyMessages clsMsg = new MyMessages ();
				clsMsg.BuildErrorString (className, methodName, errMsg, 
                                                    ex.Message.ToString ());
				return retVal;
			}
			
		} //End Method
		
		
		
		/// <summary>
		/// Method -- private  bool HideMusicManageProgDirectory(string 
		///                                                         strDirPath)
		/// 
		/// Sets the Hidden Attributes to hide on MusicManagerProg directory.
		/// </summary>
		/// <returns>
		/// returns true on success false if fail.
		/// </returns>
		/// <param name='strDirPath'>
		/// If set to <c>true</c> string dir path.
		/// </param>
		private  bool HideMusicManageProgDirectory (string strDirPath)
		{
			bool retVal = false;
			
			try {
				methodName = "private bool HideMusicManageProgDirectory(" +
                                                        " string strDirPath)";
				
				DirectoryInfo dirInf = new DirectoryInfo (strDirPath);
				
				//If Folder not hidden then hide.
				if ((dirInf.Attributes & FileAttributes.Hidden) != 
                                                        FileAttributes.Hidden) {   
					//Add Hidden flag    
					dirInf.Attributes |= FileAttributes.Hidden;    
				}	
				
				//All ok
				retVal = true;
				return retVal;
			} catch (DirectoryNotFoundException ex) {
				errMsg = "Invalid folder path. " + strDirPath;
				MyMessages clsMsg = new MyMessages ();
				clsMsg.BuildErrorString (className, methodName, errMsg, 
                                                    ex.Message.ToString ());
				return retVal;
			}		
			
			
		} //End Method 
		
		/// <summary>
		/// Method -- private  bool HideFileInCorrectTags(string strFilePath)
		/// 
		/// Sets the Hidden Attributes to hide on InCorrectTags.dat file.
		/// </summary>
		/// <returns>
		/// true if hid false if failed.
		/// </returns>
		/// <param name='strFilePath'>
		/// If set to <c>true</c> string file path.
		/// </param>
		private  bool HideFileInCorrectTags (string strFilePath)
		{
			bool retVal = false;
			
			try {
				
				methodName = "private bool HideFileInCorrectTags(" +
                                                        " string strFilePath)";
				
				FileAttributes att = File.GetAttributes (strFilePath);
				// Hide the file.
				if ((att & FileAttributes.Hidden) != FileAttributes.Hidden) {
					File.SetAttributes (strFilePath, File.GetAttributes 
                                        (strFilePath) | FileAttributes.Hidden);
				}            
				
				//All ok
				retVal = true;
				return retVal;
			} catch (IOException ex) {
				errMsg = "File error while setting file hidden attributes " +
                                                        "on. " + strFilePath;
				MyMessages clsMsg = new MyMessages ();
				clsMsg.BuildErrorString (className, methodName, errMsg, 
                                                    ex.Message.ToString ());
				return retVal;
			}
			
		} //End Method
		
		
		/// <summary>
		/// Method -- private  bool HideFileCorrectTags(string strFilePath)
		/// 
		/// Sets hide attribute for file correctTags.dat
		/// </summary>
		/// <returns>
		/// The file correct tags.
		/// </returns>
		/// true if file hid false if failed.
		/// If set to <c>true</c> string file path.
		/// </param>
		private  bool HideFileCorrectTags (string strFilePath)
		{
			bool retVal = false;
			
			try {
				methodName = "private bool HideFileCorrectTags(" +
                                                        " string strFilePath)";
				
				FileAttributes att = File.GetAttributes (strFilePath);
				//Hide the file
				if ((att & FileAttributes.Hidden) != FileAttributes.Hidden) {
					File.SetAttributes (strFilePath, File.GetAttributes (
                                        strFilePath) | FileAttributes.Hidden);
				}
				
				//All ok
				retVal = true;
				return retVal;
			} catch (IOException ex) {
				errMsg = "File error while setting file hidden attributes" +
                                                       " on. " + strFilePath;
				MyMessages clsMsg = new MyMessages ();
				clsMsg.BuildErrorString (className, methodName, errMsg, 
                                                    ex.Message.ToString ());
				return retVal;
			}
		} //End Method 
		
#endregion CreateDirectory & File Set Attributes
		
		
		
	} //End class clsCreateTagDirectoryAndFiles
	
} //End namespace MusicManager

