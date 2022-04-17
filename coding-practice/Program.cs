// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System.Text.Json;

using coding_practice;
using Newtonsoft.Json;

var a = new char[] { 'h', 'e', 'l', 'l', 'o' };
var d = new int[] { 4, 1, 2, 1, 2 };


//var s1 = new ReverseString();
//s1.ReverseString2Pointers(a);
//Console.WriteLine(a);
//s1.ReverseStringRecursive(a);
//Console.WriteLine(a);

//var s2 = new ReverseVowels();
//var b = s2.Reverse(new string("leetcode"));
//Console.WriteLine(b);
//b = s2.Reverse(new string("aA"));
//Console.WriteLine(b);
//b = s2.Reverse(new string(".,"));
//Console.WriteLine(b);
//b = s2.Reverse(new string("a.b,."));
//Console.WriteLine(b);

//var s3 = new FizzBuzz();
//var c = s3.DoFizzBuzz(15);
//Console.WriteLine(c);

// var s4 = new SingleNumber();
////var e = s4.DoSingleNumber(d);
////var e = s4.SingleNumberLeetCodeList(d);
//var e = s4.SingleNumberLeetCodeMath(d);
//Console.WriteLine(e);

// BinarySearchTree
//var tree = new coding_practice_bfs.BFS();
//tree.Insert(9);
//tree.Insert(4);
//tree.Insert(6);
//tree.Insert(20);
//tree.Insert(170);
//tree.Insert(15);
//tree.Insert(1);
//var bfs = tree.BreadthFirstSearch(170);
//Console.WriteLine(JsonConvert.SerializeObject(bfs));
//var nodeList = new List<int>();
//var nodeQueue = new Queue<coding_practice_bfs.Node>();
//nodeQueue.Enqueue(tree._root);
//var bfsR = tree.BreadthFirstSearchR(nodeQueue, nodeList);
//Console.WriteLine(JsonConvert.SerializeObject(bfsR));
// ----------
// DFS 
// ----------
//var tree = new coding_practice_dfs.DFS();
//tree.Insert(9);
//tree.Insert(4);
//tree.Insert(6);
//tree.Insert(20);
//tree.Insert(170);
//tree.Insert(15);
//tree.Insert(1);
//var dfsIn = tree.DFSInOrder();
//Console.WriteLine("InOrder: " + JsonConvert.SerializeObject(dfsIn));
//var dfsPre = tree.DFSPreOrder();
//Console.WriteLine("PreOrder: " + JsonConvert.SerializeObject(dfsPre));
//var dfsPost = tree.DFSPostOrder();
//Console.WriteLine("PostOrder: " + JsonConvert.SerializeObject(dfsPost));

// ===================
// MoveZeroes
// ===================
//var mz = new int[] { 0, 1, 0, 3, 12 };
//var mz = new int[] { 0, 0, 1 };
//var moveZ = new MoveZeroesSolution();
//var mzArr = moveZ.MoveZeroes(mz);
//Console.WriteLine("MoveZeroes: " + JsonConvert.SerializeObject(mzArr));

// ===================
// GetSum
// ===================
//var g = new SolutionGetSum();
//var sum = g.GetSum(15, 15);
//Console.WriteLine(sum);

// ======================
// Palindrome LinkedList
// ======================
//var h = new Palindromes();
//Console.WriteLine(h.IsPalindrome(ll.head));

// ======================
// Excel Columns
// ======================
//var x = new ExcelColumns();
//var sum = x.TitleToNumber("A");
//Console.WriteLine(sum); 
//sum = x.TitleToNumber("AB");
//Console.WriteLine(sum);
//sum = x.TitleToNumber("AAA");
//Console.WriteLine(sum);
//sum = x.TitleToNumber("FXSHRXW"); //2147483647
//Console.WriteLine(sum);
//sum = x.TitleToNumber("F"); //2147483647
//Console.WriteLine(sum);
//sum = x.TitleToNumber("X"); //2147483647
//Console.WriteLine(sum*26);
//sum = x.TitleToNumber("S"); //2147483647
//Console.WriteLine(sum * 26);
//sum = x.TitleToNumber("H"); //2147483647
//Console.WriteLine(sum * 26);
//sum = x.TitleToNumber("R"); //2147483647
//Console.WriteLine(sum * 26);
//sum = x.TitleToNumber("X"); //2147483647
//Console.WriteLine(sum * 26);
//sum = x.TitleToNumber("W"); //2147483647
//Console.WriteLine(sum * 26);

// ======================
// Majority Element
// ======================
//var mec = new MajorityElementClass();
/////int[] meArr2 = new int[] { 1, 2, 3, 2, 4, 1, 3, 5, 6, 7, 7, 5, 7};
/////int[] meArr1 = new int[] { 3, 2, 3 };
/////int[] meArr3 = new int[] {8,8,7,7,7};
//int[] meArr4 = new int[] { 2, 2, 1, 1, 1, 2, 2 };
/////var me = mec.MajorityElement(meArr2);
//var me = mec.MajorityElementLeetCodeAnswer(meArr4);
//Console.WriteLine(me);

