//  
//  WriteSongPathsCollectionToFile.cs
//  
//  Author:
//       art2m <art2m@chartermi.net>
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


/// <summary>
/// Class -- WriteSongPathsCollectionToFile.cs
/// 
/// Write all songs from SongPathsCollection.cs to
/// a file. So that if the user does not add or delete any songs
/// it will be faster then reading each song from the music directory.
/// </summary>
using System;
using System.IO;
using System.Text;

namespace MusicManager
{
	public class WriteSongPathsCollectionToFile
	{
		private string methodName = null;
		private string errMsg = null;
		private string className = "WriteSongPathsCollectionToFile";
        
		public WriteSongPathsCollectionToFile ()
		{
		} //End consturctor
        
		public bool CreateDirectoryAndFileForWrite ()
		{
			bool retVal = false;
			bool val = false;
			
            
			methodName = "public bool WriteSongsToFile";		
            
			string dirPath = null;
			val = CreateMusicManagerDirectory (ref dirPath);
            
			//if directory does not exist and failed to be created
			//exit without createing songPathCollection file.
			if (!val) {
				return retVal;
			}             
            
			string filePath = null;
			
			val = CreateSongPathCollectionFile (dirPath, ref filePath);
            
			if (val) 
				val = this.ShowHiddenFile (filePath);
           
            
			if (val) 
				val = this.ShowHiddenDirectory (dirPath);
           
            
			if (val) 
				retVal = WriteSongsToFile (filePath);   
           
            
			val = this.HideFile (filePath);
            
			if (val) 
				val = this.HideDirectory (dirPath);
            
			retVal = val;
			return retVal;
                
		} //End Method
        
