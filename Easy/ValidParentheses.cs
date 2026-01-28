// Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

// An input string is valid if:

// Open brackets must be closed by the same type of brackets.
// Open brackets must be closed in the correct order.
// Every close bracket has a corresponding open bracket of the same type.
 

// Example 1:

// Input: s = '()'

// Output: true

// Example 2:

// Input: s = '()[]{}'

// Output: true

// Example 3:

// Input: s = '(]'

// Output: false

// Example 4:

// Input: s = '([])'

// Output: true

// Example 5:

// Input: s = '([)]'

// Output: false

// Constraints:

// 1 <= s.length <= 104
// s consists of parentheses only '()[]{}'.


// Stack
public class Solution {
    public bool IsValid(string s) {
        if (s.Length % 2 != 0)
        {
            return false;
        }

        Stack<char> chars = new Stack<char>();

        foreach (char c in s)
        {
            // '': these quotes are for Character || "": these quotes are for String
            if (c == '(' || c == '[' || c == '{')
            {
                chars.Push(c);
            }
            else
            {
                if (chars.Count == 0)
                {
                    return false;
                }

                char top = chars.Pop();

                if (c == ')' && top != '(') return false;
                if (c == ']' && top != '[') return false;
                if (c == '}' && top != '{') return false;
            }
        }

        return chars.Count = 0;
    }
}