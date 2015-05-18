//
//  MyMessages.cs
//
//  Author:
//       art2m <art2m@live.com>
//
//  Copyright (c) 2015 art2m
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

namespace BuildingFormulas
{
	using System;
	using System.Text;
	using System.IO;
	using Gtk;
	using System.Threading;

	class MyMessages
	{
		StringBuilder sbMsg = null;
		MessageDialog md = null;
		private ResponseType rspRetVal;

		public MyMessages()
		{
			
		}

	
		#region Show MessageBox

		/// <summary>
		/// Method -- public void ShowErrMessage
		/// 
		/// Shows the error message.
		/// </summary>
		/// <param name='strMsg'>
		/// String message.
		/// </param>
		public void ShowErrMessage(string strMsg)
		{
            
			//MessageDialog md = null;
			
			//string dlgtest = "SongTagWindow";
			md = new MessageDialog(null, DialogFlags.Modal, MessageType.Error, 
				ButtonsType.Ok, strMsg);
            
			
			rspRetVal = (ResponseType)md.Run();
			Thread.Sleep(20);
		
         
			md.Destroy();
		}
		//End Method
        
		
  
		/// <summary>
		/// Method -- public void ShowSucessMessage
		/// 
		/// Shows the success message.
		/// </summary>
		/// <param name='strMsg'>
		/// String message.
		/// </param>
		public void ShowSuccessMessage(string strMsg)
		{
			MessageDialog md = null;
			
			md = new MessageDialog(null, DialogFlags.Modal, MessageType.Other, 
				ButtonsType.Ok, strMsg);
			Thread.Sleep(20);
			rspRetVal = (ResponseType)md.Run();
		
			md.Destroy();
		}
		//End Method
  
		/// <summary>
		/// Method -- public void ShowInformationMessage
		/// Shows the information message.
		/// </summary>
		/// <param name='strMsg'>
		/// String message.
		/// </param>
		public void ShowInformationMessage(string strMsg)
		{
			MessageDialog md = null;			
			
			md = new MessageDialog(null, DialogFlags.Modal, MessageType.Info, 
				ButtonsType.Ok, strMsg);
			Thread.Sleep(20);
			rspRetVal = (ResponseType)md.Run();
            
			md.Destroy();
		}
		//End Method
  
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
		public ResponseType ShowYesNoMessage(string strMsg)
		{
			//MessageDialog md = null;
			ResponseType rspRetVal;
			
			md = new MessageDialog(null, DialogFlags.Modal, 
				MessageType.Question, 
				ButtonsType.YesNo, strMsg);
			Thread.Sleep(20);
            
			rspRetVal = (ResponseType)md.Run();
			
			md.Destroy();
			//All Ok
			return rspRetVal;
		}
		//End Method
        
		/// <summary>
		/// Method -- public string ShowOkCancelMessage(string strMsg)
		/// Shows the OK cancel message.
		/// </summary>
		/// <returns>
		/// The OK cancel message.
		/// </returns>
		/// <param name='strMsg'>
		/// String message.
		/// </param>
		public ResponseType ShowOKCancelMessage(string strMsg)
		{
			MessageDialog md = null;			
            
			md = new MessageDialog(null, DialogFlags.Modal,
				MessageType.Question,
				ButtonsType.OkCancel, strMsg);
			Thread.Sleep(20);
            
			rspRetVal = (ResponseType)md.Run();		
			md.Destroy();
            
			return rspRetVal;
          
		}
		//End Method
        
          
		public void ShowMessage(Window parent, string title, string message)
		{
			Dialog dialog = null;
			try
			{
				dialog = new Dialog(title, parent,
					DialogFlags.DestroyWithParent | DialogFlags.Modal,
					ResponseType.Ok);
				dialog.VBox.Add(new Label(message));
				dialog.ShowAll();

				dialog.Run();
			}
			finally
			{
				if (dialog != null)
					dialog.Destroy();
			}
            
		}

		#endregion Show MessageBox

		
        
		
		#region CREATE MESSAGE STRINGS

		/// <summary>
		/// Method -- public void BuildErrorString
		/// 
		/// Builds the error string.
		/// </summary>
		/// <param name='MyMyClassName'>
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
		public void BuildErrorString(string MyMyClassName, string methodName,
		                                   string errMsg, string strException)
		{
			sbMsg = new StringBuilder();
            
			sbMsg.Append(MyMyClassName);
			sbMsg.AppendLine();
			sbMsg.Append(methodName);
			sbMsg.AppendLine();
			sbMsg.Append(errMsg);
			sbMsg.AppendLine();
			sbMsg.Append(strException);
            
			this.ShowErrMessage(sbMsg.ToString());

		}

		/// <summary>
		/// Builds the error string.
		/// </summary>
		/// <param name="errMsg">Error message.</param>
		/// <param name="strException">String exception.</param>
		public void BuildErrorString(string errMsg, string strException)
		{
			sbMsg = new StringBuilder();

			sbMsg.Append((errMsg));
			sbMsg.AppendLine();
			sbMsg.AppendLine();
			sbMsg.Append(strException);

			this.ShowErrMessage(sbMsg.ToString());
		}

		#endregion CREATE MESSAGE STRINGS

	}
	// End class clsMessages

}
// End namespace MusicManager
