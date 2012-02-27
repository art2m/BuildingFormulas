
/********************************************************************************************************************************
 * 
 *  Class clsMessages
 *  
 * This class displays Messages to give the user information about the program
 * 
 * *****************************************************************************************************************************/
using System;
using System.Text;
using System.IO;
using Gtk;
using System.Threading;

namespace MusicManager
{
	class MyMessages
	{   	
		StringBuilder sbMsg = null;
		MessageDialog md = null;
		private ResponseType rspRetVal;
        
		public MyMessages ()
		{
			
		} // End Constructor		
	
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
			md = new MessageDialog (null, DialogFlags.Modal, MessageType.Error, 
                                    ButtonsType.Ok, strMsg);
            
			Thread.Sleep (20);
			rspRetVal = (ResponseType)md.Run ();
         
			md.Destroy ();
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
			Thread.Sleep (20);
			rspRetVal = (ResponseType)md.Run ();
		
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
			Thread.Sleep (20);
			rspRetVal = (ResponseType)md.Run ();
            
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
			Thread.Sleep (20);
            
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

	} // End class clsMessages

} // End namespace MusicManager
