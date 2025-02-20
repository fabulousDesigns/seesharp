/*
 * Generics
 * 
 * Create a generic class called Pair<T> that can hold two items of the same type.
 * 
 * The class should:
 * 
 * Have two private fields to store the items
 * Have a constructor that takes two items of type T
 * Have methods called GetFirst() and GetSecond() that return the respective items
 * Have methods called SetFirst(T item) and SetSecond(T item) to update the items
 * Have a method called Swap() that switches the positions of the two items
 * Try implementing this in Rider. This task will help you understand:
 * How to declare generic classes
 * How to work with generic type parameters
 * How to create methods that work with generic types
 *
 * 
 */

public class Pair<T>
{
    private T itemOne;
    private T itemTwo;
    public Pair(T item1, T item2)
    {
        itemOne = item1;
        itemTwo = item2;
    }
    public T GetFirst()
    {
        return itemOne;
    }
    public T GetSecond()
    {
        return itemTwo;
    }

    public T SetFirst(T updateFirst)
    {
        itemOne = updateFirst;
        return itemOne;
    }
    
    public T SetSecond(T updateSecond)
    {
        itemTwo = updateSecond;
        return itemTwo;
    }

    public void Swap()
    {
        (itemOne, itemTwo) = (itemTwo, itemOne);
    }
    
}