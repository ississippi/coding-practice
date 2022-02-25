//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace coding_practice
//{
//    internal class Class1
//    {
//    }
//}

//Given an array of integers arr.

//We want to select three indices i, j and k where (0 <= i < j <= k < arr.length).

//Let 's define a and b as follows:

//a = arr[i] ^ arr[i + 1] ^ ... ^arr[j - 1]
//b = arr[j] ^ arr[j + 1] ^ ... ^arr[k]
//Note that ^ denotes the bitwise-xor operation.

//Return the number of triplets (i, j and k) Where a == b.

//(0,2,2)
//a = 2 ^ 3     010 ^ 011
//b = 1         001

//(0, 1, 2)
//a = 2
//b = 3 ^ 1

//(2, 3, 4)
//a = 1
//b = 6 ^ 7

//(2, 4, 4)
//a = 1 ^ 6
//b = 7

//Input: arr = [2, 3, 1, 6, 7]
//Output: 4
//Explanation: The triplets are(0, 1, 2), (0, 2, 2), (2, 3, 4) and(2, 4, 4)
//                               i j k.   i j k.   i j k.      i j k

//       i         j k 
//_ _ _ [_ _ _ _][_ _] _ _

//0 1 2  3 4 5 6   7 8  9 10

//3, 7, 8

//[[2,3],[1,6],7]
//0 2 3

//[2,[3, 1],[6], 7]



//Given a list of strings words and a string pattern, return a list of words[i] that match pattern.
//You may return the answer in any order.

//A word matches the pattern if there exists a permutation of letters p so that after replacing
//every letter x in the pattern with p(x), we get the desired word.

//Recall that a permutation of letters is a bijection from letters to letters: every
//letter maps to another letter, and no two letters map to the same letter.

 

//Example 1:

//Input: words = ["abc", "deq", "mee", "aqq", "dkd", "ccc"], pattern = "abb"
//Output: ["mee","aqq"]
//[m -> a, e -> b] => mee->abb
//[a->a, q->b] => aqq->abb

//tak->так
//t->т a->а k->к

//Explanation: "mee" matches the pattern because there is a permutation {a -> m, b -> e, ...}. 
//"ccc" does not match the pattern because {a -> c, b -> c, ...} is not a permutation, since a and b map to the same letter.
//Example 2:

//Input: words = ["a", "b", "c"], pattern = "a"
//Output: ["a","b","c"]


