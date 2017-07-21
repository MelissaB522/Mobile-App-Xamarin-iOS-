using Foundation;
using System;
using UIKit;

namespace FlagQuizApp
{
    public partial class QuestionViewController : UIViewController
    {
        // Arrays to hold images and country names
        public static UIImage[] images = new UIImage[] { UIImage.FromBundle("us.png"), UIImage.FromBundle("ca.png"), UIImage.FromBundle("ar.png"),
            UIImage.FromBundle("gb.png"), UIImage.FromBundle("no.png"), UIImage.FromBundle("ie.png"), UIImage.FromBundle("tz.png"),
            UIImage.FromBundle("bb.png"), UIImage.FromBundle("kh.png"), UIImage.FromBundle("ma.png") };
        public static string[] countries = new string[] { "USA", "Canada", "Argentina", "Great Britain", "Norway", "Ireland", "Tanzania", 
            "Barbados", "Cambodia", "Morocco"};

        // Array to hold all answers, used to set button text
        string[,] answers = new string[10, 4] {
            {"USA", "Canada", "Australia", "Russia"},
            {"Great Britain", "New Zealand", "Japan", "Canada"},
            {"Brazil", "Vietnam", "Argentina", "Jamaica"},
            {"Australia", "Great Britain", "New Zealand", "Mexico"},
            {"Austria", "Switzerland", "Sweden", "Norway"},
            {"Iceland", "Ireland", "Italy", "Chile"},
            {"South Africa", "Pakistan", "Tanzania", "Hungary"},
            {"Barbados", "Peru", "Fiji", "Portugal"},
            {"South Korea", "Monaco", "Luxembourg", "Cambodia"},
            {"Israel", "Morocco", "Philippines", "Nigeria"}
        };

        // Question counter
        int counter = 0;

        // Correct answer counter
        public static int correct = 0;

        AudioManager audioManager;

        public QuestionViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Create new instance of Data class
            Data newData = new Data(images, countries);

            // Instantiate audioManager object
            audioManager = new AudioManager();
        }

        partial void Btn4_TouchUpInside(UIButton sender)
        {
			CheckAnswer(btn4);

            NewQuestion();
        }

        partial void Btn3_TouchUpInside(UIButton sender)
        {
            CheckAnswer(btn3);

            NewQuestion();
        }

        partial void Btn2_TouchUpInside(UIButton sender)
        {
            CheckAnswer(btn2);

            NewQuestion();
        }

        partial void Btn1_TouchUpInside(UIButton sender)
        {
            CheckAnswer(btn1);

            NewQuestion();
        }

        // Method to check if the button selected is the correct one
        public void CheckAnswer(UIButton button)
        {
			// If button text matches the correct country in countries array
            // play correct sound and increment counter
			if(button.TitleLabel.Text == countries[counter])
            {
                audioManager.PlaySound("yay.wav");
                correct++;
            }
			// If incorrect, play incorrect sound
			else
            {
                audioManager.PlaySound("uhoh.wav");
            }
        }

        // Method to set image and buttons to new question
        public void NewQuestion()
        {
            // Increment question counter
			counter++;

            // After last question, open end game view controller
            if(counter == 10)
            {
                var endGameViewController = (EndGameViewController)this.Storyboard.InstantiateViewController("EndGameViewController");
                this.NavigationController.PushViewController(endGameViewController,true);
            }
            // Set image and buttons for new question
            else 
            {
                // Set image to appropriate file in images array
				imgFlag.Image = images[counter];

                // Set button text to appropriate string in 2d questions array, based on question counter
				btn1.SetTitle(answers[counter, 0], UIControlState.Normal);
				btn2.SetTitle(answers[counter, 1], UIControlState.Normal);
				btn3.SetTitle(answers[counter, 2], UIControlState.Normal);
				btn4.SetTitle(answers[counter, 3], UIControlState.Normal);
            }
        }
    }
}