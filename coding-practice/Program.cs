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

var uf = new UnionFindQuickUnion(10);
// 1-2-5-6-7 3-8-9 4
uf.union(1, 2);
uf.union(2, 5);
uf.union(5, 6);
uf.union(6, 7);
uf.union(3, 8);
uf.union(8, 9);
Console.WriteLine(uf.connected(1, 5)); // true
Console.WriteLine(uf.connected(5, 7)); // true
Console.WriteLine(uf.connected(4, 9)); // false
// 1-2-5-6-7 3-8-9-4
uf.union(9, 4);
Console.WriteLine(uf.connected(4, 9)); // true

// ===================
// Fibonacci
// ===================
var fib = new Fibonacci();
var x = fib.FibonacciIterative(8);
Console.WriteLine(" result: " + x);
var y = fib.FibonacciRecursive(8);
Console.WriteLine(" result: " + y);


