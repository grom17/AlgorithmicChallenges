﻿using System.Collections.Generic;
using System.Linq;

namespace AlgorithmicChallenges.Structures;

public class ListNode
{
    public int val;
    public ListNode? next;

    public ListNode(int val = 0, ListNode? next = null)
    {
        this.val = val;
        this.next = next;
    }
    
    public ListNode? Reverse()
    {
        var head = this;
        ListNode? previous = null;

        while (head != null)
        {
            var nextNode = head.next;
            head.next = previous;
            previous = head;
            head = nextNode;
        }

        return previous;
    }
    
    public static ListNode? ConvertToLinkedList(IReadOnlyList<int> input)
    {
        if (input.Any())
        {
            var head = new ListNode();
            var current = head;
            for (var index = 0; index < input.Count; index++)
            {
                var value = input[index];
                current!.val = value;

                if (index < input.Count - 1)
                {
                    current.next = new ListNode();
                }
                    
                current = current.next;
            }

            return head;
        }

        return null;
    }
    
    public static ListNode? ConvertToCycledLinkedList(int[] input, int pos)
    {
        if (pos == -1)
        {
            return ConvertToLinkedList(input);
        }

        if (!input.Any())
        {
            return null;
        }
        
        var head = new ListNode();
        var current = head;
        ListNode? cycledNode = null;
        for (var index = 0; index < input.Length; index++)
        {
            var value = input[index];
            current!.val = value;

            if (index == pos)
            {
                cycledNode = current;
            }

            if (index < input.Length - 1)
            {
                current.next = new ListNode();
            }
            else
            {
                current.next = cycledNode;
                break;
            }

            current = current.next;
        }

        return head;
    }
    
    public IEnumerable<int> ConvertToArray()
    {
        return ConvertToArray(this);
    }
        
    public static IEnumerable<int> ConvertToArray(ListNode? head)
    {
        var elements = new List<int>();
        var current = head;
        while (true)
        {
            if (current == null)
            {
                break;
            }

            elements.Add(current.val);
            current = current.next;
        }

        return elements.ToArray();
    }
}