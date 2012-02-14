//  
//  clsAlbumInfo.cs
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
/// Class -- clsAlbumInfo
/// 
/// Holds Album Data
/// </summary>
using System;
using System.Collections;

namespace MusicManager
{
	public class AlbumRecord
	{
		
		public AlbumRecord ()
		{
		} //End Constructor
		
        
		private string strArtistName = null;

		public string ArtistName { 
			get {
				return strArtistName;
			}
			set {
				strArtistName = value;
			}
		} //End Property
  
		private string strAlbumName = null;

		public string AlbumName { 
			get {
				return strAlbumName;
			}
			set {
				strAlbumName = value;
			}
		} //End Property
  
		private string strAlbumPath = null;

		public string AlbumPath {
			get {
				return strAlbumPath;
			}
			set {
				strAlbumPath = value;
			}
		} //End Property
  
		private string strAlbumArtName = null;

		public string AlbumArtName {
			get {
				return strAlbumArtName;
			}
			set {
				strAlbumArtName = value;
			}
		} //End Property
		
	} //End class clsAlbumInfo
	
} //End namespace MusicManager

