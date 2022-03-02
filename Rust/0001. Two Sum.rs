use std::collections::HashMap;

impl Solution {
    
    pub fn two_sum(nums: Vec<i32>, target: i32) -> Vec<i32> {
        let mut map = HashMap::new();
        
        for (i, num) in nums.iter().enumerate()
        {
            let diff = target - num;
            if let Some(&idx) = map.get(&diff) {
                return vec![idx, i as i32];
            }
            
            map.insert(num, i as i32);
        }
            
        panic!("No solution!");
    }
}
