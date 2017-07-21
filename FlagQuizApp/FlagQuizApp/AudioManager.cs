using System;
using AVFoundation;
using Foundation;

namespace FlagQuizApp
{
    public class AudioManager
    {
        private AVAudioPlayer audio;
        //private string backgroundSong = "";


        public bool MusicOn { get; set; } = true;
		public float MusicVolume { get; set; } = 0.5f;


        public AudioManager()
		{
			// Initialize
			ActivateAudioSession();
		}

        public void ActivateAudioSession()
		{
			// Initialize Audio
			var session = AVAudioSession.SharedInstance();
			session.SetCategory(AVAudioSessionCategory.Ambient);
			session.SetActive(true);
		}

		public void DeactivateAudioSession()
		{
			var session = AVAudioSession.SharedInstance();
			session.SetActive(false);
		}

		public void ReactivateAudioSession()
		{
			var session = AVAudioSession.SharedInstance();
			session.SetActive(true);
		}

		public void PlaySound(string filename)
		{
			NSUrl songURL;

			// Music enabled?
			if (!MusicOn) return;

			// Any existing sound effect?
			if (audio != null)
			{
				//Stop and dispose of any sound effect
				audio.Stop();
				audio.Dispose();
			}

			// Initialize background music
			songURL = new NSUrl("Sounds/" + filename);
			NSError err;
			audio = new AVAudioPlayer(songURL, "wav", out err);
			audio.Volume = MusicVolume;
			audio.FinishedPlaying += delegate
			{
				audio = null;
			};
			audio.NumberOfLoops = 0;
			audio.Play();

		}
    }
}
