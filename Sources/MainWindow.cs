//  
//  MainWindow.cs
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
using System;
using System.IO;
using System.Threading;
using System.Diagnostics;
using Gtk;

public delegate void ProcessingSongPath (string songPath);

public partial class MainWindow: Gtk.Window
{		
	//DefaultTraceListener d = new DefaultTraceListener ();
	private string methodName = "";
	private string errMsg = "";
	private const string className = "MainWindow";
	private Thread sngPath = null;
	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{				
		Build ();
		
		//Get user name, home directory and Default Music Directory.
		bool retVal = MusicManager.UserEnviormentInfo.GetUserInfo ();
		
		//If found then fill labels with information.
		if (retVal) {
			lblUserName.Text = MusicManager.UserEnviormentInfo.UserName;
			lblUserHomePath.Text = MusicManager.UserEnviormentInfo.
                UserHomeDirectoryPath;
			lblUserMusicPath.Text = MusicManager.UserEnviormentInfo.
                UserMusicDirectoryPath;
			lblInfo.Text = MusicManager.UserEnviormentInfo.
                UserMusicDirectoryPath;
		} else { //No information located fill with Undetermined.
			lblUserName.Text = "Undetermined";
			lblUserHomePath.Text = "Undetermined";
			lblUserMusicPath.Text = "Undetermined";			
		
		}
		
	} //End Method 
	
    
 
    
#region Menu Events

	/// <summary>
	/// Event -- protected void SelectPathToMusicFolderMenu
	/// 
	/// calls DisplayFileBrowser for displaying.
	/// </summary>
	/// <param name='sender'>
	/// Sender.
	/// </param>
	/// <param name='e'>
	/// E.
	/// </param>
	protected void SelectPathToMusicFolderMenu (object sender, 
                                                            System.EventArgs e)
	{
        
			
		methodName = "protected void " +
            " mnuMain_UserInfo_MusicPath_Incorrect_OnClicked (object sender, " +
   "System.EventArgs e)";         
  
		MusicManager.DisplayFileBrowser fBrowser = new MusicManager.
        DisplayFileBrowser ();
  
		fBrowser.SelectToplevelMusicDirectory ();
     
	
	} //End Event 
    
	protected void LoadSongsFromMusicFolderMenu (object sender, 
                                                        System.EventArgs e)
	{
		try {
			methodName = "protected void LoadSongsFromMusicFolderMenu";
            
			MusicManager.SongFilePaths sngFile = new 
                                                MusicManager.SongFilePaths ();
       
             
			//If no toplevel music directory selected exit.
			if (!CheckToplevelMusicDirectorySelected ())
				return;      
         
         
			MusicManager.SongPathsCollection.ClearArray ();
			sngFile.SetObjectMainWindow = this;
      
			//Calls method to get all of the mp3 song files located under
			//the toplevel music folder.
			sngPath = new Thread (sngFile.GetAllSongPaths);
			sngPath.Start ();  
			
            
		} catch (ThreadStartException ex) {
			errMsg = "Encountered error while starting thread.";
			MusicManager.MyMessages myMsg = new MusicManager.MyMessages ();
			myMsg.BuildErrorString (className, methodName, errMsg,
                                                        ex.Message.ToString ());           
        
		} catch (ThreadInterruptedException ex) {
			errMsg = "Encountered error while sngPath thread active.";
			MusicManager.MyMessages myMsg = new MusicManager.MyMessages ();
			myMsg.BuildErrorString (className, methodName, errMsg,
                                                        ex.Message.ToString ());
		} catch (ThreadAbortException ex) {
			errMsg = "sngPath thread terminated unexpectedly"; 
			MusicManager.MyMessages myMsg = new MusicManager.MyMessages ();
			myMsg.BuildErrorString (className, methodName, errMsg,
                                                        ex.Message.ToString ());
		}
        
	} //End Event    

   
	/// <summary>
	/// Event -- protected void QuitMusicManagerProgramMenu
	/// 
	/// Quits the music manager program menu.
	/// </summary>
	/// <param name='sender'>
	/// Sender.
	/// </param>
	/// <param name='e'>
	/// E.
	/// </param>
	protected void QuitMusicManagerProgramMenu (object sender, 
                                                            System.EventArgs e)
	{
		Application.Quit ();
	} //End Event
    
    
	protected void LoadSongsFromFilemnu (object sender, System.EventArgs e)
	{
		throw new System.NotImplementedException ();
	}

 
	/// <summary>
	/// Event -- protected void ReplaceSpaceInFileWithUnderscoreMenu
	/// 
	/// Replaces the space in song file with underscore menu.
	/// </summary>
	/// <param name='sender'>
	/// Sender.
	/// </param>
	/// <param name='e'>
	/// E.
	/// </param>
	/// <exception cref='System.NotImplementedException'>
	/// Is thrown when a requested operation is not implemented for a given type.
	/// </exception>
	protected void ReplaceSpaceInFileWithUnderscoreMenu (object sender, 
                                                         System.EventArgs e)
	{
		MusicManager.MusicPathWindow musicPath = 
                                        new MusicManager.MusicPathWindow ();
		musicPath.ShowAll ();
        
	} //End Event
 
    
	/// <summary>
	/// Event -- protected void ReplaceUnderscoreInFileWithSpaceMenu
	/// 
	/// Replaces the undersore in song file with space.
	/// </summary>
	/// <param name='sender'>
	/// Sender.
	/// </param>
	/// <param name='e'>
	/// E.
	/// </param>
	/// <exception cref='System.NotImplementedException'>
	/// Is thrown when a requested operation is not implemented for a given type.
	/// </exception>
	protected void ReplaceUndersoreInFileWithSpaceMenu (object sender, 
                                                            System.EventArgs e)
	{
		MusicManager.MusicPathWindow musicPath = 
                                        new MusicManager.MusicPathWindow ();
		musicPath.ShowAll ();
	} //End Event
    
