
//  
//  clsInsertUnderscore.cs
//  
//  Author:
//       art2m <${AuthorEmail}>
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


/// <summary>
/// clsInsertUnderscore
/// 
/// This class removes the space character from the path name of a directory 
/// or the path name of a song. It then replaces the space that was removed
/// with an underscore character.
/// </summary>
/// 
using System;
using System.IO;
using System.Text;

namespace MusicManager
{
	public class InsertUnderscore
	{
		
		private string methodName = "";
		private string errMsg = "";
		private const string className = "clsInsertUnderscore";
		
		
		//Constructor
		public InsertUnderscore ()
		{
		}
		
		
		/// <summary>
		/// Method -- public bool BeginIterateMusicDirectories()
		/// 
		/// Begins the iterate music directories.
		/// Check Music Directory Exists.
		/// </summary>
		/// <returns>
		/// bool retVal true if all directories and files have been changed 
		/// false if error encountered and quit before completion.
		/// </returns>
		/// <exception cref='DirectoryNotFoundException'>
		/// Is thrown when part of a file or directory argument cannot be found.
		/// </exception>
		public bool BeginIterateMusicDirectories ()
		{
			bool retVal = false;
			
			try {
				methodName = "public bool BeginIterateMusicDirectories()";
				errMsg = "Encountered error while Iterating Music Directories.";
				
				if (!Directory.Exists (
                                UserEnviormentInfo.UserMusicDirectoryPath)) {
					throw new DirectoryNotFoundException (
                  "  Directory does not exist:  " + 
                                    UserEnviormentInfo.UserMusicDirectoryPath);
				} else {
					//doesn't matter true or false just checking to see if there
					//are files in toplevel music directory.
					retVal = CheckForMp3FilesInDirectory (
                        UserEnviormentInfo.UserMusicDirectoryPath);
                    
                    
					retVal = IterateMusicDirectories_Files (
                                    UserEnviormentInfo.UserMusicDirectoryPath);
					//retVal = true;
					return retVal;
				}
			} catch (DirectoryNotFoundException ex) {
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg, 
                                                    ex.Message.ToString ());
				return retVal;
			} catch (Exception ex) {
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg,
                                                    ex.Message.ToString ());
				return retVal;
			}
			
			
		} //End Method public bool BeginIterateMusicDirectories()
		
		
		private bool IterateMusicDirectories_Files (string musicPath)
		{
			
			bool retVal = false;
            
			return retVal;
			
		}
		
		private bool CheckForMp3FilesInDirectory (string dirPath)
		{            
			bool retVal = false;
            
			string[] sngFiles = null;
            
			sngFiles = Directory.GetFiles (dirPath);
            
			if (sngFiles.Length < 1) {
				return retVal;
			}
            
            
			return retVal;
            
		} //End Method
        
        
        
		/// <summary>
		/// Method -- public string RemoveSpaces(strig strPath)
		/// 
		/// This removes all the spaces fromthe path name of 
		/// the directory, song name or song path. 
		/// </summary>
		/// <returns>
		/// String retVal
		/// </returns>
		/// <param name='strPath'>
		/// String strPath
		/// </param>
		private bool RemoveSpaces (string strPath)
		{
			
			bool retVal = false;
			
			try {
				methodName = "public string RemoveSpaces(string strPath";
				errMsg = "Encountered error while removing " +
                                                 "spaces from path name.";
				
				string[] strTemp = strPath.Split (' ');
				
				ReplaceSpaceWithUnderscore (strTemp);
				
				retVal = true;
				return retVal;
			} catch (InvalidOperationException ex) {
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg, 
                                        ex.Message.ToString ());								
				return retVal;	
			}
			
			
		} //End Method public string RemoveSpaces(string strPath)
		
		
		
		/// <summary>
		/// Method -- private string ReplaceSpaceWithUnderscore
		/// 
		/// This inserts Underscore characters into the path name of the 
		/// directoy, song name or song path replacing the spaces.
		/// </summary>
		/// <returns>
		/// String retVal
		/// </returns>
		/// <param name='strPath'>
		/// String[] strPath
		/// </param>
		private string ReplaceSpaceWithUnderscore (string[] strPath)
		{
			
			string retVal = "";
			
			try {
				methodName = "public string ReplaceSpaceWithUnderscore(" +
                                                        " string[] strPath)";
				errMsg = "Encountered error while inserting Uderscore " +
                                                "character into path string.";
				StringBuilder sb = new StringBuilder ();
				
				foreach (string strTemp in strPath) {
					sb.Append (strTemp).Append ("_");
					
				}
				
				
				retVal = sb.ToString ().TrimEnd (new char[] {'_'});				
				
				//Verify string to be returned 
				//now has no spaces and has underscore instead.
				
				
				return retVal;
			} catch (IndexOutOfRangeException ex) {
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, 
                                        errMsg, ex.Message.ToString ());
				return retVal;
			} catch (InvalidOperationException ex) {
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, 
                                        errMsg, ex.Message.ToString ());
				return retVal;  
			}
			
			
		} //End Method private string InsertUnderscore(string[] strPath)
		
	} //End class clsInsertUnderscore
	
} //End namespace MusicManager

