﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ilikeswitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("학년을 입력하세요: ");
            int level = int.Parse(Console.ReadLine());
            switch (level)
            {
                case 1:
                    Console.WriteLine("수강해야 하는 전공 학점: 12학점");
                    break;
                case 3:
                    Console.WriteLine("수강해야 하는 전공 학점: 10학점");
                    break;
                case 2:
                case 4:
                    Console.WriteLine("수강해야 하는 전공 학점: 18학점");
                    break;
            }
        }
    }
}
