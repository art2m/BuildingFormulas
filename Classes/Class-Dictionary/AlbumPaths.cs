//  
//  AlbumPaths.cs
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


/// <summary>
/// Class -- AlbumPaths.cs
/// 
/// Store Album Name as Key Album Path as value.
/// </summary>/
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicManager
{
	public static class AlbumPaths
	{
		private static Dictionary<string, string> dicAlbum = 
                                         new Dictionary<string, string> ();
		private static string className = "AlbumPaths";
		private static string methodName = null;
		private static string errMsg = null;
		private static MyMessages myMsg;  
        
        
		/// <summary>
		/// Method -- public static bool AddNewItem(string KeyItem,
		///                                                 string[] valItem)
		/// 
		/// Adds the new item.
		/// </summary>
		/// <returns>
		/// The new item.
		/// </returns>
		/// <param name='keyItem'>
		/// If set to <c>true</c> key item.
		/// </param>
		/// <param name='valItem'>
		/// If set to <c>true</c> value item.
		/// </param>
		public static bool AddNewItem (string keyItem, string valItem)
		{
			bool retVal = false;
			try {
                
				myMsg = new MyMessages ();
                
				dicAlbum.Add (keyItem, valItem);
                
				//All ok
				retVal = true;
				return retVal;
			} catch (ArgumentException ex) {
				errMsg = "This key already exists in the collection. /n " +
                                    "It will not be added to the collection.";
				StringBuilder sb = new StringBuilder ();
				sb.Append (keyItem).Append (":  ").Append (errMsg);
                
				myMsg.BuildErrorString (className, methodName, errMsg,
                                       ex.Message.ToString ());    
				return retVal;                               
			} 
                
		} //End Method
        
        
		/// <summary>
		/// Method -- public static bool ContainsKey (string keyItem)
		/// 
		/// Containses the key.
		/// </summary>
		/// <returns>
		/// true contains key else false.
		/// </returns>
		/// <param name='keyItem'>
		/// If set to <c>true</c> key item.
		/// </param>
		public static bool ContainsKey (string keyItem)
		{
			bool retVal = false;
            
			retVal = dicAlbum.ContainsKey (keyItem);
            
			return retVal;
		} //End Method
        
        
		/// <summary>
		/// Method -- public static string[] ReturnItemValueAtKEy (
		///                                                     string keyItem)
		/// 
		/// Returns the item value at key.
		/// </summary>
		/// <returns>
		/// The item value at key.
		/// </returns>
		/// <param name='keyItem'>
		/// Key item.
		/// </param>
		public static string ReturnItemValueAtKey (string keyItem)
		{
			string val;
            
			dicAlbum.TryGetValue (keyItem, out val);
            
			return val;
		} //End Method
        
        
		/// <summary>
		/// Method -- public static bool RemoveItem (string keyItem)
		/// 
		/// Removes the item.
		/// </summary>
		/// <returns>
		/// true if item removed else false.
		/// </returns>
		/// <param name='keyItem'>
		/// If set to <c>true</c> key item.
		/// </param>
		public static bool RemoveItem (string keyItem)
		{
			bool retVal = false;
            
			retVal = dicAlbum.Remove (keyItem);
            
			return retVal;
		} //End Method
        
        
		/// <summary>
		/// Method public static bool ClearCollection()
		/// 
		/// Clears the collection.
		/// </summary>
		/// <returns>
		/// true if collection cleared else false.
		/// </returns>
		public static bool ClearCollection ()
		{
			bool retVal = false;
            
			dicAlbum.Clear ();
            
			//all ok
			retVal = true;
			return retVal;
		} //End Method
        
        
		/// <summary>
		/// Method -- public static int ItemsCount()
		/// 
		/// Count of items contained in the collection
		/// </summary>
		/// <returns>
		/// The count.
		/// </returns>
		public static int ItemsCount ()
		{
			int cnt;
			cnt = dicAlbum.Count;
            
			return cnt;
		} //End Method
        
        
	} //End class AlbumPaths
    
} //End namespace MusicManager