// ======================
// Roman Numerals
// ======================
//var rn = new RomanToInteger();
//string[] nums = new string[] { "III", "V", "IV", "IX", "XCIV", "MMMXL", "LCIX" };
//foreach(var s in nums)
//{
//    var val = rn.RomanToInt(s);
//    Console.WriteLine(s + " = " + val);
//}

// ==========================
// Best Time to Buy and Sell
// ==========================
//int[] prices = new int[] { 7, 1, 5, 3, 6, 4 };
//var b = new BestTimeToBuyandSell();
////var sum = b.MaxProfit(prices);
//var sum = b.MaxProfitClean(prices);
//Console.WriteLine(sum);

// ==========================================
// 5993. Keep Multiplying Found Values by Two
// ==========================================
//int[] nums1 = new int[] { 5, 3, 6, 1, 12 };
//int[] nums2 = new int[] { 8, 19, 4, 2, 15, 3 };
//var l5993 = new LeetCodeContest278();
////var sum = l5993.FindFinalValue(nums1, 3);
//var sum = l5993.FindFinalValue(nums2, 2);
//Console.WriteLine(sum);

// =============================================================
// 5981. All Divisions With the Highest Score of a Binary Array
// =============================================================
//int[] barray = new int[] { 0,0,1,0 };
//var l5981 = new LeetCodeContest278();
//var maxScore = l5981.MaxScoreIndices(barray);
//Console.WriteLine(maxScore);

// ===========================================
// Graph: DisjointSet - QuickFind
// ===========================================
//var uf = new UnionFindQuickFind(10);
//// 1-2-5-6-7 3-8-9 4
//uf.union(1, 2);
//uf.union(2, 5);
//uf.union(5, 6);
//uf.union(6, 7);
//uf.union(3, 8);
//uf.union(8, 9);
//Console.WriteLine(uf.connected(1, 5)); // true
//Console.WriteLine(uf.connected(5, 7)); // true
//Console.WriteLine(uf.connected(4, 9)); // false
//// 1-2-5-6-7 3-8-9-4
//uf.union(9, 4);
//Console.WriteLine(uf.connected(4, 9)); // true

// ===========================================
// Graph: DisjointSet - QuickFind
// ===========================================

//var uf = new UnionFindQuickUnion(10);
//// 1-2-5-6-7 3-8-9 4
//uf.union(1, 2);
//uf.union(2, 5);
//uf.union(5, 6);
//uf.union(6, 7);
//uf.union(3, 8);
//uf.union(8, 9);
//Console.WriteLine(uf.connected(1, 5)); // true
//Console.WriteLine(uf.connected(5, 7)); // true
//Console.WriteLine(uf.connected(4, 9)); // false
//// 1-2-5-6-7 3-8-9-4
//uf.union(9, 4);
//Console.WriteLine(uf.connected(4, 9)); // true

// ===================
// Fibonacci
// ===================
//var fib = new Fibonacci();
//var x = fib.FibonacciIterative(8);
//Console.WriteLine(" result: " + x);
//var y = fib.FibonacciRecursive(8);
//Console.WriteLine(" result: " + y);

//List<int> orders = new List<int>();
//orders.Add(3);
//orders.Add(5);
//orders.Add(1);
//orders.Add(4);
//orders.Add(2);
//var dd = new DoorDash();
//var eligible = dd.GetEligibleOrders(orders);
//Console.WriteLine(PrintList(eligible));

// ===================
// Longest Substring
// ===================
// Given a string s, find the length of the longest substring without repeating characters.
//var ss = new LongestSubstring();
//List<string> ts = new List<string>();
//ts.Add("abcabcbb");
//ts.Add("bbbbb");
//ts.Add("pwwkew");
//ts.Add("kkknananajjj");
//ts.Add("sdfghdorkuscbbnnnnnn");
//ts.Add("dorkussdfgh");
//ts.Add("fffffffsdfghdorkus");
//ts.Add("bab");
//ts.Add("dvdf");
//ts.Add("aab");
//foreach (var s in ts)
//{
//    Console.WriteLine(String.Format($"Longest substring of {s} is of length {ss.LengthOfLongestSubstringBruteForce(s)}."));
//}
//foreach (var s in ts)
//{
//    Console.WriteLine(String.Format($"Longest substring of {s} is of length {ss.LengthOfLongestSubstringSlidingWindow(s)}."));
//}
//foreach (var s in ts)
//{
//    Console.WriteLine(String.Format($"Longest substring of {s} is of length {ss.LengthOfLongestSubstringSlidingWindowOptimized(s)}."));
//}


// ===================
// Doordash
// ===================
//var dd = new DoorDash();
//var dddata = new int[] { 3, 5, 1, 4, 2 };
//var eligible = dd.GetEligibleOrders(dddata);

