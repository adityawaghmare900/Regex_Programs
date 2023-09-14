namespace PasswordCheck
{
    internal class Check
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your choice\n"+
                "1. Minimum 8 characters\n"+
                "2. At least 1 upper case\n"+
                "3. should have 1 numeric number\n"+
                 "4. has exactly 1 special charater\n"+
                 "5. All In Once Cases");


            int choice=Convert.ToInt16(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    PasswordCheck.minumum8charater();
                    break;

                case 2:
                    PasswordCheck.shouldHave1UpperCase();
                    break;

                case 3:
                    PasswordCheck.shouldHave1NumericNumber();
                    break;
                    
                case 4:
                    PasswordCheck.shouldHave1SpecialCharacter();
                    break;

                case 5:
                    PasswordCheck.AllInOneCases();
                    break; 
            }            
            
        }
    }
}