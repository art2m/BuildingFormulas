//  
//  AlbumDatabaseTable.cs
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
using System.IO;
using Mono.Data.Sqlite;
using System.Data;

namespace MusicManager
{
	public class AlbumDatabaseTable
	{
        
		private string methodName = null;
		private string errMsg = null;
		private const string className = "AlbumDatabaseTable";
        
		public AlbumDatabaseTable ()
		{
		} //End Constructor
        
#region Open Close database
        
		//private System.Data.IDbConnection dbCon;
		private Mono.Data.Sqlite.SqliteConnection dbCon;
		//private bool bolCon;
		private string strCon;

		public bool OpenDatabaseConnection ()
		{   
         
			bool retVal = false;
         
         
			try {
             
				methodName = "public bool OpenDatabaseConnection()";
                 
				strCon = ConnectionProperties.DataBaseConnection;
				dbCon = new Mono.Data.Sqlite.SqliteConnection (strCon);
				//dbCon = (System.Data.IDbConnection) new 
				//SqliteConnection(strCon);
				dbCon.Open ();
             
				retVal = true;      
				return retVal;
          
			} catch (InvalidOperationException ex) {
				errMsg = "Unable to open database.";
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg,
                                       ex.Message.ToString ());
				return retVal;
			} catch (SqliteException ex) {
				errMsg = "Unable to open database.";
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg,
                                       ex.Message.ToString ());
				return retVal;  
			}       
                         
		} //End Method
     
		public bool CloseConnection ()
		{   
			bool retVal = false;
			try {
				methodName = "public bool CloseConnection()";
				errMsg = "Encountered error while closing database.";
				dbCon.Close ();
               
				//All ok
				retVal = true;
				return retVal;
                
			} catch (InvalidOperationException ex) {
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg, 
                                       ex.Message.ToString ());
				return retVal;
			} catch (SqliteException ex) {
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg, 
                                       ex.Message.ToString ());
				return retVal; 
			} finally {
				if (dbCon.State != ConnectionState.Closed) {
					dbCon.Close ();
					MyMessages myMsg = new MyMessages ();
					myMsg.ShowInformationMessage ("Database connection" +
                                                              " closed.");   
				}
             
			}
            
     
		} //End Method
        
#endregion Open Close database
        
        
#region Update Add New Records
        
		public bool UpdateAlbumAddNewRecord (string albumName, 
                                            string trackCount, string discCount, 
                                            string discNumber, string albumPath, 
                                            string albumYear, string albumGenre,
                                             string artistName)
		{
			bool retVal = false;            
               
               
               
			//If connection not open then open the connection.
			if (dbCon.State != ConnectionState.Open) {
                   
				retVal = this.OpenDatabaseConnection ();                    
				//unable to open connection.
				if (retVal != true) {               
					return retVal;  
				} else {
					retVal = false; 
				}
			}
                  
			MyMessages myMsg = null;
               
			SqliteCommand cmd = null;
                  
			try {
				methodName = "public bool UpdateAlbumAddNewRecord(string" +
              "albumName, string trackCount, string discCount, string" +
              " albumPath, string albumYear, string albumGenre, string" +
              " artistName";
                          
				errMsg = "Update of record to database failed.";
                      
				cmd = dbCon.CreateCommand ();
                   
				//Add new record to Album Table
				cmd.CommandText = "INSERT INTO album-data (Album-Name," +
                     " Track-Count,Disc-Count, Disc-Number, Album-Path, Album-Year," +
                     " Album-Genre, Artist-Name) " +
                       "VALUES (albumName, trackCount, discCount, discNumber," +
                       " albumPath, albumYear, albumGenre, artistName)";
				//Runs Query
				cmd.ExecuteNonQuery ();
                   
				//All ok
				retVal = true;
				myMsg = new MyMessages ();
				myMsg.ShowSuccessMessage ("Album table update completed" +
                                                             " successfully.");         
				return retVal;
                   
			} catch (InvalidOperationException ex) {
				if (myMsg == null) {
					myMsg = new MyMessages ();
				}
				myMsg.BuildErrorString (className, methodName, errMsg,
                                             ex.Message.ToString ());
				return retVal;
			} catch (SqliteException ex) {
				if (myMsg == null) {
					myMsg = new MyMessages ();
				}
				myMsg.BuildErrorString (className, methodName, errMsg, 
                                              ex.Message.ToString ());
				return retVal;
			} finally {
                      
				if (cmd != null) {
					cmd.Dispose ();  
				}               
				this.CloseConnection ();
			}       
               
		} //End Method
        
