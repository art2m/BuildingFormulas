//  
//  SongTagWindow.cs
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
using System.IO;
using System.Threading;
using System.Diagnostics;

#region MyEvents

public delegate void SngPathBeingProcessed (string sngPath);


#endregion MyEvents

namespace MusicManager
{
	public partial class SongTagWindow : Gtk.Window
	{
        
#region Class Declerations
        
		SongTagRecord sngRec = null;
		ValidateSongTags valSngTags = new ValidateSongTags ();
		TagRecordState tagRecState = new TagRecordState ();
		DefaultTraceListener d = new DefaultTraceListener ();
        
#endregion Class Declerations
        
		//if false then we are doing Invalid Tags. true
		//then doing valid tags.
		private bool validTags = false;
        
 #region Error Strings
        
		private string methodName = null;
		private string errMsg = null;
		private const string className = "SongTagWindow";
        
#endregion Error Strings       
        
		
		private Thread sngPath = null;
		
		public SongTagWindow () : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();		
			
			SetToolTips ();
            
			SetTagRecordTextBoxesState (false);
			SetFilePathTextBoxesState (false);
		}
        
		/// <summary>
		/// public void DisplaySongsBeingProcessed
		/// 
		/// Displaies the songs being processed. Delegate event.
		/// </summary>
		/// <param name='sngPath'>
		/// sngPath.
		/// </param>
		public void DisplaySongsBeingProcessed (string sngPath)
		{     
            
			try {
                
				methodName = "public void DisplaySongsBeingProcessed(" +
                                                        " string sngPath)";
				errMsg = "Encountered error while displaying current" +
                                                        "  song information.";
				d.AssertUiEnabled = true;
				Debug.Listeners.Add (d);
                   
				sngPath = sngPath.Trim ();
                   
				if (String.IsNullOrEmpty (sngPath)) {
					Debug.Assert (false);
				}
                   
				lblInfo.Text = sngPath;
                
			} catch (ArgumentNullException ex) {
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg,
                                       ex.Message.ToString ());         
			} catch (InvalidOperationException ex) {
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg,
                                       ex.Message.ToString ());    
			}
            
            
		} //End Event            
      
        
        
