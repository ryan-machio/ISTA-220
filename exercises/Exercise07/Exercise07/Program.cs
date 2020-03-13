using System;
using System.Drawing;
using System.Linq;
namespace Exercise07
{
    class RouletteWheel
    {
        static int[] wheel = new int[] { 0, 28, 9, 26, 30, 11, 7, 20, 32, 17, 5, 22, 34, 15, 3, 24, 36, 13, 1, -1, 27, 10, 25, 29, 12, 8, 19, 31, 18, 6, 21, 33, 16, 4, 23, 35, 14, 2 };

        Random random;

        public RouletteWheel(Random random)
        {
            this.random = random;
        }

        public int RandomSlot()
        {
            return random.Next(wheel.Length);
        }

        public static string SlotText(int slot)
        {
            if (wheel[slot] >= 0)
            {
                return wheel[slot].ToString();
            }
            else
            {
                return "00";
            }
        }

        public static Color SlotColor(int slot)
        {
            if (wheel[slot] > 0)
            {
                // Odd Numbers are red, even numbers are black
                return (wheel[slot] % 2 == 0) ? Color.Black : Color.Red;
            }
            else
            {
                // 0 and 00 are green
                return Color.Green;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            RouletteWheel roulette = new RouletteWheel(new Random());
            for (int i = 0; i < 1; i++)
            {
                int slot = roulette.RandomSlot();
                Color color = RouletteWheel.SlotColor(slot);
                string text = RouletteWheel.SlotText(slot);
                Console.WriteLine("{0} {1}", text, color);
            }

            PlaceABet();
        }

        public static void PlaceABet()
        {
            Console.WriteLine("How would you like to bet?  Press any key to view the betting menu.");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Input a character and press enter to pick your bet:" +
                "\nA = Numbers" +
                "\nB = Evens/Odds" +
                "\nC = Lows/Highs" +
                "\nD = Dozens" +
                "\nE = Columns" +
                "\nF = Streets" +
                "\nG = 6 Numbers" +
                "\nH = Split" +
                "\nI = Corner" +
                "\nJ = Reds/Blacks");
            string bet = Console.ReadLine();
            char betChosen = char.Parse(bet);

            if (betChosen == 'A')
                NumbersBets();
            if (betChosen == 'B')
                EvensOdds();
            if (betChosen == 'C')
                LowsHighs();
            if (betChosen == 'D')
                Dozens();
            if (betChosen == 'E')
                Columns();
            if (betChosen == 'J')
                BlacksReds();
            if (betChosen == 'F')
                Street();
            if (betChosen == 'G')
                SixNumbers();
            if (betChosen == 'H')
                split();
            if (betChosen == 'I')
                Corner();
            if (betChosen == 'J')
                Corner();
        }

        public static void NumbersBets()

        {
            Console.WriteLine("Pick a number to bet on between 0 and 36, including 00.");
            int bet = int.Parse(Console.ReadLine());
            int num = 0;
            RouletteWheel roulette = new RouletteWheel(new Random());
            for (int i = 0; i < 1; i++)
            {
                int slot = roulette.RandomSlot();
                Color color = RouletteWheel.SlotColor(slot);
                string text = RouletteWheel.SlotText(slot);
                Console.WriteLine("{0} {1}", text, color);
                num = int.Parse(text);
            }

            if (bet != num)
                Console.WriteLine("You lose!");
            else
                Console.WriteLine("You win!");

            Console.WriteLine($"Your bet was {bet}.  The winning number was {num}");
        }

        static void EvensOdds()
        {

            Console.WriteLine("Input 1 for odd and 2 for even.");
            int bet = int.Parse(Console.ReadLine());
            do
            {
                if (bet == 1)
                {
                    Console.WriteLine("You chose odd.");
                    break;
                }
                else if (bet == 2)
                {
                    Console.WriteLine("You chose even.");
                    break;
                }
                else
                {
                    Console.WriteLine("Please input a correct number for your color choice, 1 for red, 2 for black");
                    bet = int.Parse(Console.ReadLine());
                }
            } while (bet < 1 && bet > 2);

            int num = 0;
            RouletteWheel roulette = new RouletteWheel(new Random());
            for (int i = 0; i < 1; i++)
            {
                int slot = roulette.RandomSlot();
                Color color = RouletteWheel.SlotColor(slot);
                num = slot % 2;

                if (IsEven(num))
                {
                    Console.WriteLine("The winning number is even.");
                    num = 2;
                }
                else
                    num = 1;
            }

            if (bet != num)
                Console.WriteLine("You lose!");
            else
                Console.WriteLine("You win!");
        }

