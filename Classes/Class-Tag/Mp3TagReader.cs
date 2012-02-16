
/// <summary>
/// class -- clsMp3TagReader
/// 
/// Read Song tags.
/// </summary>
using System;
using System.IO;
using System.Text;
using TagLib;
using Gtk;

namespace MusicManager
{	
	public class Mp3TagReader
	{
		
        
		TagLib.File tgLib = null;
		private const string className = "Mp3TagReader";
		private string methodName = "";
		private string errMsg = "";
		private const string miss = "missing";
		private const string err = "error";
       
		public Mp3TagReader ()
		{
		    
		} //End Constructor
		
		
		/// <summary> 
		/// METHOD -- public string getTitle(string stPath)
		/// 
		/// This method returns the song title from the mp3 file tag 
		/// located at this path. Return 'missing' if no song
		/// title found. Else 'error' on Error. 
		/// </summary>
		/// <param name="strPath">
		/// A <see cref="System.String"/>
		/// </param>
		/// <returns>
		/// A <see cref="System.String"/>
		/// </returns>
		public string GetTitle (string strPath)
		{
			
			string retVal = miss;
			
			try {
				
				methodName = "public string GetTitle(string strPath)";	
				
				
						
				tgLib = TagLib.File.Create (strPath);	
				
				if (tgLib.Tag.Title == null) {
					retVal = miss;
				} else {
					retVal = tgLib.Tag.Title.ToString ();
				
					if (string.IsNullOrEmpty (retVal))
						retVal = miss; 
				}				
				
				return retVal;					
			} catch (TagLib.CorruptFileException ex) {
				
				errMsg = "This file is corrupt. " + strPath;
				MyMessages clsMsg = new MyMessages ();
				clsMsg.BuildErrorString (className, methodName, errMsg, 
                                                        ex.Message.ToString ());	
				
				retVal = err;
				return retVal; // return empty string on error.
			
			} catch (TagLib.UnsupportedFormatException ex) {
				errMsg = "Unsupported format. " + strPath;
				MyMessages clsMsg = new MyMessages ();
				clsMsg.BuildErrorString (className, methodName, errMsg, 
                                                        ex.Message.ToString ());
				
				retVal = err;
				return retVal;
			} catch (System.NullReferenceException ex) {
				errMsg = "Null error. " + strPath;
				MyMessages clsMsg = new MyMessages ();
				clsMsg.BuildErrorString (className, methodName, errMsg, 
                                                        ex.Message.ToString ());
				retVal = err;
				return retVal;
			}
					
			
		} //End Method public string GetTitle(string strPath)
		
		
		/// <summary> 
		/// METHOD -- public string GetArtist(string strPath);
		/// 
		/// This method returns the Artist name from the mp3 file tag
		/// located at this path. Returns 'missing' if no Artist Name
		/// found. Else 'error on Error. 
		/// </summary>
		/// <param name="strPath">
		/// A <see cref="System.String"/>
		/// </param>
		/// <returns>
		/// A <see cref="System.String"/>
		/// </returns>
		public string GetArtist (string strPath)
		{
			string retVal = miss;
			
			
			try {
				methodName = "public string GetArtist(string strPath)";
				
				
				
				tgLib = TagLib.File.Create (strPath);
				
				if (String.IsNullOrEmpty (tgLib.Tag.FirstPerformer)) {
					return retVal;
				} 			
               
				retVal = tgLib.Tag.FirstPerformer;
				
				return retVal;
			} catch (TagLib.CorruptFileException ex) {                
				errMsg = "This file is corrupt. " + strPath;
				MyMessages clsMsg = new MyMessages ();
				clsMsg.BuildErrorString (className, methodName, errMsg, 
                                                        ex.Message.ToString ());
				retVal = err;
				return retVal;				
			} catch (TagLib.UnsupportedFormatException ex) { 
				errMsg = "Unsupported format. " + strPath;
				MyMessages clsMsg = new MyMessages ();
				clsMsg.BuildErrorString (className, methodName, errMsg, 
                                                        ex.Message.ToString ());
				retVal = err;
				return retVal;				
			} catch (NullReferenceException ex) {
				errMsg = "Null error. " + strPath;
				MyMessages clsMsg = new MyMessages ();
				clsMsg.BuildErrorString (className, methodName, errMsg, 
                                                        ex.Message.ToString ());
				retVal = err;
				return retVal;
			}
			
		} //End Method public string GetArtist(string strPath)
		
		
		
