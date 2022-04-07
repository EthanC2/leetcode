use std::collections::HashMap;

struct TrieNode {
    is_end: bool,
    children: HashMap<char,TrieNode>,    
}

struct WordDictionary {
    root: TrieNode,
}


impl TrieNode {
    fn new() -> TrieNode {
        TrieNode {is_end: false, children: HashMap::new()}
    }
}

/** 
 * `&self` means the method takes an immutable reference.
 * If you need a mutable reference, change it to `&mut self` instead.
 */
impl WordDictionary {

    fn new() -> Self {
        WordDictionary{root: TrieNode::new()}
    }
    
    fn add_word(&mut self, word: String) {
        let mut current_node = &mut self.root;
        for c in word.chars() {
            current_node = current_node.children.entry(c).or_insert(TrieNode::new());
        }
        
        current_node.is_end = true;
    }
    
    fn search(&self, word: String) -> bool {
        self.internal_search(word.as_str(), &self.root)
    }
    
    fn internal_search(&self, substr: &str, start: &TrieNode) -> bool {
        let mut current_node = start;
        for (i,c) in substr.chars().enumerate() {                      
            match c {
                '.' => return current_node.children.values().any(|child| self.internal_search(&substr[(i+1)..], &child)),
                 _ => match current_node.children.get(&c) {
                    Some(child) => current_node = child,
                    None => return false,
                },
            }
        }
        
        current_node.is_end
    }
}