        static void LowsHighs()
        {
            Console.WriteLine("Input 1 for lows (1 - 18), 2 for highs (19 - 36).");
            int bet = int.Parse(Console.ReadLine());
            RouletteWheel rw = new RouletteWheel(new Random());
            int num = 0;

            for (int i = 0; i < 1; i++)
            {
                int slot = rw.RandomSlot();
                Color color = RouletteWheel.SlotColor(slot);
                num = slot;
            }

            if (num >= 1 && num <= 18)
            {
                Console.WriteLine("The ball landed on a low number.");
                num = 1;
            }

            else if (num >= 19 && num <= 37)
            {
                Console.WriteLine("The ball landed on a high number.");
                num = 2;
            }

            if (bet == 1)
            {
                Console.WriteLine("You made a low bet.");
                bet = 1;
            }

            else if (bet == 2)
            {
                Console.WriteLine("You made a high bet.");
            }

            if (num == bet)
                Console.WriteLine("You bet correctly, you win!");
            else
                Console.WriteLine("You lose.");
        }

        static void Dozens()
        {
            Console.WriteLine("Input 1 for the first dozen, 2 for the second dozen, 3 for the third dozen.");
            int bet = int.Parse(Console.ReadLine());
            RouletteWheel rw = new RouletteWheel(new Random());
            for (int i = 0; i < 1; i++)
            {
                int slot = rw.RandomSlot();
                Console.WriteLine($"The ball landed in {slot}.");
                if (slot <= 12)
                {
                    Console.WriteLine("Ball landed in first dozen.");
                    slot = 1;
                }
                if (slot >= 13 && slot <= 24)
                {
                    Console.WriteLine("Ball landed in second dozen.");
                }
                if (slot >= 25)
                {
                    Console.WriteLine("Ball landed in 3rd dozen.");
                    slot = 3;
                }

                if (slot == bet)
                    Console.WriteLine("You won!");
                else
                    Console.WriteLine("You lose.");
            }
        }

        static void Columns()
        {
            Console.WriteLine("Input 1 for the first dozen, 2 for the second dozen, 3 for the third dozen.");
            int bet = int.Parse(Console.ReadLine());

            int num = 0;
            RouletteWheel rw = new RouletteWheel(new Random());
            for (int i = 0; i < 1; i++)
            {
                int slot = rw.RandomSlot();
                num = slot;
            }
            int[] firstCol = { 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34 };
            int[] secondCol = { 2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35 };
            int[] thirdCol = { 3, 6, 9, 12, 15, 18, 21, 24, 30, 33, 36 };

            if (firstCol.Contains(num))
            {
                Console.WriteLine("The ball landed in the first column.");
                num = 1;
            }

            else if (secondCol.Contains(num))
            {
                Console.WriteLine("The ball landed in the second column.");
                num = 2;
            }

            else if (thirdCol.Contains(num))
            {
                Console.WriteLine("The ball landed in the third column.");
                num = 3;
            }

            if (num == bet)
                Console.WriteLine("You won!");
            else
                Console.WriteLine("You lose.");
        }

