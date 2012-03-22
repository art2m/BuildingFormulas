//  
//  ReadSongPathsCollectionFromFile.cs
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
/// Class -- ReadSongPathsCollectionFromFile.cs
/// 
/// Read song paths collection from file and refill the SongPathsCollection
/// wit it. Quicker then rescanning the users music files. As long as the 
/// user made no changes to there music file since the last time it was
/// saved to file.
/// </summary>
using System;
using System.IO;
using System.Text;

namespace MusicManager
{
	public class ReadSongPathsCollectionFromFile
	{
		public ReadSongPathsCollectionFromFile ()
		{
		} //End Constructor
        
		public void FillSongPathsCollectionFromFile ()
		{
			//
		}
        
	} //End class ReadSongPathsCollectionFromFile
    
} //End namespace MusicManager

