//  
//  Mp3TagWriter.cs
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
/// Class -- Mp3TagWriter
/// 
/// This class is for writing data changes back to the 
/// tag.
/// </summary>
using System;
using System.IO;

namespace MusicManager
{
	public class Mp3TagWriter
	{
        
		TagLib.File tgLib = null;
		private const string className = "Mp3TagWriter";
		private string methodName = "";
		private string errMsg = "";
        
		public Mp3TagWriter ()
		{
		}
        
		public bool SaveSongTagData (SongTagRecord sngTagRecord)
		{
            
			bool retVal = false;
            
			try {
                
				methodName = "public bool SaveSongTagData(" +
                                                 "SongTagRecord sngTagRecord)";
             
             
				if (String.IsNullOrEmpty (sngTagRecord.SongPath)) {
					return retVal;
				} else if (!File.Exists (sngTagRecord.SongPath)) {
					return retVal;  
				}           
             
				tgLib = TagLib.File.Create (sngTagRecord.SongPath);
				tgLib.Tag.Clear ();
                
				
				
				tgLib.Tag.AlbumArtists = new string[] {sngTagRecord.ArtistName};
				tgLib.Tag.Album = sngTagRecord.AlbumName;
				tgLib.Tag.Title = sngTagRecord.SongTitle;
				tgLib.Tag.Genres = new string[] {sngTagRecord.GenreType};
				tgLib.Tag.Track = Convert.ToUInt32 (
                                                sngTagRecord.ThisTrackNumber);
				tgLib.Tag.TrackCount = Convert.ToUInt32 (
                                                 sngTagRecord.TotalTrackCount);
				tgLib.Tag.Year = Convert.ToUInt32 (sngTagRecord.YearCreated);
				tgLib.Tag.Disc = Convert.ToUInt32 (sngTagRecord.ThisDiscNumber);
				tgLib.Tag.DiscCount = Convert.ToUInt32 (
                                                 sngTagRecord.TotalDiscCount);
             
				tgLib.Save ();
                
				//All ok
				retVal = true;
				return retVal;
			} catch (TagLib.UnsupportedFormatException ex) {
				errMsg = "Unable to save tag information.";
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg,
                                       ex.Message.ToString ());
				return retVal;
             
			} catch (NullReferenceException ex) {
				errMsg = "Unable to save tag information."; 
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg,
                                       ex.Message.ToString ());
				return retVal;
                    
			}            
              
            
		}  //End Method    
        
        
     
//GetAlbum
//
//GetGenre
//
//GetYear
//
//GetDisc
//
//GetDiscCount
//
//GetTrack
//
//GetTrackCount
//
//AlbumArtExists
        
	} //End class Mp3TagWriter
    
} //End namespace MusicManager

