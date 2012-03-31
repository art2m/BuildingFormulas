//  
//  InputDialog.cs
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
	public partial class MyInputDialog : Gtk.Dialog
	{
		
		MyMessages myMsg = null;
        
		public MyInputDialog ()
		{
			this.Build ();
			SetInputMessage ();
		} //End Constructor
        
        
#region Button Events
        
		protected void SelectedCancelButton (object sender, System.EventArgs e)
		{
			if (myMsg == null) {
				myMsg = new MyMessages ();   
			}
			
			myMsg.OutputDialogMessage = null;
		
		} //End Event

		protected void SelectedOkButton (object sender, System.EventArgs e)
		{
			string retVal = null;
			if (myMsg == null) {
				myMsg = new MyMessages ();    
			}           
			retVal = txtData.Text.Trim ();
			myMsg.OutputDialogMessage = retVal;
            
			
		} //End Event
        
#endregion Button Events
        
		private void SetInputMessage ()
		{
			if (myMsg == null) {
				myMsg = new MyMessages ();   
			}
			
			lblInfo.Text = myMsg.InputDialogMessage;
            
		} //End Method
        
	} //End class InputDialog : Gtk.Dialog
    
} //End namespace MusicManager

