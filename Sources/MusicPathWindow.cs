//  
//  MusicPathWindow.cs
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

namespace MusicManager
{
	public partial class MusicPathWindow : Gtk.Window
	{
		public MusicPathWindow () : 
                base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
            
			SetToolTips ();
		}

#region Button Events
        
		/// <summary>
		/// Event -- protected void InsertUnderscoreInPathNameButton
		/// 
		/// Inserts the underscore in path name button.
		/// </summary>
		/// <param name='sender'>
		/// Sender.
		/// </param>
		/// <param name='e'>
		/// E.
		/// </param>
		protected void InsertUnderscoreInPathNameButton (object sender, 
                                                            System.EventArgs e)
		{
			bool retVal = false;
            
			InsertUnderscore insert = new InsertUnderscore ();
            
			retVal = insert.BeginIterateMusicDirectories ();
            
			if (retVal) {
				lblInfo.Text = "Completed underscore insertion successfully.";
			} else {
				lblInfo.Text = "Unable to complete underscore insertion.";
			}
                
		} //End Event
  
        
		/// <summary>
		/// Event -- protected void RemoveUnderscoreFormPathNameButton
		/// 
		/// Removes the underscore from path name button.
		/// </summary>
		/// <param name='sender'>
		/// Sender.
		/// </param>
		/// <param name='e'>
		/// E.
		/// </param>
		protected void RemoveUnderscoreFromPathNameButton (object sender, 
                                                            System.EventArgs e)
		{
			bool retVal = false;
            
			RemoveUnderscore remUnderscore = new RemoveUnderscore ();
            
			//retVal = remUnderscore.RemoveUnderscoreFromSongPath ();
            
			if (retVal) {
				lblInfo.Text = "Completed removing underscore successfully.";
			} else {
				lblInfo.Text = "Unable to complete underscore removal.";
			}
            
		} //End Event
           
        
		/// <summary>
		/// Event -- protected void QuitChangeMusicPathStructureWindowButton
		/// 
		/// Quits the change music path structure window button.
		/// </summary>
		/// <param name='sender'>
		/// Sender.
		/// </param>
		/// <param name='e'>
		/// E.
		/// </param>
		protected void QuitChangeMusicPathStructureWindowButton (object sender, 
                                                            System.EventArgs e)
		{
			this.Destroy ();
		} //End Event
        
#endregion Button Events
        
		/// <summary>
		/// Method -- private void SetToolTips
		/// 
		/// Sets the tool tips.
		/// </summary>
		private void SetToolTips ()
		{
			btnInsert.TooltipText = "Select to insert an underscore" +
             " charater into all spaces into the complete song path. ";
            
			btnRemove.TooltipText = "Select to remove all underscores" +
             " from the complete song path and insert spaces.";
		} //End Method
        
		
	} //End class MusicPathWindow
    
} //End namespace MusicManager

