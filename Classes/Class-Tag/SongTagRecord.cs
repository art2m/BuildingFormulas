//  
//  clsSongTagRecord.cs
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
/// Class -- clsSongTagRecord
/// 
/// This holds one song tag record.
/// </summary>
using System;

//using System.Runtime.Serialization;
//using System.Runtime.Serialization.Formatters.Binary;

namespace MusicManager
{
	
    //[Serializable()]
    public class SongTagRecord
    {
		
       
        public SongTagRecord ()
        {
        } //End Constructor
		
#region Properties
		
        private string strSngTitle = "";

        public string SongTitle {
            get {
                return strSngTitle;
            } 
            set {
                strSngTitle = value;
            }
        }
		
        private string strArtist = "";

        public string ArtistName {
            get {
                return strArtist;
            }
            set {
                strArtist = value;
            }
        }
		
        private string strAlbum = "";

        public string AlbumName {
            get {
                return strAlbum;
            }
            set {
                strAlbum = value;
            }	
        }
		
        private string strGenre = "";

        public string GenreType {
            get {
                return strGenre;
            }
            set {
                strGenre = value;
            }
        }
		
        private string strYear = "";

        public string YearCreated {
            get {
                return strYear;
            }
            set {
                strYear = value;
            }
        }
		
        private string strDiscNum = "";

        public string ThisDiscNumber {
            get {
                return strDiscNum;
            }
            set {
                strDiscNum = value;
            }
        }
		
        private string strDiscCnt = "";

        public string TotalDiscCount {
            get {
                return strDiscCnt;
            }
            set {
                strDiscCnt = value;
            }
        }
		
        private string strTrackNum = "";

        public string ThisTrackNumber {
            get {
                return strTrackNum;
            }
            set {
                strTrackNum = value;
            }
        }
				
        private string strTrackCnt = "";

        public string TotalTrackCount {
            get {
                return strTrackCnt;
            }
            set {
                strTrackCnt = value;
            }
        }
		
        private string strAlbArt = "";

        public string AlbumArt {
            get {
                return strAlbArt;
            }
            set {
                strAlbArt = value;
            }
        }
		
        private string strSngPath = "";

        public string SongPath {
            get {
                return strSngPath;
            }
            set {
                strSngPath = value;
            }
        }
        
       
		
#endregion Properties
		
        /*
		
		/// <summary>
		/// Method -- public bool GetObjectData(SerializationInfo info, StreamingContext ctxt)
		/// 
		/// Serialize Tag Correct data for writing to file.
		/// 
		/// </summary>
		/// <returns>
		/// return true if data serialized ok else false
		/// </returns>
		/// <param name='info'>
		/// If set to <c>true</c> info.
		/// </param>
		/// <param name='ctxt'>
		/// If set to <c>true</c> ctxt.
		/// </param>
		public bool GetObjectData (SerializationInfo info, StreamingContext ctxt)
		{
			bool retVal = false;
			
			try {
				
				methodName = "public void GetObjectData(SerializationInfo info, StreamingContext ctxt)";
				
				info.AddValue ("SongTitle", strSngTitle);
				info.AddValue ("ArtistName", strArtist);
				info.AddValue ("AlbumName", strAlbum);
				info.AddValue ("GenreType", strGenre);
				info.AddValue ("YearCreated", strYear);
				info.AddValue ("DiscNumber", strDiscNum);
				info.AddValue ("DiscCount", strDiscCnt);
				info.AddValue ("TrackNumber", strTrackNum);
				info.AddValue ("TrackCount", strTrackCnt);
				info.AddValue ("AlbumArt", strAlbArt);
				info.AddValue ("SongPath", strSngPath);
				
				//All ok
				retVal = true;
				return retVal;
			} catch (SerializationException se) {
				errMsg = "Encountered error while serializing data to be written to file.";
				clsMessages clsMsg = new clsMessages ();
				clsMsg.BuildErrorString (className, methodName, errMsg, se.Message.ToString ());
				return retVal;
			}
		    
		} //End Method public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
		
  
		
		/// <summary>
		/// Method -- public bool  ClsSongTagRecord(SerializationInfo info, StreamingContext ctxt)
		/// 
		/// Deserialization constructor.
		/// Deserialize data from file.
		/// </summary>
		/// <returns>
		/// retur true if all data was deserialized else false.
		/// </returns>
		/// <param name='info'>
		/// If set to <c>true</c> info.
		/// </param>
		/// <param name='ctxt'>
		/// If set to <c>true</c> ctxt.
		/// </param>
		public bool  ClsSongTagRecord (SerializationInfo info, StreamingContext ctxt)
		{
			
			bool retVal = false;
			
			try {
				methodName = "public void  ClsSongTagRecord(SerializationInfo info, StreamingContext ctxt)";
				
				//Get the values from info and assign them to the appropriate properties
				strSngTitle = (string)info.GetValue ("SongTitle", typeof(string));
				strArtist = (string)info.GetValue ("ArtistName", typeof(string));
				strAlbum = (string)info.GetValue ("AlbumName", typeof(string));
				strGenre = (string)info.GetValue ("GenreType", typeof(string));
				strYear = (string)info.GetValue ("YearCreated", typeof(string));
				strDiscNum = (string)info.GetValue ("DiscNumber", typeof(string));
				strDiscCnt = (string)info.GetValue ("DiscCount", typeof(string));
				strTrackNum = (string)info.GetValue ("TrackNumber", typeof(string));
				strTrackCnt = (string)info.GetValue ("TrackCount", typeof(string));
				strAlbArt = (string)info.GetValue ("AlbumArt", typeof(string));
				strSngPath = (string)info.GetValue ("SongPath", typeof(string));
				
				//All ok
				retVal = true;
				return retVal;
			} catch (SerializationException se) {
				errMsg = "Encountered error while dserializing data from file.";	
				clsMessages clsMsg = new clsMessages ();
				clsMsg.BuildErrorString (className, methodName, errMsg, se.Message.ToString ());
				return retVal;
			}		
		    
		} //End Method public void  ClsSongTagRecord(SerializationInfo info, StreamingContext ctxt)
		
		
	    */    
	
		
    } //End class clsSongTagRecord
	
	
	
	
} //End MusicManager