#region Button Events
        
        
		/// <summary>
		/// Event -- protected void EditTagInformationButton
		/// 
		/// Place the song tag displayed into the edit state.
		/// </summary>
		/// <param name='sender'>
		/// Sender.
		/// </param>
		/// <param name='e'>
		/// E.
		/// </param>
		/// <exception cref='System.NotImplementedException'>
		/// Is thrown when a requested operation is not implemented for a given 
		/// type.
		/// </exception>
		protected void EditTagInformationButton (object sender, 
                                                    System.EventArgs e)
		{
			tagRecState.EditingTagRecordState = true;
			SetTagRecordTextBoxesState (true);
			SetTagEditButtonState ();
			SetMoveButtonsState ();
            
		} //End Event
        
		/// <summary>
		/// Event protected void CancelTagOperationButton
		/// 
		/// cancel Displayed tag operation. The specified sender e.
		/// </summary>
		/// <returns>
		/// <c>true</c> if this instance cancel tag operation the specified 
		/// sender e; otherwise, <c>false</c>.
		/// </returns>
		/// <param name='sender'>
		/// Sender.
		/// </param>
		/// <param name='e'>
		/// E.
		/// </param>
		/// <exception cref='System.NotImplementedException'>
		/// Is thrown when a requested operation is not implemented for a given 
		/// type.
		/// </exception>
		protected void CancelTagOperationButton (object sender, 
                                                        System.EventArgs e)
		{
			//If user cancels operation then call display for tags we
			//are currently showing and redisplay the current tag.
			if (validTags) {
				DisplayValidRecord ();
			} else {
				DisplayInValidRecord ();
			}
			tagRecState.CancelTagEditState = true;
			tagRecState.EditingTagRecordState = false;
			SetTagRecordTextBoxesState (false);            
			SetTagEditButtonState ();   
			SetMoveButtonsState ();
			tagRecState.CancelTagEditState = false;
			
		} //End Event
        
		/// <summary>
		/// Event protected void UpdateTagFileButton
		/// 
		/// Updates this song tag file with changes.
		/// </summary>
		/// <param name='sender'>
		/// Sender.
		/// </param>
		/// <param name='e'>
		/// E.
		/// </param>
		/// <exception cref='System.NotImplementedException'>
		/// Is thrown when a requested operation is not implemented for a given 
		/// type.
		/// </exception>
		protected void UpdateTagFileButton (object sender, System.EventArgs e)
		{
			bool retVal = false;
            
			retVal = UpdateTagData (); 
			//if true reset all settings or if false leave as is.
			if (retVal) {
				tagRecState.TagEditUpdateState = true;
				tagRecState.EditingTagRecordState = false;            
				SetTagRecordTextBoxesState (false);
				tagRecState.TagEditUpdateState = false; 
				SetTagEditButtonState ();
				SetMoveButtonsState ();
				
			}			
			
		}  //End Event
        
        
		/// <summary>
		/// Event -- protected void OpenSongFileButton
		/// 
		/// Opens the song file in a browser, for the tag being edited.
		/// </summary>
		/// <param name='sender'>
		/// Sender.
		/// </param>
		/// <param name='e'>
		/// E.
		/// </param>
		/// <exception cref='System.NotImplementedException'>
		/// Is thrown when a requested operation is not implemented for a given 
		/// type.
		/// </exception>
		protected void OpenSongFileButton (object sender, 
                                                        System.EventArgs e)
		{
			throw new System.NotImplementedException ();
		} //End Event
        
        
		/// <summary>
		/// Method -- protected void ShowSongTagsWithErrorsButton
		/// 
		/// Shows the song tags with errors button.
		/// </summary>
		/// <param name='sender'>
		/// Sender.
		/// </param>
		/// <param name='e'>
		/// E.
		/// </param>
		protected void ShowSongTagsWithErrorsButton (object sender, 
                                                            System.EventArgs e)
		{
			MyMessages myMsg = null;
            
			try {
				methodName = "private void GetTagsWithErrorsFromColleciton()";
          
				validTags = false;
                   
				if (InvalidSongTagCollection.ItemsCount () > 0) {
					tagRecState.TotalTagRecordCount = 
                                               InvalidSongTagCollection.ItemsCount ();
					if (tagRecState.ShowingErrorTagsState != true) {
						tagRecState.TagWindowInitialize = true;          
						tagRecState.ShowingErrorTagsState = true;
						tagRecState.ShowingValidTagsState = false;
						SetTagEditButtonState ();           
                
						btnFirst.Click ();   
					}
				} else {
					errMsg = "Currently there are no tags in this collection."; 
                        
					myMsg = new MyMessages ();
					myMsg.ShowInformationMessage (errMsg);
					myMsg = null;
				}
			} catch (NullReferenceException ex) {
				myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg,
                                       ex.Message.ToString ());                
			} catch (InvalidOperationException ex) {
				myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg,
                                       ex.Message.ToString ());  
			}

		} //End Method

		protected void ShowValidSongTagsButton (object sender, 
                                                        System.EventArgs e)
		{
			MyMessages myMsg = null;
         
			try {
				methodName = "private void GetValidSongTagsFromCollection().";      
          
				validTags = true;
                   
				if (ValidSongTagCollection.ItemsCount () > 0) {
					tagRecState.TotalTagRecordCount = 
                                      ValidSongTagCollection.ItemsCount ();
					if (tagRecState.ShowingValidTagsState != true) {
						tagRecState.TagWindowInitialize = true;  
						tagRecState.ShowingValidTagsState = true;
						tagRecState.ShowingErrorTagsState = false;
						SetTagEditButtonState ();            
                
						btnFirst.Click (); 
					}  
				} else {
					errMsg = "Currently there are no tags in this collection."; 
					myMsg = new MyMessages ();
					myMsg.ShowInformationMessage (errMsg); 
					myMsg = null;
				}
			} catch (NullReferenceException ex) {
				myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg,
                                       ex.Message.ToString ());
			} catch (InvalidOperationException ex) {
				myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg,
                                       ex.Message.ToString ());    
			}
            
			
			
		} //End Method

		
		/// <summary>
		/// Event -- protected void MoveToFirstTagRecordButton
		/// 
		/// Moves to first tag record for either error tags or valid tags.
		/// Depending on which set is currently selected.
		/// </summary>
		/// <param name='sender'>
		/// Sender.
		/// </param>
		/// <param name='e'>
		/// E.
		/// </param>
		protected void MoveToFirstTagRecordButton (object sender, 
                                                    System.EventArgs e)
		{   
			//first record.
			tagRecState.CurrentTagIndex = 0;   
         
			if (tagRecState.ShowingValidTagsState) {
				DisplayValidRecord ();
			} else {
				DisplayInValidRecord ();     
			}
            
			lblInfo.Text = "Record # " + (tagRecState.CurrentTagIndex + 1) +
                " of " + tagRecState.TotalTagRecordCount;
            
			SetMoveButtonsState ();
		} //End Event
        
		/// <summary>
		/// Event -- protected void MoveToPreviousTagRecordButton
		/// Moves to previous tag record for either error tags or valid tags.
		/// Depending on which set is currently selected.
		/// </summary>
		/// <param name='sender'>
		/// Sender.
		/// </param>
		/// <param name='e'>
		/// E.
		/// </param>
		protected void MoveToPreviousTagRecordButton (object sender, 
                                                        System.EventArgs e)
		{
			if (tagRecState.CurrentTagIndex > 0) {
				--tagRecState.CurrentTagIndex;
			}                       
			//if showing tags no errors else with errors.
			if (tagRecState.ShowingValidTagsState) {
				DisplayValidRecord ();
			} else {
				DisplayInValidRecord ();
			}
            
			lblInfo.Text = "Record # " + (tagRecState.CurrentTagIndex + 1) +
                " of " + tagRecState.TotalTagRecordCount;
            
			SetMoveButtonsState ();
		
		} //End Event
  
		/// <summary>
		/// Event -- protected void MoveToNextTagRecordButton
		/// 
		/// Moves to next tag record for either error tags or valid tags.
		/// Depending on which set is currently selected.
		/// </summary>
		/// <param name='sender'>
		/// Sender.
		/// </param>
		/// <param name='e'>
		/// E.
		/// </param>
		protected void MoveToNextTagRecordButton (object sender, 
                                                        System.EventArgs e)
		{
			if ((tagRecState.CurrentTagIndex + 1) < 
                                (tagRecState.TotalTagRecordCount - 1)) {
				++tagRecState.CurrentTagIndex;
             
				if (tagRecState.ShowingValidTagsState) {
					DisplayValidRecord ();
				} else {
					DisplayInValidRecord ();
				}
			}
            
			lblInfo.Text = "Record # " + (tagRecState.CurrentTagIndex + 1) + 
                " of " + tagRecState.TotalTagRecordCount;
            
			SetMoveButtonsState ();
		} //End Event
  
        
		/// <summary>
		/// Event -- protected void MoveToLastTagRecordButton
		/// 
		/// Moves to last tag record for either error tags or valid tags.
		/// Depending on which set is currently selected.
		/// </summary>
		/// <param name='sender'>
		/// Sender.
		/// </param>
		/// <param name='e'>
		/// E.
		/// </param>
		protected void MoveToLastTagRecordButton (object sender, 
                                                        System.EventArgs e)
		{
			tagRecState.CurrentTagIndex = (
                                        tagRecState.TotalTagRecordCount - 1);
         
			if (tagRecState.ShowingValidTagsState) {
				DisplayValidRecord ();
			} else {
				DisplayInValidRecord ();
			}
            
			lblInfo.Text = "Record # " + (tagRecState.CurrentTagIndex + 1) +
                " of " + tagRecState.TotalTagRecordCount;
            
			SetMoveButtonsState ();
		} //End Event
        
        
		/// <summary>
		/// Event -- protected void EditArtistDirectoryPathButton
		/// 
		/// Edits the artist directory path.
		/// </summary>
		/// <param name='sender'>
		/// Sender.
		/// </param>
		/// <param name='e'>
		/// E.
		/// </param>
		/// <exception cref='System.NotImplementedException'>
		/// Is thrown when a requested operation is not implemented for a given 
		/// type.
		/// </exception>
		protected void EditArtistDirectoryPathButton (object sender, 
                                                            System.EventArgs e)
		{
			throw new System.NotImplementedException ();
		} //End Event
        

		/// <summary>
		/// Event -- protected void EditAlbumDirectoryPathButton
		/// 
		/// Edits the album directory path.
		/// </summary>
		/// <param name='sender'>
		/// Sender.
		/// </param>
		/// <param name='e'>
		/// E.
		/// </param>
		/// <exception cref='System.NotImplementedException'>
		/// Is thrown when a requested operation is not implemented for a given 
		/// type.
		/// </exception>
		protected void EditAlbumDirectoryPathButton (object sender, 
                                                            System.EventArgs e)
		{
			throw new System.NotImplementedException ();
		} //End Event
       
		/// <summary>
		/// Event -- protected void EditSongFilePathButton
		/// 
		/// Edits the song file path.
		/// </summary>
		/// <param name='sender'>
		/// Sender.
		/// </param>
		/// <param name='e'>
		/// E.
		/// </param>
		/// <exception cref='System.NotImplementedException'>
		/// Is thrown when a requested operation is not implemented for a given 
		/// type.
		/// </exception>
		protected void EditSongFilePathButton (object sender, 
                                                            System.EventArgs e)
		{
			throw new System.NotImplementedException ();
		} //End Event

		/// <summary>
		/// Event -- protected void CancelPathOperationButton
		/// 
		/// Cancels current operation to change the paths for artist, album or
		/// song.
		/// </summary>
		/// <returns>
		/// <c>true</c> if this instance cancel path operation; 
		/// otherwise, <c>false</c>.
		/// </returns>
		/// <param name='sender'>
		/// Sender.
		/// </param>
		/// <param name='e'>
		/// E.
		/// </param>
		/// <exception cref='System.NotImplementedException'>
		/// Is thrown when a requested operation is not implemented for a given 
		/// type.
		/// </exception>
		protected void CancelPathOperationButton (object sender, 
                                                            System.EventArgs e)
		{
			throw new System.NotImplementedException ();
		} //End Event
  
		/// <summary>
		/// Event -- protected void UpdatePathChangesButton
		/// 
		/// Updates the artist, album or and song changes to music directory.
		/// </summary>
		/// <param name='sender'>
		/// Sender.
		/// </param>
		/// <param name='e'>
		/// E.
		/// </param>
		/// <exception cref='System.NotImplementedException'>
		/// Is thrown when a requested operation is not implemented for a given 
		/// type.
		/// </exception>
		protected void UpdatePathChangesButton (object sender, 
                                                            System.EventArgs e)
		{
			throw new System.NotImplementedException ();
		} //End Event

		protected void LoadAllSongTagsButton (object sender, System.EventArgs e)
		{
			tagRecState.LoadedTagsState = true; 
			if (SongPathsCollection.ItemsCount () > 0) {
				btnErrorTags.Sensitive = true;
				btnValidTags.Sensitive = true;
			}
			LoadSongTags ();			
			
		} //End Event
        
      
		/// <summary>
		/// Event -- protected void QuitSongTagWindowButton
		/// 
		/// Quits the song tag window.
		/// </summary>
		/// <param name='sender'>
		/// Sender.
		/// </param>
		/// <param name='e'>
		/// E.
		/// </param>
		protected void QuitSongTagWindowButton (object sender, 
                                                            System.EventArgs e)
		{
			if (sngPath != null)
				sngPath.Abort ();
         
			this.Destroy ();
		} //End Event		
		
