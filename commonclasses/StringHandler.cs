using System;

namespace commonclasses
{
    public static class StringHandler
    {
        /// Insert spaces before each capital letter in a string
        public static string InsertSpaces(this string source)
        {
            string result = string.Empty;
            

            if (!String.IsNullOrWhiteSpace(source))
            {
                for (var i = 0; i < source.Length; i++)
                {
                    if(i == 0)
                    {
                        result+=source[i];
                        continue;
                    }
                    else if (char.IsUpper(source[i]))
                    {
                        result = result.Trim();
                        result+= " ";
                    }
                    result += source[i];
                }
            }
            return result;
        }
    }
}
