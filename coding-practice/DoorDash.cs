/*
 A chef receives all his orders for the day as a list of order ids.
 Given this list, the chef chooses to prepare them in the following way.
 He creates a new list by repeatedly removing the smallest eligible order
 from the list and appending it to the new list.

 An order is considered eligible if its id is greater than its immediate left and right neighbors in the list.
 Return the order in which the chef creates the new list

 Input = [3, 5, 1, 4, 2]

 [3, 5, 1, 4, 2]  ->.  eligible [5, 4] -> 4

 [3, 5, 1, 2].    ->  eligible [5, 2] -> 2

 [3, 5, 1].     ->.   eligible [5] -> 5
 .
 .
 .
 [3, 1] 

 [1]           -> eligible  [1]

 Output = [4, 2, 5, 3, 1]

 n * n/2 + (n - 1) * (n-1)/2 

 Operations on the array:
 - select the peak elements
 - put it in eligible 
 - select the least from eligible
 - remove from original structure
 - repeat

 */
public class DoorDash
{
    public void RemoveItem(int item, ref List<int> arr)
    {
        int index = 0;
        for (var i = 0; i < arr.Count; i++)
        {
            if (item == arr[i])
            {
                index = i;
            }
        }
        Console.WriteLine("index: " + index);
        arr.RemoveAt(index);
    }

    public List<int> GetEligibleOrders(int[] orders)
    {
        var ordersList = new List<int>();

        for (var i = 0; i < orders.Length; i++)
        {
            ordersList.Add(orders[i]);
        }
        if (orders.Length < 2)
        {
            return ordersList;
        }

        var resultList = new List<int>();

        while (ordersList.Count > 0)
        {
            var eligibleItem = Int32.MaxValue;
            for (int i = 0; i < ordersList.Count; i++)
            {
                if ((i == 0 || ordersList[i - 1] < ordersList[i]) && (i == ordersList.Count - 1 || ordersList[i + 1] < ordersList[i]))
                {
                    if (ordersList[i] < eligibleItem)
                    {
                        eligibleItem = ordersList[i];
                    }
                }
            }
            resultList.Add(eligibleItem);
            RemoveItem(eligibleItem, ref ordersList);
        }

        return resultList;
    }
    public void PrintList(List<int> p)
    {
        foreach (var a in p)
        {
            Console.Write(a);
        }
    }
}