// ====================================================================================
// Leetcode Contest 71
// ====================================================================================
//
//var lc71 = new LeetcodeContest71();
//// ==============================
//// Minimum Sum
//// ==============================
//var lowest = lc71.MinimumSum2(2932);
//Console.WriteLine(lowest);
//// ==============================
//// Pivot Array
//// ==============================
//var pivotArray1 = new int[] { 9, 12, 5, 10, 14, 3, 10 };
//var newArray1 = lc71.PivotArray(pivotArray1, 10);
//// Expected Output: [9, 5, 3, 10, 10, 12, 14]
//Util.PrintArray("newArray1: Expected Output: [9, 5, 3, 10, 10, 12, 14]", newArray1);
//var pivotArray2 = new int[] { -3, 4, 3, 2 };
//var newArray2 = lc71.PivotArray(pivotArray2, 2);
//Util.PrintArray("newArray2: Expected Output:[-3,2,4,3]", newArray2);

// ====================================================================================
// Leetcode Contest 279
// ====================================================================================
//
//var lc279 = new LeetcodeContest279();
//var eo1 = new int[] { 4, 1, 2, 3 };
//var resorted1 = lc279.SortEvenOdd(eo1);
//Util.PrintArray("resorted: Expected Output:[2,3,4,1]", resorted1);
//var eo2 = new int[] { 2,1 };
//var resorted2 = lc279.SortEvenOdd(eo2);
//Util.PrintArray("resorted: Expected Output:[2,1]", resorted2);
//var eo3 = new int[] { 36, 45, 32, 31, 15, 41, 9, 46, 36, 6, 15, 16, 33, 26, 27, 31, 44, 34 };
//var resorted3 = lc279.SortEvenOdd(eo3);
//Util.PrintArray("resorted: Expected Output:[9,46,15,45,15,41,27,34,32,31,33,31,36,26,36,16,44,6]", resorted3);
//var newNum = lc279.SmallestNumber(310);
//Console.WriteLine(String.Format($"Expected: 301 Actual: {newNum}"));

//var ftd = new FindTheDifference389();
//var c1 = ftd.FindTheDifference("abcd", "abcde");
//Console.WriteLine("FindTheDifference for 'abcd', 'abcde' = " + c1);
//var c2 = ftd.FindTheDifference("", "y");
//Console.WriteLine("FindTheDifference for '', 'y' = " + c2);

// ====================================================================================
// Valid Sudoku 36
// ====================================================================================
//
// 36. Valid Sudoku - https://leetcode.com/problems/valid-sudoku/
// Medium
// Determine if a 9 x 9 Sudoku board is valid.Only the filled cells need to be validated according to the following rules:
// Each row must contain the digits 1-9 without repetition.
// Each column must contain the digits 1-9 without repetition.
// Each of the nine 3 x 3 sub-boxes of the grid must contain the digits 1-9 without repetition.
// Note:
//A Sudoku board (partially filled) could be valid but is not necessarily solvable.
//Only the filled cells need to be validated according to the mentioned rules.
//var vs = new ValidSudoku36();
//char[,] grid1 = new char[,] {
//{ '5', '3', '.', '.', '7', '.', '.', '.', '.'}
//,{'6', '.', '.', '1', '9', '5', '.', '.', '.'}
//,{'.', '9', '8', '.', '.', '.', '.', '6', '.'}
//,{'8', '.', '.', '.', '6', '.', '.', '.', '3'}
//,{'4', '.', '.', '8', '.', '3', '.', '.', '1'}
//,{'7', '.', '.', '.', '2', '.', '.', '.', '6'}
//,{'.', '6', '.', '.', '.', '.', '2', '8', '.'}
//,{'.', '.', '.', '4', '1', '9', '.', '.', '5'}
//,{'.', '.', '.', '.', '8', '.', '.', '7', '9'}};
//var isValid1 = vs.IsValidSudoku(grid1);
//Console.WriteLine("IsValidSudoku isValid: " + isValid1);
//char[,] grid2 = new char[,] {
//{ '5', '3', '.', '.', '7', '.', '.', '.', '.'}
//,{'6', '.', '.', '1', '9', '5', '.', '.', '.'}
//,{'.', '9', '8', '.', '.', '.', '.', '6', '.'}
//,{'8', '.', '.', '.', '6', '.', '.', '.', '3'}
//,{'4', '.', '.', '8', '6', '3', '.', '.', '1'}
//,{'7', '.', '.', '.', '2', '.', '.', '.', '6'}
//,{'.', '6', '.', '.', '.', '.', '2', '8', '.'}
//,{'.', '.', '.', '4', '1', '9', '.', '.', '5'}
//,{'.', '.', '.', '.', '8', '.', '.', '7', '9'}};
//var isValid2 = vs.IsValidSudoku(grid2);
//Console.WriteLine("IsValidSudoku isValid: " + isValid2);
//char[,] grid3 = new char[,] {
//{ '5', '3', '.', '.', '7', '.', '.', '.', '.'}
//,{'6', '.', '3', '1', '9', '5', '.', '.', '.'}
//,{'.', '9', '8', '.', '.', '.', '.', '6', '.'}
//,{'8', '.', '.', '.', '6', '.', '.', '.', '3'}
//,{'4', '.', '.', '8', '.', '3', '.', '.', '1'}
//,{'7', '.', '.', '.', '2', '.', '.', '.', '6'}
//,{'.', '6', '.', '.', '.', '.', '2', '8', '.'}
//,{'.', '.', '.', '4', '1', '9', '.', '.', '5'}
//,{'.', '.', '.', '.', '8', '.', '.', '7', '9'}};
//var isValid3 = vs.IsValidSudoku(grid3);
//Console.WriteLine("IsValidSudoku isValid: " + isValid3);

