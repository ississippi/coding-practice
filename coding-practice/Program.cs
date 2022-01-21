// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using coding_practice;

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
