/*
  TC: O(n)
  SC: O(1)
*/
impl Solution {
    pub fn remove_element(nums: &mut Vec<i32>, val: i32) -> i32 {
        let mut idx = 0;
        
        for i in 0..nums.len() {
            if nums[i] != val {
                nums[idx] = nums[i];
                idx += 1;
            }
        }
        
        idx as i32
    }
}



/*
  Fast alternative, 0 ms
*/
impl Solution {
    pub fn remove_element(nums: &mut Vec<i32>, val: i32) -> i32 {
        nums.retain(|i| *i != val);
        nums.len() as i32
    }
}