// ====================================================================================
// 217. Contains Duplicate - https://leetcode.com/problems/contains-duplicate/
// ====================================================================================
// Easy
// Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.

// Example 1:
// Input: nums = [1,2,3,1]
// Output: true

// Example 2:
// Input: nums = [1,2,3,4]
// Output: false

// Example 3:
// Input: nums = [1,1,1,3,3,4,3,2,4,2]
// Output: true
//var cd = new ContainsDuplicate217();
//var cd1 = new int[] { 1, 2, 3, 1 };
//var dup1 = cd.ContainsDuplicate(cd1);
//Console.WriteLine("ContainsDuplicate: [1,2,3,1] : " + dup1);
//var cd2 = new int[] { 1, 2, 3, 4 };
//var dup2 = cd.ContainsDuplicate(cd2);
//Console.WriteLine("ContainsDuplicate: [1,2,3,4] : " + dup2);
//var cd3 = new int[] { 1, 2, 3, 1 };
//var dup3 = cd.ContainsDuplicate(cd3);
//Console.WriteLine("ContainsDuplicate: [1,1,1,3,3,4,3,2,4,2] : " + dup3);

// ====================================================================================
// 187. Repeated DNA Sequences https://leetcode.com/problems/repeated-dna-sequences/
// ====================================================================================
//var rdna = new RepeatingDNA();
////var result1 = rdna.FindRepeatedDnaSequencesOptimal("AAAAACCCCCAAAAACCCCCCAAAAAGGGTTT");
////Util.PrintList("FindRepeatedDnaSequences ",result1);
//var result2 = rdna.FindRepeatedDnaSequencesOptimal("AAAAAAAAAAA");
//Util.PrintList("FindRepeatedDnaSequences ", result2);

// ====================================================================================
// 128. Longest Consecutive Sequence https://leetcode.com/problems/longest-consecutive-sequence/
// ====================================================================================
//var lcs = new LongestConsecutiveSequence128();
//var seq1 = new int[] { 100, 4, 200, 1, 3, 2 };
//var res1 = lcs.longestConsecutiveBest(seq1);
//Console.WriteLine("LongestConsecutive for [100, 4, 200, 1, 3, 2] is " + res1);
//var seq2 = new int[] { 0, 3, 7, 2, 5, 8, 4, 6, 0, 1 };
//var res2 = lcs.longestConsecutiveBest(seq2);
//Console.WriteLine("LongestConsecutive for [0, 3, 7, 2, 5, 8, 4, 6, 0, 1] is " + res2);
//var seq3 = new int[] { 0 };
//var res3 = lcs.longestConsecutiveBest(seq3);
//Console.WriteLine("LongestConsecutive for [0] is " + res3);
//var seq4 = new int[] { 0, 1 };
//var res4 = lcs.longestConsecutiveBest(seq4);
//Console.WriteLine("LongestConsecutive for [0, 1] is " + res4);
//var seq5 = new int[] { 0, 2 };
//var res5 = lcs.longestConsecutiveBest(seq5);
//Console.WriteLine("LongestConsecutive for [0, 2] is " + res5);
//var seq6 = new int[] { 0, 0 };
//var res6 = lcs.longestConsecutiveBest(seq5);
//Console.WriteLine("LongestConsecutive for [0, 0] is " + res6);

// ====================================================================================
// Rohan Mock Interview 2022-02-12
// ====================================================================================
//var words = new string[] { "lottery", "bus", "table", "chair", "table", "newspaper", "bus", "car" };
//var rohan = new RohanMockInterview20220212();
//var rohanRes1 = rohan.GetWordFrequency(words);
//foreach (var word in rohanRes1)
//    Console.WriteLine("Word: " + word.Key + " appeared " + word.Value + " times.");
//var seen = new Dictionary<string, int>();
//var rohanRes2 = rohan.GetWordFrequencyR(words, 0, seen);
//foreach (var word in rohanRes2)
//    Console.WriteLine("Word: " + word.Key + " appeared " + word.Value + " times.");

// ====================================================================================
// 73. Set Matrix Zeroes https://leetcode.com/problems/set-matrix-zeroes/
// ====================================================================================
//var smz = new SetMatrixZeroes73();
//var smzData1 = new int[][] { new int[] { 1, 1, 1 }, new int[] { 1, 0, 1 }, new int[] { 1, 1, 1 } };
//var smzRes1 = smz.SetZeroes(smzData1);
//Console.WriteLine();
////[0,1,2,0],[3,4,5,2],[1,3,1,5]
//var smzData2 = new int[][] { new int[] { 0, 1, 2, 0 }, new int[] { 3, 4, 5, 2 }, new int[] { 1, 3, 1, 5 } };
//var smzRes2 = smz.SetZeroes(smzData2);
//Console.WriteLine();

