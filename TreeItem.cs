using System;
using System.Collections.Generic;


namespace FileExplorer
{
    public class TreeItem
    {
        private TreeItem mParentItem;
        private List<TreeItem> mChildItems;
        public string ItemData { get; set; }

        public static int Count { get; private set; } = 0;


        public TreeItem(string data, TreeItem parent = null)
        {
            Count++;
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
