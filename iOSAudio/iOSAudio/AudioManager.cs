using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AVFoundation;
using Foundation;
using UIKit;

namespace iOSAudio
{
    class AudioManager
    {
        #region Private Variables
        private AVAudioPlayer audio;
        private string backgroundSong = "";
        #endregion

        #region Computed Properties

        public bool MusicOn { get; set; } = true;
        public float MusicVolume { get; set; } = 0.5f;

        #endregion

        #region Constructors
        public AudioManager()
        {
            // Initialize
            ActivateAudioSession();
        }
        #endregion

        #region Public Methods
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
            audio = new AVAudioPlayer(songURL, "mp3", out err);
            audio.Volume = MusicVolume;
            audio.FinishedPlaying += delegate {
                audio = null;
            };
            audio.NumberOfLoops = 0;
            audio.Play();

        }
        #endregion
    }
}