//  
//  clsSongTagList.cs
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
/// class -- clsSongTagList
/// 
/// This collection stores all tags that have
/// the correct data in them. 
/// 
/// </summary>
using System;
using System.Collections.Generic;

namespace MusicManager
{
	public static class ValidSongTagCollection
	{
		private static string methodName = null;
		private static string errMsg = null;
		private static string className = "clsSongTagList";
		static List<SongTagRecord> lstTag = new List<SongTagRecord> ();
		
		/// <summary>
		/// Method -- public static bool AddNewItem
		/// 
		/// Adds the new item to collection.
		/// </summary>
		/// <returns>
		/// The new item.
		/// </returns>
		/// <param name='objSongTag'>
		/// If set to <c>true</c> object song tag.
		/// </param>
		/// <exception cref='ArgumentNullException'>
		/// Is thrown when an argument passed to a method is invalid because it 
		/// is <see langword="null" /> .
		/// </exception>
		/// <exception cref='NullReferenceException'>
		/// Is thrown when there is an attempt to dereference a null object 
		/// reference.
		/// </exception>
		public static bool  AddNewItem (SongTagRecord objSongTag)
		{
			bool retVal = false;
			
			try {
				methodName = "private static bool AddNewItem(clsSongTagRecord " +
              "objSongTag";
				if (objSongTag == null) {
					throw new ArgumentNullException ("objSongTag record has " +
                                                       "not been initialized.");
				} else if (lstTag == null) {
					throw new NullReferenceException ("lstTag collection " +
                                                      "has not been " +
                                                       "initalized.");
				}
				lstTag.Add (objSongTag);                
				//All ok
				retVal = true;
				return retVal;
			} catch (ArgumentNullException ex) {
				errMsg = "Encountered error while adding item to " +
                    "collection.";
				MyMessages clsMsg = new MyMessages ();
				clsMsg.BuildErrorString (className, methodName, errMsg,
                    ex.Message.ToString ());
				return retVal;
			} catch (NullReferenceException ex) {
				errMsg = "Encountered error while adding item to " +
                    "collection.";
				MyMessages clsMsg = new MyMessages ();
				clsMsg.BuildErrorString (className, methodName, errMsg,
                    ex.Message.ToString ());
				return retVal;    
			}
		} //End Method 
	
        
        