        static void Street()
        {
            int[] fRow = { 1, 2, 3 };
            int[] fRow2 = { 4, 5, 6 };
            int[] fRow3 = { 7, 8, 9 };
            int[] fRow4 = { 10, 11, 12 };
            int[] fRow5 = { 13, 14, 15 };
            int[] fRow6 = { 16, 17, 18 };
            int[] fRow7 = { 19, 20, 21 };
            int[] fRow8 = { 22, 23, 24 };
            int[] fRow9 = { 25, 26, 27 };
            int[] fRow10 = { 1, 2, 3 };
            int[] fRow11 = { 28, 29, 30 };
            int[] fRow12 = { 31, 32, 33 };
            int[] fRow13 = { 34, 35, 36 };
            Console.WriteLine("Input 1 for the first row, \n2 for the second, \n3 for the third dozen, \n4 for the fourth row, \n5 for the fifth row, \n6 for the sixth row," +
                " \n7 for the seventh row, \n8 for the eigth row, \n9 for the ninth row, \n10 for the tenth row, \n11 for eleventh first row, \n12 for the twelth row, or \n13 for the thirteenth row");
            int bet = int.Parse(Console.ReadLine());
            int num = 0;

            RouletteWheel rw = new RouletteWheel(new Random());
            for (int i = 0; i < 1; i++)
            {
                int slot = rw.RandomSlot();
                num = slot;
            }

            if (fRow.Contains(num))
            {
                Console.WriteLine("The ball landed in the first row.");
                num = 1;
            }
            else if (fRow2.Contains(num))
            {
                Console.WriteLine("The ball landed in the second row."); num = 2;
            }
            else if (fRow3.Contains(num))
            {
                Console.WriteLine("The ball landed in the third row."); num = 3;
            }
            else if (fRow4.Contains(num))
            {
                Console.WriteLine("The ball landed in the fourth row."); num = 4;
            }
            else if (fRow5.Contains(num))
            {
                Console.WriteLine("The ball landed in the fifth row."); num = 5;
            }
            else if (fRow6.Contains(num))
            {
                Console.WriteLine("The ball landed in the sixth row."); num = 6;
            }
            else if (fRow7.Contains(num))
            {
                Console.WriteLine("The ball landed in the seventh row."); num = 7;
            }
            else if (fRow8.Contains(num))
            {
                Console.WriteLine("The ball landed in the eigth row."); num = 8;
            }
            else if (fRow9.Contains(num))
            {
                Console.WriteLine("The ball landed in the ninth row."); num = 9;
            }
            else if (fRow10.Contains(num))
            {
                Console.WriteLine("The ball landed in the tenth row."); num = 10;
            }
            else if (fRow11.Contains(num))
            {
                Console.WriteLine("The ball landed in the eleventh row."); num = 11;
            }
            else if (fRow12.Contains(num))
            {
                Console.WriteLine("The ball landed in the twelth row."); num = 12;
            }
            else if (fRow13.Contains(num))
            {
                Console.WriteLine("The ball landed in the thirteenth row."); num = 13;
            }
            else
            {
            }

            if (num == bet)
                Console.WriteLine("You won!");
            else
                Console.WriteLine("You lose.");
        }

        static void SixNumbers()
        {
            Console.WriteLine("Input 1 for the first dozen" +
                "\n2 for the second dozen" +
                "\n3 for the third dozen" +
                "\n4 for the fourth dozen" +
                "\n5 for the fifth dozen" +
                "\n6 for the sixth dozen.");

            int bet = int.Parse(Console.ReadLine());
            int num = 0;

            RouletteWheel rw = new RouletteWheel(new Random());
            for (int i = 0; i < 1; i++)
            {
                int slot = rw.RandomSlot();
                num = slot;
            }

            int[] fRow = { 1, 2, 3, 4, 5, 6 };
            int[] fRow2 = { 7, 8, 9, 10, 11, 12 };
            int[] fRow3 = { 13, 14, 15, 16, 17, 18 };
            int[] fRow4 = { 19, 20, 21, 22, 23, 24 };
            int[] fRow5 = { 25, 26, 27, 28, 29, 30 };
            int[] fRow6 = { 31, 32, 33, 34, 35, 36 };

            if (fRow.Contains(num))
            {
                Console.WriteLine("The ball landed in the first dozen.");
                num = 1;
            }

            else if (fRow2.Contains(num))
            {
                Console.WriteLine("The ball landed in the second row."); num = 2;
            }

            else if (fRow3.Contains(num))
            {
                Console.WriteLine("The ball landed in the second row."); num = 3;
            }

            else if (fRow4.Contains(num))
            {
                Console.WriteLine("The ball landed in the second row."); num = 4;
            }

            else if (fRow5.Contains(num))
            {
                Console.WriteLine("The ball landed in the second row."); num = 5;
            }

            else if (fRow6.Contains(num))
            {
                Console.WriteLine("The ball landed in the second row."); num = 6;
            }


            if (num == bet)
                Console.WriteLine("You won!");
            else
                Console.WriteLine("You lose.");
        }

