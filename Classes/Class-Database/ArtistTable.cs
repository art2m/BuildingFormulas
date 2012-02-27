//  
//  ArtistTable.cs
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

namespace MusicManager
{
	public class ArtistTable
	{
        
        #region Database Objects
        
		private OdbcDataAdapter da = null;
		private DataSet ds = null;
		private int index = 0;
		private OdbcConnection odbCon;
        
#endregion Database Objects
        
#region Class Variables
        
		private string methodName = null;
		private string errMsg = null;
		private const string className = "ArtistDatabaseMovement";
        
#endregion Class Variables
        
		public ArtistTable ()
		{
		} //End Constructor
        
	} //End class ArtistTable
    
} //End namespace MusicManager


