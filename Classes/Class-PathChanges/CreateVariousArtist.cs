//  
//  clsCreateVariousArtist.cs
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
/// Cls create various artist.
/// 
/// This class takes all albums that are by various artists and creates a Various_Artist directory and places 
/// all of the Various Artist albums under that directory.
/// </summary>
using System;
using System.IO;
using System.Text;

namespace MusicManager
{
	public class CreateVariousArtist
	{
				 
		private string methodName = "";
		private string errMsg = "";
		private const string className = "clsCreateVariousArtist";
		
		public CreateVariousArtist ()
		{
		} //End Constructor
		
		
		/// <summary>
		/// Method -- public bool MakeVariousArtistDirectories(string strPath)
		/// 
		/// Makes the various artist directories. Pass in the Genre directories
		/// one at a time. Like: Various-Rock, Various-Country etc....
		/// </summary>
		/// <returns>
		/// The various artist directories.
		/// </returns>
		/// <param name='strPath'>
		/// If set to <c>true</c> string path.
		/// </param>
		public bool MakeVariousArtistDirectories (string strPath)
		{
			bool retVal = false;
			bool dirArtist = false;
			bool dirExists = false;
			
			try {
				methodName = "METHOD public bool " +
                                "MakeVariousArtistDirectories(string strPath)";
				errMsg = "Encountered error while validating" +
                                                " Toplevel Music Directory.";
				
				//strPath contains /home/user/Music/Various-BigBands
				//Get list of directories. 
				foreach (string strDir in Directory.GetDirectories(strPath)) {		
				
							
					dirArtist = CheckToSeeIfDirectoryContainsMusicFiles (
                                                                        strDir);
						
					if (!dirArtist) {
						//Do nothing is artist dirctory	no songs
						//contained in it.
						retVal = true;
						return retVal;
					} else {
						
							
						//Has no Artist directory So this is a 
						//Various Artist Album
						//Create a Various_Artist Directory and 
						//copy This Directory into it.
						//string strCreate = "/home/art2m/Music/Various_Artist";
						
						StringBuilder sb = new StringBuilder ();
						sb.Append (strPath);
						sb.Append ("/Various_Artist");
						string strCreate = sb.ToString ();
						
						dirExists = Directory.Exists (strCreate);
							
						if (!dirExists) {
							Directory.CreateDirectory (strCreate);	
						}
						
						DirectoryInfo sourceDir = new DirectoryInfo (strDir);
							
						DirectoryInfo destinationDir = new 
                                                    DirectoryInfo (strCreate);
							 
						string strDestDir = Path.Combine (
                                    destinationDir.FullName, sourceDir.Name);
							
						dirExists = Directory.Exists (strDestDir);
						
						if (!dirExists) {
							Directory.CreateDirectory (strDestDir);
						}
						
						DirectoryInfo SDir = new DirectoryInfo (strDir);
						DirectoryInfo DDir = new DirectoryInfo (strDestDir);
						
					    			
						CopyFiles (SDir, DDir);
						
						DeleteDirectoryAndFiles (strDir);
						retVal = true;
						return retVal;
						
					}
					
					
				} //End For Statement	
				retVal = true;
				return retVal;			
			} catch (DirectoryNotFoundException ex) {
				MyMessages myMsg = new MyMessages ();		
				myMsg.BuildErrorString (className, methodName, errMsg,
                                                    ex.Message.ToString ());
				return retVal;
			} catch (PathTooLongException ex) {
				MyMessages myMsg = new MyMessages ();        
				myMsg.BuildErrorString (className, methodName, errMsg,
                                                    ex.Message.ToString ());
				return retVal; 
			} catch (IOException ex) {
				MyMessages myMsg = new MyMessages ();        
				myMsg.BuildErrorString (className, methodName, errMsg,
                                                    ex.Message.ToString ());  
				return retVal;
			}
			
		} //End Method 
		
		
				
		
		
