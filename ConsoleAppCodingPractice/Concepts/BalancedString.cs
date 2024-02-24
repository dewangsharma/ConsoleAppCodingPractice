using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleAppCodingPractice.Concepts
{
    /// <summary>
    /// Check that string is balanced
    /// [{()}] = balanced string
    /// [{)} = not balanced string
    /// </summary>
    class BalancedString : IStartMain
    {
        public void BootStrap( )
        {
            string inputString = "[{({()})}]";
            Console.WriteLine($"Input string data: {inputString}");

            var result = IsBalanced ( inputString.ToCharArray() );

            Console.WriteLine($"Balanced: {result}");

            inputString = "[{({(()))}]";
            Console.WriteLine( $"Input string data: {inputString}" );

            result = IsBalanced( inputString.ToCharArray() );

            Console.WriteLine( $"Balanced: {result}" );
        }

        private bool IsBalanced( char[] data)
        {
            Stack<char> stack = new Stack<char>();
            foreach(var c in data)
            {
                if(IsOpening(c))
                {
                    stack.Push( c );
                }
                else {
                    if( !( stack.Count > 0 && IsMatchingClose( stack.Pop(), c ) ) )
                        return false;                    
                }
            }
            return stack.Count == 0;
        }

        private bool IsOpening(char c)
        {
            return c == '[' || c == '{' || c == '(' ;
        }

        private bool IsMatchingClose( char openBracket, char closeBracket )
        {
            switch(openBracket)
            {
                case '[':
                    return ']' == closeBracket;

                case '{':
                    return '}' == closeBracket;

                case '(':
                    return ')' == closeBracket;

                default:
                    return false;
            }
        }
    }
}
