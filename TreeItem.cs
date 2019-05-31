using System;
using System.Collections.Generic;
using System.Threading;


namespace FileExplorer
{
    public class TreeItem
    {
        private TreeItem mParentItem;
        private List<TreeItem> mChildItems;
        public string ItemData { get; set; }

        static int _count = 0;
        public static int Count => _count;


        public TreeItem(string data, TreeItem parent = null)
        {
            Interlocked.Increment(ref _count);
            this.mParentItem = parent;
            this.ItemData = data;
            mChildItems = new List<TreeItem>(); //TODO capacity
//            Console.WriteLine("mChildItems.Capacity = {0}", mChildItems.Capacity);
        }


        public void AddChild(TreeItem child)
        {
            mChildItems.Add(child);
        }

    }
}
