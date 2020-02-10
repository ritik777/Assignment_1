using System;
using System.Collections.Generic;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The printed pattern is:");
            Console.WriteLine("   ");
            int n = 5;
            PrintPattern(n);

            Console.WriteLine("   ");

            int n2 = 6;
            Console.WriteLine("The Series till " + n2 + " Terms is as follows : ");
            PrintSeries(n2);
            Console.WriteLine("  ");

            Console.WriteLine(" ");
            string s = "09:15:35PM";
            string t = UsfTime(s);
            Console.WriteLine(t);
            Console.WriteLine("");

            
            int n3 = 110;
            int k = 11;
            Console.WriteLine(" USF numbers between " + n3 + " and " + k+ ":");
            Console.WriteLine(" ");
            UsfNumbers(n3, k);

            Console.WriteLine(" ");
            string[] word = {"abcd", "dcba", "lls", "s", "sssll"};
            //Removing empty spaces
            for (int p = 0; p <= word.Length - 1; p++) {
                word[p] = word[p].Trim();
            }
            Console.WriteLine("Palindrome Pairs are :");
            PalindromePairs(word);
            Console.WriteLine("   ");

            Console.WriteLine("  ");
            int n4 = 5;
            Stones(n4);
            Console.WriteLine(" ");
        }

        private static void PrintPattern(int n)
        {
            try
            {   // initialized variable i
                int i;
                //Ran a loop starting from n and decrementing it by 1 till n reaches 1.
                //This prints n till 1. example if n=4, then loop will print 4 3 2 1.
                for (i = n; i >= 1; i--)
                {
                    Console.Write(i);
                }
                 // Breaking the line
                    Console.WriteLine(" ");
                /*decrementing n by 1 and calling Function again recursively. if previously if it was PrintPatten(5)
                 ,now it will be PrintPattern(4).
                 We will call PrintPattern until n reaches 0, i.e when n=0 we have already printed the pattern*/
             
                    n--;
                if (n != 0)
                {
                    PrintPattern(n);
                }
            }
            catch
            {
                Console.WriteLine("Exception Occured while computing printPattern");
            }
            
        }

        private static void PrintSeries(int n2)
        {
            try
            {/* Breakdown of logic:
                1. Initialized the variable x to 1 ; print it
                2. Initialized i to 2; run a loop till n2; make x = x+i, till i reaches nth term while printing x everytime.
                       
                For instance : if n2=4, then loop will first print x= 1. Then add x = x+i, i.e x = 2+1 = 3.
                        then i will be 3. loop condition(i<=n2) will be checked, i.e 3<=3. Hence x= 3+3 =6 so on*/

                //initializing x to 1
                int x = 1;
                int i; //initializing i here. 
                // print x
                Console.Write(x);
                //iteratively print x=x+i, till i reaches nth term;
                for (i = 2; i <= n2 ; i++)
                {
                    x = x + i;
                    Console.Write("," + x);
                    
                }
            }
            catch
            {
                Console.WriteLine("Exception Occured while computing printSeries");
            }
                    }

        public static string UsfTime(string s)
        {
            try
            {// Breakdown of logic: 
              //Calculated total number of seconds in earth time and divided it according to USF time
                Console.WriteLine("Timing of the planet Earth:  " + s);
                
                //Let us convert it into USF time
                //Splitting the string into hours minutes and seconds and inserting it into the string array.
                String[] seperator = { ":" };
                int count = 4;
                String[] strlist = s.Split(seperator, count, StringSplitOptions.RemoveEmptyEntries);
                //Parsing string into integer to denote x, y and z as the variables containing hours, minutes and seconds respectively
                int x = int.Parse(strlist[0]);
                int y = int.Parse(strlist[1]);
                int z = int.Parse(strlist[2].Substring(0, 2));
                //if the time is in PM we convert it into 24 hours format. i.e addition of 12 to x.
                if (strlist[2].Substring(2) == "PM" && x != 0 && strlist[2].Substring(2)!="AM")
                {
                    x = x + 12;
                }
                
                // Procedure to convert earth time to usf time
                // Converting time to total number of seconds

                int seconds = (x * 3600) + (y * 60) + z;
                int q, r;// q and r are minutes and seconds of USF
                // w is number of hours for USF
                int w = seconds / (60 * 45);

                //w would be 0 if earth's time is at midnight 12am to 12:45 am so we have to take that into consideration
                if (w != 0)
                {
                    int w_rem = seconds - (w * 60 * 45);
                    //calculating minutes for usf
                    q = w_rem / 45;
                    //Calcualating seconds when w is 00
                    r = w_rem - (q * 45);
                }
                else
                {
                    //if w is not 0
                    q = seconds / 45;
                    r = seconds - (q * 45);
                }

                String msg = "The time at USF is: " + w.ToString() + ":" + q.ToString() + ":" + r.ToString() + "";
                

                return msg;
            }
            catch
            {
                Console.WriteLine("Exception Occured while computing UsfTime");
            }
            return null;
        }

        public static void UsfNumbers(int n3, int k)
        {
            try
            {
                int i, j;
                int u = k;
                //This loop iterates from i =1 till i=n3(110) with increment of u(11)
                for (i = 1; i <= n3; i = i + u)
                {
                    //This loop prints one line. i.e from current i till current k.
                    //suppose i is 1 so this loop will print from 1 through k i.e 11 with certain operations
                    /*'U' in place of numbers which are multiple of 3,"S" for 
                    *multiples of 5,"F" for multiples of 7, 'US' in place of numbers which are multiple
                      of 3 and 5, 'SF' in place of numbers which are multiple of 5 and 7 and so on*/
                  
                    for (j = i; j <= k; j++)
                    {
                        if (j % 3 == 0 && j % 5 == 0)
                        {
                            Console.Write(" US ");
                        }
                        else if (j % 5 == 0 && j % 7 == 0)
                        {
                            Console.Write(" SF ");
                        }
                        else if (j % 3 == 0)
                        {
                            Console.Write(" U ");
                        }
                        else if (j % 5 == 0)
                        {
                            Console.Write(" S ");
                        }
                        else if (j % 7 == 0)
                        {
                            Console.Write(" F ");
                        }

                        else
                        {
                            Console.Write(" " + j);
                        }


                    }
                    //we iterate k to k+11.
                    
                    k = k + 11;

                    //now when in first loop i will be 11.
                    //In this case,second loop j would be 11 and it will iterate through (k+11 = 22)
                    //and so on...

                    //this breaks the line
                    Console.WriteLine(" ");


                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing UsfNumbers()");
            }
        }

        public static void PalindromePairs(string[] words)
        {
            try
            {
                int i, j;
                string pal, reverse_str = "", final_str;
                //going through every string in the array
                for (i = 0; i <= words.Length - 1; i++)
                {
                    //checking each string in the array with every other string in the array
                    for (j = 0; j <= words.Length - 1; j++)
                    {
                        //Checking if string is not added to itself or if there are no empty spaces in the string
                        if (i != j && words[i] != "" && words[j] != "")
                        {
                            //adding 2 strings
                            pal = words[i] + words[j];
                            // Converting String to character array and checking for palindrome
                            char[] chars = pal.ToCharArray();
                            //reversing the characters
                            Array.Reverse(chars);
                            //transforming character array to string 
                            reverse_str = new string(chars);
                            //palindrome condition check
                            if (pal == reverse_str)
                            {
                                /* if it is palindrome we get a string with pairs of location of strings
                                 * which when added are palindrome*/
                                final_str = "[" + i.ToString() + "," + j.ToString() + "]"+" ";
                                Console.Write(final_str);
                            }
                        }


                    }


                }
            }
            catch
            {

                Console.WriteLine("Exception occured while computing     PalindromePairs()");
            }
        }

        public static void Stones(int n4)
        {
            try
            {
                /* if number of stones are 3 or less than 3 then player 1 having first chance will definitely win
                 * if number of stones are 4 then player 1 can never win
                 * if number of stones are more than 4, then this algorithm predicts one set where player 1 can win*/
                
                //when number of stones are 4
                if (n4 == 4)
                {
                    Console.WriteLine("False");
                }
                //if number of stones are less than 3
                else if (n4 <= 3)
                { Console.WriteLine("you win in the first attempt!"); }

                // now when number of stones are more than 4
                else
                {
                    int z = n4;
                    // we initialize the list and random number generator
                    List<int> termsList = new List<int>();
                    Random rnd = new Random();

                    // b variable has random integer that is 1 2 or 3
                    int b = rnd.Next(1, 4);
                    //we add random number b to the list that act as number of stones that can be picked at first chance
                    termsList.Add(b);
                    // we subtract random number b(first chance) from total number of stones
                    n4 = n4 - b;

                    //now we check if remaining stones(n4) are greater than 3.
                    while (n4 > 3)
                    {
                        // choose another random variable that is between 1 2 or 3(player 2 chance)
                        int bi = rnd.Next(1, 4);
                        // we add that into list
                        termsList.Add(bi);
                        //we subtract random number(bi) from the remaining stones
                        n4 = n4 - bi;
                        //while condition is checked again untill stones are less than 3
                    }
                    // now we add last remaining stones into the list, after while condition is exhausted
                    termsList.Add(n4);

                    // we count number of elements in the list
                    
                    int q = termsList.Count;

                    /*if number of elements in list is in even number we recursively call stones(n4) function
                    until we get our desired set in which player 1 wins*/
                    if (q % 2 == 0)
                    {
                        Stones(z);
                    }
                    else
                    /* if number of elements in list is in odd number then we got our set
                        (player 1 wins when count of elements in the list is in odd number)*/
                    {
                        Console.WriteLine("Player 1 wins :");
                        Console.Write("[");
                        foreach (int i in termsList)
                        {
                            Console.Write(" "+ i + ",");
                        }
                        Console.Write("]");
                    }
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing Stones()");
            }
        }





    }
}



