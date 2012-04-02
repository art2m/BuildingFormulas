//  
//  CombinePlaylist.cs
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
/// Class -- CombinePlaylist.cs
/// 
/// Combine playlist into one new playlist store the new playlist in the 
/// same file that ther other playlists are being combined from.
/// </summary>
using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using Gtk;

namespace MusicManager
{
	public class CombinePlaylist
	{
        
		private string methodName = null;
		private string errMsg = null;
		private string className = "CombinePlaylist";
		private string dirPlayList = null;
		private string newFileName = null;
		private string newPlayListPath = null;
		private List<string> lstPaths = new List<string> ();
		private List<string> lstPList = new List<string> ();
        
		public CombinePlaylist ()
		{
		} //End Constructor
        
		public void CombineMultiplePlaylists ()
		{
			bool retVal = false;
            
			retVal = GetPlaylistDirectory ();
            
			if (!retVal) {
				retVal = AppendM3uPlaylist ();
			}
          
		} //End Method
        
        
		/// <summary>
		/// Method -- private string GetPlaylistDirectory()
		/// 
		/// Get directory that contains multiple m3u playlists 
		/// needing to be combined into one playlist.
		/// </summary>
		/// <returns>
		/// The playlist directory.
		/// </returns>
		private bool GetPlaylistDirectory ()
		{
			bool retVal = false;
			string pListName = null;
			MyMessages myMsg = null;
            
			try {
				methodName = "private string GetPlaylistDirectory()";
				myMsg = new MyMessages ();
				
				retVal = DisplayFileBrowser ();
				
				if (retVal) {
					retVal = NameNewPlaylist (ref pListName);
				} else {
					return retVal;
				}
                
				if (!retVal) {
					return retVal;
				}	                  
				
				//All Ok
				newFileName = pListName;
				retVal = true;
				return true;
			} catch (NullReferenceException ex) {
				
				myMsg.BuildErrorString (className, methodName, errMsg, 
                                       ex.Message.ToString ());
				return retVal;
			} catch (IOException ex) {
				
				myMsg.BuildErrorString (className, methodName, errMsg, 
                                       ex.Message.ToString ());
				return retVal;
			}
            
		} //End Method
        
		private bool DisplayFileBrowser ()
		{
			
			bool retVal = false;  		
			MyMessages myMsg = null; 
            
			try {
				methodName = "private bool DisplayFileBrowser()";
				errMsg = "Encountered error while getting playlist directory.";
				string msg = "You must select a directory that contains m3u " +
                                                            "playlist files.";
				myMsg = new MyMessages ();
				DisplayFileBrowser fb = null;
				string dirPlaylist = null;
				bool keepLoop = false;
				do {
					//Display file browser so user can select directory with
					//.m3u Playlists in it.
					dirPlaylist = fb.SelectPlaylistDirectory (); 
                          
					//if user canceled without selecting a directory then
					//exit for loop. User wishes to quit.
					if (String.IsNullOrEmpty (dirPlaylist)) {
						keepLoop = true;
					} else if (!Directory.Exists (dirPlaylist)) {
						myMsg.ShowErrMessage (msg);                        
						keepLoop = false;
					} else { 
						//Check that the files contained in this directory
						//are .m3u playlist files. if return true then Correct
						//Exit loop with KeepLoop true. Else if return not 
						//correct false. Continue to loop. until user 
						//selects cancel in filebrowser.
						keepLoop = ValidateMultiplePlaylistFiles (dirPlaylist);
                                                  
					}
                           
					//Tell user how to exit the loop.
					if (!keepLoop) {
						string msgExit = "To cancel selecting playlist" +
                                " directory select cancel in filebrowser.";
						StringBuilder sb = new StringBuilder ();
						sb.Append (msg);
						sb.Append (Environment.NewLine);
						sb.Append (msgExit);
                            
						myMsg.ShowInformationMessage (sb.ToString ());
						myMsg = null;
					}
				} while (!keepLoop); 
                   
				//All Ok
				//Store play list directory path.
				dirPlayList = dirPlaylist;
				retVal = keepLoop;
				return retVal;
			} catch (NullReferenceException ex) {
				myMsg.BuildErrorString (className, methodName, errMsg,
                                       ex.Message.ToString ());
				return retVal;
			} catch (IOException ex) {
				myMsg.BuildErrorString (className, methodName, errMsg,
                                       ex.Message.ToString ());
				return retVal;          
			}
            
		} //End Method
        
        
        