	/// <summary>
	/// Event protected void CreateVariousArtistFolderMenu
	/// 
	/// Creates a various artist folder inside of Genre folder. This holds all
	/// Albums that do not have one Artist.
	/// </summary>
	/// <param name='sender'>
	/// Sender.
	/// </param>
	/// <param name='e'>
	/// E.
	/// </param>
	protected void CreateVariousArtistFolderMenu (object sender, 
                                                            System.EventArgs e)
	{
//		string[] genres = null;
// 
//		int intCnt = MusicManager.GenreCollection.ItemsCount ();
// 
//		if ((intCnt - 1) < 1) {
//			return;
//		}
// 
//		genres = new string[intCnt];
//
//		//Fill the list with music directories paths.
//		genres = MusicManager.GenreCollection.GetAllGenreDirectories ();
// 
//		if (genres == null) {
//			return;
//		} else if (genres.Length < 1) {
//			return;
//		}
// 
//		for (int i = 0; i < intCnt -1; i++) {     
//             
//		}
// 
		throw new System.NotImplementedException ();
	} //End Event
    
	/// <summary>
	/// Event -- protected void DisplaySongTagWindowMenu
	/// 
	/// Displaies the song tag window.
	/// </summary>
	/// <param name='sender'>
	/// Sender.
	/// </param>
	/// <param name='e'>
	/// E.
	/// </param>
	protected void DisplaySongTagWindowMenu (object sender, System.EventArgs e)
	{
		
		MusicManager.SongTagWindow sngtag = new MusicManager.SongTagWindow ();
         
		sngtag.ShowAll ();
   
     
	} //End Event
    
	
 
#endregion Menu Events

	
	
#region Button Events Area  
    
