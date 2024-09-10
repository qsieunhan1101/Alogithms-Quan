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

        public void printMenu()
        {
            List<MenuBase> menuP = new List<MenuBase>();
            for (int i = 0; i < menuP.Count; i++)
            {  
                for (int j = 0; j < menuP.Count; j++)
                {
                    if (j!=i && menuP[i].Id == menuP[j].Parent_id)
                    {
                        menuP[i].menuChilds.Add(menuP[j]);
                    }
                }
            }

            for (int i = 0; i < menuP.Count; i++)
            {
                Console.WriteLine(menuP[i].Title);
                for (int j = 0; j < menuP[i].menuChilds.Count; j++)
                {
                    Console.WriteLine("--"+menuP[i].Title);
                }
            }
    
        }

        private void printMenuBases(List<MenuBase> mbase)
        {

        }




    }


}