		/// <summary>
		/// Method -- private void CopyFiles(DirectoryInfo source, DirectoryInfo destination)
		/// 
		/// 
		/// Copies the Various artist files.
		/// </summary>
		/// <param name='source'>
		/// Source.
		/// </param>
		/// <param name='destination'>
		/// Destination.
		/// </param>
		private void CopyFiles (DirectoryInfo source, DirectoryInfo destination)
		{
			
			
			
			try {
				methodName = "private static void CopyFiles(" + 
                        " DirectoryInfo source, DirectoryInfo destination)";
				errMsg = "Encountered error while copying" +
                                            " various Artist music files.";
				
				// Copy all files.
				FileInfo[] files = source.GetFiles ();
				foreach (FileInfo file in files) {
					file.CopyTo (Path.Combine (destination.FullName, 
	                    file.Name));
				}
			} catch (FileNotFoundException ex) {
				MyMessages myMsg = new MyMessages ();  
				myMsg.BuildErrorString (className, methodName, errMsg,
                                                    ex.Message.ToString ());				
				
			} catch (IndexOutOfRangeException ex) {
				MyMessages myMsg = new MyMessages ();  
				myMsg.BuildErrorString (className, methodName, errMsg,
                                                    ex.Message.ToString ()); 
			} catch (IOException ex) {
				MyMessages myMsg = new MyMessages ();  
				myMsg.BuildErrorString (className, methodName, errMsg,
                                                    ex.Message.ToString ());
			}	
			
		} //End Method 
		
		
		/// <summary>
		/// Method -- private void DeleteDirectoryAndFiles(string strPath)
		/// 
		/// Deletes the directory and files. After copying all directories and files.
		/// </summary> 
		/// <param name='strPath'>
		/// String path.
		/// </param>
		private void DeleteDirectoryAndFiles (string strPath)
		{
						
			// Delete this dir and all subdirs.
			try {
				System.IO.DirectoryInfo di = new 
                                            System.IO.DirectoryInfo (strPath);		
				
				methodName = "private static void" +
                                "  DeleteDirectoryAndFiles(string strPath)";
				errMsg = "Encountered error while deleating" +
                                " old Various Artist Album Directoryies.";
				
				di.Delete (true);
			} catch (FileNotFoundException ex) {
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, 
                                            errMsg, ex.Message.ToString ());
			} catch (PathTooLongException ex) {
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, 
                                            errMsg, ex.Message.ToString ()); 
			} catch (IOException ex) {
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, 
                                            errMsg, ex.Message.ToString ());
			} catch (UnauthorizedAccessException ex) {
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, 
                                            errMsg, ex.Message.ToString ()); 
			}
			
		} //End Method private void DeleteDirectoryAndFiles(string strPath)
		
		
		
		/// <summary>
		/// Method -- private bool CheckToSeeIfDirectoryContainsMusicFiles(string strDir)
		/// 
		///Checks to see if directory contains music files.
		///Check to see if directory has mp3 files in it if so then not artist
		///Directory but is Album Directory Return true if Album Directory False if 
		///Artist Directory. We do this so we can put correct Artist, Album, Songs into
		///Correct Collection with correct information.
		/// </summary>
		/// <returns>
		/// bool retVal
		/// </returns>
		/// <param name='strDir'>
		/// If set to <c>true</c> string dir.
		/// </param>
		public bool CheckToSeeIfDirectoryContainsMusicFiles (string strDir)
		{
			
			bool retVal = false;
			
			
			try {
				methodName = "public bool" +
                   " CheckToSeeIfDirectoryContainsMusicFiles(string strDir)";
				errMsg = "Encountered error while verifying that" +
                                       " the directory contains music files.";
				
				string[] aryFiles = Directory.GetFiles (strDir);
				
				//if length greater then 0 then this directory 
				//has music files in it.
				//Making it an Album Dir. 
				//If = 0 Then no music Files so makes it an Artist Dir.
				if (aryFiles.Length > 0) {
					retVal = true;
					return retVal;
				} else {
					return retVal;
				}
			} catch (PathTooLongException ex) {
				MyMessages myMsg = new MyMessages ();  
				myMsg.BuildErrorString (className, methodName, 
                                             errMsg, ex.Message.ToString ());
				return retVal;
				
			} catch (IOException ex) {
				MyMessages myMsg = new MyMessages ();  
				myMsg.BuildErrorString (className, methodName, 
                                             errMsg, ex.Message.ToString ());
				return retVal;  
			}
		
		} //End Method 
		
	} //End class clsCreateVariousArtist
 	
} //End namespace MusicManager

