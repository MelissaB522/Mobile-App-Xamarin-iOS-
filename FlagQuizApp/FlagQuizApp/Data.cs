using System;
using Foundation;
using UIKit;
namespace FlagQuizApp
{
    public class Data
    {
        protected UIImage[] flagImages;
        protected string[] flagNames;

        public Data(UIImage[] images, string[] countries)
        {
            flagImages = images;
            flagNames = countries;
        }
    }
}
