// Given an integer x, return true if x is a palindrome, and false otherwise.

// Example 1:

// Input: x = 121
// Output: true
// Explanation: 121 reads as 121 from left to right and from right to left.


// For this solution, i am using Palindrome
public class Solution {
    public bool IsPalindrome(int x) {
        if (x < 0) {
            return false;
        }

        int original = x;
        long reversed = 0;

        while (x > 0) {
            int digit = x % 10;
            reversed = reversed * 10 + digit;
            x = x / 10;
        }

        return original == reversed;
    }
}