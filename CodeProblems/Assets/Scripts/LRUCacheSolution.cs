using System.Collections.Generic;

public class DoubleLinkedNode
{
    public int key;
    public int value;

    public DoubleLinkedNode prev;
    public DoubleLinkedNode next;

    public DoubleLinkedNode(int key, int value)
    {
        this.key = key;
        this.value = value;
    }
}

public class LRUCache
{
    private int maxSize = -1;
    private int size = 0;

    private DoubleLinkedNode head = null;
    private DoubleLinkedNode tail = null;

    private Dictionary<int, DoubleLinkedNode> cache;

    public LRUCache(int capacity)
    {
        this.maxSize = capacity;
        this.cache = new Dictionary<int, DoubleLinkedNode>();
        head = new DoubleLinkedNode(0, 0);
        tail = new DoubleLinkedNode(0, 0);
        head.next = tail;
        tail.prev = head;
    }

    public int Get(int key)
    {
        if (cache.ContainsKey(key))
        {
            var node = cache[key];
            MoveToFirst(node);

            return node.value;
        }
        else
        {
            return -1;
        }
    }

    public void Put(int key, int value)
    {
        if (cache.ContainsKey(key))
        {
            var node = cache[key];
            node.value = value;
            MoveToFirst(node);
        }
        else
        {
            var newNode = new DoubleLinkedNode(key, value);
            AddFirstNode(newNode);
            cache.Add(key, newNode);
            size++;

            if (size > maxSize)
            {
                var removedNode = RemoveLast();
                if (removedNode != null)
                {
                    cache.Remove(removedNode.key);
                    size--;
                }
            }
        }
    }


    private void AddFirstNode(DoubleLinkedNode node)
    {
        node.next = head.next;
        node.next.prev = node;
        head.next = node;
        node.prev = head;
    }

    private void MoveToFirst(DoubleLinkedNode node)
    {
        if (head.next == node)
        {
            return;
        }

        RemoveNode(node);

        node.next = head.next;
        node.next.prev = node;
        head.next = node;
        node.prev = head;
    }

    private void RemoveNode(DoubleLinkedNode node)
    {
        node.prev.next = node.next;
        node.next.prev = node.prev;
    }

    private DoubleLinkedNode RemoveLast()
    {
        var oldLast = tail.prev;
        oldLast.prev.next = tail;
        tail.prev = oldLast.prev;
        return oldLast;
    }
}
