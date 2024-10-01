using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Pradeep_1
{
    public class TreeNode
    {
        int data;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int value)
        {
            data = value;
        }
        public bool HasMax2Child()
        {
            int childrencounterer = 0;
            if (left != null)
            {
                childrencounterer++;
            }
            if (right != null)
            {
                childrencounterer++;
            }
            return childrencounterer <= 2;
        }
        public int GetNumberofChildren()
        {
            int childrencounterer = 0;
            if (left != null)
            {
                childrencounterer++;
            }
            if (right != null)
            {
                childrencounterer++;
            }
            return childrencounterer;
        }

    }
    public class Program43
    {
        public static void Main(String[] args)
        {
            TreeNode root = new TreeNode(0)
            {
                left = new TreeNode(1)
                {
                    left = new TreeNode(3),
                    right = new TreeNode(4)
                },
                right = new TreeNode(2)
                {
                    left = new TreeNode(5),
                    right = new TreeNode(6)
                }
            };

            bool isNumberOfNodes;

            int numberOfNodes;



            isNumberOfNodes = root.left.HasMax2Child();
            numberOfNodes = root.GetNumberofChildren();


            Console.WriteLine(isNumberOfNodes);
            Console.WriteLine(numberOfNodes);

        }
    }
}
