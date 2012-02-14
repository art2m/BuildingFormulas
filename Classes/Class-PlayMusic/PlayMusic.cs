//  
//  clsPlayMusic.cs
//  
//  Author:
//       art2m <art2m@live.com>
// 
//  Copyright (c) 2011 art2m
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
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;

/**************************************************************************************************************************************************
  * 
  * Need to fix headers and error handaling as well as method header 
  * 
  * ***********************************************************************************************************************************************/

namespace MusicManager
{
	public class PlayMusic
	{
		MyMessages clsMsg = new MyMessages ();
		
		//Constructor
		public PlayMusic ()
		{
		}
		
		//add string to be passed in with the song to be played.
		public bool Play_Music ()
		{
			bool retVal = false;
		
			try {
				string path = " -C /home/art2m/Music/Various-Rock/20_Greatest_Hits_1957/02-_Sixteen_Candles.mp3";
				
				
				ProcessStartInfo psi = new ProcessStartInfo ();
				psi.FileName = "mpg123"; //strPlay;
				psi.UseShellExecute = false;			
				psi.Arguments = path;
				Process p = Process.Start (psi);
				p.WaitForExit ();		
					
				// if return code 0 then ok else error encountred
				Console.WriteLine ("The return value is:  " + p.ExitCode.ToString ());
				retVal = true;
				return retVal;
			} catch (Exception ex) {
				StringBuilder sbErr = new StringBuilder ();
				sbErr.AppendLine ("Quitting song play back. Encountered Error.");
				sbErr.AppendLine (ex.Message.ToString ());
				clsMsg.ShowErrMessage (sbErr.ToString ());
				
				return retVal;
			}
					
		} //End Method public bool play_music() method
		
		
	} // End class clsPlayMusic
	
} // End namespace MusicManager

