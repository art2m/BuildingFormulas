//  
//  MessageWindow.cs
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
using System.Text;
using System.IO;
using Gtk;

namespace MusicManager
{
	public partial class MessageWindow : Gtk.Window
	{
        
		StringBuilder sbMsg = null;
		MessageDialog md = null;
     
		public MessageWindow () : 
                base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
		} //End Constructor
        
		private string className = null;

		public string SetClassName {
			set {
				className = value;
			}    
		} //End Property
        
        
		private string methodName = null;

		public string SetMethodName {
			set {
				methodName = value;
			}
		} //End Property
        
		private string errMsg = null;

		public string SetErrorMessage {
			set {
				errMsg = value;
			}
		} //End Property
        
		private string exMsg = null;

		public string SetExceptionMessage {
			set {
				exMsg = value;
			}
		} //End Property
        
        
        #region Show MessageBox
        
		/// <summary>
		/// Method -- public void ShowErrMessage
		/// 
		/// Shows the error message.
		/// </summary>
		/// <param name='strMsg'>
		/// String message.
		/// </param>
		public void ShowErrMessage (string strMsg)
		{
            
			MessageDialog md = null;
         
			//string dlgtest = "SongTagWindow";
			md = new MessageDialog (this, DialogFlags.DestroyWithParent, MessageType.Error, 
                                    ButtonsType.Ok, strMsg);
			md.Run ();
			md.Destroy ();
			this.Destroy ();
		} //End Method
  
		/// <summary>
		/// Method -- public void ShowSucessMessage
		/// 
		/// Shows the success message.
		/// </summary>
		/// <param name='strMsg'>
		/// String message.
		/// </param>
		public void ShowSuccessMessage (string strMsg)
		{
			MessageDialog md = null;
         
			md = new MessageDialog (null, DialogFlags.Modal, MessageType.Other, 
                                    ButtonsType.Ok, strMsg);
         
			md.Run ();
			md.Destroy ();
		} //End Method
  
		/// <summary>
		/// Method -- public void ShowInformationMessage
		/// Shows the information message.
		/// </summary>
		/// <param name='strMsg'>
		/// String message.
		/// </param>
		public void ShowInformationMessage (string strMsg)
		{
			MessageDialog md = null;            
         
			md = new MessageDialog (null, DialogFlags.Modal, MessageType.Info, 
                                    ButtonsType.Ok, strMsg);
         
     
			md.Run ();
			md.Destroy ();
		} //End Method
  
		/// <summary>
		/// Method -- public ResponseType showYesNoMessage
		/// 
		/// Shows the yes no message.
		/// </summary>
		/// <returns>
		/// The yes no message.
		/// </returns>
		/// <param name='strMsg'>
		/// String message.
		/// </param>
		public ResponseType ShowYesNoMessage (string strMsg)
		{
			//MessageDialog md = null;
			ResponseType rspRetVal;
         
			md = new MessageDialog (null, DialogFlags.Modal, 
                                    MessageType.Question, 
                                    ButtonsType.YesNo, strMsg);
			rspRetVal = (ResponseType)md.Run ();
         
			md.Destroy ();
			//All Ok
			return rspRetVal;
		} //End Method 
     #endregion
     
		/// <summary>
		/// Method -- public void BuildErrorString
		/// 
		/// Builds the error string.
		/// </summary>
		/// <param name='className'>
		/// String class.
		/// </param>
		/// <param name='methodName'>
		/// String method.
		/// </param>
		/// <param name='errMsg'>
		/// String error message.
		/// </param>
		/// <param name='strException'>
		/// String exception.
		/// </param>
		public void BuildErrorString (string className, string methodName,
                             string errMsg, string strException)
		{
			sbMsg = new StringBuilder ();
         
			sbMsg.Append (className);
			sbMsg.AppendLine ();
			sbMsg.Append (methodName);
			sbMsg.AppendLine ();
			sbMsg.Append (errMsg);
			sbMsg.AppendLine ();
			sbMsg.Append (strException);
         
			this.ShowErrMessage (sbMsg.ToString ());
     
		} // End METHOD     
        
        
		public string BuildNewErrorString ()
		{
			sbMsg = new StringBuilder ();
         
			sbMsg.Append (className);
			sbMsg.AppendLine ();
			sbMsg.Append (methodName);
			sbMsg.AppendLine ();
			sbMsg.Append (errMsg);
			sbMsg.AppendLine ();
			sbMsg.Append (exMsg);
         
			return sbMsg.ToString ();
			//this.ShowErrMessage (sbMsg.ToString ());
		}
        
		public void ShowMessage (Window parent, string title, string message)
		{
			Dialog dialog = null;
			try {
				dialog = new Dialog (title, parent,
            DialogFlags.DestroyWithParent | DialogFlags.Modal,
            ResponseType.Ok);
				dialog.VBox.Add (new Label (message));
				dialog.ShowAll ();

				dialog.Run ();
			} finally {
				if (dialog != null)
					dialog.Destroy ();
			}
		}
        
        
	} //End class MessageWindow : Gtk.Window
    
} //End namespace MusicManager

