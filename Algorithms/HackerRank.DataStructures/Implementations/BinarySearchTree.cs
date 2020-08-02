using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace HackerRank.DataStructures.Implementations
{
    public class BSTNode
    {
        public int Data { get; set; }
        public BSTNode Left { get; set; }
        public BSTNode Right { get; set; }
        public BSTNode(int data)
        {
            this.Data = data;
        }

        public void Insert(int value)
        {
            if (value <= Data)
            {
                if (Left == null)
                    Left = new BSTNode(value);
                else
                    Left.Insert(value);
            }
            else
            {
                if (Right == null)
                    Right = new BSTNode(value);
                else
                    Right.Insert(value);
            }
        }
        public bool Contains(int value)
        {
            if (value == Data)
            {
                return true;
            }
            else if (value < Data)
            {
                if (Left == null)
                    return false;
                else
                    return Left.Contains(value);
            }
            else
            {
                if (Right == null)
                    return false;
                else
                    return Right.Contains(value);
            }
        }

        public void PrintInOrder()
        {
            if (Left != null)
                Left.PrintInOrder();
            Console.Write(Data + " ");
            if (Right != null)
                Right.PrintInOrder();
        }
        public void PrintPreOrder()
        {
            Console.Write(Data + " ");
            if (Left != null)
                Left.PrintInOrder();            
            if (Right != null)
                Right.PrintInOrder();
        }

        public void PrintPostOrder()
        {            
            if (Left != null)
                Left.PrintInOrder();
            if (Right != null)
                Right.PrintInOrder();
            Console.Write(Data + " ");
        }

        // Inclusive ranges
        public bool CheckBST(BSTNode root, int min, int max) 
        {
            if (root == null) 
                return true;
            if (root.Data < min || root.Data > max) 
                return false;
            return CheckBST(root.Left, min, root.Data - 1) && CheckBST(root.Right, root.Data + 1, max);
        }
        public bool CheckBST(BSTNode root)
        {
            return CheckBST(root, int.MinValue, int.MaxValue);
        } 
    }   
}
