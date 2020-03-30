namespace Toci.Hammer.Palindrom
{
    //class hetman : Goniec, wieza

    public class DawidPalindrom :   IPalindromSolution
    {
        public bool IsPalindrom(string candidate)
        {
            // radar cyc kajak abba
            //candidate
            //for(int; < ;++)
            for (int i = 0, j = candidate.Length - 1; i < j; i++, j--)
            {
                if (candidate[i] != candidate[j])
                {
                    return false;
                }
            }
           
            return true;
        }
    }
}