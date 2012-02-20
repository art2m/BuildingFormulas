using System;
using System.IO;
using Mono.Data.Sqlite;
using System.Data;
using System.Data.Odbc;
using Gtk;
using System.Text;
using System.Threading;
using System.Windows.Forms;

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
		private string exMsg = null;
		private const string className = "ArtistDatabaseTable";
		private MessageDialog md = null;
		private StringBuilder sbMsg = null;
		private ResponseType rspRetVal;
		private Thread setErrMsg = null;
        
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
		} //End Property
        
        
		public bool ExecuteQuery (string myQuery)
		{ 
			bool retVal = false;
			SqliteCommand sqlCmd = null;
            
			try {
				methodName = "public bool ExecuteQuery(string myQuery)";
                   
				errMsg = "Encountered error while executing a query" +
                                     "  on the MusicManagerSqlite database.";
                   
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
           
				sqlCmd = dbCon.CreateCommand (); 
				sqlCmd.CommandText = myQuery; 
				sqlCmd.ExecuteNonQuery (); 
                   
				//All Ok
				retVal = true;
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
        
#endregion Store Sql Statement
		
		
		
		
		
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
			string retValMsg = null;
			
			
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
			
			
			SqliteCommand sqlCmd = null;
			ResponseType rspRetVal;
            
			MyMessages myMsg = null;
            
			try {
				methodName = "public bool UpdateArtistAddNewRecord( string" +
                              " artistName, string artistPath)";
				errMsg = "Update of record to database failed.";
                
				            
				sqlCmd = dbCon.CreateCommand ();                
             
				 	 
				//Add New record To Artist Table.                
				sqlCmd.CommandText = "insert into artistdata (" +
				" ArtistName, ArtistPath) " +
				"values (" + artistName + "," + artistPath + ")";
                
				
				//Runs Query
				sqlCmd.ExecuteNonQuery ();
				
				//All ok
				retVal = true;
						
				return retVal;
				
			} catch (InvalidOperationException ex) {
				if (myMsg == null) {
					myMsg = new MyMessages ();
				}
				myMsg.BuildErrorString (className, methodName, errMsg, 
                                        ex.Message.ToString ());
				return retVal;
			} catch (SqliteException ex) {   
                
//				if (myMsg == null) {
//					myMsg = new MyMessages ();
//				}
                
				
       
				/*
				if (myMsg == null) {
					myMsg = new MyMessages ();
				}
                
				
				myMsg.SetClassName = className;
				myMsg.SetMethodName = methodName;
				myMsg.SetErrorMessage = errMsg;
				string strMsg = ex.ToString ();
                
				myMsg.SetExceptionMessage = strMsg;
				myMsg.BuildNewErrorString ();
                
				setErrMsg = new Thread (myMsg.ShowNewErrMessage);
				setErrMsg.Start ();   
				
                
				
				//retValMsg = BuildNewErrorString ();
                
				//retValMsg = "hello there";
                
                */
				
				//Thread.CurrentThread.Join ();
				//string dlgtest = "SongTagWindow";
                
				md = new MessageDialog (null, DialogFlags.Modal, MessageType.Error, 
				ButtonsType.Ok, "Testing");
                
				rspRetVal = (ResponseType)md.Run ();
         
				md.Destroy ();
               
//				MessageDialog md = null;
//				
//				md = new MessageDialog (null, DialogFlags.Modal, MessageType.Error, 
//                                    ButtonsType.Ok, retValMsg);
//				rspRetVal = (ResponseType)md.Run ();
//         
//				md.Destroy ();
       
                
				//msgWin.ShowErrMessage (retValMsg);
                
				//msgWin.Show ();
                
				
                
                
				//msgWin.BuildErrorString (className, methodName, errMsg,
				//ex.Message.ToString ());
                
                
				//myMsg.ShowMessage (null, "Error Message", "Testing");
//				myMsg.BuildErrorString (className, methodName, errMsg, 
//                                        ex.Message.ToString ());
				return retVal;
			} finally {
                
				if (sqlCmd != null) {
					sqlCmd.Dispose ();  
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
			
			SqliteCommand sqlCmd = null;
            
			try {
				methodName = "public bool UpdateArtistEditRecord(int intIndex" +
                 " string artistName, string artistPath)";
                
				errMsg = "Update of record to database failed.";
                
				sqlCmd = dbCon.CreateCommand ();			
				//Update Artist Edit Record.			
				sqlCmd.CommandText = "UPDATE artistdata SET ArtistName =" +
               " artistName, SET ArtistPath = artistPath" +
               "WHERE PKey = intIndex";
                
				sqlCmd.ExecuteNonQuery ();
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
                
				if (sqlCmd != null) {
					sqlCmd.Dispose ();  
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
            
			SqliteCommand sqlCmd = null;	
            
			try {
				sqlCmd = dbCon.CreateCommand ();
				//Delete record from Artist Table.
				sqlCmd.CommandText = "DELETE FROM artistdata WHERE PKey = " + 
                                                                    intIndex;
				sqlCmd.ExecuteNonQuery ();				
				
				
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
                
				if (sqlCmd != null) {
					sqlCmd.Dispose ();  
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
      
				string sql = "SELECT * FROM artistdata";
				dbcmd.CommandText = sql;
				reader = dbcmd.ExecuteReader ();
				
				string artistName = null;
				string artistPath = null;		
				string primaryKey = null;
				
				//Read Artist Table and add To clsArtistCollectionl.
				while (reader.Read()) {
					//strArtistName = reader.GetDataTypeName(2);
					//strType = reader.GetDataTypeName(2);                    
                    
					artistName = reader ["ArtistName"].ToString ();
					artistPath = reader ["ArtistPath"].ToString ();
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
        
        
        #region Show MessageBox
        
		/// <summary>
		/// Method -- public void ShowErrMessage
		/// 
		/// Shows the error message.
		/// </summary>
		/// <param name='strMsg'>
		/// String message.
		/// </param>
		public void ShowErrMessage (string strMsg)
		{
            
			MessageDialog md = null;
         
			//string dlgtest = "SongTagWindow";
			md = new MessageDialog (null, DialogFlags.Modal, MessageType.Error, 
                                    ButtonsType.Ok, strMsg);
			rspRetVal = (ResponseType)md.Run ();
         
			md.Destroy ();
			
		} //End Method
  
		/// <summary>
		/// Method -- public void ShowSucessMessage
		/// 
		/// Shows the success message.
		/// </summary>
		/// <param name='strMsg'>
		/// String message.
		/// </param>
		public void ShowSuccessMessage (string strMsg)
		{
			MessageDialog md = null;
         
			md = new MessageDialog (null, DialogFlags.Modal, MessageType.Other, 
                                    ButtonsType.Ok, strMsg);
         
			md.Run ();
			md.Destroy ();
		} //End Method
  
		/// <summary>
		/// Method -- public void ShowInformationMessage
		/// Shows the information message.
		/// </summary>
		/// <param name='strMsg'>
		/// String message.
		/// </param>
		public void ShowInformationMessage (string strMsg)
		{
			MessageDialog md = null;            
         
			md = new MessageDialog (null, DialogFlags.Modal, MessageType.Info, 
                                    ButtonsType.Ok, strMsg);
         
     
			md.Run ();
			md.Destroy ();
		} //End Method
  
		/// <summary>
		/// Method -- public ResponseType showYesNoMessage
		/// 
		/// Shows the yes no message.
		/// </summary>
		/// <returns>
		/// The yes no message.
		/// </returns>
		/// <param name='strMsg'>
		/// String message.
		/// </param>
		public ResponseType ShowYesNoMessage (string strMsg)
		{
			//MessageDialog md = null;
			ResponseType rspRetVal;
         
			md = new MessageDialog (null, DialogFlags.Modal, 
                                    MessageType.Question, 
                                    ButtonsType.YesNo, strMsg);
			rspRetVal = (ResponseType)md.Run ();
         
			md.Destroy ();
			//All Ok
			return rspRetVal;
		} //End Method 
        
        
		public string BuildNewErrorString ()
		{
			sbMsg = new StringBuilder ();
         
			sbMsg.Append (className);
			sbMsg.AppendLine ();
			sbMsg.Append (methodName);
			sbMsg.AppendLine ();
			sbMsg.Append (errMsg);
			sbMsg.AppendLine ();
			sbMsg.Append (exMsg); 
            
			return sbMsg.ToString ();
            
		}
     #endregion
        
        
        
        
	} // End clsDatabase
	
} // End Namespace MusicFixer



