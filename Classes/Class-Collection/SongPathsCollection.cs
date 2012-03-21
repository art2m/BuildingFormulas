//  
//  clsSongsPathList.cs
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
using System;
using System.Collections.Generic;

namespace MusicManager
{
	public static class SongPathsCollection
	{
		private static string strMethod = null;
		private static string strErrMsg = null;
		private static string strClass = "clsSongPathList";
		private static List<string> lstPaths = new List<string> ();
        
		
        
		/// <summary>
		/// Method -- public static bool AddNewItem(string strPath)
		/// 
		/// Adds the new item.
		/// </summary>
		/// <returns>
		/// The new item.
		/// </returns>
		/// <param name='strPath'>
		/// If set to <c>true</c> string path.
		/// </param>
		/// <exception cref='ArgumentNullException'>
		/// Is thrown when an argument passed to a method is invalid because it 
		/// is <see langword="null" /> .
		/// </exception>
		/// <exception cref='NullReferenceException'>
		/// Is thrown when there is an attempt to dereference a null object 
		/// reference.
		/// </exception>
		public static bool  AddNewItem (string strPath)
		{
			bool bolRetVal = false;
            
			try {
				strMethod = "public static bool AddNewItem(string strPath)";
				   
				lstPaths.Add (strPath); 
				//All ok
				bolRetVal = true;
                
				return bolRetVal;
			} catch (ArgumentNullException ex) {
				strErrMsg = "Encountered error while adding new song path " +
                    "to this collection: " + strPath;
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (strClass, strMethod, strErrMsg,
                                        ex.Message.ToString ());               
				return bolRetVal;
			} catch (NullReferenceException ex) {
				strErrMsg = "Encountered error while adding new song path " +
                    "to this collection: " + strPath;
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (strClass, strMethod, strErrMsg,
                                        ex.Message.ToString ());               
				return bolRetVal;
			}
		} //End Method
		
        
		/// <summary>
		/// Method -- public static bool ContainsItem
		/// 
		/// Check string passed in and see if it is in the list.
		/// </summary>
		/// <returns>
		/// true if in collection false if not or false if error.
		/// </returns>
		/// <param name='strPath'>
		/// If set to <c>true</c> string genre.
		/// </param>
		public static bool ContainsItem (string strPath)
		{    
			bool bolRetVal = false;
            
			try {
				strMethod = "public static bool ContainsItem(string strPath";      
                				
				bolRetVal = lstPaths.Contains (strPath);
             
				//All ok
				bolRetVal = true;
				return bolRetVal;
			} catch (ArgumentException ex) {
				strErrMsg = "Encountered error while checking for this item: " +
                    strPath;
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (strClass, strMethod, strErrMsg,
                    ex.Message.ToString ());
				return bolRetVal;
			} catch (NullReferenceException ex) {
				strErrMsg = "Encountered error while checking for this item: " + 
                    strPath;
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (strClass, strMethod, strErrMsg,
                    ex.Message.ToString ());
				return bolRetVal;
			}                
		} //End Method
     
     
       	
		/// <summary>
		/// Method -- public static void ClearArray
		/// Clears the array.
		/// </summary>
		public static void ClearArray ()
		{   
			try {
				strMethod = "public static void ClearArray()";
				
				lstPaths.Clear ();
			} catch (NullReferenceException ex) {
				strErrMsg = "Encountered error while clearing the collection.";
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (strClass, strMethod, strErrMsg,
                                        ex.Message.ToString ());
			}            
		} //End Method
		
		/// <summary>
		/// Method -- public static int ItemsCount
		/// 
		/// Get count of items in collection.
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
				strMethod = "public static int ItemsCount()";
				
