using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_M2
{
    public class Person3
    {
        private string? field;

        public string Name
        {
            get => field ?? "N/A";//指向Name 隐藏自动生成的name字段
            set => field = value;//指向Name 隐藏自动生成的name字段
        }
        public string Field { 
            get => @field ?? "N/A";//指向类定义的field字段
            set => @field = value;//指向类定义的field字段

        }
    }
}
