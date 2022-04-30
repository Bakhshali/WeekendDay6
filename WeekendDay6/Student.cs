using System;
using System.Collections.Generic;
using System.Text;

namespace WeekendDay6
{
    internal class Student
    {
        private int _id;
        private byte _point;
        public int Id { get; }
        public string Fullname { get; set; }
        public byte Point
        {
            get
            {
                return _point;
            }
            set
            {
                if(value < 0 || value > 100)
                {
                    _point = value;
                }
            }
        }

        public Student(string fullname,byte point)
        {
            _id++;
            Id = _id;
            Fullname = fullname;
            Point = point;
        }

        public void StudentInfo()
        {
            Console.WriteLine($"Id: {Id}, Fullname: {Fullname}, Point: {Point}");
        }
    }
}
