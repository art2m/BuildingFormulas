//  
//  Artist-Db-Table.cs
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
using System.Data;
using System.Data.SQLite;

namespace ClassesClassDatabase
{
	public class Artist_Db_Table
	{
        
		private SQLiteConnection sql_con;
		private SQLiteCommand sql_cmd;
		private SQLiteDataAdapter objDA;
		private DataSet dsArtist = new DataSet ();
		private DataTable datTable = new DataTable ();
        
		public Artist_Db_Table ()
		{
		} //End Constructor
        
		/// <summary>
		/// Method -- public void SetConnection()
		/// 
		/// Sets the connection.
		/// </summary>
		public void SetConnection ()
		{
			sql_con = new SQLiteConnection
                ("Data Source=MusicManagerSqlite;Version=3;New=False;" +
                 " Compress=True;"); 
		} //End Method
        
        
		/// <summary>
		/// Method -- public void ExecuteQuery
		/// 
		/// Executes the query.
		/// </summary>
		/// <param name='query'>
		/// Query.
		/// </param>
		public void ExecuteQuery (string query)
		{
			SetConnection (); 
			sql_con.Open (); 
			sql_cmd = sql_con.CreateCommand (); 
			sql_cmd.CommandText = query;
			sql_cmd.ExecuteNonQuery (); 
			sql_con.Close (); 
		} //End Method
        
		public void LoadArtistData ()
		{
			SetConnection (); 
			sql_con.Open (); 
			sql_cmd = sql_con.CreateCommand (); 
			string CommandText = "select *, MusicManagerSqlite from Artist-Data"; 
			objDA = new SQLiteDataAdapter (CommandText, sql_con); 
			dsArtist.Reset (); 
			objDA.Fill (dsArtist); 
			datTable = dsArtist.Tables ["artist-data"];
			//Grid.DataSource = datTable; 
			sql_con.Close (); 
		}
        
		public void Add ()
		{
			//string txtSQLQuery = "insert into  mains (desc) values ('" + txtDesc.Text + "')";
			//ExecuteQuery (txtSQLQuery);            
		}
        
	} //End Class Artist_db_Table
    
} //End namespace MusicManager