#endregion Button Events
        
#region Update Tag
        
        
		/// <summary>
		/// Updates the tag data.
		/// </summary>
		/// <returns>
		/// The tag data.
		/// </returns>
		private bool UpdateTagData ()
		{
			bool retVal = false;
               
			try {
                
				methodName = "private bool UpdateTagData";
                
				errMsg = "Encountered error while updating tag data.";
                
				SongTagRecord sngTagRecord = new SongTagRecord ();
				Mp3TagWriter mp3Write = new Mp3TagWriter ();   
                   
                   
				retVal = ValidateDataInTextBoxes ();
				if (!retVal) {
					return retVal;
				}                   
                    
				sngTagRecord.ArtistName = txtArtist.Text;           
				sngTagRecord.AlbumName = txtAlbum.Text;
				sngTagRecord.SongTitle = txtSong.Text;
				sngTagRecord.SongPath = txtSongPath.Text;
				sngTagRecord.GenreType = txtGenre.Text;
				sngTagRecord.YearCreated = txtYear.Text;
				sngTagRecord.ThisTrackNumber = txtTrackNum.Text;
				sngTagRecord.TotalTrackCount = txtTrackCount.Text;
				sngTagRecord.ThisDiscNumber = txtDiscNum.Text;
				sngTagRecord.TotalDiscCount = txtDiscCount.Text;
                   
				retVal = mp3Write.SaveSongTagData (sngTagRecord);
				if (!retVal) {
					return retVal;
				}
                   
				//Updating invalid tag data.
				//Remove tag from collection that user has changed data in.
				//insert new tag with changed data into this record.
				//This is done after user has updated tag changes to the
				//Song tag. this gets the corrected tag into the collection.
				if (!validTags) {
					retVal = InvalidSongTagCollection.RemoveItemAt (
                                                tagRecState.CurrentTagIndex);  
					if (retVal) { 
						retVal = InvalidSongTagCollection.InsertItemAt (
                                    tagRecState.CurrentTagIndex, sngTagRecord);
					} else { //Encountered error.
						return retVal;
					}
				} else { //vaildTags = true. Editing ValidTags data
					retVal = ValidSongTagCollection.RemoveItemAt (
                                                tagRecState.CurrentTagIndex);
                       
					if (retVal) {
						retVal = ValidSongTagCollection.InsertItemAt (
                               tagRecState.CurrentTagIndex, sngTagRecord);
					} else { //Encountered error
						return retVal;
					}
				}           
                   
				//if false was errors return false else return true.
				if (!retVal) {
					return retVal;
				}
                   
				//All ok
				retVal = true;
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
		/// Method -- private bool ValidateDataInTextBoxes
		/// 
		/// Make sure all data in the text boxes is correct
		/// before updating this tag.
		/// </summary>
		/// <returns>
		/// true if all ok else false.
		/// </returns>
		private bool ValidateDataInTextBoxes ()
		{
			bool retVal = false;
			bool val = false;
              
			try {
				val = CheckAllTextBoxesContainData ();
				//if errors found return false
				if (!val) {
					return retVal;
				}
                  
				val = ValidateNumericValuesInTextBoxes ();
				//If not all valid numeric values return false.
				if (!val) {
					return retVal;
				}
                   
				//All Ok
				retVal = true;
				return retVal;
			} catch (InvalidOperationException ex) {
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg,
                                       ex.Message.ToString ());
				return retVal;
          
			}
		} //End Method
           
           
		/// <summary>
		/// Method -- private bool CheckAllTextBoxesContainData
		/// 
		/// Trim all text boxes. Then check for null or empty.
		/// </summary>
		/// <returns>
		/// true if ok false if missing.
		/// </returns>
		private bool CheckAllTextBoxesContainData ()
		{
			string infoMsg = null;
			bool retVal = false;
              
			MyMessages myMsg = null;
               
			try {
				myMsg = new MyMessages ();
                
				methodName = "private bool CheckAllTextBoxesContainData()";
                
				errMsg = "Encountered error while validating data in" +
                                                            " text boxes.";
                
				txtArtist.Text = txtArtist.Text.Trim ();
				txtAlbum.Text = txtAlbum.Text.Trim ();
				txtSong.Text = txtSong.Text.Trim ();
				txtSongPath.Text = txtSongPath.Text.Trim ();
				txtGenre.Text = txtGenre.Text.Trim ();
				txtYear.Text = txtYear.Text.Trim ();
				txtTrackNum.Text = txtTrackNum.Text.Trim ();
				txtTrackCount.Text = txtTrackCount.Text.Trim ();
				txtDiscNum.Text = txtDiscNum.Text.Trim ();
				txtDiscCount.Text = txtDiscCount.Text.Trim ();
                
                      
				if (String.IsNullOrEmpty (txtArtist.Text)) {
					infoMsg = "You must enter the name of the Artist." +
                                      " Then select update button again.";                   
					myMsg.ShowErrMessage (infoMsg);
					return retVal;
				} else if (String.IsNullOrEmpty (txtAlbum.Text)) {
					infoMsg = "You must enter the name of the Album." +
                                       " Then select update button again.";                   
					myMsg.ShowErrMessage (infoMsg);
					return retVal;
				} else if (String.IsNullOrEmpty (txtSong.Text)) {
					infoMsg = "You must enter the name of the Song." +
                                      " Then select update button again.";                   
					myMsg.ShowErrMessage (infoMsg);
					return retVal;
				} else if (String.IsNullOrEmpty (txtSongPath.Text)) {
					infoMsg = "You must enter the name of the Artist." +
                                      " Then select update button again.";                   
					myMsg.ShowErrMessage (infoMsg);
					return retVal;
				} else if (String.IsNullOrEmpty (txtGenre.Text)) {
					infoMsg = "You must enter the Genre type. Then " +
                              "select update button again.";                   
					myMsg.ShowErrMessage (infoMsg);
					return retVal;
				} else if (String.IsNullOrEmpty (txtYear.Text)) {
					infoMsg = "You must enter a year. then select update" +
                                                          " button again.";                   
					myMsg.ShowErrMessage (infoMsg);
					return retVal;
				} else if (String.IsNullOrEmpty (txtTrackNum.Text)) {                    
					infoMsg = "You must enter the track number. Then " +
                              "select update button again.";                   
					myMsg.ShowErrMessage (infoMsg);
					return retVal;
				} else if (String.IsNullOrEmpty (txtTrackCount.Text)) {
					infoMsg = "You must enter the total number of tracks." +
                                      " Then select update button again.";                   
					myMsg.ShowErrMessage (infoMsg);
					return retVal;
				} else if (String.IsNullOrEmpty (txtDiscNum.Text)) {
					infoMsg = "You must enter the disc number 1 or more." +
                                      " Then select update button again.";                   
					myMsg.ShowErrMessage (infoMsg);
					return retVal;
				} else if (String.IsNullOrEmpty (txtDiscCount.Text)) {
					infoMsg = "You must enter the total number of discs." +
                                      " Then select update button again.";                   
					myMsg.ShowErrMessage (infoMsg);
					return retVal;
				}
                      
				//All ok
				retVal = true;
				return retVal;
			} catch (InvalidOperationException ex) {
				myMsg.BuildErrorString (className, methodName, errMsg,
                                       ex.Message.ToString ());
				return retVal;
			}                
		} //End Method
        
       
		/// <summary>
		/// Method -- private bool ValidateNumericValuesInTextBoxes
		/// 
		/// Validates the numeric values in text boxes.
		/// </summary>
		/// <returns>
		/// true if valid numeric value false if not.
		/// </returns>
		private bool ValidateNumericValuesInTextBoxes ()
		{
			bool retVal = false;
			uint val = 0;
			string infoMsg = null;
            
			MyMessages myMsg = null;
            
			try {
				myMsg = new MyMessages ();
                
				methodName = "private bool ValidateNumericValuesInTextBoxes()";
                
				errMsg = "Encountered error while validating user" +
                                              "  entered numeric values.";
				retVal = UInt32.TryParse (txtYear.Text, out val);
				if (!retVal) {
					infoMsg = "You must enter a valid year." +
                                      " Then Select update button agian.";
					myMsg.ShowErrMessage (infoMsg);
					return retVal;            
				}   
             
				retVal = UInt32.TryParse (txtTrackNum.Text, out val);
				if (!retVal) {
					infoMsg = "You must enter a valid track number." +
                                      " Then Select update button agian.";
					myMsg.ShowErrMessage (infoMsg);
					return retVal;  
				}
             
                   
				retVal = UInt32.TryParse (txtTrackCount.Text, out val);
				if (!retVal) {
					infoMsg = "You must enter a valid total " +
                     "  number of tracks. Then Select update button agian.";
					myMsg.ShowErrMessage (infoMsg);
					return retVal;
				}
          
				retVal = UInt32.TryParse (txtDiscNum.Text, out val);
				if (!retVal) {
					infoMsg = "You must enter a valid Disc number such as: 1" +
                        "Then Select update button agian.";
					myMsg.ShowErrMessage (infoMsg);
					return retVal;
				}
                   
				retVal = UInt32.TryParse (txtDiscCount.Text, out val);
				if (!retVal) {
					infoMsg = "You must enter a valid total number of Disc. " +
                        "Then Select update button agian.";
					myMsg.ShowErrMessage (infoMsg);
					return retVal;
				}
                   
				//All ok
				retVal = true;
				return retVal;
			} catch (InvalidOperationException ex) {
				myMsg.BuildErrorString (className, methodName, errMsg,
                                       ex.Message.ToString ());
				return retVal;
			}   
            
		} //End Method 
        
#endregion  Update Tag
        
       
        
		
		/// <summary>
		/// Method -- private void SetToolTips
		/// 
		/// Sets the tool tips.
		/// </summary>/
		private void SetToolTips ()
		{
			btnEditTag.TooltipText = "Edit displayed tag.";
			btnFirst.TooltipText = "Move to first tag record.";
			btnPrevious.TooltipText = "Move to previous tag record.";
			btnNext.TooltipText = "Move to next tag record.";
			btnLast.TooltipText = "Move to last tag record.";
			btnLoadTags.TooltipText = "Load all song tags.";
			btnErrorTags.TooltipText = "Load tags with missing or corrupt " +
                                                                     "data.";
			btnValidTags.TooltipText = "Load tags with not missing or corrupt" +
                                                                      " data.";
			
			
		} //End Method
		
        
		/// <summary>
		/// Method -- private void LoadSongTags
		/// 
		/// Loads the song tags. Both valid and error tags.
		/// </summary>
		/// 
		private void LoadSongTags ()
		{			
			try {
				
				//pass ValidateSongTags object. for use with delegate event.
				valSngTags.GetObjecSongTagWindow = this;
				//sngPath = new Thread (valSngTags.GetPathsFromSongPathList);
				//sngPath.Start ();   
				//Thread.Sleep (10);
				valSngTags.GetPathsFromSongPathList ();
				
			} catch (ThreadStartException ex) {
				errMsg = "Encountered error while starting thread.";
				MusicManager.MyMessages myMsg = new MusicManager.MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg,
                                                        ex.Message.ToString ());
			} catch (ThreadInterruptedException ex) {
				errMsg = "Encountered error while sngPath thread active.";
				MusicManager.MyMessages myMsg = new MusicManager.MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg,
                                                        ex.Message.ToString ());  
			} catch (ThreadAbortException ex) {
				errMsg = "sngPath thread terminated unexpectedly"; 
				MusicManager.MyMessages myMsg = new MusicManager.MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg,
                                                        ex.Message.ToString ());    
			}               
						
		} //End Method
		
	
		
		

		
#region Display record in record fields.
		
		/// <summary>
		/// Method private void DisplayInValidRecord
		/// 
		/// Display InValid tag records one at a time.
		/// </summary>
		private void DisplayInValidRecord ()
		{	
				
			try {
				methodName = "private void DisplayInvalidRecord()";
                
				errMsg = "Encountered error while displaying" +
                                                    " Invalid tag record.";
				sngRec = new SongTagRecord ();
             
				sngRec = InvalidSongTagCollection.GetItemAt (
                                            tagRecState.CurrentTagIndex);         
          
                   
				if (String.IsNullOrEmpty (sngRec.SongTitle)) {
					txtSong.Text = "No Tag data found.";
				} else {
					txtSong.Text = sngRec.SongTitle;
				}
             
				if (String.IsNullOrEmpty (sngRec.ArtistName)) {
					txtArtist.Text = "No Tag data found.";
				} else {
					txtArtist.Text = sngRec.ArtistName;
				}
             
				if (String.IsNullOrEmpty (sngRec.AlbumName)) {
					txtAlbum.Text = "No Tag data found.";
				} else {
					txtAlbum.Text = sngRec.AlbumName;   
				}
             
				if (String.IsNullOrEmpty (sngRec.GenreType)) {
					txtGenre.Text = "No Tag data found.";
				} else {
					txtGenre.Text = sngRec.GenreType;   
				}
             
				if (String.IsNullOrEmpty (sngRec.ThisTrackNumber)) {
					txtTrackNum.Text = "No Tag data found.";
				} else {
					txtTrackNum.Text = sngRec.ThisTrackNumber;
				}
             
				if (String.IsNullOrEmpty (sngRec.TotalTrackCount)) {
					txtTrackCount.Text = "No Tag data found.";
				} else {
					txtTrackCount.Text = sngRec.TotalTrackCount;    
				}
             
				if (String.IsNullOrEmpty (sngRec.AlbumArt)) {
					txtAlbumArt.Text = "No Tag data found";
				} else {
					txtAlbumArt.Text = sngRec.AlbumArt;
				}
             
				if (String.IsNullOrEmpty (sngRec.YearCreated)) {
					txtYear.Text = "No Tag data found.";
				} else {
					txtYear.Text = sngRec.YearCreated;
				}
             
				if (String.IsNullOrEmpty (sngRec.ThisDiscNumber)) {
					txtDiscNum.Text = "No Tag data found.";
				} else {
					txtDiscNum.Text = sngRec.ThisDiscNumber;
				}
                 
				if (String.IsNullOrEmpty (sngRec.TotalDiscCount)) {
					txtDiscCount.Text = "No Tag data found.";
				} else {
					txtDiscCount.Text = sngRec.TotalDiscCount;      
				}
				if (String.IsNullOrEmpty (sngRec.SongPath)) {
					txtSongPath.Text = "No Song path found.";
				} else {
					txtSongPath.Text = sngRec.SongPath;
				}
                   
				if (!String.IsNullOrEmpty (sngRec.SongPath)) {
					string parentDir = Directory.GetParent (
                                                sngRec.SongPath).FullName;
					txtAlbumPath.Text = parentDir;
                       
					parentDir = Directory.GetParent (parentDir).FullName;
                       
					txtArtistPath.Text = parentDir;
				} else {
					txtAlbumPath.Text = "Song Path InValid.";
                       
					txtArtistPath.Text = "Song Path Invalid.";
				}
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
		/// Method -- private void DisplayValidRecord
		/// 
		/// Display tag records with no errors one at a time.
		/// </summary>
		private void DisplayValidRecord ()
		{
		
				
			try {
                
				methodName = "private void DisplayValidRecord()";
                
				errMsg = "Encountered error while Displaying valid tag record.";
                
				sngRec = new SongTagRecord ();
             
				sngRec = ValidSongTagCollection.GetItemAt (
                                            tagRecState.CurrentTagIndex);
             
          
                   
				if (string.IsNullOrEmpty (sngRec.SongTitle)) {
					txtSong.Text = "No Tag data found";
				} else {
					txtSong.Text = sngRec.SongTitle;
				}
             
				if (String.IsNullOrEmpty (sngRec.ArtistName)) {
					txtArtist.Text = "No Tag data found.";
				} else {
					txtArtist.Text = sngRec.ArtistName;
				}
             
				if (String.IsNullOrEmpty (sngRec.AlbumName)) {
					txtAlbum.Text = "No Tag data found.";
				} else {
					txtAlbum.Text = sngRec.AlbumName;   
				}
             
				if (String.IsNullOrEmpty (sngRec.GenreType)) {
					txtGenre.Text = "No Tag data found.";
				} else {
					txtGenre.Text = sngRec.GenreType;   
				}
             
				if (String.IsNullOrEmpty (sngRec.ThisTrackNumber)) {
					txtTrackNum.Text = "No Tag data found.";
				} else {
					txtTrackNum.Text = sngRec.ThisTrackNumber;
				}
             
				if (String.IsNullOrEmpty (sngRec.TotalTrackCount)) {
					txtTrackCount.Text = "No Tag data found.";
				} else {
					txtTrackCount.Text = sngRec.TotalTrackCount;    
				}
             
				if (String.IsNullOrEmpty (sngRec.AlbumArt)) {
					txtAlbumArt.Text = "No Tag data found";
				} else {
					txtAlbumArt.Text = sngRec.AlbumArt;
				}
             
				if (String.IsNullOrEmpty (sngRec.YearCreated)) {
					txtYear.Text = "No Tag data found.";
				} else {
					txtYear.Text = sngRec.YearCreated;
				}
             
				if (String.IsNullOrEmpty (sngRec.ThisDiscNumber)) {
					txtDiscNum.Text = "No Tag data found.";
				} else {
					txtDiscNum.Text = sngRec.ThisDiscNumber;
				}
                 
				if (String.IsNullOrEmpty (sngRec.TotalDiscCount)) {
					txtDiscCount.Text = "No Tag data found.";
				} else {
					txtDiscCount.Text = sngRec.TotalDiscCount;      
				} 
                   
				if (String.IsNullOrEmpty (sngRec.SongPath)) {
					txtSongPath.Text = "No Song path found.";
				} else {
					txtSongPath.Text = sngRec.SongPath;
				}
                   
				if (!String.IsNullOrEmpty (sngRec.SongPath)) {
					string parentDir = Directory.GetParent (
                                                sngRec.SongPath).FullName;
					txtAlbumPath.Text = parentDir;
                       
					parentDir = Directory.GetParent (parentDir).FullName;
                       
					txtArtistPath.Text = parentDir;
				} else {
					txtAlbumPath.Text = "Song Path InValid.";
                       
					txtArtistPath.Text = "Song Path Invalid.";
				}
			} catch (InvalidOperationException ex) {
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg,
                                        ex.Message.ToString ());
			} catch (NullReferenceException ex) {
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg,
                                        ex.Message.ToString ());  
			}
            
           
		}//End Method
			