// ====================================================================================
// 249. Group Shifted Strings https://leetcode.com/problems/group-shifted-strings/
// ====================================================================================
//var gss = new GroupShiftedStrings249();
//var gssData1 = new string[] {"abc","bcd","acef","xyz","az","ba","a","z"};
//var gssRes1 = gss.GroupStrings(gssData1);
//Console.WriteLine();

// =========================================================================================================
// 1570. Dot Product of Two Sparse Vectors https://leetcode.com/problems/dot-product-of-two-sparse-vectors/
// =========================================================================================================
//var nums1 = new int[] { 1, 0, 0, 2, 3 };
//var nums2 = new int[] { 0, 3, 0, 4, 0 };
//var nums3 = new int[] { 0, 1, 0, 0, 0 };
//var nums4 = new int[] { 0, 0, 0, 0, 2 };
//var nums5 = new int[] { 0, 1, 0, 0, 2, 0, 0 };
//var nums6 = new int[] { 1, 0, 0, 0, 3, 0, 4 };
//SparseVector v1 = new SparseVector(nums1);
//SparseVector v2 = new SparseVector(nums2);
//var sumSparseVectors1 = v1.DotProduct(v2);
//Console.WriteLine("Sum of vectors [1, 0, 0, 2, 3] and [0, 3, 0, 4, 0] : " + sumSparseVectors1);
//SparseVector v3 = new SparseVector(nums3);
//SparseVector v4 = new SparseVector(nums4);
//var sumSparseVectors2 = v3.DotProduct(v4);
//Console.WriteLine("Sum of vectors [0, 1, 0, 0, 0] and [0, 0, 0, 0, 2] : " + sumSparseVectors2);
//SparseVector v5 = new SparseVector(nums5);
//SparseVector v6 = new SparseVector(nums6);
//var sumSparseVectors3 = v5.DotProduct(v6);
//Console.WriteLine("Sum of vectors [0,1,0,0,2,0,0] and [1,0,0,0,3,0,4] : " + sumSparseVectors3);

// ===============================================================================================================================================
// 1282. Group the People Given the Group Size They Belong To https://leetcode.com/problems/group-the-people-given-the-group-size-they-belong-to/
// ===============================================================================================================================================
//var gtp = new GroupThePeople1282();
//var gtpArr1 = new[] { 3, 3, 3, 3, 3, 1, 3 };
//var gtpRes1 = gtp.GroupThePeople(gtpArr1);
//Console.WriteLine();
//var gtpArr2 = new[] { 2, 1, 3, 3, 3, 2 };
//var gtpRes2 = gtp.GroupThePeople(gtpArr2);
//Console.WriteLine();

// =======================================================================================================
// 1817. Finding the Users Active Minutes https://leetcode.com/problems/finding-the-users-active-minutes/
// =======================================================================================================
//var ftuam = new FindingUsersActiveMinutes1817();
//var logs1 = new int[][] { new int[] { 0, 5 }, new int[] { 1, 2 }, new int[] { 0, 2 }, new int[] { 0, 5 }, new int[] { 1, 3 } };
//var res1 = ftuam.FindingUsersActiveMinutes(logs1, 5);
//Console.WriteLine();


// =======================================================================================================
// Leetcode Bi-weekly contest 72
// =======================================================================================================
//
//  5996. Count Equal and Divisible Pairs in an Array https://leetcode.com/contest/biweekly-contest-72/problems/count-equal-and-divisible-pairs-in-an-array/
// Easy
//var l72 = new LeetcodeContest72();
//var c72n1 = new int[] { 3, 1, 2, 2, 2, 1, 3 };
//var c72r1 = l72.CountPairs(c72n1, 2);
//Console.WriteLine(" CountPairs of  [3, 1, 2, 2, 2, 1, 3] k=2 is: " + c72r1);
//
// 5997. Find Three Consecutive Integers That Sum to a Given Number https://leetcode.com/contest/biweekly-contest-72/problems/find-three-consecutive-integers-that-sum-to-a-given-number/
//
//long c72n2 = 33;
//var c72r2 = l72.SumOfThree(c72n2);
//Util.PrintArray("Sum of Three with 33", c72r2);
//var c72r3 = l72.SumOfThree(462667378);
//Util.PrintArray("Sum of Three with 478526380", c72r3);
//var c72r4 = l72.MaximumEvenSplit(28);
//Util.PrintList("MaximumEvenSplit with 28", c72r4);

