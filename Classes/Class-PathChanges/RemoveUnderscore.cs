//  
//  clsRemoveUnderscore.cs
//  
//  Author:
//       art2m <${AuthorEmail}>
// 
//  Copyright (c) 2011 art2m
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
/// clsRemoveUnderscore
/// 
/// This class removes the underscore character from the path name of a directory 
/// or the path name of a song. It then replaces the underscore character that was removed
/// with a space.
/// </summary>
using System;
using System.Text;
using System.Diagnostics;

namespace MusicManager
{
	public class RemoveUnderscore
	{
		
		
		private string methodName = "";
		private string errMsg = "";
		private const string className = "clsRemoveUnderscore";
		
		//Constructor
		public RemoveUnderscore ()
		{
		}
		
		/// <summary>
		/// Method -- public string RemoveUnderscore(string strPath)
		/// 
		/// This removes all the underscore characters from
		/// the path name of the directory, song name or song path.
		/// </summary>
		/// <returns>
		/// String strPath.
		/// </returns>
		/// <param name='strPath'>
		/// String strPath.
		/// </param>
		public string RemoveUnderscoreFromSongPath (string strPath)
		{
			string retVal = null;
			
				
			try {
				methodName = "public string RemoveUnderscore(string strPath)";
				errMsg = "Encountered error while removing the " +
                                                     "Underscore character.";
				
				string[] strTemp = strPath.Split ('_');
			
				retVal = InsertSpaces (strTemp);
				
				
				return retVal;	
			} catch (ArgumentNullException ex) {
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg, 
                                                    ex.Message.ToString ());
				return retVal;
			} catch (IndexOutOfRangeException ex) {
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg, 
                                                    ex.Message.ToString ());
				return retVal;  
			}
			
		} //End Method 
		
		
		/// <summary>
		/// Method public string InsertSpaces(string[] strPath)
		/// 
		/// This inserts spaces into the path name of the 
		/// directoy, song name or song path.
		/// </summary>
		/// <returns>
		/// String strPath.
		/// </returns>
		/// <param name='strPath'>
		/// String[] strPath.
		/// </param>
		public string InsertSpaces (string[] strPath)
		{
			string retVal = "";
			
			try {
				methodName = "public string InsertSpaces(string[] strPath)";
				errMsg = "Encountered errro while inserting spaces in " +
                                        "place of the Underscore character.";
					
				StringBuilder sb = new StringBuilder ();
				
				foreach (string strTemp in strPath) {
					sb.Append (strTemp).Append (" ");
					
				}
				
				
				retVal = sb.ToString ().TrimEnd (new char[]{' '});
				
				//Check that the path name string now contains spaces.
				Console.Write (retVal);
				
				return retVal;
			} catch (IndexOutOfRangeException ex) {
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
		
		
	} //End class clsRemoveUnderscore
	
} //End namespace MusicManager

