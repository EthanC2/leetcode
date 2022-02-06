/*
    This problem is especially interesting. Essentially, you have to create an LRU
    cache that can both get and set values in constant time (O(1)), *and* can also 
    maintain ordering. The intuitive way to solve this is a doubly-linked list since it 
    fits all those requirements, but you run into a problem because removal from a doubly-linked
    lists only have a constant removal time IF you already have the reference to them, so you need
    a way to associate the keys directly with the nodes in the list. From there, you can just
    use a hashmap.
    
    Sorry for how ugly LinkedListNode<ValueTuple<int,int>> is. I originally created a 
    class called "KeyNode" that acted as a thin wrapper, but it was too slow because it
    lacked optimizations that the raw LinkedListNode<T> had. So, I tried to derived from it
    instead to maintain them; unfortunately, the LinkedListNode<T> class is sealed and cannot
    be derived from.
*/
public class LRUCache 
{ 
    /*
        Variables.
        
        ValueTuple Note:
        Item1 = key;
        Item2 = value;
    */
    LinkedList<ValueTuple<int,int>> _deque;
    Dictionary<int, LinkedListNode<ValueTuple<int,int>>> _cache;
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
      
      var node = _cache[key];
      _deque.Remove(node);
      _deque.AddFirst(node);
      return node.Value.Item2;
    }
    
    public void Put(int key, int value) 
    {
      if (_cache.ContainsKey(key))
      {
        var keynode = _cache[key];
        _deque.Remove(keynode);
        _deque.AddFirst(keynode);
        keynode.Value = ValueTuple.Create(keynode.Value.Item1, value);
        return;
      }
      
      if (_deque.Count+1 > _capacity)
      {
        _cache.Remove(_deque.Last.Value.Item1);
        _deque.RemoveLast();
      }
      
      //Add elems to the ds
      var newnode = new LinkedListNode<ValueTuple<int,int>>(ValueTuple.Create(key,value));
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