#endregion Display record in record fields.		
       
		
		/// <summary>
		/// Method private bool GetSongTitleFromPathString
		/// 
		/// Gets the song title from path string. To be displayed in the
		/// song path text box.
		/// </summary>
		/// <returns>
		/// The song title from path string.
		/// </returns>
		/// <param name='sngFilePath'>
		/// If set to <c>true</c> string sng path.
		/// </param>
		/// <param name='sngName'>
		/// If set to <c>true</c> string sng name.
		/// </param>
		private bool GetSongTitleFromPathString (string sngFilePath, 
                                                    ref string sngName)
		{
			bool retVal = false;
			
			try {
				if (!File.Exists (sngFilePath)) {
					return retVal;
				}
          
				sngName = System.IO.Path.GetFileName (sngFilePath); 
          
				//All ok
				retVal = true;
				return retVal;
			} catch (IOException ex) {
				MyMessages myMsg = new MyMessages ();
				myMsg.BuildErrorString (className, methodName, errMsg,
                                       ex.Message.ToString ());
				return retVal;
			} 
		} //End Method 
        
        
        
#region Text Box Controls State
        
		/// <summary>
		/// Method -- private void SetTagRecordTextBoxesState
		/// 
		/// Sets the state of the tag record text boxes.
		/// </summary>
		/// <param name='valState'>
		/// Value state true boxes enabled; else false not enabled.
		/// </param>
		private void SetTagRecordTextBoxesState (bool valState)
		{
			txtArtist.IsEditable = valState;
			txtAlbum.IsEditable = valState;
			txtSong.IsEditable = valState;
			txtGenre.IsEditable = valState;
			txtTrackNum.IsEditable = valState;
			txtTrackCount.IsEditable = valState;
			txtAlbumArt.IsEditable = valState;
			txtYear.IsEditable = valState;
			txtDiscNum.IsEditable = valState;
			txtDiscCount.IsEditable = valState;
               
		} //End Method

           
		/// <summary>
		/// Method -- private void SetFilePathTextBoxesState
		/// 
		/// Sets the state of the file path text boxes.
		/// </summary>
		/// <param name='valState'>
		/// Value state true boxes enabled; else false not enabled.
		/// </param>
		private void SetFilePathTextBoxesState (bool valState)
		{
			txtArtistPath.IsEditable = valState;
			txtAlbumPath.IsEditable = valState;
			txtSongPath.IsEditable = valState;
               
		} //End Method
        
