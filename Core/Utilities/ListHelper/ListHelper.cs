using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.ListHelper
{
    public class ListHelper<T>
    {
        public static List<T> Reverse(List<T> messages)
        {
            int index = messages.Count - 1;
            for (int i = 0; i <= index; i++)
            {
                var temp = messages[index];
                messages[index] = messages[i];
                messages[i] = temp;

                index--;
            }

            return messages;
        }
    }
}
