using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_practice
{
    // input: stream of friend pairs
    // output: sets of people who know each other

    // A-B, B-C, D-E
    // [[A, B, C], [D, E]]

    public class Friends
    {
        // [{A, B}]
        Dictionary<string, List<string>> friends = new Dictionary<string, List<string>>();

        public void SendFriends(string friendA, string friendB)
        {

        }

        public List<List<string>> GetFriends()
        {
            return null;
        }

    }

}