#endregion Text Box Controls State
        
		/// <summary>
		/// Method -- public void SetTagButtonsStartState
		/// 
		/// Sets the state of the tag buttons start.
		/// </summary>
		/// <param name='valState'>
		/// Value state.
		/// </param>
		private void SetTagButtonsState (bool valState)
		{   
		        
			btnEditTag.Sensitive = valState;
			btnEditCancel.Sensitive = valState;
			btnEditUpdate.Sensitive = valState;
			btnEditOpen.Sensitive = valState;   
   
			
		} //End Method 
        
#region Set Move Buttons State
        
		private void SetMoveButtonsState ()
		{
			if (tagRecState.EditingTagRecordState) {
				btnFirst.Sensitive = false;
				btnNext.Sensitive = false;
				btnPrevious.Sensitive = false;
				btnLast.Sensitive = false;
			} else if (tagRecState.TagEditUpdateState) {
				//Add count of records may be true.
				btnFirst.Sensitive = false;
				btnNext.Sensitive = false;
				btnPrevious.Sensitive = false;
				btnLast.Sensitive = false;
			} else if (tagRecState.CancelTagEditState) {
				//True or false based on count of items loaded
				SetMoveButtonStateByRecordCount ();   
			} else if (tagRecState.LoadedTagsState) {
				SetMoveButtonStateByRecordCount ();
			}    
               
		} //End Method 
           
		private void SetMoveButtonStateByRecordCount ()
		{
			int recPos = tagRecState.CurrentTagIndex;
			int recTotal = tagRecState.TotalTagRecordCount;
               
			if (recTotal > 0) {
				if (recPos > 0) {
					btnFirst.Sensitive = true;      
				} else {
					btnFirst.Sensitive = false;
				}               
				if (recTotal > 1) {
					if ((recPos > 0)) {
						btnPrevious.Sensitive = true;   
					} else {
						btnPrevious.Sensitive = false;
					}                   
					if ((recPos + 1) < recTotal) {
						btnNext.Sensitive = true;
						btnLast.Sensitive = true;
					} else {
						btnNext.Sensitive = false;
						btnLast.Sensitive = false;
					}                    
				} //End If 
			} //End if 
		} //End Method
        
