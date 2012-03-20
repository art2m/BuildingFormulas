//  
//  clsSongs.cs
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
using System.Collections.Generic;
using System.Threading;

namespace MusicManager
{
	public class SongFilePaths
	{
		
		private string methodName = "";
		private string errMsg = "";
		private const string className = "clsSongPaths";
       
		public SongFilePaths ()
		{
		} //End Constructor
		
		//passed from songTagWindow for delegate can access.
		private MainWindow clsMw = null;

		public MainWindow SetObjectMainWindow {
			set {
				clsMw = value;
			}
		}
        
		public void GetAllSongPaths ()
		{
            
			MusicDirectoryLoop (MusicManager.UserEnviormentInfo.
                                UserMusicDirectoryPath);
		}
		
		/// <summary>
		/// Method -- public void MusicDirectoryLoop (string dirMusic)
		/// 
		/// Get All of the Music File Paths and save them to collection
		/// </summary>
		/// <param name='dirMusic'>
		/// String M dir.
		/// </param>
		public void MusicDirectoryLoop (string dirMusic)
		{	
			bool retVal = false;
            
			try {
				methodName = "public void ValidateMusicDirectory " +
                 "   (string dirMusic)";
				errMsg = "Encountered error while checking directory for " +
                 "   .mp3 file. ";
 			 	
				foreach (string musicDir in 
                                    Directory.GetDirectories (dirMusic)) { 
				
					retVal = CheckForFiles (musicDir);
				
					if (!retVal) {
						MusicDirectoryLoop (musicDir);   
					} 
				} 				
			} catch (DirectoryNotFoundException ex) {
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg, 
                                         ex.Message.ToString ()); 
				return;
			} catch (PathTooLongException ex) {
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg, 
                                         ex.Message.ToString ()); 
				return;
			}
			
			
		} //End Method 
		
			
		
		private bool CheckForFiles (string musicDir)
		{
			bool retVal = false;           
			
			try {
				methodName = "private bool CheckFoFiles(string directory)";
				errMsg = "Encountered error while checking for song files.";
				string[] getFile = Directory.GetFiles (musicDir);
                   
				Console.WriteLine (musicDir);
          
				int intCnt = getFile.Length;
          
				if (intCnt > 0) {
					retVal = CheckFilesMp3 (getFile);              
             
				}
				//Return false no files found;
				return retVal;
			} catch (PathTooLongException ex) {
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg, 
                                       ex.Message.ToString ());
				return retVal;
			} catch (DirectoryNotFoundException ex) {
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg, 
                                       ex.Message.ToString ());
				return retVal;      
			} catch (IOException ex) {
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg, 
                                       ex.Message.ToString ());
				return retVal;   
			} catch (UnauthorizedAccessException ex) {
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg, 
                                       ex.Message.ToString ());
				return retVal;  
			}
            
			
		} //End Method 
		
		
		private bool CheckFilesMp3 (string[] sngFiles)
		{
			bool retVal = false;
			int compMp3 = -1;
			string filePath = "";
			
			try {
				methodName = "private bool CheckFileisMp3(string[] sngFiles)";
				ProcessingSongPath evSngPath = new ProcessingSongPath				
				                                    (clsMw.ProcessingSongPath);
				
				
				foreach (string sngFile in sngFiles) {
					
					filePath = sngFile;
					compMp3 = -1;
					FileInfo fIfo = new FileInfo (sngFile);
					
					compMp3 = String.Compare (fIfo.Extension, ".mp3",
                                              StringComparison.
                                              OrdinalIgnoreCase);
					
					//If .mp3 music file add it to the collection.
					if (compMp3 == 0) {
						evSngPath (sngFile);
						Thread.Sleep (100);
                        
						SongPathsCollection.AddNewItem (sngFile);
						GetMusicPathInfo (sngFile);
                        
					}
					
					//Get and display the number of songs found.
					int intCnt = SongPathsCollection.ItemsCount ();
     
					evSngPath ("Located: " + intCnt + " Songs.");
					
				} //End foreach loop
				
				//all ok				
				return retVal;
			} catch (FileNotFoundException ex) {
				errMsg = "File: " + filePath + " Does not exist.";
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg, 
                                         ex.Message.ToString ());				
				return retVal;
			} catch (IOException ex) {
				errMsg = "Encountered File Access Error: " + filePath;
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg, 
                                         ex.Message.ToString ());
				return retVal;
			} catch (UnauthorizedAccessException ex) {
				errMsg = "Encountered File Access Error: " + filePath;
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg, 
                                         ex.Message.ToString ());
				return retVal;
			}
			
		} //End Method  
        
        
		public void GetMusicPathInfo (string sngPath)
		{
			string artistName = null;
			string albumName = null;
			string artistPath = null;
			string albumPath = null;            
			MyMessages myMsg;
            
			methodName = "private void GetMusicPathInfo (string sngPath)";
			myMsg = new MyMessages ();
           
			if (String.IsNullOrEmpty (sngPath)) {
				errMsg = "Null string song file path.";
				myMsg.BuildErrorString (className, methodName, errMsg, "");
				return;
			}		

			albumPath = Directory.GetParent (sngPath).ToString ();
			artistPath = Directory.GetParent (albumPath).ToString ();
            
			//Get the directory name only from directory path.
			string[] splitAlbum = albumPath.Split (Path.DirectorySeparatorChar);
			int cnt = splitAlbum.Length - 1;
			albumName = splitAlbum [cnt];
            
			
            
			string[] split = artistPath.Split (Path.DirectorySeparatorChar);
			cnt = split.Length - 1;
			artistName = split [cnt];
            
			AddNewAlbumDictionary (albumName, albumPath);
			AddNewAlbumPath (albumName, albumPath);
			AddNewArtistDictionary (artistName, artistPath);
			AddNewArtistPath (artistName, artistPath);
			AddNewSongPath (albumName, albumPath);
            
            
		} //End Method
        
        
        
		public void AddNewAlbumDictionary (string albumName, string albumPath)
		{
			bool retVal = false;
			string[] sngPaths;
			List<string> mp3Songs = new List<string> ();
			string ext;
          
			//Check if key all ready in collection.
			retVal = AlbumDictionary.ContainsKey (albumName);
            
			//if key in collection exit.
			if (retVal) {
				return;
			}
            
			//Get all files contained in this directory.
			sngPaths = Directory.GetFiles (albumPath);
            
			//if songs found check ext for mp3 songs if found add to 
			//array.
			if (sngPaths.Length > 0) {   				
				for (int i = 0; i < sngPaths.Length; i++) {
					ext = Path.GetExtension (sngPaths [i]);
                    
					if (ext == ".mp3") {
						
						mp3Songs.Add (
                            Path.GetFileNameWithoutExtension (sngPaths [i]));
                       
						
					}     
				} //End For
                
				string[] sngItems = mp3Songs.ToArray ();  			
                 
				//Add new album name key and mp3Song Array as value.
				AlbumDictionary.AddNewItem (albumName, sngItems);
			} //End If
		} //End Metod
        
		public void AddNewAlbumPath (string albumName, string albumPath)
		{
			bool retVal = false;
            
			//Check to see if albumName all ready in collection
			retVal = AlbumPaths.ContainsKey (albumName);
            
			//If not then enter album name and albumPath.
			if (!retVal) {
				AlbumPaths.AddNewItem (albumName, albumPath);
			}                           
		} //End Method
        
		public void AddNewArtistDictionary (string artistName,
                                                        string artistPath)
		{
			bool retVal = false;
            
			//Check artist name not all ready in collection.
			retVal = Artist_Dictionary.ContainsKey (artistName);
            
			//if it is then exit.
			if (retVal) {
				return;
			}
            
			//Get all Album directories for this artist. if found then
			//add them to the Artist_Dictionary with the artist name as key.
			string[] albumPaths = Directory.GetDirectories (artistPath);
            
			if (albumPaths.Length > 0) {
				Artist_Dictionary.AddNewItem (artistName, albumPaths);
			}
                
		} //End Method
        
		public void AddNewArtistPath (string artistName, string artistPath)
		{
			bool retVal = false;
            
			//Check if Artist all ready in collection.
			retVal = ArtistPaths.ContainsKey (artistName);
            
			//if Artist not in collection then add artistName as Key and
			// artistPath as value.
			if (!retVal) {
				ArtistPaths.AddNewItem (artistName, artistPath);
			}
		}
        
		public void AddNewSongPath (string albumName, string albumPath)
		{
			bool retVal = false;
			string[] sngPaths;
			List<string> mp3Songs = new List<string> ();
			string ext;
          
			//Check if key all ready in collection.
			retVal = SongPaths.ContainsKey (albumName);
            
			//if key in collection exit.
			if (retVal) {
				return;
			}
            
			//Get all files contained in this directory.
			sngPaths = Directory.GetFiles (albumPath);
            
			//if songs found check ext for mp3 songs if found add to 
			//array.
			if (sngPaths.Length > 0) {  
				for (int i = 0; i < sngPaths.Length; i++) {
					ext = Path.GetExtension (sngPaths [i]);
                    
					if (ext == ".mp3") {
						mp3Songs.Add (sngPaths [i]);
					}     
				} //End For
                
				string[] sngItems = mp3Songs.ToArray ();
                
				//Add new album name key and sngItems array as value.
				SongPaths.AddNewItem (albumName, sngItems);
			} //End If            
		}
      
        
	} //End class clsSongs
    
	
} //End namespace MusicManager

