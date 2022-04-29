using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// input: stream of friend pairs
// output: sets of people who know each other

// A-B, B-C, D-E
// [[A, B, C], [D, E]]

public class FriendList
{
    // [{A, B}]
    Dictionary<string, List<string>> friendList = new Dictionary<string, List<string>>();

    public void SendFriends(string friendA, string friendB)
    {
        if (!friendList.ContainsKey(friendA))
        {
            friendList.Add(friendA, new List<string>());
        }
        friendList[friendA].Add(friendB);

        if (friendList.ContainsKey(friendB))
        {
            friendList[friendB].Add(friendA);
        }
        else
        {
            friendList.Add(friendB, new List<string>());
        }
    }

    public void dfs(string v, List<string> friends, HashSet<string> visited)
    {
        // mark v is visited
        // add v to a list of friends. list can be a parameter
        // fetch all adjacent nodes of v
        // if not visited, then visit (call dfs on that node)
        visited.Add(v);
        friends.Add(v);
        foreach (var friend in friendList)
        {
            if (!visited.Contains(friend.Key))
            {
                dfs(friend.Key, friend.Value, visited);
            }
        }
    }
    public List<List<string>> GetRelationships()
    {
        var visited = new HashSet<string>();

        foreach (var friend in friendList)
        {
            if (!visited.Contains(friend.Key))
            {
                dfs(friend.Key, friend.Value, visited);
            }
        }
        return null;
    }


}