        static void split()
        {
            Console.WriteLine("Guess a split between 1 and 32 ");
            int bet = int.Parse(Console.ReadLine());
            int slot = 0;
            int num = 0;
            RouletteWheel rw = new RouletteWheel(new Random());
            for (int i = 0; i < 1; i++)
            {
                slot = rw.RandomSlot();
                num = slot;
            }

            int[] split1 = { 1, 2, 4 };
            int[] split2 = { 3, 2, 3, 6 };
            int[] split3 = {  2, 1 ,  2, 3 , 2, 5  };
            int[] split4 = {  4, 1 ,  4, 5 ,  4, 7  };
            int[] split5 = {  2, 5 ,  5, 4 ,  5, 6 ,  5, 8  };
            int[] split6 = {  3, 6 ,  6, 5 ,  6, 9 } ;
            int[] split7 = {  7, 4 ,  7, 8 ,  7, 10  };
            int[] split8 = {  5, 8 ,  7, 8 ,  8, 9 ,  8, 11  };
            int[] split9 = {  6, 9 ,  8, 9 ,  9, 12  };
            int[] split10 = {  7, 10 ,  10, 11 ,  10, 13  };
            int[] split11 = {  10, 11 ,  11, 8 ,  11, 14 ,  12, 11  };
            int[] split12 = {  11, 12 ,  9, 12 ,  12, 15  };
            int[] split13 = {  10, 13 ,  13, 14 ,  13, 16  };
            int[] split14 = {  16, 17 ,  14, 17 ,  17, 20 ,  17, 18  };
            int[] split15 = {  15, 18 ,  17, 18 ,  18, 21  };
            int[] split16 = { 16, 19 ,  19, 22 , 19, 20  };
            int[] split17 = {  19, 20 ,  17, 14 ,  17, 18 ,  17, 20  };
            int[] split18 = {  20, 21 ,  21, 18 ,  21, 24 } ;
            int[] split19 = {  19, 22 ,  22, 23 ,  22, 25 } ;
            int[] split20 = {  20, 21 ,  21, 18 ,  21, 24 } ;
            int[] split21 = {  22, 19 ,  22, 23 ,  22, 25 } ;
            int[] split23 = {  23, 20 ,  23, 22 ,  23, 24 ,  23, 26  };
            int[] split24 = {  21, 24 ,  23, 24 ,  27, 24  };
            int[] split25 = {  22, 25 ,  26, 25 ,  28, 25  };
            int[] split26 = {  25, 26 ,  23, 26 ,  26, 27 ,  26, 29  };
            int[] split27 = {  24, 27 ,  26, 27 ,  27, 30  };
            int[] split28 = {  28, 31 ,  31, 32 ,  31, 34  };
            int[] split29 = { 32, 29 ,  32, 33 ,  32, 28 ,  32, 35  };
            int[] split30 = {  30, 33 , 33, 32 ,  33, 36  };
            int[] split31 = {  34, 31 ,  34, 35  };
            int[] split32 = {  32, 35 ,  34, 36 ,  35, 36  };
            int[] split33 = {  33, 36 ,  35, 36  };

            if (split1.Contains(num))
            {
                num = slot;
                Console.WriteLine($"The ball landed in the {num} split.");
            }
            else if (split2.Contains(num))
            {
                num = slot;
                Console.WriteLine($"The ball landed in the {num} split.");
            }
            else if (split3.Contains(num))
            {
                num = slot;
                Console.WriteLine($"The ball landed in the {num} split.");
            }
            else if (split4.Contains(num))
            {
                num = slot;
                Console.WriteLine($"The ball landed in the {num} split.");
            }
            else if (split5.Contains(num))
            {
                num = slot;
                Console.WriteLine($"The ball landed in the {num} split.");
            }
            else if (split6.Contains(num))
            {
                num = slot;
                Console.WriteLine($"The ball landed in the {num} split.");
            }
            else if (split7.Contains(num))
            {
                num = slot;
                Console.WriteLine($"The ball landed in the {num} split.");
            }
            else if (split8.Contains(num))
            {
                num = slot;
                Console.WriteLine($"The ball landed in the {num} split.");
            }
            else if (split9.Contains(num))
            {
                num = slot;
                Console.WriteLine($"The ball landed in the {num} split.");
            }
            else if (split10.Contains(num))
            {
                num = slot;
                Console.WriteLine($"The ball landed in the {num} split.");
            }
            else if (split11.Contains(num))
            {
                num = slot;
                Console.WriteLine($"The ball landed in the {num} split.");
            }
            else if (split12.Contains(num))
            {
                num = slot;
                Console.WriteLine($"The ball landed in the {num} split.");
            }
            else if (split13.Contains(num))
            {
                num = slot;
                Console.WriteLine($"The ball landed in the {num} split.");
            }
            else if (split14.Contains(num))
            {
                num = slot;
                Console.WriteLine($"The ball landed in the {num} split.");
            }
            else if (split15.Contains(num))
            {
                num = slot;
                Console.WriteLine($"The ball landed in the {num} split.");
            }
            else if (split16.Contains(num))
            {
                num = slot;
                Console.WriteLine($"The ball landed in the {num} split.");
            }
            else if (split17.Contains(num))
            {
                num = slot;
                Console.WriteLine($"The ball landed in the {num} split.");
            }
            else if (split18.Contains(num))
            {
                num = slot;
                Console.WriteLine($"The ball landed in the {num} split.");
            }
            else if (split19.Contains(num))
            {
                num = slot;
                Console.WriteLine($"The ball landed in the {num} split.");
            }
            else if (split19.Contains(num))
            {
                num = slot;
                Console.WriteLine($"The ball landed in the {num} split.");
            }
            else if (split20.Contains(num))
            {
                num = slot;
                Console.WriteLine($"The ball landed in the {num} split.");
            }
            else if (split21.Contains(num))
            {
                num = slot;
                Console.WriteLine($"The ball landed in the {num} split.");
            }
            else if (split23.Contains(num))
            {
                num = slot;
                Console.WriteLine($"The ball landed in the {num} split.");
            }
            else if (split24.Contains(num))
            {
                num = slot;
                Console.WriteLine($"The ball landed in the {num} split.");
            }
            else if (split25.Contains(num))
            {
                num = slot;
                Console.WriteLine($"The ball landed in the {num} split.");
            }
            else if (split26.Contains(num))
            {
                num = slot;
                Console.WriteLine($"The ball landed in the {num} split.");
            }
            else if (split27.Contains(num))
            {
                num = slot;
                Console.WriteLine($"The ball landed in the {num} split.");
            }
            else if (split28.Contains(num))
            {
                num = slot;
                Console.WriteLine($"The ball landed in the {num} split.");
            }
            else if (split29.Contains(num))
            {
                num = slot;
                Console.WriteLine($"The ball landed in the {num} split.");
            }
            else if (split30.Contains(num))
            {
                num = slot;
                Console.WriteLine($"The ball landed in the {num} split.");
            }
            else if (split31.Contains(num))
            {
                num = slot;
                Console.WriteLine($"The ball landed in the {num} split.");
            }
            else if (split32.Contains(num))
            {
                num = slot;
                Console.WriteLine($"The ball landed in the {num} split.");
            }
            else if (split33.Contains(num))
            {
                num = slot;
                Console.WriteLine($"The ball landed in the {num} split.");
            }
            else
            {
            }

            if (bet == slot)
                Console.WriteLine("You won!");
            else
                Console.WriteLine("You lose.");
        }

