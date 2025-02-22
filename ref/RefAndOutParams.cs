// Question 2: Implement a Statistics Calculator
// Create a method that takes an array of numbers and returns multiple statistics about it. Use both ref and out parameters to:
//
// Update the array by normalizing all numbers (divide each by the maximum)
// Return the minimum, maximum, and average values from the original array
//
// Here's your starting point:
//
// public void CalculateStats<T>(ref T[] array, out T min, out T max, out double average) 
//     where T : struct, IComparable<T>, IConvertible
// {
//     // Your implementation here
// }



class RefAndOutParams
{
    public void CalculateStats<T>(ref T[] array, out T min, out T max, out double average) 
        where T : struct, IComparable<T>, IConvertible
    {
        min = array[0];
        max = array[0];
        foreach (T item in array)
        {
            if (item.CompareTo(min) < 0) min = item;
            if (item.CompareTo(max) > 0) max = item;
        }

        double sum = 0;
        foreach (T item in array)
        {
            sum += item.ToDouble(null);
        }
        average = sum / array.Length;
        
        double maxValue = max.ToDouble(null);
        for (int i = 0; i < array.Length; i++)
        {
            double normalizedValue = array[i].ToDouble(null) / maxValue;
           
            array[i] = (T)Convert.ChangeType(normalizedValue, typeof(T));
        }

    }
}