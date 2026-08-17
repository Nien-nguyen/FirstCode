using System;
using System.Collections.Generic;
using System.Text;

namespace FirstCode.ss2
{
    internal class lesson1
    {
        //CHARACTER ESCAPE SEQUENCES
        /*  \n - New line
            \t - Tab
            \" - Double quote
            \\ - Backslash 
        VERBATIM STRING LITERAL
        A VSL will keep all whitespace and characters without the need to escape the backslash. To create a VS, use the @ directive before the literla string

         */
        private static void Sub(string[] args)
        {
            Console.WriteLine("Hello\nWorld!");
            Console.WriteLine("Hello\tWorld!");
            Console.WriteLine("Hello \"World!\"");
            Console.WriteLine("c:\\source\\repos");

            Console.WriteLine(@"    c:\source\repos    
        (this is where your code goes)");
        }
    }
}
