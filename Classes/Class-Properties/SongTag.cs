//  
//  SongTagRecord.cs
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
/// class -- Song tag record.
/// 
/// Holds data returned about this particular record.
/// 
/// </summary>
using System;

namespace MusicManager
{
	public static class SongTag
	{
      
        
        
		private static string strArtistName;

		public static string ArtistName {
			get {
				return strArtistName;
			} 
			set {
				strArtistName = value;
			} 
		}//End Property
            
		private static string strAlbumName;

		public static string AlbumName {
			get {
				return strAlbumName;
			}
			set {
				strAlbumName = value;
			}
		} //End Property
        
        
		private static string strSngTitle;
        
		public static string SongTitle {
			get {
				return strSngTitle;
			}
			set {
				strSngTitle = value;
			}
		} //End Property
         
		private static string strGenreType;

		public static string GenreType {
			get {
				return strGenreType;
			}
			set {
				strGenreType = value;
			}
		} //End Property
        
        
		private static string strTrackNum;

		public static string TrackNumber {
			get {
				return strTrackNum;
			}
			set {
				strTrackNum = value;
			}
		} //End Property
        
		private static string strTrackCnt;

		public static string TrackCount {
			get {
				return strTrackCnt;
			}
			set {
				strTrackCnt = value;
			}
		} //End Property
        
		private static string strAlbumArt;

		public static string AlbumArtExists {
			get {
				return strAlbumArt;
			}
			set {
				strAlbumArt = value;
			}
		} //End Property
        
		private static string strYear;

		public static string YearOfSongOrCd {
			get {
				return strYear;
			}
			set {
				strYear = value;
			}
		} //End Property
        
		private static string strDiscNum;

		public static string DiscNumber {
			get {
				return strDiscNum;
			}
			set {
				strDiscNum = value;
			}
		} //End Property
            
      
		private static string strDiscCnt;

		public static string DiscCount {
			get {
				return strDiscCnt;
			}
			set {
				strDiscCnt = value;
			}
		} //End Property
        
		private static string strSngPath;

		public static string SongPath {
			get {
				return strSngPath;
			}
			set {
				strSngPath = value;
			}
		} //End Property
        
        
	} //End class SongTagRecord
    
} //End namespace MusicManager

