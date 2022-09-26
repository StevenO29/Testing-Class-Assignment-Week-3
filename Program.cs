while (true)
{
    Console.Title = "Class Assignment Week 3";
    Main:
    string restart;
    Console.WriteLine("Testing nomor :");
    Console.WriteLine("1. Deret bilangan ganjil/genap ke input \n2. Deret bilangan dari 2 input (terbesar - terkecil) \n3. Hasil faktorial dari input \n4. Deret kuadrat dari 0 - input \n5. Exit");
    Console.Write("\nPilihan : ");
    int pil = Convert.ToInt32(Console.ReadLine());
    if (pil == 1)
    {
        Console.Clear();
        int counter;
        Console.Write("Input : ");
        int N = Convert.ToInt32(Console.ReadLine());
        Console.Write("Hasil : ");
        if (N % 2 == 0)
        {
            counter = 2;
            while (counter != N)
            {
                Console.Write(counter + ", ");
                counter += 2;
            }
            Console.Write(counter);
        }
        else
        {
            counter = 1;
            while (counter != N)
            {
                Console.Write(counter + ", ");
                counter += 2;
            }
            Console.Write(counter);
        }
        Console.Write("\n\nRestart? (Y/N) \n--> ");
        restart = Console.ReadLine().ToUpper();
        if (restart == "Y")
        {
            Console.Clear();
            goto Main;
        }
        else if (restart == "N")
            System.Environment.Exit(0);
        else
            Console.Write("Yang bener woe :)");
    }
    else if (pil == 2)
    {
        Console.Clear();
        int counter;
        Console.Write("Input bil1 : ");
        int bil1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input bil2 : ");
        int bil2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Hasil : ");
        if (bil1 > bil2)
        {
            counter = bil1;
            while (counter != bil2)
            {
                Console.Write(counter + " ");
                counter -= 1;
            }
            Console.Write(counter);
        }
        else
        {
            counter = bil2;
            while (counter != bil1)
            {
                Console.Write(counter + " ");
                counter -= 1;
            }
            Console.Write(counter);
        }
        Console.Write("\n\nRestart? (Y/N) \n--> ");
        restart = Console.ReadLine().ToUpper();
        if (restart == "Y")
        {
            Console.Clear();
            goto Main;
        }
        else if (restart == "N")
            System.Environment.Exit(0);
        else
            Console.Write("Yang bener woe :)");
    }
    else if (pil == 3)
    {
        Console.Clear();
        int counter = 1;
        Console.Write("Input : ");
        int bil = Convert.ToInt32(Console.ReadLine());
        Console.Write("Hasil : ");
        for (int i = 1; i <= bil; i++)
        {
            counter = counter * i;
            Console.Write(bil - (i - 1));
            if (i != bil)
                Console.Write("*");
        }
        Console.Write(" = " + counter);
        Console.Write("\n\nRestart? (Y/N) \n--> ");
        restart = Console.ReadLine().ToUpper();
        if (restart == "Y")
        {
            Console.Clear();
            goto Main;
        }
        else if (restart == "N")
            System.Environment.Exit(0);
        else
            Console.Write("Yang bener woe :)");
    }
    else if (pil == 4)
    {
        Console.Clear();
        int Hasil;
        Console.Write("Input : ");
        int N = Convert.ToInt32(Console.ReadLine());
        Console.Write("Hasil : ");
        for (int i = 0; i <= N; i++)
        {
            Hasil = i * i;
            Console.Write(Hasil + " ");
        }
        Console.Write("\n\nRestart? (Y/N) \n--> ");
        restart = Console.ReadLine().ToUpper();
        if (restart == "Y")
        {
            Console.Clear();
            goto Main;
        }
        else if (restart == "N")
            System.Environment.Exit(0);
        else
            Console.Write("Yang bener woe :)");
    }
    else if (pil == 5)
    {
        System.Environment.Exit(0);
    }
    else
        Console.Write("Pilih yang bener oi :)\n\n");
}