using System;
using System.Collections.Generic;
using System.Text;

namespace WeekendDay6
{
    internal class Group
    {
        private Student[] students = new Student[0];

        public string GroupNo { get; set; }

        private int _limit;

        public int StudentLimit
        {
            get
            {
                return _limit;
            }
            set
            {
                if(value > 5 || value < 18)
                {
                    _limit = value;
                }
            }
        }

        

        public static bool CheckGroupNo(string groupno)
        {
            bool hasUpper = false;
            bool hasDigit = false;
            
            if(groupno.Length == 5)
            {
                foreach (var item in groupno)
                {
                    if (char.IsUpper(item))
                    {
                        hasUpper = true;
                    }
                    if (char.IsDigit(item))
                    {
                        hasDigit = true;
                    }
                }

            }
            bool result = hasDigit && hasUpper;
            return result;

        }

       public void AddStudent(Student student)
        {

            if(students.Length == StudentLimit)
            {
                Array.Resize(ref students, students.Length + 1);
                students[students.Length - 1] = student;
            }
        }

        public string GetStudent(int?id)
        {
            foreach (var item in students)
            {
                if(item.Id == id)
                {
                    return item.ToString();
                }
            }
            return null;
           
        }

        public  Student [] getAllStudents()
        {


            return students;
        }

        public Group(string groupno,int slimit)
        {
            GroupNo = groupno;
            StudentLimit = slimit;
        }

      
        

    }
}
