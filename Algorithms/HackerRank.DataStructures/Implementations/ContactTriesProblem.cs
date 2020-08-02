using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.DataStructures.Implementations
{
    public class TrieNode
    {
        private const int NUMBER_OF_CHARACTERS = 26;
        TrieNode[] children = new TrieNode[NUMBER_OF_CHARACTERS];
        int size = 0;

        private int GetCharIndex(char c)
        {
            return c - 'a';
        }

        private TrieNode GetNode(char c) 
        {
            return children[GetCharIndex(c)];
        }
        private void SetNode(char c, TrieNode node) 
        {
            children[GetCharIndex(c)] = node;
        }
        public void Add(string s) 
        {
            Add(s, 0);
        }
        private void Add(string s, int index)
        {
            size++;
            if (index == s.Length) return;
            char current = s[index];
            //int charCode = GetCharIndex(current);
            TrieNode child = GetNode(current);
            if (child == null)
            {
                child = new TrieNode();
                SetNode(current, child);
            }
            child.Add(s, index + 1);

        }
        public int FindCount(String s, int index) 
        {
            if (index == s.Length) return size;
            TrieNode child = GetNode(s[index]);
            if (child == null)
                return 0;
            return child.FindCount(s, index + 1);
        }        
    }
    public class ContactTriesProblem
    {
    }
}
