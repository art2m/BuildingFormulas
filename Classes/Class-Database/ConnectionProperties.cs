//  
//  ConnectionProperties.cs
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
	public static class ConnectionProperties
	{
	    
#region Database And Program Startup Path
        
		//MusicManagerSqlite Database connection string.
		private static string dbCon = "Data Source=MusicManagerSqlite;Version=3;" +
                                                "New=False;Compress=True;";
  
		/// <summary>
		/// Property -- public static string DataBaseConnection
		/// 
		/// Gets the data base connection.
		/// </summary>
		/// <value>
		/// The data base connection.
		/// </value>
		public static string DataBaseConnection {
			get {
				return dbCon;
			}
        
		} //End Property
        
        
        
		private static string App_StartupPath {
			get {
				return System.IO.Path.GetFullPath ("Music-Manager.exe");  
			}                 
		} //End Property
     
		private static string DatabasePath {
			get {
				return System.IO.Path.GetFullPath ("MusicManagerSqlite");   
			}
         
		} //End Property
        
        #endregion Database And Program Startup Path
     
        
	} //End class ConnectionProperties
    
    
} //End namespace MusicManager

