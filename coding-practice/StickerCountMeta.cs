using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_practice
{

    // Your previous Plain Text content is preserved below:

    // # Problem
    // # The Facebook company store sells stickers that say the word “facebook” on them. We just got a new shipment in, and we have way more than we know what to do with. We came up with a plan: we can make posters by cutting and pasting the letters in the word "facebook" to make other words. 
    // # Given a particular source string representing a word on a sticker, write a function that tells me how many stickers of that string I need in order to make a given target string. Your function should take in both a source string and target string, and return the number of stickers.

    // # Examples
    // # source == "facebook", target == "fee": return 2
    // # source == "facebook", target == "BOO": return 1
    // # source == "facebook", target == "coffee kebab": return 3

    // int StickersToMakeTarget(


    // # Write a function that takes a list of words as input, and returns 
    // # a list of those words bucketized by anagrams.
    // #
    // # "Anagram" definition: a word, phrase, or name formed by rearranging
    // # the letters of another, such as cinema, formed from iceman.
    // #
    // # Example:
    // # 
    // # anagram_buckets(word_list)
    // #
    // # Input:  ["star", "rats", "car", "arc", "arts", "stars"]
    // # Output:  [ ["star", "rats", "arts"], ["car", "arc"], ["stars"] ]

    public static class StickerCountMeta
    {
        public static int GetStickerCount(string source, string target)
        {
            var sourceLetters = new Dictionary<char, int>();
            var targetLetters = new Dictionary<char, int>();
            var stickerCount = 0;
            source = source.ToLower();
            target = target.ToLower();
            for (int i = 0; i < source.Length; i++)
            {
                if (sourceLetters.ContainsKey(source[i]))
                {
                    sourceLetters[source[i]] = sourceLetters[source[i]] + 1;
                }
                else
                {
                    sourceLetters.Add(source[i], 1);
                }
            }
            for (int i = 0; i < target.Length; i++)
            {
                if (target[i] == ' ')
                    continue;
                if (targetLetters.ContainsKey(target[i]))
                {
                    targetLetters[target[i]] = targetLetters[target[i]] + 1;
                }
                else
                {
                    targetLetters.Add(target[i], 1);
                }
            }

            foreach (var key in targetLetters.Keys)
            {
                double stickers = targetLetters[key] / sourceLetters[key];
                var stickersForLetter = (int)Math.Ceiling(stickers);
                stickerCount = (stickersForLetter > stickerCount) ? stickersForLetter : stickerCount;
            }
            return stickerCount;
        }
    }
}

