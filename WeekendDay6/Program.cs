using System;

namespace WeekendDay6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fullname;
            string email;
            string password;
            string groupno;
            int limit;
            string sfullname;
            byte point;



            Group group = null;





            Console.WriteLine("Please enter Fullname");
            fullname = Console.ReadLine();
            Console.WriteLine("Please enter Email");
            email = Console.ReadLine();
            User user = new User(fullname, email);

            do
            {
                Console.WriteLine("Please enter Password");
                password = Console.ReadLine();
            } while (!PasswordChecker(password) || password.Length < 8);

            bool check = true;
            do
            {

                Console.WriteLine("1.ShowInfo");
                Console.WriteLine("2.CreateNewGroup");
                Console.WriteLine("3.Menu");
                int answer = Convert.ToInt32(Console.ReadLine());
                switch (answer)
                {
                    case 1:
                        user.ShowInfo();
                        break;
                    case 2:

                        do
                        {
                            Console.WriteLine("Please enter GroupNo");
                            groupno = Console.ReadLine();

                        } while (Group.CheckGroupNo(groupno));

                        do
                        {
                            Console.WriteLine("Please enter Limit");
                            limit = Convert.ToInt32(Console.ReadLine());
                            Group group1 = new Group(groupno, limit);

                        } while (limit < 5 || limit > 18);

                        break;

                    case 3:

                        Console.WriteLine("1.Show all students");
                        Console.WriteLine("2.Get student by id");
                        Console.WriteLine("3.Add student");
                        Console.WriteLine("4.Quit");
                        do
                        {
                            int answer1 = Convert.ToInt32(Console.ReadLine());
                            switch (answer1)
                            {
                                case 1:

                                    
                                    break;
                                case 3:
                                    Console.WriteLine("Please enter Fullname;");
                                    sfullname = Console.ReadLine();
                                    do
                                    {
                                        Console.WriteLine("Please enter point");
                                        point = Convert.ToByte(Console.ReadLine());
                                        Student student = new Student(sfullname, point);

                                    } while (point < 0 || point > 100);
                                    break;
                                default:
                                    break;
                            }

                        } while (check);

                        break;
                    default:
                        break;
                }

            } while (check);


        }

        public static bool PasswordChecker(string pw)
        {
            bool hasDigit = false;
            bool hasLetter = false;
            bool hasUpper = false;

            if (pw.Length > 8)

                foreach (var item in pw)
                {
                    if (char.IsDigit(item))
                    {
                        hasDigit = true;
                    }
                    if (char.IsLetter(item))
                    {
                        hasLetter = true;
                    }
                    if (char.IsUpper(item))
                    {
                        hasUpper = true;
                    }
                }
            bool result = hasDigit && hasLetter && hasUpper;
            return result;


        }

    }
}
