class Program {
    static void Main(string[] args) {
        Console.Write("Input Password x6: ");
        int Password = int.Parse(Console.ReadLine());

            int x1 = Password / 100000 % 10;
            int x2 = Password / 10000% 10;
            int x3 = Password / 1000% 10;
            int x4 = Password / 100% 10;
            int x5 = Password / 10% 10;
            int x6 = Password % 10;

        if (Password >= 0 && Password <= 999999) {
            Console.Write("Input work: ");
            string work = (Console.ReadLine());

        if (work == "FBI") {
                if ((x2 % 2) != 0 && (x4 % 2 == 0 && x4 != 6) && (x1 <= 7 && x1 >= 4))
                    Console.WriteLine("True");
                } else {
                     Console.WriteLine("False");
                }

                }
             }

             }
        


     

