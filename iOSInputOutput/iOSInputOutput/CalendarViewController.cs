using Foundation;
using System;
using UIKit;
using TimesSquare.iOS;

namespace iOSInputOutput
{
    public partial class CalendarViewController : UIViewController
    {
        public DateTime netDate;

        public CalendarViewController (IntPtr handle) : base (handle)
        {
        }

		public override void ViewDidLoad()
		{
            var calendarView = new TSQCalendarView(View.Bounds)
            {
                Calendar = new Foundation.NSCalendar(Foundation.NSCalendarType.Gregorian),
                FirstDate = Foundation.NSDate.Now,
                LastDate = NSDate.FromTimeIntervalSinceNow(60 * 60 * 24 * 265 * 5),
				BackgroundColor = UIColor.LightTextColor,
				PagingEnabled = true
			};

			// Handler
			calendarView.DidSelectDate += (sender, e) =>
			{
				netDate = (DateTime)e.Date;
                UserData.BirthDate = netDate;
			};

			// Add component to view
			View.Add(calendarView);



		}
    }
}