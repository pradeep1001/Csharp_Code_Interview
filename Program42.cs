using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

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
    public class Program42
    {
        public static void Main(String[] args)
        {
            string istrInput = Console.ReadLine();
            Console.WriteLine(istrInput);
            string[] istrInput1 = istrInput.Split(' ');
            int a = Convert.ToInt32(istrInput1[0]);
            int b = Convert.ToInt32(istrInput1[1]);
            int c = a * b;
            Console.WriteLine(c);
        }
    }
}
