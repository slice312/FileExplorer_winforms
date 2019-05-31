using System;
using System.Collections.Generic;
using System.Threading;


namespace FileExplorer
{
    public class TreeItem
    {
        public string ItemData { get; set; }

        public TreeItem ParentItem { get; private set; }
        public List<TreeItem> Childs { get; }




        private static int _count = 0;
        public static int Count => _count;



        public TreeItem(string data, TreeItem parent = null)
        {
            Interlocked.Increment(ref _count);
            this.ParentItem = parent;
            this.ItemData = data;
            this.Childs = new List<TreeItem>(); //TODO capacity
//            Console.WriteLine("mChildItems.Capacity = {0}", mChildItems.Capacity);
        }


        public void AddChild(TreeItem child)
        {
            Childs.Add(child);
        }

    }
}
