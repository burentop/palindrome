using System;

namespace PalChecker {
    class Palindrome
    {
        private string Contents;
        private string[] ContentsArray;
        private string[] ReverseArray;

        public Palindrome(string contents)
        {
            Contents = contents;
            ContentsArray = contents.ToCharArray();
            ReverseArray = contents.ToCharArray().Reverse();
        }

        public string GetContents()
        {
            return Contents;
        }

        public bool IsPalindrome()
        {
            return ContentsArray == ReverseArray;
        }
    }
}