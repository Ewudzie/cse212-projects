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

        /* Create a plan: 
            1. Declare a variable as an array
            2. Use a for loop to iterate through the five multiple numbers of 7
            3. print or return output
                
        */
        double[] multiples = new double[length]; // decalring an arry to access the lenght of number to generate multiples against
        for (int i = 0; i < length; i++) // a for loop that iterate through the multiplication of the number against the lenght of the number to multiple to.
        {
            multiples[i] = number * (i + 1);
        }


        return multiples; // returns the result of the multiplication 
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


        /* Create a plan:
            1. create a list of a variable containing a data of numbers
            2.create a viarable that accepts an amount
            3. use range method to rearrange lsit from right
        */


        /* var listdata = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 }; //declare list with data
         listdata = listdata.GetRange(5, data.Count - 3);
         Console.WriteLine(listdata);*/

        int count = data.Count;

        List<int> endOfArray = data.GetRange(count - amount, amount); // This take the last amount of elements
        data.RemoveRange(count - amount, amount); // remove them from the end
        data.InsertRange(0, endOfArray);// insert them at the biginning
        
    }
}