		/// <summary>
		/// Method -- private bool ValidateMultiplePlaylistFiles(
		/// string dirplaylist);
		/// 
		/// Get files from directory and check that they contain at least 
		/// 2 .m3u playlist files.
		/// </summary>
		/// <returns>
		/// return false if not at least 2 .m3u playlist files found
		/// else return true. 
		/// </returns>
		/// <param name='dirPlaylist'>
		/// If set to <c>true</c> dir playlist.
		/// </param>
		private bool ValidateMultiplePlaylistFiles (string dirPlaylist)
		{
			bool retVal = false;
			MyMessages myMsg = null;
            
			try {
                
				myMsg = new MyMessages ();
				methodName = "private bool ValidateMutiplePlaylistFiles(" +
                                                        " string dirPlaylist)";
				errMsg = "Encountered error while validating" +
                                               " directory has playlist files.";
				//Get files in the playlist directory the user slected.
				string[] filePlaylists = Directory.GetFiles (dirPlaylist);
               
				string myTemp = null;           
                   
				//Loop threw the files looking for any playlist file
				//with .m3u extension. if found add to list collection.
				for (int i = 0; i < filePlaylists.Length; i++) {           
					myTemp = filePlaylists [i];
					if (System.IO.Path.GetExtension (myTemp) == ".m3u") {
						lstPaths.Add (myTemp);
					}         
				}
               
				//Check lstPaths count must be at least 2 Playlist files 
				//to combine. if not exit return false.
				if (lstPaths.Count < 2) {
					return retVal;
				}
                   
				//All Ok
				retVal = true;
				return retVal;
			} catch (NullReferenceException ex) {
				myMsg.BuildErrorString (className, methodName, errMsg,
                                       ex.Message.ToString ()); 
				return retVal;
			} catch (IndexOutOfRangeException ex) {
				myMsg.BuildErrorString (className, methodName, errMsg,
                                       ex.Message.ToString ());  
				return retVal;
			} catch (IOException ex) {
				myMsg.BuildErrorString (className, methodName, errMsg,
                                       ex.Message.ToString ());  
				return retVal;
			}
               
		} //End Method
        
