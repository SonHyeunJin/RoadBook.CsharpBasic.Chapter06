﻿using System;
using System.Collections;

namespace RoadBook.CsharpBasic.Chapter06.Examples
{
    internal class Ex006
    {
        public void Run()
        {
            ArrayList aList = new ArrayList();

            for (int idx = 0; idx < 10; idx++)
            {
                aList.Add(idx);
            }

            for (int idx = 0; idx < 10; idx++)
            {
                aList.Add(idx.ToString());
            }

            for (int idx = 0; idx < aList.Count; idx++)
            {
                Console.WriteLine("Value: {0} / Type: {1}", aList[idx], aList[idx].GetType());
            }
        }
    }
}
