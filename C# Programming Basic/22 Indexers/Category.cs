﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_Indexers
{
    internal class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Category(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public void Show()
        {
            Console.WriteLine("id:{0},name:{1}",Id,Name);
        }
    }
}
