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

using System.IO;
using Mono.Data.Sqlite;
using System.Data;
using System.Data.Odbc;

namespace MusicManager
{
	public class ArtistTable
	{
        
        #region Database Objects
        
		private IDataAdapter da = null;
		private DataSet ds = null;
		private int index = 0;
		
       
        
#endregion Database Objects
        
#region Class Variables
        
		private string methodName = null;
		private string errMsg = null;
		private const string className = "ArtistTable";
        
#endregion Class Variables
        
		public ArtistTable ()
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
         
				
				string sql = "SELECT * FROM artistdata";
//				IDbCommand dbcmd = dbCon.CreateCommand ();
//				dbcmd.CommandText = sql;
                
				da = new Mono.Data.Sqlite.SqliteDataAdapter (sql, dbCon);
				
				ds = new DataSet ();

				da.Fill (ds);

				DataTable dt = ds.Tables ["artistdata"];
                 
             
				
                
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
                            
				string recordCnt = "SELECT COUNT(*) FROM artistdata";
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
		///Method -- public bool AddNewRecord (ArtistRecord recArtist)
		/// 
		/// Adds the new record.
		/// </summary>
		/// <returns>
		/// The new record.
		/// </returns>
		/// <param name='recArtist'>
		/// If set to <c>true</c> rec artist.
		/// </param>
		public bool AddNewRecord (ArtistRecord recArtist)
		{
			bool retVal = false;
			try {
				methodName = "public void AddNewRecord (" +
                                                " ArtistRecord recArtist)";
                
				errMsg = "Encountered error while adding new record" +
                                        " to the Artist database tabel.";
                
				DataRow artistRow = ds.Tables ["artistdata"].NewRow (); 
				artistRow ["ArtistName"] = recArtist.ArtistName;
				artistRow ["ArtistPath"] = recArtist.ArtistPath;
				ds.Tables ["artistdata"].Rows.Add (artistRow);
                   
				//update database with chnages.
				da.Update (ds);
                
				//All ok 
				retVal = true;
				return retVal;
			} catch (SqliteException ex) {
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg,
                                       ex.Message.ToString ());     
				return retVal;
			} catch (ArgumentNullException ex) {
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg,
                                       ex.Message.ToString ()); 
				return retVal;
			} catch (InvalidOperationException ex) {
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg,
                                       ex.Message.ToString ());  
				return retVal;
			}       

		} //End Method 
        
        
		/// <summary>
		/// Method -- public bool EditRecord (ArtistRecord recArtist)
		/// 
		/// Edits the record that matches the primary key.
		/// </summary>
		/// <returns>
		/// The record.
		/// </returns>
		/// <param name='recArtist'>
		/// If set to <c>true</c> rec artist.
		/// </param>
		public bool EditRecord (ArtistRecord recArtist)
		{            
			int key = 0;
			bool retVal = false;
            
			try {
				methodName = "public void EditRecord (" +
                                                " ArtistRecord recArtist)";
				errMsg = "Encountered error while editing a record" +
                                            " in the artistdata table.";
				int intPKey = Convert.ToInt32 (recArtist.ArtistPrimaryKey);
				/*
				DataTable dt = new DataTable ();
				
                   
				foreach (DataRow row in dt.Rows) {
					key = Convert.ToInt32 (row ["PKey"]);
					if (key == intPKey) {
						row ["ArtistName"] = recArtist.ArtistName;
						row ["ArtistPath"] = recArtist.ArtistPath;
						row.AcceptChanges ();
					}
				}
                */
				//All Ok
				retVal = true;
				return retVal;
			} catch (SqliteException ex) {
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg,
                                       ex.Message.ToString ());  
				return retVal;
			} catch (ArgumentNullException ex) {
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg,
                                       ex.Message.ToString ());   
				return retVal;
			}
		
		} //End Method 
        
        
		/// <summary>
		/// Method -- public bool DeleteRecord(int intPKey)
		/// 
		/// Deletes the record that matches the Primary key
		/// from the table artistdata.
		/// </summary>
		/// <returns>
		/// The record.
		/// </returns>
		/// <param name='intPKey'>
		/// If set to <c>true</c> int P key.
		/// </param>
		public bool DeleteRecord (int intPKey)
		{
			int key = 0;
			bool retVal = false;
            
			try {
				methodName = "public void DeleteRecord(int intPKey)";
				errMsg = "Encountered error while deleting a record" +
                                            " from the artistdata table.";
				DataTable dt = new DataTable ();
				/*
				da.Fill (dt);
				foreach (DataRow row in dt.Rows) {
					key = Convert.ToInt32 (row ["PKey"]);
					if (key == intPKey) {
						row.Delete ();
						row.AcceptChanges ();
					}
				}
    */         
				//All ok 
				retVal = true;
				return retVal;
			} catch (SqliteException ex) {
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg,
                                       ex.Message.ToString ());  
				return retVal;
			} catch (ArgumentNullException ex) {
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg,
                                       ex.Message.ToString ());  
				return retVal;
			}
        
		}  //End Method 
        
        
	} //End class ArtistTable
    
} //End namespace MusicManager


