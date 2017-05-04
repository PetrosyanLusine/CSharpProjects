﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProjectCafe
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> Users = new List<User>();
            List<Cafe> cafes = new List<Cafe>();
            StreamReader reader;
            StreamWriter writer;
            using (reader = new StreamReader("Users.txt"))
            {
                String line;
                while ((line = reader.ReadLine()) != null)
                {
                    String[] linearr = line.Split(' ');
                    Users.Add(new User(linearr[0], linearr[1], Convert.ToInt32(linearr[2]), linearr[3]));
                }
                reader.Close();
            }
            using (reader = new StreamReader("Cafes.txt"))
            {
                String line;
                while ((line = reader.ReadLine()) != null)
                {
                    String[] linearr = line.Split(' ');
                    String[] Open= {linearr[8],linearr[9],linearr[10],linearr[11],linearr[12],linearr[13],linearr[14]};
                    String[] Close= {linearr[15],linearr[16],linearr[17],linearr[18],linearr[19],linearr[20],linearr[21]};
                    cafes.Add(new Cafe(linearr[0],new Address(linearr[1],linearr[2],linearr[3],linearr[4],Convert.ToDouble(linearr[5]),Convert.ToDouble(linearr[6])),linearr[7],new Open_Close(Open,Close),linearr[22],linearr[23],linearr[24],Convert.ToInt32(linearr[25])));
                }
                reader.Close();
            }
            String[] open = {
                                "7:05",
                                "7:30",
                                "7:30",
                                "7:30",
                                "7:30",
                                "9:00",
                                "9:30"
                            };
            String[] close = {
                                "22:35",
                                "22:30",
                                "22:30",
                                "22:30",
                                "22:30",
                                "23:00",
                                "23:30"
                            };
            Open_Close hours1 = new Open_Close(open, close);

            Cafe cafe1 = new Cafe("Jose", new Address("Aram", "28", "Yerevan", "Armenia", 40.17506970913358, 44.519750475883484), "091540020", hours1, "Restaurant", "jose.am", optionalRestrictionAge: 18);
            Cafe cafe2 = new Cafe("Aeon", new Address("Teryan", "3", "Yerevan", "Armenia", 40.18178325626785, 44.5125675201416), "010538766", hours1, "Cafe", "aeonyerevan.com");
            Cafe cafe3 = new Cafe("Havana", new Address("Leningradyan", "1/6", "Yerevan", "Armenia", 40.19033280000001, 44.48103570000001), "010380606", hours1, "Restaurant", "havana.am", optionalRestrictionAge: 14);
            Cafe cafe10 = new Cafe("Cinnabon", new Address("Northern ave", "8", "Yerevan", "Armenia", 40.182053751571125, 44.51447993516922), "010433535", new Open_Close(open, close), "cafe", "cinnabon.am", optionalRestrictionAge: 18);
            Cafe cafe11 = new Cafe("La Piazza", new Address("Northern ave", "10", "Yerevan", "Armenia", 40.18187751990506, 44.514833986759186), "010434343", new Open_Close(open, close), "cafe", "lapizza.am", optionalRestrictionAge: 15);
            //User user1 = new User("Lusine", "Petrosyan", 18, "lusinecfc1@gmail.com");
            //User user2 = new User("Khachatur", "Khechoyan", 5, "khachatur1998@mail.ru");
            //User user3 = new User("Ragnar", "Lothbrock", 30, "RagnarL@mail.ru");
            //User user4 = new User("Crocodile", "Gena", 14, "Gena2003@mail.ru");
            //User user5 = new User("Holden", "Caulfield", 16, "TheCatcher@gmail.com");
            //User user10 = new User("Bob", "Marley", 98, "BobMarley@gmail.com");
            //User user11 = new User("Emin", "Davidov", 40, "EminDav@gmail.com");
            //User user12 = new User("Lusine", "Petrosyan", 4, "lusinecfc1@gmail.com");
            //User user13 = new User("Tigran", "Jamkochyan", 43, "tikorabiz@gmail.com");
            //User user14 = new User("Jor", "Dilbaryan", 56, "jorikjorik@gmail.com");

            ////cafe1.Visit(user13);
            ////cafe11.Visit(user3);
            ////cafe11.Visit(user1);
            ////cafe10.Visit(user2);

            //cafe1.AddNewReview(new Review(user1, DateTime.Parse("10 / 01 / 1999"), "Very Good!", 5));
            //cafe1.AddNewReview(new Review(user2, DateTime.Parse("10 / 01 / 1999"), "Normal!", 4));
            //cafe1.AddNewReview(new Review(user11, DateTime.Parse("10/01/1987"), "BAD!", 2));

            ////cafe1.PrintAllReviews();
            ////cafe1.PrintAverageRate();
            ////cafe1.PrintTimeTable();

            //user1.SaveCafe(cafe1);
            //user1.SaveCafe(cafe11);
            //user1.SaveCafe(cafe10);

            //Users.Add(user1);
            //Users.Add(user2);
            //Users.Add(user3);
            //Users.Add(user4);
            //Users.Add(user5);
            //Users.Add(user10);
            //Users.Add(user11);
            //Users.Add(user12);
            //Users.Add(user13);
            //Users.Add(user14);

            ////user1.PrintFavoriteCafes();

            //cafes.Add(cafe1);
            //cafes.Add(cafe2);
            //cafes.Add(cafe3);
            //cafes.Add(cafe10);
            //cafes.Add(cafe11);
            //cafes.Sort();
            ////for (int i = 0; i < cafes.Count; i++)
            ////{
            ////    Console.WriteLine(cafes[i]);
            ////}
            ////string line;
            ////try {
            ////    while ((line=reader.ReadLine())!= null)
            ////    {
            ////        String[] info = line.Split(' ');
            ////        Users.Add(new User(info[0],info[1],Convert.ToInt32(info[2]),info[3]));
            ////    }
            ////}
            ////    catch{
            ////    }
            while (true)
            {
                z:
                Console.WriteLine("Welcome!");
                Console.WriteLine("Choose what you want to do.");
                Console.WriteLine();
                Console.WriteLine("1.Create new User");
                Console.WriteLine("2.Create new Cafe");
                Console.WriteLine("3.Show list of Cafes");
                Console.WriteLine("4.Show list of Users");
                Console.WriteLine();
                String l = Console.ReadLine();
                Console.WriteLine();
                switch (l)
                {
                    case "1":
                        while (true){
                            Console.WriteLine("Enter User's Name");
                            string userName = Console.ReadLine();
                            Console.WriteLine();
                            Console.WriteLine("Enter User's Surname");
                            string userSurname = Console.ReadLine();
                            Console.WriteLine();
                            Console.WriteLine("Enter User's Age");
                            int age;
                            while (true)
                            {
                                try
                                {
                                    age = Convert.ToInt32(Console.ReadLine());
                                    break;
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Invalid age! Please try again!");
                                    Console.WriteLine();
                                }
                            }
                            Console.WriteLine();
                            Console.WriteLine("Enter User's Mail");
                            string userMail = Console.ReadLine();
                            Console.WriteLine();
                            Console.WriteLine("User have successfully been created!");
                            Console.WriteLine();

                            using (writer = new StreamWriter("Users.txt", true))
                            {
                                writer.Write(userName + " " + userSurname + " " + age + " " + userMail + "\r\n");
                                writer.Flush();
                                writer.Close();
                            }
                            try
                            {
                                Users.Add(new User(userName, userSurname, age, userMail));
                                break;
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Error,Try again");
                            }
                            
                        }
                        break;
                    case "2":
                        Console.WriteLine("Enter Cafe's Name");
                        string cafeName = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine("Enter street name");
                        string streetName = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine("Enter street num");
                        string streetNum = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine("Enter city");
                        string city = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine("Enter country");
                        string country = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine("Enter latitude");
                        double latitude;
                        while (true)
                        {
                            try
                            {
                                latitude = Convert.ToDouble(Console.ReadLine());
                                break;
                            }
                            catch (Exception)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Invalid latitude! Please try again!");
                                Console.WriteLine();
                            }
                        }
                        Console.WriteLine();
                        Console.WriteLine("Enter longitude");
                        double longitude;
                        while (true)
                        {
                            try
                            {
                                longitude = Convert.ToDouble(Console.ReadLine());
                                break;
                            }
                            catch (Exception)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Invalid longitude! Please try again!");
                                Console.WriteLine();
                            }
                        }
                        Console.WriteLine();
                        Console.WriteLine("Enter phone number");
                        string phoneNumber = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine("Enter Hours of opening (in one line, 23:59 format)");
                        String[] opentime = new String[7];

                        opentime = Console.ReadLine().Split(' ');
                        Console.WriteLine();

                        Console.WriteLine("Enter Hours of closing (in one line, 23:59 format)");
                        String[] closetime = new String[7];

                        closetime = Console.ReadLine().Split(' ');
                        Console.WriteLine();
                        Console.WriteLine("Enter type(cafe, bar...)");
                        string type = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine("Enter website");
                        string webSite = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine("Write description");
                        string description = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine("Enter Restriction Age");
                        int RestrictionAge;
                        while (true)
                        {
                            try
                            {
                                RestrictionAge = Convert.ToInt32(Console.ReadLine());
                                break;
                            }
                            catch (Exception)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Invalid age! Please try again!");
                                Console.WriteLine();
                            }
                        }

                        Console.WriteLine();
                        Console.WriteLine("Cafe have successfully been created!");
                        Console.WriteLine();
                        cafes.Add(new Cafe(cafeName, new Address(streetName, streetNum, city, country, latitude, longitude), phoneNumber, new Open_Close(open, close), type, webSite, description, RestrictionAge));
                        using (writer = new StreamWriter("Cafes.txt",true))
                        {
                            writer.Write(cafeName + " " + streetName + " " + streetNum + " " + city + " " + country + " " + latitude + " " + longitude + " " + phoneNumber + " ");
                            for (int i = 0; i < 7; i++)
                            {
                                writer.Write(opentime[i] + " ");
                            }
                            for (int i = 0; i < 7; i++)
                            {
                                writer.Write(closetime[i] + " ");
                            }
                            writer.Write(type + " " + webSite + " " + "." + " " + RestrictionAge + "\r\n");
                            writer.Flush();
                            writer.Close();
                        }
                        break;
                    case "3":
                        Console.WriteLine("Choose cafe");
                        Console.WriteLine();
                        for (int i = 0; i < cafes.Count; i++)
                        {
                            Console.Write(i + 1 + ".");
                            Console.WriteLine(cafes[i].Name);
                        }
                        Console.WriteLine(cafes.Count+1 + ".Exit To Main Menu");
                        Console.WriteLine();
                        string c;

                        while (true)
                        {
                            c = Console.ReadLine();
                            try
                            {
                                if (Convert.ToInt32(c) > cafes.Count+1 || Convert.ToInt32(c) <= 0)
                                {
                                    Console.WriteLine("Error! Invalid number!");
                                }
                                else
                                    break;
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Error! Invalid number!");
                            }
                        }
                        if (Convert.ToInt32(c) == (cafes.Count+1))
                        {
                            goto z;
                        }
                        Console.WriteLine();
                        Console.WriteLine(cafes[int.Parse(c) - 1].ToString());
                        Console.WriteLine();
                        while (true)
                        {
                            Console.WriteLine("1.Show nearby cafes");
                            Console.WriteLine("2.Show Reviewes");
                            Console.WriteLine("3.Print Average rate");
                            Console.WriteLine("4.Add Review");
                            Console.WriteLine("5.Visit");
                            Console.WriteLine("6.Print Timetable");
                            Console.WriteLine("7.Distance From");
                            Console.WriteLine("8.Exit to main menu");
                            string k = Console.ReadLine();
                            Console.WriteLine();
                            switch (k)
                            {
                                case "1":
                                    cafes[Convert.ToInt32(c) - 1].Nearby(cafes);
                                    Console.WriteLine();
                                    break;
                                case "2":
                                    cafes[Convert.ToInt32(c) - 1].PrintAllReviews();
                                    Console.WriteLine();
                                    break;
                                case "3":
                                    cafes[Convert.ToInt32(c) - 1].PrintAverageRate();
                                    Console.WriteLine();
                                    break;
                                case "4":
                                    Console.WriteLine();
                                    for (int i = 0; i < Users.Count; i++)
                                    {
                                        Console.Write(i + 1 + ".");
                                        Console.WriteLine(Users[i]);
                                    }
                                    string q;
                                    while (true)
                                    {
                                        q = Console.ReadLine();
                                        try
                                        {
                                            if (Convert.ToInt32(q) > Users.Count || Convert.ToInt32(q) <= 0)
                                            {
                                                Console.WriteLine("Error! Invalid number!");
                                            }
                                            else
                                                break;
                                        }
                                        catch (Exception)
                                        {
                                            Console.WriteLine("Error! Invalid number!");
                                        }
                                    }
                                    Console.WriteLine("Write Your Oppinion");
                                    String op = Console.ReadLine();
                                    Console.WriteLine();
                                    Console.WriteLine("Write Rate (0-5)");
                                    String ra = Console.ReadLine();
                                    while (true)
                                    {
                                        try
                                        {
                                            if (Convert.ToInt32(ra) > 5 || Convert.ToInt32(ra) < 0)
                                            {
                                                Console.WriteLine("Invalid number! Please try again!");
                                            }
                                            else
                                                goto gt;
                                        }
                                        catch
                                        {
                                            Console.WriteLine("Invalid number! Please try again!");
                                        }
                                    }
                                gt:
                                    cafes[Convert.ToInt32(c) - 1].AddNewReview(new Review(Users[Convert.ToInt32(q) - 1], DateTime.Now, op, Convert.ToInt32(ra)));
                                    break;
                                case "8":
                                    goto x;
                                default:
                                    Console.WriteLine("Invalid number!Please try again!");
                                    Console.WriteLine();
                                    break;
                            }
                        }
                    x:
                        break;
                    case "4":
                        for (int i = 0; i < Users.Count; i++)
                        {
                            Console.Write(i + 1 + ".");
                            Console.WriteLine(Users[i]);
                        }
                        Console.WriteLine(Users.Count+1 +"."+ "Exit To Main Menu");
                        string u;
                        while (true)
                        {
                            u = Console.ReadLine();
                            try
                            {
                                if (Convert.ToInt32(u) > Users.Count+1 || Convert.ToInt32(u) <= 0)
                                {
                                    Console.WriteLine("Error! Invalid number!");
                                }
                                else
                                    break;
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Error! Invalid number!");
                            }
                        }
                        if (Convert.ToInt32(u) == (Users.Count + 1))
                        {
                            goto z;
                        }
                        Console.WriteLine();
                        Console.WriteLine(Users[Convert.ToInt32(u) - 1]);
                        Console.WriteLine();
                        while (true)
                        {
                            Console.WriteLine("1.Save Cafe");
                            Console.WriteLine("2.Favorite Cafes");
                            Console.WriteLine("3.Exit To Main Menu");
                            Console.WriteLine();
                            String z = Console.ReadLine();
                            switch (z)
                            {
                                case "1":
                                    Console.WriteLine("Choose cafe");
                                    for (int i = 0; i < cafes.Count; i++)
                                    {
                                        Console.Write(i + 1);
                                        Console.WriteLine(cafes[i]);
                                    }
                                    string m;
                                    while (true)
                                    {
                                        m = Console.ReadLine();
                                        try
                                        {
                                            if (Convert.ToInt32(m) > cafes.Count || Convert.ToInt32(m) <= 0)
                                            {
                                                Console.WriteLine("Error! Invalid number!");
                                            }
                                            else
                                                break;
                                        }
                                        catch (Exception)
                                        {
                                            Console.WriteLine("Error! Invalid number!");
                                        }
                                    }
                                    if (!Users[Convert.ToInt32(u) - 1].favoriteCafes.Contains(cafes[Convert.ToInt32(m) - 1]))
                                        Users[Convert.ToInt32(u) - 1].favoriteCafes.Add(cafes[Convert.ToInt32(m) - 1]);
                                    break;
                                case "2":
                                    foreach (var item in Users[Convert.ToInt32(u) - 1].favoriteCafes)
                                    {
                                        Console.WriteLine(item);
                                    }
                                    break;
                                case "3":
                                    goto p;
                            }
                        }
                    p:
                        break;
                    default:
                        Console.WriteLine("Invalid number! Please try again!");
                        break;
                }

            }

        }
        public List<Cafe> SearchByName(String Name, List<Cafe> Cafes)
        {
            List<Cafe> list = new List<Cafe>();
            for (int i = 0; i < Cafes.Count; i++)
            {
                if (Cafes[i].Name.Contains(Name))
                {
                    list.Add(Cafes[i]);
                }
            }
            return list;
        }
    }
}
