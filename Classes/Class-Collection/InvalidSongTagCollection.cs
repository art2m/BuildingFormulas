//  
//  clsSongMissingTagList.cs
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
/// class -- clsSongMissingTagList
/// 
/// This collection stores all song tags that have missing
/// information, errors, missing or corrupt.
/// 
/// </summary>
using System;
using System.Collections.Generic;

namespace MusicManager
{
	public static class InvalidSongTagCollection
	{
		
		private static string methodName = null;
		private static string errMsg = null;
		private static string className = "clsSongMissingTagList";
		static List<SongTagRecord> sngTagInv = new List<SongTagRecord> ();
		//static ArrayList sngTagInv = new ArrayList ();
        
		/// <summary>
		/// Method -- public static bool AddNewItem
		/// 
		/// Adds the new item.
		/// </summary>
		/// <returns>
		/// The new item.
		/// </returns>
		/// <param name='sngTagRecord'>
		/// If set to <c>true</c> object song tag.
		/// </param>
		/// <exception cref='ArgumentNullException'>
		/// Is thrown when an argument passed to a method is invalid because it 
		/// is <see langword="null" /> .
		/// </exception>
		/// <exception cref='NullReferenceException'>
		/// Is thrown when there is an attempt to dereference a null object 
		/// reference.
		/// </exception>/
		public static bool  AddNewItem (SongTagRecord sngTagRecord)
		{
			bool retVal = false;
			
			try {
				methodName = "public static bool AddNewItem(clsSongTagRecord " +
              "sngTagRecord)";
                
				errMsg = "Encountered error while adding item to collection.";                
             
				sngTagInv.Add (sngTagRecord);
                 
				//All ok 
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
        
		public static bool InsertItemAt (int index, SongTagRecord sngTagRecord)
		{
			bool retVal = false;
            
			try {
				methodName = "public static bool InsertItemAt(int index," +
                                                " SongTagRecord sngTagRecord)";
                
				errMsg = "Encountered error while adding item to collection.";               
				
				sngTagInv.Insert (index, sngTagRecord);
                
				//all ok
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
        
		
		/// <summary>
		/// Method -- public static int ClearArray
		/// Clears the array.
		/// </summary>
		/// <returns>
		/// The array.
		/// </returns>
		public static void ClearArray ()
		{    
			try {
				methodName = "public static void ClearArray";      
				errMsg = "Encountered error while clearing the collection.";
               
				sngTagInv.Clear ();
                
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
		
		/// <summary>
		/// Method -- public static int ItemsCount
		/// 
		/// Itemses the count.
		/// </summary>
		/// <returns>
		/// The count.
		/// </returns>
		public static int ItemsCount ()
		{
			int recCnt = 0;
            
			try {
				methodName = "public static int ItemsCount()";
                
				errMsg = "Encountered error while getting count of items " +
                                                "contained in the collection.";
               
             
				//All ok
				recCnt = sngTagInv.Count;
				return recCnt;
			} catch (NullReferenceException ex) {				
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg,
                                        ex.Message.ToString ());
				return recCnt;
			} catch (InvalidOperationException ex) {
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg,
                                        ex.Message.ToString ());
				return recCnt;
			}
		} //End Method 
        
        
		/// <summary>
		/// Method -- public static bool RemoveItemAt
		/// 
		/// Removes the item at index.
		/// </summary>
		/// <returns>
		/// The <see cref="System.Boolean"/>.
		/// </returns>
		/// <param name='index'>
		/// If set to <c>true</c> int index.
		/// </param>
		/// <exception cref='IndexOutOfRangeException'>
		/// Is thrown when an attempt is made to access an element of an array 
		/// with an index that is outside the bounds
		/// of the array.
		/// </exception>
		public static bool RemoveItemAt (int index)
		{
			bool retVal = false;
            
			try {
				methodName = "public static bool RemoveItemAt(int index)";                
               
				sngTagInv.RemoveAt (index);
             
				//All ok
				retVal = true;
				return retVal;
			} catch (IndexOutOfRangeException ex) {		
				errMsg = "Encountered error while removing items at this " +
                    "index:  " + index.ToString ();
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg,
                    ex.Message.ToString ());
				return retVal;
			} catch (NullReferenceException ex) {
				errMsg = "Encountered error while removing items at this " +
                    "index:  " + index.ToString ();
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg,
                    ex.Message.ToString ());
				return retVal;   
			} catch (ArgumentNullException ex) {
				errMsg = "Encountered error while removing items at this " +
                    "index:  " + index.ToString ();
                
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg,
                    ex.Message.ToString ());
				return retVal;       
			} catch (InvalidOperationException ex) {
				errMsg = "Encountered error while removing items at this " +
                    "index:  " + index.ToString ();
                
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg,
                    ex.Message.ToString ());
				return retVal;     
			}
		} //End Method
		
        
		/// <summary>
		/// Method -- public static clsSongTagRecord GetItemAt
		/// 
		/// Gets the item at index.
		/// </summary>
		/// <returns>
		/// The <see cref="clsSongTagRecord"/>.
		/// </returns>
		/// <param name='index'>
		/// Int index.
		/// </param>
		/// <exception cref='IndexOutOfRangeException'>
		/// Is thrown when an attempt is made to access an element of an array 
		/// with an index that is outside the bounds
		/// of the array.
		/// </exception>
		public static SongTagRecord GetItemAt (int index)
		{   
			
            
			try {
				methodName = "Public static clsSongTagRecord GetItemAt(index)";                
						
			
				//All Ok
				//Console.WriteLine (sngTagInv [index].SongTitle);
				return sngTagInv [index];
			} catch (IndexOutOfRangeException ex) {
				errMsg = "Encountered error while gettin item at this " +
                    "index: " + index.ToString ();
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg,
                    ex.Message.ToString ());
				return null;
			} catch (NullReferenceException ex) {
				errMsg = "Encountered error while gettin item at this " +
                    "index: " + index.ToString ();
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg,
                    ex.Message.ToString ());
				return null;  
			} 
		} //End Method	
		
        
        
		      
		/// <summary>
		/// Method -- public static clsSongTagRecord GetAllIems
		/// Gets all items.
		/// </summary>
		/// <returns>
		/// The all items.
		/// </returns>
		public static void GetAllItems ()
		{
		
			
            
			try {
				methodName = "public static clsSongTagRecord GetAllItems()";
                
                
				if (sngTagInv == null) {
					throw new NullReferenceException ("sngTagRecords " +
                                        " collection has not been initalized.");
				}
				int recCnt = sngTagInv.Count;
			
                
				for (int i  = 0; i < recCnt; i++) {
				    
					SongTagRecord recSongTag = new SongTagRecord ();
                    
					//recSongTag = sngTagInv [i].SongTitle;                   
                    
				}
				//All ok
				
			} catch (NullReferenceException ex) {
				errMsg = "Encountered error while getting item from " +
                                                "clsSongMissingTag collection.";
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg,
                    ex.Message.ToString ());
				
			} 
		} //End Method
		
     
	} //End class clsSongMissingTagList
	
} //End namespace MusicManager

