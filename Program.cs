using System;
using System.IO;

namespace H.W.Part_1__F21
{
    class Program
    {
        static string path_students = ReadTxt("students");
        static string path_teachers = ReadTxt("teachers");
        static string path_merchants = ReadTxt("merchants");
        static string path_employees = ReadTxt("employees");
        static string path_cars = ReadTxt("cars");
        static string path_houses = ReadTxt("houses");
        static void Main(string[] args)
        {
            Console.WriteLine("\n___________________________________________________________________________________________________________");
            Students();
            Console.WriteLine("\n___________________________________________________________________________________________________________");
            Teachers();
            Console.WriteLine("\n___________________________________________________________________________________________________________");
            Merchants();
            Console.WriteLine("\n___________________________________________________________________________________________________________");
            Employees();
            Console.WriteLine("\n___________________________________________________________________________________________________________");
            Cars();
            Console.WriteLine("\n___________________________________________________________________________________________________________");
            Houses();

            Console.WriteLine("\n____________________________________________________________________________________________________________________________________________________________________________________________________________________");
            SupportedStudents(path_students);
            Console.WriteLine("\n____________________________________________________________________________________________________________________________________________________________________________________________________________________");
            SupportedTeachers(path_teachers);
            Console.WriteLine("\n____________________________________________________________________________________________________________________________________________________________________________________________________________________");
            SupportedMerchants(path_merchants);
            Console.WriteLine("\n____________________________________________________________________________________________________________________________________________________________________________________________________________________");
            SupportedEmployees(path_employees);
            Console.ReadKey();

        }
        static string ReadTxt(string file)
        {
            bool loop = true;
            string path = "";
            do
            {
                try
                {
                    Console.WriteLine("please enter the path of {0} file", file);
                    path = Console.ReadLine();
                    FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                    StreamReader sr = new StreamReader(fs);
                    sr.Close();
                    fs.Close();
                    loop = false;
                }
                catch (FileNotFoundException Fnon)
                {
                    Console.WriteLine(Fnon.Message);
                    Console.WriteLine("Try again......");
                }
            } while (loop);
            return path;
        }
        static void Students()
        {
            FileStream fs_r = new FileStream(path_students, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs_r);

            int index = 1;
            int i = 0;
            string[] accumulation = File.ReadAllLines(path_students);

            Console.WriteLine("\n_____________________________________________________ Students" +
                              " _____________________________________________________\n");

            while (!sr.EndOfStream)
            {
                try
                {
                    string content = sr.ReadLine();   
                    string[] info = content.Split(',');
                    if (info.Length == 6)
                    {
                        Students student = new Students(int.Parse(info[0]), info[1], info[2], int.Parse(info[3]),
                                                        info[4], info[5]);
                        accumulation[i] = student.ToString();
                    }
                    if (info.Length == 5)
                    {
                        Students student = new Students(int.Parse(info[0]), info[1], info[2], int.Parse(info[3]), info[4]);
                        accumulation[i] = student.ToString();
                    }
                    if (info.Length == 4)
                    {
                        Students student = new Students(int.Parse(info[0]), info[1], info[2], int.Parse(info[3]));
                        accumulation[i] = student.ToString();
                    }
                    Console.WriteLine(accumulation[i]);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + ", worng Format in Line number {0}", index);
                }
                i++;
                index++;
            }
            sr.Close();
            fs_r.Close();
        }

