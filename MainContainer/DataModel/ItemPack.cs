using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MainContainer.Exception
{
    public class ItemPack
    {
        List<Item> items;
        int val;

        public ItemPack(List<Item> items, int val)
        {
            this.items = items;
            this.val = val;
        }

        public List<Item> Items
        {
            get
            {
                return items;
            }

            set
            {
                items = value;
            }
        }

        public int Val
        {
            get
            {
                return val;
            }

            set
            {
                val = value;
            }
        }
    }
}