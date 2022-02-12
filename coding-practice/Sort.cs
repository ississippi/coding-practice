using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_practice
{
    internal class Sort
    {

        //const numbers = [99, 44, 6, 2, 1, 5, 63, 87, 283, 4, 0];

        public void bubbleSort(char[] array)
        {
            var len = array.Length;
            for (var i = 0; i < len; i++)
            {
                for (var j = 0; j < len; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        //Swap the numbers
                        var temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        //bubbleSort(numbers);
        //console.log(numbers);

        //function selectionSort(array)
        //{
        //    const length = array.length;
        //    for (let i = 0; i < length; i++)
        //    {
        //        // set current index as minimum
        //        let min = i;
        //        let temp = array[i];
        //        for (let j = i + 1; j < length; j++)
        //        {
        //            if (array[j] < array[min])
        //            {
        //                //update minimum if current is lower that what we had previously
        //                min = j;
        //            }
        //        }
        //        array[i] = array[min];
        //        array[min] = temp;
        //    }
        //    return array;
        //}


    }
}
