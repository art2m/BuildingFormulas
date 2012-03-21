//  
//  clsUserEnvData.cs
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


/************************************************************************************************************************************************
 *
 *This class stores all of the users Enviormental data such as: User Name, User Home Path, User Music Directory.
 *It also has a Method to get the user Enviormental information.
 ***********************************************************************************************************************************************/
using System;
using System.IO;

namespace MusicManager
{
	public static class UserEnviormentInfo
	{
		
		
		private static string methodName = null;
		private static string errMsg = null;
		private static string className = "clsUserEnvData";
		
	
		
		
		/// <summary>
		///Property -- private static string UserName  
		/// 
		/// 
		/// The name of the string user.
		/// </summary>/
		private static string userName = null;

		public static string UserName {
			get {
				return userName;
			}
			set {
				userName = value;
			}			
		} // End Property
		
		
		/// <summary>
		/// Property -- public static string UserHomeDirectoryPath
		/// 
		/// The path to the Users home directory
		/// </summary>
		private static string userHome = null;

		public static string UserHomeDirectoryPath {
			get {
				return userHome;
			}
			set {
				userHome = value;
			}
		} //End Property
		
		
		/// <summary>
		/// Property -- public static string UserMusicDirectoryPath
		/// 
		/// The path to the Users toplevel Music Directory.
		/// </summary>
		private static string userMusic = "";

		public static string UserMusicDirectoryPath {
			get {
				return userMusic;				
			}
			set {
				userMusic = value;
			}
		}	//End Property
		
		
		
		
		/// <summary>
		/// Properth -- public static string GetMusicGenreDirectory
		/// 
		/// This holds the music Genre Directory we are now woring in such as Various-Rock
		/// </summary>
		private static string genreFolder = "";

		public static string GetMusicGenreDirectory {
			get {
				return genreFolder;
			}
			set {
				genreFolder = value;
			}
		} //End Property
		
		
		//
		/// <summary>
		/// Property --public static bool ToplevelMusicDirectoryFound
		/// 
		/// Set to true if music files are found under the music directory selected
		/// by user. need this here or else foreach string dir in Directories will
		/// continue to loop threw to last file found and it is a jpg so it returns
		/// false always no mp3 found.
		/// </summary>
		private static bool mp3Found = false;

		public static bool ToplevelMusicDirectoryFound {
			get { 
				return mp3Found;
			}
			set { 
				mp3Found = value;
			}
		}// End Property
		
		
		
		private static readonly string incorFolderName = "MusicManagerProg";

		public static string GetIncorrectCorrectTagFolderName {
			get {
				return incorFolderName;
			}
		} //End Property
		
		
		private static readonly string incorFileName = "InCorrectTags.dat";

		public static string GetInCorrectFileName {
			get {
				return incorFileName;
			}
		} //End Property
		
		
		/// <summary>
		/// The name of the corr file.
		/// </summary>
		private static readonly String corrFileName = "CorrectTags.dat";

		public static string GetCorrectFileName {
			get {
				return corrFileName;
			}
		} //End Property
		
		/// <summary>
		/// Property -- public static string GetSongCollectionFileName
		///  
		/// Return the name of the file where the songs from the 
		/// class songPathsCollection is to be writen to or read from.
		/// 
		/// </summary>
		private static readonly string songPathCollectionName = 
                                                    "SongCollection.dat";

		public static string GetSongPathCollectionFileName {
			get {
				return songPathCollectionName;
			}
			
		} //End Property
        
        
		/// <summary>
		/// Property -- public static string GetProgramDataDirectoryName
		/// 
		/// Returns the name of the directory where all data files for 
		/// this program will be stored. Music-Manager
		/// </summary>
		private static readonly string programDataDirectory = "Music-Manager";
        
		public static string GetProgramDataDirectoryName {
			get {
				return programDataDirectory;
			}
		} //End Property  
        
		
		/// <summary>
		/// Method -- static public bool GetUserInfo
		/// 
		/// Get user name, users home path, users music directory path.
		/// </summary>
		/// <returns>
		/// The user info.
		/// </returns>
		public static bool GetUserInfo ()
		{	
			
			bool retVal = false;			
				
			try {
				
				methodName = "public static bool GetUserInfo()";
				
				//Get user home directory path and users name.
				UserEnviormentInfo.UserHomeDirectoryPath = 
                    Environment.GetFolderPath (
                        Environment.SpecialFolder.Personal);				
				string[] words = 
                    UserEnviormentInfo.UserHomeDirectoryPath.Split ('/');			
				UserEnviormentInfo.UserName = words [2];
				
				UserEnviormentInfo.UserMusicDirectoryPath = 
                    Environment.GetFolderPath (
                        Environment.SpecialFolder.MyMusic);
				
				retVal = true;
				return retVal;
			} catch (UnauthorizedAccessException ex) {
				errMsg = "Permissions not correct for accessing this path.";
				MyMessages clsMsg = new MyMessages ();				
				clsMsg.BuildErrorString (className, methodName, errMsg, 
                                         ex.Message.ToString ());
				return retVal;
			} catch (DirectoryNotFoundException ex) {
				errMsg = "Unable to access default /home/user or " +
              "  /home/usr/music directory.";
				MyMessages clsMsg = new MyMessages ();
				clsMsg.BuildErrorString (className, methodName, errMsg, 
                                         ex.Message.ToString ());
				return retVal;
			}
			
				
		} // End Method 
		
	} //End clsData
	
} // End namespace MusicManager

