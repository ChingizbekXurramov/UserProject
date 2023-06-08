namespace UserProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Start();
        }
        static void Start()
        {
            Console.WriteLine("1. Sign up");
            Console.WriteLine("2. Log in");
            Console.WriteLine("3. Delete user");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Signup();
                    break;
                case "2":
                    Login();
                    break;
                case "3":
                    DeleteUser();
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice! Try again.");
                    break;
            }

            Console.WriteLine();

        }

        static void Signup()
        {
            Console.Write("Enter full name: ");
            string fullName = Console.ReadLine();
            Console.Write("Enter username: ");
            string userName = Console.ReadLine();
            Console.Write("Enter password: ");
            string password = Console.ReadLine();
            Console.Write("Enter phone number: ");
            string phone = Console.ReadLine();

            string path = $@"C:\Users\Hp\Documents\GitHub\3Modul\UserProject\UserProject\bin\Debug\net6.0\{userName + password}.txt";
            File.Create(path).Close();

            using (StreamWriter sw = new StreamWriter(path))
            {
                Console.WriteLine("FullName : " + fullName);
                Console.WriteLine("UserName : " + userName);
                Console.WriteLine("PhoneNumber : " + phone);
                Console.WriteLine("Password : " + password);
            }
            Console.ReadKey();
            Console.WriteLine("Press Enter");
            Start();
            Console.Clear();
        }

        static void Login()
        {
            Console.Write("Enter username: ");
            string userName = Console.ReadLine();
            Console.Write("Enter password: ");
            string password = Console.ReadLine();


            string FileName = userName + password;
            string path = $@"C:\Users\Hp\Documents\GitHub\3Modul\UserProject\UserProject\bin\Debug\net6.0\{FileName}.txt";
            if (File.Exists(path))
            {
                string texts = File.ReadAllText(path);
                Console.WriteLine(texts);
            }
            else
                File.Create(path).Close();
            Console.WriteLine("Invalid username or password. Please try again.");
            Console.ReadKey();
            Console.WriteLine("Press Enter");
            Start();
            Console.Clear();
        }

        static void DeleteUser()
        {
            Console.Write("Enter username of the user to delete: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter your Password - ");
            string password = Console.ReadLine();

            string fileName = userName + password;
            string path = $@"C:\Users\Hp\Documents\GitHub\3Modul\UserProject\UserProject\bin\Debug\net6.0\{fileName}.txt";
            if (File.Exists(path))
            {
                string texts = File.ReadAllText(path);
                Console.WriteLine(texts);
            }
            else
                File.Create(path).Close();
            Console.WriteLine("Do you Delete another Profile  \t >>  1-NO  << \t >> 2 - ");
            int opp = int.Parse(Console.ReadLine());
            switch (opp)
            {
                case 1:
                    File.Delete(path);
                    break;
                case 2:
                    Start();
                    break;
            }
            Console.ReadKey();
            Console.WriteLine("Press Enter");
            Start();
            Console.Clear();
        }
    }
}