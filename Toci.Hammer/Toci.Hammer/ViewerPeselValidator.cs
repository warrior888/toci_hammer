using System.Collections.Generic;

namespace Toci.Hammer
{
    public class ViewerPeselValidator
    {
        protected Dictionary<int, int> DaysMonthsMap = new Dictionary<int, int>()
        {
            { 1, 31 },
            { 2, 28 },
            { 3, 31 },
            { 4, 30 },
            { 5, 31 },
            { 6, 30 },
            { 7, 31 },
            { 8, 30 },
            { 9, 31 },
            { 10, 30 },
            { 11, 31 },
            { 12, 30 },
        };

        public bool IsPeselValid(string peselCandidate)
        {
            return ValidateDateInPesel(peselCandidate) && ValidatePeselRest(peselCandidate);
        }

        protected bool ValidateDateInPesel(string peselCandidate)
        {
            bool result = false;

            string day = peselCandidate.Substring(4, 2);
            string month = peselCandidate.Substring(2, 2);
            string year = peselCandidate.Substring(0, 2);

            int dayNum = 0;
            int monthNum = 0;
            int yearNum = 0;
            int.TryParse(day, out dayNum);
            int.TryParse(month, out monthNum);
            int.TryParse(year, out yearNum);

            if (monthNum > 0 && monthNum < 13)
            {
                yearNum += 1900;
                int yearDivisionRest = yearNum % 4;

                if (yearDivisionRest == 0)
                {

                    // jest dobrze

                    // leap year
                    if (monthNum == 2 && dayNum > 29)
                    {
                        return false;
                    }
                }

                if (DaysMonthsMap[monthNum] >= dayNum && DaysMonthsMap[monthNum] > 0)
                {
                    result = true;
                }
            }

            // tu i nie komuniklaty

            return result;
        }

        protected bool ValidatePeselRest(string peselCandidate)
        {
            bool result = false;

            // ?

            return result;
        }
    }
}