//  
//  ArtistDatabaseMovement.cs
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
/// Class -- ArtistDatabaseMovement
/// 
///  Used to move First, Next, Previous, Last.
/// threw the Artist data in the database.
/// </summary>
using System;
using System.IO;
using Mono.Data.Sqlite;
using System.Data;
using System.Data.Odbc;

namespace MusicManager
{
	public class ArtistDatabaseMovement
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
        
		public ArtistDatabaseMovement ()
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
        
        
#region Move threw rows.
        
		/// <summary>
		/// Method -- public bool LoadDatabase
		/// 
		/// Creates connections to Database.
		/// </summary>
		/// <returns>
		/// The database.
		/// </returns>
		public bool LoadDatabase ()
		{
			bool retVal = false;
            
			try {
                
				methodName = "public bool LoadDatabase()";
				errMsg = "Encountered error while loading dataset" +
                                                            " and dataAdaptr";
			
				odbCon = new OdbcConnection (
                                    ConnectionProperties.DataBaseConnection);
				odbCon.Open ();               
                
					
             
				da = new OdbcDataAdapter ("select * from artist-data", odbCon);
				OdbcCommandBuilder builder = new OdbcCommandBuilder (da);
				ds = new DataSet ();
				da.Fill (ds, "artist-data");
                
				//All ok
				retVal = true;
				return retVal;
			} catch (InvalidOperationException ex) {
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg,
                                       ex.Message.ToString ());
				return retVal;                
			} catch (NullReferenceException ex) {
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg,
                                       ex.Message.ToString ());
				return retVal;                
			} catch (SqliteException ex) {
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg,
                                       ex.Message.ToString ());
				return retVal;                
			}
            
		} //End Method
        
        
		/// <summary>
		/// Method -- public int GetRowCountFromTable
		/// 
		/// Gets the row count from table.
		/// </summary>
		/// <returns>
		/// The row count from table.
		/// </returns>
		public int GetRowCountFromTable ()
		{
                  
			int rowCnt = -1;
			try {
                      
				methodName = "public int GetRowCountFromTable()";
                      
				errMsg = "Encountered error while getting row count.";
                      
				//If connection not open then open the connection.
				if (dbCon.State != ConnectionState.Open) {
                             
					bool retVal = this.OpenDatabaseConnection ();                    
					//unable to open connection.
					if (retVal != true) {               
						return rowCnt;  
					} 
				} 
                            
				string recordCnt = "SELECT COUNT(*) FROM artist-data";
				rowCnt = Convert.ToInt32 (recordCnt);
                             
				return rowCnt;
			} catch (InvalidOperationException ex) {
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg, 
                                             ex.Message.ToString ());
				return rowCnt;
			} catch (SqliteException ex) {
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg, 
                                             ex.Message.ToString ());
				return rowCnt;  
			}
                  
		} //End Method
        
		
		/// <summary>
		/// Method -- public string[] MoveToFirstRecord
		/// 
		/// Moves to first record.
		/// </summary>
		/// <returns>
		/// The to first record.
		/// </returns>
		public string[] MoveToFirstRecord ()
		{
			string [] recRow = null;
            
		
			try {
				methodName = "public void MoveToFristRecord";
                                      
				errMsg = "Encountered error while moving to first record.";                           
                 
                                        
				if (ds.Tables ["artist-data"].Rows.Count > 0) {
                           
					index = 0;
                                
					recRow = new string[2];
                                
					recRow [0] = ds.Tables ["artist-data"].Rows [index] 
                                                ["Artist-Name"].ToString ();
					recRow [1] = ds.Tables ["artist-data"].Rows [index]
                                                ["Artist-Path"].ToString ();
					recRow [2] = ds.Tables ["artist-data"].Rows [index] 
                                                       ["PKey"].ToString ();
				}
                
				//All ok
				return recRow;
			} catch (InvalidOperationException ex) {
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg,
                                       ex.Message.ToString ());
				return recRow;
			} catch (NullReferenceException ex) {
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg,
                                       ex.Message.ToString ());
				return recRow;
			} catch (SqliteException ex) {
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg,
                                       ex.Message.ToString ());
				return recRow; 
			}         
            
		} //End Method
        
        
		/// <summary>
		/// Method -- public string[] MoveToNextRecord
		/// 
		/// Moves to next record.
		/// </summary>
		/// <returns>
		/// The to next record.
		/// </returns>
		public string[] MoveToNextRecord ()
		{
            
			string[] recRow = null;
            
			try {
				methodName = "public string[] MoveToNextRecord()";
             
				errMsg = "Encountered error while moving to next record.";
             
				if (index < ds.Tables ["artist-data"].Rows.Count - 1) {
					index++;
                 
					recRow = new string[2];
                 
					recRow [0] = ds.Tables ["artist-data"].Rows [index] 
                                                ["Artist-Name"].ToString ();
					recRow [1] = ds.Tables ["artist-data"].Rows [index] 
                                                ["Artist-Path"].ToString ();
					recRow [2] = ds.Tables ["artist-data"].Rows [index] 
                                                       ["PKey"].ToString ();
                 
				}            
             
				//All ok
				return recRow;
			} catch (InvalidOperationException ex) {
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg,
                                       ex.Message.ToString ());
				return recRow;
			} catch (NullReferenceException ex) {
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg,
                                       ex.Message.ToString ());
				return recRow;
			} catch (SqliteException ex) {
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg,
                                       ex.Message.ToString ());
				return recRow; 
			}         
            
		} //End Method
        
        
		/// <summary>
		/// Method -- public string[ MoveToPreviousRecord
		/// 
		/// Moves to previous record.
		/// </summary>
		/// <returns>
		/// The to previous record.
		/// </returns>
		public string[] MoveToPreviousRecord ()
		{
			string[] recRow = null;
            
			try {
				methodName = "public string[] MoveToPreviousRecord()";
                      
				errMsg = "Encountered error while moving to Previous record.";
                      
				if (index == ds.Tables ["artist-data"].Rows.Count - 1 || 
                                                                index != 0) {
                          
					index--;
                          
					recRow = new string[2];
                          
					recRow [0] = ds.Tables ["artist-data"].Rows [index] 
                                                ["Artist-Name"].ToString ();
					recRow [1] = ds.Tables ["artist-data"].Rows 
                                        [index] ["Artist-Path"].ToString ();
					recRow [2] = ds.Tables ["artist-data"].Rows [index] 
                                                        ["PKey"].ToString ();
				}
                      
                      
				//All Ok
				return recRow;
			} catch (InvalidOperationException ex) {
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg,
                                       ex.Message.ToString ());
				return recRow;
			} catch (NullReferenceException ex) {
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg,
                                       ex.Message.ToString ());
				return recRow;
			} catch (SqliteException ex) {
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg,
                                       ex.Message.ToString ());
				return recRow; 
			}         
		} //End Method        
        
		/// <summary>
		/// Method -- public string[] MoveToLastRecord
		/// 
		/// Moves to last record.
		/// </summary>
		/// <returns>
		/// The to last record.
		/// </returns>
		public string[] MoveToLastRecord ()
		{
			string[] recRow = null;
            
			try {
				methodName = "public string[] MoveToLastRecord()";
                      
				errMsg = "Encountered error while moving to last record.";
                      
				index = ds.Tables ["artist-data"].Rows.Count - 1;
                      
				if (index > 0) {                
                     
					recRow = new string[2];
                      
					recRow [0] = ds.Tables ["artist-data"].Rows [index] 
                                                ["Artist-Name"].ToString ();
					recRow [1] = ds.Tables ["artist-data"].Rows [index] 
                                                ["Artist-Path"].ToString ();
					recRow [2] = ds.Tables ["artist-data"].Rows [index] 
                                                ["PKey"].ToString ();
				}
                      
				//All Ok
				return recRow;
			} catch (InvalidOperationException ex) {
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg,
                                       ex.Message.ToString ());
				return recRow;
			} catch (NullReferenceException ex) {
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg,
                                       ex.Message.ToString ());
				return recRow;
			} catch (SqliteException ex) {
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg,
                                       ex.Message.ToString ());
				return recRow; 
			}         
            
		} //End Method
        
#endregion Move threw rows.
        
        
	} // End class ArtistDatabaseMovement
    
} //End namespace MusicManager

