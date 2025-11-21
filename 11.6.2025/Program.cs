// Task 1
        Console.WriteLine("Enter a number:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        if (num1 % 2 == 0)
            Console.WriteLine($"{num1} is even");
        else
            Console.WriteLine($"{num1} is odd");


        // Task 2
        Console.WriteLine("Enter first number:");
        int t2_num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        int t2_num2 = Convert.ToInt32(Console.ReadLine());
        if (t2_num1 > t2_num2)
            Console.WriteLine($"{t2_num1} > {t2_num2}");
        else if (t2_num2 > t2_num1)
            Console.WriteLine($"{t2_num2} > {t2_num1}");
        else
            Console.WriteLine("These numbers are equal");


        // Task 3
        Console.WriteLine("Enter a number:");
        int t3 = Convert.ToInt32(Console.ReadLine());
        if (t3 > 0)
            Console.WriteLine("Positive");
        else if (t3 < 0)
            Console.WriteLine("Negative");
        else
            Console.WriteLine("Zero");


        // Task 4
        Console.WriteLine("Enter a number:");
        int t4 = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i < t4; i++)
        {
            Console.WriteLine(i);
        }


        // Task 5
        Console.WriteLine("Enter a number:");
        int t5 = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        for (int i = 1; i <= t5; i++)
        {
            sum += i;
        }
        Console.WriteLine(sum);


        // Task 6
        Console.WriteLine("Enter a number:");
        int t6 = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{i} x {t6} = {i * t6}");
        }


        // Task 7
        Console.WriteLine("Enter a number:");
        int t7 = Convert.ToInt32(Console.ReadLine());
        int count = 0;
        while (t7 != 0)
        {
            t7 /= 10;
            count++;
        }
        Console.WriteLine(count);


        // Task 8
        Console.WriteLine("Enter a number:");
        int t8 = Convert.ToInt32(Console.ReadLine());
        int rev = 0;
        int original8 = t8;
        while (t8 != 0)
        {
            int digit = t8 % 10;
            rev = rev * 10 + digit;
            t8 /= 10;
        }
        Console.WriteLine(rev);


        // Task 9
        Console.WriteLine("Enter a number:");
        int t9 = Convert.ToInt32(Console.ReadLine());
        int fact = 1;
        for (int i = 1; i <= t9; i++)
        {
            fact *= i;
        }
        Console.WriteLine(fact);


        // Task 10
        int evenSum = 0, oddSum = 0;
        for (int i = 1; i <= 10; i++)
        {
            if (i % 2 == 0)
                evenSum += i;
            else
                oddSum += i;
        }
        Console.WriteLine("Even sum: " + evenSum);
        Console.WriteLine("Odd sum: " + oddSum);


        // Task 11
        Console.WriteLine("Enter a number:");
        int t11 = Convert.ToInt32(Console.ReadLine());
        int temp = t11;
        int reverse11 = 0;

        while (temp != 0)
        {
            int digit = temp % 10;
            reverse11 = reverse11 * 10 + digit;
            temp /= 10;
        }

        Console.WriteLine(reverse11);

        if (reverse11 == t11)
            Console.WriteLine("Palindrome");
        else
            Console.WriteLine("Not palindrome");


        // Task 13
        Console.WriteLine("Enter a number:");
        int t13 = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= t13; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
                Console.WriteLine(i);
        }


        // Task 15
        string password = "";
        while (password != "Secret123")
        {
            Console.WriteLine("Enter password:");
            password = Console.ReadLine();

            if (password == "Secret123")
                Console.WriteLine("Access granted.");
            else
                Console.WriteLine("Wrong password.");
        }


        // Task 16
        Random random = new Random();
        int secret = random.Next(1, 21);
        int guess;
        Console.WriteLine("Guess number between 1–20");

        do
        {
            Console.Write("Enter guess: ");
            guess = int.Parse(Console.ReadLine());

            if (guess > secret)
                Console.WriteLine("Too high!");
            else if (guess < secret)
                Console.WriteLine("Too low!");
            else
                Console.WriteLine("Correct!");
        }
        while (guess != secret);


        // Task 17
        Console.Write("Enter a number: ");
        int t17 = int.Parse(Console.ReadLine());
        bool prime = true;

        if (t17 <= 1)
            prime = false;
        else
        {
            for (int i = 2; i <= Math.Sqrt(t17); i++)
            {
                if (t17 % i == 0)
                {
                    prime = false;
                    break;
                }
            }
        }

        if (prime)
            Console.WriteLine(t17 + " is prime.");
        else
            Console.WriteLine(t17 + " is not prime.");



        // Task 18
        Console.Write("Enter a number: ");
        int t18 = int.Parse(Console.ReadLine());

        for (int i = 1; i <= t18; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