// =======================================================================================================
// Leetcode weekly contest 281
// =======================================================================================================
//
//  6012. Count Integers With Even Digit Sum https://leetcode.com/contest/weekly-contest-281/problems/count-integers-with-even-digit-sum/
// Easy
//var l281 = new LeetcodeContest281();
//var l281r1 = l281.CountEven(4);
//Console.WriteLine("CountEven result from 4 is: " + l281r1); 
//var l281r2 = l281.CountEven(30);
//Console.WriteLine("CountEven result from 30 is: " + l281r2);
//var l281r3 = l281.CountEven(684);
//Console.WriteLine("CountEven result from 684 is: " + l281r3);
//
//var l281arr1 = new int[] { 1, 2, 3, 4, 5 };
//var l281Pairs1 = l281.CoutPairs(l281arr1, 2);
//Console.WriteLine("CountPairs from [1, 2, 3, 4, 5] is: " + l281Pairs1);
//var l281arr2 = new int[] { 1, 2, 3, 4 };
//var l281Pairs2 = l281.CoutPairs(l281arr2, 5);
//Console.WriteLine("CountPairs from [1,2,3,4] is: " + l281Pairs2);

// =======================================================================================================
// 1756. Design Most Recently Used Queue - https://leetcode.com/problems/design-most-recently-used-queue/
// =======================================================================================================
//var mruq1 = new MostRecentlyUsedQueue1756(8);
//var mruqr1 = mruq1.Fetch(3);
//Console.WriteLine("8: Fetch(3): " + mruqr1);
//var mruqr2 = mruq1.Fetch(5);
//Console.WriteLine("8: Fetch(5): " + mruqr2);
//var mruqr3 = mruq1.Fetch(2);
//Console.WriteLine("8: Fetch(2): " + mruqr3);
//var mruqr4 = mruq1.Fetch(8);
//Console.WriteLine("8: Fetch(8): " + mruqr4);

//var mruq2 = new MostRecentlyUsedQueue1756(3);
//var mruqr21 = mruq2.Fetch(3);
//Console.WriteLine("3: Fetch(3): " + mruqr21);
//var mruqr22 = mruq2.Fetch(2);
//Console.WriteLine("3: Fetch(2): " + mruqr22);
//var mruqr23 = mruq2.Fetch(1);
//Console.WriteLine("3: Fetch(1): " + mruqr23);
//var mruqr24 = mruq2.Fetch(2);
//Console.WriteLine("3: Fetch(2): " + mruqr24);
//var mruqr25 = mruq2.Fetch(2);
//Console.WriteLine("3: Fetch(2): " + mruqr25);
//var mruqr26 = mruq2.Fetch(2);
//Console.WriteLine("3: Fetch(2): " + mruqr26);
//var mruqr27 = mruq2.Fetch(3);
//Console.WriteLine("3: Fetch(3): " + mruqr27);
//var mruqr28 = mruq2.Fetch(2);
//Console.WriteLine("3: Fetch(2): " + mruqr28);
//var mruqr29 = mruq2.Fetch(1);
//Console.WriteLine("3: Fetch(1): " + mruqr29);
//var mruqr210 = mruq2.Fetch(1);
//Console.WriteLine("3: Fetch(1): " + mruqr210);
//var mruqr211 = mruq2.Fetch(2);
//Console.WriteLine("3: Fetch(2): " + mruqr211);

// =========================================================================================================================================
// 1940. Longest Common Subsequence Between Sorted Arrays - https://leetcode.com/problems/longest-common-subsequence-between-sorted-arrays/
// =========================================================================================================================================

//var lcs1 = new LongestCommonSubsequence1940();
//var lcs1d1 = new int[][] { new int[] { 1, 3, 4 }, new int[] { 1, 4, 7, 9 } };
//var lcs1r1 = lcs1.LongestCommonSubsequence(lcs1d1);
//Util.PrintList("LongestCommonSubsequence of [1,3,4] and [1,4,7,9] is: ", lcs1r1);
//var lcs1d2 = new int[][] { new int[] { 2, 3, 6, 8 }, new int[] { 1, 2, 3, 5, 6, 7, 10 }, new int[] { 2, 3, 4, 6, 9 } };
//var lcs1r2 = lcs1.LongestCommonSubsequence(lcs1d2);
//Util.PrintList("LongestCommonSubsequence of [2, 3, 6, 8], [1, 2, 3, 5, 6, 7, 10], [2,3,4,6,9] is: ", lcs1r2);
//var lcs1d3 = new int[][] { new int[] { 1, 2, 3, 4, 5 }, new int[] { 6, 7, 8 } };
//var lcs1r3 = lcs1.LongestCommonSubsequence(lcs1d3);
//Util.PrintList("LongestCommonSubsequence of [1,2,3,4,5], [6,7,8] is: ", lcs1r3);

// =========================================================================================================================================
// 1198. Find Smallest Common Element in All Rows - https://leetcode.com/problems/find-smallest-common-element-in-all-rows/
// =========================================================================================================================================

//var l1198d1 = new int[][] { new int[] { 1, 2, 3, 4, 5 }, new int[] { 2, 4, 5, 8, 10 }, new int[] { 3, 5, 7, 9, 11 }, new int[] { 1, 3, 5, 7, 9 } };
//var l1198r1 = SmallestCommonElement1198.SmallestCommonElement(l1198d1);
//Console.WriteLine("SmallestCommonElement of [[1,2,3,4,5],[2,4,5,8,10],[3,5,7,9,11],[1,3,5,7,9]] is: " + l1198r1);
////[1,2,3],[2,3,4],[2,3,5]
//var l1198d2 = new int[][] { new int[] { 1, 2, 3 }, new int[] { 2, 3, 4 }, new int[] { 2, 3, 5 } };
//var l1198r2 = SmallestCommonElement1198.SmallestCommonElement(l1198d2);
//Console.WriteLine("SmallestCommonElement of [[1,2,3],[2,3,4],[2,3,5]] is: " + l1198r2);

