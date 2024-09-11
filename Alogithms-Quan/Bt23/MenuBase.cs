using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alogithms_Quan
{
    internal class MenuBase
    {
        int id;
        string title;
        int parent_id;
        public MenuBase(int id, string title, int parent_id) 
        {       
            Id = id;
            Title = title;
            Parent_id = parent_id;
        }

        public int Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public int Parent_id { get => parent_id; set => parent_id = value; }
    }
}
