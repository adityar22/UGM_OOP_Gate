using System;
namespace gate_prjct
{
    public class MMenu
    {
        public string uName;
        public void menu(){
            int input = 0;
                while (input != -1)
                {
                    Console.WriteLine("\n----------------------------------------------------");
                    CCalendar calendar = new CCalendar(DateTime.Now);
                    string schedule = calendar.checkSchedule();
                    Console.WriteLine(schedule);
                    Console.WriteLine("\nGATE's Menu:\n(1) My Diary\n(2) My Schedule\n(3) My Dictionary\n(-1) Logout");
                    Console.WriteLine("----------------------------------------------------\n");
                    Console.WriteLine("Input Your Choice: ");
                    try{
                        input = Convert.ToInt32(Console.ReadLine());
                        switch (input)
                        {
                            case 1:
                                mdiary();
                                break;
                            case 2:
                                mschedule();
                                break;
                            case 3:
                                mdictionary();
                                break;
                            case -1:
                                MLogin login = new MLogin();
                                login.signorlogin();
                                break;
                            default:
                                Console.WriteLine("Your input is invalid!");
                                break;
                        }
                    }catch{
                        Console.WriteLine("Please input a valid option");
                    }
                }
        }
        private void mdiary(){
            MDiary diary = new MDiary();
            diary.uName = uName;
            diary.menu();
        }
        private void mschedule(){
            MCalendar calendar = new MCalendar();
            calendar.uName = uName;
            calendar.menu();
        }
        private void mdictionary(){
            Console.WriteLine("This feature is under construction");
            MDictionary dictionary = new MDictionary();
            //dictionary.menu();
        }
    }
}