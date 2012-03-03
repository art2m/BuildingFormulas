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

//using Mono.Data.Sqlite;
using System.Data;
using System.Data.Odbc;
using System.Data.SQLite;

namespace MusicManager
{
	public class ArtistTable
	{
        
        #region Database Objects
		private System.Data.SQLite.SQLiteConnection dbCon;
		//private Mono.Data.Sqlite.SqliteConnection dbCon;
		private string strCon;
		private System.Data.SQLite.SQLiteDataAdapter sqlDA = null;
		//private Mono.Data.Sqlite.SqliteDataAdapter sqlDA = null;
		//private DataRow sqlDR = null;
		//private System.Data.DataRow sqlDR = null;
		private System.Data.DataSet sqlDS = new System.Data.DataSet ();
		//private DataSet sqlDS = new DataSet ();
		//private DataTable sqlDT = new DataTable ();
		//private System.Data.DataTable sqlDT = null;
		private System.Data.SQLite.SQLiteCommand sqlCMD = null;
		//private SqliteCommand sqlCMD = null;
        
		
		
     
        
#endregion Database Objects
        
#region Class Variables
		private const string sqlQuery = null;
		private string sqlLoadQuery = "SELECT * FROM Artist";
		private int index = 0;
		private string methodName = null;
		private string errMsg = null;
		private const string className = "ArtistTable";
#endregion Class Variables
        
		public ArtistTable ()
		{
		} //End Constructor
        
#region Open Close database
        
		
		

		public bool OpenDatabaseConnection ()
		{   
         
			bool retVal = false;
         
         
			try {
             
				methodName = "public bool OpenDatabaseConnection()";
                 
				strCon = ConnectionProperties.DataBaseConnection;
				dbCon = new System.Data.SQLite.SQLiteConnection (strCon);
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
			} catch (SQLiteException ex) {
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
			} catch (SQLiteException ex) {
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
        
		public void SetSqlQuery (string Val)
		{
			//sqlQuery = Val;
		}
        
        
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
            
           
			if (dbCon == null) {
				OpenDatabaseConnection ();
			}
			Console.WriteLine (dbCon.State.ToString ());
            
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
            
			try {
                
				methodName = "public bool LoadDatabase()";
				errMsg = "Encountered error while loading dataset" +
                                                            " and dataAdaptr";
         
				
				string sql = "SELECT * FROM Artist";

                
				sqlDA = new System.Data.SQLite.SQLiteDataAdapter (sql, dbCon);				
				sqlDS.Reset ();
				sqlDA.Fill (sqlDS);

				//DataTable dt = sqlDS.Tables ["artist"];
                 
             
				
                
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
			} catch (SQLiteException ex) {
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
                            
				string recordCnt = "SELECT COUNT(*) FROM Artist";
				rowCnt = Convert.ToInt32 (recordCnt);
                             
				return rowCnt;
			} catch (InvalidOperationException ex) {
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg, 
                                             ex.Message.ToString ());
				return rowCnt;
			} catch (SQLiteException ex) {
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
                                           
				string sql = "SELECT * FROM Artist";

                
				sqlDA = new System.Data.SQLite.SQLiteDataAdapter (sql, dbCon);              

				sqlDA.Fill (sqlDS);
                
				if (sqlDS == null) {
					Console.WriteLine ("DataSet is null.");
				}
               
				System.Data.DataTable sqlDT = new System.Data.DataTable ("Artist");
                
				//sqlDT = sqlDS.Tables ["Artist"];
                
				if (sqlDT == null) {
					Console.WriteLine ("The data table is null.");
				}
                
                
                
				System.Data.DataRow sqlDR = sqlDT.NewRow ();
                
				if (sqlDR == null) {
					Console.WriteLine ("DataRow is null.");
				}
                
				//DataRow sqlDR = sqlDT.NewRow ();
                
				//sqlDT = DataTable ["Artist"];
				//sqlDT = new DataTable ("Artist"); 
				//sqlDR = sqlDT ["Artist"].NewRow ();
                
				
				//sqlDR = sqlDT.Rows.Add ();
				
				int intCnt = sqlDT.Columns.Count;
				Console.WriteLine (intCnt.ToString ());
                
				bool bolRetVal = sqlDS.Tables.Contains ("ArtistName");
				if (bolRetVal) {
					Console.WriteLine ("Found it.");
				}
				string strTemp = sqlDR.GetColumnError ("ArtistName");
                
				Console.WriteLine (strTemp);
                
                
				strTemp = sqlDR.GetColumnError ("ArtistPath");
                
				Console.WriteLine (strTemp);
				
                
				//Console.WriteLine (sqlDR.RowState.ToString);
                
               
				sqlDR [1] = "Test"; //recArtist.ArtistName;
				sqlDR [2] = "Hello"; //recArtist.ArtistPath;
				sqlDS.Tables ["Artist"].Rows.Add (sqlDR);
                   
				//update database with chnages.
				sqlDA.Update (sqlDS);
                
				//All ok 
				retVal = true;
				return retVal;
			} catch (SQLiteException ex) {
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
                                            " in the artist table.";
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
			} catch (SQLiteException ex) {
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
		/// from the table Artist.
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
                                            " from the Artist table.";
				DataTable dt = new DataTable ();
				/*
				sqlDA.Fill (dt);
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
			} catch (SQLiteException ex) {
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


