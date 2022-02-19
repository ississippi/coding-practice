using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_practice
{
    internal class SubdomainVisitCount811
    {
    }
}
// https://leetcode.com/problems/subdomain-visit-count/
// Input: cpdomains = ["900 google.mail.com", "50 yahoo.com", "1 intel.mail.com", "5 wiki.org"]
// Output: ["901 mail.com","50 yahoo.com","900 google.mail.com","5 wiki.org","5 org","1 intel.mail.com","951 com"]
// Explanation: We will visit "google.mail.com" 900 times, "yahoo.com" 50 times, "intel.mail.com" once and "wiki.org" 5 times.
// For the subdomains, we will visit "mail.com" 900 + 1 = 901 times, "com" 900 + 50 + 1 = 951 times, and "org" 5 times.

public class Solution
{
    public IList<string> SubdomainVisits(string[] cpdomains)
    {
        var elements = new Dictionary<string, int>();
        var results = new List<string>();
        // ["900 google.mail.com", "50 yahoo.com", "1 intel.mail.com", "5 wiki.org"]
        for (var i = 0; i < cpdomains.Length; i++)
        {
            // "900 google.mail.com"
            var countDomain = cpdomains[i].Split(" ");
            // [900],[google.mail.com]
            var count = Int32.Parse(countDomain[0]);
            // 900
            var domainParts = countDomain[1].Split(".");
            //[google], [mail], [com]

            // domainParts has each element of the domain, add last element with count, 
            // prepend next element and add with count, and so on
            var element = string.Empty;
            for (var j = domainParts.Length - 1; j >= 0; j--)
            {
                if (string.IsNullOrEmpty(element))
                {
                    element = domainParts[j];
                    //"com"
                }
                else
                {
                    element = domainParts[j] + "." + element;
                }
                if (!elements.ContainsKey(element))
                {
                    elements.Add(element, count);
                    //"com" = 900
                }
                else
                {
                    elements[element] += count;
                }
            }
        }
        foreach (var item in elements)
        {
            var resStr = item.Value + " " + item.Key;
            results.Add(resStr);
        }
        return results;
    }
}