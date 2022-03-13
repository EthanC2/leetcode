/*
  TC: O(n)
  SC: O(n)
  Runtime: 0s
*/

impl Solution {
    pub fn is_valid(s: String) -> bool {
        let mut stk = Vec::new();
        
        for paren in s.chars() {
            if paren == '(' || paren == '{' || paren == '[' {
                stk.push(paren);
            } else if match stk.last() {
                Some('(') => paren == ')',
                Some('{') => paren == '}',
                Some('[') => paren == ']',
                _ => false,
            } {
                stk.pop();
            }
            else {
                return false;
            }
        }
        
        stk.is_empty()
    }
}
