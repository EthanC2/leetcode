impl Solution {
    pub fn fixed_point(arr: Vec<i32>) -> i32 {
        for (i,num) in arr.iter().enumerate() {
            if *num == i as i32 {
                return *num;
            }
        }
        
        -1
    }
}
