//  
//  SongDatabaseTable.cs
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
	public class SongDatabaseTable
	{
		private string methodName = null;
		private string errMsg = null;
		private const string className = "SongDatabaseTable";
        
		public SongDatabaseTable ()
		{
		} //End constructor
        
        
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
				//dbCon = (System.Data.IDbConnection) 
				//new SqliteConnection(strCon);
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
                         
		}
     
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
        
		public bool UpdateSongAddNewRecord (string sngTitle, string sngPath,
                                               string sngTrack, string albumName,
                                               string artistName, string sngYear)
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
            
			SqliteCommand cmd = null;
            
			MyMessages myMsg = null;
            
			try {
				methodName = "public bool UpdateSongAddNewRecord";
                   
				errMsg = "Update of record to database failed.";
                   
				cmd = dbCon.CreateCommand ();
                
				//Add new record to Song Table
				cmd.CommandText = "INSERT INTO song-data (Song-Title" +
                 " Song-Path, Song-Track, Album-Name, Artist-Name, Song-Year) " +
                 "VALUES  (sngTitle, sngPath, sngTrack, albumName," +
                     " artistName, sngYear)";
                   
				//Runs Query
				cmd.ExecuteNonQuery ();
                
				//All ok
				retVal = true;
				myMsg = new MyMessages ();
				myMsg.ShowSuccessMessage ("Song table update completed" +
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
        
		public bool UpdateSongEditRecord (int intIndex, string sngTitle, 
                                          string sngPath, string sngTrack, 
                                          string albumName, string artistName, 
                                          string sngYear)
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
				methodName = "public bool UpdateSongEditRecord(int intIndex," +
                  " string sngTitle, string sngPath, string sngTrack," +
                  " string albumName, string artistName, string sngYear)";
                 
				errMsg = "Update of record to database failed.";
                
				cmd = dbCon.CreateCommand ();
 			
				cmd.CommandText = "UPDATE song-data SET Song-Title = sngTitle" +
               " SET Song-Path = sngPath, SET Song-Track = sngTrack," +
               " SET Album-Name = albumName, SET Artist-Name = artistName" +
               " SET Song-Year = sngYear WHERE PKey = intIndex"; 
                       
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
            
			errMsg = "Encountered error while trying to delete this record";
            
			SqliteCommand cmd = null;   
            
			try {
				methodName = "public bool UpdateDeleteRecords(int intIndex)";
                
				cmd = dbCon.CreateCommand ();             
             
				//Delete Record from Song Table
				cmd.CommandText = "DELETE FROM song-data WHERE PKey = " + 
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
        
        
        
#region Read Tables Song
        
		public bool ReadSongTable ()
		{
			bool retVal = false;
			SongRecord recSong = null;
            
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
				methodName = "public bool ReadSongTable()";
				errMsg = "Encountered error while reading Song database" +
                                                                    " table.";    
				string sql = "SELECT * FROM song-data";
				dbcmd.CommandText = sql;
				reader = dbcmd.ExecuteReader ();
                

				string sngTitle = null;
				string sngPath = null;
				string sngTrack = null;
				string albumName = null;
				string artistName = null;
				string sngYear = null;
				string primaryKey = null;
                
                
                
				//Read Album Table and add To clsArtistCollectionl.
				while (reader.Read()) {
                     
					sngTitle = reader ["Song-Title"].ToString ();
					sngPath = reader ["Song-Path"].ToString ();
					sngTrack = reader ["Song-Track"].ToString ();
					albumName = reader ["Album-Name"].ToString ();
					artistName = reader ["Artist-Name"].ToString ();
					sngYear = reader ["Song-Year"].ToString ();
					primaryKey = reader ["PKey"].ToString ();
                    
					recSong = new SongRecord ();
                    
					recSong.SongName = sngTitle;
					recSong.SongPath = sngPath;
					recSong.SongTrackNumber = sngTrack;
					recSong.AlbumName = albumName;
					recSong.ArtistName = artistName;
					recSong.YearSongCreated = sngYear;
					recSong.SongPrimaryKey = primaryKey;
                    
					SongCollection.AddNewItem (recSong);
				}
                
				//All ok
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
        
#endregion Read Tables Song
        
        
	} //End class SongDatabaseTable
    
} //End namespace MusicManager