// =================================================================================================================================================
// 1442. Count Triplets That Can Form Two Arrays of Equal XOR - https://leetcode.com/problems/count-triplets-that-can-form-two-arrays-of-equal-xor/
// =================================================================================================================================================

//var l1442 = new CountTriplets1442();
//var l1442r1 = l1442.CountTriplets(new int[] {2,3,1,6,7});
//Console.Write("CountTriplets1442 of [2,3,1,6,7] is: " + l1442r1);

// ===========================================================================================================
// 1852. Distinct Numbers in Each Subarray - https://leetcode.com/problems/distinct-numbers-in-each-subarray/
// ===========================================================================================================

//var l1852 = new DistinctNumbers1852();
//var l1852r1 = l1852.DistinctNumbers(new int[] { 1, 2, 3, 2, 2, 1, 3 }, 3);
//Util.PrintArray("Distinct Numbers: ", l1852r1);
//var l1852r2 = l1852.DistinctNumbers(new int[] { 1, 1, 1, 1, 2, 3, 4 }, 4);
//Util.PrintArray("Distinct Numbers: ", l1852r2);

// =================================================================================================================
// 17. Letter Combinations of a Phone Number - https://leetcode.com/problems/letter-combinations-of-a-phone-number/
// =================================================================================================================

//var l17 = new LetterCombinations17();
//var l17r1 = l17.LetterCombinations("23");
//Util.PrintList("Letter Combinations for 23: ", l17r1);

// =================================================================================================================
// 409. Longest Palindrome - https://leetcode.com/problems/longest-palindrome/
// =================================================================================================================

//var l409 = new LongestPalindrome409();
//var l409r1 = l409.LongestPalindrome("abccccddAAA");
//Console.WriteLine("Longest Palindrome of abccccddAAA is: " + l409r1);
//var l409r2 = l409.LongestPalindrome("bb");
//Console.WriteLine("Longest Palindrome of bb is: " + l409r2);
//var l409r3 = l409.LongestPalindrome("ccc");
//Console.WriteLine("Longest Palindrome of ccc is: " + l409r3);
//var l409r4 = l409.LongestPalindrome("ababababa");
//Console.WriteLine("Longest Palindrome of ababababa is: " + l409r4);

// =================================================================================================================
// 442. Find All Duplicates in an Array - https://leetcode.com/problems/find-all-duplicates-in-an-array/
// =================================================================================================================
//var l442 = new FindDuplicates442();
//var l442d1 = new int[] { 4, 3, 2, 7, 8, 2, 3, 1 };
//var l442r1 = l442.FindDuplicates(l442d1);
//Util.PrintList("FindDuplicates for 4, 3, 2, 7, 8, 2, 3, 1 is: ", l442r1);
//var l442d2 = new int[] { 1,1,2 };
//var l442r2 = l442.FindDuplicates(l442d2);
//Util.PrintList("FindDuplicates for 1,1,2 is: ", l442r2);
//var l442d3 = new int[] {  };
//var l442r3 = l442.FindDuplicates(l442d3);
//Util.PrintList("FindDuplicates for [] is: ", l442r3);

// =================================================================================================================
// 362. Design Hit Counter - https://leetcode.com/problems/design-hit-counter/
// =================================================================================================================
//["HitCounter","hit","hit","hit","getHits","hit","getHits","getHits"]
//[[],[1],[2],[3],[4],[300],[300],[301]]
//var hitCounter = new HitCounter362();
//hitCounter.Hit(1);       // hit at timestamp 1.
//hitCounter.Hit(2);       // hit at timestamp 2.
//hitCounter.Hit(3);       // hit at timestamp 3.
//var l362r1 = hitCounter.GetHits(4);
//hitCounter.Hit(300);     // hit at timestamp 300.
//var l362r2 = hitCounter.GetHits(300);
//var l362r3 = hitCounter.GetHits(301);
//Console.WriteLine(String.Format($"4 = {l362r1}, 300 = {l362r2}, 301 = {l362r3}"));

// ==================================================================================================================================
// 1249. Minimum Remove to Make Valid Parentheses - https://leetcode.com/problems/minimum-remove-to-make-valid-parentheses/solution/
// ==================================================================================================================================
//var l1249 = new MinRemoveToMakeValid1249();
//var l1249r1 = l1249.MinRemoveToMakeValid("lee(t(c)o)de)");
//Console.WriteLine(string.Format($"MinRemoveToMakeValid from lee(t(c)o)de) is {l1249r1}."));

