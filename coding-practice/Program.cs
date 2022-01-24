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

 var s4 = new SingleNumber();
//var e = s4.DoSingleNumber(d);
//var e = s4.SingleNumberLeetCodeList(d);
var e = s4.SingleNumberLeetCodeMath(d);
Console.WriteLine(e);

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
var mz = new int[] { 0, 0, 1 };
var moveZ = new MoveZeroesSolution();
var mzArr = moveZ.MoveZeroes(mz);
Console.WriteLine("MoveZeroes: " + JsonConvert.SerializeObject(mzArr));
