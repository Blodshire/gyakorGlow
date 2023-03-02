
/*MAIN*/
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        ExerciseOne();
        ExerciseTwo();
    }

    private static void ExerciseTwo()
    {
        int counter = 0;
        for (int i = 1; i < 101; i++)
        {
            for (int j = i; j < 101; j++)

            {
                if (j != i && IsPrime(i) && IsPrime(j) && Math.Abs(i - j) == 2)
                {
                    Console.WriteLine(i + "," + j);
                    counter++;
                }
            }
        }

        Console.WriteLine("darab: " + counter);
    }

    private static Boolean IsPrimePair(int Number1, int Number2)
    {
        if (Number1 == 1 || Number2 == 1)
        {
            return false;
        }
        for (int i = 2; i < Number1; i++)
        {
            if (Number1 % i == 0)
            {
                return false;
            }
        }

        for (int i = 2; i < Number2; i++)
        {
            if (Number2 % i == 0)
            {
                return false;
            }
        }

        return true;
    }

    private static Boolean IsPrime(int Number)
    {
        if (Number == 1)
            return false;

        for (int i = 2; i < Number / 2 + 1; i++)
        {
            if (Number % i == 0)
                return false;

        }
        return true;
    }


    private static void ExerciseOne()
    {
        //Glória féle
        double leibniz = 0;
        int i = 1;
        double csere = 1;
        double leibnizfinal = 0;

        while (i < 1000)
        {
            leibniz = 1 / csere;

            csere += 2;

            if (i % 2 == 0)
            {
                leibnizfinal -= leibniz;
            }
            else
            {
                leibnizfinal += leibniz;
            }

            i++;

        }
        Console.WriteLine(" az eredmeny: " + leibnizfinal * 4);

        //Boldi-féle 
        int j = 1;
        double piPerFour = 0;
        double divider = 1;
        while (j < 1000)
        {
            if (j % 2 == 0)
            {
                piPerFour -= 1 / divider;
            }
            else
            {
                piPerFour += 1 / divider;
            }
            j++;
            divider += 2;
        }
        Console.WriteLine("A masik(ugyanaz) eredmeny: " + piPerFour * 4);


        double wallis = 0;
        int ii = 0;
        double first = 2;
        double second = 1;
        double wallisfinal = 1;

        while (ii < 1000)
        {

            wallis = first / second;
            wallisfinal *= wallis;

            if (first > second)
            {
                second = second + 2;
            }
            else
            {

                first = first + 2;
            }

            ii++;

        }
        Console.WriteLine("wallis: " + wallisfinal * 2);

        Console.WriteLine("A leibniz a nagybb:" + (leibnizfinal * 4 > wallisfinal * 2));

        bool switchTop = false;
        int jj = 0;
        double top = 2;
        double bot = 1;
        double sumWallis = 1;
        while (jj < 1000)
        {
            sumWallis *= top / bot;
            if (switchTop)
            {
                top += 2;
            }
            else
            {
                bot += 2;
            }
            switchTop = !switchTop;
            jj++;
        }
        Console.WriteLine(sumWallis * 2);

        double myPi = Math.PI;
        double compareLeibniz = leibnizfinal * 4 - myPi;
        double compareWallis = Math.Abs(wallisfinal * 2 - myPi);
        if (compareLeibniz < compareWallis)
        {
            Console.WriteLine("A leibniz van közelebb a pi-hez");
        }
        else if (compareLeibniz > compareWallis)
        {
            Console.WriteLine("A wallis van közelebb a pi-hez");
        }
        else
        {
            Console.WriteLine("Nem tudom miért de egyenlőek");
        }
    }
}

