using System;
using System.Collections.Generic;

public class Solution {
    public int LastStoneWeight(int[] stones) {
        List<int> stoneList = new List<int>(stones);
        for (int i = 0; i < stoneList.Count; i++) {
            stoneList[i] = -stoneList[i];
        }
        
        PriorityQueue<int> minHeap = new PriorityQueue<int>(stoneList);
        while (minHeap.Count > 1) {
            int stone1 = -minHeap.Dequeue();
            int stone2 = -minHeap.Dequeue();
            if (stone1 != stone2) {
                minHeap.Enqueue(-(stone1 - stone2));
            }
        }
        
        return (minHeap.Count > 0) ? -minHeap.Peek() : 0;
    }
}

public class PriorityQueue<T> where T : IComparable<T> {
    private List<T> heap;

    public int Count { get { return heap.Count; } }

    public PriorityQueue() {
        heap = new List<T>();
    }

    public PriorityQueue(IEnumerable<T> collection) {
        heap = new List<T>(collection);
        BuildHeap();
    }

    public void Enqueue(T item) {
        heap.Add(item);
        int currentIndex = heap.Count - 1;
        while (currentIndex > 0) {
            int parentIndex = (currentIndex - 1) / 2;
            if (heap[currentIndex].CompareTo(heap[parentIndex]) >= 0) {
                break;
            }
            Swap(currentIndex, parentIndex);
            currentIndex = parentIndex;
        }
    }

    public T Dequeue() {
        if (heap.Count == 0) {
            throw new InvalidOperationException("PriorityQueue is empty.");
        }
        T item = heap[0];
        heap[0] = heap[heap.Count - 1];
        heap.RemoveAt(heap.Count - 1);
        Heapify(0);
        return item;
    }

    public T Peek() {
        if (heap.Count == 0) {
            throw new InvalidOperationException("PriorityQueue is empty.");
        }
        return heap[0];
    }

    private void BuildHeap() {
        for (int i = heap.Count / 2 - 1; i >= 0; i--) {
            Heapify(i);
        }
    }

    private void Heapify(int index) {
        int leftChild = 2 * index + 1;
        int rightChild = 2 * index + 2;
        int smallest = index;
        
        if (leftChild < heap.Count && heap[leftChild].CompareTo(heap[smallest]) < 0) {
            smallest = leftChild;
        }
        if (rightChild < heap.Count && heap[rightChild].CompareTo(heap[smallest]) < 0) {
            smallest = rightChild;
        }
        if (smallest != index) {
            Swap(index, smallest);
            Heapify(smallest);
        }
    }

    private void Swap(int i, int j) {
        T temp = heap[i];
        heap[i] = heap[j];
        heap[j] = temp;
    }
}