		public static bool InsertItemAt (int index, SongTagRecord sngTagRecord)
		{
			bool retVal = false;
            
			try {
				if (sngTagRecord == null) {
					throw new ArgumentNullException ("sngTagRecord record " +
                                                " has not been initialized.");
				} else if (lstTag == null) {
					throw new NullReferenceException ("sngTagRecords " +
                                        " collection has not been initalized.");  
				}
				lstTag.Insert (index, sngTagRecord);
                
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
		
		/// <summary>
		/// Method -- public static void clearArray
		/// Clears the array.
		/// </summary>
		public static void ClearArray ()
		{
			try {
				methodName = "public static void ClearArray()";
				if (lstTag == null) {
					throw new NullReferenceException ("lstTag collection " +
                                                       "has not been " +
                                                        "initalized.");
				}
				lstTag.Clear ();
			} catch (NullReferenceException ex) {
				errMsg = "Encountered error while clearing the collection.";
				MyMessages clsMsg = new MyMessages ();
				clsMsg.BuildErrorString (className, methodName, errMsg,
                                        ex.Message.ToString ());
			}
		} //End Method 
		
		/// <summary>
		/// Method -- public static int ItemsCount
		/// 
		/// Items the count
		/// </summary>
		/// <returns>
		/// The count.
		/// </returns>
		/// <exception cref='NullReferenceException'>
		/// Is thrown when there is an attempt to dereference a null object 
		/// reference.
		/// </exception>
		public static int ItemsCount ()
		{
			int intCnt = 0;
            
			try {
				methodName = "public static int ItemsCount()";
				if (lstTag == null) {
					throw new NullReferenceException ("lstTag collection " +
                                                       "has not been " +
                                                        "initalized.");
				}            
				intCnt = lstTag.Count;            
				//All ok            
				return intCnt;
			} catch (NullReferenceException ex) {
				errMsg = "Encountered error while getting count of items " +
                    "contained in the collection.";
				MyMessages clsMsg = new MyMessages ();
				clsMsg.BuildErrorString (className, methodName, errMsg,
                                        ex.Message.ToString ());
				return intCnt;
			}
		} //End Method 		
		
		
		public static bool RemoveItemAt (int intIndex)
		{
			bool retVal = false;
            
			try {
				methodName = "public static bool RemoveItemAt(int intIndex)";
				if (intIndex < 1) {
					throw new IndexOutOfRangeException ("intIndex is less " +
                                                         "then zero.");
				} else if (intIndex > (lstTag.Count - 1)) {
					throw new IndexOutOfRangeException ("intIndex is greater " +
                                                         "then the number of " +
                                                         "items in the " +
                                                         "collection");
				} else if (lstTag == null) {
					throw new NullReferenceException ("lstTag collection " +
                                                      "has not been " +
                                                       "initalized.");
				}
				lstTag.RemoveAt (intIndex);
				//All ok
				retVal = true;
				return retVal;
			} catch (IndexOutOfRangeException ex) {
				errMsg = "Encountered error while removing items at this " +
                    "index:  " + intIndex.ToString ();
				MyMessages clsMsg = new MyMessages ();
				clsMsg.BuildErrorString (className, methodName, errMsg,
                    ex.Message.ToString ());
				return retVal;
			} catch (NullReferenceException ex) {
				errMsg = "Encountered error while removing items at this " +
                    "index:  " + intIndex.ToString ();
				MyMessages clsMsg = new MyMessages ();
				clsMsg.BuildErrorString (className, methodName, errMsg,
                    ex.Message.ToString ());
				return retVal;        
			}
		} //End Method
		
		/// <summary>
		/// Method -- public static clsSongTagRecord GetItemAt
		/// 
		/// Gets the item at intIndex.
		/// </summary>
		/// <returns>
		/// The <see cref="clsSongTagRecord"/>.
		/// </returns>
		/// <param name='intIndex'>
		/// Int index.
		/// </param>
		/// <exception cref='IndexOutOfRangeException'>
		/// Is thrown when an attempt is made to access an element of an array 
		/// with an index that is outside the bounds
		/// of the array.
		/// </exception>
		public static SongTagRecord GetItemAt (int intIndex)
		{   
			SongTagRecord clsStr = null;
            
			try {
				methodName = "Public static clsSongTagRecord GetItemAt(intIndex)";
				if (intIndex < 0) {
					throw new IndexOutOfRangeException ("intIndex is less " +
                                                        "then zero.");  
				} else if (intIndex > (lstTag.Count - 1)) {
					throw new IndexOutOfRangeException ("intIndex is greater " +
                                                        "then the number of " +
                                                        "items in the " +
                                                        "collection");  
				} else if (lstTag == null) {
					throw new NullReferenceException ("lstTag collection " +
                                                     "has not been " +
                                                      "initalized.");
				}
             
				clsStr = new SongTagRecord ();
				clsStr = lstTag [intIndex];
             
				//All Ok
				return clsStr;
			} catch (IndexOutOfRangeException ex) {
				errMsg = "Encountered error while gettin item at this " +
                    "index: " + intIndex.ToString ();
				MyMessages clsMsg = new MyMessages ();
				clsMsg.BuildErrorString (className, methodName, errMsg,
                    ex.Message.ToString ());
				return clsStr;
			} catch (NullReferenceException ex) {
				errMsg = "Encountered error while gettin item at this " +
                    "index: " + intIndex.ToString ();
				MyMessages clsMsg = new MyMessages ();
				clsMsg.BuildErrorString (className, methodName, errMsg,
                    ex.Message.ToString ());
				return clsStr;   
			}
		} //End Method   
     
		/// <summary>
		/// Method -- public static clsSongTagRecord GetAllIems
		/// Gets all items.
		/// </summary>
		/// <returns>
		/// The all items.
		/// </returns>
		public static SongTagRecord GetAllItems ()
		{
			SongTagRecord clsStr = null;
            
			try {
				methodName = "public static clsSongTagRecord GetAllItems()";
				if (lstTag == null) {
					throw new NullReferenceException ("lstTag collection " +
                                                     "has not been " +
                                                      "initalized.");
				}
				int intCnt = lstTag.Count;
             
				for (int i  = 0; i < intCnt; i++) {
					clsStr = new SongTagRecord ();
					clsStr = lstTag [i];
				}
				//All ok
				return clsStr;
			} catch (NullReferenceException ex) {
				errMsg = "Encountered error while getting item from " +
                    "this collection.";
				MyMessages clsMsg = new MyMessages ();
				clsMsg.BuildErrorString (className, methodName, errMsg,
                    ex.Message.ToString ());
				return clsStr;
			} 
		} //End Method
			
			
	} //End class clsSongTagList
	
} //End namespace MusicManager

