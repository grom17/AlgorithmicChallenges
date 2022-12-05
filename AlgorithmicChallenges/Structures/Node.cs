using System.Collections.Generic;

namespace AlgorithmicChallenges.Structures;

public class Node 
{
    public int val;
        
    public IList<Node> children = new List<Node>();

    public Node() {}

    public Node(int _val) 
    {
        val = _val;
    }

    public Node(int _val, IList<Node> _children)
    {
        val = _val;
        children = _children;
    }
}