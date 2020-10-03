using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace FillUnknown
{
    public class Person
    {
        public int gender;
        public int height;
        public int weight;
        
        public Person(int gender, int height, int weight)
        {
            this.gender = gender;
            this.height = height;
            this.weight = weight;
        }
    }
}
