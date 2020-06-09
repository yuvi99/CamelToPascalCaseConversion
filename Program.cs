using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamelString
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            
            Console.WriteLine(StringExtension.ToPascalCase("YuvrajRepe") );

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }

    public static class StringExtension
    {

 //       int t = 2;
        public static string CamelCase(this string str)
        {
            if (!string.IsNullOrEmpty(str) && str.Length > 1)
            {
                char[] chars = str.ToCharArray();

                for (int i = 0;  str.Length >i; i++)
                {

                }
                
                    return Char.ToLowerInvariant(str[0]) + str.Substring(1);
            }
            return str;
        }
        // Convert the string to camel case.
        public static string ToCamelCase(this string the_string)
        {
            // If there are 0 or 1 characters, just return the string.
            if (the_string == null || the_string.Length < 2)
                return the_string;

            // Split the string into words.
            string[] words = the_string.Split(
                new char[] { },
                StringSplitOptions.RemoveEmptyEntries);

            // Combine the words.
            string result = words[0].ToLower();
            for (int i = 1; i < words.Length; i++)
            {
                result +=
                    words[i].Substring(0, 1).ToUpper() +
                    words[i].Substring(1);
            }

            return result;
        }

        // Convert the string to Pascal case.
        public static string ToPascalCase(this string the_string)
        {
            // If there are 0 or 1 characters, just return the string.
            if (the_string == null) return the_string;
          
            // Split the string into words.
                       var strBuild = new StringBuilder(); 
            char[] chars = the_string.ToCharArray();
            string result = "";
            for (int i = 0; i <the_string.Length ;  i++)
            {

               // strBuild.Append(chars);
                if (char.IsUpper(chars[i]) && i >0)
                {
                    
                    strBuild.Clear();
                    strBuild.Append("_" + char.ToLower(chars[i]));
                    result += strBuild;
                }
                else
                result += char.ToLower(the_string[i]);
            }
            
            the_string = strBuild.ToString();
            
            return result;
        }
        // Capitalize the first character and add a space before
        // each capitalized letter (except the first character).
        public static string ToProperCase(this string the_string)
        {
            // If there are 0 or 1 characters, just return the string.
            if (the_string == null) return the_string;
            if (the_string.Length < 2) return the_string.ToUpper();

            // Start with the first character.
            string result = the_string.Substring(0, 1).ToUpper();

            // Add the remaining characters.
            for (int i = 1; i < the_string.Length; i++)
            {
                if (char.IsUpper(the_string[i])) result += " ";
                result += the_string[i];
            }

            return result;
        }
    }
}
