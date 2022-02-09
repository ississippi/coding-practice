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
var dd = new DoorDash();
var dddata = new int[] { 3, 5, 1, 4, 2 };
var eligible = dd.GetEligibleOrders(dddata);

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

var ftd = new FindTheDifference389();
var c1 = ftd.FindTheDifference("abcd", "abcde");
Console.WriteLine("FindTheDifference for 'abcd', 'abcde' = " + c1);
var c2 = ftd.FindTheDifference("", "y");
Console.WriteLine("FindTheDifference for '', 'y' = " + c2);

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
var vs = new ValidSudoku36();
char[,] grid1 = new char[,] {
{ '5', '3', '.', '.', '7', '.', '.', '.', '.'}
,{'6', '.', '.', '1', '9', '5', '.', '.', '.'}
,{'.', '9', '8', '.', '.', '.', '.', '6', '.'}
,{'8', '.', '.', '.', '6', '.', '.', '.', '3'}
,{'4', '.', '.', '8', '.', '3', '.', '.', '1'}
,{'7', '.', '.', '.', '2', '.', '.', '.', '6'}
,{'.', '6', '.', '.', '.', '.', '2', '8', '.'}
,{'.', '.', '.', '4', '1', '9', '.', '.', '5'}
,{'.', '.', '.', '.', '8', '.', '.', '7', '9'}};
var isValid1 = vs.IsValidSudoku(grid1);
Console.WriteLine("IsValidSudoku isValid: " + isValid1);
char[,] grid2 = new char[,] {
{ '5', '3', '.', '.', '7', '.', '.', '.', '.'}
,{'6', '.', '.', '1', '9', '5', '.', '.', '.'}
,{'.', '9', '8', '.', '.', '.', '.', '6', '.'}
,{'8', '.', '.', '.', '6', '.', '.', '.', '3'}
,{'4', '.', '.', '8', '6', '3', '.', '.', '1'}
,{'7', '.', '.', '.', '2', '.', '.', '.', '6'}
,{'.', '6', '.', '.', '.', '.', '2', '8', '.'}
,{'.', '.', '.', '4', '1', '9', '.', '.', '5'}
,{'.', '.', '.', '.', '8', '.', '.', '7', '9'}};
var isValid2 = vs.IsValidSudoku(grid2);
Console.WriteLine("IsValidSudoku isValid: " + isValid2);
char[,] grid3 = new char[,] {
{ '5', '3', '.', '.', '7', '.', '.', '.', '.'}
,{'6', '.', '3', '1', '9', '5', '.', '.', '.'}
,{'.', '9', '8', '.', '.', '.', '.', '6', '.'}
,{'8', '.', '.', '.', '6', '.', '.', '.', '3'}
,{'4', '.', '.', '8', '.', '3', '.', '.', '1'}
,{'7', '.', '.', '.', '2', '.', '.', '.', '6'}
,{'.', '6', '.', '.', '.', '.', '2', '8', '.'}
,{'.', '.', '.', '4', '1', '9', '.', '.', '5'}
,{'.', '.', '.', '.', '8', '.', '.', '7', '9'}};
var isValid3 = vs.IsValidSudoku(grid3);
Console.WriteLine("IsValidSudoku isValid: " + isValid3);