#endregion Update Add New Records
        
    
        
#region Update Edit Records
        
		public bool UpdateAlbumEditRecord (int intIndex, string albumName, 
                                            string trackCount, string discCount, 
                                            string discNumber, string albumPath, 
                                            string albumYear, string albumGenre,
                                             string artistName)
		{
			bool retVal = false;
            
            
            
			//If connection not open then open the connection.
			if (dbCon.State != ConnectionState.Open) {
                
				retVal = this.OpenDatabaseConnection ();                    
				//unable to open connection.
				if (retVal != true) {               
					return retVal;  
				} else {
					retVal = false; 
				}
			}       
            
			MyMessages myMsg = null;
               
			SqliteCommand cmd = null;
               
			try {
				methodName = "public bool UpdateAlbumEditRecord(int intIndex," +
                " string albumName string trackCount, string discCount," +
                " string discNumber, string albumPath, string albumYear," +
                 " string albumGenre, string artistName)";
                
				errMsg = "Update of record to database failed.";
                
				cmd = dbCon.CreateCommand ();
                
				cmd.CommandText = "UPDATE album-data SET Album-Name =" +
               " albumName, SET Track-Count = trackCount, SET Disc-Count =" +
               " discCount, SET Disc-Number = discNumber, SET Album-Path =" +
               " albumPath, SET Album-Year = albumYear, SET Album-Genre =" +
               " albumGenre, SET Artist-Name = artistName" +
                " WHERE PKey = intIndex";
                
				cmd.ExecuteNonQuery ();
				retVal = true;
                   
				myMsg = new MyMessages ();
				myMsg.ShowSuccessMessage ("Artist table update completed" +
                                                             " successfully.");                                          
				return retVal;
			} catch (InvalidOperationException ex) {
				if (myMsg == null) {
					myMsg = new MyMessages ();
				}
				myMsg.BuildErrorString (className, methodName, errMsg,
                                          ex.Message.ToString ());
				return retVal;
			} catch (SqliteException ex) {
				if (myMsg == null) {
					myMsg = new MyMessages ();
				}
				myMsg.BuildErrorString (className, methodName, errMsg, 
                                           ex.Message.ToString ());
				return retVal;
			} finally {
                   
				if (cmd != null) {
					cmd.Dispose ();  
				}               
				this.CloseConnection ();
			}       
		} //End Method
         
#endregion Update Edit Records
        
        
#region Update Delete Records
        
		public bool UpdateDeleteRecords (int intIndex)
		{
			bool retVal = false;                
            
            
			//If connection not open then open the connection.
			if (dbCon.State != ConnectionState.Open) {
                
				retVal = this.OpenDatabaseConnection ();                    
				//unable to open connection.
				if (retVal != true) {               
					return retVal;  
				} else {
					retVal = false; 
				}
			}       
            
			MyMessages myMsg = null;
               
			SqliteCommand cmd = null;   
               
			try {
				methodName = "public bool UpdateDeleteReord(int index)";
                
				errMsg = "Encountered error while trying to delete this record";
                
				cmd = dbCon.CreateCommand ();
                   
				//Delete Record from Album Table
				cmd.CommandText = "DELETE FROM album-data WHERE PKey = " + 
                                                                    intIndex;
				cmd.ExecuteNonQuery ();
           
				retVal = true;
                
				myMsg = new MyMessages ();
                   
				myMsg.ShowSuccessMessage ("The record has been deleted" +
                                                             " successfully");
                            
				return retVal;
                
			} catch (InvalidOperationException ex) {
				if (myMsg == null) {
					myMsg = new MyMessages ();
				}
				myMsg.BuildErrorString (className, methodName, errMsg,
                                          ex.Message.ToString ());
				return retVal;
			} catch (SqliteException ex) {
				if (myMsg == null) {
					myMsg = new MyMessages ();
				}
				myMsg.BuildErrorString (className, methodName, errMsg, 
                                           ex.Message.ToString ());
				return retVal;
			} finally {
                   
				if (cmd != null) {
					cmd.Dispose ();  
				}               
				this.CloseConnection ();
			}       
            
		} //End Method
        
