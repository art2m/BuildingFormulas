//  
//  clsCheckSongTagInfo.cs
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

/// <summary>
/// Class -- clsCheckSongTagInfo
/// 
/// Checks tag information for missing data. it then stores the path
/// of each song tag checked to either Correct Song tags or to 
/// Missing song tag information.
/// </summary>
using System;
using System.IO;
using System.Collections;
using System.Threading;

namespace MusicManager
{
	public class ValidateSongTags
	{		
		private Mp3TagReader tgRead = new Mp3TagReader ();
		private SongTagRecord sngTagRec = null;
		private string methodName = "";
		private string errMsg = "";
		private const string className = "clsCheckSongTagInfo";
		//private int intIndex = 0;

		public ValidateSongTags ()
		{
			
			
		} //End Constructor
		
		//passed from songTagWindow for delegate can access.
		private SongTagWindow sngTagWin = null;

		public SongTagWindow GetObjecSongTagWindow {
			set {
				sngTagWin = value;
			}
		}
		
		
		/// <summary>
		/// METHOD -- public bool GetPathsFromSongPathList
		/// 
		/// Get all song paths stored in the collection clsSongsPathList.
		/// loop threw each song path so if no errors or nothing missing can be 
		/// saved
		/// to clsSongTagList. or if errors or missing data save to 
		/// clsSongMissingTagList.
		/// </summary>
		/// <returns>
		/// true if no problems and false if so.
		/// </returns>
		public void GetPathsFromSongPathList ()
		{
			bool retVal = false;	
			string[] sngPaths = null;
			int recCnt = 0;
			try {				
				
				SngPathBeingProcessed evSngPath = new SngPathBeingProcessed
                    (sngTagWin.DisplaySongsBeingProcessed);
				methodName = "public bool GetPathsFromSongPathList()";
				
				sngPaths = SongPathsCollection.GetAllItems ();
				
				recCnt = sngPaths.Length;
				if (recCnt < 0) {
					throw new IndexOutOfRangeException ("Index for collection" +
                                                        " can not be < 0");
				} else if (recCnt > (sngPaths.Length)) {
					throw new IndexOutOfRangeException ("Index for collection" +
                                                        " to large.");
				}				
				//if no records then return false.
				if (recCnt < 1) {                    
					string strMsg = "No music files in collection. In Main " +
                     " window select Menu PathActions and Submenu Get All " +
                     "Music";
					MyMessages clsMsg = new MyMessages ();
					clsMsg.ShowInformationMessage (strMsg);
					return;
				}			
				
				//Clear Arrays in case user selects button again.
				ValidSongTagCollection.ClearArray ();
				InvalidSongTagCollection.ClearArray ();
                
				foreach (string sngPath in sngPaths) {	
					Thread.Sleep (100);
					evSngPath (sngPath);
					
					//if all ok returns true if not false.
					retVal = GetSongTagInfo (sngPath);
					if (!retVal) { //if false exit erorr encountered.
						return;	
					}
				}
                            
				string msgCnt = "Found " + recCnt.ToString () + " Tags ";
				msgCnt = msgCnt + "Valid tags = " 
                    + ValidSongTagCollection.ItemsCount () + " InValid Tags " +
                        InvalidSongTagCollection.ItemsCount ();
                    
				evSngPath (msgCnt);
			} catch (IndexOutOfRangeException ex) {
				errMsg = "SongPathList collection index invalid." +
                    recCnt.ToString ();
				MyMessages clsMsg = new MyMessages ();
				clsMsg.BuildErrorString (className, methodName, errMsg, 
                                         ex.Message.ToString ());
			}		
		} //End Method 
	
		
		/// <summary>
		/// METHOD -- private bool GetSongTagInfo
		/// 
		/// Get the song tag info for this song path from clsMp3TagReader
		/// Fill an array with all of the tag information. 
		/// </summary>
		/// <returns>
		/// Return true if able to get all data form the collection and if
		/// FillSongTagListCollection and FillMissingTagListCollection return 
		/// true. Else error return false.
		/// </returns>
		/// <param name='sngPath'>
		/// If set to <c>true</c> string song path.
		/// </param>
		private bool GetSongTagInfo (string sngPath)
		{
			bool retVal = false;
			
			
			try {
				methodName = "private bool GetSongTagInfo(string sngPath)";
				if (String.IsNullOrEmpty (sngPath)) {
					throw new ArgumentNullException ("String sngPath can " +
                     "   not be null empty.");
				}
				string[] sngTags = new string[11];			
				
				sngTags [0] = tgRead.GetArtist (sngPath);
				sngTags [1] = tgRead.GetAlbum (sngPath);
				sngTags [2] = tgRead.GetTitle (sngPath);
				sngTags [3] = tgRead.GetGenre (sngPath);
				sngTags [4] = tgRead.GetTrack (sngPath);
				sngTags [5] = tgRead.GetTrackCount (sngPath);
				sngTags [6] = tgRead.AlbumArtExists (sngPath);
				sngTags [7] = tgRead.GetYear (sngPath);
				sngTags [8] = tgRead.GetDisc (sngPath);
				sngTags [9] = tgRead.GetDiscCount (sngPath);
				sngTags [10] = sngPath;		
				
				//Check for Missing Data or Error getting data from the 
				//returned values.
				retVal = CheckTagInfoForMissingData (sngTags);
				
				
				if (retVal) { //If no missing or error add this to 
					//SongTagList Collection.
					retVal = FillSongTagListCollection (sngTags);
				} else { //if is missing or erorr then add this to 
					//SongMissingTagList Collection.
					retVal = FillMissingSongTagListCollection (sngTags);
				}
				
				return retVal;         
			} catch (TagLib.CorruptFileException ex) {
				errMsg = "This file is corrupt.";
				MyMessages clsMsg = new MyMessages ();
				clsMsg.BuildErrorString (className, methodName, errMsg, 
                                         ex.Message.ToString ());
				return retVal;
			} catch (TagLib.UnsupportedFormatException ex) {
				errMsg = "Unsupported format.";
				MyMessages clsMsg = new MyMessages ();
				clsMsg.BuildErrorString (className, methodName, errMsg, 
                                         ex.Message.ToString ());
				return retVal;
			} catch (IndexOutOfRangeException ex) {
				errMsg = "Incorrect index.";
				MyMessages clsMsg = new MyMessages ();
				clsMsg.BuildErrorString (className, methodName, errMsg, 
                                         ex.Message.ToString ());
				return retVal;
			} catch (ArgumentNullException ex) {
				errMsg = "Argument not correct: " + sngPath;                    
				MyMessages clsMsg = new MyMessages ();
				clsMsg.BuildErrorString (className, methodName, errMsg,
                    ex.Message.ToString ());                
				return retVal;
			}
			
		} //End Method 
	
		
		/// <summary>
		/// METHOD -- private bool CheckTagInfoForMissingData
		/// 
		/// Check to see if there is any missing data if so return false. 
		/// Check to see if there is any errors encountered when getting the
		/// data from the song tag. if so return false.
		/// If no missing data and no erorrs return true.
		/// </summary>
		/// <returns>
		/// The tag info for missing data.
		/// </returns>
		/// <param name='sngTags'>
		/// If set to <c>true</c> string tag info.
		/// </param>
		public bool CheckTagInfoForMissingData (string[] sngTags)
		{
			
			bool retVal = false;
			int missTagData = 1;
			int errTagData = 1;
           
			
			try {
				methodName = "private bool CheckTagInfoForMissingData(" +
                 " string[] sngTags)";
				if (sngTags == null) {
					throw new ArgumentNullException ("String array has not " +
                     "been initialized.");
				}
            
                
				if (sngTags.Length < 1) {
					errMsg = "There was no tag information found.";
					MyMessages clsMsg = new MyMessages ();
					clsMsg.ShowInformationMessage (errMsg);
					return retVal;
				}
				//Check Artist Name return value.
				missTagData = String.Compare (sngTags [0], "missing", 
                                            StringComparison.OrdinalIgnoreCase);
				errTagData = String.Compare (sngTags [0], "error", 
                                           StringComparison.OrdinalIgnoreCase);
				if (missTagData == 0)
					return retVal;
				if (errTagData == 0)
					return retVal;
				
				//Check Ablum Name return value.
				missTagData = String.Compare (sngTags [1], "missing", 
                                            StringComparison.OrdinalIgnoreCase);
				errTagData = String.Compare (sngTags [1], "error", 
                                           StringComparison.OrdinalIgnoreCase);
				if (missTagData == 0)
					return retVal;
				if (errTagData == 0)
					return retVal;
				
				//Check Song Title return value.
				missTagData = String.Compare (sngTags [2], "missing", 
                                            StringComparison.OrdinalIgnoreCase);
				errTagData = String.Compare (sngTags [2], "error", 
                                           StringComparison.OrdinalIgnoreCase);
				if (missTagData == 0)
					return retVal;
				if (errTagData == 0)
					return retVal;
				
				//Check Genre Name return value.
				missTagData = String.Compare (sngTags [3], "missing", 
                                            StringComparison.OrdinalIgnoreCase);
				errTagData = String.Compare (sngTags [3], "error", 
                                           StringComparison.OrdinalIgnoreCase);
				if (missTagData == 0)
					return retVal;
				if (errTagData == 0)
					return retVal;
				
				//Check Track Number return value.
				missTagData = String.Compare (sngTags [4], "missing", 
                                            StringComparison.OrdinalIgnoreCase);
				errTagData = String.Compare (sngTags [4], "error", 
                                           StringComparison.OrdinalIgnoreCase);
                
				if (missTagData == 0)
					return retVal;
				if (errTagData == 0)
					return retVal;
                
				int trackNum = Convert.ToInt32 (sngTags [4]);
				if (trackNum < 1) //Track Number less then 1 error.             
					return retVal;
               
				
				//Check Total Track Count return value.
				missTagData = String.Compare (sngTags [5], "missing", 
                                            StringComparison.OrdinalIgnoreCase);
				errTagData = String.Compare (sngTags [5], "error", 
                                           StringComparison.OrdinalIgnoreCase);
				if (missTagData == 0)
					return retVal;
				if (errTagData == 0)
					return retVal;
                
				int trackCnt = Convert.ToInt32 (sngTags [5]);
				if (trackCnt < 1)
					return retVal; //if track count < 0 error.
				
				//Check Number of Album Art Found return value.
				missTagData = String.Compare (sngTags [6], "missing", 
                                            StringComparison.OrdinalIgnoreCase);
				errTagData = String.Compare (sngTags [6], "error", 
                                           StringComparison.OrdinalIgnoreCase);
				if (missTagData == 0)
					return retVal;
				if (errTagData == 0)
					return retVal;
				
				//Check Year return value.
				missTagData = String.Compare (sngTags [7], "missing", 
                                            StringComparison.OrdinalIgnoreCase);
				errTagData = String.Compare (sngTags [7], "error", 
                                           StringComparison.OrdinalIgnoreCase);
				if (missTagData == 0)
					return retVal;
				if (errTagData == 0)
					return retVal;	
             
				int numYear = Convert.ToInt32 (sngTags [7]);
				if (numYear < 1900)
					return retVal;
				
				//Check Disc Number return value.                
				missTagData = String.Compare (sngTags [8], "missing", 
                                            StringComparison.OrdinalIgnoreCase);
				errTagData = String.Compare (sngTags [8], "error", 
                                           StringComparison.OrdinalIgnoreCase);
				if (missTagData == 0)
					return retVal;
				if (errTagData == 0)
					return retVal;
				int discNum = Convert.ToInt32 (sngTags [8]);                
				if (discNum < 1) 
					return retVal; //if Disc Number count is less then 1 error.
				
				//Check Total Disc Count return value.
				missTagData = String.Compare (sngTags [9], "missing", 
                                            StringComparison.OrdinalIgnoreCase);
				errTagData = String.Compare (sngTags [9], "error", 
                                           StringComparison.OrdinalIgnoreCase);
				if (missTagData == 0)
					return retVal;
				if (errTagData == 0)                    
					return retVal;
                
				int discCnt = Convert.ToInt32 (sngTags [9]);                
				if (discCnt < 1)
					return retVal; //if Disc Total Cnt < 1 error.
				
				//Return true if all data is filled.
				//Return false if empty string as there
				//was no data for this item.
				retVal = true;
				return retVal;
			} catch (IndexOutOfRangeException ex) {
				errMsg = "Index out of range.";
				MyMessages clsMsg = new MyMessages ();
				clsMsg.BuildErrorString (className, methodName, errMsg, 
                                         ex.Message.ToString ());
				return retVal;
			} catch (ArgumentNullException ex) {
				errMsg = "Argument not correct";                    
				MyMessages clsMsg = new MyMessages ();
				clsMsg.BuildErrorString (className, methodName, errMsg,
                    ex.Message.ToString ());                
				return retVal;   
			}		
		} //End Method 
		
		
		/// <summary>
		/// METHOD -- private bool FillSongTagListCollection
		/// 
		/// Fill the collection clsSongTagList with all the data if no error 
		/// encounterd return true.
		/// </summary>
		/// <returns>
		/// The song tag list collection.
		/// </returns>
		/// <param name='sngTags'>
		/// If set to <c>true</c> string tag info.
		/// </param>
		private bool FillSongTagListCollection (string[] sngTags)
		{
			bool retVal = false;
			
			try {
				methodName = "private bool FillSongTagListCollection(" +
                 " string[] sngTags)";
                
				sngTagRec = new SongTagRecord ();
                
				if (sngTags == null) {
					throw new ArgumentNullException ("String array has not " +
                     "been initialized.");
				} else if (sngTagRec == null) {
					throw new NullReferenceException ("clsSongRecord has not " +
                     "been initialized.");
				}
				sngTagRec.ArtistName = sngTags [0];
				sngTagRec.AlbumName = sngTags [1];
				sngTagRec.SongTitle = sngTags [2];
				sngTagRec.GenreType = sngTags [3];
				sngTagRec.ThisTrackNumber = sngTags [4];
				sngTagRec.TotalTrackCount = sngTags [5];
				sngTagRec.AlbumArt = sngTags [6];
				sngTagRec.YearCreated = sngTags [7];
				sngTagRec.ThisDiscNumber = sngTags [8];
				sngTagRec.TotalDiscCount = sngTags [9];
				sngTagRec.SongPath = sngTags [10];
				sngTagRec.SongTagValid = "true"; //Tag is correct.
				
				ValidSongTagCollection.AddNewItem (sngTagRec);
                
				//Fill Database MusicManagerSqlite Table artistdata 
				retVal = FillArtistTable (sngTagRec);
                
				if (!retVal) {
					return retVal;
				}
                
				//Fill Database MusicManagerSqlite Table albumdata
				retVal = FillAlbumTable (sngTagRec);
                
				if (!retVal) {
					return retVal;
				}
                
				//Fill Database MusicManagerSqlite Table songdata
				retVal = FillSongTable (sngTagRec);
                
				if (!retVal) {
					return retVal;
				}
				
				//All ok
				retVal = true;
				return retVal;
			} catch (IndexOutOfRangeException ior) {
				errMsg = "Index out of range.";
				MyMessages clsMsg = new MyMessages ();
				clsMsg.BuildErrorString (className, methodName, errMsg, 
                                         ior.Message.ToString ());
				return retVal;
			} catch (ArgumentNullException ex) {
				errMsg = "Argument not correct";                    
				MyMessages clsMsg = new MyMessages ();
				clsMsg.BuildErrorString (className, methodName, errMsg,
                    ex.Message.ToString ());                
				return retVal;   
			} catch (NullReferenceException ex) {
				errMsg = "Encountered error while adding to clsSongRecord";                   
				MyMessages clsMsg = new MyMessages ();
				clsMsg.BuildErrorString (className, methodName, errMsg,
                    ex.Message.ToString ());
				return retVal;
			}        
		} //End Method 
		
		
		/// <summary>
		/// METHOD -- private bool FillMissingSongTagListCollection(string[] 
		/// sngTags)
		/// 
		/// Fill the collection clsSongMissingTagList with the data from the 
		/// song tag.
		/// If all goes well retruen true if encountered error return false.
		/// </summary>
		/// <returns>
		/// The missing song tag list collection.
		/// </returns>
		/// <param name='sngTags'>
		/// If set to <c>true</c> string tag info.
		/// </param>
		private bool FillMissingSongTagListCollection (string[] sngTags)
		{
			bool retVal = false;
			
             
			try {
				methodName = "private bool FillMissingSongTagListCollection(" +
                 " string[] sngTags)";
                
				sngTagRec = new SongTagRecord ();
                
				if (sngTags == null) {
					throw new ArgumentNullException ("String array has not " +
                     "been initialized.");
				} else if (sngTagRec == null) {
					throw new ArgumentNullException ("clsSongRecord has not" +
                     "been initialized");
				}
                
               
				sngTagRec.ArtistName = sngTags [0];
				sngTagRec.AlbumName = sngTags [1];
				sngTagRec.SongTitle = sngTags [2];
				sngTagRec.GenreType = sngTags [3];
				sngTagRec.ThisTrackNumber = sngTags [4];
				sngTagRec.TotalTrackCount = sngTags [5];
				sngTagRec.AlbumArt = sngTags [6];
				sngTagRec.YearCreated = sngTags [7];
				sngTagRec.ThisDiscNumber = sngTags [8];
				sngTagRec.TotalDiscCount = sngTags [9];
				sngTagRec.SongPath = sngTags [10];
				sngTagRec.SongTagValid = "false"; //Invalid tag.
                
				InvalidSongTagCollection.AddNewItem (sngTagRec);
                
				retVal = FillArtistTable (sngTagRec);
                
				if (!retVal) {
					return retVal;
				}
                
				retVal = FillAlbumTable (sngTagRec);
                
				if (!retVal) {
					return retVal;
				}
                
				retVal = FillSongTable (sngTagRec);
                
				if (!retVal) {
					return retVal;
				}
                
				//All ok
				retVal = true;
				return retVal;
			} catch (IndexOutOfRangeException ior) {
				errMsg = "Index out of range.";
				MyMessages clsMsg = new MyMessages ();
				clsMsg.BuildErrorString (className, methodName, errMsg, 
                                         ior.Message.ToString ());
				return retVal;
			} catch (ArgumentNullException ex) {
				errMsg = "Argument not correct";                    
				MyMessages clsMsg = new MyMessages ();
				clsMsg.BuildErrorString (className, methodName, errMsg,
                    ex.Message.ToString ());                
				return retVal;  
			} catch (NullReferenceException ex) {
				errMsg = "Encountered error while adding to clsSongRecord";                   
				MyMessages clsMsg = new MyMessages ();
				clsMsg.BuildErrorString (className, methodName, errMsg,
                    ex.Message.ToString ());
				return retVal; 
			}
			
		} //End Method      
	
        
        
#region Fill Artist, Album And Song Database
        
        
		/// <summary>
		/// Method -- private bool fillArtistTable(SongTagRecord sngTagRec)
		/// 
		/// Fills the artist table.
		/// </summary>
		/// <returns>
		/// The artist table.
		/// </returns>
		/// <param name='sngTagRec'>
		/// If set to <c>true</c> sng tag rec.
		/// </param>
		private bool FillArtistTable (SongTagRecord sngTagRec)
		{
			bool retVal = false;
                  
			try {
				methodName = "private bool FillArtistTable(SongRecord" +
                                                                 " sngTagRec)";
                
				errMsg = "Encounterd error while adding a new record to" +
                                                        " the Artist table";
                
				ArtistDatabaseTable dtArtist = new ArtistDatabaseTable ();
                            
				retVal = dtArtist.OpenDatabaseConnection ();
                            
				if (!retVal) {
					MyMessages myMsg = new MyMessages ();
					myMsg.ShowErrMessage ("Error unable to open database" +
                                                            " connection.");
					myMsg = null;
					return retVal;
				}
				DirectoryInfo dirInfo = new DirectoryInfo (sngTagRec.SongPath);
                   
				DirectoryInfo dirAlbum = dirInfo.Parent;
				DirectoryInfo dirArtist = dirAlbum.Parent;                
				
				string artistPath = dirArtist.ToString ();          
                            
				retVal = dtArtist.UpdateArtistAddNewRecord (
                                            sngTagRec.ArtistName, artistPath);           
				if (!retVal) {
					return retVal;
				}          
                              
				//All ok
				retVal = true;
				return retVal;
			} catch (InvalidOperationException ex) {
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg,
                                       ex.Message.ToString ());
				return retVal;
			} catch (NullReferenceException ex) {
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg,
                                       ex.Message.ToString ());
				return retVal; 
			} catch (ArgumentNullException ex) {
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg,
                                       ex.Message.ToString ());
				return retVal;
			}
		} //End Method
              
        
		/// <summary>
		/// Method -- private bool FillAlbumTable(SongTagRecord sngTagRec)
		/// 
		/// Fills the album table.
		/// </summary>
		/// <returns>
		/// The album table.
		/// </returns>
		/// <param name='sngTagRec'>
		/// If set to <c>true</c> sng tag rec.
		/// </param>
		private bool FillAlbumTable (SongTagRecord sngTagRec)
		{
			bool retVal = false;
              
			try {
				methodName = "private bool FillAlbumTable(SongRecord" +
                                                                " sngTagRec)";
                      
				errMsg = "Encountered error while adding a new record to" +
                                                            " the album Table.";
                      
				AlbumDatabaseTable dtAlbum = new AlbumDatabaseTable ();
                      
				retVal = dtAlbum.OpenDatabaseConnection ();
                      
				if (!retVal) {
					MyMessages myMsg = new MyMessages ();
					myMsg.ShowErrMessage ("Error unable to open database" +
                                                             " connection.");
					myMsg = null;
					return retVal;   
				}
                
				DirectoryInfo dirInfo = new DirectoryInfo (sngTagRec.SongPath);
				DirectoryInfo dirAlbum = dirInfo.Parent;
                
				string albPath = dirAlbum.ToString ();
                      
				retVal = dtAlbum.UpdateAlbumAddNewRecord (sngTagRec.AlbumName, 
                            sngTagRec.TotalTrackCount, sngTagRec.TotalDiscCount,
                            sngTagRec.ThisDiscNumber, albPath, 
                            sngTagRec.YearCreated, sngTagRec.GenreType,
                            sngTagRec.ArtistName);
                      
				if (!retVal) {
					return retVal;
				}
                      
                      
				//All Ok
				retVal = true;
				return retVal;
			} catch (InvalidOperationException ex) {
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg,
                                       ex.Message.ToString ());
				return retVal;
			} catch (NullReferenceException ex) {
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg,
                                       ex.Message.ToString ());
				return retVal; 
			} catch (ArgumentNullException ex) {
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg,
                                       ex.Message.ToString ());
				return retVal;
			}
                      
		} //End Method
        
        
              
		private bool FillSongTable (SongTagRecord sngTagRec)
		{
			bool retVal = false;
            
			try {
				methodName = "private bool FillSongTable(" +
                                                    " SongTagRecord sngTagRec)";
                      
				errMsg = "Encountered error while adding" +
                                            " new record to the Song Table.";
				SongDatabaseTable dtSong = new SongDatabaseTable ();
                      
				retVal = dtSong.OpenDatabaseConnection ();
                      
				if (!retVal) {
					MyMessages myMsg = new MyMessages ();
					myMsg.ShowErrMessage ("Error unable to open database" +
                                                            " connection.");
					myMsg = null;
					return retVal;
				}
                      
                      
				retVal = dtSong.UpdateSongAddNewRecord (sngTagRec.SongTitle, 
                                sngTagRec.SongPath, sngTagRec.ThisTrackNumber,
                                sngTagRec.AlbumName, sngTagRec.ArtistName, 
                                sngTagRec.YearCreated, sngTagRec.SongTagValid);
                      
				if (!retVal) {
					return retVal;
				}
                      
				//All ok
				retVal = true;
				return retVal;
			} catch (InvalidOperationException ex) {
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg,
                                       ex.Message.ToString ());
				return retVal;
			} catch (NullReferenceException ex) {
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg,
                                       ex.Message.ToString ());
				return retVal; 
			} catch (ArgumentNullException ex) {
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg,
                                       ex.Message.ToString ());
				return retVal;
			}
                  
		} //End Method
        
#endregion Fill Artist, Album And Song Database
          
	} //End class clsCheckSongTagInfo
    
    
  
    
	
} //End namespace MusicManager
