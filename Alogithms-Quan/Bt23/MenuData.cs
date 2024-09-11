using System;
using System.Collections.Generic;

namespace Alogithms_Quan
{
    internal class MenuData
    {
        List<MenuBase> menuBases = new List<MenuBase>()
        {
        new MenuBase(1,"The thao",0),
        new MenuBase(2,"Xa hoi",0),
        new MenuBase(3,"The thao trong nuoc",1),
        new MenuBase(4,"Giao thong",2),
        new MenuBase(5,"Moi truong",2),
        new MenuBase(6,"The thao quoc te",1),
        new MenuBase(7,"Moi truong do thi",5),
        new MenuBase(8,"Giao thong un tac",4),
        };


        static void Main(string[] args)
        {
            MenuData menuData = new MenuData();
            printMenu(menuData.menuBases);
        }

        /// <summary>
        /// In ra Menu phan cap cha con
        /// </summary>
        static void printMenu(List<MenuBase> menu)
        {
            foreach (MenuBase item in menu)
            {
                if (item.Parent_id == 0)
                {
                    printChilds(menu, item, item.Parent_id);
                }
            }
        }
        /// <summary>
        /// Tim va in ra menu con theo cha
        /// </summary>
        /// <param name="menu"></param>
        /// <param name="parent"></param>
        /// <param name="level"></param>
        static void printChilds(List<MenuBase> menu , MenuBase parent , int level)
        {
            string str = new string('-', level * 2);
            Console.WriteLine($"{str}{parent.Title}");
            foreach (MenuBase item in menu)
            {
                if (item.Parent_id == parent.Id)
                {
                    printChilds(menu, item, level+1);
                }
            }
        }
    }


}