#endregion Update Delete Records
        
    
#region Read Tables Album
        
		public bool ReadAlbumTable ()
		{
			bool retVal = false;
			AlbumRecord recAlbum = null;
                        
			//If connection not open then open the connection.
			if (dbCon.State != ConnectionState.Open) {
                
				retVal = this.OpenDatabaseConnection ();                    
				//unable to open connection.
				if (retVal != true) {               
					return retVal;  
				} else {
					retVal = false; 
				}
			}       
            
            
			IDbCommand dbcmd = dbCon.CreateCommand ();
			IDataReader reader = null;
			try {   
				methodName = "public bool ReadAlbumTable()";
				errMsg = "Encountered error while reading Album database" +
                                                                    " table.";
                
				string sql = "SELECT * FROM album-data";
				dbcmd.CommandText = sql;
				reader = dbcmd.ExecuteReader ();

				string albumName = null;
				string trackCount = null;
				string discCount = null;
				string discNumber = null;
				string albumPath = null;
				string albumYear = null;
				string albumGenre = null;
				string artistName = null;
				string primaryKey = null;
                
//			Album-Name," +
//                     " Track-Count,Disc-Count, Disc-Number, Album-Path, Album-Year," +
//                     " Album-Genre, Artist-Name
                
				//Read Album Table and add To clsArtistCollectionl.
				while (reader.Read()) {
                     
					albumName = reader ["Album-Name"].ToString ();
					trackCount = reader ["Track-Count"].ToString ();
					discCount = reader ["Disc-Count"].ToString ();
					discNumber = reader ["Disc-Number"].ToString ();
					albumPath = reader ["Album-Path"].ToString ();
					albumYear = reader ["Album-Year"].ToString ();
					albumGenre = reader ["Album-Genre"].ToString ();
					artistName = reader ["Artist-Name"].ToString ();
					primaryKey = reader ["PKey"].ToString ();
                    
					recAlbum = new AlbumRecord ();
                    
					recAlbum.AlbumName = albumName;
					recAlbum.SongTracksTotalCount = trackCount;
					recAlbum.TotalDiscCount = discCount;
					recAlbum.DiscNumber = discNumber;
					recAlbum.AlbumPath = albumPath;
					recAlbum.YearOfAlbum = albumYear;
					recAlbum.AlbumGenre = albumGenre;
					recAlbum.ArtistName = artistName;
					recAlbum.AblumPrimaryKey = primaryKey;
                    
					AlbumCollection.AddNewItem (recAlbum);     
				}  
				//All Ok
				retVal = true;
				return retVal;
                
			} catch (InvalidOperationException ex) {
				MyMessages myMsg = new  MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg,
                                       ex.Message.ToString ());
				return retVal;
			} catch (SqliteException ex) {
				MyMessages myMsg = new  MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg,
                                       ex.Message.ToString ());
				return retVal;
			} finally {
                
				if (dbcmd != null) {
					dbcmd.Dispose ();  
				} 
				if (reader != null) {
					reader.Dispose ();
				}
				this.CloseConnection ();
			}   
            
            
		} //End Method
        
#endregion Read Tables Album
        
        
	} //End class AlbumDatabaseTable
    
} //End namespace MusicManager

