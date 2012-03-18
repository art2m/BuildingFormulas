//  
//  ArtistDataTable.cs
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
using System;
using System.Text;
using System.IO;
using System.Diagnostics;

namespace MusicManager
{
	public class ArtistDataTable
	{
		public ArtistDataTable ()
		{
		} //End Constructor
        
		public bool WriteTagDataToFile (ArtistRecord recArtist)
		{
			bool retVal = false;
			//Take the csv string and write it to the file.
            
			//string csvValue = CreateArtistRecord (recArtist);
            
			return retVal;
            
		} //End Method 
        
		private string CreateArtistRecord (ArtistRecord recArtist)
		{
			string retVal = null;
			//string comma = ",";
            
            
			//StringBuilder sb = new StringBuilder ();
            
//            sb.Append = recArtist.ArtistName;
//            sb.Append = comma;
//            sb.Append = recArtist.ArtistPath;
            
			//Read Artist data from ArtistRecord Collection and
			//create csv string to be placed into file.
			return retVal;
		} //End Method
        
		public bool ReadArtistDataFromFile ()
		{
			return true;
			//Read the csv strings from the file.
		} //End Method
        
		private bool PlaceArtistRecordInCollection (string artistRecord)
		{
			//Read data from csv string and fill ArtistRecord collection.
			return true;
		}
        
       
        
	} //End class ArtistDataTable
    
} //End namespace MusicManager

