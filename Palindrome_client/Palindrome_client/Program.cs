using System;
using System.Runtime.InteropServices;

namespace Palindrome_client
{
    class Program
    {
        public const string CppFunctionsDLL = @"..\..\..\Debug\palindrome.dll";

        [DllImport(CppFunctionsDLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern Byte is_palindrome(string input);
        static void Main(string[] args)
        {
            string input;
            Console.Write("Input: ");
            input = Console.ReadLine();
            Byte output = is_palindrome(input);

            Console.WriteLine($"Output is: {output}");
            Console.ReadLine();
        }
    }
}
