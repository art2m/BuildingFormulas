//  
//  clsSongInfo.cs
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
/// class clsSongInfo
/// 
/// Holds clsSongRecords
/// </summary>
using System;
using System.Collections;
using System.Data.Linq;

namespace MusicManager
{
	public class SongRecord
	{
		public SongRecord ()
		{
		} //End Constructor
		
		private  string strArtistName;

		public string ArtistName { 
			get {
				return strArtistName;  
			}
			set {
				strArtistName = value;   
			}
		} //End Property
        
		private  string strAlbumName;

		public string AlbumName {
			get {
				return strAlbumName;
			}
			set {
				strAlbumName = value;
			}
		} //End Property
        
		private  string strAlbumPath;

		public string AlbumPath {
			get {
				return strAlbumPath;
			}
			set {
				strAlbumPath = value;
			}
		} //End Property
        
		private  string strSongName;

		public string SongName {
			get {
				return strSongName;
			}
			set {
				strSongName = value;
			}
		} //End Property
        
		private  string strSongPath;

		public string SongPath { 
			get {
				return strSongPath;
			}
			set {
				strSongPath = value;
			}
		} //End Property
		
		
	} //End class clsSongInfo
	
} //End namespace MusicManager