	/// <summary>
	/// Event QuitApplicationButton
	/// 
	/// Quits the application.
	/// </summary>
	/// <param name='sender'>
	/// Sender.
	/// </param>
	/// <param name='e'>
	/// E.
	/// </param>
	protected void QuitApplicationButton (object sender, System.EventArgs e)
	{
		Application.Quit ();
	} //End Method

	
#endregion Button Events Area
	
	
#region Get Music Folders and Files
	
	
    
    
	/// <summary>
	/// Method -- private bool CheckToplevelMusicDirectorySelected()
	/// 
	/// Check to see if the user has already selected a valid toplevel
	/// music directory. 
	/// </summary>
	/// <returns>
	/// return true if valid toplevel music directory found 
	/// return false if no valid toplevel music directory found.
	/// </returns>
	private bool CheckToplevelMusicDirectorySelected ()
	{
		MusicManager.ValidateUserMusicDirectory valDir = new MusicManager.
            ValidateUserMusicDirectory ();		
		
		bool retVal = false;
		
		methodName = "private bool CheckToplevelMusicDirectorySelected()";
		string userMDir = 
                        MusicManager.UserEnviormentInfo.UserMusicDirectoryPath;
		
		//If no path found then exit return false.
		if (string.IsNullOrEmpty (userMDir)) {
			errMsg = "You nedd to select a toplevel Music directory.";
			MusicManager.MyMessages clsMsg = new MusicManager.MyMessages ();
			clsMsg.BuildErrorString (className, methodName, errMsg, "");
			return retVal;
		}			
		
		//Validate that this toplevel music directory does have song files 
		//in it's sub folders.
		valDir.ValidateMusicDirectory (MusicManager.UserEnviormentInfo.
                                       UserMusicDirectoryPath);			
		
		//If no music files are found then return false.
		if (!MusicManager.UserEnviormentInfo.ToplevelMusicDirectoryFound) {
			errMsg = "You nedd to select a toplevel Music directory.";
			MusicManager.MyMessages clsMsg = new MusicManager.MyMessages ();
			clsMsg.BuildErrorString (className, methodName, errMsg, "");
			return retVal;
			
		}
		
		//All is ok.
		retVal = true;
		return retVal;					
		
	} //End Method 	
	
	
	/// <summary>
	///Method -- private bool GetGenreFolderPaths()
	///
	/// Check for Genre folders check they are all named with a leading
	/// Various- such as: Various-Rock. Add each folder to genreFPathenreList
	/// collection.
	/// </summary>
	/// <returns>
	/// true if all is ok else false if not.
	/// </returns>
//	private bool GetGenreFolderPaths ()
//	{
//		//MusicManager.GenreFolder genreFPath = new MusicManager.GenreFolder ();
//		bool retVal = false;
//		
//		//Check Genre directory structure and names and add to 
//		//genreFPathenreList
//		//retVal = genreFPath.ValidateGenreStructure (MusicManager.
//		//UserEnviormentInfo.UserMusicDirectoryPath);		
//		
//		
//		//if Genre directory name or structure is incorrect return false exit.
//		retVal = MusicManager.GenreDirectoryProperties.CheckForGenreFolder;
//		
//		//All ok.		
//		return retVal;
//		
//	} //End Method 
	
	
	/// <summary>
	/// Method -- private bool GetArtistFolderPaths()
	/// 
	/// Checks Artist folders are named correctly they should all be 
	/// proceeded by Artist- then the name of the Artist. There should be
	/// no files located in the Artist folder only album Folders.
	/// if all is ok then add each to the clsArtistList collection.
	/// </summary>
	/// <returns>
	/// The artist folder paths.
	/// </returns>
//	private bool GetArtistFolderPaths ()
//	{
//		MusicManager.ArtistGenreFolder genreFArtist = 
//                                        new MusicManager.ArtistGenreFolder ();
//		
//		bool retVal = false;
//		
//		//Check Artist folder structure and names. and add
//		//Artist info to genreFArtistrtistList.
//		retVal = genreFArtist.ValidateArtistStructure ();
//		
//		//if Artist directory name or structure is incorrect return false.
//		retVal = MusicManager.ArtistDirectoryProperties.
//            CheckForArtistDirectories;
//		
//		//All is ok.		
//		return retVal;
//		
//	} //End Method 
	
	
//	private bool GetAlbumFolderPaths ()
//	{		
//		//MusicManager.clsAlbumGenre clsAlb = new MusicManager.clsAlbumGenre();
//		
//		bool retVal = false;
//		
//		//Check Album folders structure and names. and add
//		//Album folder info to clsAlbumList.
//		retVal = MusicManager.AlbumDirectoryProperties.
//            CheckForAlbumDirectories;
//	
//		return retVal;		
//	} //End Method
	
//	private bool GetSongFilePaths ()
//	{
//		MusicManager.SongGenre genreSng = new MusicManager.SongGenre ();
//		
//		bool retVal = false;
//		
//		retVal = genreSng.ValidateSongStructure ();
//		
//		if (!retVal)
//			return retVal;		
//		
//		return retVal;
//	} //End Method
// 
	/// <summary>
	/// Event -- public void ProcessingSongPath
	/// 
	/// Processings the song path.
	/// </summary>
	/// <param name='strpath'>
	/// Strpath.
	/// </param>
	public void ProcessingSongPath (string filePath)
	{            
		lblInfo.Text = filePath;
	} //End Method
    

	


#endregion End Get Music Folders and Files
	
} //End class public partial class MainWindow: Gtk.Window
