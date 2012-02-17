//  
//  clsArtistInfo.cs
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
/// class -- clsArtistInfo
/// 
/// Holds Artist Data
/// </summary>
using System;
using System.Collections;

namespace MusicManager
{
	public class ArtistRecord
	{
		public ArtistRecord ()
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
        
		private string strArtistPath = null;

		public string ArtistPath {
			get {
				return strArtistPath;
			}
			set {
				strArtistPath = value;
			}
		} //End Property
        
		private string primaryKey = null;
        
		public string ArtistPrimaryKey {
			get {
				return primaryKey;
			}
			set {
				primaryKey = value;
			}
		} //End Property

		
        
	} //End class clsArtistRecord
    
    
} //End namespace MusicManager

