public class LRUCache 
{
    //KeyNode
    public class KeyNode
    {
      public int Key {get; set;}
      public LinkedListNode<int> Node {get; set;}
      
      public KeyNode(int key, int value)
      {
        Key = key;
        Node = new LinkedListNode<int>(value);
      }
    }
  
    //Variables
    LinkedList<KeyNode> _deque;
    Dictionary<int, KeyNode> _cache;
    int _capacity;
  
    public LRUCache(int capacity) 
    {
      if (capacity < 0)
        _capacity = 0;
      else
        _capacity = capacity;
    
      _deque = new();
      _cache = new();
    }
    
    public int Get(int key) 
    {
      if (!_cache.ContainsKey(key))
        return -1;
      
      var keynode = _cache[key];
      _deque.Remove(keynode);
      _deque.AddFirst(keynode);
      return keynode.Node.Value;
    }
    
    public void Put(int key, int value) 
    {
      if (_cache.ContainsKey(key))
      {
        var keynode = _cache[key];
        _deque.Remove(keynode);
        _deque.AddFirst(keynode);
        keynode.Node.Value = value;
        return;
      }
      
      if (_deque.Count+1 > _capacity)
      {
        _cache.Remove(_deque.Last.Value.Key);
        _deque.RemoveLast();
      }
      
      //Add elems to the ds
      var newnode = new KeyNode(key,value);
      _cache.Add(key, newnode);
      _deque.AddFirst(newnode);
    }
}

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */
