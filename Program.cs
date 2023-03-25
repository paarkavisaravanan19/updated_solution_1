using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace solution_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "";
            string a1 = "";
            do { 
            Console.WriteLine("Press 1 or 2 or 3");
            
            int num = Convert.ToInt32(Console.ReadLine());
            
                switch (num)
                {
                    case 1:
                            Console.WriteLine(" Be a Mentalist ");
                            string ques1 = "Have you experienced any kind of change, loss, or trauma recently? Yes or No";
                            Console.WriteLine(ques1);
                            string ans1 = Console.ReadLine();
                            string ques2 = "Have you experienced a loss of interest in normal activities such as hobbies or sports? Yes or No";
                            Console.WriteLine(ques2);
                            string ans2 = Console.ReadLine();
                            if ((string.Equals(ans1, "Yes") || string.Equals(ans1, "yes") || string.Equals(ans1, "YES")) && (string.Equals(ans2, "Yes") || string.Equals(ans2, "yes") || string.Equals(ans2, "YES")))
                            {
                                Console.WriteLine("you are mentally stable, The harder you work the better you get!");
                            }
                            else if ((string.Equals(ans1, "Yes") || string.Equals(ans1, "yes") || string.Equals(ans1, "YES")) && (string.Equals(ans2, "No") || string.Equals(ans2, "no") || string.Equals(ans2, "NO")))
                            {
                                Console.WriteLine("you look mentally unstable! everything will be fine soon! All your worries will get vanish one day");
                            }
                            else if ((string.Equals(ans1, "No") || string.Equals(ans1, "no") || string.Equals(ans1, "NO")) && (string.Equals(ans2, "No") || string.Equals(ans2, "no") || string.Equals(ans2, "NO")))
                            {
                                Console.WriteLine("you are mentally unstable! Whatever happens don't stress");
                            }
                            else if ((string.Equals(ans1, "No") || string.Equals(ans1, "no") || string.Equals(ans1, "NO")) && (string.Equals(ans2, "Yes") || string.Equals(ans2, "yes") || string.Equals(ans2, "YES")))
                            {
                                Console.WriteLine("you look somrthing disturbed, Push yourself, because no one else is going to do it for you!");

                            }
                            else
                            {
                                Console.WriteLine("please enter your answer in specified format!");
                            }
                            
                        break;
                    case 2:
                        Console.WriteLine(" Mimic Ptolemy ");
                        Console.WriteLine("Enter your month number ranging from 1 to 12: ");
                        int num1 = Convert.ToInt32(Console.ReadLine());
                        switch (num1)
                        {
                            case 1:
                                Console.WriteLine("Your Zodiac is: \"Aries\",Your Funny Partner is : \"Powerstar");
                                break;
                            case 2:
                                Console.WriteLine("Your Zodiac is: \"Taurus\",Your Funny Partner is : \"Batman");
                                break;
                            case 3:
                                Console.WriteLine("Your Zodiac is: \"Gemini\",Your Funny Partner is : \"DoreMon");
                                break;
                            case 4:
                                Console.WriteLine("Your Zodiac is: \"Cancer\",Your Funny Partner is : \"IronMan");
                                break;
                            case 5:
                                Console.WriteLine("Your Zodiac is: \"Leo\",Your Funny Partner is : \"Spiderman");
                                break;
                            case 6:
                                Console.WriteLine("Your Zodiac is: \"Virgo\",Your Funny Partner is : \"Mr.Bean");
                                break;
                            case 7:
                                Console.WriteLine("Your Zodiac is: \"Libra\",Your Funny Partner is : \"Kalia");
                                break;
                            case 9:
                                Console.WriteLine("Your Zodiac is: \"Scorpio\",Your Funny Partner is : \"JeemBoomBoi");
                                break;
                            case 10:
                                Console.WriteLine("Your Zodiac is: \"Sagittarius\",Your Funny Partner is : \"The Legend");
                                break;
                            case 11:
                                Console.WriteLine("Your Zodiac is: \"Capricorn\",Your Funny Partner is : \"Kenichi");
                                break;
                            case 12:
                                Console.WriteLine("Your Zodiac is: \"Pisces\",Your Funny Partner is : \"MGR");
                                break; ;
                            default:
                                Console.WriteLine("specify the correct value");
                                break;

                        }

                        break;
                    case 3:
                        Console.WriteLine(" Calendar man ");
                        Console.WriteLine("enter the year");
                        int year = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter the month");
                        int month = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter the date");
                        int day = Convert.ToInt32(Console.ReadLine());
                        var birthday = new DateTime(year, month, day);
                        int age = (int)((DateTime.Now - birthday).TotalDays / 365.242199);
                        Console.WriteLine("your present age is : "+age);
                        break;
                }
                Console.WriteLine("========================================================");
                Console.WriteLine("do you want to play this game again");
                Console.WriteLine("y to continue, n to quit");
                a1 = Console.ReadLine();
            } while (string.Equals(a1,"y"));
            Console.WriteLine("Thanks for playing! come back again! ");
            Console.WriteLine("=======================================================");
        }
    }
}