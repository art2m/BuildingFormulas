//  
//  TagRecordState.cs
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
	public  class TagRecordState
	{
	    
#region Tag Data State
        
		private  bool tagEditing = false;
		/// <summary>
		/// Property -- public  bool EditingTagRecordState
		/// 
		/// Gets or sets a value indicating whether this 
		/// <see cref="MusicManager.TagRecordState"/> editing tag record state.
		/// </summary>
		/// <value>
		/// <c>true</c> if editing tag record state; otherwise, <c>false</c>.
		/// </value>
		public  bool EditingTagRecordState {
			get {
				return tagEditing;
			}
			set {
				tagEditing = value;
			}
		} //End Property
        
           
		private  bool tagCancel = false;
		/// <summary>
		/// Property -- public  bool CAncelTagEditState
		/// 
		/// Gets or sets a value indicating whether this instance cancel 
		/// tag edit state.
		/// </summary>
		/// <value>
		/// <c>true</c> if this instance cancel tag edit state; 
		/// otherwise, <c>false</c>.
		/// </value>
		public  bool CancelTagEditState {
			get {
				return tagCancel;                
			}
			set {
				tagCancel = value;
			}
		} //End Property
           
           
		private  bool tagEditUpdate = false;
		/// <summary>
		/// Property -- public  bool TagEditUpdateState
		/// 
		/// Gets or sets a value indicating whether this 
		/// <see cref="MusicManager.TagRecordState"/> tag edit update state.
		/// </summary>
		/// <value>
		/// <c>true</c> if tag edit update state; otherwise, <c>false</c>.
		/// </value>
		public  bool TagEditUpdateState {
			get {
				return tagEditUpdate;
			}
			set {
				tagEditUpdate = value;
			}
		} //End Property
           
           
		private  bool tagOpenFile = false;
		/// <summary>
		/// Property -- public  bool TagOpenFileState
		/// 
		/// Gets or sets a value indicating whether this 
		/// <see cref="MusicManager.TagRecordState"/> tag open file state.
		/// </summary>
		/// <value>
		/// <c>true</c> if tag open file state; otherwise, <c>false</c>.
		/// </value>
		public  bool TagOpenFileState {
			get {
				return tagOpenFile;
			}
			set {
				tagOpenFile = value;
			}
		} //End Method
        
		private  bool tagsLoadedInvalid = false;
		/// <summary>
		/// Property -- public  bool TagsInvalidLoadedForShowing
		/// 
		/// Gets or sets a value indicating whether this 
		/// <see cref="MusicManager.TagRecordState"/> tags invalid loaded
		/// for showing.
		/// </summary>
		/// <value>
		/// <c>true</c> if tags invalid loaded for showing; 
		/// otherwise, <c>false</c>.
		/// </value>
		public  bool TagsInvalidLoadedForShowing {
			get {
				return tagsLoadedInvalid;
			}
			set {
				tagsLoadedInvalid = value;
			}
		} //End Property
        
        
		private  bool tagsLoadedValid = false;
		/// <summary>
		/// Property -- public  bool TagsValidLoadedForShowing
		/// 
		/// Gets or sets a value indicating whether this 
		/// <see cref="MusicManager.TagRecordState"/> tags valid loaded 
		/// for showing.
		/// </summary>
		/// <value>
		/// <c>true</c> if tags valid loaded for showing; 
		/// otherwise, <c>false</c>.
		/// </value>
		public  bool TagsValidLoadedForShowing {
			get {
				return tagsLoadedValid;
			}
			set {
				tagsLoadedValid = value;
			}
		} //End Property
        
#endregion Tag Data State
        
        
#region File Path Data State
        
		private  bool editArtistPath = false;
		/// <summary>
		/// Property -- public  bool EditingArtistPathState
		/// 
		/// Gets or sets a value indicating whether this 
		/// <see cref="MusicManager.TagRecordState"/> editing artist path state.
		/// </summary>
		/// <value>
		/// <c>true</c> if editing artist path state; otherwise, <c>false</c>.
		/// </value>
		public  bool EditingArtistPathState {
			get {
				return editArtistPath;                
			}
			set {
				editArtistPath = value;
			}
		} //End Property
           
           
		private  bool editAlbumPath = false;
		/// <summary>
		/// Propety -- public  bool EditingAlbumPathState
		/// 
		/// Gets or sets a value indicating whether this 
		/// <see cref="MusicManager.TagRecordState"/> editing album path state.
		/// </summary>
		/// <value>
		/// <c>true</c> if editing album path state; otherwise, <c>false</c>.
		/// </value>
		public  bool EditingAlbumPathState {
			get {
				return editAlbumPath;
			}
			set {
				editAlbumPath = value;
			}
		}   //End Property
           
           
		private  bool editSongPath = false;
		/// <summary>
		/// Property -- pbulic  bool EditingSongPathState
		/// 
		/// Gets or sets a value indicating whether this 
		/// <see cref="MusicManager.TagRecordState"/> editing song path state.
		/// </summary>
		/// <value>
		/// <c>true</c> if editing song path state; otherwise, <c>false</c>.
		/// </value>
		public  bool EditingSongPathState {
			get {
				return editSongPath;
			}
			set {
				editSongPath = value;
			}
		} //End Property
           
           
		private  bool editCancelPath = false;
		/// <summary>
		/// Property -- public  bool EditCancelPathOperationState
		/// Gets or sets a value indicating whether this 
		/// <see cref="MusicManager.TagRecordState"/> edit cancel path
		/// operation stated.
		/// </summary>
		/// <value>
		/// <c>true</c> if edit cancel path operation stated; 
		/// otherwise, <c>false</c>.
		/// </value>
		public  bool EditCancelPathOperationState {
			get {
				return editCancelPath;
			}
			set {
				editCancelPath = value;
			}
		} //End Property
        
           
		private  bool editFileUpdate = false;
		/// <summary>
		/// Property -- public  bool EditingPathFileUpdate
		/// 
		/// Gets or sets a value indicating whether this 
		/// <see cref="MusicManager.TagRecordState"/> editing path file
		/// update state.
		/// </summary>
		/// <value>
		/// <c>true</c> if editing path file update state; 
		/// otherwise, <c>false</c>.
		/// </value>
		public  bool EditingPathFileUpdateState {
			get {
				return editFileUpdate;
			}
			set {
				editFileUpdate = value;
			}
		} //End Property
        
#endregion File Path Data State
        
        
        
#region Tags Show Read Write
        
		private  bool tagsLoad = false;
		/// <summary>
		/// Property -- public  bool LoadedTagState
		/// 
		/// Gets or sets a value indicating whether this 
		/// <see cref="MusicManager.TagRecordState"/> loaded tags state.
		/// </summary>
		/// <value>
		/// <c>true</c> if loaded tags state; otherwise, <c>false</c>.
		/// </value>
		public  bool LoadedTagsState {
			get {
				return tagsLoad;
			}
			set {
				tagsLoad = value;
			}
		} //End Property
           
           
		private  bool errTagsShow = false;
		/// <summary>
		/// Property -- public  bool ShowingErrorTagasState
		/// 
		/// Gets or sets a value indicating whether this 
		/// <see cref="MusicManager.TagRecordState"/> showing error tags state.
		/// </summary>
		/// <value>
		/// <c>true</c> if showing error tags state; otherwise, <c>false</c>.
		/// </value>
		public  bool ShowingErrorTagsState {
			get {
				return errTagsShow;
			}
			set {
				errTagsShow = value;
			}
		} //End Property
           
           
		private  bool validTagsShow = false;
		/// <summary>
		/// Property -- public  bool ShowingValidTagState
		/// 
		/// Gets or sets a value indicating whether this 
		/// <see cref="MusicManager.TagRecordState"/> showing valid tags state.
		/// </summary>
		/// <value>
		/// <c>true</c> if showing valid tags state; otherwise, <c>false</c>.
		/// </value>
		public  bool ShowingValidTagsState {
			get {
				return validTagsShow;
			}
			set {
				validTagsShow = value;
			}
		} //End Property
           
           
		private  bool tagsWrite = false;
		/// <summary>
		/// Property -- public  bool WriteTagsToFileState
		/// 
		/// Gets or sets a value indicating whether this 
		/// <see cref="MusicManager.TagRecordState"/> write tags to file state.
		/// </summary>
		/// <value>
		/// <c>true</c> if write tags to file state; otherwise, <c>false</c>.
		/// </value>
		public  bool WriteTagsToFileState {
			get {
				return tagsWrite;
			}
			set {
				tagsWrite = value;
			}
		} //End Property
           
           
		private  bool tagsRead = false;
		/// <summary>
		/// Property -- public  bool ReadTagsFromFileState
		/// 
		/// Gets or sets a value indicating whether this 
		/// <see cref="MusicManager.TagRecordState"/> read tags from file state.
		/// </summary>
		/// <value>
		/// <c>true</c> if read tags from file state; otherwise, <c>false</c>.
		/// </value>
		public  bool ReadTagsFromFileState {
			get {
				return tagsRead;                
			}
			set {
				tagsRead = value;
			}
		} //End Property
        
#endregion Tags Show Read Write      
        
        
		private  int recCnt = 0;
		/// <summary>
		/// Property -- public  int TotalTagRecordCount
		/// 
		/// Gets or sets the total tag record count. Can be 
		/// either Invalid tags count or Valid tags Count.
		/// </summary>
		/// <value>
		/// The total tag record count.
		/// </value>
		public  int TotalTagRecordCount {
			get {
				return recCnt;
			}
			set {
				recCnt = value;
			}
		} //End Method 
         
        
		private  int tagIndex = 0;
		/// <summary>
		/// Property -- public  int CurrentTagIndex
		/// 
		/// Gets or sets the index of the current tag.
		/// </summary>
		/// <value>
		/// The index of the current tag.
		/// </value>
		public  int CurrentTagIndex {
			get {
				return tagIndex;
			}
			set {
				tagIndex = value;
			}
		} //End Property
        
		private  int sngCnt = 0;
		/// <summary>
		/// Property -- public  int TotalNumberSongsFound
		/// 
		/// Gets or sets the total number songs found in music folder.
		/// </summary>
		/// <value>
		/// The total number songs found.
		/// </value>
		public  int TotalNumberSongsFound {
			get {
				return sngCnt;
			}
			set {
				sngCnt = value;
			}
		} //End Property
        
		private  bool tagWinInit = false;
		/// <summary>
		/// Property -- public  bool TagWindowInitialize
		/// 
		/// Gets or sets a value indicating whether this 
		/// <see cref="MusicManager.TagRecordState"/> tag window initialize.
		/// </summary>
		/// <value>
		/// <c>true</c> if tag window initialize; otherwise, <c>false</c>.
		/// </value>
		public  bool TagWindowInitialize {
			get {
				return tagWinInit;
			}
			set {
				tagWinInit = value;
			}
		} //End Property
        
       
        
        
	} //End class TagRecordState
    
    
} //End namespace MusicManager