		/// <summary> 
		/// METHOD -- public string GetAlbum(string strPath)
		/// 
		/// This method returns the Album name from the mp3 file tag
		/// located at this path. Returns 'missing' if no Album Name
		/// found. Else 'error' on Error. 
		/// </summary>
		/// <param name="strPath">
		/// A <see cref="System.String"/>
		/// </param>
		/// <returns>
		/// A <see cref="System.String"/>
		/// </returns>
		public string GetAlbum (string strPath)
		{
			string retVal = miss;
			
			try {
				methodName = "public string GetAlbum(string strPath)";
				
				
				
				tgLib = TagLib.File.Create (strPath);		
				
				if (String.IsNullOrEmpty (tgLib.Tag.Album)) {
					return retVal;
				} 
                
				retVal = tgLib.Tag.Album.ToString ();			
				
				return retVal;
			} catch (TagLib.CorruptFileException ex) { 
				errMsg = "This file is corrupt. " + strPath;
				MyMessages clsMsg = new MyMessages ();
				clsMsg.BuildErrorString (className, methodName, errMsg, 
                                                        ex.Message.ToString ());
				retVal = err;
				return retVal;				
			} catch (TagLib.UnsupportedFormatException ex) { 
				errMsg = "Unsupported format. " + strPath;
				MyMessages clsMsg = new MyMessages ();
				clsMsg.BuildErrorString (className, methodName, errMsg, 
                                                        ex.Message.ToString ());
				retVal = err;
				return retVal;				
			} catch (NullReferenceException ex) {
				errMsg = "Null error.";
				MyMessages clsMsg = new MyMessages ();
				clsMsg.BuildErrorString (className, methodName, errMsg, 
                                                        ex.Message.ToString ());
				retVal = err;
				return retVal;
			}
			
		} //End Metod public string GetAlbum(string strPath)
		
		
		/// <summary> 
		/// METHOD	-- public string GetGnere(string strPath)
		/// 
		/// This method returns the Geex Name from the mp3 file tag
		/// located at this path. Returns 'missing' if no Geex Name
		/// found. Else 'error' on Error. 
		/// </summary>
		/// <param name="strPath">
		/// A <see cref="System.String"/>
		/// </param>
		/// <returns>
		/// A <see cref="System.String"/>
		/// </returns>
		public string GetGenre (string strPath)
		{
			string retVal = miss;
			
			try {
				methodName = "public string GetGenre(string strPath)";					
				
				
				tgLib = TagLib.File.Create (strPath);	
                
				
				if (String.IsNullOrEmpty (tgLib.Tag.FirstGenre)) {
					return retVal;
				}
			                
				retVal = tgLib.Tag.FirstGenre;
				
				return retVal;
			} catch (TagLib.CorruptFileException ex) { 
				errMsg = "This file is corrupt. " + strPath;
				MyMessages clsMsg = new MyMessages ();
				clsMsg.BuildErrorString (className, methodName, errMsg, 
                                                        ex.Message.ToString ());
				retVal = err;
				return retVal;				
			} catch (TagLib.UnsupportedFormatException ex) { 
				errMsg = "Unsupported format. " + strPath;
				MyMessages clsMsg = new MyMessages ();
				clsMsg.BuildErrorString (className, methodName, errMsg, 
                                                        ex.Message.ToString ());
				retVal = err;
				return retVal;				
			} catch (NullReferenceException ex) {
				errMsg = "Null error.";
				MyMessages clsMsg = new MyMessages ();
				clsMsg.BuildErrorString (className, methodName, errMsg, 
                                                        ex.Message.ToString ());
				retVal = err;
				return retVal;
			}
		
		} //End Method
		
		
		/// <summary> 
		/// METHOD -- public string GetYear(string strPath)
		/// 
		/// This method returns the year from the mp3 file tag
		/// located at this path. Returns 'missing' if no year
		/// found. Else 'error' on Error. 
		/// </summary>
		/// <param name="strPath">
		/// A <see cref="System.String"/>
		/// </param>
		/// <returns>
		/// A <see cref="System.String"/>
		/// </returns>
		public string GetYear (string strPath)
		{
			string retVal = miss;
			
			try {
				methodName = "public string GetYear(string strPath)";	
				
				
				
				tgLib = TagLib.File.Create (strPath);	
				int yearVal = Convert.ToInt32 (tgLib.Tag.Year);
				
				if (tgLib.Tag.Year.ToString ().Length < 1) {
					return retVal;
				} else if (yearVal < 1900) {
					retVal = err;
					return retVal;
				} 
				
				retVal = tgLib.Tag.Year.ToString ();
				
					
				
				
				return retVal;
			} catch (TagLib.CorruptFileException ex) { 
				errMsg = "This file is corrupt. " + strPath;
				MyMessages clsMsg = new MyMessages ();
				clsMsg.BuildErrorString (className, methodName, errMsg, 
                                                        ex.Message.ToString ());
				retVal = err;
				return retVal;				
			} catch (TagLib.UnsupportedFormatException ex) { 
				errMsg = "Unsupported format. " + strPath;
				MyMessages clsMsg = new MyMessages ();
				clsMsg.BuildErrorString (className, methodName, errMsg, 
                                                        ex.Message.ToString ());
				retVal = err;
				return retVal;				
			} catch (NullReferenceException ex) {
				errMsg = "Null error.";
				MyMessages clsMsg = new MyMessages ();
				clsMsg.BuildErrorString (className, methodName, errMsg, 
                                                        ex.Message.ToString ());
				retVal = err;
				return retVal;
			}
			
		} //End Method
		
		
		