		/// <summary>
		/// Method -- private bool MakeSongFileDirectory()
		/// 
		/// Create the directory for all data produced by
		/// Music Manager program.
		/// </summary>
		/// <returns>
		/// The song file directory.
		/// </returns>
		private bool CreateMusicManagerDirectory (ref string dirPath)
		{
			bool retVal = false;
			MyMessages myMsg = null;
			DirectoryInfo di = null;
            
			try {				
				myMsg = new MyMessages ();
                   
				string dirName = UserEnviormentInfo.GetProgramDataDirectoryName;
                                   
				dirPath = Path.Combine (
                    UserEnviormentInfo.UserHomeDirectoryPath, dirName);		
                   
				if (Directory.Exists (dirPath)) {
					retVal = true;
				} else {
					di = Directory.CreateDirectory (dirPath);  
					if (di.Exists) {
						retVal = true;   
					} else {
						errMsg = "Unable to create directory to hold " +
                                                                "song file.";
						myMsg.BuildErrorString (className, methodName, 
                                                                errMsg, "");
						return retVal;
					}                
				}             
				//all Ok          
				return retVal;
			} catch (UnauthorizedAccessException ex) {
				errMsg = "You do not have required permission to create" +
                                                            " this direcory";
				myMsg.BuildErrorString (className, methodName, errMsg,
                                                        ex.Message.ToString ());
				return retVal;
			} catch (IOException ex) {
				errMsg = "Encountered error while attempting to create" +
                 " directory for song data.";
				myMsg.BuildErrorString (className, methodName, errMsg,
                                                        ex.Message.ToString ());
				return retVal;
			}
            
		} //End Method
        
        
		/// <summary>
		/// Method -- private bool CreateSongPathCollectionFile(stirng dirPath,
		/// ref string filePath)
		/// 
		/// Checks to see if the file exists if not it creates the file.
		/// </summary>
		/// <returns>
		/// The song path collection file.
		/// </returns>
		/// <param name='dirPath'>
		/// If set to <c>true</c> dir path.
		/// </param>
		/// <param name='filePath'>
		/// If set to <c>true</c> file path.
		/// </param>
		private bool CreateSongPathCollectionFile (string dirPath,
                                                  ref string filePath)
		{
			bool retVal = false;
			MyMessages myMsg = null;
            
            
			try {
                
				methodName = "private bool CreateSongPathCollectionFile" +
                 " string dirPath, ref string filePath";
                
				myMsg = new MyMessages ();
                    
				filePath = Path.Combine (dirPath, 
                            UserEnviormentInfo.GetSongPathCollectionFileName);   
                   
				if (!File.Exists (filePath)) {
					File.Create (filePath);
				}  
                   
				//All ok
				retVal = true;
				return retVal;
			} catch (UnauthorizedAccessException ex) {
				errMsg = "You do not have required permission to create" +
                                                            " this direcory";
				myMsg.BuildErrorString (className, methodName, errMsg,
                                                        ex.Message.ToString ()); 
				return retVal;
			} catch (IOException ex) {
				errMsg = "Encountered error while attempting to create" +
                 " the file to write song path data to.";
				myMsg.BuildErrorString (className, methodName, errMsg,
                                                        ex.Message.ToString ());  
				return retVal;
			}
            
		} //End Method
        
        
		/// <summary>
		/// Method -- private bool HideDirectory(string dirPath)
		/// 
		/// Check to see if the directory attributes to see if the 
		/// directory is hidden. If it is not the set the hidden attribute.
		/// </summary>
		/// <returns>
		/// The directory.
		/// </returns>
		/// <param name='dirPath'>
		/// If set to <c>true</c> dir path.
		/// </param>
		private bool HideDirectory (string dirPath)
		{
			bool retVal = false;
			MyMessages myMsg = null;
           
			try {
				methodName = "private bool HideDirectory(string dirPath)";
                
				myMsg = new MyMessages ();
                
				DirectoryInfo di = new DirectoryInfo (dirPath);
				FileAttributes atts = di.Attributes;
                   
				if ((atts & FileAttributes.Hidden) != FileAttributes.Hidden) {
					atts |= FileAttributes.Hidden;
				}
                   
				//All ok
				retVal = true;
				return retVal;
			} catch (IOException ex) {
				errMsg = "Encountered error while accessing directory";
				myMsg.BuildErrorString (className, methodName, errMsg,
                                       ex.Message.ToString ());
				return retVal;
			}
            
		} //End Method 
        
        
		/// <summary>
		/// Method -- private bool ShowHiddenDirectory(string dirPath) 
		/// 
		/// Check the MusicManager directory attributes to see if the
		/// directory hidden attribute is set. If they are then remove the 
		/// hidden flag so the directory is visible. and now able to write
		/// to the file in the directory.
		/// </summary>
		/// <returns>
		/// The hidden directory.
		/// </returns>
		/// <param name='dirPath'>
		/// If set to <c>true</c> dir path.
		/// </param>
		private bool ShowHiddenDirectory (string dirPath)
		{
			bool retVal = false;
			MyMessages myMsg = null;
            
			try {
				methodName = "private bool ShowHiddenDirectory(string dirPath";
             
				myMsg = new MyMessages ();
             
				DirectoryInfo di = new DirectoryInfo (dirPath);
             
				FileAttributes atts = di.Attributes;
             
				if ((atts & FileAttributes.Hidden) == FileAttributes.Hidden) {
					atts &= ~FileAttributes.Hidden;
				}
             
             
				//All ok
				retVal = true;
				return retVal;
			} catch (IOException ex) {
				errMsg = "Encountered error while accessing directory";
				myMsg.BuildErrorString (className, methodName, errMsg,
                                       ex.Message.ToString ());
				return retVal;
			}
            
		} //End Method
        
        
		/// <summary>
		/// Method -- private bool HideFile(string filePath)
		/// 
		/// if the file hidden file attributes are not set. Then set them so
		/// the file is now hidden.
		/// </summary>
		/// <returns>
		/// The file.
		/// </returns>
		/// <param name='filePath'>
		/// If set to <c>true</c> file path.
		/// </param>
		private bool HideFile (string filePath)
		{
			bool retVal = false;
			MyMessages myMsg = null;
            
			try {
				methodName = "private bool HideFile(string filepath)";
             
				myMsg = new MyMessages ();
             
				FileInfo fi = new FileInfo (filePath);
             
				FileAttributes atts = fi.Attributes;
             
				if ((atts & FileAttributes.Hidden) != FileAttributes.Hidden) {
					atts |= FileAttributes.Hidden;
				}
             
				//All ok
				retVal = true;
				return retVal;
			} catch (IOException ex) {
				errMsg = "Encountered error while accessing file.";
				myMsg.BuildErrorString (className, methodName, errMsg,
                                       ex.Message.ToString ());
				return retVal;  
			}
		} //End Method        
        
        
		/// <summary>
		/// Method -- private bool ShowHiddenFile(string filePath)
		/// 
		/// Shows the hidden file.
		/// </summary>
		/// <returns>
		/// The hidden file.
		/// </returns>
		/// <param name='filePath'>
		/// If set to <c>true</c> file path.
		/// </param>
		private bool ShowHiddenFile (string filePath)
		{
			bool retVal = false;
			MyMessages myMsg = new MyMessages ();
            
			try {
				methodName = "private bool ShowHiddenFile(string filePath)";
             
				myMsg = new MyMessages ();
             
				FileInfo fi = new FileInfo (filePath);
             
				FileAttributes atts = fi.Attributes;
             
				if ((atts & FileAttributes.Hidden) == FileAttributes.Hidden) {
					atts &= ~FileAttributes.Hidden;
				}
				//All ok
				retVal = true;
				return retVal;
			} catch (IOException ex) {
				errMsg = "Encountered error while accessing file.";
				myMsg.BuildErrorString (className, methodName, errMsg,
                                       ex.Message.ToString ());
				return retVal;  
			}
            
		} //End Method
        
		private bool WriteSongsToFile (string filePath)
		{
			bool retVal = false;
			MyMessages myMsg = null;
            
			try {
				methodName = "private bool WriteSongsToFile(string dirPath," +
                                                            " string filePath)";
				myMsg = new MyMessages ();
                   
				FileStream fs = File.OpenWrite (filePath);
				BinaryWriter sngPColl = new BinaryWriter (fs);
                   
				int cnt = SongPathsCollection.ItemsCount ();
                   
				//Check to see if the collection is empty.
				if (cnt < 1) {
					errMsg = "There are no records to write to file." +
                                                " Canceling write operation.";
					myMsg.BuildErrorString (className, methodName, errMsg, "");
					return retVal;
				}           
                   
				string[] collPaths = SongPathsCollection.GetAllItems ();
				//Put SongPathCollection.Count into file
				sngPColl.Write (cnt);
                   
				for (int i = 0; i < cnt; i++) {
					sngPColl.Write (collPaths [i]);  
				}            
          
				//All Ok
				retVal = true;            
				return retVal;
			} catch (IndexOutOfRangeException ex) {
				errMsg = "Encountered error while writing songs to file.";
				myMsg.BuildErrorString (className, methodName, errMsg,
                                        ex.Message.ToString ());
				return retVal;
			} catch (IOException ex) {
				errMsg = "Encountered error while writing songs to file.";
				myMsg.BuildErrorString (className, methodName, errMsg,
                                        ex.Message.ToString ());
				return retVal;   
			}
            
		} //End Method
        
	} //End class WriteSongPathsCollectionToFile
    
} //End MusicManager

