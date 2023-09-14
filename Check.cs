namespace LastValidName
{
    internal class Check
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Select Option \n: " +
                "1. To check for first name\n" +
                "2. To check for last name\n");

            int option=Convert.ToInt16(Console.ReadLine());
            switch (option)
            {
                case 1:
                    LastValidName.firstValid();
                    break;
                case 2:
                    LastValidName.lastValid();
                    break;
            }
            
        }
    }
}