        static void Corner()
        {
            Console.WriteLine("Input a number.");
            int guess = Convert.ToInt32(Console.ReadLine());
            int[] winningNumbers = { guess + 1, guess + 2, guess - 1, guess };
            if (guess == 1)
            {
                Console.WriteLine($"The winnning numbers of the corners are: {winningNumbers[0]}, {winningNumbers[1]}, {winningNumbers[3]}, {winningNumbers[guess + 4]}");
            }
            else
            {
                for (int i = 0; i < winningNumbers.Length; i++)
                {
                    Console.WriteLine($"The winnning numbers of the corners are: {winningNumbers[i]}");
                }
            }
        }
        static void BlacksReds()
        {
            Console.WriteLine("Input 1 for red, 2 for black.");
            int bet = int.Parse(Console.ReadLine());
            RouletteWheel rw = new RouletteWheel(new Random());
            int num = 0;

            for (int i = 0; i < 1; i++)
            {
                int slot = rw.RandomSlot();
                num = slot;

                if (IsEven(num) & num < 10 || (num >= 19 && num <= 28))
                {
                    Console.WriteLine($"The ball landed on {slot} and the color is red.");
                    num = 1;
                }
                else
                {
                    Console.WriteLine($"The ball landed on {slot} and the color is black.");
                    num = 2;
                }

                if (num == bet)
                    Console.WriteLine("You win!");
                else
                    Console.WriteLine("You lose.");
            }
        }


        public static bool IsEven(int value)
        {
            return value % 2 == 0;
        }
    }
}