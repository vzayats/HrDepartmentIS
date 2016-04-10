using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using Telerik.Windows.Controls.Calendar;

namespace HrDepartment
{
    public class DayButtonTemplateSelector : DataTemplateSelector
    {
        public DataTemplate DefaultTemplate { get; set; }
        public DataTemplate BookedDayTemplate { get; set; }
        public DataTemplate SpecialHolidayTemplate { get; set; }

        public List<DateTime> BookedDays { get; set; }
        public List<DateTime> SpecialHolidays { get; set; }

        public DayButtonTemplateSelector()
        {
            //колекція з святковими та вихідними днями
            this.BookedDays = new List<DateTime>()
            {
               new DateTime(2016, 01, 01),
                new DateTime(2016, 01, 07),
                new DateTime(2016, 01, 01),
                new DateTime(2016, 03, 08),
                new DateTime(2016, 05, 01),
                new DateTime(2016, 05, 02),
                new DateTime(2016, 05, 03),
                new DateTime(2016, 05, 09),
                new DateTime(2016, 06, 19),
                new DateTime(2016, 06, 20),
                new DateTime(2016, 06, 28),
                new DateTime(2016, 08, 24),
                new DateTime(2016, 10, 14)
            };

            //колекція з днями з робочим чaсом, скороченим на 1 годину
            this.SpecialHolidays = new List<DateTime>()
            {
                new DateTime(2016, 01, 06),
                new DateTime(2016, 03, 07),
                new DateTime(2016, 06, 27),
                new DateTime(2016, 08, 23),
                new DateTime(2016, 10, 13)
            };
        }
        //вивести дати у календар
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            var calendarButton = item as CalendarButtonContent;
            var currDate = calendarButton.Date;

            if (calendarButton.ButtonType == CalendarButtonType.Date)
            {
                //вивести у календар святковими та вихідними днями
                if (this.BookedDays.Any(a => a.Date.DayOfYear == currDate.DayOfYear))
                {
                    return this.BookedDayTemplate;
                }

                //вивести у календар дні з робочим чaсом, скороченим на 1 годину
                if (this.SpecialHolidays.Any(a => a.Date.DayOfYear == currDate.DayOfYear))
                {
                    return this.SpecialHolidayTemplate;
                }
            }

            return this.DefaultTemplate;
        }
    }
}