        static void Teachers()
        {
            FileStream fs_r = new FileStream(path_teachers, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs_r);

            int index = 1;
            int i = 0;
            string[] accumulation = File.ReadAllLines(path_teachers);

            Console.WriteLine("\n_____________________________________________________ Teachers" +
                              " _____________________________________________________\n");

            while (!sr.EndOfStream)
            {
                try
                {
                    string content = sr.ReadLine();  
                    string[] info = content.Split(',');
                    if (info.Length == 6)
                    {
                        Teachers teacher = new Teachers(int.Parse(info[0]), info[1], info[2], int.Parse(info[3]),
                                                        info[4], info[5]);
                        accumulation[i] = teacher.ToString();
                    }
                    if (info.Length == 5)
                    {
                        Teachers teacher = new Teachers(int.Parse(info[0]), info[1], info[2], int.Parse(info[3]), info[4]);
                        accumulation[i] = teacher.ToString();
                    }
                    if (info.Length == 4)
                    {
                        Teachers teacher = new Teachers(int.Parse(info[0]), info[1], info[2], int.Parse(info[3]));
                        accumulation[i] = teacher.ToString();
                    }
                    Console.WriteLine(accumulation[i]);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + ", worng Format in Line number {0}", index);
                }
                i++;
                index++;
            }
            sr.Close();
            fs_r.Close();
        }
        static void Merchants()
        {
            FileStream fs_r = new FileStream(path_merchants, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs_r);

            int index = 1;
            int i = 0;
            string[] accumulation = File.ReadAllLines(path_merchants);

            Console.WriteLine("\n_____________________________________________________ Merchants" +
                              " _____________________________________________________\n");

            while (!sr.EndOfStream)
            {
                try
                {
                    string content = sr.ReadLine();   
                    string[] info = content.Split(',');
                    if (info.Length == 6)
                    {
                        Merchants merchant = new Merchants(int.Parse(info[0]), info[1], info[2], int.Parse(info[3]),
                                                        info[4], info[5]);
                        accumulation[i] = merchant.ToString();
                    }
                    if (info.Length == 5)
                    {
                        Merchants merchant = new Merchants(int.Parse(info[0]), info[1], info[2], int.Parse(info[3]), info[4]);
                        accumulation[i] = merchant.ToString();
                    }
                    if (info.Length == 4)
                    {
                        Merchants merchant = new Merchants(int.Parse(info[0]), info[1], info[2], int.Parse(info[3]));
                        accumulation[i] = merchant.ToString();
                    }
                    Console.WriteLine(accumulation[i]);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + ", worng Format in Line number {0}", index);
                }
                i++;
                index++;
            }
            sr.Close();
            fs_r.Close();
        }

        static void Employees()
        {
            FileStream fs_r = new FileStream(path_employees, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs_r);

            int index = 1;
            int i = 0;
            string[] accumulation = File.ReadAllLines(path_employees);

            Console.WriteLine("\n_____________________________________________________ Employees" +
                              " _____________________________________________________\n");

            while (!sr.EndOfStream)
            {
                try
                {
                    string content = sr.ReadLine();  
                    string[] info = content.Split(',');
                    if (info.Length == 6)
                    {
                        Employees employee = new Employees(int.Parse(info[0]), info[1], info[2], int.Parse(info[3]),
                                                        info[4], info[5]);
                        accumulation[i] = employee.ToString();
                    }
                    if (info.Length == 5)
                    {
                        Employees employee = new Employees(int.Parse(info[0]), info[1], info[2], int.Parse(info[3]), info[4]);
                        accumulation[i] = employee.ToString();
                    }
                    if (info.Length == 4)
                    {
                        Employees employee = new Employees(int.Parse(info[0]), info[1], info[2], int.Parse(info[3]));
                        accumulation[i] = employee.ToString();
                    }
                    Console.WriteLine(accumulation[i]);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + ", worng Format in Line number {0}", index);
                }
                i++;
                index++;
            }
            sr.Close();
            fs_r.Close();
        }

        static void Cars()
        {
            FileStream fs_r = new FileStream(path_cars, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs_r);

            int index = 1;
            int i = 0;
            string[] accumulation = File.ReadAllLines(path_cars);

            Console.WriteLine("\n_____________________________________________________ Cars" +
                              " _____________________________________________________\n");

            while (!sr.EndOfStream)
            {
                try
                {
                    string content = sr.ReadLine();   
                    string[] info = content.Split(',');
                    Cars car = new Cars(int.Parse(info[0]), info[1], int.Parse(info[2]), int.Parse(info[3]));
                    accumulation[i] = car.ToString();
                    Console.WriteLine(accumulation[i]);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + ", worng Format in Line number {0}", index);
                }
                i++;
                index++;
            }
            sr.Close();
            fs_r.Close();
        }
        static void Houses()
        {
            FileStream fs_r = new FileStream(path_houses, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs_r);

            int index = 1;
            int i = 0;
            string[] accumulation = File.ReadAllLines(path_houses);

            Console.WriteLine("\n_____________________________________________________ Houses" +
                              " _____________________________________________________\n");

            while (!sr.EndOfStream)
            {
                try
                {
                    string content = sr.ReadLine();   
                    string[] info = content.Split(',');
                    Houses houses = new Houses(int.Parse(info[0]), int.Parse(info[1]), info[2]);
                    accumulation[i] = houses.ToString();
                    Console.WriteLine(accumulation[i]);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + ", worng Format in Line number {0}", index);
                }
                i++;
                index++;
            }
            sr.Close();
            fs_r.Close();
        }





        static void SupportedStudents(string path)
        {
            FileStream fs_r = new FileStream(path, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs_r);

            int index = 1;
            int i = 0;
            string[] accumulation = File.ReadAllLines(path);
            bool supported = true;
            string reason = "";
            bool consequence;

            Console.WriteLine("\n______________________________________________________________________________________ " +
                              "_____________ Supported Students _____________" +
                              " ______________________________________________________________________________________\n");

            while (!sr.EndOfStream)
            {
                try
                {
                    string content = sr.ReadLine();
                    string[] info = content.Split(',');
                    if (info.Length == 6)
                    {
                        Students student = new Students(int.Parse(info[0]), info[1], info[2], int.Parse(info[3]),
                                                        info[4], info[5]);
                        accumulation[i] = student.ToString();

                        string[] infoHouses = info[5].Split(' ');
                        string[] infoCars = info[4].Split(' ');

                        if (infoHouses.Length > 2)
                        {
                            supported = false;
                            reason = " -has more then one house ";
                        }
                        if (info[4] != " -1" && infoCars.Length > 2)
                        {
                            supported = false;
                            reason += " -has more then one car ";
                        }
                        if (info[4] != " -1" && int.Parse(info[3]) < 4)
                        {
                            supported = false;
                            reason += " -has car and house, less than 4 year ";
                        }
                        if (info[4] != " -1")
                        {
                            consequence = CarSupport(info[4]);
                            if (!consequence)
                            {
                                supported = false;
                                reason = " has a car engine capacity is grater 2200 than ";
                            }
                        }
                        consequence = HouseSupport(info[5]);
                        if (!consequence)
                        {
                            supported = false;
                            reason = " has a house engine Size is grater 300 than ";
                        }
                    }
                    if (info.Length == 5)
                    {
                        Students student = new Students(int.Parse(info[0]), info[1], info[2], int.Parse(info[3]), info[4]);
                        accumulation[i] = student.ToString();

                        string[] infoCars = info[4].Split(' ');

                        if (infoCars.Length > 2)
                        {
                            supported = false;
                            reason = " -has more then one car ";
                        }
                        consequence = CarSupport(info[4]);
                        if (!consequence)
                        {
                            supported = false;
                            reason = " has a car engine capacity is grater 2200 than ";
                        }
                    }
                    if (info.Length == 4)
                    {
                        Students student = new Students(int.Parse(info[0]), info[1], info[2], int.Parse(info[3]));
                        accumulation[i] = student.ToString();
                    }
                    string result = (supported) ? "Supported" : "Not Supported";
                    string cause = (supported) ? " none of the conditions were met " : reason;
                    Console.WriteLine(result + "  // Reason:" + cause + "//    " + accumulation[i]);
                    supported = true;
                    reason = "";
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + ", worng Format in Line number {0}", index);
                }
                i++;
                index++;
            }
            sr.Close();
            fs_r.Close();
        }

        static void SupportedTeachers(string path)
        {
            FileStream fs_r = new FileStream(path, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs_r);

            int index = 1;
            int i = 0;
            string[] accumulation = File.ReadAllLines(path);
            bool supported = true;
            string reason = "";
            bool consequence;

            Console.WriteLine("\n______________________________________________________________________________________ " +
                              "_____________ Supported Teachers _____________" +
                              " ______________________________________________________________________________________\n");

            while (!sr.EndOfStream)
            {
                try
                {
                    string content = sr.ReadLine();
                    string[] info = content.Split(',');
                    if (info.Length == 6)
                    {
                        Teachers teacher = new Teachers(int.Parse(info[0]), info[1], info[2], int.Parse(info[3]),
                                                                                info[4], info[5]);
                        accumulation[i] = teacher.ToString();

                        string[] infoHouses = info[5].Split(' ');
                        string[] infoCars = info[4].Split(' ');

                        if (infoHouses.Length > 2)
                        {
                            supported = false;
                            reason = " -has more then one house ";
                        }
                        if (info[4] != " -1" && infoCars.Length > 2)
                        {
                            supported = false;
                            reason += " -has more then one car ";
                        }
                        if (info[4] != " -1" && int.Parse(info[3]) > 20)
                        {
                            supported = false;
                            reason += " -has car and house, over then 20 experience ";
                        }
                        if (info[4] != " -1")
                        {
                            consequence = CarSupport(info[4]);
                            if (!consequence)
                            {
                                supported = false;
                                reason = " has a car engine capacity is grater 2200 than ";
                            }
                        }
                        consequence = HouseSupport(info[5]);
                        if (!consequence)
                        {
                            supported = false;
                            reason = " has a house engine Size is grater 300 than ";
                        }
                    }
                    if (info.Length == 5)
                    {
                        Teachers teacher = new Teachers(int.Parse(info[0]), info[1], info[2], int.Parse(info[3]), info[4]);
                        accumulation[i] = teacher.ToString();
                        string[] infoCars = info[4].Split(' ');
                        if (infoCars.Length > 2)
                        {
                            supported = false;
                            reason += " -has more then one car ";
                        }
                        consequence = CarSupport(info[4]);
                        if (!consequence)
                        {
                            supported = false;
                            reason = " has a car engine capacity is grater 2200 than ";
                        }
                    }
                    if (info.Length == 4)
                    {
                        Teachers teacher = new Teachers(int.Parse(info[0]), info[1], info[2], int.Parse(info[3]));
                        accumulation[i] = teacher.ToString();
                    }
                    string result = (supported) ? "Supported" : "Not Supported";
                    string cause = (supported) ? " none of the conditions were met " : reason;
                    Console.WriteLine(result + "  // Reason:" + cause + "//    " + accumulation[i]);
                    supported = true;
                    reason = "";
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + ", worng Format in Line number {0}", index);
                }
                i++;
                index++;
            }
            sr.Close();
            fs_r.Close();
        }

        static void SupportedMerchants(string path)
        {
            FileStream fs_r = new FileStream(path, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs_r);

            int index = 1;
            int i = 0;
            string[] accumulation = File.ReadAllLines(path);
            bool supported = true;
            string reason = "";
            bool consequence;

            Console.WriteLine("\n______________________________________________________________________________________ " +
                              "_____________ Supported Merchants _____________" +
                              " ______________________________________________________________________________________\n");

            while (!sr.EndOfStream)
            {
                try
                {
                    string content = sr.ReadLine();
                    string[] info = content.Split(',');
                    if (info.Length == 6)
                    {
                        Merchants merchant = new Merchants(int.Parse(info[0]), info[1], info[2], int.Parse(info[3]),
                                                                                info[4], info[5]);
                        accumulation[i] = merchant.ToString();

                        string[] infoHouses = info[5].Split(' ');
                        string[] infoCars = info[4].Split(' ');

                        if (infoHouses.Length > 2)
                        {
                            supported = false;
                            reason = " -has more then one house ";
                        }
                        if (info[4] != " -1" && infoCars.Length > 2)
                        {
                            supported = false;
                            reason += " -has more then one car ";
                        }
                        if (info[4] != " -1" && int.Parse(info[3]) > 1000000)
                        {
                            supported = false;
                            reason += " -has car and house, over then 1000000 income ";
                        }
                        if (info[4] != " -1")
                        {
                            consequence = CarSupport(info[4]);
                            if (!consequence)
                            {
                                supported = false;
                                reason = " has a car engine capacity is grater 2200 than ";
                            }
                        }
                        consequence = HouseSupport(info[5]);
                        if (!consequence)
                        {
                            supported = false;
                            reason = " has a house engine Size is grater 300 than ";
                        }
                    }
                    if (info.Length == 5)
                    {
                        Merchants merchant = new Merchants(int.Parse(info[0]), info[1], info[2], int.Parse(info[3]), info[4]);
                        accumulation[i] = merchant.ToString();
                        string[] infoCars = info[4].Split(' ');
                        if (infoCars.Length > 2)
                        {
                            supported = false;
                            reason += " -has more then one car ";
                        }
                        consequence = CarSupport(info[4]);
                        if (!consequence)
                        {
                            supported = false;
                            reason = " has a car engine capacity is grater 2200 than ";
                        }
                    }
                    if (info.Length == 4)
                    {
                        Merchants merchant = new Merchants(int.Parse(info[0]), info[1], info[2], int.Parse(info[3]));
                        accumulation[i] = merchant.ToString();
                    }
                    string result = (supported) ? "Supported" : "Not Supported";
                    string cause = (supported) ? " none of the conditions were met " : reason;
                    Console.WriteLine(result + "  // Reason:" + cause + "//    " + accumulation[i]);
                    supported = true;
                    reason = "";
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + ", worng Format in Line number {0}", index);
                }
                i++;
                index++;
            }
            sr.Close();
            fs_r.Close();
        }

        static void SupportedEmployees(string path)
        {
            FileStream fs_r = new FileStream(path, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs_r);

            int index = 1;
            int i = 0;
            string[] accumulation = File.ReadAllLines(path);
            bool supported = true;
            string reason = "";
            bool consequence;

            Console.WriteLine("\n______________________________________________________________________________________ " +
                              "_____________ Supported Employees _____________" +
                              " ______________________________________________________________________________________\n");

            while (!sr.EndOfStream)
            {
                try
                {
                    string content = sr.ReadLine();
                    string[] info = content.Split(',');
                    if (info.Length == 6)
                    {
                        Employees employee = new Employees(int.Parse(info[0]), info[1], info[2], int.Parse(info[3]),
                                                                                info[4], info[5]);
                        accumulation[i] = employee.ToString();

                        string[] infoHouses = info[5].Split(' ');
                        string[] infoCars = info[4].Split(' ');

                        if (infoHouses.Length > 2)
                        {
                            supported = false;
                            reason = " -has more then one house ";
                        }
                        if (info[4] != " -1" && infoCars.Length > 2)
                        {
                            supported = false;
                            reason += " -has more then one car ";
                        }
                        if (info[4] != " -1" && int.Parse(info[3]) > 1500000)
                        {
                            supported = false;
                            reason += " -has car and house, over then 1500000 salary ";
                        }
                        if (info[4] != " -1")
                        {
                            consequence = CarSupport(info[4]);
                            if (!consequence)
                            {
                                supported = false;
                                reason = " has a car engine capacity is grater 2200 than ";
                            }
                        }
                        consequence = HouseSupport(info[5]);
                        if (!consequence)
                        {
                            supported = false;
                            reason = " has a house engine Size is grater 300 than ";
                        }
                    }
                    if (info.Length == 5)
                    {
                        Employees employee = new Employees(int.Parse(info[0]), info[1], info[2], int.Parse(info[3]), info[4]);
                        accumulation[i] = employee.ToString();
                        string[] infoCars = info[4].Split(' ');
                        if (infoCars.Length > 2)
                        {
                            supported = false;
                            reason += " -has more then one car ";
                        }
                        consequence = CarSupport(info[4]);
                        if (!consequence)
                        {
                            supported = false;
                            reason = " has a car engine capacity is grater 2200 than ";
                        }
                    }
                    if (info.Length == 4)
                    {
                        Employees employee = new Employees(int.Parse(info[0]), info[1], info[2], int.Parse(info[3]));
                        accumulation[i] = employee.ToString();
                    }
                    string result = (supported) ? "Supported" : "Not Supported";
                    string cause = (supported) ? " none of the conditions were met " : reason;
                    Console.WriteLine(result + "  // Reason:" + cause + "//    " + accumulation[i]);
                    supported = true;
                    reason = "";
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + ", worng Format in Line number {0}", index);
                }
                i++;
                index++;
            }
            sr.Close();
            fs_r.Close();
        }

        static bool CarSupport(string idCar)
        {
            FileStream fs_r = new FileStream(path_cars, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs_r);
            int i = 1;
            bool find = false;
            bool result = true;

            while (!find)
            {
                string content = sr.ReadLine();
                string[] info = content.Split(',');
                string[] infoCar = idCar.Split(' ');
                Cars car = new Cars(int.Parse(info[0]), info[1], int.Parse(info[2]), int.Parse(info[3]));
                if(infoCar[i] == info[0])
                {
                    if (int.Parse(info[3]) >= 2200) result = false;
                    find = true;
                    i++;
                }
            } 
            sr.Close();
            fs_r.Close();
            return result;
        }
        
        static bool HouseSupport(string idHouses)
        {
            FileStream fs_r = new FileStream(path_houses, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs_r);
            int i = 1;
            bool find = false;
            bool result = true;

            while (!find)
            {
                string content = sr.ReadLine();
                string[] info = content.Split(',');
                string[] infohouse = idHouses.Split(' ');
                Houses houses = new Houses(int.Parse(info[0]), int.Parse(info[1]), info[2]);
                if (infohouse[i] == info[0])
                {
                    if (int.Parse(info[1]) >= 300) result = false;
                    find = true;
                    i++;
                }
            }
            sr.Close();
            fs_r.Close();
            return result;
        }
    }
}