		/// <summary>
		/// Method -- private bool NameNewPlaylist(ref string pListName)
		/// 
		/// Display dialog for user to name the new playlist.
		/// </summary>
		/// <returns>
		/// The new playlist.
		/// </returns>
		/// <param name='pListName'>
		/// If set to <c>true</c> p list name.
		/// </param>
		private bool NameNewPlaylist (ref string pListName)
		{
			bool retVal = false;
			bool keepLoop = false;
			MyMessages myMsg = null;
            
			try {
				ResponseType rspRetVal = new ResponseType ();
				MyInputDialog dlgInput = new MyInputDialog ();
				myMsg = new MyMessages ();
                
				methodName = "private bool NameNewPlaylist(string pListName)";
				errMsg = "Encountered error while getting new playlist name.";
          
				do {
                       
					//enter string to be displayed in myInputDialog.
					ConstantMessages.InputDialogMessage = 
                                    "Enter name for new combined playlist.";
					rspRetVal = (ResponseType)dlgInput.Run ();
               
					if (rspRetVal == ResponseType.Ok) {
						string plistName = 
                                   ConstantMessages.OutputDialogMessage;   
						// if ok return is true exit loop else return is false.
						//continue loop.
						keepLoop = ValidatePlaylistFileName (plistName);
						dlgInput.Destroy ();                
					} else {
						//User canceled and did not create a new name for the 
						//playlist. so set keepLoop to true so we can exit loop.
						dlgInput.Destroy (); 
						keepLoop = true;
					}                
                                       
				} while (!keepLoop);           
                   
				//All ok
				retVal = keepLoop;
				return retVal;
			} catch (IOException ex) {
				myMsg.BuildErrorString (className, methodName, errMsg,
                                       ex.Message.ToString ());  
				return retVal;
			}
            
		} //End Method
        
        
		private bool ValidatePlaylistFileName (string pListName)
		{
			bool retVal = false;
			StringBuilder sb = null;
			MyMessages myMsg = null;
            
			try {
				methodName = "private bool ValidatePlaylistFileName(" +
                                                           " string pListName)";
				errMsg = "Encontered error while validating file name.";
				if (String.IsNullOrEmpty (pListName)) {
					return retVal; //no file name entered.
				} 
          
               
				//Check file name not to long.
				int len = pListName.Length;
                   
				if (len > 254) {
					return retVal; //File name to long.
				}
          
             
				//Get list of invalid file name characters.
				char[] notAllowed = System.IO.Path.GetInvalidFileNameChars ();
                    
				int index = 0;
				//Check for invalid char in the file name string.
				for (int i = 0; i < notAllowed.Length; i++) {
					index = pListName.IndexOf (notAllowed [i]);
					if (index > 0) {
						string msg = ":  This character is not" +
                                                   " allowed in a file name.";
						sb = new StringBuilder ();
						sb.Append (notAllowed [i]);
						sb.AppendLine (msg);  
                           
						myMsg.ShowErrMessage (sb.ToString ());      
						return retVal;
					}               
				} //End for 
                
				//Check that this file does not all ready exist.               
				sb.Append (dirPlayList);
				sb.Append (Path.DirectorySeparatorChar);
				sb.Append (newFileName);
				if (!File.Exists (sb.ToString ())) { // save file path.
					newPlayListPath = sb.ToString ();
				} else { //This file name all ready exists.
					sb.Append (newFileName);
					sb.Append (Environment.NewLine);
					sb.Append ("This playlist name all ready exists.");
					sb.Append (Environment.NewLine);
					sb.Append ("Please start again and enter a diffrent name.");
					myMsg.ShowErrMessage (sb.ToString ());
				}                    
                
				//Create the new Playlist file in same playlist file where
				//the playlists to be combined are.
				retVal = CreateNewPlaylistFile ();
				//If Failed to create new playlist return false.
				if (!retVal) {
					return retVal;
				}                
                
				//All Ok
				retVal = true;
				return retVal;
			} catch (NullReferenceException ex) {
				myMsg.BuildErrorString (className, methodName, errMsg,
                                       ex.Message.ToString ());
				return retVal;
			} catch (AccessViolationException ex) {
				myMsg.BuildErrorString (className, methodName, errMsg,
                                       ex.Message.ToString ());
				return retVal;
			} catch (IOException ex) {
				myMsg.BuildErrorString (className, methodName, errMsg,
                                       ex.Message.ToString ());
				return retVal;
			} 
            
		} //End Method
  
        
		/// <summary>
		/// Method -- public bool CreateNewPlaylistFile()
		/// 
		/// Creates the new playlist file.
		/// </summary>
		/// <returns>
		/// The new playlist file.
		/// </returns>
		public bool CreateNewPlaylistFile ()
		{
			bool retVal = false;
			MyMessages myMsg = null;
			string combPlaylist = null;
            
			try {
				methodName = "private bool CreateNewPlaylistFile()";
				errMsg = "Unable to create new Playlist file. Exiting.";
				myMsg = new MyMessages ();
                
                
				//Create the new playlist that is going to hold all the
				//playlist that are being combined.
				File.Create (newPlayListPath);
                
				for (int i = 0; i > lstPaths.Count; i++) {
					combPlaylist = lstPaths [i];
					retVal = ReadInM3uPlaylistFile (combPlaylist);
					if (!retVal) { //exit if error encoutered.
						break;   
					}
				}                
				
				return retVal;
                
			} catch (NullReferenceException ex) {
				myMsg.BuildErrorString (className, methodName, errMsg,
                                       ex.Message.ToString ());
				return retVal;                                                   
			} catch (AccessViolationException ex) {
				myMsg.BuildErrorString (className, methodName, errMsg,
                                       ex.Message.ToString ());
				return retVal;        
			} catch (IOException ex) {
				myMsg.BuildErrorString (className, methodName, errMsg,
                                       ex.Message.ToString ());
				return retVal;
			}
			
		} //End Method
        
       
		/// <summary>
		/// Method -- private bool ReadInM3uPlaylistFile()
		/// 
		/// Reads the in m3u playlist file.
		/// </summary>
		/// <returns>
		/// The in m3u playlist file.
		/// </returns>
		/// <param name='pListPath'>
		/// If set to <c>true</c> p list path.
		/// </param>
		private bool ReadInM3uPlaylistFile (string pListPath)
		{
			bool retVal = false;
			string msg = null;
			MyMessages myMsg = null;
			StreamReader sr = null;
            
			try {
				methodName = "private bool ReadInM3uPlaylistFile(" +
                                                        " string pListPath)";
				
				myMsg = new MyMessages ();
                   
				//make sure file hasn't been deleted.
				if (!File.Exists (pListPath)) {
					msg = "Encountere error while checking if the" +
                         " playlist file to be combined exists:  ";
					errMsg = String.Join (msg, pListPath);
					myMsg.ShowErrMessage (errMsg);
                       
					return retVal;   
				}  
                   
				
                   
				//Open the Playlist file to be read from for combining.
				sr = File.OpenText (pListPath);
                   
				string reading = null;
				//Read line into the list collection so it can be appended
				//to the file it is being combined into.
				while ((reading = sr.ReadLine()) != null) {
					lstPList.Add (reading);
				}
                
				sr.Close ();
                
				//Call to append the playlist just read in to the Playlist file
				//being created.
				retVal = AppendM3uPlaylist ();           
                   
				return retVal;
			} catch (NullReferenceException ex) {
				errMsg = "Encountered error while reading in Playlist" +
                                                        " to be combined.";
				myMsg.BuildErrorString (className, methodName, errMsg,
                                       ex.Message.ToString ());
				return retVal;
			} catch (FileNotFoundException ex) {
				errMsg = "Encountered error while reading in Playlist" +
                                                        " to be combined.";
				myMsg.BuildErrorString (className, methodName, errMsg,
                                       ex.Message.ToString ());
				return retVal;
			} catch (FieldAccessException ex) {
				errMsg = "Encountered error while reading in Playlist" +
                                                        " to be combined.";
				myMsg.BuildErrorString (className, methodName, errMsg,
                                       ex.Message.ToString ());
				return retVal;
			} catch (FileLoadException ex) {
				errMsg = "Encountered error while reading in Playlist" +
                                                        " to be combined.";
				myMsg.BuildErrorString (className, methodName, errMsg,
                                       ex.Message.ToString ());
				return retVal;
			} catch (IOException ex) {
				errMsg = "Encountered error while reading in Playlist" +
                                                        " to be combined.";
				myMsg.BuildErrorString (className, methodName, errMsg,
                                       ex.Message.ToString ());
				return retVal; 
			} finally {
				if (sr != null) 
					sr.Close ();  
			}
            
		} //End Method
        
        
		/// <summary>
		/// Method -- private bool AppendM3uPlaylist
		/// 
		/// Appends the m3u playlist that was read into the collection to
		/// the new file being combined to.
		/// </summary>
		/// <returns>
		/// The m3u playlist.
		/// </returns>
		private bool AppendM3uPlaylist ()
		{
			bool retVal = false;
			string msg = null;
			MyMessages myMsg = null;
			StreamWriter sw = null;
            
			try {
				methodName = "AppendM3uPlaylist()";
                 
				//make sure file hasn't been deleted.
				if (!File.Exists (newPlayListPath)) {
					msg = "Encountered error while checking if the" +
                                                 " new playlist file exists:  ";
					errMsg = String.Join (msg, newPlayListPath);
					myMsg.ShowErrMessage (errMsg);
					return retVal;
				}  
				//If there are no lines to be read in the collection exit.
				if (lstPList.Count < 1) {
					msg = "There are no playlist songs to be combined into" +
                                                             " this file.";
					errMsg = String.Join (msg, newPlayListPath);
					myMsg.ShowErrMessage (errMsg);
					return retVal;
				}
          
				sw = File.AppendText (newPlayListPath);
                   
				for (int i = 0; i < lstPList.Count; i++) {
					sw.WriteLine (lstPList [i]);
				}
                   
				sw.Close ();
                   
				//All ok
				retVal = true;
				return retVal;
			} catch (NullReferenceException ex) {
				errMsg = "Encounterd error while combining playlist.";
				myMsg.BuildErrorString (className, methodName, errMsg,
                                       ex.Message.ToString ());
				return retVal;
			} catch (FileNotFoundException ex) {
				errMsg = "Encounterd error while combining playlist.";
				myMsg.BuildErrorString (className, methodName, errMsg,
                                       ex.Message.ToString ());
				return retVal;
			} catch (FieldAccessException ex) {
				errMsg = "Encounterd error while combining playlist.";
				myMsg.BuildErrorString (className, methodName, errMsg,
                                       ex.Message.ToString ());
				return retVal;
			} catch (FileLoadException ex) {
				errMsg = "Encounterd error while combining playlist.";
				myMsg.BuildErrorString (className, methodName, errMsg,
                                       ex.Message.ToString ());
				return retVal;
			} catch (IOException ex) {
				errMsg = "Encounterd error while combining playlist.";
				myMsg.BuildErrorString (className, methodName, errMsg,
                                       ex.Message.ToString ());
				return retVal;
			} finally {
				if (sw != null)
					sw.Close ();
			}
            
		} //End Method
        
        
	} //End class CombinePlayists
    
} //End namespace MusicManager
