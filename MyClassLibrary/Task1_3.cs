namespace MyClassLibrary
{
   
        public static class Task1_3
        {
            public static double PerSquare(int x)
            { return x * x; }
            public static double PerRectangle(int x, int y)
            { return x * y; }
            public static double PerTriangle(int x, int y, int z)
            {
                double s = (x + y + z) / 2;
                return Math.Sqrt(s * (s - x) * (s - y) * (s - z));
            }
            public static bool IsPalindrome(string text)
            {
                string cleanText = text.Replace(" ", "").ToLower();
                int length = cleanText.Length;
                for (int i = 0; i < length / 2; i++)
                {
                    if (cleanText[i] != cleanText[length - 1 - i])
                    {
                        return false;
                    }
                }
                return true;
            }

            public static int CountSentences(string text)
            {
                int count = 0;
                foreach (char character in text)
                {
                    if (character == '.')
                    {
                        count++;
                    }
                }
                return count;
            }
            public static string ReverseString(string text)
            {
                char[] charArray = text.ToCharArray();
                Array.Reverse(charArray);
                return new string(charArray);
            }
        }
    }
