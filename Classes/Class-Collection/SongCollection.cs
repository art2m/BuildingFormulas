//  
//  SongCollection.cs
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
using System.Collections.Generic;

namespace MusicManager
{
	public static  class SongCollection
	{
		
		private static string methodName = null;
		private static string errMsg = null;
		private static string className = "ArtistCollection";
		private static List<SongRecord> lstSong = new List<SongRecord> ();
        
		public static bool AddNewItem (SongRecord recSong)
		{
			bool retVal = false;
            
			try {
				methodName = "public static bool AddNewItem(SongRecord" +
                                                                " recSong)";                
             
				lstSong.Add (recSong); 
				//All ok
				retVal = true;
				return retVal;
			} catch (ArgumentNullException ex) {
				errMsg = "Encountered error while adding item to collection.";
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg,
                    ex.Message.ToString ());
				return retVal;
			} catch (NullReferenceException ex) {
				errMsg = "Encountered error while adding item to collection.";
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg,
                    ex.Message.ToString ());
				return retVal;    
			}
            
		} //End Method 
        
		public static bool InsertItemAt (SongRecord recSong, int index)
		{
			bool retVal = false;
            
			try {
				methodName = "public static bool InsertItemAt(SongRecord" +
                                                     " recSong, int index";
				errMsg = "Encountered error while inserting record" +
                                                         " into collection.";                
             
				lstSong.Insert (index, recSong);
             
				//All Ok
				retVal = true;
				return retVal;
			} catch (ArgumentNullException ex) {
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg,
                    ex.Message.ToString ());
				return retVal;
			} catch (NullReferenceException ex) {
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
        
		public static void ClearArray ()
		{   
			try {
				methodName = "public static void ClearArray()";
             
				errMsg = "Encountered error while clearing the collection.";                
         
				lstSong.Clear ();
                
			} catch (InvalidOperationException ex) {
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg,
                    ex.Message.ToString ());
			} catch (NullReferenceException ex) {
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg,
                    ex.Message.ToString ()); 
			}
            
		} //End Method
        
        
		public static int GetItemsCount ()
		{
			int retVal = 0;
            
			try {
				methodName = "public static int GetItemsCount()";
				errMsg = "Encountered error while getting collection count.";                
         
				retVal = lstSong.Count;
             
				return retVal;
                
			} catch (NullReferenceException ex) {
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
        
		public static bool RemoveItemAt (int index)
		{
			bool retVal = false;
            
			try {
				methodName = "public static bool RemoveItemAt(int index)";                              
                
				lstSong.RemoveAt (index);
             
				//All Ok
				retVal = true;
				return retVal;
			} catch (IndexOutOfRangeException ex) {
				errMsg = "Encountered error while removing item at: " + index;
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg, 
                                       ex.Message.ToString ());
				return retVal;
			} catch (NullReferenceException ex) {
				errMsg = "Encountered error while removing item at: " + index;
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg, 
                                       ex.Message.ToString ());
				return retVal;  
			} catch (ArgumentNullException ex) {
				errMsg = "Encountered error while removing item at: " + index;
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg, 
                                       ex.Message.ToString ());
				return retVal; 
			} catch (InvalidOperationException ex) {
				errMsg = "Encountered error while removing item at: " + index;
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg, 
                                       ex.Message.ToString ());
				return retVal; 
			}
            
		} //End Method
        
		public static SongRecord GetItemAt (int index)
		{
			SongRecord recSong = null;
            
			try {
				recSong = new SongRecord ();
                
                
				methodName = "public static SongRecord GetItemAt(int index)";                 
               
				recSong = lstSong [index];
                      
				return recSong;
			} catch (IndexOutOfRangeException ex) {
				errMsg = "Collection index out of range.";
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg, 
                                       ex.Message.ToString ());
				return recSong;
			} catch (ArgumentNullException ex) {
				errMsg = "Encountered error while getting Item At: " + index;
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg, 
                                       ex.Message.ToString ());
				return recSong; 
			} catch (NullReferenceException ex) {
				errMsg = "Encountered error while getting Item At: " + index;
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg, 
                                       ex.Message.ToString ());
				return recSong;   
			} catch (InvalidOperationException ex) {
				errMsg = "Encountered error while getting Item At: " + index;
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg, 
                                       ex.Message.ToString ());
				return recSong;  
			}
            
		} //End Method
        
        
	} //End class SongCollection
    
} //End namespace MusicManger

