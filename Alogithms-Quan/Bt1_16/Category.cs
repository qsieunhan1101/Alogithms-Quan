using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alogithms_Quan
{
    internal class Category
    {
        int id;
        string name;

        public Category(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
    }
}