#endregion Set Move Buttons State
        
        
#region Tag Edit Button State
        
		private void SetTagEditButtonState ()
		{
			if (tagRecState.TotalTagRecordCount < 1) {
				btnEditTag.Sensitive = false;
				btnEditCancel.Sensitive = false;
				btnEditUpdate.Sensitive = false;
				btnEditOpen.Sensitive = false;
			
			}
			if (tagRecState.TotalTagRecordCount > 0) {
				btnEditTag.Sensitive = true;
				btnEditCancel.Sensitive = false;
				btnEditUpdate.Sensitive = false;
				btnEditOpen.Sensitive = true;
				
				if (tagRecState.TagWindowInitialize) {
					btnEditTag.Sensitive = true;
					btnEditOpen.Sensitive = true;
					btnEditCancel.Sensitive = false;
					btnEditUpdate.Sensitive = false;
					
					//only used once when tags load first time.
					tagRecState.TagWindowInitialize = false;
				}
				if (tagRecState.EditingTagRecordState) {
					btnEditTag.Sensitive = false;
					btnEditCancel.Sensitive = true;
					btnEditUpdate.Sensitive = true;
					btnEditOpen.Sensitive = true;
					
				}
				if (tagRecState.CancelTagEditState) {
					btnEditTag.Sensitive = true;
					btnEditCancel.Sensitive = false;
					btnEditUpdate.Sensitive = false;
					btnEditOpen.Sensitive = true;  
					
				}
				if (tagRecState.TagEditUpdateState) {
					btnEditTag.Sensitive = true;
					btnEditCancel.Sensitive = false;
					btnEditUpdate.Sensitive = false;
					btnEditOpen.Sensitive = true;
					
				} 
			} //End if
            
		} //End Method     
        
#endregion Tag Edit Button State
            
		
        
       
	} //End clsSongTagWindow
	
} //End namespace MusicManager

