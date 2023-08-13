using System;
using System.Collections.Generic;

public class MyHashSet
{
    private HashSet<int> keys;

    public MyHashSet()
    {
        keys = new HashSet<int>();
    }

    public void Add(int key)
    {
        keys.Add(key);
    }

    public void Remove(int key)
    {
        keys.Remove(key);
    }

    public bool Contains(int key)
    {
        return keys.Contains(key);
    }
}