		/// <summary> 
		/// METHOD -- public string GetDisc(string strPath)
		/// 
		/// This method returns the Disc Number from the mp3 file tag
		/// located at this path. Returns 'missing' if no Disc Number
		/// found. Else 'error' on Error.
		/// </summary>
		/// <param name="strPath">
		/// A <see cref="System.String"/>
		/// </param>
		/// <returns>
		/// A <see cref="System.String"/>
		/// </returns>		
		public string GetDisc (string strPath)
		{
			string retVal = miss;
			
			try {
				methodName = "pbulic string GetDisc(string strPath)";
				
				
								
				tgLib = TagLib.File.Create (strPath);
				
				
				retVal = tgLib.Tag.Disc.ToString ();		
				
				if (String.IsNullOrEmpty (retVal))
					retVal = miss;
			
							
				return retVal;
			} catch (TagLib.CorruptFileException ex) { 
				errMsg = "This file is corrupt. " + strPath;
				MyMessages clsMsg = new MyMessages ();
				clsMsg.BuildErrorString (className, methodName, errMsg, 
                                                        ex.Message.ToString ());
				retVal = err;
				return retVal;				
			} catch (TagLib.UnsupportedFormatException ex) { 
				errMsg = "Unsupported format. " + strPath;
				MyMessages clsMsg = new MyMessages ();
				clsMsg.BuildErrorString (className, methodName, errMsg, 
                                                        ex.Message.ToString ());
				retVal = err;
				return retVal;				
			} catch (NullReferenceException ex) {
				errMsg = "Null error.";
				MyMessages clsMsg = new MyMessages ();
				clsMsg.BuildErrorString (className, methodName, errMsg, 
                                                        ex.Message.ToString ());
				retVal = err;
				return retVal;
			}
						
		} //End Method
		
		
		
		/// <summary> 
		/// METHOD -- public string GetDiscCount(string strPath)
		/// 
		/// This method returns Disc Count from the mp3 file tag
		/// located at this path. Returns 'missing' if no Disc Count
		/// found. Else 'error' on Error. 
		/// </summary>
		/// <param name="strPath">
		/// A <see cref="System.String"/>
		/// </param>
		/// <returns>
		/// A <see cref="System.String"/>
		/// </returns>
		public string GetDiscCount (string strPath)
		{
			string retVal = miss;
			
			try {
				methodName = "public GetDiscCount(string strPath)";
				
			
				
				tgLib = TagLib.File.Create (strPath);
				
			
				retVal = tgLib.Tag.DiscCount.ToString ();
				
				if (String.IsNullOrEmpty (retVal))
					retVal = miss;
			
				
							
				return retVal;
			} catch (TagLib.CorruptFileException ex) { 
				errMsg = "This file is corrupt. " + strPath;
				MyMessages clsMsg = new MyMessages ();
				clsMsg.BuildErrorString (className, methodName, errMsg, 
                                                        ex.Message.ToString ());
				retVal = err;
				return retVal;				
			} catch (TagLib.UnsupportedFormatException ex) { 
				errMsg = "Unsupported format. " + strPath;
				MyMessages clsMsg = new MyMessages ();
				clsMsg.BuildErrorString (className, methodName, errMsg, 
                                                        ex.Message.ToString ());
				retVal = err;
				return retVal;				
			} catch (NullReferenceException ex) {
				errMsg = "Null error.";
				MyMessages clsMsg = new MyMessages ();
				clsMsg.BuildErrorString (className, methodName, errMsg, 
                                                        ex.Message.ToString ());
				retVal = "error.";
				return retVal;
			}
		
		} //End Method
		
		
		/// <summary> 
		/// METHOD -- public string GetTrack(string strPath)
		/// 
		/// This method returns the Track Number from the mp3 file tag
		/// located at this path. Returns 'missing' if no Track Number
		/// found. Else 'error' on Error. 
		/// </summary>
		/// <param name="strPath">
		/// A <see cref="System.String"/>
		/// </param>
		/// <returns>
		/// A <see cref="System.String"/>
		/// </returns>
		public string GetTrack (string strPath)
		{
			string retVal = miss;
			
			try {
				methodName = "public string GetTrack(string strPath)";
				
				
				
				tgLib = TagLib.File.Create (strPath);
				
				
				
				retVal = tgLib.Tag.Track.ToString ();
				
				if (String.IsNullOrEmpty (retVal))
					retVal = miss;				
				
				
				return retVal;
			} catch (TagLib.CorruptFileException ex) { 
				errMsg = "This file is corrupt. " + strPath;
				MyMessages clsMsg = new MyMessages ();
				clsMsg.BuildErrorString (className, methodName, errMsg, 
                                                        ex.Message.ToString ());
				retVal = err;
				return retVal;				
			} catch (TagLib.UnsupportedFormatException ex) { 
				errMsg = "Unsupported format. " + strPath;
				MyMessages clsMsg = new MyMessages ();
				clsMsg.BuildErrorString (className, methodName, errMsg, 
                                                        ex.Message.ToString ());
				retVal = err;
				return retVal;				
			} catch (NullReferenceException ex) {
				errMsg = "Null error.";
				MyMessages clsMsg = new MyMessages ();
				clsMsg.BuildErrorString (className, methodName, errMsg, 
                                                        ex.Message.ToString ());
				retVal = err;
				return retVal;
			}
		
		} //End Method
		
		
		
