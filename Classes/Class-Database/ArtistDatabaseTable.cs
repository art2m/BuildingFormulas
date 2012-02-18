using System;
using System.IO;
using Mono.Data.Sqlite;
using System.Data;

namespace MusicManager
{
	public class ArtistDatabaseTable
	{
		
		#region Class Level Data Objects
		//private  Mono.Data.Sqlite.SqliteDataAdapter objDa = 
		//new Mono.Data.Sqlite.SqliteDataAdapter();
		
		//private DataSet objArtistDs = new System.Data.DataSet();		
		//private DataSet objAlbumDs = new System.Data.DataSet();		
		//private DataSet objSongDs = new System.Data.DataSet();	
		
		#endregion
		
		private string methodName = null;
		private string errMsg = null;
		private const string className = "ArtistDatabaseTable";
		
		public ArtistDatabaseTable ()
		{
		}
		
		
		
		#region Store Sql Statement
		private string sqlStatement;

		public string FillSqlCommand {
			get {
				return sqlStatement;
			}
			
			set {
				sqlStatement = value;
			}
		}
		#endregion
		
		
		
		
		
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
          
				
#region Update Add New Records
        
		public bool UpdateArtistAddNewRecord (string artistName, 
                                                            string artistPath)
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
				methodName = "public bool UpdateArtistAddNewRecord( string" +
                              " artistName, string artistPath)";
				errMsg = "Update of record to database failed.";
                
				cmd = dbCon.CreateCommand ();
				 	 
				//Add New record To Artist Table.
				cmd.CommandText = "INSERT INTO  artist-data (" +
              " Artist-Name, Artist-Path) " +
					"VALUES (artistName, artistPath)";
				//Runs Query
				cmd.ExecuteNonQuery ();
				
				//All ok
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
		
		
#endregion Update Add New Records
		
		
		
		
#region Update Edit Records
        
		public bool UpdateArtistEditRecord (int intIndex, string artistName,
                                            string artistPath)
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
				methodName = "public bool UpdateArtistEditRecord(int intIndex" +
                 " string artistName, string artistPath)";
                
				errMsg = "Update of record to database failed.";
                
				cmd = dbCon.CreateCommand ();			
				//Update Artist Edit Record.			
				cmd.CommandText = "UPDATE artist-data SET Artist-Name =" +
               " artistName, SET Artist-Path = artistPath" +
               "WHERE PKey = intIndex";
                
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
				cmd = dbCon.CreateCommand ();
				//Delete record from Artist Table.
				cmd.CommandText = "DELETE FROM artist-data WHERE PKey = " + 
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
		
	
		
		
#region Read Tables Artist
		
		public bool ReadArtistTable ()
		{
			
			bool retVal = false;
            
			ArtistRecord recArtist = null;
						
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
      
				string sql = "SELECT * FROM artist-data";
				dbcmd.CommandText = sql;
				reader = dbcmd.ExecuteReader ();
				
				string artistName = null;
				string artistPath = null;		
				string primaryKey = null;
				
				//Read Artist Table and add To clsArtistCollectionl.
				while (reader.Read()) {
					//strArtistName = reader.GetDataTypeName(2);
					//strType = reader.GetDataTypeName(2);                    
                    
					artistName = reader ["Artist-Name"].ToString ();
					artistPath = reader ["Artist-Path"].ToString ();
					primaryKey = reader ["PKey"].ToString ();
                    
					recArtist = new ArtistRecord ();
					
					recArtist.ArtistName = artistName;
					recArtist.ArtistPath = artistPath;
					recArtist.ArtistPrimaryKey = primaryKey;
                    
					ArtistCollection.AddNewItem (recArtist);
					
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
		
		
#endregion Read Tables Artist
        
        
        
        
	} // End clsDatabase
	
} // End Namespace MusicFixer



