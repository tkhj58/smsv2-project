
namespace StudentManagement
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            StudentManagement sms = new StudentManagement();
            UserInterface runit = new UserInterface(sms);
            runit.Run();
        }
    }
}
