// Question 3: Circular Buffer Implementation
//     Create a generic circular buffer (ring buffer) that uses ref returns to allow modifying elements in place. This is a more advanced question that tests both understanding of ref and data structures!

public class CircularBuffer<T>
{
    private T[] buffer;
    private int head = 0;  
    private int tail = 0; 
    private int count = 0; 
    
    public CircularBuffer(int size)
    {
        buffer = new T[size];
    }

    // Adds a new element to the buffer
    public void Add(T item)
    {
        buffer[head] = item;
        head = (head + 1) % buffer.Length; 
        
        if (count < buffer.Length)
        {
            count++;
        }
        else
        {
            tail = (tail + 1) % buffer.Length;
        }
    }

    public ref T GetAt(int index)
    {
        if (index < 0 || index >= count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }
        
        int actualPos = (tail + index) % buffer.Length;
        return ref buffer[actualPos];
    }

    public bool TryModifyOldest(ref T newValue)
    {
        if (count == 0)
        {
            return false;
        }

        T temp = buffer[tail];
        buffer[tail] = newValue;
        newValue = temp;
        
        return true;
    }

    public void PrintBuffer()
    {
        Console.WriteLine($"Buffer state (Count: {count}):");
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"Index {i}: {GetAt(i)}");
        }
    }
}