		/// <summary> 
		/// METHOD -- public string GetTrackCount(string strPath)
		/// 
		/// This method returns the Number of Tracks from the mp3 file tag
		/// located at this path. Returns '0' if no Number of Tracks 
		/// found. Else 'error' on error. 
		/// </summary>
		/// <param name="strPath">
		/// A <see cref="System.String"/>
		/// </param>
		/// <returns>
		/// A <see cref="System.String"/>
		/// </returns>
		public string GetTrackCount (string strPath)
		{
			string retVal = miss;
			
			try {
				methodName = "public string GetTrackCount(string strPath)";					
				
				tgLib = TagLib.File.Create (strPath);					
				
				retVal = tgLib.Tag.TrackCount.ToString ();
			
				if (String.IsNullOrEmpty (retVal))
					retVal = miss;	
							
				
				return retVal;
			} catch (TagLib.CorruptFileException ex) { 
				errMsg = "This file is corrupt. " + strPath;
				MyMessages clsMsg = new MyMessages ();
				clsMsg.BuildErrorString (className, methodName, errMsg, 
                                                        ex.Message.ToString ());
				retVal = err;
				return retVal;				
			} catch (TagLib.UnsupportedFormatException ex) { 
				errMsg = "Unsupported format. " + strPath;
				MyMessages clsMsg = new MyMessages ();
				clsMsg.BuildErrorString (className, methodName, errMsg, 
                                                        ex.Message.ToString ());
				retVal = err;
				return retVal;				
			} catch (NullReferenceException ex) {
				errMsg = "Null error.";
				MyMessages clsMsg = new MyMessages ();
				clsMsg.BuildErrorString (className, methodName, errMsg, 
                                                        ex.Message.ToString ());
				retVal = err;
				return retVal;
			}
						
		} //End  Method 
		
		
		/// <summary>
		/// METHOD -- public string AlbumArtExists(string strPath)
		/// 
		/// This method returns the Number of Album Art from the mp3 file tag
		/// located at this path. Returns '0' if no Album Art found.
		/// Else 'error' on Error.
		/// </summary>
		/// <returns>
		/// The art exists.
		/// </returns>
		/// <param name='strPath'>
		/// String path.
		/// </param>
		public string AlbumArtExists (string strPath)
		{
						
			try {
				methodName = "public bool AlbumArtExists(string strPath)";	
				
				
				tgLib = TagLib.File.Create (strPath);
				
				if (tgLib.Tag.Pictures == null) {
					return "0";
				} else {
					return tgLib.Tag.Pictures.Length.ToString ();
				}
				
			} catch (TagLib.CorruptFileException ex) {
				errMsg = "This file is corrupt. " + strPath;
				MyMessages clsMsg = new MyMessages ();
				clsMsg.BuildErrorString (className, methodName, errMsg, 
                                                        ex.Message.ToString ());
				return err; 
			} catch (TagLib.UnsupportedFormatException ex) {
				errMsg = "Unsupported format. " + strPath;
				MyMessages clsMsg = new MyMessages ();
				clsMsg.BuildErrorString (className, methodName, errMsg, 
                                                        ex.Message.ToString ());
				return err;
			} catch (NullReferenceException ex) {
				errMsg = "Null error.";
				MyMessages clsMsg = new MyMessages ();
				clsMsg.BuildErrorString (className, methodName, errMsg, 
                                                        ex.Message.ToString ());
				return err;

			}
			
		} //End Method 
		
		
        
	} // End Class Mp3TagReader
	
} //End namespace MusicManager

