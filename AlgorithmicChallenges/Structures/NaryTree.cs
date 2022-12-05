using System.Collections.Generic;

namespace AlgorithmicChallenges.Structures;

public class NaryTree
{
    public Node? Root { get; }

    public NaryTree(IEnumerable<object?> tree)
    {
        var queue = new Queue<Node>();
        var rootValueSet = false; // will be set after first null value when Root is not null
        
        foreach (var value in tree)
        {
            if (Root == null && value != null)
            {
                Root = new Node((int)value);
                queue.Enqueue(Root);
                continue;
            }

            if (value != null)
            {
                var node = new Node((int)value);
                var parentNode = queue.Peek();
                parentNode.children.Add(node);
                queue.Enqueue(node);
            }
            else if (!rootValueSet)
            {
                rootValueSet = true;
            }
            else
            {
                queue.Dequeue();
            }
        }
    }
}