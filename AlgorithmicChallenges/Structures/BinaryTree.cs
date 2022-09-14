using System.Collections.Generic;
using System.Linq;

namespace AlgorithmicChallenges.Structures;

public class BinaryTree
{
    public BinaryTree(IEnumerable<object?> tree)
    {
        foreach (var value in tree)
        {
            if (value is int intValue)
            {
                Add(intValue);
            }
        }
    }
    
    public BinaryTree(IEnumerable<int> tree)
    {
        foreach (var value in tree)
        {
            Add(value);
        }
    }

    public static IEnumerable<int> ConvertToLevelOrderedEnumeration(TreeNode? root)
    {
        var queue = new Queue<TreeNode?>();
        queue.Enqueue(root);

        while (queue.Any())
        {
            var node = queue.Dequeue();

            if (node == null)
            {
                continue;
            }
                
            yield return node.Value;
            queue.Enqueue(node.Left);
            queue.Enqueue(node.Right);
        }
    }

    public TreeNode? Root { get; private set; }

    private void Add(int value)
    {
        TreeNode? before = null; 
        var after = Root;

        while (after != null)
        {
            before = after;
            if (value < after.Value)
            {
                after = after.Left;
            }
            else if (value > after.Value)
            {
                after = after.Right;
            }
            else
            {
                return;
            }
        }

        var newNode = new TreeNode
        {
            Value = value
        };

        if (Root == null)
        {
            Root = newNode;
        }
        else
        {
            if (value < before!.Value)
            {
                before.Left = newNode;
            }
            else
            {
                before.Right = newNode;
            }
        }
    }
}