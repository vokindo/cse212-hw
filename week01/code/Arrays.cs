public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Step 1: Create a new array of size 'count' to hold the multiples
        double[] multiples = new double[length];

        // Step 2: Use a loop to fill the array
        // For each index i, calculate the multiple as start * (i + 1)
        // Store the result in multiples[i]

        for (int i = 0; i < length; i++)
        {
        multiples[i] = number * (i + 1);
        }

        // Step 3: Return the array

        return multiples; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Step 1: Get the last 'amount' elements from the list.
        // These will become the first part of the rotated list.
        List<int> rightPart = data.GetRange(data.Count - amount, amount);

        // Step 2: Get the remaining elements from the start up to data.Count - amount.
        List<int> leftPart = data.GetRange(0, data.Count - amount);

        // Step 3: Clear the original list so we can rebuild it in the rotated order.
        data.Clear();

        // Step 4: Add the right part first, followed by the left part.
        data.AddRange(rightPart);
        data.AddRange(leftPart);

        // TODO Problem 2 End
    }
}