// ==================================================================================================================================
// 3. Longest Substring Without Repeating Characters - https://leetcode.com/problems/longest-substring-without-repeating-characters/
// ==================================================================================================================================
//var l3 = new LengthOfLongestSubstring3();
//var l3r1 = l3.LengthOfLongestSubstring("abcabcbb");
//Console.WriteLine("LengthOfLongestSubstring, abcabcbb, is: " + l3r1);
//var l3r2 = l3.LengthOfLongestSubstring("bbbbb");
//Console.WriteLine("LengthOfLongestSubstring, bbbbb, is: " + l3r2);
//var l3r3 = l3.LengthOfLongestSubstring("pwwkew");
//Console.WriteLine("LengthOfLongestSubstring, pwwkew, is: " + l3r3);
//var l3r4 = l3.LengthOfLongestSubstring("au");
//Console.WriteLine("LengthOfLongestSubstring, au, is: " + l3r4);
//var l3r5 = l3.LengthOfLongestSubstring("abbccaabbabc");
//Console.WriteLine("LengthOfLongestSubstring, abbccaabbabc, is: " + l3r5);

// ==================================================================================================================================
// 139. Word Break - https://leetcode.com/problems/word-break/
// ==================================================================================================================================
var l139 = new WordBreak139();
//var l139d1 = new List<string>();
//l139d1.Add("leet");
//l139d1.Add("code");
//var sd1 = "leetcode";
//var l139r1 = l139.WordBreak(sd1, l139d1);
//Console.WriteLine("WordBreak for leetcode is: " + l139r1);
//var l139d2 = new List<string>();
//l139d2.Add("apple");
//l139d2.Add("pen");
//l139d2.Add("apple");
//var sd2 = "applepenapple";
//var l139r2 = l139.WordBreak(sd2, l139d2);
//Console.WriteLine("WordBreak for applepenapple is: " + l139r2);
//var l139d3 = new List<string>();
//l139d3.Add("cats");
//l139d3.Add("dog");
//l139d3.Add("sand");
//l139d3.Add("and");
//l139d3.Add("cat");
//var sd3 = "catsandog";
//var l139r3 = l139.WordBreak(sd3, l139d3);
//Console.WriteLine("WordBreak for catsandog is: " + l139r3);

// ==================================================================================================================================
// 404. Sum of Left Leaves - https://leetcode.com/problems/sum-of-left-leaves/
// ==================================================================================================================================
//var l404 = new SumofLeftLeaves404();
//var l404d3 = new TreeNode404(3);
//var l139r3 = l139.WordBreak(sd3, l139d3);
//Console.WriteLine("WordBreak for catsandog is: " + l139r3);
// ==================================================================================================================================
// 133. Clone Graph - https://leetcode.com/problems/clone-graph/
// ==================================================================================================================================
var l133 = new coding_practice_graph_leetcode.CloneGraphLeetcode133();
// [[2,4],[1,3],[2,4],[1,3]]
var l133d1 = new List<List<int>>();
var node1 = new coding_practice_graph_leetcode.Node(1);
var node2 = new coding_practice_graph_leetcode.Node(2);
var node3 = new coding_practice_graph_leetcode.Node(3);
var node4 = new coding_practice_graph_leetcode.Node(4);
node1.neighbors.Add(node2);
node1.neighbors.Add(node4);
node2.neighbors.Add(node1);
node2.neighbors.Add(node3);
node3.neighbors.Add(node2);
node3.neighbors.Add(node4);
node4.neighbors.Add(node1);
node4.neighbors.Add(node3);
//var l133r1 = l133.CloneGraph(node1);

//var l6060 = new FindClosestNumbertoZero2239();
//var l6060d1 = new int[] { -4, -2, 1, 4, 8 };
////var l6060d1 = new int[] { -10000, -10000 };
//var l6060r1 = l6060.FindClosestNumber(l6060d1);
//Console.WriteLine("FindClosestNumbertoZero for [-4, -2, 1, 4, 8] is: " + l6060r1);

var l6061 = new NumberofWaystoBuyPensandPencils2240();

var l6061r1 = l6061.WaysToBuyPensPencils(20, 10, 5);
Console.WriteLine("WaysToBuyPensPencils(20, 10, 5) is: " + l6061r1);
var l6061r2 = l6061.waysToBuyPensPencils(20, 10, 5);
Console.WriteLine("WaysToBuyPensPencils(20, 10, 5) is: " + l6061r2);

var l2241 = new ATM();
var l2241d1 = new List<int>() { 0, 0, 1, 2, 1 };
var l2241d2 = new List<int>() { 0, 1, 0, 1, 1 };
l2241.deposit(l2241d1);
Console.WriteLine("ATM withdraw(600)"); 
var atmResult = l2241.withdraw(600);
Util.PrintList("ATM withdraw(600) result is: ", atmResult);
l2241.deposit(l2241d2);
Console.WriteLine("ATM withdraw(600)");
atmResult = l2241.withdraw(600);
Util.PrintList("ATM withdraw(600) result is: ", atmResult); 
Console.WriteLine("ATM withdraw(550)");
atmResult = l2241.withdraw(550);
Util.PrintList("ATM withdraw(550) result is: ", atmResult);