				intCnt = lstPaths.Count;
				//All ok
				return intCnt;
			} catch (NullReferenceException ex) {
				strErrMsg = "Encountered error while getting count of items " +
                    "contained in the collection.";
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (strClass, strMethod, strErrMsg,
                                        ex.Message.ToString ());
				return intCnt;
			}
		} //End Method         
	    
        
        
		public static string GetItemAt (int index)
		{
			try {
				strMethod = "public static string GetItemAt(int index)";
				return lstPaths [index];
			} catch (IndexOutOfRangeException ex) {
				MyMessages myMsg = new MyMessages ();
				strErrMsg = "Encountered error while returning song path.";
				myMsg.BuildErrorString (strClass, strMethod, strErrMsg,
                                       ex.Message.ToString ());
				return null;
                
			}
		} //End Method
            
            
		/// <summary>
		/// Method -- public static int GetItemIndex
		/// 
		/// Gets the index of the item.
		/// </summary>
		/// <returns>
		/// The item index.
		/// </returns>
		/// <param name='strPath'>
		/// String genre.
		/// </param>
		public static int GetItemIndex (string strPath)
		{
			int intRetVal = 0;
            
			try {
				strMethod = "public static int GetItemIndex(string strPath)";
				            
				intRetVal = lstPaths.IndexOf (strPath);             
				//All ok              
				return intRetVal;
			} catch (ArgumentException ex) {
				strErrMsg = "Encountered error getting index of this item: " +
                    strPath;
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (strClass, strMethod, strErrMsg,
                    ex.Message.ToString ());
				return intRetVal;
			} catch (NullReferenceException ex) {
				strErrMsg = "Encountered error getting index of this item: " +
                    strPath;
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (strClass, strMethod, strErrMsg,
                    ex.Message.ToString ());
				return intRetVal;
			}
		} //End Method
        
        
		/// <summary>
		/// Method -- public static bool RemoveItem
		/// Removes the item.
		/// </summary>
		/// <returns>
		/// The item.
		/// </returns>
		/// <param name='strPath'>
		/// If set to <c>true</c> string genre.
		/// </param>
		public static bool RemoveItem (string strPath)
		{
			bool bolRetVal = false;
         
			try {
				strMethod = "public static bool RemoveItem(string strPath)";
				
				lstPaths.Remove (strPath);
             
				//All ok
				bolRetVal = true;
				return bolRetVal;
			} catch (ArgumentException ex) {
				strErrMsg = "Encountered error while removing this item: " +
                    strPath;
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (strClass, strMethod, strErrMsg,
                    ex.Message.ToString ());                
				return bolRetVal;
			} catch (NullReferenceException ex) {
				strErrMsg = "Encountered error while removing this item: " +
                    strPath;
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (strClass, strMethod, strErrMsg,
                    ex.Message.ToString ());
				return bolRetVal;
			}
		} //End Method
     
        
		public static bool RemoveItemAt (int intIndex)
		{
			bool bolRetVal = false;
            
			try {
				strMethod = "public static bool RemoveItemAt(int intIndex)";
				
				lstPaths.RemoveAt (intIndex);            
				//All ok
				bolRetVal = true;
				return bolRetVal;
			} catch (IndexOutOfRangeException ex) {
				strErrMsg = "Encountered error removing item at index: " +
                    intIndex.ToString ();
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (strClass, strMethod, strErrMsg,
                                        ex.Message.ToString ());
				return bolRetVal;
			} catch (NullReferenceException ex) {
				strErrMsg = "Encountered error removing item at index: " +
                    intIndex.ToString ();
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (strClass, strMethod, strErrMsg,
                                        ex.Message.ToString ());
				return bolRetVal;   
			}
		} //End Method 
		
		/// <summary>
		/// Method -- public bool GetAllItems()
		/// 
		/// Gets all genre directories from collection list.
		/// 
		/// </summary>
		/// <returns>
		/// all genre directories.
		/// </returns>       
		public static string[] GetAllItems ()
		{   		
			
			return lstPaths.ToArray ();            
			
		} //End Method 
        
      
	} //End class clsSongsPathList
    
  
	
} //End namespace MusicManger

