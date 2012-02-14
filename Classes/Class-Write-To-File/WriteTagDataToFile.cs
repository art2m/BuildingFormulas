//  
//  clsWriteInTagData.cs
//  
//  Author:
//       art2m <art2m@live.com>
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
/// Class -- clsWriteInTagData
/// 
/// Writes correct tags and incorrect tags to file.
/// </summary>
using System;
using System.IO;
using System.Text;
using System.Collections;

namespace MusicManager
{
	public static class WriteTagDataToFile
	{
		
		
		private static string methodName = "";
		private static string errMsg = "";
		private static readonly string className = "clsWriteInTagData";
		
				
		
		/// <summary>
		/// Method -- static 
		/// public bool CreateWriteSongTagsToFile(int intTag);
		/// 
		/// Public method to be called by routine that need sto write 
		/// tag information to file. Must pass in and int of 1 or 2 
		/// </summary>
		/// <returns>
		/// The write song tags to file.
		/// </returns>
		/// <param name='intTag'>
		/// If set to <c>true</c> int tag.
		/// </param>
		public static bool WriteSongTagsToFile ()
		{
			bool retVal = false;				
			
			//Write correct song tags to file.
			string filePathCorr = System.IO.Path.Combine (
                UserEnviormentInfo.UserHomeDirectoryPath, 
                UserEnviormentInfo.GetIncorrectCorrectTagFolderName);
         
			string corrFilePath = System.IO.Path.Combine (filePathCorr,
                                    UserEnviormentInfo.GetCorrectFileName);  
			retVal = WriteValidSongTagsToFile (corrFilePath);
		    
			//Write Incorrect song tags to file.
			string filePathIncorr = System.IO.Path.Combine (
                UserEnviormentInfo.UserHomeDirectoryPath, 
                 UserEnviormentInfo.GetIncorrectCorrectTagFolderName);
         
			string incorrFilePath = System.IO.Path.Combine (filePathIncorr, 
                                UserEnviormentInfo.GetInCorrectFileName);  
			retVal = WriteSongTagsWithErrorsToFile (incorrFilePath);
            
			return retVal;			
		} //End Method 
		
		
#region Write Tags To File
        
        
		/// <summary>
		/// Method -- private static bool WriteSongTagsWithErrorToFile
		/// 
		/// Writes the song tags with errors to file as csv strings.
		/// </summary>
		/// <returns>
		/// The song tags with errors to file.
		/// </returns>
		/// <param name='filePath'>
		/// If set to <c>true</c> file path.
		/// </param>
		private static bool WriteSongTagsWithErrorsToFile (string filePath)
		{
			bool retVal = false;
			SongTagRecord sngTagRecord = null;
			string writeValue = null;
			StreamWriter file = null;
			
			try {
				methodName = "private static bool " +
                            "WriteSongTagsInCorrectToFile (string filePath)";
				
				int recCnt = InvalidSongTagCollection.ItemsCount ();				
				
				if (recCnt < 1) {
					return retVal;
				}
				if (!File.Exists (filePath))
					return retVal;
                
				file = new StreamWriter (filePath);                 
				
				for (int i = 0; i < recCnt; i++) {
					sngTagRecord = new SongTagRecord ();
					sngTagRecord = InvalidSongTagCollection.GetItemAt (i);
					writeValue = CreateComaSeperatedString (sngTagRecord);
					if (!String.IsNullOrEmpty (writeValue)) {
						file.WriteLine (writeValue);
					}                    
				}	         
				
				//All ok
				retVal = true;
				return retVal;
			} catch (AccessViolationException ex) {
				errMsg = "You do not have access permision.";
				MyMessages clsMsg = new MyMessages ();                
				clsMsg.BuildErrorString (className, methodName, errMsg, 
                    ex.Message.ToString ());                
				return retVal;				
			} catch (ArgumentNullException ex) {
				errMsg = "Encountered error while writing tags to file.";
				MyMessages clsMsg = new MyMessages ();                
				clsMsg.BuildErrorString (className, methodName, errMsg, 
                    ex.Message.ToString ());                
				return retVal; 
			} catch (IOException ex) {
				errMsg = "Encountered error while writing tags to file."; 
				MyMessages clsMsg = new MyMessages ();                
				clsMsg.BuildErrorString (className, methodName, errMsg, 
                    ex.Message.ToString ());
				return retVal;
			} catch (NullReferenceException ex) {
				errMsg = "Encountered error while writing tags to file."; 
				MyMessages clsMsg = new MyMessages ();                
				clsMsg.BuildErrorString (className, methodName, errMsg, 
                    ex.Message.ToString ());
				return retVal;   
			} finally {
				file.Close (); 
			}		
		} //End Method 
		
        
		/// <summary>
		/// Method -- private static bool WrieValidSongTagsToFile
		/// 
		/// Writes the valid song tags to file as csv strings.
		/// </summary>
		/// <returns>
		/// The valid song tags to file.
		/// </returns>
		/// <param name='filePath'>
		/// If set to <c>true</c> file path.
		/// </param>
		private static bool WriteValidSongTagsToFile (string filePath)
		{
			bool retVal = false;
			SongTagRecord sngTagRecord = null;
			string writeValue = null;
			StreamWriter file = null;
         
       
			try {
				methodName = "private static bool " +
                               "WriteSongTagsInCorrectToFile (string filePath)";
                    
				int recCnt = ValidSongTagCollection.ItemsCount ();             
                    
				if (recCnt < 1)
					return retVal;
				if (!File.Exists (filePath))
					return retVal;            
                       
				file = new StreamWriter (filePath);              
                    
				for (int i = 0; i < recCnt; i++) {
					sngTagRecord = new SongTagRecord ();
					sngTagRecord = ValidSongTagCollection.GetItemAt (i);
					writeValue = CreateComaSeperatedString (sngTagRecord);
					if (!String.IsNullOrEmpty (writeValue)) {
						file.WriteLine (writeValue);
					}                    
				}                
                    
				//All ok
				retVal = true;
				return retVal;
			} catch (AccessViolationException ex) {
				errMsg = "You do not have access permision.";
				MyMessages clsMsg = new MyMessages ();                
				clsMsg.BuildErrorString (className, methodName, errMsg, 
                    ex.Message.ToString ());                
				return retVal;              
			} catch (ArgumentNullException ex) {
				errMsg = "Encountered error while writing tags to file.";
				MyMessages clsMsg = new MyMessages ();                
				clsMsg.BuildErrorString (className, methodName, errMsg, 
                    ex.Message.ToString ());                
				return retVal; 
			} catch (IOException ex) {
				errMsg = "Encountered error while writing tags to file."; 
				MyMessages clsMsg = new MyMessages ();                
				clsMsg.BuildErrorString (className, methodName, errMsg, 
                    ex.Message.ToString ());
				return retVal;
			} catch (NullReferenceException ex) {
				errMsg = "Encountered error while writing tags to file."; 
				MyMessages clsMsg = new MyMessages ();                
				clsMsg.BuildErrorString (className, methodName, errMsg, 
                    ex.Message.ToString ());
				return retVal;   
			} finally {
				file.Close (); 
			}       
		} //End Method 		 
        
        
		/// <summary>
		/// Method -- private string CreateComaSeperatedStringe (
		///                                     clsSongTagRecord sngTagRecord)
		/// 
		/// Creates the coma seperated string. For writing tag information to 
		/// file.
		/// </summary>
		/// <returns>
		/// The coma seperated string.
		/// </returns>
		/// <param name='sngTagRecord'>
		/// Cls string.
		/// </param>
		private static string CreateComaSeperatedString (SongTagRecord 
                                                                sngTagRecord)
		{
			string retVal = null;
			try {
				methodName = "private static string " +
                       "CreateCommaSeperatedString(SongTagRecord sngTagRecord)";
				char comma = ',';
                
				StringBuilder sb = new StringBuilder ();
                
				sb.Append (sngTagRecord.ArtistName).Append (comma);
				sb.Append (sngTagRecord.AlbumName).Append (comma);
				sb.Append (sngTagRecord.SongTitle).Append (comma);
				sb.Append (sngTagRecord.GenreType).Append (comma);
				sb.Append (sngTagRecord.AlbumArt).Append (comma);
				sb.Append (sngTagRecord.ThisTrackNumber).Append (comma);
				sb.Append (sngTagRecord.TotalTrackCount).Append (comma);
				sb.Append (sngTagRecord.YearCreated).Append (comma);
				sb.Append (sngTagRecord.ThisDiscNumber).Append (comma);
				sb.Append (sngTagRecord.TotalDiscCount).Append (comma);
				sb.Append (sngTagRecord.SongPath);
                
				//All ok
				retVal = sb.ToString ();
				return retVal;
			} catch (ArgumentOutOfRangeException ex) {
				errMsg = "Encountered error while creating csv string.";
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg,
                                       ex.Message.ToString ());
				return retVal;
			} catch (ArgumentNullException ex) {
				errMsg = "Encountered error while creating csv string.";
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg,
                                       ex.Message.ToString ());
				return retVal;     
			}         
		} //End Method 
        
		
		
	
		
#endregion Write Tags To File
		
		
		
	} //End class clsWriteInTagData
	
} //End namespace

