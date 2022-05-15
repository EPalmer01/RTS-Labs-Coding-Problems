namespace RTS_Labs_Coding_Problems
{
    public static class Logic
    {
        public static AboveBelow aboveBelow(List<int> numbers, int comparison)
        {
            var returnAboveBelow = new AboveBelow();

            foreach(var number in numbers)
            {
                if (number >= comparison)
                {
                    returnAboveBelow.Above.Add(number);
                }
                else
                {
                    returnAboveBelow.Below.Add(number);
                }
            }

            return returnAboveBelow;
        }

        public static string stringRotation(string baseString, int rotation)
        {
            return baseString[^rotation..] + baseString[..^rotation];
        }
    }
}
