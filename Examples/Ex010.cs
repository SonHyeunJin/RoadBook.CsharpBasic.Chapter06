﻿using System;
using System.Collections;

namespace RoadBook.CsharpBasic.Chapter06.Examples
{
    internal class Ex010
    {
        public void Run()
        {
            Stack stk = new Stack();

            Console.WriteLine("* 시작점");
            for (int idx = 1; idx < 11; idx ++)
            {
                Console.WriteLine("{0}번 선수 도착", idx);
                stk.Push(string.Format("{0}번 선수", idx));
            }
            Console.WriteLine("=====");
            Console.WriteLine("5~10등 선수는 탈락합니다.");
            for (int idx = 0; idx < 6; idx ++)
            {
                stk.Pop();
            }
            Console.WriteLine("=====");

            Console.WriteLine("*올림픽 대표선수 명단");
            foreach (object obj in stk)
            {
                Console.WriteLine(obj.ToString());
            }
        }
    }
}
