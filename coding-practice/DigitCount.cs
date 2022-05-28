using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_practice
{
    internal class DigitCount123
    {
        // Leetcode bi-weekly contest #79
        // Check if Number Has Equal Digit Count and Digit Value
        // You are given a 0-indexed string num of length n consisting of digits.
        // Return true if for every index i in the range 0 <= i<n,
        // the digit i occurs num[i] times in num, otherwise return false.
        // Accepted
        public bool DigitCount(string num)
        {
            var arr = num.ToCharArray();
            for (var i = 0; i < num.Length; i++)
            {
                var counter = 0;
                var target = i;
                var targetCountChar = arr[i];
                int targetCount = targetCountChar - '0';
                for (var j = 0; j < arr.Length; j++)
                {
                    int currentVal = arr[j] - '0';
                    if (currentVal == target)
                        counter++;

                }
                if (targetCount != counter)
                    return false;
            }
            return true;
        }
        // Sender With Largest Word Count
        // You have a chat log of n messages.You are given two string arrays messages and senders
        // where messages[i] is a message sent by senders[i].
        // A message is list of words that are separated by a single space with no leading or trailing spaces.
        // The word count of a sender is the total number of words sent by the sender.
        // Note that a sender may send more than one message.
        // Return the sender with the largest word count.
        // If there is more than one sender with the largest word count,
        // return the one with the lexicographically largest name.

        // Accepted
        public string LargestWordCount(string[] messages, string[] senders)
        {
            var userMessageCount = new Dictionary<string, int>();
            for (int i = 0; i < messages.Length; i++)
            {
                var msgArray = messages[i].Split(' ');
                if (userMessageCount.ContainsKey(senders[i]))
                    userMessageCount[senders[i]] += msgArray.Length;
                else
                    userMessageCount.Add(senders[i], msgArray.Length);
            }
            var max = 0;
            var maxUser = string.Empty;
            foreach (var userMsgCount in userMessageCount)
            {
                var userName = userMsgCount.Key;
                var userCount = userMsgCount.Value;
                if (max < userCount)
                {
                    maxUser = userName;
                    max = userCount;
                }
                else if (max == userCount)
                {
                    var greatest = getLexGreatest(maxUser, userName);
                    maxUser = greatest;
                }
            }
            return maxUser;

        }


        private string getLexGreatest(string name1, string name2)
        {
            var name1Array = name1.ToCharArray();
            var name2Array = name2.ToCharArray();
            var name1Lex = 0;
            var name2Lex = 0;
            for (var i = 0; i < name1Array.Length; i++)
            {
                if (name1Array[i] > name2Array[i])
                {
                    name1Lex = 1;
                    break;
                }
                else if (name1Array[i] < name2Array[i])
                {
                    name2Lex = 1;
                    break;
                }
            }
            if (name1Lex == 1)
                return name1;
            else if (name2Lex == 1)
                return name2;
            else
                return name1;
        }

    }
}
