using System;
namespace UtcDateTimeToLocalString
{
    using System.Globalization;

    public class MainPageViewModel
    {
        public MainPageViewModel()
        {
            CurrentDateTime = DateTime.Parse("07/19/2022", CultureInfo.InvariantCulture);
        }

        public DateTime CurrentDateTime { get; set; }

    }
}

