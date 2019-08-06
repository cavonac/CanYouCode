using System;
using System.Text;

namespace CanYouCode
{
    /// <summary>
    /// </summary>
    public static class RunLengthEncoding
    {
        public static string RLEncode(this string plaintext)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < plaintext.Length; i++)
            {
                int count = 1; // current count of input char
                while (i < plaintext.Length - 1 && plaintext[i] == plaintext[i+1])
                {
                    // increase count 
                    count++;

                    // move to next character
                    i++;
                }

                sb.Append(plaintext[i]).Append(count);
            }

            return sb.ToString();
        }

        public static string RLDecode(this string codedString)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < codedString.Length; i++)
            {
                char cs = codedString[i];

                int count = GetCountFromSubstring(codedString, ref i, codedString.Length);

                for (int c = 0; c < count; c++)
                {
                    sb.Append(cs);                    
                }
            }

            return sb.ToString();
        }

        private static int GetCountFromSubstring(string codedString, ref int startIndex, int endIndex)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = startIndex + 1; i < endIndex; i++)
            {
                if (char.IsDigit(codedString, i))
                {
                    sb.Append(codedString[i]);
                    startIndex++;
                }
                else
                    break;
            }

            return Int32.Parse(sb.ToString());
        }
    }
}
