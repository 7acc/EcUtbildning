using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise13
{
    class DatetimeCalculator
    {
        public DateTime born;

        public int GetAge()
        {
            TimeSpan days = DateTime.Now - born;
            var years = days.Days / 365;
            
            return years;
        }

        public string GetHundredthBday()
        {
            var hundredthBday = born.AddYears(100);

            return hundredthBday.DayOfWeek.ToString();
        }       
        public double GetDaysToNextBirthday()
        {
            var days = born.DayOfYear - DateTime.Now.DayOfYear +1;
            if (days < 0)
                days += 365;
                
            return days;
        }

        public string GetDateTimeInfo(DatetimeCalculator dude)
        {
            return $"{dude.born.ToShortDateString()} {dude.GetAge()} {dude.GetDaysToNextBirthday()} {dude.GetHundredthBday()}";
        }
        public double NextBirthday()
        {
            var days = born.AddYears(GetAge() + 1) - DateTime.Now;
            var day = days.Days;
            return day;
        }
    }
}
