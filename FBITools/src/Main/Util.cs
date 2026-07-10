using System;
using System.Collections.Generic;
using App.Core;

namespace FBITools
{
    public static class Util
    {
        public static List<DropItem> EnumToDropItems<T>()
        {
            var collection = Enum.GetValues(typeof(T));
            var list = new List<DropItem>();

            foreach (var item in collection)
            {
                list.Add(new DropItem((int)item, ((int)item).ToString().PadLeft(3) + " - " + item));
            }

            return list;
        }
    }
}